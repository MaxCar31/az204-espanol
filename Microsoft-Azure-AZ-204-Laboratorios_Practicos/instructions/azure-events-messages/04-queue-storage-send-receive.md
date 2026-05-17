---
lab:
  topic: Eventos y mensajes de Azure
  title: Enviar y recibir mensajes desde Azure Queue Storage
  description: Aprenda cómo enviar y recibir mensajes desde Azure Queue Storage con el SDK de .NET Azure.Storage.Queues.
  duration: 30 minutes
  level: 500
  islab: true
  primarytopics:
    - .NET
    - Azure
    - Azure Queue Storage
---

# Enviar y recibir mensajes desde Azure Queue Storage

En este ejercicio, creará y configurará recursos de Azure Queue Storage y luego compilará una aplicación de .NET para enviar y recibir mensajes usando el SDK **Azure.Storage.Queues**. Aprenderá cómo aprovisionar recursos de almacenamiento, administrar mensajes en cola y limpiar su entorno cuando termine.

Tareas realizadas en este ejercicio:

* Crear recursos de Azure Queue Storage
* Asignar un rol a su nombre de usuario de Microsoft Entra
* Crear una aplicación de consola de .NET para enviar y recibir mensajes
* Limpiar recursos

Este ejercicio tarda aproximadamente **30** minutos en completarse.

