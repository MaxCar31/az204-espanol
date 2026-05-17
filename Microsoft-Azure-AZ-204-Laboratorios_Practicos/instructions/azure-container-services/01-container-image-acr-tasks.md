---
lab:
  topic: Servicios de contenedores de Azure
  title: Compilar y ejecutar una imagen de contenedor con Azure Container Registry Tasks
  description: Aprenda cómo usar comandos de la CLI de Azure para compilar y ejecutar imágenes de contenedores con Azure Container Registry Tasks.
  duration: 20 minutes
  level: 300
  islab: true
  primarytopics:
    - Azure
    - Azure Container Registry
---

# Compilar y ejecutar una imagen de contenedor con Azure Container Registry Tasks

En este ejercicio, compilará una imagen de contenedor a partir del código de su aplicación y la enviará a Azure Container Registry usando la CLI de Azure. Aprenderá a preparar su aplicación para la creación de contenedores, crear una instancia de ACR y almacenar su imagen de contenedor en Azure.

Tareas realizadas en este ejercicio:

* Crear un recurso de Azure Container Registry
* Compilar y enviar una imagen desde un Dockerfile
* Verificar los resultados
* Ejecutar la imagen en Azure Container Registry

Este ejercicio tarda aproximadamente **20** minutos en completarse.

>**Importante:** Las ejecuciones de tareas de Azure Container Registry están pausadas temporalmente para los créditos gratuitos de Azure. Este ejercicio requiere un plan de Pago por uso, u otro plan pago.

## Crear un recurso de Azure Container Registry

