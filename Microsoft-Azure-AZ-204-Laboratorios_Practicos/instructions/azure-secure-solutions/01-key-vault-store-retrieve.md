---
lab:
  topic: Soluciones seguras en Azure
  title: Crear y recuperar secretos de Azure Key Vault
  description: Aprenda cómo crear un almacén de claves y crear y recuperar secretos con la CLI de Azure, y también mediante programación.
  duration: 30 minutes
  level: 400
  islab: true
  primarytopics:
    - Azure
    - Azure Key Vault
---

# Crear y recuperar secretos de Azure Key Vault

En este ejercicio, creará un Azure Key Vault, almacenará secretos usando la CLI de Azure y compilará una aplicación de consola de .NET que pueda crear y recuperar secretos del almacén de claves. Aprenderá cómo configurar la autenticación, administrar secretos mediante programación y limpiar los recursos cuando termine.

Tareas realizadas en este ejercicio:

* Crear recursos de Azure Key Vault
* Almacenar un secreto en un almacén de claves usando la CLI de Azure
* Crear una aplicación de consola de .NET para crear y recuperar secretos
* Limpiar recursos

Este ejercicio tarda aproximadamente **30** minutos en completarse.

## Crear recursos de Azure Key Vault y agregar un secreto

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
    keyVaultName=mykeyvaultname$RANDOM
    ```

1. Ejecute el siguiente comando para obtener el nombre del almacén de claves y registre el nombre. Lo necesitará más adelante en el ejercicio.

    ```
    echo $keyVaultName
    ```

1. Ejecute el siguiente comando para crear un recurso de Azure Key Vault. Esto puede tardar unos minutos en ejecutarse.

    ```
    az keyvault create --name $keyVaultName \
        --resource-group $resourceGroup --location $location
    ```

### Asignar un rol a su nombre de usuario de Microsoft Entra

Para crear y recuperar un secreto, asigne su usuario de Microsoft Entra al rol **Oficial de secretos de Key Vault** (Key Vault Secrets Officer). Esto le da a su cuenta de usuario permiso para configurar, eliminar y enumerar secretos. En un escenario típico, es posible que desee separar las acciones de creación/lectura asignando el **Oficial de secretos de Key Vault** a un grupo, y el **Usuario de secretos de Key Vault** (Key Vault Secrets User, que puede obtener y enumerar secretos) a otro.

1. Ejecute el siguiente comando para recuperar el **userPrincipalName** de su cuenta. Esto representa a quién se asignará el rol.

    ```
    userPrincipal=$(az rest --method GET --url https://graph.microsoft.com/v1.0/me \
        --headers 'Content-Type=application/json' \
        --query userPrincipalName --output tsv)
    ```

1. Ejecute el siguiente comando para recuperar el ID de recurso del almacén de claves. El ID de recurso establece el ámbito para la asignación del rol a un almacén de claves específico.

    ```
    resourceID=$(az keyvault show --resource-group $resourceGroup \
        --name $keyVaultName --query id --output tsv)
    ```

1. Ejecute el siguiente comando para crear y asignar el rol **Oficial de secretos de Key Vault**.

    ```
    az role assignment create --assignee $userPrincipal \
        --role "Key Vault Secrets Officer" \
        --scope $resourceID
    ```

A continuación, agregue un secreto al almacén de claves que creó.

### Agregar y recuperar un secreto con la CLI de Azure

1. Ejecute el siguiente comando para crear un secreto.

    ```
    az keyvault secret set --vault-name $keyVaultName \
        --name "MySecret" --value "My secret value"
    ```

1. Ejecute el siguiente comando para recuperar el secreto y verificar que se haya configurado.

    ```
    az keyvault secret show --name "MySecret" --vault-name $keyVaultName
    ```

    Este comando devuelve un JSON. La última línea contiene la contraseña en texto sin formato.

    ```json
    "value": "My secret value"
    ```

## Crear una aplicación de consola de .NET para almacenar y recuperar secretos

Ahora que los recursos necesarios se han implementado en Azure, el siguiente paso es configurar la aplicación de consola. Los siguientes pasos se realizan en el cloud shell.

>**Sugerencia:** Cambie el tamaño del cloud shell para mostrar más información, y código, arrastrando el borde superior. También puede usar los botones minimizar y maximizar para cambiar entre el cloud shell y la interfaz principal del portal.

1. Ejecute los siguientes comandos para crear un directorio que contenga el proyecto y cámbiese al directorio del proyecto.

    ```
    mkdir keyvault
    cd keyvault
    ```

1. Cree la aplicación de consola de .NET.

    ```
    dotnet new console
    ```

1. Ejecute los siguientes comandos para agregar los paquetes **Azure.Identity** y **Azure.Security.KeyVault.Secrets** al proyecto.

    ```
    dotnet add package Azure.Identity
    dotnet add package Azure.Security.KeyVault.Secrets
    ```

### Agregar el código inicial para el proyecto

1. Ejecute el siguiente comando en el cloud shell para comenzar a editar la aplicación.

    ```
    code Program.cs
    ```

1. Reemplace cualquier contenido existente con el siguiente código. Asegúrese de reemplazar **YOUR-KEYVAULT-NAME** con el nombre real de su almacén de claves.

    ```csharp
    using Azure.Identity;
    using Azure.Security.KeyVault.Secrets;
    
    // Replace YOUR-KEYVAULT-NAME with your actual Key Vault name
    string KeyVaultUrl = "https://YOUR-KEYVAULT-NAME.vault.azure.net/";
    
    
    // ADD CODE TO CREATE A CLIENT
    
    
    
    // ADD CODE TO CREATE A MENU SYSTEM
    
    
    
    // ADD CODE TO CREATE A SECRET
    
    
    
    // ADD CODE TO LIST SECRETS
    
    
    ```

1. Presione **ctrl+s** para guardar sus cambios.

### Agregar código para completar la aplicación

Ahora es el momento de agregar código para completar la aplicación.

1. Busque el comentario **// ADD CODE TO CREATE A CLIENT** y agregue el siguiente código justo después del comentario. Asegúrese de revisar el código y los comentarios.

    ```csharp
    // Configure authentication options for connecting to Azure Key Vault
    DefaultAzureCredentialOptions options = new()
    {
        ExcludeEnvironmentCredential = true,
        ExcludeManagedIdentityCredential = true
    };
    
    // Create the Key Vault client using the URL and authentication credentials
    var client = new SecretClient(new Uri(KeyVaultUrl), new DefaultAzureCredential(options));
    ```

1. Busque el comentario **// ADD CODE TO CREATE A MENU SYSTEM** y agregue el siguiente código justo después del comentario. Asegúrese de revisar el código y los comentarios.

    ```csharp
    // Main application loop - continues until user types 'quit'
    while (true)
    {
        // Display menu options to the user
        Console.Clear();
        Console.WriteLine("\nPlease select an option:");
        Console.WriteLine("1. Create a new secret");
        Console.WriteLine("2. List all secrets");
        Console.WriteLine("Type 'quit' to exit");
        Console.Write("Enter your choice: ");
    
        // Read user input and convert to lowercase for easier comparison
        string? input = Console.ReadLine()?.Trim().ToLower();
        
        // Check if user wants to exit the application
        if (input == "quit")
        {
            Console.WriteLine("Goodbye!");
            break;
        }
    
        // Process the user's menu selection
        switch (input)
        {
            case "1":
                // Call the method to create a new secret
                await CreateSecretAsync(client);
                break;
            case "2":
                // Call the method to list all existing secrets
                await ListSecretsAsync(client);
                break;
            default:
                // Handle invalid input
                Console.WriteLine("Invalid option. Please enter 1, 2, or 'quit'.");
                break;
        }
    }
    ```

1. Busque el comentario **// ADD CODE TO CREATE A SECRET** y agregue el siguiente código justo después del comentario. Asegúrese de revisar el código y los comentarios.

    ```csharp
    async Task CreateSecretAsync(SecretClient client)
    {
        try
        {
            Console.Clear();
            Console.WriteLine("\nCreating a new secret...");
            
            // Get the secret name from user input
            Console.Write("Enter secret name: ");
            string? secretName = Console.ReadLine()?.Trim();
    
            // Validate that the secret name is not empty
            if (string.IsNullOrEmpty(secretName))
            {
                Console.WriteLine("Secret name cannot be empty.");
                return;
            }
            
            // Get the secret value from user input
            Console.Write("Enter secret value: ");
            string? secretValue = Console.ReadLine()?.Trim();
    
            // Validate that the secret value is not empty
            if (string.IsNullOrEmpty(secretValue))
            {
                Console.WriteLine("Secret value cannot be empty.");
                return;
            }
    
            // Create a new KeyVaultSecret object with the provided name and value
            var secret = new KeyVaultSecret(secretName, secretValue);
            
            // Store the secret in Azure Key Vault
            await client.SetSecretAsync(secret);
    
            Console.WriteLine($"Secret '{secretName}' created successfully!");
            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
        }
        catch (Exception ex)
        {
            // Handle any errors that occur during secret creation
            Console.WriteLine($"Error creating secret: {ex.Message}");
        }
    }
    ```

1. Busque el comentario **// ADD CODE TO LIST SECRETS** y agregue el siguiente código justo después del comentario. Asegúrese de revisar el código y los comentarios.

    ```csharp
    async Task ListSecretsAsync(SecretClient client)
    {
        try
        {
            Console.Clear();
            Console.WriteLine("Listing all secrets in the Key Vault...");
            Console.WriteLine("----------------------------------------");
    
            // Get an async enumerable of all secret properties in the Key Vault
            var secretProperties = client.GetPropertiesOfSecretsAsync();
            bool hasSecrets = false;
    
            // Iterate through each secret property to retrieve full secret details
            await foreach (var secretProperty in secretProperties)
            {
                hasSecrets = true;
                try
                {
                    // Retrieve the actual secret value and metadata using the secret name
                    var secret = await client.GetSecretAsync(secretProperty.Name);
                    
                    // Display the secret information to the console
                    Console.WriteLine($"Name: {secret.Value.Name}");
                    Console.WriteLine($"Value: {secret.Value.Value}");
                    Console.WriteLine($"Created: {secret.Value.Properties.CreatedOn}");
                    Console.WriteLine("----------------------------------------");
                }
                catch (Exception ex)
                {
                    // Handle errors for individual secrets (e.g., access denied, secret not found)
                    Console.WriteLine($"Error retrieving secret '{secretProperty.Name}': {ex.Message}");
                    Console.WriteLine("----------------------------------------");
                }
            }
    
            // Inform user if no secrets were found in the Key Vault
            if (!hasSecrets)
            {
                Console.WriteLine("No secrets found in the Key Vault.");
            }
        }
        catch (Exception ex)
        {
            // Handle general errors that occur during the listing operation
            Console.WriteLine($"Error listing secrets: {ex.Message}");
        
        }
        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine();
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

1. Ejecute el siguiente comando para iniciar la aplicación de consola. La aplicación mostrará el sistema de menús para la aplicación.

    ```
    dotnet run
    ```

1. Usted creó un secreto al principio de este ejercicio, ingrese **2** para recuperarlo y mostrarlo.

1. Ingrese **1** y luego ingrese un nombre de secreto y un valor para crear un nuevo secreto.

1. Enumere los secretos nuevamente para ver su nueva adición.

Ingrese **quit** cuando haya terminado con la aplicación.

## Limpiar recursos

Ahora que ha terminado el ejercicio, debe eliminar los recursos de la nube que creó para evitar el uso innecesario de recursos.

1. En su navegador web, vaya al portal de Azure [https://portal.azure.com](https://portal.azure.com); inicie sesión con sus credenciales de Azure si se le solicita.
1. Vaya al grupo de recursos que creó y vea el contenido de los recursos usados en este ejercicio.
1. En la barra de herramientas, seleccione **Eliminar grupo de recursos**.
1. Ingrese el nombre del grupo de recursos y confirme que desea eliminarlo.

> **PRECAUCIÓN:** Al eliminar un grupo de recursos se eliminan todos los recursos que contiene. Si eligió un grupo de recursos existente para este ejercicio, cualquier recurso existente fuera del alcance de este ejercicio también se eliminará.
