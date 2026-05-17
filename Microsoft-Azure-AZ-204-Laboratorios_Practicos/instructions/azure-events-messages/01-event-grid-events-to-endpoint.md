---
lab:
  topic: Eventos y mensajes de Azure
  title: Enrutar eventos a un punto de conexión personalizado con Azure Event Grid
  description: Aprenda cómo usar Azure Event Grid para enrutar eventos a un punto de conexión personalizado.
  duration: 30 minutes
  level: 300
  islab: true
  primarytopics:
    - Azure
    - Azure Event Grid
---

# Enrutar eventos a un punto de conexión personalizado con Azure Event Grid

En este ejercicio, creará un tema de Azure Event Grid y un punto de conexión de aplicación web, y luego compilará una aplicación de consola de .NET que envía eventos personalizados al tema de Event Grid. Aprenderá cómo configurar suscripciones a eventos, autenticarse con Event Grid y verificar que sus eventos se enruten correctamente al punto de conexión visualizándolos en la aplicación web.

Tareas realizadas en este ejercicio:

* Crear recursos de Azure Event Grid
* Habilitar un proveedor de recursos de Event Grid
* Crear un tema en Event Grid
* Crear un punto de conexión de mensajes
* Suscribirse al tema
* Enviar un evento con una aplicación de consola de .NET
* Limpiar recursos

Este ejercicio tarda aproximadamente **30** minutos en completarse.

## Crear recursos de Azure Event Grid

En esta sección del ejercicio, creará los recursos necesarios en Azure con la CLI de Azure.

