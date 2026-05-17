---
lab:
  topic: Servicios de contenedores de Azure
  title: Implementar un contenedor en Azure Container Instances usando comandos de la CLI de Azure
  description: Aprenda cómo usar comandos de la CLI de Azure para implementar un contenedor en Azure Container Instances.
  duration: 15 minutes
  level: 300
  islab: true
  primarytopics:
    - Azure
    - Azure Container Instances
---

# Implementar un contenedor en Azure Container Instances usando comandos de la CLI de Azure

En este ejercicio, implementará y ejecutará un contenedor en Azure Container Instances (ACI) usando la CLI de Azure. Aprenderá cómo crear un grupo de contenedores, especificar la configuración del contenedor y verificar que su aplicación en contenedores se esté ejecutando en la nube.

Tareas realizadas en este ejercicio:

* Crear recursos de Azure Container Instance en Azure
* Crear e implementar un contenedor
* Verificar que el contenedor se esté ejecutando

Este ejercicio tarda aproximadamente **15** minutos en completarse.

## Crear un grupo de recursos

1. En su navegador web, vaya al portal de Azure [https://portal.azure.com](https://portal.azure.com); inicie sesión con sus credenciales de Azure si se le solicita.

1. Use el botón **[\>_]** a la derecha de la barra de búsqueda en la parte superior de la página para crear un nuevo cloud shell en el portal de Azure, seleccionando un entorno ***Bash***. El cloud shell proporciona una interfaz de línea de comandos en un panel en la parte inferior del portal de Azure. Si se le solicita seleccionar una cuenta de almacenamiento para guardar sus archivos, seleccione **No se requiere cuenta de almacenamiento**, su suscripción y luego seleccione **Aplicar**.

    > **Nota**: Si ha creado previamente un cloud shell que usa un entorno *PowerShell*, cámbielo a ***Bash***.

1. Cree un grupo de recursos para los recursos necesarios para este ejercicio. Reemplace **myResourceGroup** con un nombre que desee usar para el grupo de recursos. Puede reemplazar **eastus** por una región cercana a usted si es necesario. Si ya tiene un grupo de recursos que desea usar, continúe con el siguiente paso.

    ```
    az group create --location eastus --name myResourceGroup
    ```

## Crear e implementar un contenedor

Puede crear un contenedor proporcionando un nombre, una imagen de Docker y un grupo de recursos de Azure al comando **az container create**. Expone el contenedor a Internet especificando una etiqueta de nombre DNS.

1. Ejecute el siguiente comando para crear un nombre DNS usado para exponer su contenedor a Internet. Su nombre DNS debe ser único, ejecute este comando desde Cloud Shell para crear una variable que contenga un nombre único.

    ```bash
    DNS_NAME_LABEL=aci-example-$RANDOM
    ```

1. Ejecute el siguiente comando para crear una instancia de contenedor. Reemplace **myResourceGroup** y **myLocation** con los valores que usó anteriormente. La operación tarda unos minutos en completarse.

    ```bash
    az container create --resource-group myResourceGroup \
        --name mycontainer \
        --image mcr.microsoft.com/azuredocs/aci-helloworld \
        --ports 80 \
        --dns-name-label $DNS_NAME_LABEL --location myLocation \
        --os-type Linux \
        --cpu 1 \
        --memory 1.5 
    ```

    En el comando anterior, **$DNS_NAME_LABEL** especifica su nombre DNS. El nombre de la imagen, **mcr.microsoft.com/azuredocs/aci-helloworld**, hace referencia a una imagen de Docker que ejecuta una aplicación web básica de Node.js.

Continúe con la siguiente sección después de que haya finalizado el comando **az container create**.

## Verificar que el contenedor se esté ejecutando

Puede verificar el estado de compilación de los contenedores con el comando **az container show**.

1. Ejecute el siguiente comando para verificar el estado de aprovisionamiento del contenedor que creó. Reemplace **myResourceGroup** con el valor que usó anteriormente.

    ```bash
    az container show --resource-group myResourceGroup \
        --name mycontainer \
        --query "{FQDN:ipAddress.fqdn,ProvisioningState:provisioningState}" \
        --out table 
    ```

    Verá el nombre de dominio completo (FQDN) de su contenedor y su estado de aprovisionamiento. Aquí hay un ejemplo.

    ```
    FQDN                                    ProvisioningState
    --------------------------------------  -------------------
    aci-wt.eastus.azurecontainer.io         Succeeded
    ```

    > **Nota:** Si su contenedor está en el estado **Creating** (Creando), espere unos momentos y vuelva a ejecutar el comando hasta que vea el estado **Succeeded** (Correcto).

1. Desde un navegador, navegue hasta el FQDN de su contenedor para verlo ejecutándose. Es posible que reciba una advertencia de que el sitio no es seguro.

## Limpiar recursos

Ahora que ha terminado el ejercicio, debe eliminar los recursos de la nube que creó para evitar el uso innecesario de recursos.

1. En su navegador web, vaya al portal de Azure [https://portal.azure.com](https://portal.azure.com); inicie sesión con sus credenciales de Azure si se le solicita.
1. Vaya al grupo de recursos que creó y vea el contenido de los recursos usados en este ejercicio.
1. En la barra de herramientas, seleccione **Eliminar grupo de recursos**.
1. Ingrese el nombre del grupo de recursos y confirme que desea eliminarlo.

> **PRECAUCIÓN:** Al eliminar un grupo de recursos se eliminan todos los recursos que contiene. Si eligió un grupo de recursos existente para este ejercicio, cualquier recurso existente fuera del alcance de este ejercicio también se eliminará.
