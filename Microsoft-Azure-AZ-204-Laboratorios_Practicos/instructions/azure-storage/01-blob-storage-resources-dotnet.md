---
lab:
  topic: Azure Storage
  title: Crear recursos de Blob Storage con la biblioteca cliente de .NET
  description: Aprenda cómo usar la biblioteca cliente de .NET para Azure Storage para crear contenedores, cargar y listar blobs, y eliminar contenedores.
  duration: 30 minutes
  level: 400
  islab: true
  primarytopics:
    - .NET
    - Azure
    - Azure Storage
---

# Crear recursos de Blob Storage con la biblioteca cliente de .NET

En este ejercicio, creará una cuenta de Azure Storage y compilará una aplicación de consola en .NET usando la biblioteca cliente de Azure Storage Blob para crear contenedores, cargar archivos en el almacenamiento de blobs, listar blobs y descargar archivos. Aprenderá cómo autenticarse con Azure, realizar operaciones de almacenamiento de blobs mediante programación y verificar los resultados en el portal de Azure.

Tareas realizadas en este ejercicio:

* Preparar los recursos de Azure
* Crear una aplicación de consola para crear y descargar datos
* Ejecutar la aplicación y verificar los resultados
* Limpiar recursos

Este ejercicio tarda aproximadamente **30** minutos en completarse.

## Crear una cuenta de Azure Storage

En esta sección del ejercicio, creará los recursos necesarios en Azure con la CLI de Azure.