1. En su navegador web, vaya al portal de Azure [https://portal.azure.com](https://portal.azure.com); inicie sesión con sus credenciales de Azure si se le solicita.

1. Use el botón **[\>_]** a la derecha de la barra de búsqueda en la parte superior de la página para crear un nuevo cloud shell en el portal de Azure, seleccionando un entorno ***Bash***. El cloud shell proporciona una interfaz de línea de comandos en un panel en la parte inferior del portal de Azure. Si se le solicita seleccionar una cuenta de almacenamiento para guardar sus archivos, seleccione **No se requiere cuenta de almacenamiento**, su suscripción y luego seleccione **Aplicar**.

    > **Nota**: Si ha creado previamente un cloud shell que usa un entorno *PowerShell*, cámbielo a ***Bash***.

1. En la barra de herramientas de cloud shell, en el menú **Configuración** (Settings), seleccione **Ir a la versión clásica** (Go to Classic version) (esto es necesario para usar el editor de código).

1. Cree un grupo de recursos para los recursos necesarios para este ejercicio. Si ya tiene un grupo de recursos que desea usar, continúe con el siguiente paso. Reemplace **myResourceGroup** con un nombre que desee usar para el grupo de recursos. Puede reemplazar **eastus** por una región cercana a usted si es necesario.

    ```bash
    az group create --name myResourceGroup --location eastus
    ```

1. Muchos de los comandos requieren nombres únicos y usan los mismos parámetros. Crear algunas variables reducirá los cambios necesarios en los comandos que crean recursos. Ejecute los siguientes comandos para crear las variables necesarias. Reemplace **myResourceGroup** con el nombre que está usando para este ejercicio. Si cambió la ubicación en el paso anterior, realice el mismo cambio en la variable **location**.

    ```bash
    let rNum=$RANDOM
    resourceGroup=myResourceGroup
    location=eastus
    topicName="mytopic-evgtopic-${rNum}"
    siteName="evgsite-${rNum}"
    siteURL="https://${siteName}.azurewebsites.net"
    ```

### Habilitar un proveedor de recursos de Event Grid

Un Proveedor de recursos de Azure es un servicio que define y administra tipos específicos de recursos en Azure. Es lo que usa Azure en segundo plano cuando implementa o administra recursos. Registre el proveedor de recursos de Event Grid con el comando **az provider register**.

```bash
az provider register --namespace Microsoft.EventGrid
```

El registro puede tardar unos minutos en completarse. Puede comprobar el estado con el siguiente comando.

```bash
az provider show --namespace Microsoft.EventGrid --query "registrationState"
```

> **Nota:** Este paso solo es necesario en suscripciones que no hayan usado Event Grid anteriormente.

### Crear un tema en Event Grid

Cree un tema usando el comando **az eventgrid topic create**. El nombre debe ser único porque forma parte de la entrada DNS.

```bash
az eventgrid topic create --name $topicName \
    --location $location \
    --resource-group $resourceGroup
```

### Crear un punto de conexión de mensajes

Antes de suscribirnos al tema personalizado, debemos crear el punto de conexión para el mensaje de evento. Normalmente, el punto de conexión realiza acciones basadas en los datos del evento. El siguiente script usa una aplicación web precompilada que muestra los mensajes de eventos. La solución implementada incluye un plan de App Service, una aplicación web de App Service y el código fuente de GitHub.

1. Ejecute los siguientes comandos para crear un punto de conexión de mensajes. El comando **echo** mostrará la URL del sitio para el punto de conexión.

    ```bash
    az deployment group create \
        --resource-group $resourceGroup \
        --template-uri "https://raw.githubusercontent.com/Azure-Samples/azure-event-grid-viewer/main/azuredeploy.json" \
        --parameters siteName=$siteName hostingPlanName=viewerhost
    
    echo "Your web app URL: ${siteURL}"
    ```

    > **Nota:** Este comando puede tardar unos minutos en completarse.

1. Abra una nueva pestaña en su navegador y vaya a la URL generada al final del script anterior para asegurarse de que la aplicación web se esté ejecutando. Debería ver el sitio sin mensajes mostrados actualmente.

    > **Sugerencia:** Deje el navegador ejecutándose, se usa para mostrar actualizaciones.

### Suscribirse al tema

Se suscribe a un tema de Event Grid para decirle a Event Grid qué eventos desea rastrear y a dónde enviarlos.

1. Suscríbase a un tema usando el comando **az eventgrid event-subscription create**. El siguiente script recupera el ID de suscripción de su cuenta y lo usa en la creación de la suscripción de eventos.

    ```bash
    endpoint="${siteURL}/api/updates"
    topicId=$(az eventgrid topic show --resource-group $resourceGroup \
        --name $topicName --query "id" --output tsv)
    
    az eventgrid event-subscription create \
        --source-resource-id $topicId \
        --name TopicSubscription \
        --endpoint $endpoint
    ```

1. Vea su aplicación web nuevamente y observe que se le ha enviado un evento de validación de suscripción. Seleccione el icono del ojo para expandir los datos del evento. Event Grid envía el evento de validación para que el punto de conexión pueda verificar que desea recibir datos de eventos. La aplicación web incluye código para validar la suscripción.

## Enviar un evento con una aplicación de consola de .NET

Ahora que los recursos necesarios se han implementado en Azure, el siguiente paso es configurar la aplicación de consola. Los siguientes pasos se realizan en el cloud shell.

>**Sugerencia:** Cambie el tamaño del cloud shell para mostrar más información, y código, arrastrando el borde superior. También puede usar los botones minimizar y maximizar para cambiar entre el cloud shell y la interfaz principal del portal.

1. Ejecute los siguientes comandos para crear un directorio que contenga el proyecto y cámbiese al directorio del proyecto.

    ```bash
    mkdir eventgrid
    cd eventgrid
    ```

1. Cree la aplicación de consola de .NET.

    ```bash
    dotnet new console
    ```

1. Ejecute los siguientes comandos para agregar los paquetes **Azure.Messaging.EventGrid** y **dotenv.net** al proyecto.

    ```bash
    dotnet add package Azure.Messaging.EventGrid
    dotnet add package dotenv.net
    ```

### Configurar la aplicación de consola

En esta sección, recupera el punto de conexión del tema y la clave de acceso para que se puedan agregar a un archivo **.env** para almacenar esos secretos.

1. Ejecute los siguientes comandos para recuperar la URL y la clave de acceso del tema que creó anteriormente. Asegúrese de registrar estos valores.

    ```bash
    az eventgrid topic show --name $topicName -g $resourceGroup --query "endpoint" --output tsv
    az eventgrid topic key list --name $topicName -g $resourceGroup --query "key1" --output tsv
    ```

1. Ejecute el siguiente comando para crear el archivo **.env** para guardar los secretos y luego ábralo en el editor de código.

    ```bash
    touch .env
    code .env
    ```

1. Agregue el siguiente código al archivo **.env**. Reemplace **YOUR_TOPIC_ENDPOINT** y **YOUR_TOPIC_ACCESS_KEY** con los valores que registró anteriormente.

    ```
    TOPIC_ENDPOINT="YOUR_TOPIC_ENDPOINT"
    TOPIC_ACCESS_KEY="YOUR_TOPIC_ACCESS_KEY"
    ```

1. Presione **ctrl+s** para guardar el archivo, luego **ctrl+q** para salir del editor.

Ahora es el momento de reemplazar el código de plantilla en el archivo **Program.cs** usando el editor en el cloud shell.

### Agregar el código para el proyecto

1. Ejecute el siguiente comando en el cloud shell para comenzar a editar la aplicación.

    ```bash
    code Program.cs
    ```

1. Reemplace cualquier código existente con el siguiente código. Asegúrese de revisar los comentarios en el código.

    ```csharp
    using dotenv.net; 
    using Azure.Messaging.EventGrid; 
    
    // Load environment variables from .env file
    DotEnv.Load();
    var envVars = DotEnv.Read();
    
    // Start the asynchronous process to send an Event Grid event
    ProcessAsync().GetAwaiter().GetResult();
    
    async Task ProcessAsync()
    {
        // Retrieve Event Grid topic endpoint and access key from environment variables
        var topicEndpoint = envVars["TOPIC_ENDPOINT"];
        var topicKey = envVars["TOPIC_ACCESS_KEY"];
        
        // Check if the required environment variables are set
        if (string.IsNullOrEmpty(topicEndpoint) || string.IsNullOrEmpty(topicKey))
        {
            Console.WriteLine("Please set TOPIC_ENDPOINT and TOPIC_ACCESS_KEY in your .env file.");
            return;
        }
    
        // Create an EventGridPublisherClient to send events to the specified topic
        EventGridPublisherClient client = new EventGridPublisherClient
            (new Uri(topicEndpoint),
            new Azure.AzureKeyCredential(topicKey));
    
        // Create a new EventGridEvent with sample data
        var eventGridEvent = new EventGridEvent(
            subject: "ExampleSubject",
            eventType: "ExampleEventType",
            dataVersion: "1.0",
            data: new { Message = "Hello, Event Grid!" }
        );
    
        // Send the event to Azure Event Grid
        await client.SendEventAsync(eventGridEvent);
        Console.WriteLine("Event sent successfully.");
    }
    ```

1. Presione **ctrl+s** para guardar el archivo, luego **ctrl+q** para salir del editor.

## Iniciar sesión en Azure y ejecutar la aplicación

1. En el panel de la línea de comandos de cloud shell, ingrese el siguiente comando para iniciar sesión en Azure.

    ```
    az login
    ```

    **<font color="red">Debe iniciar sesión en Azure, incluso si la sesión de cloud shell ya está autenticada.</font>**

    > **Nota**: En la mayoría de los escenarios, bastará con usar *az login*. Sin embargo, si tiene suscripciones en varios inquilinos, es posible que deba especificar el inquilino mediante el parámetro *--tenant*. Consulte [Iniciar sesión en Azure interactivamente mediante la CLI de Azure](https://learn.microsoft.com/cli/azure/authenticate-azure-cli-interactively) para obtener más detalles.

1. Ejecute el siguiente comando en el cloud shell para iniciar la aplicación de consola. Verá el mensaje **Event sent successfully.** (Evento enviado correctamente) cuando se envíe el mensaje.

    ```bash
    dotnet run
    ```

1. Vea su aplicación web para ver el evento que acaba de enviar. Seleccione el icono del ojo para expandir los datos del evento.

## Limpiar recursos

Ahora que ha terminado el ejercicio, debe eliminar los recursos de la nube que creó para evitar el uso innecesario de recursos.

1. En su navegador web, vaya al portal de Azure [https://portal.azure.com](https://portal.azure.com); inicie sesión con sus credenciales de Azure si se le solicita.
1. Vaya al grupo de recursos que creó y vea el contenido de los recursos usados en este ejercicio.
1. En la barra de herramientas, seleccione **Eliminar grupo de recursos**.
1. Ingrese el nombre del grupo de recursos y confirme que desea eliminarlo.

> **PRECAUCIÓN:** Al eliminar un grupo de recursos se eliminan todos los recursos que contiene. Si eligió un grupo de recursos existente para este ejercicio, cualquier recurso existente fuera del alcance de este ejercicio también se eliminará.