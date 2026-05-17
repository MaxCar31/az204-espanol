---
lab:
  topic: Soluciones seguras en Azure
  title: Recuperar ajustes de configuración desde Azure App Configuration
  description: Aprenda cómo crear un recurso de Azure App Configuration y establecer información de configuración con la CLI de Azure. Luego, use **ConfigurationBuilder** para recuperar la configuración de su aplicación.
  duration: 15 minutes
  level: 400
  islab: true
  primarytopics:
    - Azure
    - Azure App Configuration
---

# Recuperar ajustes de configuración desde Azure App Configuration

En este ejercicio, creará un recurso de Azure App Configuration, almacenará los ajustes de configuración usando la CLI de Azure y compilará una aplicación de consola en .NET que utiliza **ConfigurationBuilder** para recuperar los valores de configuración. Aprenderá cómo organizar la configuración con claves jerárquicas y cómo autenticar su aplicación para acceder a los datos de configuración basados en la nube.

Tareas realizadas en este ejercicio:

* Crear un recurso de Azure App Configuration
* Almacenar información de configuración de la cadena de conexión
* Crear una aplicación de consola en .NET para recuperar la información de configuración
* Limpiar recursos

Este ejercicio tarda aproximadamente **15** minutos en completarse.

## Crear un recurso de Azure App Configuration y agregar información de configuración

En esta sección del ejercicio, creará los recursos necesarios en Azure con la CLI de Azure.