## Crear recursos de Azure Queue Storage

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
    storAcctName=storactname$RANDOM
    ```

1. Necesitará el nombre asignado a la cuenta de almacenamiento más adelante en este ejercicio. Ejecute el siguiente comando y registre la salida.

    ```
    echo $storAcctName
    ```

1. Ejecute el siguiente comando para crear una cuenta de almacenamiento usando la variable que creó anteriormente. La operación tarda unos minutos en completarse.

    ```bash
    az storage account create --resource-group $resourceGroup \
        --name $storAcctName --location $location --sku Standard_LRS
    ```

### Asignar un rol a su nombre de usuario de Microsoft Entra

Para permitir que su aplicación envíe y reciba mensajes, asigne su usuario de Microsoft Entra al rol **Colaborador de datos de Queue Storage** (Storage Queue Data Contributor). Esto le da a su cuenta de usuario permiso para crear colas y enviar/recibir mensajes usando Azure RBAC. Realice los siguientes pasos en el cloud shell.

1. Ejecute el siguiente comando para recuperar el **userPrincipalName** de su cuenta. Esto representa a quién se asignará el rol.

    ```
    userPrincipal=$(az rest --method GET --url https://graph.microsoft.com/v1.0/me \
        --headers 'Content-Type=application/json' \
        --query userPrincipalName --output tsv)
    ```

1. Ejecute el siguiente comando para recuperar el ID de recurso de la cuenta de almacenamiento. El ID de recurso establece el ámbito para la asignación del rol a un espacio de nombres específico.

    ```
    resourceID=$(az storage account show --resource-group $resourceGroup \
        --name $storAcctName --query id --output tsv)
    ```

1. Ejecute el siguiente comando para crear y asignar el rol **Colaborador de datos de Queue Storage**.

    ```
    az role assignment create --assignee $userPrincipal \
        --role "Storage Queue Data Contributor" \
        --scope $resourceID
    ```

## Crear una aplicación de consola de .NET para enviar y recibir mensajes

Ahora que los recursos necesarios se han implementado en Azure, el siguiente paso es configurar la aplicación de consola. Los siguientes pasos se realizan en el cloud shell.

>**Sugerencia:** Cambie el tamaño del cloud shell para mostrar más información, y código, arrastrando el borde superior. También puede usar los botones minimizar y maximizar para cambiar entre el cloud shell y la interfaz principal del portal.

1. Ejecute los siguientes comandos para crear un directorio que contenga el proyecto y cámbiese al directorio del proyecto.

    ```
    mkdir queuestor
    cd queuestor
    ```

1. Cree la aplicación de consola de .NET.

    ```
    dotnet new console
    ```

1. Ejecute los siguientes comandos para agregar los paquetes **Azure.Storage.Queues** y **Azure.Identity** al proyecto.

    ```
    dotnet add package Azure.Storage.Queues
    dotnet add package Azure.Identity
    ```

### Agregar el código inicial para el proyecto

1. Ejecute el siguiente comando en el cloud shell para comenzar a editar la aplicación.

    ```
    code Program.cs
    ```

1. Reemplace cualquier contenido existente con el siguiente código. Asegúrese de revisar los comentarios en el código y reemplace **<YOUR-STORAGE-ACCT-NAME>** con el nombre de la cuenta de almacenamiento que registró anteriormente.

    ```csharp
    using Azure;
    using Azure.Identity;
    using Azure.Storage.Queues;
    using Azure.Storage.Queues.Models;
    using System;
    using System.Threading.Tasks;
    
    // Create a unique name for the queue
    // TODO: Replace the <YOUR-STORAGE-ACCT-NAME> placeholder 
    string queueName = "myqueue-" + Guid.NewGuid().ToString();
    string storageAccountName = "<YOUR-STORAGE-ACCT-NAME>";
    
    // ADD CODE TO CREATE A QUEUE CLIENT AND CREATE A QUEUE
    
    
    
    // ADD CODE TO SEND AND LIST MESSAGES
    
    
    
    // ADD CODE TO UPDATE A MESSAGE AND LIST MESSAGES
    
    
    
    // ADD CODE TO DELETE MESSAGES AND THE QUEUE
    
    
    ```

1. Presione **ctrl+s** para guardar sus cambios.

### Agregar código para crear un cliente de cola y crear una cola

Ahora es el momento de agregar código para crear el cliente de almacenamiento en cola y crear una cola.

1. Busque el comentario **// ADD CODE TO CREATE A QUEUE CLIENT AND CREATE A QUEUE** y agregue el siguiente código justo después del comentario. Asegúrese de revisar el código y los comentarios.

    ```csharp
    // Create a DefaultAzureCredentialOptions object to exclude certain credentials
    DefaultAzureCredentialOptions options = new()
    {
        ExcludeEnvironmentCredential = true,
        ExcludeManagedIdentityCredential = true
    };
    
    // Instantiate a QueueClient to create and interact with the queue
    QueueClient queueClient = new QueueClient(
        new Uri($"https://{storageAccountName}.queue.core.windows.net/{queueName}"),
        new DefaultAzureCredential(options));
    
    Console.WriteLine($"Creating queue: {queueName}");
    
    // Create the queue
    await queueClient.CreateAsync();
    
    Console.WriteLine("Queue created, press Enter to add messages to the queue...");
    Console.ReadLine();
    ```

1. Presione **ctrl+s** para guardar el archivo y luego continúe con el ejercicio.

### Agregar código para enviar y listar mensajes en una cola

1. Busque el comentario **// ADD CODE TO SEND AND LIST MESSAGES** y agregue el siguiente código justo después del comentario. Asegúrese de revisar el código y los comentarios.

    ```csharp
    // Send several messages to the queue with the SendMessageAsync method.
    await queueClient.SendMessageAsync("Message 1");
    await queueClient.SendMessageAsync("Message 2");
    
    // Send a message and save the receipt for later use
    SendReceipt receipt = await queueClient.SendMessageAsync("Message 3");
    
    Console.WriteLine("Messages added to the queue. Press Enter to peek at the messages...");
    Console.ReadLine();
    
    // Peeking messages lets you view the messages without removing them from the queue.
    
    foreach (var message in (await queueClient.PeekMessagesAsync(maxMessages: 10)).Value)
    {
        Console.WriteLine($"Message: {message.MessageText}");
    }
    
    Console.WriteLine("\nPress Enter to update a message in the queue...");
    Console.ReadLine();
    ```

1. Presione **ctrl+s** para guardar el archivo y luego continúe con el ejercicio.

### Agregar código para actualizar un mensaje y listar los resultados

1. Busque el comentario **// ADD CODE TO UPDATE A MESSAGE AND LIST MESSAGES** y agregue el siguiente código justo después del comentario. Asegúrese de revisar el código y los comentarios.

    ```csharp
    // Update a message with the UpdateMessageAsync method and the saved receipt
    await queueClient.UpdateMessageAsync(receipt.MessageId, receipt.PopReceipt, "Message 3 has been updated");
    
    Console.WriteLine("Message three updated. Press Enter to peek at the messages again...");
    Console.ReadLine();
    
    
    // Peek messages from the queue to compare updated content
    foreach (var message in (await queueClient.PeekMessagesAsync(maxMessages: 10)).Value)
    {
        Console.WriteLine($"Message: {message.MessageText}");
    }
    
    Console.WriteLine("\nPress Enter to delete messages from the queue...");
    Console.ReadLine();
    ```

1. Presione **ctrl+s** para guardar el archivo y luego continúe con el ejercicio.

### Agregar código para eliminar mensajes y la cola

1. Busque el comentario **// ADD CODE TO DELETE MESSAGES AND THE QUEUE** y agregue el siguiente código justo después del comentario. Asegúrese de revisar el código y los comentarios.

    ```csharp
    // Delete messages from the queue with the DeleteMessagesAsync method.
    foreach (var message in (await queueClient.ReceiveMessagesAsync(maxMessages: 10)).Value)
    {
        // "Process" the message
        Console.WriteLine($"Deleting message: {message.MessageText}");
    
        // Let the service know we're finished with the message and it can be safely deleted.
        await queueClient.DeleteMessageAsync(message.MessageId, message.PopReceipt);
    }
    Console.WriteLine("Messages deleted from the queue.");
    Console.WriteLine("\nPress Enter key to delete the queue...");
    Console.ReadLine();
    
    // Delete the queue with the DeleteAsync method.
    Console.WriteLine($"Deleting queue: {queueClient.Name}");
    await queueClient.DeleteAsync();
    
    Console.WriteLine("Done");
    ```

1. Presione **ctrl+s** para guardar el archivo, luego **ctrl+q** para salir del editor.

## Iniciar sesión en Azure y ejecutar la aplicación

1. En el panel de la línea de comandos de cloud shell, ingrese el siguiente comando para iniciar sesión en Azure.

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

1. Expanda **> Almacenamiento de datos** (Data storage) en la navegación izquierda y seleccione **Colas** (Queues).

1. Seleccione la cola que crea la aplicación y podrá ver los mensajes enviados y monitorear lo que está haciendo la aplicación.

## Limpiar recursos

Ahora que ha terminado el ejercicio, debe eliminar los recursos de la nube que creó para evitar el uso innecesario de recursos.

1. En su navegador web, vaya al portal de Azure [https://portal.azure.com](https://portal.azure.com); inicie sesión con sus credenciales de Azure si se le solicita.
1. Vaya al grupo de recursos que creó y vea el contenido de los recursos usados en este ejercicio.
1. En la barra de herramientas, seleccione **Eliminar grupo de recursos**.
1. Ingrese el nombre del grupo de recursos y confirme que desea eliminarlo.

> **PRECAUCIÓN:** Al eliminar un grupo de recursos se eliminan todos los recursos que contiene. Si eligió un grupo de recursos existente para este ejercicio, cualquier recurso existente fuera del alcance de este ejercicio también se eliminará.