1. En su navegador web, vaya al portal de Azure [https://portal.azure.com](https://portal.azure.com); inicie sesión con sus credenciales de Azure si se le solicita.

1. Use el botón **[\>_]** a la derecha de la barra de búsqueda en la parte superior de la página para crear un nuevo cloud shell en el portal de Azure, seleccionando un entorno ***Bash***. El cloud shell proporciona una interfaz de línea de comandos en un panel en la parte inferior del portal de Azure. Si se le solicita seleccionar una cuenta de almacenamiento para guardar sus archivos, seleccione **No se requiere cuenta de almacenamiento**, su suscripción y luego seleccione **Aplicar**.

    > **Nota**: Si ha creado previamente un cloud shell que usa un entorno *PowerShell*, cámbielo a ***Bash***.

1. En la barra de herramientas de cloud shell, en el menú **Configuración** (Settings), seleccione **Ir a la versión clásica** (Go to Classic version) (esto es necesario para usar el editor de código).

1. Cree un grupo de recursos para los recursos necesarios para este ejercicio. Reemplace **myResourceGroup** con un nombre que desee usar para el grupo de recursos. Puede reemplazar **eastus2** por una región cercana a usted si es necesario. Si ya tiene un grupo de recursos que desea usar, continúe con el siguiente paso.

    ```
    az group create --location eastus2 --name myResourceGroup
    ```

1. Muchos de los comandos requieren nombres únicos y usan los mismos parámetros. Crear algunas variables reducirá los cambios necesarios en los comandos que crean recursos. Ejecute los siguientes comandos para crear las variables necesarias. Reemplace **myResourceGroup** con el nombre que está usando para este ejercicio.

    ```
    resourceGroup=myResourceGroup
    location=eastus
    accountName=storageacct$RANDOM
    ```

1. Ejecute los siguientes comandos para crear la cuenta de Azure Storage, cada nombre de cuenta debe ser único. El primer comando crea una variable con un nombre único para su cuenta de almacenamiento. Registre el nombre de su cuenta a partir de la salida del comando **echo**.

    ```
    az storage account create --name $accountName \
        --resource-group $resourceGroup \
        --location $location \
        --sku Standard_LRS 
    
    echo $accountName
    ```

### Asignar un rol a su nombre de usuario de Microsoft Entra

Para permitir que su aplicación cree recursos y elementos, asigne su usuario de Microsoft Entra al rol **Propietario de datos de Storage Blob** (Storage Blob Data Owner). Realice los siguientes pasos en el cloud shell.

>**Sugerencia:** Cambie el tamaño del cloud shell para mostrar más información, y código, arrastrando el borde superior. También puede usar los botones minimizar y maximizar para cambiar entre el cloud shell y la interfaz principal del portal.

1. Ejecute el siguiente comando para recuperar el **userPrincipalName** de su cuenta. Esto representa a quién se asignará el rol.

    ```
    userPrincipal=$(az rest --method GET --url https://graph.microsoft.com/v1.0/me \
        --headers 'Content-Type=application/json' \
        --query userPrincipalName --output tsv)
    ```

1. Ejecute el siguiente comando para recuperar el ID de recurso de la cuenta de almacenamiento. El ID de recurso establece el ámbito para la asignación del rol a un espacio de nombres específico.

    ```
    resourceID=$(az storage account show --name $accountName \
        --resource-group $resourceGroup \
        --query id --output tsv)
    ```
1. Ejecute el siguiente comando para crear y asignar el rol **Propietario de datos de Storage Blob**. Este rol le otorga los permisos para administrar contenedores y elementos.

    ```
    az role assignment create --assignee $userPrincipal \
        --role "Storage Blob Data Owner" \
        --scope $resourceID
    ```

## Crear una aplicación de consola en .NET para crear contenedores y elementos

Ahora que los recursos necesarios se han implementado en Azure, el siguiente paso es configurar la aplicación de consola. Los siguientes pasos se realizan en el cloud shell.

1. Ejecute los siguientes comandos para crear un directorio que contenga el proyecto y cámbiese al directorio del proyecto.

    ```
    mkdir azstor
    cd azstor
    ```

1. Cree la aplicación de consola de .NET.

    ```
    dotnet new console
    ```

1. Ejecute los siguientes comandos para agregar los paquetes necesarios en la aplicación.

    ```
    dotnet add package Azure.Storage.Blobs
    dotnet add package Azure.Identity
    ```

1. Ejecute el siguiente comando para crear una carpeta **data** en su proyecto.

    ```
    mkdir data
    ```

Ahora es el momento de agregar el código para el proyecto.

### Agregar el código inicial para el proyecto

1. Ejecute el siguiente comando en el cloud shell para comenzar a editar la aplicación.

    ```
    code Program.cs
    ```

1. Reemplace cualquier contenido existente con el siguiente código. Asegúrese de revisar los comentarios en el código.

    ```csharp
    using Azure.Storage.Blobs;
    using Azure.Storage.Blobs.Models;
    using Azure.Identity;
    
    Console.WriteLine("Azure Blob Storage exercise\n");
    
    // Create a DefaultAzureCredentialOptions object to configure the DefaultAzureCredential
    DefaultAzureCredentialOptions options = new()
    {
        ExcludeEnvironmentCredential = true,
        ExcludeManagedIdentityCredential = true
    };
    
    // Run the examples asynchronously, wait for the results before proceeding
    await ProcessAsync();
    
    Console.WriteLine("\nPress enter to exit the sample application.");
    Console.ReadLine();
    
    async Task ProcessAsync()
    {
        // CREATE A BLOB STORAGE CLIENT
        
    
    
        // CREATE A CONTAINER
        
    
    
        // CREATE A LOCAL FILE FOR UPLOAD TO BLOB STORAGE
        
    
    
        // UPLOAD THE FILE TO BLOB STORAGE
        
    
    
        // LIST BLOBS IN THE CONTAINER
        
    
    
        // DOWNLOAD THE BLOB TO A LOCAL FILE
        
    
    }
    ```

1. Presione **ctrl+s** para guardar sus cambios y continúe con el siguiente paso.


## Agregar código para completar el proyecto

Durante el resto del ejercicio, agregará código en áreas especificadas para crear la aplicación completa.

1. Busque el comentario **// CREATE A BLOB STORAGE CLIENT** y luego agregue el siguiente código justo debajo del comentario. El **BlobServiceClient** actúa como el punto de entrada principal para administrar contenedores y blobs en una cuenta de almacenamiento. El cliente utiliza *DefaultAzureCredential* para la autenticación. Asegúrese de reemplazar **YOUR_ACCOUNT_NAME** con el nombre que registró anteriormente.

    ```csharp
    // Create a credential using DefaultAzureCredential with configured options
    string accountName = "YOUR_ACCOUNT_NAME"; // Replace with your storage account name
    
    // Use the DefaultAzureCredential with the options configured at the top of the program
    DefaultAzureCredential credential = new DefaultAzureCredential(options);
    
    // Create the BlobServiceClient using the endpoint and DefaultAzureCredential
    string blobServiceEndpoint = $"https://{accountName}.blob.core.windows.net";
    BlobServiceClient blobServiceClient = new BlobServiceClient(new Uri(blobServiceEndpoint), credential);
    ```

1. Presione **ctrl+s** para guardar sus cambios y continúe con el siguiente paso.

1. Busque el comentario **// CREATE A CONTAINER** y luego agregue el siguiente código justo debajo del comentario. La creación de un contenedor incluye la creación de una instancia de la clase **BlobServiceClient** y luego la llamada al método **CreateBlobContainerAsync** para crear el contenedor en su cuenta de almacenamiento. Se agrega un valor GUID al nombre del contenedor para garantizar que sea único. El método **CreateBlobContainerAsync** falla si el contenedor ya existe.

    ```csharp
    // Create a unique name for the container
    string containerName = "wtblob" + Guid.NewGuid().ToString();
    
    // Create the container and return a container client object
    Console.WriteLine("Creating container: " + containerName);
    BlobContainerClient containerClient = 
        await blobServiceClient.CreateBlobContainerAsync(containerName);
    
    // Check if the container was created successfully
    if (containerClient != null)
    {
        Console.WriteLine("Container created successfully, press 'Enter' to continue.");
        Console.ReadLine();
    }
    else
    {
        Console.WriteLine("Failed to create the container, exiting program.");
        return;
    }
    ```

1. Presione **ctrl+s** para guardar sus cambios y continúe con el siguiente paso.

1. Encuentre el comentario **// CREATE A LOCAL FILE FOR UPLOAD TO BLOB STORAGE** y luego agregue el siguiente código justo debajo del comentario. Esto crea un archivo en el directorio de datos que se carga en el contenedor.

    ```csharp
    // Create a local file in the ./data/ directory for uploading and downloading
    Console.WriteLine("Creating a local file for upload to Blob storage...");
    string localPath = "./data/";
    string fileName = "wtfile" + Guid.NewGuid().ToString() + ".txt";
    string localFilePath = Path.Combine(localPath, fileName);
    
    // Write text to the file
    await File.WriteAllTextAsync(localFilePath, "Hello, World!");
    Console.WriteLine("Local file created, press 'Enter' to continue.");
    Console.ReadLine();
    ```

1. Presione **ctrl+s** para guardar sus cambios y continúe con el siguiente paso.

1. Busque el comentario **// UPLOAD THE FILE TO BLOB STORAGE** y luego agregue el siguiente código justo debajo del comentario. El código obtiene una referencia a un objeto **BlobClient** llamando al método **GetBlobClient** en el contenedor creado en la sección anterior. Luego, carga un archivo local generado usando el método **UploadAsync**. Este método crea el blob si aún no existe y lo sobrescribe si es así.

    ```csharp
    // Get a reference to the blob and upload the file
    BlobClient blobClient = containerClient.GetBlobClient(fileName);
    
    Console.WriteLine("Uploading to Blob storage as blob:\n\t {0}", blobClient.Uri);
    
    // Open the file and upload its data
    using (FileStream uploadFileStream = File.OpenRead(localFilePath))
    {
        await blobClient.UploadAsync(uploadFileStream);
        uploadFileStream.Close();
    }
    
    // Verify if the file was uploaded successfully
    bool blobExists = await blobClient.ExistsAsync();
    if (blobExists)
    {
        Console.WriteLine("File uploaded successfully, press 'Enter' to continue.");
        Console.ReadLine();
    }
    else
    {
        Console.WriteLine("File upload failed, exiting program..");
        return;
    }
    ```

1. Presione **ctrl+s** para guardar sus cambios y continúe con el siguiente paso.

1. Busque el comentario **// LIST BLOBS IN THE CONTAINER** y luego agregue el siguiente código justo debajo del comentario. Puede enumerar los blobs en el contenedor con el método **GetBlobsAsync**. En este caso, solo se agregó un blob al contenedor, por lo que la operación de listado devuelve solo ese blob.

    ```csharp
    Console.WriteLine("Listing blobs in container...");
    await foreach (BlobItem blobItem in containerClient.GetBlobsAsync())
    {
        Console.WriteLine("\t" + blobItem.Name);
    }
    
    Console.WriteLine("Press 'Enter' to continue.");
    Console.ReadLine();
    ```

1. Presione **ctrl+s** para guardar sus cambios y continúe con el siguiente paso.

1. Busque el comentario **// DOWNLOAD THE BLOB TO A LOCAL FILE** y luego agregue el siguiente código justo debajo del comentario. El código usa el método **DownloadAsync** para descargar el blob creado anteriormente a su sistema de archivos local. El código de ejemplo agrega un sufijo de "DOWNLOADED" (DESCARGADO) al nombre del blob para que pueda ver ambos archivos en el sistema de archivos local.

    ```csharp
    // Adds the string "DOWNLOADED" before the .txt extension so it doesn't 
    // overwrite the original file
    
    string downloadFilePath = localFilePath.Replace(".txt", "DOWNLOADED.txt");
    
    Console.WriteLine("Downloading blob to: {0}", downloadFilePath);
    
    // Download the blob's contents and save it to a file
    BlobDownloadInfo download = await blobClient.DownloadAsync();
    
    using (FileStream downloadFileStream = File.OpenWrite(downloadFilePath))
    {
        await download.Content.CopyToAsync(downloadFileStream);
    }
    
    Console.WriteLine("Blob downloaded successfully to: {0}", downloadFilePath);
    ```

1. Presione **ctrl+s** para guardar el archivo, luego **ctrl+q** para salir del editor.

## Iniciar sesión en Azure y ejecutar la aplicación

1. En el panel de la línea de comandos del cloud shell, ingrese el siguiente comando para iniciar sesión en Azure.

    ```
    az login
    ```

    **<font color="red">Debe iniciar sesión en Azure, incluso si la sesión de cloud shell ya está autenticada.</font>**

    > **Nota**: En la mayoría de los escenarios, bastará con usar *az login*. Sin embargo, si tiene suscripciones en varios inquilinos, es posible que deba especificar el inquilino mediante el parámetro *--tenant*. Consulte [Iniciar sesión en Azure interactivamente mediante la CLI de Azure](https://learn.microsoft.com/cli/azure/authenticate-azure-cli-interactively) para obtener más detalles.

1. Ejecute el siguiente comando para iniciar la aplicación de consola. La aplicación se pausará muchas veces durante la ejecución esperando a que presione cualquier tecla para continuar. Esto le da la oportunidad de ver los mensajes en el portal de Azure.

    ```
    dotnet run
    ```

1. En el portal de Azure, navegue hasta la cuenta de Azure Storage que creó.

1. Expanda **> Almacenamiento de datos** (Data storage) en la navegación izquierda y seleccione **Contenedores** (Containers).

1. Seleccione el contenedor que creó la aplicación y podrá ver el blob que se cargó.

1. Ejecute los dos comandos a continuación para cambiar al directorio **data** y listar los archivos que se cargaron y descargaron.

    ```
    cd data
    ls
    ```

## Limpiar recursos

Ahora que ha terminado el ejercicio, debe eliminar los recursos de la nube que creó para evitar el uso innecesario de recursos.

1. En su navegador web, vaya al portal de Azure [https://portal.azure.com](https://portal.azure.com); inicie sesión con sus credenciales de Azure si se le solicita.
1. Vaya al grupo de recursos que creó y vea el contenido de los recursos usados en este ejercicio.
1. En la barra de herramientas, seleccione **Eliminar grupo de recursos**.
1. Ingrese el nombre del grupo de recursos y confirme que desea eliminarlo.

> **PRECAUCIÓN:** Al eliminar un grupo de recursos se eliminan todos los recursos que contiene. Si eligió un grupo de recursos existente para este ejercicio, cualquier recurso existente fuera del alcance de este ejercicio también se eliminará.