1. En su navegador web, vaya al portal de Azure [https://portal.azure.com](https://portal.azure.com); inicie sesión con sus credenciales de Azure si se le solicita.

1. Use el botón **[\>_]** a la derecha de la barra de búsqueda en la parte superior de la página para crear un nuevo cloud shell en el portal de Azure, seleccionando un entorno ***Bash***. El cloud shell proporciona una interfaz de línea de comandos en un panel en la parte inferior del portal de Azure. Si se le solicita seleccionar una cuenta de almacenamiento para guardar sus archivos, seleccione **No se requiere cuenta de almacenamiento**, su suscripción y luego seleccione **Aplicar**.

    > **Nota**: Si ha creado previamente un cloud shell que usa un entorno *PowerShell*, cámbielo a ***Bash***.

1. En la barra de herramientas de cloud shell, en el menú **Configuración** (Settings), seleccione **Ir a la versión clásica** (Go to Classic version) (esto es necesario para usar el editor de código).

1. Cree un grupo de recursos para los recursos necesarios para este ejercicio. Si ya tiene un grupo de recursos que desea usar, continúe con el siguiente paso. Reemplace **myResourceGroup** con un nombre que desee usar para el grupo de recursos. Puede reemplazar **eastus** por una región cercana a usted si es necesario.

    ```
    az group create --name myResourceGroup --location eastus
    ```

1. Muchos de los comandos requieren nombres únicos y usan los mismos parámetros. Crear algunas variables reducirá los cambios necesarios en los comandos que crean recursos. Ejecute los siguientes comandos para crear las variables necesarias. Reemplace **myResourceGroup** con el nombre que está usando para este ejercicio. Si cambió la ubicación en el paso anterior, realice el mismo cambio en la variable **location**.

    ```
    resourceGroup=myResourceGroup
    location=eastus
    appConfigName=appconfigname$RANDOM
    ```

1. Ejecute el siguiente comando para obtener el nombre del recurso de App Configuration. Registre el nombre, lo necesitará más adelante en el ejercicio.

    ```
    echo $appConfigName
    ```

1. Ejecute el siguiente comando para asegurarse de que el proveedor **Microsoft.AppConfiguration** esté registrado para su suscripción.

    ```
    az provider register --namespace Microsoft.AppConfiguration
    ```

1. El registro puede tardar unos minutos en completarse. Ejecute el siguiente comando para comprobar el estado del registro. Continúe con el siguiente paso cuando los resultados devuelvan **Registered**.

    ```
    az provider show --namespace Microsoft.AppConfiguration --query "registrationState"
    ```

1. Ejecute el siguiente comando para crear un recurso de Azure App Configuration. Esto puede tardar unos minutos en ejecutarse.

    ```
    az appconfig create --location $location \
        --name $appConfigName \
        --resource-group $resourceGroup \
        --sku Free
    ```

    >**Sugerencia:** Si hay un problema al crear el recurso de AppConfig debido a restricciones de cuota al usar el valor de SKU **Free** (Gratis), utilice **Developer** (Desarrollador) en su lugar.
    

### Asignar un rol a su nombre de usuario de Microsoft Entra

Para recuperar la información de configuración, debe asignar a su usuario de Microsoft Entra el rol **Lector de datos de App Configuration** (App Configuration Data Reader).

1. Ejecute el siguiente comando para recuperar el **userPrincipalName** de su cuenta. Esto representa a quién se asignará el rol.

    ```
    userPrincipal=$(az rest --method GET --url https://graph.microsoft.com/v1.0/me \
        --headers 'Content-Type=application/json' \
        --query userPrincipalName --output tsv)
    ```

1. Ejecute el siguiente comando para recuperar el ID de recurso de su servicio App Configuration. El ID de recurso establece el ámbito para la asignación del rol.

    ```
    resourceID=$(az appconfig show --resource-group $resourceGroup \
        --name $appConfigName --query id --output tsv)
    ```

1. Ejecute el siguiente comando para crear y asignar el rol **Lector de datos de App Configuration**.

    ```
    az role assignment create --assignee $userPrincipal \
        --role "App Configuration Data Reader" \
        --scope $resourceID
    ```

A continuación, agregue un marcador de posición de cadena de conexión a App Configuration.

### Agregar información de configuración con la CLI de Azure

En Azure App Configuration, una clave como **Dev:conStr** es una clave jerárquica o de espacio de nombres. Los dos puntos (:) actúan como un delimitador que crea una jerarquía lógica, donde:

* **Dev** representa el espacio de nombres o el prefijo del entorno (lo que indica que esta configuración es para el entorno de Desarrollo)
* **conStr** representa el nombre de la configuración

Esta estructura jerárquica le permite organizar los ajustes de configuración por entorno, característica o componente de la aplicación, lo que facilita la administración y recuperación de las configuraciones relacionadas.

Ejecute el siguiente comando para almacenar el marcador de posición de la cadena de conexión.

```
az appconfig kv set --name $appConfigName \
    --key Dev:conStr \
    --value connectionString \
    --yes
```

Este comando devuelve un JSON. La última línea contiene el valor en texto sin formato.

```json
"value": "connectionString"
```

## Crear una aplicación de consola en .NET para recuperar información de configuración

Ahora que los recursos necesarios se han implementado en Azure, el siguiente paso es configurar la aplicación de consola. Los siguientes pasos se realizan en el cloud shell.

>**Sugerencia:** Cambie el tamaño del cloud shell para mostrar más información, y código, arrastrando el borde superior. También puede usar los botones minimizar y maximizar para cambiar entre el cloud shell y la interfaz principal del portal.

1. Ejecute los siguientes comandos para crear un directorio que contenga el proyecto y cámbiese al directorio del proyecto.

    ```
    mkdir appconfig
    cd appconfig
    ```

1. Cree la aplicación de consola de .NET.

    ```
    dotnet new console
    ```

1. Ejecute los siguientes comandos para agregar los paquetes **Azure.Identity** y **Microsoft.Extensions.Configuration.AzureAppConfiguration** al proyecto.

    ```
    dotnet add package Azure.Identity
    dotnet add package Microsoft.Extensions.Configuration.AzureAppConfiguration
    ```

### Agregar el código para el proyecto

1. Ejecute el siguiente comando en el cloud shell para comenzar a editar la aplicación.

    ```
    code Program.cs
    ```

1. Reemplace cualquier contenido existente con el siguiente código. Asegúrese de reemplazar **YOUR_APP_CONFIGURATION_NAME** con el nombre que registró anteriormente y lea los comentarios en el código.

    ```csharp
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.Configuration.AzureAppConfiguration;
    using Azure.Identity;
    
    // Set the Azure App Configuration endpoint, replace YOUR_APP_CONFIGURATION_NAME
    // with the name of your actual App Configuration service
    
    string endpoint = "https://YOUR_APP_CONFIGURATION_NAME.azconfig.io"; 
    
    // Configure which authentication methods to use
    // DefaultAzureCredential tries multiple auth methods automatically
    DefaultAzureCredentialOptions credentialOptions = new()
    {
        ExcludeEnvironmentCredential = true,
        ExcludeManagedIdentityCredential = true
    };
    
    // Create a configuration builder to combine multiple config sources
    var builder = new ConfigurationBuilder();
    
    // Add Azure App Configuration as a source
    // This connects to Azure and loads configuration values
    builder.AddAzureAppConfiguration(options =>
    {
        
        options.Connect(new Uri(endpoint), new DefaultAzureCredential(credentialOptions));
    });
    
    // Build the final configuration object
    try
    {
        var config = builder.Build();
        
        // Retrieve a configuration value by key name
        Console.WriteLine(config["Dev:conStr"]);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error connecting to Azure App Configuration: {ex.Message}");
    }
    ```

1. Presione **ctrl+s** para guardar el archivo, luego **ctrl+q** para salir del editor.

## Iniciar sesión en Azure y ejecutar la aplicación

1. En el cloud shell, ingrese el siguiente comando para iniciar sesión en Azure.

    ```
    az login
    ```

    **<font color="red">Debe iniciar sesión en Azure, incluso si la sesión de cloud shell ya está autenticada.</font>**

    > **Nota**: En la mayoría de los escenarios, bastará con usar *az login*. Sin embargo, si tiene suscripciones en varios inquilinos, es posible que deba especificar el inquilino mediante el parámetro *--tenant*. Consulte [Iniciar sesión en Azure interactivamente mediante la CLI de Azure](https://learn.microsoft.com/cli/azure/authenticate-azure-cli-interactively) para obtener más detalles.

1. Ejecute el siguiente comando para iniciar la aplicación de consola. La aplicación mostrará el valor **connectionString** que asignó a la configuración **Dev:conStr** anteriormente en el ejercicio.

    ```
    dotnet run
    ```

    La aplicación mostrará el valor **connectionString** que asignó a la configuración **Dev:conStr** anteriormente en el ejercicio.

## Limpiar recursos

Ahora que ha terminado el ejercicio, debe eliminar los recursos de la nube que creó para evitar el uso innecesario de recursos.

1. En su navegador web, vaya al portal de Azure [https://portal.azure.com](https://portal.azure.com); inicie sesión con sus credenciales de Azure si se le solicita.
1. Vaya al grupo de recursos que creó y vea el contenido de los recursos usados en este ejercicio.
1. En la barra de herramientas, seleccione **Eliminar grupo de recursos**.
1. Ingrese el nombre del grupo de recursos y confirme que desea eliminarlo.

> **PRECAUCIÓN:** Al eliminar un grupo de recursos se eliminan todos los recursos que contiene. Si eligió un grupo de recursos existente para este ejercicio, cualquier recurso existente fuera del alcance de este ejercicio también se eliminará.
