---
lab:
  topic: Servicios de contenedores de Azure
  title: Implementar un contenedor en Azure Container Apps con la CLI de Azure
  description: Aprenda cómo usar comandos de la CLI de Azure para crear un entorno seguro de Azure Container Apps e implementar un contenedor.
  duration: 15 minutes
  level: 400
  islab: true
  primarytopics:
    - Azure
    - Azure Container Apps
---

# Implementar un contenedor en Azure Container Apps con la CLI de Azure

En este ejercicio, implementará una aplicación en contenedores en Azure Container Apps usando la CLI de Azure. Aprenderá cómo crear un entorno de aplicaciones de contenedor, implementar su contenedor y verificar que su aplicación se esté ejecutando en Azure.

Tareas realizadas en este ejercicio:

* Crear recursos en Azure
* Crear un entorno de Azure Container Apps
* Implementar una aplicación de contenedor en el entorno

Este ejercicio tarda aproximadamente **15** minutos en completarse.

## Crear un grupo de recursos y preparar el entorno de Azure

1. En su navegador web, vaya al portal de Azure [https://portal.azure.com](https://portal.azure.com); inicie sesión con sus credenciales de Azure si se le solicita.

1. Use el botón **[\>_]** a la derecha de la barra de búsqueda en la parte superior de la página para crear un nuevo cloud shell en el portal de Azure, seleccionando un entorno ***Bash***. El cloud shell proporciona una interfaz de línea de comandos en un panel en la parte inferior del portal de Azure. Si se le solicita seleccionar una cuenta de almacenamiento para guardar sus archivos, seleccione **No se requiere cuenta de almacenamiento**, su suscripción y luego seleccione **Aplicar**.

    > **Nota**: Si ha creado previamente un cloud shell que usa un entorno *PowerShell*, cámbielo a ***Bash***.

1. Cree un grupo de recursos para los recursos necesarios para este ejercicio. Reemplace **myResourceGroup** con un nombre que desee usar para el grupo de recursos. Puede reemplazar **eastus** por una región cercana a usted si es necesario. Si ya tiene un grupo de recursos que desea usar, continúe con el siguiente paso.

    ```azurecli
    az group create --location eastus --name myResourceGroup
    ```

1. Ejecute el siguiente comando para asegurarse de tener instalada la última versión de la extensión Azure Container Apps para la CLI.

    ```azurecli
    az extension add --name containerapp --upgrade
    ```

### Registrar espacios de nombres

Hay dos espacios de nombres que deben registrarse para Azure Container Apps, y debe asegurarse de que estén registrados en los siguientes pasos. Cada registro puede tardar unos minutos en completarse si aún no están configurados en su suscripción.

1. Registre el espacio de nombres **Microsoft.App**.

    ```bash
    az provider register --namespace Microsoft.App
    ```

1. Registre el proveedor **Microsoft.OperationalInsights** para el área de trabajo de Log Analytics de Azure Monitor si no lo ha usado antes.

    ```bash
    az provider register --namespace Microsoft.OperationalInsights
    ```

## Crear un entorno de Azure Container Apps

Un entorno en Azure Container Apps crea un límite seguro alrededor de un grupo de aplicaciones de contenedor. Las aplicaciones de contenedor implementadas en el mismo entorno se implementan en la misma red virtual y escriben registros en la misma área de trabajo de Log Analytics.

1. Cree un entorno con el comando **az containerapp env create**. Reemplace **myResourceGroup** y **myLocation** con los valores que usó anteriormente. La operación tarda unos minutos en completarse.

    ```bash
    az containerapp env create \
        --name my-container-env \
        --resource-group myResourceGroup \
        --location myLocation
    ```

## Implementar una aplicación de contenedor en el entorno

Una vez que el entorno de la aplicación de contenedor termine de implementarse, puede implementar una imagen de contenedor en su entorno.

1. Implemente una imagen de contenedor de aplicación de muestra con el comando **containerapp create**. Reemplace **myResourceGroup** con el valor que usó anteriormente.

    ```bash
    az containerapp create \
        --name my-container-app \
        --resource-group myResourceGroup \
        --environment my-container-env \
        --image mcr.microsoft.com/azuredocs/containerapps-helloworld:latest \
        --target-port 80 \
        --ingress 'external' \
        --query properties.configuration.ingress.fqdn
    ```

    Al establecer **--ingress** en **external**, hace que la aplicación de contenedor esté disponible para solicitudes públicas. El comando devuelve un enlace para acceder a su aplicación.

    ```
    Container app created. Access your app at <url>
    ```

Para verificar la implementación, seleccione la URL devuelta por el comando **az containerapp create** para verificar que la aplicación de contenedor se esté ejecutando.

## Limpiar recursos

Ahora que ha terminado el ejercicio, debe eliminar los recursos de la nube que creó para evitar el uso innecesario de recursos.

1. En su navegador web, vaya al portal de Azure [https://portal.azure.com](https://portal.azure.com); inicie sesión con sus credenciales de Azure si se le solicita.
1. Vaya al grupo de recursos que creó y vea el contenido de los recursos usados en este ejercicio.
1. En la barra de herramientas, seleccione **Eliminar grupo de recursos**.
1. Ingrese el nombre del grupo de recursos y confirme que desea eliminarlo.

> **PRECAUCIÓN:** Al eliminar un grupo de recursos se eliminan todos los recursos que contiene. Si eligió un grupo de recursos existente para este ejercicio, cualquier recurso existente fuera del alcance de este ejercicio también se eliminará.