1. En su navegador web, vaya al portal de Azure [https://portal.azure.com](https://portal.azure.com); inicie sesión con sus credenciales de Azure si se le solicita.

1. Use el botón **[\>_]** a la derecha de la barra de búsqueda en la parte superior de la página para crear un nuevo cloud shell en el portal de Azure, seleccionando un entorno ***Bash***. El cloud shell proporciona una interfaz de línea de comandos en un panel en la parte inferior del portal de Azure. Si se le solicita seleccionar una cuenta de almacenamiento para guardar sus archivos, seleccione **No se requiere cuenta de almacenamiento**, su suscripción y luego seleccione **Aplicar**.

    > **Nota**: Si ha creado previamente un cloud shell que usa un entorno *PowerShell*, cámbielo a ***Bash***.

1. Cree un grupo de recursos para los recursos necesarios para este ejercicio. Reemplace **myResourceGroup** con un nombre que desee usar para el grupo de recursos. Puede reemplazar **eastus** por una región cercana a usted si es necesario. Si ya tiene un grupo de recursos que desea usar, continúe con el siguiente paso.

    ```
    az group create --location eastus --name myResourceGroup
    ```

1. Ejecute el siguiente comando para crear un registro de contenedores básico. El nombre del registro debe ser único dentro de Azure y contener entre 5 y 50 caracteres alfanuméricos en minúscula. Reemplace **myResourceGroup** con el nombre que usó anteriormente y **myContainerRegistry** con un valor único.

    ```bash
    az acr create --resource-group myResourceGroup \
        --name myContainerRegistry --sku Basic
    ```

    > **Nota:** El comando crea un registro *Basic*, una opción optimizada en costos para desarrolladores que aprenden sobre Azure Container Registry.

## Compilar y enviar una imagen desde un Dockerfile

A continuación, compilará y enviará una imagen basada en un Dockerfile.

1. Ejecute el siguiente comando para crear el Dockerfile. El Dockerfile contiene una sola línea que hace referencia a la imagen *hello-world* alojada en Microsoft Container Registry.

    ```bash
    echo FROM mcr.microsoft.com/hello-world > Dockerfile
    ```

1. Ejecute el siguiente comando **az acr build**, que compila la imagen y, después de que la imagen se compile correctamente, la envía a su registro. Reemplace **myContainerRegistry** con el nombre que creó anteriormente.

    ```bash
    az acr build --image sample/hello-world:v1  \
        --registry myContainerRegistry \
        --file Dockerfile .
    ```

    A continuación, se muestra una muestra abreviada del resultado del comando anterior que muestra las últimas líneas con los resultados finales. Puede ver en el campo *repository* que aparece la imagen *sample/hello-word*.

    ```
    - image:
        registry: myContainerRegistry.azurecr.io
        repository: sample/hello-world
        tag: v1
        digest: sha256:92c7f9c92844bbbb5d0a101b22f7c2a7949e40f8ea90c8b3bc396879d95e899a
      runtime-dependency:
        registry: mcr.microsoft.com
        repository: hello-world
        tag: latest
        digest: sha256:92c7f9c92844bbbb5d0a101b22f7c2a7949e40f8ea90c8b3bc396879d95e899a
      git: {}


    Run ID: cf1 was successful after 11s
    ```

## Verificar los resultados

1. Ejecute el siguiente comando para enumerar los repositorios en su registro. Reemplace **myContainerRegistry** con el nombre que creó anteriormente.

    ```bash
    az acr repository list --name myContainerRegistry --output table
    ```

    Salida:

    ```
    Result
    ----------------
    sample/hello-world
    ```

1. Ejecute el siguiente comando para enumerar las etiquetas en el repositorio **sample/hello-world**. Reemplace **myContainerRegistry** con el nombre que usó anteriormente.

    ```bash
    az acr repository show-tags --name myContainerRegistry \
        --repository sample/hello-world --output table
    ```

    Salida:

    ```
    Result
    --------
    v1
    ```

## Ejecutar la imagen en el ACR

1. Ejecute la imagen de contenedor *sample/hello-world:v1* desde su registro de contenedor con el comando **az acr run**. El siguiente ejemplo usa **$Registry** para especificar el registro donde ejecuta el comando. Reemplace **myContainerRegistry** con el nombre que usó anteriormente.

    ```bash
    az acr run --registry myContainerRegistry \
        --cmd '$Registry/sample/hello-world:v1' /dev/null
    ```

    El parámetro **cmd** en este ejemplo ejecuta el contenedor en su configuración predeterminada, pero **cmd** admite otros parámetros de **docker run** o incluso otros comandos de **docker**.

    El siguiente resultado de muestra está abreviado:

    ```
    Packing source code into tar to upload...
    Uploading archived source code from '/tmp/run_archive_ebf74da7fcb04683867b129e2ccad5e1.tar.gz'...
    Sending context (1.855 KiB) to registry: mycontainerre...
    Queued a run with ID: cab
    Waiting for an agent...
    2019/03/19 19:01:53 Using acb_vol_60e9a538-b466-475f-9565-80c5b93eaa15 as the home volume
    2019/03/19 19:01:53 Creating Docker network: acb_default_network, driver: 'bridge'
    2019/03/19 19:01:53 Successfully set up Docker network: acb_default_network
    2019/03/19 19:01:53 Setting up Docker configuration...
    2019/03/19 19:01:54 Successfully set up Docker configuration
    2019/03/19 19:01:54 Logging in to registry: mycontainerregistry008.azurecr.io
    2019/03/19 19:01:55 Successfully logged into mycontainerregistry008.azurecr.io
    2019/03/19 19:01:55 Executing step ID: acb_step_0. Working directory: '', Network: 'acb_default_network'
    2019/03/19 19:01:55 Launching container with name: acb_step_0

    Hello from Docker!
    This message shows that your installation appears to be working correctly.

    2019/03/19 19:01:56 Successfully executed container: acb_step_0
    2019/03/19 19:01:56 Step ID: acb_step_0 marked as successful (elapsed time in seconds: 0.843801)

    Run ID: cab was successful after 6s
    ```

## Limpiar recursos

Ahora que ha terminado el ejercicio, debe eliminar los recursos de la nube que creó para evitar el uso innecesario de recursos.

1. En su navegador web, vaya al portal de Azure [https://portal.azure.com](https://portal.azure.com); inicie sesión con sus credenciales de Azure si se le solicita.
1. Vaya al grupo de recursos que creó y vea el contenido de los recursos usados en este ejercicio.
1. En la barra de herramientas, seleccione **Eliminar grupo de recursos**.
1. Ingrese el nombre del grupo de recursos y confirme que desea eliminarlo.

> **PRECAUCIÓN:** Al eliminar un grupo de recursos se eliminan todos los recursos que contiene. Si eligió un grupo de recursos existente para este ejercicio, cualquier recurso existente fuera del alcance de este ejercicio también se eliminará.
