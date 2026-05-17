---
lab:
  topic: Application Insights
  title: Monitorear una aplicación con autoinstrumentación
  description: 'Aprenda cómo monitorear una aplicación en Application Insights sin modificar el código configurando la autoinstrumentación'
  duration: 20 minutes
  level: 300
  islab: true
---

# Monitorear una aplicación con autoinstrumentación

En este ejercicio, creará una aplicación web de Azure App Service con Application Insights habilitado, configurará la autoinstrumentación sin modificar el código, creará e implementará una aplicación Blazor y luego verá las métricas de la aplicación y los datos de error en Application Insights. Implementar un monitoreo y observabilidad exhaustivos de la aplicación, sin tener que hacer cambios en su código, simplifica las implementaciones y migraciones.

Tareas realizadas en este ejercicio:

* Crear un recurso de aplicación web con Application Insights habilitado
* Configurar la instrumentación para la aplicación web.
* Crear una nueva aplicación Blazor e implementarla en el recurso de la aplicación web.
* Ver la actividad de la aplicación en Application Insights
* Limpiar recursos

Este ejercicio tarda aproximadamente **20** minutos en completarse.

## Crear recursos en Azure

1. En su navegador web, vaya al portal de Azure [https://portal.azure.com](https://portal.azure.com); inicie sesión con sus credenciales de Azure si se le solicita.
1. Seleccione **+ Crear un recurso** ubicado en el encabezado **Servicios de Azure** cerca de la parte superior de la página de inicio.
1. En la barra de búsqueda **Buscar en el Marketplace**, ingrese *web app* y presione **Enter** para comenzar la búsqueda.
1. En el mosaico de Web App, seleccione el menú desplegable **Crear** y luego seleccione **Web App**.

    ![Captura de pantalla del mosaico de Web App.](./media/create-web-app-tile.png)

Al seleccionar **Crear** se abrirá una plantilla con algunas pestañas para completar con información sobre su implementación. Los siguientes pasos lo guían sobre qué cambios hacer en las pestañas relevantes.

1. Complete la pestaña **Conceptos básicos** (Basics) con la información de la siguiente tabla:

    | Configuración | Acción |
    |--|--|
    | **Suscripción** | Conserve el valor predeterminado. |
    | **Grupo de recursos** | Seleccione Crear nuevo, ingrese `rg-WebApp` y luego seleccione Aceptar. También puede seleccionar un grupo de recursos existente si lo prefiere. |
    | **Nombre** | Ingrese un nombre único, por ejemplo **TUS-INICIALES-monitorapp**. Reemplace **TUS-INICIALES** con sus iniciales o algún otro valor. El nombre debe ser único, por lo que es posible que requiera algunos cambios. |
    | Control deslizante debajo de **Nombre** | Seleccione el control deslizante para desactivarlo. Este control deslizante solo aparece en algunas configuraciones de Azure. |
    | **Publicar** | Seleccione la opción **Código** (Code). |
    | **Pila de tiempo de ejecución** | Seleccione **.NET 8 (LTS)** en el menú desplegable. |
    | **Sistema operativo** | Seleccione **Windows**. |
    | **Región** | Conserve la selección predeterminada o elija una región cercana a usted. |
    | **Plan de Windows** | Conserve la selección predeterminada. |
    | **Plan de precios** | Seleccione el menú desplegable y elija el plan **Gratis F1** (Free F1). |

1. Seleccione, o navegue a, la pestaña **Monitor + seguro** (Monitor + secure) e ingrese la información de la siguiente tabla:

    | Configuración | Acción |
    |--|--|
    | **Habilitar Application Insights** | Seleccione **Sí**. |
    | **Application Insights** | Seleccione **Crear nuevo** y aparecerá un cuadro de diálogo. Ingrese `autoinstrument-insights` en el campo **Nombre** del cuadro de diálogo. Luego seleccione **Aceptar** para aceptar el nombre. |
    | **Área de trabajo** | Ingrese `Workspace` si el campo aún no está completo y bloqueado. |

1. Seleccione **Revisar y crear** (Review + create) y revise los detalles de su implementación. Luego seleccione **Crear** para crear los recursos.

La implementación tardará unos minutos en completarse. Cuando termine, seleccione el botón **Ir al recurso**.

### Configurar los ajustes de instrumentación

Para habilitar el monitoreo sin realizar cambios en su código, debe configurar la instrumentación para su aplicación a nivel de servicio.

1. En el menú de navegación izquierdo expanda **Supervisión** (Monitoring) y seleccione **Application Insights**.

1. Busque la sección **Instrumentar su aplicación** (Instrument your application) y seleccione **.NET Core**.

1. Seleccione **Recomendado** en la sección **Nivel de recopilación** (Collection level).

1. Seleccione **Aplicar** y luego confirme los cambios.

1. En el menú de navegación izquierdo, seleccione **Información general** (Overview).

## Crear e implementar una aplicación Blazor

En esta sección del ejercicio, creará una aplicación Blazor en Cloud Shell y la implementará en la aplicación web que creó. Todos los pasos de esta sección se realizan en Cloud Shell.

1. Use el botón **[\>_]** a la derecha de la barra de búsqueda en la parte superior de la página para crear un nuevo cloud shell en el portal de Azure, seleccionando un entorno ***Bash***. El cloud shell proporciona una interfaz de línea de comandos en un panel en la parte inferior del portal de Azure. Si se le solicita seleccionar una cuenta de almacenamiento para guardar sus archivos, seleccione **No se requiere cuenta de almacenamiento**, su suscripción y luego seleccione **Aplicar**.

    > **Nota**: Si ha creado previamente un cloud shell que usa un entorno *PowerShell*, cámbielo a ***Bash***.

1. Ejecute los siguientes comandos para crear un directorio para la aplicación Blazor y cambiar a ese directorio.

    ```
    mkdir blazor
    cd blazor
    ```

1. Ejecute el siguiente comando para crear una nueva aplicación Blazor en la carpeta.

    ```
    dotnet new blazor
    ```

1. Ejecute el siguiente comando para compilar la aplicación para asegurarse de que no hubo problemas durante la creación.

    ```
    dotnet build
    ```

### Implementar la aplicación en App Service

Para implementar la aplicación, primero debe publicarla con el comando **dotnet publish**, y luego crear un archivo *.zip* para la implementación.

1. Ejecute el siguiente comando para publicar la aplicación en un directorio *publish*.

    ```
    dotnet publish -c Release -o ./publish
    ```

1. Ejecute los siguientes comandos para crear un archivo *.zip* de la aplicación publicada. El archivo *.zip* estará ubicado en el directorio raíz de la aplicación.

    ```
    cd publish
    zip -r ../app.zip .
    cd ..
    ```

1. Ejecute el siguiente comando para implementar la aplicación en App Service. Reemplace **YOUR-WEB-APP-NAME** y **YOUR-RESOURCE-GROUP** con los valores que usó al crear los recursos de App Service anteriormente en el ejercicio.

    ```
    az webapp deploy --name YOUR-WEB-APP-NAME \
        --resource-group YOUR-RESOURCE-GROUP \
        --src-path ./app.zip
    ```

    >**Nota:** Es posible que deba ejecutar **az login**, o **az login --use-device-code** en el cloud shell para que el comando **az webapp deploy** funcione.

1. Cuando se complete la implementación, seleccione el enlace en el campo **Dominio predeterminado** ubicado en la sección **Esenciales** para abrir la aplicación en una nueva pestaña de su navegador.

Ahora es el momento de ver algunas métricas básicas de la aplicación en Application Insights. No cierre esta pestaña, la usará en el resto del ejercicio.

## Ver métricas en Application Insights

Vuelva a la pestaña del portal de Azure y navegue hasta el recurso de Application Insights que creó anteriormente. La pestaña **Información general** muestra algunos gráficos básicos:

* Solicitudes fallidas (Failed requests)
* Tiempo de respuesta del servidor (Server response time)
* Solicitudes del servidor (Server requests)
* Disponibilidad (Availability)

En esta sección realizará algunas acciones en la aplicación web y luego regresará a esta página para ver la actividad. Los informes de actividad tienen retraso, por lo que puede tardar unos minutos en aparecer en los gráficos.

Realice los siguientes pasos en la aplicación web.

1. Navegue entre las opciones de navegación **Home**, **+ Counter** y **Weather** en el menú de la aplicación web.

1. Actualice la página web varias veces para generar datos de **Tiempo de respuesta del servidor** y **Solicitudes del servidor**.

1. Para crear algunos errores, seleccione el botón **Home** y luego agregue a la URL **/failures**. Esta ruta no existe en la aplicación web y generará un error. Actualice la página varias veces para generar datos de error.

1. Vuelva a la pestaña donde se está ejecutando Application Insights y espere un minuto o dos a que la información aparezca en los gráficos.

1. En el panel de navegación izquierdo expanda la sección **Investigar** (Investigate) y seleccione **Errores** (Failures). Muestra el recuento de solicitudes fallidas junto con información más detallada sobre los códigos de respuesta para los errores.

Explore otras opciones de informes para tener una idea de qué otros tipos de información están disponibles.

## Limpiar recursos

Ahora que ha terminado el ejercicio, debe eliminar los recursos de la nube que creó para evitar el uso innecesario de recursos.

1. En su navegador web, vaya al portal de Azure [https://portal.azure.com](https://portal.azure.com); inicie sesión con sus credenciales de Azure si se le solicita.
1. Vaya al grupo de recursos que creó y vea el contenido de los recursos usados en este ejercicio.
1. En la barra de herramientas, seleccione **Eliminar grupo de recursos**.
1. Ingrese el nombre del grupo de recursos y confirme que desea eliminarlo.

> **PRECAUCIÓN:** Al eliminar un grupo de recursos se eliminan todos los recursos que contiene. Si eligió un grupo de recursos existente para este ejercicio, cualquier recurso existente fuera del alcance de este ejercicio también se eliminará.
