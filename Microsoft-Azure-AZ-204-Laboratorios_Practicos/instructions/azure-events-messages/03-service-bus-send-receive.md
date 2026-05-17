---
lab:
  topic: Eventos y mensajes de Azure
  title: Enviar y recibir mensajes de Azure Service Bus
  description: Aprenda cómo enviar y recibir mensajes de Azure Service Bus con el SDK de .NET Azure.Messaging.ServiceBus.
  duration: 30 minutes
  level: 500
  islab: true
  primarytopics:
    - .NET
    - Azure
    - Azure Service Bus
---

# Enviar y recibir mensajes de Azure Service Bus

En este ejercicio, creará y configurará recursos de Azure Service Bus y luego compilará una aplicación de .NET para enviar y recibir mensajes usando el SDK **Azure.Messaging.ServiceBus**. Aprenderá a aprovisionar un espacio de nombres y una cola de Service Bus, asignar permisos e interactuar con mensajes mediante programación.

Tareas realizadas en este ejercicio:

* Crear recursos de Azure Service Bus
* Asignar un rol a su nombre de usuario de Microsoft Entra
* Crear una aplicación de consola de .NET para enviar y recibir mensajes
* Limpiar recursos

Este ejercicio tarda aproximadamente **30** minutos en completarse.

## Crear recursos de Azure Event Hubs

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
    namespaceName=svcbusns$RANDOM
    ```

1. Necesitará el nombre asignado al espacio de nombres más adelante en este ejercicio. Ejecute el siguiente comando y registre la salida.

    ```
    echo $namespaceName
    ```

### Crear un espacio de nombres y una cola de Azure Service Bus

1. Cree un espacio de nombres de mensajería de Service Bus. El siguiente comando crea un espacio de nombres usando la variable que creó anteriormente. La operación tarda unos minutos en completarse.

    ```bash
    az servicebus namespace create \
        --resource-group $resourceGroup \
        --name $namespaceName \
        --location $location
    ```

1. Ahora que se ha creado un espacio de nombres, necesita crear una cola para guardar los mensajes. Ejecute el siguiente comando para crear una cola llamada **myqueue**.

    ```bash
    az servicebus queue create --resource-group $resourceGroup \
        --namespace-name $namespaceName \
        --name myqueue
    ```

### Asignar un rol a su nombre de usuario de Microsoft Entra

Para permitir que su aplicación envíe y reciba mensajes, asigne su usuario de Microsoft Entra al rol **Propietario de los datos de Azure Service Bus** (Azure Service Bus Data Owner) en el nivel del espacio de nombres de Service Bus. Esto le da a su cuenta de usuario permiso para administrar y acceder a colas y temas mediante Azure RBAC. Realice los siguientes pasos en el cloud shell.

1. Ejecute el siguiente comando para recuperar el **userPrincipalName** de su cuenta. Esto representa a quién se asignará el rol.

    ```
    userPrincipal=$(az rest --method GET --url https://graph.microsoft.com/v1.0/me \
        --headers 'Content-Type=application/json' \
        --query userPrincipalName --output tsv)
    ```

1. Ejecute el siguiente comando para recuperar el ID de recurso del espacio de nombres de Service Bus. El ID de recurso establece el ámbito para la asignación del rol a un espacio de nombres específico.

    ```
    resourceID=$(az servicebus namespace show --name $namespaceName \
        --resource-group $resourceGroup \
        --query id --output tsv)
    ```
1. Ejecute el siguiente comando para crear y asignar el rol **Propietario de los datos de Azure Service Bus**.

    ```
    az role assignment create --assignee $userPrincipal \
        --role "Azure Service Bus Data Owner" \
        --scope $resourceID
    ```

## Crear una aplicación de consola de .NET para enviar y recibir mensajes

Ahora que los recursos necesarios se han implementado en Azure, el siguiente paso es configurar la aplicación de consola. Los siguientes pasos se realizan en el cloud shell.

>**Sugerencia:** Cambie el tamaño del cloud shell para mostrar más información, y código, arrastrando el borde superior. También puede usar los botones minimizar y maximizar para cambiar entre el cloud shell y la interfaz principal del portal.

1. Ejecute los siguientes comandos para crear un directorio que contenga el proyecto y cámbiese al directorio del proyecto.

    ```
    mkdir svcbus
    cd svcbus
    ```

1. Cree la aplicación de consola de .NET.

    ```
    dotnet new console
    ```

1. Ejecute los siguientes comandos para agregar los paquetes **Azure.Messaging.ServiceBus** y **Azure.Identity** al proyecto.

    ```
    dotnet add package Azure.Messaging.ServiceBus
    dotnet add package Azure.Identity
    ```

### Agregar el código inicial para el proyecto

1. Ejecute el siguiente comando en el cloud shell para comenzar a editar la aplicación.

    ```
    code Program.cs
    ```

1. Reemplace cualquier contenido existente con el siguiente código. Asegúrese de revisar los comentarios en el código y reemplace **<YOUR-NAMESPACE>** con el espacio de nombres de Service Bus que registró anteriormente.

    ```csharp
    using Azure.Messaging.ServiceBus;
    using Azure.Identity;
    using System.Timers;
    
    
    // TODO: Replace <YOUR-NAMESPACE> with your Service Bus namespace
    string svcbusNameSpace = "<YOUR-NAMESPACE>.servicebus.windows.net";
    string queueName = "myQueue";
    
    
    // ADD CODE TO CREATE A SERVICE BUS CLIENT
    
    
    
    // ADD CODE TO SEND MESSAGES TO THE QUEUE
    
    
    
    // ADD CODE TO PROCESS MESSAGES FROM THE QUEUE
    
    
    
    // Dispose client after use
    await client.DisposeAsync();
    ```

1. Presione **ctrl+s** para guardar sus cambios.

### Agregar código para enviar mensajes a la cola

Ahora es el momento de agregar código para crear el cliente de Service Bus y enviar un lote de mensajes a la cola.

1. Busque el comentario **// ADD CODE TO CREATE A SERVICE BUS CLIENT** y agregue el siguiente código justo después del comentario. Asegúrese de revisar el código y los comentarios.

    ```csharp
    // Create a DefaultAzureCredentialOptions object to configure the DefaultAzureCredential
    DefaultAzureCredentialOptions options = new()
    {
        ExcludeEnvironmentCredential = true,
        ExcludeManagedIdentityCredential = true
    };
    
    // Create a Service Bus client using the namespace and DefaultAzureCredential
    // The DefaultAzureCredential will use the Azure CLI credentials, so ensure you are logged in
    ServiceBusClient client = new(svcbusNameSpace, new DefaultAzureCredential(options));
    ```

1. Busque el comentario **// ADD CODE TO SEND MESSAGES TO THE QUEUE** y agregue el siguiente código justo después del comentario. Asegúrese de revisar el código y los comentarios.

    ```csharp
    // Create a sender for the specified queue
    ServiceBusSender sender = client.CreateSender(queueName);
    
    // create a batch 
    using ServiceBusMessageBatch messageBatch = await sender.CreateMessageBatchAsync();
    
    // number of messages to be sent to the queue
    const int numOfMessages = 3;
    
    for (int i = 1; i <= numOfMessages; i++)
    {
        // try adding a message to the batch
        if (!messageBatch.TryAddMessage(new ServiceBusMessage($"Message {i}")))
        {
            // if it is too large for the batch
            throw new Exception($"The message {i} is too large to fit in the batch.");
        }
    }
    
    try
    {
        // Use the producer client to send the batch of messages to the Service Bus queue
        await sender.SendMessagesAsync(messageBatch);
        Console.WriteLine($"A batch of {numOfMessages} messages has been published to the queue.");
    }
    finally
    {
        // Calling DisposeAsync on client types is required to ensure that network
        // resources and other unmanaged objects are properly cleaned up.
        await sender.DisposeAsync();
    }
    
    Console.WriteLine("Press any key to continue");
    Console.ReadKey();
    ```

1. Presione **ctrl+s** para guardar el archivo y luego continúe con el ejercicio.

### Agregar código para procesar mensajes en la cola

1. Busque el comentario **// ADD CODE TO PROCESS MESSAGES FROM THE QUEUE** y agregue el siguiente código justo después del comentario. Asegúrese de revisar el código y los comentarios.

    ```csharp
    // Create a processor that we can use to process the messages in the queue
    ServiceBusProcessor processor = client.CreateProcessor(queueName, new ServiceBusProcessorOptions());
    
    // Idle timeout in milliseconds, the idle timer will stop the processor if there are no more 
    // messages in the queue to process
    const int idleTimeoutMs = 3000;
    System.Timers.Timer idleTimer = new(idleTimeoutMs);
    idleTimer.Elapsed += async (s, e) =>
    {
        Console.WriteLine($"No messages received for {idleTimeoutMs / 1000} seconds. Stopping processor...");
        await processor.StopProcessingAsync();
    };
    
    try
    {
        // add handler to process messages
        processor.ProcessMessageAsync += MessageHandler;
    
        // add handler to process any errors
        processor.ProcessErrorAsync += ErrorHandler;
    
        // start processing 
        idleTimer.Start();
        await processor.StartProcessingAsync();
    
        Console.WriteLine($"Processor started. Will stop after {idleTimeoutMs / 1000} seconds of inactivity.");
        // Wait for the processor to stop
        while (processor.IsProcessing)
        {
            await Task.Delay(500);
        }
        idleTimer.Stop();
        Console.WriteLine("Stopped receiving messages");
    }
    finally
    {
        // Dispose processor after use
        await processor.DisposeAsync();
    }
    
    // handle received messages
    async Task MessageHandler(ProcessMessageEventArgs args)
    {
        string body = args.Message.Body.ToString();
        Console.WriteLine($"Received: {body}");
    
        // Reset the idle timer on each message
        idleTimer.Stop();
        idleTimer.Start();
    
        // complete the message. message is deleted from the queue. 
        await args.CompleteMessageAsync(args.Message);
    }
    
    // handle any errors when receiving messages
    Task ErrorHandler(ProcessErrorEventArgs args)
    {
        Console.WriteLine(args.Exception.ToString());
        return Task.CompletedTask;
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

1. Ejecute el siguiente comando para iniciar la aplicación de consola. La aplicación se pausará en varias etapas y le pedirá que presione una tecla para continuar. Esto le da la oportunidad de ver los mensajes en el portal de Azure.

    ```
    dotnet run
    ```

    

1. En el portal de Azure, navegue hasta el espacio de nombres de Service Bus que creó.

1. Seleccione **myqueue** en la parte inferior de la ventana **Información general** (Overview).

1. Seleccione **Service Bus Explorer** en el panel de navegación izquierdo.

1. Seleccione **Inspeccionar desde el principio** (Peek from start) y los tres mensajes deberían aparecer después de unos segundos.

1. En el cloud shell, presione cualquier tecla para continuar y la aplicación procesará los tres mensajes.

1. Regrese al portal después de que la aplicación haya terminado de procesar los mensajes. Seleccione **Inspeccionar desde el principio** (Peek from start) nuevamente y observe que no hay mensajes en la cola.

## Limpiar recursos

Ahora que ha terminado el ejercicio, debe eliminar los recursos de la nube que creó para evitar el uso innecesario de recursos.

1. En su navegador web, vaya al portal de Azure [https://portal.azure.com](https://portal.azure.com); inicie sesión con sus credenciales de Azure si se le solicita.
1. Vaya al grupo de recursos que creó y vea el contenido de los recursos usados en este ejercicio.
1. En la barra de herramientas, seleccione **Eliminar grupo de recursos**.
1. Ingrese el nombre del grupo de recursos y confirme que desea eliminarlo.

> **PRECAUCIÓN:** Al eliminar un grupo de recursos se eliminan todos los recursos que contiene. Si eligió un grupo de recursos existente para este ejercicio, cualquier recurso existente fuera del alcance de este ejercicio también se eliminará.

