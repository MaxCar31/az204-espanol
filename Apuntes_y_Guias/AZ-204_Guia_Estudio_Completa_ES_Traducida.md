# Guía de estudio del examen AZ-204: Desarrollo de soluciones para Microsoft Azure

## Finalidad de este documento

Esta guía de estudio le ayudará a comprender qué esperar en el examen, e incluye un resumen de los temas que el examen podría incluir y vínculos a recursos adicionales. La información y los materiales de este documento le ayudarán a centrar sus estudios a medida que se prepara para el examen.

| Vínculos útiles | Descripción |
|---|---|
| Obtención de la certificación | Algunas certificaciones solo requieren aprobar un examen, mientras que otros requieren aprobar varios exámenes. |
| Renovación de la certificación | Las certificaciones de asociado, experto y especialidad de Microsoft caducan anualmente. Puede renovar sus aptitudes aprobando una evaluación en línea gratuita en Microsoft Learn. |
| Su perfil de Microsoft Learn | La conexión del perfil de certificación a Microsoft Learn le permite programar y renovar exámenes y compartir e imprimir certificados. |
| Puntuación de los exámenes e informes de puntuación | Se requiere una puntuación de 700 o superior para aprobar. |
| Espacio aislado del examen | Puede explorar el entorno del examen visitando nuestro espacio aislado del examen. |
| Solicitud de ajustes | Si usa dispositivos de asistencia, requiere tiempo adicional o necesita modificaciones en cualquier parte de la experiencia del examen, puedes solicitar una adaptación. |
| Preséntese a una evaluación gratuita para practicar | Practique y ponga a prueba sus conocimientos con preguntas que lo ayudarán a prepararse para el examen. |

## Actualizaciones al examen

Nuestros exámenes se actualizan periódicamente para reflejar las aptitudes necesarias para desempeñar un rol.

Siempre actualizamos la versión en inglés del examen primero. Algunos exámenes se localizan en otros idiomas y se actualizan aproximadamente ocho semanas después de actualizar la versión en inglés. Los otros idiomas disponibles se enumeran en la sección Schedule Exam (Programar examen) de la página web Exam Details (Detalles del examen). Si el examen no está disponible en su idioma de preferencia, puede solicitar un período adicional de 30 minutos para completarlo.

> **Nota**: Las viñetas debajo de cada una de las aptitudes medidas están diseñadas para ilustrar cómo estamos evaluando esa aptitud. Los temas relacionados puede que se traten en el examen.

> **Nota**: La mayoría de las preguntas tratan las características que son de disponibilidad general (GA). El examen puede contener preguntas de Características en vista previa (GB) si dichas características se usan de forma regular.

## Habilidades medidas a fecha de 14 de enero de 2026

### Perfil del público

Los candidatos a este examen son responsables de participar en todas las fases de desarrollo, como la recopilación de requisitos, el diseño, el desarrollo, la implementación, la seguridad, el mantenimiento, el ajuste del rendimiento y la supervisión.

Debe ser experto en Azure: SDKs, opciones de almacenamiento de datos, conexiones de datos, API existentes, autenticación y autorización de aplicaciones, implementación de proceso y contenedor, y depuración.

Para implementar soluciones, se asocia con: arquitectos de soluciones en la nube, DBA, DevOps, administradores de infraestructura y otras partes interesadas.

Debe tener al menos dos años de experiencia en programación, competencia en programación con SDK de Azure y competencia en el uso de la CLI de Azure, Azure PowerShell y otras herramientas.

### Aptitudes de un vistazo

- Desarrollo de soluciones de proceso de Azure (25-30 %)
- Desarrollo para Azure Storage (15-20 %)
- Implementación de la seguridad de Azure (15–20 %)
- Supervisión, solución de problemas y optimización de las soluciones de Azure (5-10 %)
- Conexión y consumo de servicios de Azure y de terceros (20-25 %)

---

# PARTE 1 — Desarrollo de soluciones de proceso de Azure (25-30 %)


---

<!-- ===== Implementación de soluciones en ---

<!-- ===== Implementación de soluciones en contenedores ===== -->

# Contenedores

## Administración de imágenes de contenedor en Azure Container Registry

Azure Container Registry (ACR) es un servicio de registro Docker privado y administrado basado en Docker Registry 2.0 de código abierto. Cree y mantenga registros de contenedores de Azure para almacenar y administrar sus imágenes de contenedor Docker privadas.

### Descripción de Azure Container Registry

Azure Container Registry (ACR) es un servicio de registro administrado basado en Docker Registry 2.0 de código abierto. Cree y mantenga registros de contenedores de Azure para almacenar y administrar sus imágenes de contenedor y artefactos relacionados.

Use el servicio ACR con sus canalizaciones existentes de desarrollo e implementación de contenedores, o use Azure Container Registry Tasks para compilar imágenes de contenedor en Azure. Compile a petición o automatice completamente las compilaciones con desencadenadores como confirmaciones de código fuente y actualizaciones de imagen base.

#### Casos de uso

Extraiga imágenes de un registro de contenedores de Azure a varios destinos de implementación:

- **Sistemas de orquestación escalables** que administran aplicaciones en contenedores en clústeres de hosts, incluidos Kubernetes, DC/OS y Docker Swarm.
- **Servicios de Azure** que admiten la compilación y ejecución de aplicaciones a escala, incluidos Azure Kubernetes Service (AKS), App Service, Batch y Service Fabric.

Los desarrolladores también pueden enviar imágenes a un registro de contenedores como parte de un flujo de trabajo de desarrollo de contenedores. Por ejemplo, puede apuntar a un registro de contenedores desde una herramienta de integración y entrega continuas como Azure Pipelines o Jenkins.

Configure ACR Tasks para recompilar automáticamente las imágenes de la aplicación cuando se actualicen sus imágenes base, o automatice las compilaciones de imágenes cuando su equipo confirme código en un repositorio Git. Cree tareas de varios pasos para automatizar la compilación, prueba y aplicación de revisiones en varias imágenes de contenedor en paralelo en la nube.

#### Niveles de servicio de Azure Container Registry

Azure Container Registry está disponible en varios niveles de servicio. Estos niveles proporcionan precios predecibles y varias opciones para adaptarse a los patrones de capacidad y uso de su registro Docker privado en Azure.

| Nivel     | Descripción                                                                                                                                                                                                                                                                                                                                                                                  |
| --------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| Básico   | Punto de entrada económico para desarrolladores que aprenden sobre Azure Container Registry. Los registros básicos tienen las mismas capacidades programáticas que los niveles Estándar y Premium (como la integración de autenticación de Microsoft Entra, la eliminación de imágenes y los webhooks). Sin embargo, el almacenamiento incluido y el rendimiento de imágenes son más adecuados para escenarios de menor uso.                                 |
| Estándar | Los registros estándar ofrecen las mismas capacidades que el nivel Básico, con mayor almacenamiento incluido y rendimiento de imágenes. Los registros estándar deben satisfacer las necesidades de la mayoría de los escenarios de producción.                                                                                                                                                                                                   |
| Premium  | Los registros premium ofrecen la mayor cantidad de almacenamiento incluido y operaciones simultáneas, lo que permite escenarios de alto volumen. Además de un mayor rendimiento de imágenes, el nivel Premium agrega características como: replicación geográfica para administrar un solo registro en varias regiones, confianza en el contenido para la firma de etiquetas de imágenes y vínculo privado con puntos de conexión privados para restringir el acceso al registro. |

#### Imágenes y artefactos compatibles

Cuando las imágenes se agrupan en un repositorio, cada imagen es una instantánea de solo lectura de un contenedor compatible con Docker. Los registros de contenedores de Azure pueden incluir imágenes de Windows y Linux. Además de las imágenes de contenedor de Docker, Azure Container Registry almacena formatos de contenido relacionados, como [gráficos de Helm](https://learn.microsoft.com/es-es/azure/container-registry/container-registry-helm-repos) e imágenes creadas según la [especificación de formato de imagen de Open Container Initiative (OCI)](https://github.com/opencontainers/image-spec/blob/master/spec.md).

#### Compilaciones de imágenes automatizadas

Use [Azure Container Registry Tasks](https://learn.microsoft.com/es-es/azure/container-registry/container-registry-tasks-overview) (ACR Tasks) para simplificar la compilación, prueba, envío e implementación de imágenes en Azure. Configure las tareas de compilación para automatizar la canalización de aplicación de parches del sistema operativo de contenedor y del marco, y compile imágenes automáticamente cuando el equipo confirme código en el control de código fuente.

### Exploración de las capacidades de almacenamiento

Todos los niveles de Azure Container Registry se benefician de características avanzadas de almacenamiento de Azure, como el cifrado en reposo para la seguridad de los datos de imagen y la redundancia geográfica para la protección de los datos de imagen.

- **Cifrado en reposo:** Todas las imágenes de contenedor y otros artefactos del registro están cifrados en reposo. Azure cifra automáticamente una imagen antes de almacenarla y la descifra sobre la marcha cuando usted o sus aplicaciones y servicios extraen la imagen. Opcionalmente, aplique una capa de cifrado adicional con una clave administrada por el cliente.
- **Almacenamiento regional:** Azure Container Registry almacena datos en la región donde se crea el registro, para ayudar a los clientes a cumplir los requisitos de residencia de datos y cumplimiento normativo. En todas las regiones excepto Sur de Brasil y Sudeste Asiático, Azure también puede almacenar datos del registro en una región emparejada en la misma geografía. En las regiones Sur de Brasil y Sudeste Asiático, los datos del registro siempre están confinados a la región, para adaptarse a los requisitos de residencia de datos de esas regiones.

  Si se produce una interrupción regional, es posible que los datos del registro no estén disponibles y no se recuperen automáticamente. Los clientes que deseen almacenar sus datos de registro en varias regiones para mejorar el rendimiento en distintas zonas geográficas, o que deseen resistencia ante una interrupción regional, deben habilitar la replicación geográfica.

- **Replicación geográfica:** Para escenarios que requieren una garantía de alta disponibilidad, considere usar la característica de replicación geográfica de los registros Premium. La replicación geográfica ayuda a protegerse contra la pérdida de acceso al registro en caso de error regional. La replicación geográfica también proporciona otras ventajas, como el almacenamiento de imágenes cercano a la red para inserciones y extracciones más rápidas en escenarios de desarrollo o implementación distribuidos.

- **Redundancia de zona:** Una característica del nivel de servicio Premium, la redundancia de zona usa zonas de disponibilidad de Azure para replicar el registro en un mínimo de tres zonas independientes en cada región habilitada.

- **Almacenamiento escalable:** Azure Container Registry permite crear tantos repositorios, imágenes, capas o etiquetas como necesite, hasta el [límite de almacenamiento](https://learn.microsoft.com/es-es/azure/container-registry/container-registry-skus#service-tier-features-and-limits) del registro.

  Un número elevado de repositorios y etiquetas puede afectar al rendimiento del registro. Elimine periódicamente los repositorios, etiquetas e imágenes no utilizados como parte de la rutina de mantenimiento del registro. Los recursos del registro eliminados, como repositorios, imágenes y etiquetas, no se pueden recuperar después de la eliminación.

### Creación y administración de contenedores con tareas

Azure Container Registry (ACR) Tasks es un conjunto de características que:

- Proporciona compilación de imágenes de contenedor basada en la nube para plataformas como Linux, Windows y máquinas RISC avanzadas (Arm).
- Amplía las primeras partes del ciclo de desarrollo de una aplicación a la nube con compilaciones de imágenes de contenedor bajo demanda.
- Habilita compilaciones automatizadas desencadenadas por actualizaciones de código fuente, actualizaciones de imagen base del contenedor o temporizadores.

#### Escenarios de tareas

ACR Tasks admite varios escenarios para compilar y mantener imágenes de contenedor y otros artefactos.

- **Tarea rápida** - Compile e inserte una sola imagen de contenedor en un registro de contenedores a petición, en Azure, sin necesidad de una instalación local de Docker Engine. Piense en `docker build`, `docker push` en la nube.

- **Tareas desencadenadas automáticamente** - Habilite uno o más desencadenadores para compilar una imagen:

  - Desencadenar al actualizar el código fuente
  - Desencadenar al actualizar la imagen base
  - Desencadenar según una programación

- **Tarea de varios pasos** - Amplíe la capacidad de compilación e inserción de imágenes individuales de ACR Tasks con flujos de trabajo de varios pasos basados en varios contenedores.

Cada tarea de ACR tiene un contexto de código fuente asociado: la ubicación de un conjunto de archivos de origen que se usan para compilar una imagen de contenedor u otro artefacto. Los contextos de ejemplo incluyen un repositorio Git o un sistema de archivos local.

#### Tarea rápida

El ciclo de desarrollo de _bucle interno_ es el proceso iterativo de escribir código, compilar y probar la aplicación antes de confirmar en el control de código fuente. Es realmente el comienzo de la administración del ciclo de vida del contenedor.

Antes de confirmar la primera línea de código, la característica de tarea rápida de ACR Tasks puede proporcionar una experiencia de desarrollo integrada descargando las compilaciones de imágenes de contenedor a Azure. Con las tareas rápidas, puede comprobar las definiciones de compilación automatizadas y detectar posibles problemas antes de confirmar el código.

Con el conocido formato `docker build`, el comando [az acr build](https://learn.microsoft.com/es-es/cli/azure/acr#az-acr-build) de la CLI de Azure toma un contexto (el conjunto de archivos para compilar), lo envía a ACR Tasks y, de forma predeterminada, inserta la imagen compilada en su registro al completarse.

#### Desencadenamiento de tareas al actualizar el código fuente

Desencadene una compilación de imagen de contenedor o una tarea de varios pasos cuando se confirma el código, o cuando se realiza o actualiza una solicitud de incorporación de cambios en un repositorio Git en GitHub o Azure DevOps Services. Por ejemplo, configure una tarea de compilación con el comando `az acr task create` de la CLI de Azure especificando un repositorio Git y, opcionalmente, una rama y un Dockerfile. Cuando el equipo actualiza el código en el repositorio, un webhook creado por ACR Tasks desencadena una compilación de la imagen de contenedor definida en el repositorio.

#### Desencadenamiento al actualizar la imagen base

Puede configurar una tarea de ACR para realizar un seguimiento de una dependencia en una imagen base cuando compila una imagen de aplicación. Cuando la imagen base actualizada se inserta en el registro, o se actualiza una imagen base en un repositorio público como Docker Hub, ACR Tasks puede compilar automáticamente cualquier imagen de aplicación basada en ella.

#### Programación de una tarea

Opcionalmente, programe una tarea configurando uno o varios desencadenadores de temporizador al crear o actualizar la tarea. Programar una tarea es útil para ejecutar cargas de trabajo de contenedor según una programación definida o para ejecutar operaciones de mantenimiento o pruebas en imágenes insertadas periódicamente en el registro.

#### Tareas de varios pasos

Las tareas de varios pasos, definidas en un archivo [YAML](https://learn.microsoft.com/es-es/azure/container-registry/container-registry-tasks-reference-yaml), especifican operaciones de compilación e inserción individuales para imágenes de contenedor u otros artefactos. También pueden definir la ejecución de uno o más contenedores, con cada paso usando el contenedor como su entorno de ejecución. Por ejemplo, puede crear una tarea de varios pasos que automatice lo siguiente:

- Compilar una imagen de aplicación web
- Ejecutar el contenedor de aplicación web
- Compilar una imagen de prueba de aplicación web
- Ejecutar el contenedor de prueba de aplicación web, que realiza pruebas en el contenedor de aplicación en ejecución
- Si las pruebas son correctas, compilar un paquete de archivo de gráfico de Helm
- Realizar una actualización de `helm` usando el nuevo paquete de archivo de gráfico de Helm

#### Plataformas de imágenes

De forma predeterminada, ACR Tasks compila imágenes para el sistema operativo Linux y la arquitectura amd64. Especifique la etiqueta `--platform` para compilar imágenes de Windows o imágenes de Linux para otras arquitecturas. Especifique el sistema operativo y opcionalmente una arquitectura compatible en formato SO/arquitectura (por ejemplo, `--platform Linux/arm`). Para arquitecturas ARM, opcionalmente especifique una variante en formato SO/arquitectura/variante (por ejemplo, `--platform Linux/arm64/v8`):

| OS      | Architecture |
| ------- | ------------ |
| Linux   | AMD64        |
|         | Arm          |
|         | Arm64        |
|         | 386          |
| Windows | AMD64        |

### Exploración de los elementos de un Dockerfile

Un Dockerfile es un script que contiene una serie de instrucciones que se usan para compilar una imagen de Docker. Los Dockerfiles típicamente incluyen la siguiente información:

- La imagen base o primaria que se usa para crear la nueva imagen
- Comandos para actualizar el sistema operativo base e instalar otro software
- Artefactos de compilación para incluir, como una aplicación desarrollada
- Servicios a exponer, como almacenamiento y configuración de red
- Comando a ejecutar cuando se inicia el contenedor

#### Creación de un Dockerfile

El primer paso para crear un Dockerfile es elegir una imagen base que sirva de base para la aplicación. Por ejemplo, si está compilando una aplicación .NET, podría elegir una imagen de Microsoft .NET como su base.

```Dockerfile
# Use el runtime de .NET 6 como imagen base
FROM mcr.microsoft.com/dotnet/runtime:6.0

# Establezca el directorio de trabajo en /app
WORKDIR /app

# Copie el contenido de la aplicación publicada al directorio /app del contenedor
COPY bin/Release/net6.0/publish/ .

# Exponga el puerto 80 al exterior
EXPOSE 80

# Establezca el comando que se ejecuta cuando se inicia el contenedor
CMD ["dotnet", "MyApp.dll"]
```

Veamos cada línea para ver qué hace:

- **`FROM mcr.microsoft.com/dotnet/runtime:6.0`**: Este comando establece la imagen base en el runtime de .NET 6, que es necesario para ejecutar aplicaciones .NET 6.
- **`WORKDIR /app`**: Establece el directorio de trabajo en `/app`, que es donde se copian los archivos de la aplicación.
- **`COPY bin/Release/net6.0/publish/ .`**: Copia el contenido de la aplicación publicada al directorio `/app` del contenedor. Asumimos que la aplicación .NET 6 está compilada y publicada en el directorio `bin/Release/net6.0/publish`.
- **`EXPOSE 80`**: Expone el puerto 80, que es el puerto HTTP predeterminado, al mundo exterior. Cambie esta línea en consecuencia si su aplicación escucha en un puerto diferente.
- **`CMD ["dotnet", "MyApp.dll"]`**: El comando a ejecutar cuando se inicia el contenedor. En este caso, estamos ejecutando el comando dotnet con el nombre del archivo DLL de nuestra aplicación (`MyApp.dll`). Cambie esta línea para que coincida con el nombre de su aplicación y punto de entrada.

No vamos a cubrir la especificación del archivo Dockerfile. Visite la [referencia de Dockerfile](https://docs.docker.com/engine/reference/builder/) para más información. Cada uno de estos pasos crea una imagen de contenedor almacenada en caché mientras compilamos la imagen final del contenedor. Estas imágenes temporales se superponen una encima de la anterior y se presentan como una sola imagen una vez que se completan todos los pasos.

#### Recursos

- [Docker run reference (CLI)](https://docs.docker.com/engine/reference/run/)
- [Docker build reference](https://docs.docker.com/engine/reference/commandline/build/)

### Exploración de Azure Container Instances

Azure Container Instances (ACI) es una excelente solución para cualquier escenario que pueda operar en contenedores aislados, incluidas aplicaciones simples, automatización de tareas y trabajos de compilación. Estas son algunas de las ventajas:

- **Inicio rápido**: ACI puede iniciar contenedores en Azure en segundos, sin necesidad de crear ni administrar una máquina virtual.
- **Acceso al contenedor**: ACI permite exponer los grupos de contenedores directamente a Internet con una dirección IP y un nombre de dominio completo (FQDN).
- **Seguridad de nivel de hipervisor**: Aísle la aplicación de forma tan completa como lo haría en una máquina virtual.
- **Datos del cliente**: El servicio ACI almacena los datos mínimos del cliente necesarios para garantizar que los grupos de contenedores se ejecutan según lo previsto.
- **Tamaños personalizados**: ACI proporciona una utilización óptima al permitir especificaciones exactas de núcleos de CPU y memoria.
- **Almacenamiento persistente**: Monte recursos compartidos de Azure Files directamente en un contenedor para recuperar y conservar el estado.
- **Linux y Windows**: Programe contenedores de Windows y Linux usando la misma API.

Para escenarios donde se necesita orquestación completa de contenedores, incluyendo la detección de servicios entre varios contenedores, el escalado automático y las actualizaciones coordinadas de aplicaciones, se recomienda [Azure Kubernetes Service (AKS)](https://learn.microsoft.com/es-es/azure/aks/).

#### Grupos de contenedores

El recurso de nivel superior en Azure Container Instances es el _grupo de contenedores_. Un grupo de contenedores es una colección de contenedores que se programan en el mismo equipo host. Los contenedores de un grupo de contenedores comparten un ciclo de vida, recursos, red local y volúmenes de almacenamiento. Es un concepto similar a un _pod_ en Kubernetes.

El diagrama siguiente muestra un ejemplo de un grupo de contenedores que incluye varios contenedores:

![Ejemplo de grupo de contenedores con dos contenedores, uno escuchando en el puerto 80 y el otro en el puerto 5000.](https://learn.microsoft.com/en-us/training/wwl-azure/create-run-container-images-azure-container-instances/media/container-groups-example.png)

Este grupo de contenedores de ejemplo:

- Se programa en una sola máquina host.
- Se le asigna una etiqueta de nombre DNS.
- Expone una sola dirección IP pública, con un puerto expuesto.
- Consta de dos contenedores. Un contenedor escucha en el puerto 80, mientras que el otro escucha en el puerto 5000.
- Incluye dos recursos compartidos de archivos de Azure como montajes de volumen, y cada contenedor monta uno de los recursos compartidos localmente.

:information_source: Actualmente, los grupos de varios contenedores solo admiten contenedores Linux. Para los contenedores Windows, Azure Container Instances solo admite la implementación de una sola instancia.

#### Implementación

Hay dos formas comunes de implementar un grupo de varios contenedores: usar una plantilla de Resource Manager o un archivo YAML. Se recomienda una plantilla de Resource Manager cuando se necesitan implementar más recursos de servicio de Azure al implementar las instancias de contenedor. Debido a la naturaleza más concisa del formato YAML, se recomienda un archivo YAML cuando la implementación incluye solo instancias de contenedor.

#### Asignación de recursos

Azure Container Instances asigna recursos como CPU, memoria y, opcionalmente, GPU (versión preliminar) a un grupo de contenedores sumando las solicitudes de recursos de las instancias del grupo. Usando los recursos de CPU como ejemplo, si crea un grupo de contenedores con dos instancias, cada una solicitando una CPU, entonces al grupo de contenedores se le asignan dos CPU.

#### Redes

Los grupos de contenedores comparten una dirección IP y un espacio de nombres de puertos en esa dirección IP. Para permitir que los clientes externos lleguen a un contenedor dentro del grupo, debe exponer el puerto en la dirección IP y desde el contenedor. Dado que los contenedores del grupo comparten un espacio de nombres de puertos, la asignación de puertos no se admite. Los contenedores de un grupo pueden comunicarse entre sí a través del host local en los puertos que han expuesto, aunque esos puertos no estén expuestos externamente en la dirección IP del grupo.

#### Almacenamiento

Puede especificar volúmenes externos para montar dentro de un grupo de contenedores. Puede asignar esos volúmenes a rutas específicas dentro de los contenedores individuales de un grupo. Los volúmenes admitidos incluyen:

- Azure file share
- Secret
- Empty directory
- Cloned git repo

#### Escenarios comunes

Los grupos de varios contenedores son útiles en casos donde se desea dividir una sola tarea funcional en varias imágenes de contenedor. Estas imágenes pueden ser entregadas por diferentes equipos y tener requisitos de recursos separados.

Entre los usos de ejemplo se incluyen:

- Un contenedor que sirve una aplicación web y un contenedor que extrae el contenido más reciente del control de código fuente.
- Un contenedor de aplicación y un contenedor de registro. El contenedor de registro recopila los registros y métricas generados por la aplicación principal y los escribe en el almacenamiento a largo plazo.
- Un contenedor de aplicación y un contenedor de supervisión. El contenedor de supervisión realiza periódicamente una solicitud a la aplicación para asegurarse de que se está ejecutando y respondiendo correctamente, y emite una alerta si no lo hace.
- Un contenedor de front-end y un contenedor de back-end. El front-end puede servir una aplicación web, mientras que el back-end ejecuta un servicio para recuperar datos.

### Ejecución de tareas en contenedores con directivas de reinicio

La facilidad y rapidez de implementación de contenedores en Azure Container Instances ofrece una plataforma atractiva para ejecutar tareas de una sola vez como compilación, pruebas y representación de imágenes en una instancia de contenedor.

Con una directiva de reinicio configurable, puede especificar que los contenedores se detengan cuando sus procesos se hayan completado. Las instancias de contenedor se facturan por segundo, por lo que solo se le cobra por los recursos de proceso utilizados mientras se ejecuta el contenedor que ejecuta su tarea.

#### Directiva de reinicio de contenedores

Al crear un grupo de contenedores en Azure Container Instances, puede especificar una de tres configuraciones de directiva de reinicio.

| Directiva de reinicio | Descripción                                                                                                                                                                                |
| --------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| Siempre        | Los contenedores del grupo de contenedores siempre se reinician. Esta es la configuración predeterminada que se aplica cuando no se especifica ninguna directiva de reinicio en la creación del contenedor.                                     |
| Nunca          | Los contenedores del grupo de contenedores nunca se reinician. Los contenedores se ejecutan como máximo una vez.                                                                                                    |
| EnCasoDeError  | Los contenedores del grupo de contenedores solo se reinician cuando el proceso ejecutado en el contenedor produce un error (cuando termina con un código de salida distinto de cero). Los contenedores se ejecutan al menos una vez. |

#### Especificación de una directiva de reinicio

Especifique el parámetro `--restart-policy` cuando llame a `az container create`.

```sh
az container create \
    --resource-group myResourceGroup \
    --name mycontainer \
    --image mycontainerimage \
    --restart-policy OnFailure
```

#### Ejecución hasta completarse

Azure Container Instances inicia el contenedor y lo detiene cuando su aplicación o script finaliza. Cuando Azure Container Instances detiene un contenedor cuya directiva de reinicio es `Never` u `OnFailure`, el estado del contenedor se establece en **Terminado**.

### Configuración de variables de entorno en instancias de contenedor

Establecer variables de entorno en las instancias de contenedor permite proporcionar una configuración dinámica de la aplicación o el script ejecutado por el contenedor. Estas variables de entorno son similares al argumento de línea de comandos `--env` de `docker run`.

Si necesita pasar secretos como variables de entorno, Azure Container Instances admite valores seguros para contenedores de Windows y Linux.

En el siguiente ejemplo, se pasan dos variables al contenedor cuando se crea. El ejemplo asume que ejecuta la CLI en un shell de Bash o Cloud Shell; si usa el símbolo del sistema de Windows, especifique las variables con comillas dobles, como `--environment-variables "NumWords"="5" "MinLength"="8"`.

```sh
az container create \
    --resource-group myResourceGroup \
    --name mycontainer2 \
    --image mcr.microsoft.com/azuredocs/aci-wordcount:latest
    --restart-policy OnFailure \
    --environment-variables 'NumWords'='5' 'MinLength'='8'\
```

#### Valores seguros

Los objetos con valores seguros están diseñados para contener información confidencial, como contraseñas o claves de la aplicación. El uso de valores seguros para las variables de entorno es más seguro y flexible que incluirlos en la imagen del contenedor.

Las variables de entorno con valores seguros no son visibles en las propiedades del contenedor. Solo se puede acceder a sus valores desde dentro del contenedor. Por ejemplo, las propiedades del contenedor que se visualizan en Azure Portal o la CLI de Azure muestran solo el nombre de una variable segura, no su valor.

Establezca una variable de entorno segura especificando la propiedad secureValue en lugar del `value` normal para el tipo de variable. Las dos variables definidas en el siguiente YAML demuestran los dos tipos de variables.

```yaml
apiVersion: 2018-10-01
location: eastus
name: securetest
properties:
  containers:
    - name: mycontainer
      properties:
        environmentVariables:
          - name: "NOTSECRET"
            value: "my-exposed-value"
          - name: "SECRET"
            secureValue: "my-secret-value"
        image: nginx
        ports: []
        resources:
          requests:
            cpu: 1.0
            memoryInGB: 1.5
  osType: Linux
  restartPolicy: Always
tags: null
type: Microsoft.ContainerInstance/containerGroups
```

Ejecutaría el siguiente comando para implementar el grupo de contenedores con YAML:

```sh
az container create --resource-group myResourceGroup \
    --file secure-env.yaml \
```

### Montaje de un recurso compartido de archivos de Azure en Azure Container Instances

De forma predeterminada, Azure Container Instances no tiene estado. Si el contenedor se bloquea o se detiene, todo su estado se pierde. Para conservar el estado más allá de la duración del contenedor, debe montar un volumen desde un almacén externo. Como se muestra en esta unidad, Azure Container Instances puede montar un recurso compartido de archivos de Azure creado con Azure Files. Azure Files ofrece recursos compartidos de archivos totalmente administrados en la nube a los que se puede acceder a través del protocolo estándar del sector Bloque de mensajes del servidor (SMB). El uso de un recurso compartido de archivos de Azure con Azure Container Instances proporciona características de uso compartido de archivos similares al uso de un recurso compartido de archivos de Azure con máquinas virtuales de Azure.

#### Limitaciones

- Solo puede montar recursos compartidos de Azure Files en contenedores Linux.
- El montaje del volumen del recurso compartido de archivos de Azure requiere que el contenedor Linux se ejecute como raíz.
- Los montajes de volumen del recurso compartido de archivos de Azure están limitados a la compatibilidad con CIFS.

#### Implementación del contenedor y montaje del volumen

Para montar un recurso compartido de archivos de Azure como volumen en un contenedor mediante la CLI de Azure, especifique el recurso compartido y el punto de montaje del volumen al crear el contenedor con `az container create`. A continuación se muestra un ejemplo del comando:

```sh
az container create \
    --resource-group $ACI_PERS_RESOURCE_GROUP \
    --name hellofiles \
    --image mcr.microsoft.com/azuredocs/aci-hellofiles \
    --dns-name-label aci-demo \
    --ports 80 \
    --azure-file-volume-account-name $ACI_PERS_STORAGE_ACCOUNT_NAME \
    --azure-file-volume-account-key $STORAGE_KEY \
    --azure-file-volume-share-name $ACI_PERS_SHARE_NAME \
    --azure-file-volume-mount-path /aci/logs/
```

El valor de `--dns-name-label` debe ser único dentro de la región de Azure donde se crea la instancia de contenedor. Actualice el valor del comando anterior si recibe un mensaje de error de **etiqueta de nombre DNS** al ejecutar el comando.

#### Implementación del contenedor y montaje del volumen - YAML

También puede implementar un grupo de contenedores y montar un volumen en un contenedor con la CLI de Azure y una plantilla YAML. La implementación mediante plantilla YAML es el método preferido cuando se implementan grupos de contenedores que constan de varios contenedores.

La siguiente plantilla YAML define un grupo de contenedores con un contenedor creado con la imagen `aci-hellofiles`. El contenedor monta el recurso compartido de archivos de Azure acishare creado anteriormente como un volumen. A continuación se muestra un archivo YAML de ejemplo.

```yaml
apiVersion: "2019-12-01"
location: eastus
name: file-share-demo
properties:
  containers:
    - name: hellofiles
      properties:
        environmentVariables: []
        image: mcr.microsoft.com/azuredocs/aci-hellofiles
        ports:
          - port: 80
        resources:
          requests:
            cpu: 1.0
            memoryInGB: 1.5
        volumeMounts:
          - mountPath: /aci/logs/
            name: filesharevolume
  osType: Linux
  restartPolicy: Always
  ipAddress:
    type: Public
    ports:
      - port: 80
    dnsNameLabel: aci-demo
  volumes:
    - name: filesharevolume
      azureFile:
        sharename: acishare
        storageAccountName: <Storage account name>
        storageAccountKey: <Storage account key>
tags: {}
type: Microsoft.ContainerInstance/containerGroups
```

#### Montaje de varios volúmenes

Para montar varios volúmenes en una instancia de contenedor, debe implementar mediante una plantilla de Azure Resource Manager o un archivo YAML. Para usar una plantilla o archivo YAML, proporcione los detalles del recurso compartido y defina los volúmenes rellenando la matriz `volumes` en la sección `properties` de la plantilla.

Por ejemplo, si creó dos recursos compartidos de Azure Files nombrados _share1_ y _share2_ en la cuenta de almacenamiento _myStorageAccount_, la matriz `volumes` en una plantilla de Resource Manager se vería similar a lo siguiente:

```json
"volumes": [{
  "name": "myvolume1",
  "azureFile": {
    "shareName": "share1",
    "storageAccountName": "myStorageAccount",
    "storageAccountKey": "<storage-account-key>"
  }
},
{
  "name": "myvolume2",
  "azureFile": {
    "shareName": "share2",
    "storageAccountName": "myStorageAccount",
    "storageAccountKey": "<storage-account-key>"
  }
}]
```

A continuación, para cada contenedor en el grupo de contenedores en el que desea montar los volúmenes, rellene la matriz `volumeMounts` en la sección `properties` de la definición del contenedor. Por ejemplo, esto monta los dos volúmenes, _myvolume1_ y _myvolume2_, definidos anteriormente:

```json
"volumeMounts": [{
  "name": "myvolume1",
  "mountPath": "/mnt/share1/"
},
{
  "name": "myvolume2",
  "mountPath": "/mnt/share2/"
}]
```

## Implementación de Azure Container Apps

Azure Container Apps proporciona la flexibilidad que necesita con un servicio de contenedor sin servidor construido para aplicaciones de microservicios y capacidades sólidas de escalado automático sin la sobrecarga de administrar infraestructura compleja.

### Exploración de Azure Container Apps

Azure Container Apps permite ejecutar microservicios y aplicaciones en contenedores en una plataforma sin servidor que se ejecuta sobre Azure Kubernetes Service. Los usos comunes de Azure Container Apps incluyen:

- Implementar puntos de conexión de API
- Alojar aplicaciones de procesamiento en segundo plano
- Controlar procesamiento impulsado por eventos
- Ejecutar microservicios

Las aplicaciones compiladas en Azure Container Apps pueden escalar dinámicamente según: tráfico HTTP, procesamiento impulsado por eventos, carga de CPU o memoria, y cualquier [escalador compatible con KEDA](https://keda.sh/docs/scalers/).

Con Azure Container Apps, puede:

- Ejecutar múltiples revisiones de contenedor y administrar el ciclo de vida de la aplicación de contenedor.
- Escalar automáticamente sus aplicaciones en función de cualquier desencadenador de escala compatible con KEDA. La mayoría de las aplicaciones pueden escalar a cero. (Las aplicaciones que se escalan según la carga de CPU o memoria no pueden escalar a cero.)
- Habilitar entrada HTTPS sin tener que administrar otra infraestructura de Azure.
- Dividir el tráfico entre varias versiones de una aplicación para implementaciones azul/verde y escenarios de pruebas A/B.
- Usar el ingreso interno y la detección de servicios para puntos de conexión solo internos seguros con detección de servicios basada en DNS integrada.
- Compilar microservicios con [Dapr](https://docs.dapr.io/concepts/overview/) y acceder a su conjunto enriquecido de API.
- Ejecutar contenedores desde cualquier registro, público o privado, incluyendo Docker Hub y Azure Container Registry (ACR).
- Usar la extensión de la CLI de Azure, Azure Portal o plantillas ARM para administrar las aplicaciones.
- Proporcionar una red virtual existente al crear un entorno para sus aplicaciones de contenedor.
- Administrar de forma segura secretos directamente en su aplicación.
- Supervisar registros usando Azure Log Analytics.

#### Entornos de Azure Container Apps

Las aplicaciones individuales de contenedor se implementan en un único entorno de Container Apps, que actúa como un límite seguro alrededor de grupos de aplicaciones de contenedor. Las aplicaciones de contenedor en el mismo entorno se implementan en la misma red virtual y escriben los registros en el mismo espacio de trabajo de Log Analytics. Podría proporcionar una red virtual existente cuando crea un entorno.

Las razones para implementar aplicaciones de contenedor en el mismo entorno incluyen situaciones cuando necesita:

- Administrar servicios relacionados
- Implementar diferentes aplicaciones en la misma red virtual
- Instrumentar aplicaciones [Dapr](https://docs.dapr.io/concepts/overview/) que se comunican a través de la API de invocación de servicio de Dapr
- Tener aplicaciones que compartan la misma configuración de Dapr
- Tener aplicaciones que compartan el mismo espacio de trabajo de análisis de registros

Las razones para implementar aplicaciones de contenedor en entornos diferentes incluyen situaciones cuando desea asegurar:

- Dos aplicaciones nunca compartan los mismos recursos de proceso
- Dos aplicaciones de Dapr no puedan comunicarse a través de la API de invocación de servicio de Dapr

#### Microservicios con Azure Container Apps

Las arquitecturas de microservicios le permiten desarrollar, actualizar, versionar y escalar de forma independiente áreas funcionales principales de un sistema general. Azure Container Apps proporciona la base para implementar microservicios con:

- Escalado, versionado y actualización independientes
- Descubrimiento de servicios
- Integración nativa de [Dapr](https://docs.dapr.io/concepts/overview/)

#### Integración con Dapr

Al implementar un sistema compuesto por microservicios, las llamadas a funciones se distribuyen por la red. Para soportar la naturaleza distribuida de los microservicios, debe considerar fallas, reintentos y tiempos de espera. Aunque Container Apps incluye los componentes básicos para ejecutar microservicios, el uso de Dapr proporciona un modelo de programación de microservicios aún más enriquecido. Dapr incluye características como observabilidad, pub/sub, e invocación de servicio a servicio con TLS mutuo, reintentos y más.

### Exploración de contenedores en Azure Container Apps

Azure Container Apps administra los detalles de Kubernetes y la orquestación de contenedores por usted. Los contenedores en Azure Container Apps pueden usar cualquier tiempo de ejecución, lenguaje de programación o pila de desarrollo de su elección.

![Diagrama que muestra cómo los contenedores de una Azure Container App se agrupan en pods dentro de instantáneas de revisión.](https://learn.microsoft.com/en-us/training/wwl-azure/implement-azure-container-apps/media/azure-container-apps-containers.png)

Azure Container Apps admite cualquier imagen de contenedor basada en Linux x86-64 (`linux/amd64`). No hay imagen de contenedor base requerida, y si un contenedor falla se reinicia automáticamente.

#### Configuración

El código siguiente es un ejemplo de la matriz `containers` en la sección `properties.template` de una plantilla de recurso de aplicación de contenedor. El extracto muestra algunas de las opciones de configuración disponibles al configurar un contenedor cuando se usan plantillas de Azure Resource Manager (ARM). Los cambios en la sección de configuración de la plantilla ARM desencadenan una nueva revisión de aplicación de contenedor.

```jsonc
"containers": [
  {
       "name": "main",
       "image": "[parameters('container_image')]",
    "env": [
      {
        "name": "HTTP_PORT",
        "value": "80"
      },
      {
        "name": "SECRET_VAL",
        "secretRef": "mysecret"
      }
    ],
    "resources": {
      "cpu": 0.5,
      "memory": "1Gi"
    },
    "volumeMounts": [
      {
        "mountPath": "/myfiles",
        "volumeName": "azure-files-volume"
      }
    ]
    "probes":[
        {
            "type":"liveness",
            "httpGet":{
            "path":"/health",
            "port":8080,
            "httpHeaders":[
                {
                    "name":"Custom-Header",
                    "value":"liveness probe"
                }]
            },
            "initialDelaySeconds":7,
            "periodSeconds":3
// el archivo se ha truncado por brevedad
```

#### Varios contenedores

Puede definir varios contenedores en una sola aplicación de contenedor para implementar el [patrón sidecar](https://learn.microsoft.com/es-es/azure/architecture/patterns/sidecar). Los contenedores de una aplicación de contenedor comparten recursos de disco duro y red, y experimentan el mismo ciclo de vida de la aplicación.

Entre los ejemplos de contenedores sidecar se incluyen:

- Un agente que lee registros del contenedor de aplicación principal en un volumen compartido y los reenvía a un servicio de registro.
- Un proceso en segundo plano que actualiza una caché usada por el contenedor de aplicación principal en un volumen compartido.

:information_source: Ejecutar varios contenedores en una sola aplicación de contenedor es un caso de uso avanzado. En la mayoría de los casos en los que desea ejecutar varios contenedores, como al implementar una arquitectura de microservicios, implemente cada servicio como una aplicación de contenedor independiente.

Para ejecutar varios contenedores en una aplicación de contenedor, agregue más de un contenedor en la matriz de contenedores de la plantilla de aplicación de contenedor.

#### Registros de contenedores

Puede implementar imágenes alojadas en registros privados proporcionando credenciales en la configuración de Container Apps.

Para usar un registro de contenedores, defina los campos necesarios en la matriz registries de la sección properties.configuration de la plantilla de recursos de la aplicación de contenedor. El campo passwordSecretRef identifica el nombre del secreto en la matriz secrets donde definió la contraseña.

```jsonc
{
  // ...
  "registries": [
    {
      "server": "docker.io",
      "username": "my-registry-user-name",
      "passwordSecretRef": "my-password-secret-name"
    }
  ]
}
```

Con la información del registro agregada, las credenciales guardadas se pueden usar para extraer una imagen de contenedor del registro privado cuando se implementa la aplicación.

#### Limitaciones

Azure Container Apps tiene las siguientes limitaciones:

- Contenedores con privilegios: Azure Container Apps no puede ejecutar contenedores con privilegios. Si el programa intenta ejecutar un proceso que requiere acceso raíz, la aplicación dentro del contenedor experimenta un error en tiempo de ejecución.
- Sistema operativo: Se requieren imágenes de contenedor basadas en Linux (`linux/amd64`).

### Implementación de autenticación y autorización en Azure Container Apps

Azure Container Apps proporciona características de autenticación y autorización integradas para proteger la aplicación de contenedor con entrada externa habilitada con código mínimo o nulo. La característica de autenticación integrada de Container Apps puede ahorrar tiempo y esfuerzo al proporcionar autenticación lista para usar con proveedores de identidades federados, lo que le permite centrarse en el resto de la aplicación.

- Las características de autenticación integradas de Azure Container Apps no requieren ningún lenguaje, SDK, experiencia en seguridad ni código específico que tenga que escribir.

Esta característica solo debe usarse con HTTPS. Asegúrese de que `allowInsecure` esté deshabilitado en la configuración de entrada de la aplicación de contenedor. Puede configurar la aplicación de contenedor para la autenticación con o sin restricción de acceso al contenido del sitio y las API.

- Para restringir el acceso a la aplicación solo a usuarios autenticados, establezca la configuración de acceso restringido en **Requerir autenticación**.
- Para autenticar pero no restringir el acceso, establezca la configuración de acceso restringido en **Permitir acceso no autenticado**.

#### Proveedores de identidad

Container Apps usa identidad federada, en la que un proveedor de identidades de terceros administra las identidades de usuario y el flujo de autenticación. Los siguientes proveedores de identidades están disponibles de forma predeterminada:

| Proveedor                   | Punto de conexión de inicio de sesión | Guía de procedimientos                                                                                                             |
| --------------------------- | ------------------------------------ | --------------------------------------------------------------------------------------------------------------------------- |
| Plataforma de identidad de Microsoft | `/.auth/login/aad`     | [Plataforma de identidad de Microsoft](https://learn.microsoft.com/es-es/azure/container-apps/authentication-azure-active-directory) |
| Facebook                    | `/.auth/login/facebook`       | [Facebook](https://learn.microsoft.com/es-es/azure/container-apps/authentication-facebook)                                  |
| GitHub                      | `/.auth/login/github`         | [GitHub](https://learn.microsoft.com/es-es/azure/container-apps/authentication-github)                                      |
| Google                      | `/.auth/login/google`         | [Google](https://learn.microsoft.com/es-es/azure/container-apps/authentication-google)                                      |
| X                           | `/.auth/login/twitter`        | [X](https://learn.microsoft.com/es-es/azure/container-apps/authentication-twitter)                                          |
| Cualquier proveedor de OpenID Connect | `/.auth/login/<providerName>` | [OpenID Connect](https://learn.microsoft.com/es-es/azure/container-apps/authentication-openid)                              |

Cuando usa uno de estos proveedores, el punto de conexión de inicio de sesión está disponible para la autenticación de usuarios y la validación de tokens de autenticación del proveedor. Puede ofrecer a los usuarios cualquier número de estas opciones de proveedor.

#### Arquitectura de características

El componente de middleware de autenticación y autorización es una característica de la plataforma que se ejecuta como contenedor sidecar en cada réplica de la aplicación. Cuando está habilitado, cada solicitud HTTP entrante pasa por la capa de seguridad antes de que la aplicación la procese.

![Diagrama que muestra solicitudes interceptadas por un contenedor sidecar que interactúa con proveedores de identidad antes de permitir tráfico al contenedor de la aplicación.](https://learn.microsoft.com/en-us/training/wwl-azure/implement-azure-container-apps/media/container-apps-authorization-architecture.png)

El middleware de la plataforma gestiona varios aspectos de la aplicación:

- Autentica a los usuarios y clientes con los proveedores de identidades especificados
- Administra la sesión autenticada
- Inserta información de identidad en los encabezados de solicitud HTTP

El módulo de autenticación y autorización se ejecuta en un contenedor independiente, aislado del código de la aplicación. Como el contenedor de seguridad no se ejecuta en proceso, no es posible la integración directa con marcos de lenguaje específicos. Sin embargo, la información relevante que necesita la aplicación se proporciona en los encabezados de solicitud.

#### Flujo de autenticación

El flujo de autenticación es el mismo para todos los proveedores, pero difiere según si desea iniciar sesión con el SDK del proveedor:

- **Sin SDK de proveedor** (flujo dirigido por el servidor o flujo del servidor): La aplicación delega el inicio de sesión federado en Container Apps. La delegación es el caso típico de las aplicaciones de explorador, que presenta la página de inicio de sesión del proveedor al usuario.

- **Con SDK de proveedor** (flujo dirigido por el cliente o flujo del cliente): La aplicación inicia la sesión de los usuarios en el proveedor manualmente y luego envía el token de autenticación a Container Apps para su validación. Este enfoque es típico para las aplicaciones sin explorador que no presentan la página de inicio de sesión del proveedor al usuario. Un ejemplo es una aplicación móvil nativa que inicia la sesión de los usuarios con el SDK del proveedor.

### Administración de revisiones y secretos en Azure Container Apps

Azure Container Apps implementa el control de versiones de la aplicación de contenedor mediante la creación de revisiones. Una revisión es una instantánea inmutable de una versión de la aplicación de contenedor. Puede usar revisiones para publicar una nueva versión de la aplicación o revertir rápidamente a una versión anterior. Se crean nuevas revisiones cuando se actualiza la aplicación con [cambios de ámbito de revisión](https://learn.microsoft.com/es-es/azure/container-apps/revisions#revision-scope-changes). También puede actualizar la aplicación de contenedor basándose en una revisión específica.

Puede controlar qué revisiones están activas y el tráfico externo que se enruta a cada revisión activa. Los nombres de revisión se usan para identificar una revisión y en la URL de la revisión. Puede personalizar el nombre de la revisión estableciendo el sufijo de revisión.

De forma predeterminada, Container Apps crea un nombre de revisión único con un sufijo que consiste en una cadena semialeatoria de caracteres alfanuméricos. Por ejemplo, para una aplicación de contenedor llamada _album-api_, establecer el nombre del sufijo de revisión en _1st-revision_ crearía una revisión con el nombre _album-api--1st-revision_. Puede establecer el sufijo de revisión en la plantilla ARM, a través de los comandos `az containerapp create` y `az containerapp update` de la CLI de Azure, o al crear una revisión desde Azure Portal.

#### Actualización de la aplicación de contenedor

Con el comando `az containerapp update` puede modificar variables de entorno, recursos de proceso, parámetros de escala e implementar una imagen diferente. Si la actualización de su aplicación de contenedor incluye [cambios en el ámbito de la revisión](https://learn.microsoft.com/en-us/azure/container-apps/revisions#revision-scope-changes), se genera una nueva revisión.

```sh
az containerapp update \
  --name <APPLICATION_NAME> \
  --resource-group <RESOURCE_GROUP_NAME> \
  --image <IMAGE_NAME>
```

Puede enumerar todas las revisiones asociadas con la aplicación de contenedor con el comando `az containerapp revision list`.

```sh
az containerapp revision list \
  --name <APPLICATION_NAME> \
  --resource-group <RESOURCE_GROUP_NAME> \
  -o table
```

Para más información sobre los comandos de Container Apps, visite la referencia de [`az containerapp`](https://learn.microsoft.com/es-es/cli/azure/containerapp).

#### Administración de secretos en Azure Container Apps

Azure Container Apps permite a la aplicación almacenar de forma segura valores de configuración confidenciales. Una vez que los secretos se definen en el nivel de la aplicación, los valores protegidos están disponibles para las aplicaciones de contenedor. Específicamente, puede hacer referencia a valores protegidos dentro de las reglas de escala.

- Los secretos tienen el ámbito de una aplicación, fuera de cualquier revisión específica de una aplicación.
- Agregar, quitar o cambiar secretos no genera nuevas revisiones.
- Cada revisión de la aplicación puede hacer referencia a uno o más secretos.
- Varias revisiones pueden hacer referencia a los mismos secretos.

Un secreto actualizado o eliminado no afecta automáticamente a las revisiones existentes de la aplicación. Cuando se actualiza o elimina un secreto, puede responder a los cambios de dos maneras:

1. Implementar una nueva revisión.
1. Reiniciar una revisión existente.

Antes de eliminar un secreto, implemente una nueva revisión que ya no haga referencia al secreto anterior. Luego desactive todas las revisiones que hagan referencia al secreto.

:information_source: Container Apps no admite la integración con Azure Key Vault. En su lugar, habilite la identidad administrada en la aplicación de contenedor y use el SDK de Key Vault en la aplicación para acceder a los secretos.

#### Definición de secretos

Al crear una aplicación de contenedor, los secretos se definen mediante el parámetro `--secrets`.

- El parámetro acepta un conjunto de pares nombre/valor delimitado por espacios.
- Cada par está delimitado por un signo igual (`=`).

En el ejemplo siguiente, se declara una cadena de conexión a una cuenta de almacenamiento de cola en el parámetro `--secrets`. El valor de queue-connection-string proviene de una variable de entorno llamada `$CONNECTION_STRING`.

```sh
az containerapp create \
  --resource-group "my-resource-group" \
  --name queuereader \
  --environment "my-environment-name" \
  --image demos/queuereader:v1 \
  --secrets "queue-connection-string=$CONNECTION_STRING"
```

Después de declarar secretos en el nivel de aplicación, puede hacer referencia a ellos en variables de entorno al crear una nueva revisión en la aplicación de contenedor. Cuando una variable de entorno hace referencia a un secreto, su valor se rellena con el valor definido en el secreto. Para hacer referencia a un secreto en una variable de entorno en la CLI de Azure, establezca su valor en `secretref:`, seguido del nombre del secreto.

El siguiente ejemplo muestra una aplicación que declara una cadena de conexión en el nivel de aplicación. Esta conexión se referencia en una variable de entorno del contenedor.

```sh
az containerapp create \
  --resource-group "my-resource-group" \
  --name myQueueApp \
  --environment "my-environment-name" \
  --image demos/myQueueApp:v1 \
  --secrets "queue-connection-string=$CONNECTIONSTRING" \
  --env-vars "QueueName=myqueue" "ConnectionString=secretref:queue-connection-string"
```

### Exploración de la integración de Dapr con Azure Container Apps

El entorno de ejecución de aplicaciones distribuidas (Dapr) es un conjunto de características que se pueden adoptar de forma incremental y que simplifican la creación de aplicaciones distribuidas basadas en microservicios. Dapr proporciona funcionalidades para habilitar la intercomunicación entre aplicaciones mediante mensajería a través de publicación-suscripción o llamadas de servicio a servicio fiables y seguras.

Dapr es un proyecto de código abierto de la [Cloud Native Computing Foundation (CNCF)](https://www.cncf.io/projects/dapr/). La CNCF es parte de Linux Foundation y proporciona soporte, supervisión y dirección para proyectos nativos en la nube de rápido crecimiento. Como alternativa a implementar y administrar el proyecto Dapr OSS por su cuenta, la plataforma Container Apps:

- Proporciona una integración de Dapr administrada y compatible
- Gestiona las actualizaciones de versión de Dapr sin problemas
- Expone un modelo de interacción de Dapr simplificado para aumentar la productividad del desarrollador

#### API de Dapr

![Captura decorativa.](https://learn.microsoft.com/en-us/training/wwl-azure/implement-azure-container-apps/media/azure-container-apps-dapr-building-blocks.png)

| API de Dapr                                                                                                                                    | Descripción                                                                                                                                |
| --------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------ |
| [Invocación de servicio a servicio](https://docs.dapr.io/developing-applications/building-blocks/service-invocation/service-invocation-overview/) | Descubre servicios y realiza llamadas directas y confiables de servicio a servicio con autenticación y cifrado mTLS automáticos.                 |
| [Administración de estado](https://docs.dapr.io/developing-applications/building-blocks/state-management/state-management-overview/)           | Proporciona capacidades de administración de estado para transacciones y operaciones CRUD.                                                               |
| [Pub/sub](https://docs.dapr.io/developing-applications/building-blocks/pubsub/pubsub-overview)                                                | Permite que las aplicaciones de contenedor de publicador y suscriptor se intercomuniquen a través de un agente de mensajes intermediario.                                     |
| [Enlaces](https://docs.dapr.io/developing-applications/building-blocks/bindings/bindings-overview/)                                           | Desencadena las aplicaciones en función de eventos.                                                                                                 |
| [Actores](https://docs.dapr.io/developing-applications/building-blocks/actors/actors-overview/)                                               | Los actores de Dapr son unidades de trabajo de un solo subproceso controladas por mensajes, diseñadas para escalar rápidamente. Por ejemplo, en situaciones de cargas de trabajo con ráfagas intensas. |
| [Observabilidad](https://learn.microsoft.com/es-es/azure/container-apps/observability)                                                        | Envía información de seguimiento a un backend de Application Insights.                                                                               |
| [Secretos](https://docs.dapr.io/developing-applications/building-blocks/secrets/secrets-overview/)                                            | Accede a secretos desde el código de la aplicación o hace referencia a valores seguros en los componentes de Dapr.                                              |
| [Configuración](https://docs.dapr.io/developing-applications/building-blocks/configuration/)                                                  | Recupera y se suscribe a los elementos de configuración de la aplicación para los almacenes de configuración admitidos.                                              |

:information_source: La tabla cubre las API de Dapr estables. Para obtener más información sobre el uso de API y características alfa, [visite las limitaciones](https://learn.microsoft.com/es-es/azure/container-apps/dapr-overview?tabs=bicep1%2Cyaml#unsupported-dapr-capabilities).

#### Conceptos básicos de Dapr

El siguiente ejemplo basado en la API de publicación/suscripción se usa para ilustrar los conceptos básicos relacionados con Dapr en Azure Container Apps.

![Diagrama que muestra la API de pub/sub de Dapr y cómo funciona en Container Apps.](https://learn.microsoft.com/en-us/training/wwl-azure/implement-azure-container-apps/media/distributed-application-runtime-container-apps.png)

| Etiqueta | Configuración de Dapr            | Descripción                                                                                                                                                                                                                                                                  |
| ----- | -------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| 1     | Container Apps con Dapr habilitado | Dapr se habilita en el nivel de la aplicación de contenedor configurando un conjunto de argumentos de Dapr. Estos valores se aplican a todas las revisiones de una aplicación de contenedor determinada cuando se ejecuta en modo de varias revisiones.                                                                                     |
| 2     | Dapr                             | Las API de Dapr totalmente administradas se exponen a cada aplicación de contenedor a través de un sidecar de Dapr. Las API de Dapr se pueden invocar desde la aplicación de contenedor a través de HTTP o gRPC. El sidecar de Dapr se ejecuta en el puerto HTTP 3500 y el puerto gRPC 50001.                                                    |
| 3     | Configuración de componentes de Dapr | Dapr usa un diseño modular en el que la funcionalidad se entrega como un componente. Los componentes de Dapr pueden compartirse entre varias aplicaciones de contenedor. Los identificadores de aplicación de Dapr proporcionados en la matriz `scopes` determinan qué aplicaciones de contenedor habilitadas para Dapr cargan un componente determinado en tiempo de ejecución. |

#### Habilitación de Dapr

Puede configurar Dapr usando varios [argumentos y anotaciones](https://docs.dapr.io/reference/arguments-annotations-overview/) basados en el contexto de tiempo de ejecución. Azure Container Apps proporciona tres canales a través de los cuales puede configurar Dapr:

- CLI de Container Apps
- Plantillas de Infraestructura como código (IaC), como Bicep o plantillas de Azure Resource Manager (ARM)
- El portal de Azure

#### Componentes y ámbitos de Dapr

Dapr utiliza un diseño modular donde la funcionalidad se entrega como un componente. El uso de componentes de Dapr es opcional y dictado exclusivamente por las necesidades de su aplicación.

Los componentes de Dapr en aplicaciones de contenedores son recursos a nivel de entorno que:

- Pueden proporcionar un modelo de abstracción intercambiable para conectarse a servicios externos de apoyo.
- Pueden ser compartidos entre aplicaciones de contenedores o limitados a aplicaciones de contenedores específicas.
- Pueden usar secretos de Dapr para recuperar de forma segura metadatos de configuración.

De forma predeterminada, todas las aplicaciones de contenedores habilitadas para Dapr dentro del mismo entorno cargan el conjunto completo de componentes implementados. Para garantizar que los componentes se carguen en tiempo de ejecución solo por las aplicaciones de contenedores apropiadas, se deben usar ámbitos de aplicación.

---

<!-- ===== Azure App Service ===== -->

# Azure App Service

## Exploración de Azure App Service

Obtenga información sobre los componentes clave de Azure App Service y cómo App Service puede ayudarle a crear, mantener e implementar aplicaciones web de manera más eficiente.

### Examen de Azure App Service

Azure App Service es un servicio basado en HTTP para hospedar aplicaciones web, API REST y back-ends móviles. Puede desarrollar en su lenguaje de programación o marco de trabajo favorito. Las aplicaciones se ejecutan y escalan fácilmente en entornos basados en Windows y Linux.

#### Compatibilidad integrada con el escalado automático

La capacidad de escalar vertical u horizontalmente está integrada en Azure App Service. Según el uso de la aplicación web, puede escalar los recursos de la máquina subyacente que hospeda la aplicación web. Los recursos incluyen el número de núcleos o la cantidad de RAM disponible. El escalado horizontal es la capacidad de aumentar o reducir el número de instancias de máquina que ejecutan la aplicación web.

#### Compatibilidad con contenedores

Con Azure App Service, puede implementar y ejecutar aplicaciones web en contenedores en Windows y Linux. Puede extraer imágenes de contenedor de un Azure Container Registry privado o Docker Hub. Azure App Service también admite aplicaciones de varios contenedores, contenedores de Windows y Docker Compose para orquestar instancias de contenedor.

#### Compatibilidad con integración y entrega continuas (CI/CD)

Azure Portal proporciona integración e implementación continuas listas para usar con Azure DevOps Services, GitHub, Bitbucket, FTP o un repositorio Git local en el equipo de desarrollo. Conecte la aplicación web con cualquiera de los orígenes anteriores y App Service realizará el resto sincronizando automáticamente el código y cualquier cambio futuro en la aplicación web. También se admite la integración e implementación continuas para aplicaciones web en contenedores mediante Azure Container Registry o Docker Hub.

#### Implementación de ranuras

Al implementar una aplicación web, puede usar una ranura de implementación independiente en lugar de la ranura de producción predeterminada cuando se ejecuta en el nivel de plan Standard o superior. Las ranuras de implementación son aplicaciones activas con sus propios nombres de host. Los elementos de contenido y configuración de la aplicación se pueden intercambiar entre dos ranuras de implementación, incluida la ranura de producción.

#### App Service en Linux

App Service también puede alojar aplicaciones web de forma nativa en Linux para pilas de aplicaciones compatibles. También puede ejecutar contenedores Linux personalizados (también conocidos como _Web App for Containers_). App Service en Linux admite muchas imágenes integradas específicas del lenguaje. Solo implemente su código. Los lenguajes y marcos compatibles incluyen: .NET Core, Java (Tomcat, JBoss EAP o Java SE con servidor web incorporado), Node.js, Python y PHP. Si el tiempo de ejecución que requiere su aplicación no es compatible con las imágenes integradas, puede implementarlo con un contenedor personalizado.

Los lenguajes y sus versiones compatibles se actualizan periódicamente. Puede recuperar la lista actual usando el siguiente comando en Cloud Shell.

```sh
az webapp list-runtimes --os-type linux
```

##### Limitaciones

App Service en Linux tiene algunas limitaciones:

- App Service en Linux no es compatible con el nivel de tarifa Compartido.
- Azure Portal muestra solo las características que actualmente funcionan para aplicaciones Linux. A medida que se habilitan las características, se activan en el portal.
- Cuando se implementa en imágenes integradas, su código y contenido se asignan a un volumen de almacenamiento para contenido web, respaldado por Azure Storage. La latencia de disco de este volumen es mayor y más variable que la latencia del sistema de archivos del contenedor. Las aplicaciones que requieren un acceso pesado de solo lectura a archivos de contenido podrían beneficiarse de la opción de contenedor personalizado, que coloca los archivos en el sistema de archivos del contenedor en lugar del volumen de contenido.

#### App Service Environment

App Service Environment es una característica de Azure App Service que proporciona un entorno completamente aislado y dedicado para ejecutar aplicaciones de App Service. Ofrece seguridad mejorada a escala.

A diferencia de la oferta estándar de App Service, donde la infraestructura de soporte es compartida, en App Service Environment los recursos de proceso están dedicados a un único cliente. Para más información sobre las diferencias entre App Service Environment y App Service, consulte la [comparación](https://learn.microsoft.com/es-es/azure/app-service/environment/ase-multi-tenant-comparison).

### Examen de Azure App Service plans

En App Service, una aplicación siempre se ejecuta en un _plan de App Service_. Un plan de App Service define un conjunto de recursos de proceso para que se ejecute una aplicación web. Una o varias aplicaciones se pueden configurar para ejecutarse en los mismos recursos informáticos (o en el mismo plan de App Service).

Al crear un plan de App Service en una región determinada (por ejemplo, Europa Occidental), se crea un conjunto de recursos de proceso para ese plan en dicha región. Todas las aplicaciones que incluya en este plan de App Service se ejecutan en los recursos de proceso definidos por el plan. Cada plan de App Service define:

- Sistema operativo (Windows, Linux)
- Región (Oeste de EE.UU., Este de EE.UU., etc.)
- Número de instancias de máquina virtual
- Tamaño de instancias de máquina virtual (Pequeño, Mediano, Grande)
- Nivel de precios (Gratuito, Compartido, Básico, Estándar, Premium, PremiumV2, PremiumV3, Aislado, AisladoV2)

El _plan de tarifa_ de un plan de App Service determina qué características de App Service obtiene y cuánto paga por el plan. Hay varias categorías de planes de tarifa:

- **Proceso compartido**: **Gratuito** y **Compartido**, los dos niveles base, ejecutan una aplicación en la misma máquina virtual de Azure que otras aplicaciones de App Service, incluyendo aplicaciones de otros clientes. Estos niveles asignan cuotas de CPU a cada aplicación que se ejecuta en los recursos compartidos, y los recursos no pueden escalarse horizontalmente.
- **Proceso dedicado**: Los niveles **Básico**, **Estándar**, **Premium**, **PremiumV2** y **PremiumV3** ejecutan aplicaciones en máquinas virtuales de Azure dedicadas. Solo las aplicaciones del mismo plan de App Service comparten los mismos recursos de proceso. Cuanto mayor sea el nivel, más instancias de máquina virtual estarán disponibles para usted para escalarse horizontalmente.
- **Aislado**: Los niveles **Aislado** e **AisladoV2** ejecutan máquinas virtuales de Azure dedicadas en redes virtuales de Azure dedicadas. Proporciona aislamiento de red además del aislamiento de proceso a sus aplicaciones. Proporciona las capacidades máximas de escalado horizontal.

:information_source: Las opciones de hospedaje de bases y compartidas de App Service (vista previa) se ejecutan en las mismas máquinas virtuales de Azure que otras aplicaciones de App Service. Algunas aplicaciones pueden pertenecer a otros clientes. Estos niveles están destinados a usarse únicamente con fines de desarrollo y prueba.

#### Cómo se ejecuta y escala mi aplicación

En los niveles **Gratuito** y **Compartido**, una aplicación recibe minutos de CPU en una instancia de máquina virtual compartida y no puede escalarse horizontalmente. En otros niveles, una aplicación se ejecuta y escala de la siguiente manera:

- Una aplicación se ejecuta en todas las instancias de máquina virtual configuradas en el plan de App Service.
- Si múltiples aplicaciones están en el mismo plan de App Service, todas comparten las mismas instancias de máquina virtual.
- Si tiene múltiples ranuras de implementación para una aplicación, todas las ranuras de implementación también se ejecutan en las mismas instancias de máquina virtual.
- Si habilita registros de diagnóstico, realiza copias de seguridad o ejecuta WebJobs, también utilizan ciclos de CPU y memoria en estas instancias de máquina virtual.

De esta manera, el plan de App Service es la **unidad de escala** de las aplicaciones de App Service. Si el plan está configurado para ejecutar cinco instancias de máquina virtual, todas las aplicaciones del plan se ejecutan en las cinco instancias. Si el plan está configurado para el escalado automático, todas las aplicaciones del plan se escalan horizontalmente juntas según la configuración de escalado automático.

#### Qué hago si mi aplicación necesita más capacidades o características

Su plan de App Service puede escalarse hacia arriba y hacia abajo en cualquier momento. Es tan simple como cambiar el nivel de precios del plan. Si su aplicación está en el mismo plan de App Service con otras aplicaciones, podría querer mejorar el desempeño de la aplicación aislando los recursos de proceso. Puede hacerlo moviendo la aplicación a un plan de App Service separado.

Posiblemente pueda ahorrar dinero colocando múltiples aplicaciones en un plan de App Service. Sin embargo, dado que las aplicaciones en el mismo plan de App Service comparten los mismos recursos de proceso, necesita comprender la capacidad del plan de App Service existente y la carga esperada para la nueva aplicación.

Aisle su aplicación en un nuevo plan de App Service cuando:

- La aplicación consume muchos recursos.
- Desea más control de sus instancias y desea implementar múltiples aplicaciones en el mismo plan con escalado impulsado por eventos.
- La aplicación necesita recursos en una región geográfica diferente.

De esta manera puede asignar un nuevo conjunto de recursos para la aplicación y obtener mayor control sobre las aplicaciones.

### Implementación en App Service

Cada equipo de desarrollo tiene requisitos únicos que pueden hacer que sea difícil implementar una canalización de implementación eficiente en cualquier servicio en la nube. App Service admite tanto implementación automatizada como manual.

#### Implementación automatizada

La implementación automatizada, o implementación continua, es un proceso utilizado para enviar nuevas características y correcciones de errores en un patrón rápido y repetitivo con efecto mínimo en los usuarios finales.

Azure admite la implementación automatizada directamente desde varias fuentes. Las siguientes opciones están disponibles:

- **Azure DevOps Services**: Puede enviar su código a Azure DevOps Services, compilar su código en la nube, ejecutar las pruebas, generar una versión del código e implementar finalmente su código en una aplicación web de Azure.
- **GitHub**: Azure admite la implementación automatizada directamente desde GitHub. Cuando conecta su repositorio de GitHub a Azure para la implementación automatizada, cualquier cambio que envíe a su rama de producción en GitHub se implementa automáticamente para usted.
- **Bitbucket**: Con sus similitudes con GitHub, puede configurar una implementación automatizada con Bitbucket.

#### Implementación manual

Hay varias opciones que puede usar para enviar manualmente su código a Azure:

- **Git**: Las aplicaciones web de App Service tienen una URL de Git que puede agregar como repositorio remoto. El envío al repositorio remoto implementa su aplicación.
- **CLI**: `webapp up` es una característica de la interfaz de línea de comandos `az` que empaqueta su aplicación y la implementa. A diferencia de otros métodos de implementación, `az webapp up` puede crear una nueva aplicación web de App Service para usted.
- **Implementación ZIP**: Use `curl` o una utilidad HTTP similar para enviar un ZIP de los archivos de su aplicación a App Service.
- **FTP/S**: FTP o FTPS es una forma tradicional de enviar su código a muchos entornos de hospedaje, incluyendo App Service.

#### Usar ranuras de implementación

Siempre que sea posible, use ranuras de implementación al implementar una nueva compilación de producción. Al usar un nivel de plan de App Service Estándar o superior, puede implementar su aplicación en un entorno de ensayo e intercambiar sus ranuras de ensayo y producción. La operación de intercambio calienta las instancias de trabajador necesarias para que coincidan con su escala de producción, eliminando así tiempos de inactividad.

##### Implementación continua de código

Si el proyecto designa ramas para pruebas, control de calidad y almacenamiento provisional, cada una de esas ramas debe implementarse de forma continua en una ranura de ensayo. Esto permite a las partes interesadas evaluar y probar fácilmente la rama implementada.

##### Implementación continua de contenedores

Para contenedores personalizados de Azure Container Registry u otros registros de contenedores, implemente la imagen en una ranura de ensayo e intercámbiela en producción para evitar tiempos de inactividad. La automatización es más compleja que la implementación de código porque debe insertar la imagen en un registro de contenedores y actualizar la etiqueta de imagen en la aplicación web.

- **Compilar y etiquetar la imagen**: Como parte de la canalización de compilación, etiquete la imagen con el ID de confirmación de Git, una marca de tiempo u otra información identificable. Es mejor no usar la etiqueta predeterminada "latest". De lo contrario, es difícil rastrear qué código está implementado actualmente, lo que complica mucho la depuración.
- **Insertar la imagen etiquetada**: Una vez que la imagen se compila y etiqueta, la canalización inserta la imagen en el registro de contenedores. En el siguiente paso, la ranura de implementación extraerá la imagen etiquetada desde el registro de contenedores.
- **Actualizar la ranura de implementación con la nueva etiqueta de imagen**: Cuando se actualiza esta propiedad, el sitio se reinicia automáticamente y extrae la nueva imagen del contenedor.

#### Contenedores sidecar

En Azure App Service, puede agregar hasta nueve contenedores sidecar para cada aplicación de contenedor personalizada con sidecar habilitado. Los contenedores sidecar permiten implementar servicios y características adicionales en la aplicación de contenedor sin acoplarlos estrechamente al contenedor de aplicación principal. Por ejemplo, puede agregar servicios de supervisión, registro, configuración y red como contenedores sidecar.

Puede añadir un contenedor sidecar a través del **Centro de implementación** en la página de administración de la aplicación.

### Exploración de la autenticación y autorización en App Service

Azure App Service proporciona soporte integrado de autenticación y autorización. Puede permitir que los usuarios inicien sesión y accedan a datos escribiendo código mínimo o sin código en su aplicación web, API REST, back-end móvil o Azure Functions.

#### ¿Por qué utilizar la autenticación integrada?

No está obligado a utilizar App Service para autenticación y autorización. Muchos marcos web se agrupan con características de seguridad, y puede usarlas si lo desea. Si necesita más flexibilidad de la que proporciona App Service, también puede escribir sus propias utilidades.

La característica de autenticación integrada de App Service y Azure Functions puede ahorrarle tiempo y esfuerzo al proporcionar autenticación lista para usar con proveedores de identidades federadas, lo que le permite centrarse en el resto de la aplicación.

- Azure App Service le permite integrar varias capacidades de autenticación en su aplicación web o API sin implementarlas por su cuenta.
- La autenticación está integrada directamente en la plataforma y no requiere ningún lenguaje, SDK, experiencia en seguridad ni código específicos.
- Puede integrarse con varios proveedores de inicio de sesión. Por ejemplo, Microsoft Entra ID, Facebook, Google y X.

#### Proveedores de identidad

App Service utiliza identidad federada, en la cual un proveedor de identidad de terceros administra las identidades del usuario y el flujo de autenticación para usted. Los siguientes proveedores de identidad están disponibles de forma predeterminada:

| Proveedor                   | Punto de conexión de inicio de sesión | Guía de procedimientos                                                                                                                          |
| --------------------------- | ------------------------------------ | ---------------------------------------------------------------------------------------------------------------------------------------- |
| Microsoft Entra             | `/.auth/login/aad`            | [App Service Microsoft Entra login](https://learn.microsoft.com/en-us/azure/app-service/configure-authentication-provider-aad)           |
| Facebook                    | `/.auth/login/facebook`       | [App Service Facebook login](https://learn.microsoft.com/en-us/azure/app-service/configure-authentication-provider-facebook)             |
| Google                      | `/.auth/login/google`         | [App Service Google login](https://learn.microsoft.com/en-us/azure/app-service/configure-authentication-provider-google)                 |
| X                           | `/.auth/login/x`              | [App Service X login](https://learn.microsoft.com/en-us/azure/app-service/configure-authentication-provider-twitter)                     |
| Cualquier proveedor de OpenID Connect | `/.auth/login/<providerName>` | [App Service OpenID Connect login](https://learn.microsoft.com/en-us/azure/app-service/configure-authentication-provider-openid-connect) |
| GitHub                      | `/.auth/login/github`         | [App Service GitHub login](https://learn.microsoft.com/en-us/azure/app-service/configure-authentication-provider-github)                 |

Al configurar esta característica con uno de estos proveedores, su punto de conexión de inicio de sesión está disponible para la autenticación de usuarios y la validación de tokens de autenticación del proveedor. Puede ofrecer a los usuarios cualquier número de estas opciones de inicio de sesión.

#### Cómo funciona

El componente de middleware de autenticación y autorización es una característica de la plataforma que se ejecuta en la misma máquina virtual que la aplicación. Cuando está habilitado, cada solicitud HTTP entrante pasa por él antes de que la aplicación la procese.

El middleware de la plataforma gestiona varios aspectos de la aplicación:

- Autentica usuarios y clientes con el proveedor de identidades especificado
- Valida, almacena y actualiza tokens OAuth emitidos por el proveedor de identidades configurado
- Administra la sesión autenticada
- Inserta información de identidad en los encabezados de solicitud HTTP

El módulo se ejecuta de forma independiente del código de la aplicación y se puede configurar mediante la configuración de Azure Resource Manager o un archivo de configuración. No se requieren SDK, lenguajes de programación específicos ni cambios en el código de la aplicación.

:information_source: En Linux y contenedores, el módulo de autenticación y autorización se ejecuta en un contenedor separado, aislado del código de su aplicación. Dado que no se ejecuta en proceso, no es posible la integración directa con marcos de lenguaje específicos.

El flujo de autenticación es el mismo para todos los proveedores, pero difiere según si desea iniciar sesión con el SDK del proveedor:

- Sin SDK de proveedor: La aplicación delega el inicio de sesión federado en App Service. Esta delegación es típicamente el caso de aplicaciones de navegador, que pueden presentar la página de inicio de sesión del proveedor al usuario. El código del servidor administra el proceso de inicio de sesión y se denomina _flujo dirigido por el servidor_ o _flujo del servidor_.
- Con SDK de proveedor: La aplicación inicia la sesión de los usuarios en el proveedor manualmente y luego envía el token de autenticación a App Service para su validación. Esto es típicamente el caso de aplicaciones sin navegador, que no pueden presentar la página de inicio de sesión del proveedor al usuario. El código de la aplicación administra el proceso de inicio de sesión y se denomina _flujo dirigido por el cliente_ o _flujo del cliente_. Esto se aplica a API REST, Azure Functions, clientes navegador JavaScript y aplicaciones móviles nativas que inician la sesión de usuarios usando el SDK del proveedor.

La siguiente tabla muestra los pasos del flujo de autenticación.

| Paso                            | Sin SDK del proveedor                                                                            | Con SDK del proveedor                                                                                                                               |
| ------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------- |
| Iniciar sesión del usuario                    | Redirige el cliente a `/.auth/login/<provider>`                                                   | El código del cliente inicia la sesión del usuario directamente con el SDK del proveedor y recibe un token de autenticación. Para más información, consulte la documentación del proveedor. |
| Post-autenticación             | El proveedor redirige el cliente a `/.auth/login/<provider>/callback`                                 | El código del cliente publica el token del proveedor a `/.auth/login/<provider>` para validación.                                                              |
| Establecer sesión autenticada | App Service agrega una cookie autenticada a la respuesta                                               | App Service devuelve su propio token de autenticación al código del cliente                                                                                 |
| Servir contenido autenticado     | El cliente incluye la cookie de autenticación en solicitudes posteriores (gestionada automáticamente por el navegador) | El código del cliente presenta el token de autenticación en el encabezado `X-ZUMO-AUTH` (gestionado automáticamente por los SDK de cliente de Mobile Apps)                            |

Para los exploradores cliente, App Service puede redirigir automáticamente a todos los usuarios no autenticados a `/.auth/login/<proveedor>`. También puede presentar a los usuarios uno o más vínculos `/.auth/login/<proveedor>` para iniciar sesión en la aplicación con el proveedor de su elección.

##### Comportamiento de autorización

En Azure Portal, puede configurar App Service con varios comportamientos cuando una solicitud entrante no está autenticada.

- **Permitir solicitudes no autenticadas**: Esta opción aplaza la autorización del tráfico no autenticado al código de su aplicación. Para solicitudes autenticadas, App Service también pasa información de autenticación en los encabezados HTTP. Esta opción proporciona más flexibilidad al manejar solicitudes anónimas. Le permite presentar múltiples proveedores de inicio de sesión a sus usuarios.

- **Requerir autenticación**: Esta opción rechaza cualquier tráfico no autenticado en su aplicación. Este rechazo puede ser una acción de redirección a uno de los proveedores de identidades configurados. En estos casos, un cliente navegador se redirige a `/.auth/login/<provider>` para el proveedor que elige. Si la solicitud anónima proviene de una aplicación móvil nativa, la respuesta devuelta es un HTTP 401 No autorizado. También puede configurar el rechazo para que sea `HTTP 401 No autorizado` o `HTTP 403 Prohibido` para todas las solicitudes.

  :stop_sign: Restringir el acceso de esta manera se aplica a todas las llamadas a su aplicación, lo que puede no ser deseable para aplicaciones que desean tener una página de inicio disponible públicamente, como en muchas aplicaciones de una sola página.

##### Almacenamiento de tokens

App Service proporciona un almacenamiento de tokens integrado, que es un repositorio de tokens asociados con los usuarios de sus aplicaciones web, API o aplicaciones móviles nativas. Cuando habilita la autenticación con cualquier proveedor, este almacenamiento de tokens está inmediatamente disponible para su aplicación.

##### Registro y seguimiento

Si habilita el registro de aplicaciones, los seguimientos de autenticación y autorización se recopilan directamente en los archivos de registro. Si ve un error de autenticación inesperado, puede encontrar todos los detalles fácilmente consultando los registros de aplicaciones existentes.

### Descripción de las características de red de App Service

De forma predeterminada, las aplicaciones alojadas en App Service son accesibles directamente a través de Internet y solo pueden llegar a puntos de conexión alojados en Internet. Para muchas aplicaciones, necesita controlar el tráfico de red entrante y saliente.

Hay dos tipos principales de implementación para Azure App Service:

- El servicio público multiinquilino aloja planes de App Service en las SKU de precios Gratis, Compartido, Básico, Estándar, Premium, PremiumV2 y PremiumV3.
- El entorno de App Service (ASE) multiinquilino aloja planes de App Service de SKU aislado directamente en su red virtual de Azure.

#### Características de red de App Service multiinquilino

Azure App Service es un sistema distribuido. Los roles que manejan solicitudes HTTP o HTTPS entrantes se denominan _front-ends_. Los roles que alojan la carga de trabajo de los clientes se denominan _workers_. Todos los roles en una implementación de App Service existen en una red multiinquilino. Debido a que hay muchos clientes diferentes en la misma unidad de escala de App Service, no puede conectar la red de App Service directamente a su red.

En lugar de conectar las redes, necesita características para manejar varios aspectos de la comunicación de la aplicación. Las características que manejan solicitudes a su aplicación no se pueden usar para resolver problemas cuando realiza llamadas desde su aplicación. Del mismo modo, las características que resuelven problemas para llamadas desde su aplicación no se pueden usar para resolver problemas en su aplicación.

| Características de entrada     | Características de salida                            |
| -------------------- | -------------------------------------------- |
| Dirección asignada a la aplicación | Conexiones híbridas                           |
| Restricciones de acceso  | Integración de red virtual requerida por puerta de enlace |
| Puntos de conexión de servicio    | Integración de red virtual                  |
| Puntos de conexión privados    |                                              |

Puede mezclar las características para resolver sus problemas con algunas excepciones. Los siguientes casos de uso entrantes son ejemplos de cómo usar características de red de App Service para controlar el tráfico entrante en su aplicación.

| Caso de uso entrante | Característica |
| ---------------------------------------------------------------- | -------------------- |
| Compatibilidad con necesidades de SSL basadas en IP para su aplicación | Dirección asignada a la aplicación |
| Compatibilidad con una dirección de entrada dedicada y no compartida para su aplicación | Dirección asignada a la aplicación |
| Restringir el acceso a la aplicación desde un conjunto de direcciones bien definidas | Restricciones de acceso  |

#### Comportamiento de red predeterminado

Las unidades de escala de Azure App Service admiten muchos clientes en cada implementación. Los planes de SKU Gratuito y Compartido alojan cargas de trabajo de clientes en workers multiinquilino. Los planes Básico y superiores alojan cargas de trabajo de clientes que están dedicadas a un solo plan de App Service. Si tiene un plan de App Service Estándar, todas las aplicaciones en ese plan se ejecutan en el mismo worker. Si escala el worker, todas las aplicaciones en ese plan de App Service se replican en un nuevo worker para cada instancia en el plan de App Service.

##### Direcciones de salida

Las máquinas virtuales de trabajo se dividen en gran medida por los planes de App Service. Los planes Gratis, Compartido, Básico, Estándar y Premium usan el mismo tipo de máquina virtual de trabajo. El plan PremiumV2 usa otro tipo de máquina virtual. PremiumV3 usa otro tipo distinto. Cuando cambia la familia de máquinas virtuales, obtiene un conjunto diferente de direcciones de salida.

Hay muchas direcciones que se usan para las llamadas salientes. Las direcciones de salida que usa la aplicación para realizar llamadas salientes se enumeran en las propiedades de la aplicación. Estas direcciones son compartidas por todas las aplicaciones que se ejecutan en la misma familia de máquinas virtuales de trabajo en la implementación de App Service. Si desea ver todas las direcciones que podría usar la aplicación en una unidad de escala, existe una propiedad llamada `possibleOutboundIpAddresses` que las enumera.

##### Buscar IP de salida

Para buscar las direcciones IP de salida que usa actualmente la aplicación en Azure Portal, seleccione **Propiedades** en la navegación izquierda de la aplicación.

Puede encontrar la misma información ejecutando el siguiente comando de la CLI de Azure en Cloud Shell. Aparecen en el campo **Direcciones IP de salida adicionales**.

```sh
az webapp show \
    --resource-group <group_name> \
    --name <app_name> \
    --query outboundIpAddresses \
    --output tsv
```

Para buscar todas las posibles direcciones IP de salida de la aplicación, independientemente de los planes de tarifa, ejecute el siguiente comando en Cloud Shell.

```sh
az webapp show \
    --resource-group <group_name> \
    --name <app_name> \
    --query possibleOutboundIpAddresses \
    --output tsv
```

## Configuración de opciones de la aplicación web

En App Service, la configuración de la aplicación son variables que se pasan como variables de entorno al código de la aplicación.

### Configuración de opciones de la aplicación

En App Service, la configuración de la aplicación son variables que se pasan como variables de entorno al código de la aplicación. Para las aplicaciones Linux y los contenedores personalizados, App Service pasa la configuración de la aplicación al contenedor usando el indicador `--env` para establecer la variable de entorno en el contenedor. En cualquier caso, se insertan en el entorno de la aplicación al iniciarse. Cuando agrega, quita o edita la configuración de la aplicación, App Service desencadena un reinicio de la aplicación.

Para los desarrolladores de ASP.NET y ASP.NET Core, configurar los ajustes de la aplicación en App Service es similar a configurarlos en `<appSettings>` en _Web.config_ o _appsettings.json_, pero los valores de App Service anulan los de _Web.config_ o _appsettings.json_. Puede conservar la configuración de desarrollo (por ejemplo, la contraseña local de MySQL) en _Web.config_ o _appsettings.json_ y los secretos de producción (por ejemplo, la contraseña de la base de datos de Azure MySQL) de forma segura en App Service. El mismo código usa la configuración de desarrollo al depurar localmente, y usa los secretos de producción cuando se implementa en Azure.

La configuración de la aplicación siempre se cifra al almacenarse (cifrado en reposo). Los nombres de configuración de la aplicación solo pueden contener letras, números (0-9), puntos (".") y guiones bajos ("_"). Los caracteres especiales en el valor de una configuración de aplicación deben escaparse según lo requiera el sistema operativo de destino.

Se puede acceder a la configuración de la aplicación navegando a la página de administración de la aplicación y seleccionando **Variables de entorno > Configuración de la aplicación**.

![Captura de navegación a Variables de entorno > Configuración de la aplicación.](../../wwl-azure/configure-web-app-settings/media/configure-app-settings.png)

#### Agregar y editar configuraciones

Para agregar una nueva configuración de aplicación, seleccione **\+ Agregar**. Si usa ranuras de implementación, puede especificar si la configuración es intercambiable o no. En el cuadro de diálogo, puede fijar la configuración a la ranura actual.

![Selección de la configuración de ranura de implementación para fijarla a la ranura actual.](https://learn.microsoft.com/en-us/training/wwl-azure/configure-web-app-settings/media/app-configure-slotsetting.png)

Cuando termine, seleccione **Aplicar**. No olvide seleccionar **Aplicar** de nuevo en la página de **Variables de entorno**.

:information_source: En un servicio de aplicaciones de Linux predeterminado o en un contenedor Linux personalizado, cualquier estructura de clave JSON anidada en el nombre de configuración de la aplicación, como `ApplicationInsights:InstrumentationKey`, debe configurarse en App Service como `ApplicationInsights__InstrumentationKey` para el nombre de clave. En otras palabras, reemplace cualquier `:` con `__` (doble guion bajo). Los puntos en el nombre de configuración de la aplicación se reemplazan con `_` (guion bajo simple).

##### Editar la configuración de la aplicación de forma masiva

Para agregar o editar la configuración de la aplicación de forma masiva, seleccione el botón **Edición avanzada**. Cuando termine, seleccione **Aceptar**. No olvide seleccionar Aplicar de nuevo en la página de Variables de entorno. La configuración de la aplicación tiene el siguiente formato JSON:

```jsonc
[
  {
    "name": "<key-1>",
    "value": "<value-1>",
    "slotSetting": false
  },
  {
    "name": "<key-2>",
    "value": "<value-2>",
    "slotSetting": false
  }
  // ...
]
```

#### Configurar cadenas de conexión

Para los desarrolladores de ASP.NET y ASP.NET Core, configurar las cadenas de conexión en App Service es como configurarlas en `<connectionStrings>` en _Web.config_, pero los valores que establezca en App Service anulan los de _Web.config_. Para otras pilas de lenguaje, es mejor usar la configuración de la aplicación en su lugar, porque las cadenas de conexión requieren un formato especial en las claves de variable para acceder a los valores.

:point_up: Hay un caso en el que es posible que desee usar cadenas de conexión en lugar de configuración de aplicación para lenguajes que no sean .NET: ciertos tipos de bases de datos de Azure se respaldan junto con la aplicación _solo_ si configura una cadena de conexión para la base de datos en la aplicación de App Service.

Agregar y editar cadenas de conexión sigue los mismos principios que otros ajustes de la aplicación y también se pueden vincular a ranuras de implementación. Un ejemplo de cadenas de conexión en formato JSON que usaría para agregar o editar de forma masiva:

```jsonc
[
  {
    "name": "name-1",
    "value": "conn-string-1",
    "type": "SQLServer",
    "slotSetting": false
  },
  {
    "name": "name-2",
    "value": "conn-string-2",
    "type": "PostgreSQL",
    "slotSetting": false
  }
  // ...
]
```

:information_source: Las aplicaciones .NET que tienen como destino PostgreSQL deben establecer la cadena de conexión en **Personalizado** como solución alternativa para un problema conocido en `EnvironmentVariablesConfigurationProvider` de .NET.

En tiempo de ejecución, las cadenas de conexión están disponibles como variables de entorno, con el prefijo de los siguientes tipos de conexión:

- SQLServer: `SQLCONNSTR_`
- MySQL: `MYSQLCONNSTR_`
- SQLAzure: `SQLAZURECONNSTR_`
- Custom: `CUSTOMCONNSTR_`
- PostgreSQL: `POSTGRESQLCONNSTR_`
- Notification Hub: `NOTIFICATIONHUBCONNSTR_`
- Service Bus: `SERVICEBUSCONNSTR_`
- Event Hub: `EVENTHUBCONNSTR_`
- Document DB: `DOCDBCONNSTR_`
- Redis Cache: `REDISCACHECONNSTR_`

Por ejemplo, una cadena de conexión de MySQL llamada _connectionstring1_ se puede acceder como la variable de entorno `MYSQLCONNSTR_connectionString1`.

### Configurar variables de entorno para contenedores personalizados

El contenedor personalizado puede usar variables de entorno que deben proporcionarse externamente. Puede pasarlas a través de Cloud Shell. En Bash:

```bash
az webapp config appsettings set --resource-group <group-name> --name <app-name> --settings key1=value1 key2=value2
```

En PowerShell:

```ps
Set-AzWebApp -ResourceGroupName <group-name> -Name <app-name> -AppSettings @{"DB_HOST"="myownserver.mysql.database.azure.com"}
```

Cuando se ejecuta la aplicación, la configuración de la aplicación de App Service se inserta en el proceso como variables de entorno automáticamente. Puede comprobar las variables de entorno del contenedor con la URL `https://<app-name>.scm.azurewebsites.net/Env`.

### Configuración general

En la sección **Configuración > Configuración general** puede configurar algunos valores comunes de la aplicación. Algunos valores requieren escalar a planes de tarifa superiores.

![Captura de navegación a Configurar > Configuración general.](https://learn.microsoft.com/en-us/training/wwl-azure/configure-web-app-settings/media/configure-general-settings.png)

Lista de la configuración disponible actualmente:

- **Configuración de la pila**: La pila de software para ejecutar la aplicación, incluida la versión del lenguaje y del SDK. Para las aplicaciones Linux y las aplicaciones de contenedor personalizadas, también puede establecer un comando o archivo de inicio opcional.

  ![Establecimiento de la configuración de la pila que incluye el lenguaje de programación.](https://learn.microsoft.com/en-us/training/wwl-azure/configure-web-app-settings/media/open-general-linux.png)

- **Configuración de plataforma**: Permite configurar ajustes para la plataforma de hospedaje, que incluyen:

  - **Arquitectura de plataforma**: 32 bits o 64 bits. Solo para aplicaciones Windows.
  - **Estado de FTP**: Permitir solo FTPS o deshabilitar FTP por completo.
  - **Versión de HTTP**: Establezca en **2.0** para habilitar la compatibilidad con el protocolo HTTPS/2.

    :information_source: La mayoría de los exploradores modernos admiten el protocolo HTTP/2 solo a través de TLS, mientras que el tráfico no cifrado sigue usando HTTP/1.1. Para asegurarse de que los exploradores cliente se conecten a la aplicación con HTTP/2, proteja el nombre DNS personalizado.

  - **WebSockets**: Para ASP.NET SignalR o socket.io, por ejemplo.
  - **Siempre activo**: Mantiene la aplicación cargada incluso cuando no hay tráfico. Cuando **Siempre activo** no está activado (valor predeterminado), la aplicación se descarga después de 20 minutos sin solicitudes entrantes. La aplicación descargada puede causar alta latencia para las nuevas solicitudes a causa del tiempo de preparación. Cuando **Siempre activo** está activado, el equilibrador de carga de front-end envía una solicitud GET a la raíz de la aplicación cada cinco minutos. El ping continuo evita que la aplicación se descargue.

    Siempre activo es necesario para WebJobs continuos o para WebJobs que se desencadenan mediante una expresión CRON.

  - **Versión de canalización administrada**: El modo de canalización de IIS. Establézcalo en **Clásico** si tiene una aplicación heredada que requiere una versión anterior de IIS.
  - **Versión de HTTP**: Establezca en 2.0 para habilitar la compatibilidad con el protocolo HTTPS/2.
  - **Afinidad ARR**: En una implementación de varias instancias, garantiza que el cliente se enrute a la misma instancia durante la vida de la sesión. Puede establecer esta opción en **Desactivado** para aplicaciones sin estado.
  - **Solo HTTPS**: Cuando está habilitado, todo el tráfico HTTP se redirige a HTTPS.
  - **Versión mínima de TLS**: Seleccione la versión mínima de cifrado TLS requerida por la aplicación.

- **Depuración**: Habilite la depuración remota para aplicaciones ASP.NET, ASP.NET Core o Node.js. Esta opción se desactiva automáticamente después de 48 horas.
- **Certificados de cliente entrantes**: Requiera certificados de cliente en la autenticación mutua. La autenticación mutua TLS se usa para restringir el acceso a la aplicación habilitando diferentes tipos de autenticación para ella.

### Configuración de asignaciones de ruta

En la sección **Configuración** > **Asignaciones de ruta** puede configurar asignaciones de controladores y asignaciones de aplicaciones virtuales y directorios. La página **Asignaciones de ruta** muestra diferentes opciones según el tipo de sistema operativo.

#### Aplicaciones Windows (sin contenedor)

Para las aplicaciones Windows, puede personalizar las asignaciones de controladores de IIS y las aplicaciones y directorios virtuales.

Las asignaciones de controladores permiten agregar procesadores de script personalizados para controlar solicitudes de extensiones de archivo específicas. Para agregar un controlador personalizado, seleccione **Nueva asignación de controlador**. Configure el controlador de la siguiente manera:

- **Extensión**: la extensión de archivo que desea controlar, como _\*.php_ o _handler.fcgi_.
- **Procesador de script**: La ruta de acceso absoluta del procesador de script. Las solicitudes a archivos que coincidan con la extensión de archivo se procesan mediante el procesador de script. Use la ruta de acceso `D:\home\site\wwwroot` para referirse al directorio raíz de la aplicación.
- **Argumentos**: Argumentos de línea de comandos opcionales para el procesador de script.

Cada aplicación tiene la ruta raíz predeterminada (`/`) asignada a `D:\home\site\wwwroot`, donde se implementa el código de forma predeterminada. Si la raíz de la aplicación está en una carpeta diferente, o si el repositorio tiene más de una aplicación, puede editar o agregar aplicaciones y directorios virtuales.

Puede configurar aplicaciones y directorios virtuales especificando cada directorio virtual y su ruta física correspondiente relativa a la raíz del sitio web (`D:\home`). Para marcar un directorio virtual como aplicación web, desactive la casilla **Directorio**.

#### Aplicaciones Linux y en contenedor

Puede agregar almacenamiento personalizado para la aplicación en contenedor. Las aplicaciones en contenedor incluyen todas las aplicaciones Linux y también los contenedores personalizados de Windows y Linux que se ejecutan en App Service. Seleccione **Nuevo montaje de Azure Storage** y configure el almacenamiento personalizado de la siguiente manera:

- **Nombre**: El nombre para mostrar.
- **Opciones de configuración**: **Básico** o **Avanzado**. Seleccione **Básico** si la cuenta de almacenamiento no usa puntos de conexión de servicio, puntos de conexión privados o Azure Key Vault. De lo contrario, seleccione **Avanzado**.
- **Cuentas de almacenamiento**: La cuenta de almacenamiento con el contenedor que desea.
- **Tipo de almacenamiento**: **Azure Blobs** o **Azure Files**. Las aplicaciones de contenedor Windows solo admiten Azure Files. Azure Blobs solo admite acceso de solo lectura.
- **Contenedor de almacenamiento**: Para la configuración básica, el contenedor que desea.
- **Nombre del recurso compartido**: Para la configuración avanzada, el nombre del recurso compartido de archivos.
- **Clave de acceso**: Para la configuración avanzada, la clave de acceso.
- **Ruta de montaje**: La ruta absoluta en su contenedor para montar el almacenamiento personalizado.
- **Configuración de ranura de implementación**: Cuando se marca, la configuración de montaje de almacenamiento también se aplica a las ranuras de implementación.

### Habilitación del registro de diagnósticos

Azure App Service proporciona funciones de diagnóstico integradas para ayudarlo a depurar una aplicación de App Service. En esta sección, aprenderá cómo habilitar el registro de diagnósticos, agregar instrumentación a su aplicación y cómo acceder a la información registrada por Azure.

La siguiente tabla muestra los tipos de registro, las plataformas admitidas y dónde se pueden almacenar y ubicar los registros para acceder a la información.

| Tipo                    | Plataforma     | Ubicación                                          | Descripción                                                                                                                                                                                                                                                                                                           |
| ----------------------- | --------------------- | -------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| Registro de aplicaciones | Windows, Linux | Sistema de archivos de App Service y/o blobs de Azure Storage | Registra mensajes generados por el código de la aplicación. Los mensajes se generan mediante el marco web que elija, o directamente desde el código de la aplicación usando el patrón de registro estándar del lenguaje. Cada mensaje se asigna a una de las siguientes categorías: Crítico, Error, Advertencia, Información, Depuración y Rastreo. |
| Registro del servidor web | Windows | Sistema de archivos de App Service o blobs de Azure Storage | Datos sin procesar de solicitud HTTP en formato de archivo de registro extendido W3C. Cada mensaje de registro incluye datos como el método HTTP, URI del recurso, IP del cliente, puerto del cliente, agente de usuario, código de respuesta, etc. |
| Mensajes de error detallados | Windows        | Sistema de archivos de App Service                            | Copias de las páginas de error _.html_ que de otro modo se enviarían al navegador del cliente. Por razones de seguridad, las páginas de error detalladas no deben enviarse a los clientes en producción, pero App Service puede guardar la página de error cada vez que se produce un error de aplicación que tiene un código HTTP de 400 o superior.                         |
| Rastreo de solicitudes fallidas  | Windows        | Sistema de archivos de App Service                            | Información de rastreo detallada sobre solicitudes fallidas, incluido un rastreo de los componentes de IIS utilizados para procesar la solicitud y el tiempo empleado en cada componente. Se genera una carpeta para cada solicitud fallida, que contiene el archivo de registro XML y la hoja de estilos XSL para ver el archivo de registro con.                         |
| Registro de implementación      | Windows, Linux | Sistema de archivos de App Service                            | Ayuda a determinar por qué falló una implementación. El registro de implementación sucede automáticamente y no hay configuraciones configurables para el registro de implementación.                                                                                                                                                                      |

#### Habilitar registro de aplicaciones (Windows)

1. Para habilitar el registro de aplicaciones para aplicaciones Windows en Azure Portal, navegue a su aplicación y seleccione **Registros de App Service**.

1. Seleccione **Activado** para **Registro de aplicaciones (Sistema de archivos)** o **Registro de aplicaciones (Blob)**, o ambos. La opción **Sistema de archivos** es para propósitos de depuración temporal y se desactiva automáticamente después de 12 horas. La opción **Blob** es para registro a largo plazo y necesita un contenedor de almacenamiento de blobs para escribir los registros.

:information_source: Si regenera las claves de acceso de su cuenta de almacenamiento, debe restablecer la configuración de registro correspondiente para usar las claves de acceso actualizadas. Para hacer esto, desactive la característica de registro y luego actívela nuevamente.

1. También puede establecer el **Nivel** de detalles incluidos en el registro como se muestra en la siguiente tabla.

| Nivel       | Categorías incluidas                          |
| ----------- | -------------------------------------------- |
| Deshabilitado    | Ninguno                                         |
| Error       | Error, Crítico                              |
| Advertencia     | Advertencia, Error, Crítico                     |
| Información | Información, Advertencia, Error, Crítico               |
| Detallado     | Rastreo, Depuración, Información, Advertencia, Error, Crítico |

1. Cuando finalice, seleccione **Guardar**.

#### Habilitar registro de aplicaciones (Linux/Contenedor)

1. En **Registros de App Service**, establezca la opción **Registro de aplicaciones** en **Sistema de archivos**.
1. En **Cuota (MB)**, especifique la cuota de disco para los registros de aplicaciones. En **Período de retención (Días)**, establezca el número de días que deben retenerse los registros.
1. Cuando finalice, seleccione **Guardar**.

#### Habilitar registro del servidor web

1. Para **Registro del servidor web**, seleccione **Almacenamiento** para almacenar registros en almacenamiento de blobs, o **Sistema de archivos** para almacenar registros en el sistema de archivos de App Service.
1. En **Período de retención (Días)**, establezca el número de días que deben retenerse los registros.
1. Cuando finalice, seleccione **Guardar**.

#### Agregar mensajes de registro en el código

En el código de la aplicación, use las instalaciones de registro habituales para enviar mensajes de registro a los registros de la aplicación. Por ejemplo:

- Las aplicaciones ASP.NET pueden usar la clase `System.Diagnostics.Trace` para registrar información en el registro de diagnósticos de la aplicación. Por ejemplo:

  ```csharp
  System.Diagnostics.Trace.TraceError("Si está viendo esto, ocurrió un problema");
  ```

  De forma predeterminada, ASP.NET Core utiliza el proveedor de registro `Microsoft.Extensions.Logging.AzureAppServices`.

#### Transmitir registros

Antes de transmitir registros en tiempo real, habilite el tipo de registro que desee. Toda la información escrita en archivos con extensión .txt, .log o .htm almacenados en el directorio `/LogFiles` (`d:/home/logfiles`) la transmite App Service.

:information_source: Algunos tipos de registro almacenan en búfer las escrituras en el archivo de registro, lo que puede resultar en eventos fuera de orden en la transmisión. Por ejemplo, una entrada de registro de aplicación que ocurre cuando un usuario visita una página puede mostrarse en la transmisión antes de la entrada de registro HTTP correspondiente para la solicitud de página.

- Portal de Azure: Para transmitir registros en Azure Portal, navegue a su aplicación y seleccione **Transmisión de registros**.
- CLI de Azure: Para transmitir registros en vivo en Cloud Shell, use el siguiente comando:

  ```sh
  az webapp log tail --name appname --resource-group myResourceGroup
  ```

- Consola local: Para transmitir registros en la consola local, instale la CLI de Azure e inicie sesión en su cuenta. Una vez que haya iniciado sesión, siga las instrucciones que aparecen para la CLI de Azure.

#### Acceder a archivos de registro

Si configuró la opción de blobs de Azure Storage para un tipo de registro, necesita una herramienta de cliente que funcione con Azure Storage.

Para los registros almacenados en el sistema de archivos de App Service, la forma más sencilla es descargar el archivo ZIP en el explorador en:

- Aplicaciones Linux/contenedor: `https://<app-name>.scm.azurewebsites.net/api/logs/docker/zip`
- Aplicaciones Windows: `https://<app-name>.scm.azurewebsites.net/api/dump`

Para las aplicaciones Linux/en contenedor, el archivo ZIP contiene registros de salida de consola tanto para el host de docker como para el contenedor de docker. Para una aplicación escalada horizontalmente, el archivo ZIP contiene un conjunto de registros para cada instancia. En el sistema de archivos de App Service, estos archivos de registro son el contenido del directorio _/home/LogFiles_.

### Configuración de certificados de seguridad

Azure App Service tiene herramientas que le permiten crear, cargar o importar un certificado privado o certificado público en App Service.

Un certificado cargado en una aplicación se almacena en una unidad de implementación vinculada a la combinación de grupo de recursos y región del plan de App Service (denominada internamente _webspace_). El certificado es accesible para otras aplicaciones en la misma combinación de grupo de recursos y región.

La tabla siguiente detalla las opciones que tiene para agregar certificados en App Service:

| Opción                                        | Descripción                                                                                                                                               |
| --------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------- |
| Crear un certificado administrado gratuito de App Service | Un certificado privado que es gratuito y fácil de usar si solo necesita proteger su dominio personalizado en App Service.                                 |
| Comprar un certificado de App Service           | Un certificado privado administrado por Azure. Combina la simplicidad de la gestión automática de certificados con la flexibilidad de las opciones de renovación y exportación. |
| Importar un certificado de Key Vault           | Útil si usa Azure Key Vault para gestionar sus certificados.                                                                                            |
| Cargar un certificado privado                  | Si ya tiene un certificado privado de un proveedor de terceros, puede cargarlo.                                                                 |
| Cargar un certificado público                   | Los certificados públicos no se usan para proteger dominios personalizados, pero puede cargarlos en su código si necesita acceder a recursos remotos.               |

#### Requisitos de certificados privados

El **certificado administrado gratuito de App Service** y el **certificado de App Service** ya cumplen los requisitos de App Service. Si desea usar un certificado privado en App Service, el certificado debe cumplir los siguientes requisitos:

- Debe exportarse como archivo PFX protegido con contraseña, cifrado con Triple DES.
- Contiene una clave privada de al menos 2048 bits.
- Contiene todos los certificados intermedios y el certificado raíz en la cadena de certificados.

Para proteger un dominio personalizado en un enlace TLS, el certificado tiene otros requisitos:

- Contiene Uso de clave extendida para autenticación de servidor (OID = 1.3.6.1.5.5.7.3.1)
- Firmado por una autoridad de certificación de confianza

#### Importar un certificado de App Service

Si adquiere un certificado de App Service de Azure, Azure administra las siguientes tareas:

- Se encarga del proceso de compra del proveedor de certificados.
- Realiza la verificación del dominio del certificado.
- Mantiene el certificado en Azure Key Vault.
- Administra la renovación del certificado.
- Sincroniza automáticamente el certificado con las copias importadas en aplicaciones de App Service.

Si ya tiene un certificado de App Service activo, puede:

- Importar el certificado en App Service.
- Administrar el certificado, como renovarlo, volverlo a crear clave y exportarlo.

:information_source: Los certificados de App Service no se admiten en Azure National Clouds en este momento.

## Escalado de aplicaciones en Azure App Service

El escalado automático permite que un sistema ajuste los recursos requeridos para satisfacer la demanda variada de los usuarios, mientras controla los costos asociados con estos recursos. Puede utilizar escalado automático con muchos servicios de Azure, incluidas aplicaciones web. El escalado automático requiere que configure reglas de escalado automático que especifiquen las condiciones bajo las cuales se deben agregar o eliminar recursos.

### Examen de los factores de escalado automático

Azure App Service admite escalado manual y dos opciones para escalar automáticamente sus aplicaciones web:

- Escalado automático con Azure _autoscale_ (escalado automático). El escalado automático toma decisiones de escalado basadas en reglas que define.
- Escalado automático de Azure App Service _automatic scaling_ (escalado automático). El escalado automático toma decisiones de escalado automáticamente basandose en los parámetros que selecciona.

La siguiente tabla destaca las diferencias entre las dos opciones de escalado automático:

| **Factor**                  | **Escalado automático**                                                                                                                      | **Escalado automático**                                                                                    |
| --------------------------- | ---------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------- |
| **Niveles de precios disponibles** | Estándar e superior                                                                                                                    | Premium V2 (P1V2, P2V2, P3V2) y Premium V3 (P0V3, P1V3, P2V3, P3V3, P1MV3, P2MV3, P3MV3, P4MV3, P5MV3) |
| **Escalado basado en reglas**      | Sí                                                                                                                                | No, la plataforma administra el escalado horizontal y hacia adentro basado en tráfico HTTP.                                     |
| **Escalado basado en programación**  | Sí                                                                                                                                | No                                                                                                       |
| **Instancias siempre listas**  | No, su aplicación web se ejecuta en otras instancias disponibles durante la operación de escalado horizontal, basándose en el umbral definido para las reglas de escalado automático. | Sí (mínimo 1)                                                                                          |
| **Instancias precalentadas**     | No                                                                                                                                 | Sí (predeterminado 1)                                                                                          |
| **Máximo por aplicación**         | No                                                                                                                                 | Sí                                                                                                      |

#### ¿Qué es el escalado automático?

El escalado automático es un sistema o proceso en la nube que ajusta los recursos disponibles basándose en la demanda actual. El escalado automático realiza escalado _horizontal hacia adentro y hacia afuera_, a diferencia del escalado _vertical hacia arriba y hacia abajo_.

El escalado automático puede ser activado según una programación, o evaluando si el sistema se está quedando sin recursos. Por ejemplo, el escalado automático podría activarse si la utilización de CPU crece, el uso de memoria aumenta, el número de solicitudes entrantes a un servicio parece estar aumentando, o alguna combinación de factores.

#### Escalado automático de Azure App Service

El escalado automático en Azure App Service supervisa las métricas de recursos de una aplicación web mientras se ejecuta. Detecta situaciones donde se requieren otros recursos para manejar una carga de trabajo creciente, y garantiza que esos recursos estén disponibles antes de que el sistema se sobrecargue.

El escalado automático responde a cambios en el entorno agregando o eliminando servidores web y equilibrando la carga entre ellos. El escalado automático no tiene ningún efecto en la potencia de CPU, memoria o capacidad de almacenamiento de los servidores web que potencian la aplicación, solo cambia el número de servidores web.

##### Reglas de escalado automático

El escalado automático toma sus decisiones basadas en reglas que usted define. Una regla especifica el umbral para una métrica y desencadena un evento de escalado automático cuando se cruza este umbral. El escalado automático también puede desasignar recursos cuando disminuye la carga de trabajo.

Defina sus reglas de escalado automático cuidadosamente. Por ejemplo, un ataque de denegación de servicio puede resultar en un gran flujo de tráfico entrante. Intentar manejar un aumento en las solicitudes causado por un ataque de DoS sería fútil y costoso. Estas solicitudes no son genuinas y deben descartarse en lugar de procesarse. Una mejor solución es implementar la detección y el filtrado de solicitudes que ocurren durante tal ataque antes de que lleguen a su servicio.

##### ¿Cuándo debería considerar el escalado automático?

El escalado automático proporciona elasticidad para sus servicios. Por ejemplo, podría esperar actividad aumentada/reducida para una aplicación empresarial durante las vacaciones.

El escalado automático mejora la disponibilidad y la tolerancia a fallos. Puede ayudar a garantizar que las solicitudes de cliente a un servicio no sean denegadas porque una instancia sea: no pueda reconocer la solicitud de manera oportuna; o porque una instancia se haya bloqueado.

El escalado automático funciona agregando o eliminando servidores web. Si sus aplicaciones web realizan procesamiento intensivo de recursos como parte de cada solicitud, entonces el escalado automático podría no ser un enfoque efectivo. En estas situaciones, puede ser necesario realizar escalado manual hacia arriba. Por ejemplo, si una solicitud enviada a una aplicación web implica realizar procesamiento complejo en un conjunto de datos grande, dependiendo del tamaño de la instancia, esta sola solicitud podría agotar la capacidad de procesamiento y memoria de la instancia.

El escalado automático no es el mejor enfoque para manejar el crecimiento a largo plazo. Podría tener una aplicación web que comienza con pocos usuarios, pero aumenta en popularidad a lo largo del tiempo. El escalado automático tiene una sobrecarga asociada con la supervisión de recursos y la determinación de si desencadenar un evento de escalado. En este escenario, si puede anticipar la tasa de crecimiento, escalar manualmente el sistema a lo largo del tiempo puede ser un enfoque más rentable.

El número de instancias de un servicio también es un factor importante. Es posible que espere ejecutar solo algunas instancias de un servicio la mayor parte del tiempo. Sin embargo, en esta situación, el servicio es susceptible a tiempos de inactividad o falta de disponibilidad, independientemente de si el escalado automático está habilitado o no. Cuantas menos instancias haya inicialmente, menos capacidad tendrá para manejar una carga de trabajo en aumento mientras el escalado automático pone en marcha más instancias.

#### Escalado automático de Azure App Service

Habilite el escalado automático para un plan de App Service y configure un rango de instancias para cada una de las aplicaciones web. A medida que la aplicación web empieza a recibir tráfico HTTP, App Service supervisa la carga y agrega instancias. Los recursos pueden compartirse cuando varias aplicaciones web dentro de un plan de App Service necesiten escalarse horizontalmente de forma simultánea.

Aquí hay algunos escenarios en los que debe escalar horizontalmente de forma automática:

- No desea configurar reglas de escalado automático basadas en métricas de recursos.
- Desea que sus aplicaciones web dentro del mismo Plan de App Service se escalen de forma diferente e independiente entre sí.
- Su aplicación web está conectada a una base de datos o sistema heredado, que podría no escalar tan rápido como la aplicación web. El escalado automático permite establecer el número máximo de instancias a las que puede escalar su Plan de App Service. Esta configuración ayuda a que la aplicación web no abrume el back-end.

### Identificación de los factores de escalado automático

El escalado automático le permite especificar las condiciones bajo las cuales una aplicación web debe escalarse horizontalmente y volver a reducirse. El escalado automático efectivo garantiza que haya suficientes recursos disponibles para manejar grandes volúmenes de solicitudes en horas pico, mientras administra los costos cuando disminuye la demanda.

Puede configurar el escalado automático para detectar cuándo escalar hacia adentro y hacia afuera de acuerdo con una combinación de factores, basándose en el uso de recursos. También puede configurar el escalado automático para que ocurra de acuerdo con una programación.

En esta sección, aprenderá cómo especificar los factores que se pueden utilizar para escalar automáticamente un servicio.

#### Escalado automático y el Plan de App Service

El escalado automático es una característica del Plan de App Service utilizado por la aplicación web. Cuando la aplicación web se escala horizontalmente, Azure inicia nuevas instancias del hardware definido por el Plan de App Service a la aplicación.

Para evitar el escalado automático descontrolado, un plan de App Service tiene un límite de instancias. Los planes de planes de tarifa más caros tienen un límite mayor. El escalado automático no puede crear más instancias que este límite.

:information_source: No todos los niveles de precios del Plan de App Service admiten escalado automático.

#### Condiciones de escalado automático

Indique cómo realizar el escalado automático creando condiciones de escalado automático. Azure ofrece dos opciones para el escalado automático:

- Escalar en función de una métrica, como la longitud de la cola de disco o el número de solicitudes HTTP que esperan procesamiento.
- Escalar a un recuento de instancias específico según una programación. Por ejemplo, puede organizar el escalado horizontal a una hora concreta del día, en una fecha específica o en un día de la semana. También especifica una fecha de finalización y el sistema reduce horizontalmente en ese momento.

El escalado a un recuento de instancias específico solo le permite escalar horizontalmente a un número definido de instancias. Si necesita escalar horizontalmente de forma incremental, puede combinar el escalado automático basado en métricas y en programación en la misma condición de escalado automático. Por ello, podría organizar que el sistema escale horizontalmente si el número de solicitudes HTTP supera algún umbral, pero solo entre ciertas horas del día.

Puede crear varias condiciones de escalado automático para gestionar diferentes programaciones y métricas. Azure escala automáticamente el servicio cuando se aplica cualquiera de estas condiciones. Un plan de App Service también tiene una condición predeterminada que se usa si ninguna de las otras condiciones es aplicable. Esta condición siempre está activa y no tiene una programación.

#### Métricas para las reglas de escalado automático

El escalado automático por métrica requiere que defina una o más reglas de escalado automático. Una regla de escalado automático especifica una métrica que se debe supervisar y cómo debe responder el escalado automático cuando esta métrica supera un umbral definido. Las métricas que puede supervisar para una aplicación web son:

- **Porcentaje de CPU**: Esta métrica es una indicación del uso de CPU en todas las instancias. Un valor alto indica que las instancias se están convirtiendo en dependientes de la CPU, lo que podría causar retrasos en el procesamiento de solicitudes de clientes.
- **Porcentaje de memoria**: Esta métrica captura el uso de memoria de la aplicación en todas las instancias. Un valor alto indica que la memoria libre podría estar agotándose y podría causar que una o más instancias fallen.
- **Longitud de la cola de disco**: Esta métrica es una medida del número de solicitudes de E/S pendientes en todas las instancias. Un valor alto significa que podría estar produciéndose contención de disco.
- **Longitud de la cola HTTP**: Esta métrica muestra cuántas solicitudes de cliente están esperando procesamiento por parte de la aplicación web. Si este número es grande, las solicitudes de los clientes pueden fallar con errores HTTP 408 (Tiempo de espera agotado).
- **Entrada de datos**: Esta métrica es el número de bytes recibidos en todas las instancias.
- **Salida de datos**: Esta métrica es el número de bytes enviados por todas las instancias.

También puede escalar en función de las métricas de otros servicios de Azure.

#### Cómo analiza las métricas una regla de escalado automático

El escalado automático funciona analizando las tendencias en los valores de métricas a lo largo del tiempo en todas las instancias. El análisis es un proceso de varios pasos.

En el primer paso, una regla de escalado automático agrega los valores recuperados para una métrica de todas las instancias durante un período de tiempo conocido como _intervalo de tiempo_. Cada métrica tiene su propio _intervalo de tiempo_ intrínseco, pero en la mayoría de los casos este período es de 1 minuto. El valor agregado se conoce como _agregación de tiempo_. Las opciones disponibles son _Promedio_, _Mínimo_, _Máximo_, _Suma_, _Último_ y _Recuento_.

Un intervalo de un minuto es un período corto para determinar si cualquier cambio en una métrica es lo suficientemente duradero como para que valga la pena el escalado automático. Por ello, una regla de escalado automático realiza un segundo paso que agrega aún más el valor calculado por la _agregación de tiempo_ durante un período más largo especificado por el usuario, conocido como _Duración_. La _Duración_ mínima es de 5 minutos. Si la _Duración_ se establece en 10 minutos, por ejemplo, la regla de escalado automático agrega los 10 valores calculados para el _intervalo de tiempo_.

El cálculo de agregación para la _Duración_ puede ser diferente del _intervalo de tiempo_. Por ejemplo, si la _agregación de tiempo_ es _Promedio_ y la estadística recopilada es _Porcentaje de CPU_ en un _intervalo de tiempo_ de un minuto, cada minuto se calcula el porcentaje promedio de uso de CPU en todas las instancias. Si la _estadística del intervalo de tiempo_ está establecida en _Máximo_ y la _Duración_ de la regla está establecida en 10 minutos, el máximo de los 10 valores promedio para el porcentaje de uso de CPU determina si se superó el umbral de la regla.

#### Acciones de escalado automático

Cuando una regla de escalado automático detecta que una métrica superó un umbral, puede realizar una acción de escalado automático. Una acción de escalado automático puede ser de _escalado horizontal_ o de _reducción horizontal_. Una acción de escalado horizontal aumenta el número de instancias, y una acción de reducción horizontal reduce el recuento de instancias. Una acción de escalado automático usa un operador (como _menor que_, _mayor que_, _igual a_, etc.) para determinar cómo reaccionar ante el umbral. Las acciones de escalado horizontal suelen usar el operador _mayor que_ para comparar el valor de la métrica con el umbral. Las acciones de reducción horizontal tienden a comparar el valor de la métrica con el umbral usando el operador _menor que_. Una acción de escalado automático también puede establecer el recuento de instancias en un nivel específico, en lugar de incrementar o decrementar el número disponible.

Una acción de escalado automático tiene un período de _recuperación_, especificado en minutos. Durante este intervalo, la regla de escala no se puede volver a desencadenar. Esto es para permitir que el sistema se estabilice entre eventos de escalado automático. Recuerde que se necesita tiempo para iniciar o apagar instancias, por lo que las métricas recopiladas pueden no mostrar cambios significativos durante varios minutos. El período de recuperación mínimo es de cinco minutos.

#### Emparejamiento de reglas de escalado automático

Debe planificar la reducción horizontal cuando disminuya la carga de trabajo. Considere definir las reglas de escalado automático en pares en la misma condición de escalado automático. Una regla de escalado automático debe indicar cómo escalar horizontalmente el sistema cuando una métrica supera un umbral superior. Luego otra regla debe definir cómo reducir horizontalmente el sistema de nuevo cuando la misma métrica cae por debajo de un umbral inferior.

#### Combinación de reglas de escalado automático

Una sola condición de escalado automático puede contener varias reglas de escalado automático (por ejemplo, una regla de escalado horizontal y la correspondiente regla de reducción horizontal). Sin embargo, las reglas de escalado automático en una condición no tienen que estar directamente relacionadas. Podría definir las siguientes cuatro reglas en la misma condición de escalado automático:

- Si la longitud de la cola HTTP supera 10, escalar horizontalmente en 1
- Si el uso de CPU supera el 70 %, escalar horizontalmente en 1
- Si la longitud de la cola HTTP es cero, reducir horizontalmente en 1
- Si el uso de CPU cae por debajo del 50 %, reducir horizontalmente en 1

Al determinar si se debe escalar horizontalmente, la acción de escalado automático se realiza si se cumple **cualquiera** de las reglas de escalado horizontal (la longitud de la cola HTTP supera 10 **o** el uso de CPU supera el 70 %). Al reducir horizontalmente, la acción de escalado automático se ejecuta **solo si se cumplen todas** las reglas de reducción horizontal (la longitud de la cola HTTP cae a cero **y** el uso de CPU cae por debajo del 50 %). Si necesita reducir horizontalmente cuando solo se cumple una de las reglas de reducción horizontal, debe definir las reglas en condiciones de escalado automático independientes.

### Habilitación del escalado automático en App Service

En esta sección, aprenderá a habilitar el escalado automático, crear reglas de escalado automático y supervisar la actividad de escalado automático.

#### Habilitar el escalado automático

Para comenzar con el escalado automático, navegue al plan de App Service en Azure Portal y seleccione **Escalar horizontalmente (plan de App Service)** en el grupo **Configuración** del panel de navegación izquierdo. Seleccione **Basado en reglas** en la sección **Método de escalado horizontal** de la página y, a continuación, seleccione **Configurar**.

:information_source: No todos los planes de tarifa admiten el escalado automático. Los planes de tarifa de desarrollo están limitados a una sola instancia (los planes **F1** y **D1**) o solo proporcionan escalado manual (el plan **B1**). Si seleccionó uno de estos planes, primero debe escalar al plan **S1** o a cualquiera de los planes de producción de nivel **P**.

De forma predeterminada, un plan de App Service solo implementa el escalado manual. Al seleccionar **Escalado automático personalizado** se muestran los grupos de condiciones que puede usar para administrar la configuración de escala.

![Captura de pantalla que muestra la selección de escalado automático personalizado.](https://learn.microsoft.com/en-us/training/wwl-azure/scale-apps-app-service/media/enable-autoscale.png)

#### Agregar condiciones de escala

Una vez habilitado el escalado automático, puede editar la condición de escala predeterminada creada automáticamente y agregar sus propias condiciones de escala personalizadas. Recuerde que cada condición de escala puede escalar según una métrica o escalar a un recuento de instancias específico.

La condición de escala predeterminada se ejecuta cuando ninguna de las otras condiciones de escala está activa.

![Captura de pantalla de la página de condiciones de un plan de App Service que muestra la condición de escalado predeterminada.](https://learn.microsoft.com/en-us/training/wwl-azure/scale-apps-app-service/media/autoscale-conditions.png)

Una condición de escala basada en métricas también puede especificar el número mínimo y máximo de instancias que se crearán. El número máximo no puede superar los límites definidos por el plan de tarifa. Además, todas las condiciones de escala distintas de la predeterminada pueden incluir una programación que indique cuándo se debe aplicar la condición.

#### Crear reglas de escala

Una condición de escala basada en métricas contiene una o más reglas de escala. Use el vínculo **Agregar una regla** para agregar sus propias reglas personalizadas. Debe definir:

- Los criterios que indican cuándo debe desencadenar una regla una acción de escalado automático.
- La acción de escalado automático que se debe realizar.

![Captura de pantalla del panel de configuración de reglas de escalado.](https://learn.microsoft.com/en-us/training/wwl-azure/scale-apps-app-service/media/autoscale-rules.png)

#### Supervisar la actividad de escalado automático

Azure Portal le permite realizar un seguimiento de cuándo se produjo el escalado automático mediante el gráfico **Historial de ejecución**. Este gráfico muestra cómo varía el número de instancias a lo largo del tiempo y qué condiciones de escalado automático causaron cada cambio.

![Captura de pantalla de la información del historial de ejecución de la aplicación.](https://learn.microsoft.com/en-us/training/wwl-azure/scale-apps-app-service/media/autoscale-run-history.png)

Puede usar el gráfico de **Historial de ejecución** con las métricas que se muestran en la página **Información general** para correlacionar los eventos de escalado automático con el uso de recursos.

![Captura de pantalla de las métricas mostradas en la página de información general del plan de App Service.](https://learn.microsoft.com/en-us/training/wwl-azure/scale-apps-app-service/media/service-plan-metrics.png)

### Exploración de los procedimientos recomendados para el escalado automático

Si no sigue los procedimientos recomendados al crear la configuración de escalado automático, puede crear condiciones que produzcan resultados no deseados. En esta sección, aprenderá a evitar la creación de reglas que entren en conflicto entre sí.

#### Conceptos del escalado automático

- Una configuración de escalado automático escala las instancias horizontalmente, es decir, _horizontalmente hacia afuera_ aumentando las instancias y _horizontalmente hacia adentro_ disminuyendo el número de instancias. Una configuración de escalado automático tiene un valor máximo, mínimo y predeterminado de instancias.
- Un trabajo de escalado automático siempre lee la métrica asociada por la cual escalar, verificando si superó el umbral configurado para el escalado horizontal hacia afuera o hacia adentro.
- Todos los umbrales se calculan en el nivel de instancia. Por ejemplo, "escalar horizontalmente en una instancia cuando el promedio de CPU > 80 % cuando el recuento de instancias es 2", significa escalar horizontalmente cuando el promedio de CPU en todas las instancias supera el 80 %.
- Todos los éxitos y errores del escalado automático se registran en el Registro de actividad. Después puede configurar una alerta del registro de actividad para que reciba una notificación por correo electrónico, mensaje de texto o webhooks cuando haya actividad.

#### Procedimientos recomendados del escalado automático

Use los siguientes procedimientos recomendados al crear las reglas de escalado automático.

##### Asegúrese de que los valores máximo y mínimo sean diferentes y tengan un margen adecuado entre ellos

Si tiene una configuración con mínimo=dos, máximo=dos y el recuento de instancias actual es dos, no puede producirse ninguna acción de escala. Mantenga un margen adecuado entre los recuentos de instancias máximo y mínimo, que son inclusivos. El escalado automático siempre escala entre estos límites.

##### Elija la estadística adecuada para la métrica de diagnóstico

Para las métricas de diagnóstico, puede elegir entre _Promedio_, _Mínimo_, _Máximo_ y _Total_ como métrica por la cual escalar. La estadística más común es _Promedio_.

##### Elija los umbrales con cuidado para todos los tipos de métrica

Se recomienda elegir cuidadosamente diferentes umbrales para el escalado horizontal hacia afuera y hacia adentro según las situaciones prácticas.

No se recomienda_ la configuración de escalado automático como los siguientes ejemplos con valores de umbral iguales o similares para las condiciones de escalado hacia afuera y hacia adentro:

- Aumentar instancias en uno cuando el recuento de subprocesos >= 600
- Disminuir instancias en uno cuando el recuento de subprocesos <= 600

Veamos un ejemplo de lo que puede llevar a un comportamiento que podría parecer confuso. Considere la siguiente secuencia.

1. Suponga que hay dos instancias para comenzar y que el número promedio de subprocesos por instancia crece a 625.
1. El escalado automático escala horizontalmente agregando una tercera instancia.
1. A continuación, suponga que el recuento promedio de subprocesos entre instancias cae a 575.
1. Antes de reducir horizontalmente, el escalado automático intenta estimar el estado final si lo hiciera. Por ejemplo, 575 x 3 (recuento de instancias actual) = 1725 / 2 (número final de instancias al reducir) = 862,5 subprocesos. Esto significa que el escalado automático tendría que volver a escalar horizontalmente incluso después de reducir, si el recuento promedio de subprocesos permanece igual o incluso cae solo un poco. Sin embargo, si vuelve a escalar horizontalmente, todo el proceso se repite, lo que lleva a un bucle infinito.
1. Para evitar esta situación (denominada "oscilación"), el escalado automático no reduce en absoluto. En su lugar, omite y vuelve a evaluar la condición la próxima vez que se ejecuta el trabajo del servicio.

La estimación durante una reducción está destinada a evitar situaciones de "oscilación", donde las acciones de reducción y escalado horizontal van y vienen continuamente. Tenga en cuenta este comportamiento cuando elija los mismos umbrales para el escalado y la reducción horizontales.

Se recomienda elegir un margen adecuado entre los umbrales de escalado horizontal hacia afuera y hacia adentro. Como ejemplo, considere la siguiente combinación de reglas mejorada.

- Aumentar instancias en uno cuando CPU% >= 80
- Disminuir instancias en uno cuando CPU% <= 60

En este caso

1. Suponga que comienza con dos instancias.
1. Si el promedio de CPU% en todas las instancias llega a 80, el escalado automático escala horizontalmente agregando una tercera instancia.
1. Ahora suponga que con el tiempo el CPU% cae a 60.
1. La regla de reducción horizontal del escalado automático estima el estado final si se redujera. Por ejemplo, 60 x 3 (recuento de instancias actual) = 180 / 2 (número final de instancias al reducir) = 90. Por ello, el escalado automático no reduce porque tendría que escalar horizontalmente de nuevo inmediatamente. En su lugar, omite la reducción.
1. La próxima vez que el escalado automático comprueba, el CPU sigue cayendo a 50. Estima de nuevo: 50 x 3 instancias = 150 / 2 instancias = 75, que está por debajo del umbral de escalado horizontal de 80, por lo que se reduce correctamente a 2 instancias.

##### Consideraciones para el escalado cuando se configuran varias reglas en un perfil

Hay casos en los que puede que tenga que establecer varias reglas en un perfil. El siguiente conjunto de reglas de escalado automático lo usan los servicios cuando se establecen varias reglas.

En el _escalado horizontal_, el escalado automático se ejecuta si se cumple alguna regla. En la _reducción horizontal_, el escalado automático requiere que se cumplan todas las reglas.

Para ilustrarlo, suponga que tiene las siguientes cuatro reglas de escalado automático:

- Si la CPU < 30 %, reducir horizontalmente en 1
- Si la memoria < 50 %, reducir horizontalmente en 1
- Si la CPU > 75 %, escalar horizontalmente en 1
- Si la memoria > 75 %, escalar horizontalmente en 1

Entonces ocurre lo siguiente:

- Si la CPU es el 76 % y la memoria es el 50 %, se escala horizontalmente.
- Si la CPU es el 50 % y la memoria es el 76 %, se escala horizontalmente.

Por otro lado, si la CPU es el 25 % y la memoria el 51 %, el escalado automático no reduce. Una reducción automática se produciría si la CPU es el 29 % y la memoria el 49 %, ya que ambas reglas de reducción serían verdaderas.

##### Seleccione siempre un recuento de instancias predeterminado seguro

El recuento de instancias predeterminado es importante porque el escalado automático escala el servicio a ese recuento cuando las métricas no están disponibles. Por lo tanto, seleccione un recuento de instancias predeterminado que sea seguro para las cargas de trabajo.

##### Configurar notificaciones de escalado automático

El escalado automático publica en el Registro de actividad si se produce alguna de las siguientes condiciones:

- El escalado automático emite una operación de escalado
- El servicio de escalado automático completa correctamente una acción de escalado
- El servicio de escalado automático no puede realizar una acción de escalado.
- Las métricas no están disponibles para que el servicio de escalado automático tome una decisión de escala.
- Las métricas están disponibles (recuperación) de nuevo para tomar una decisión de escala.

También puede usar una alerta del Registro de actividad para supervisar el estado del motor de escalado automático. Además de usar alertas del registro de actividad, también puede configurar notificaciones por correo electrónico o webhook para recibir notificaciones de acciones de escalado correctas a través de la pestaña de notificaciones en la configuración de escalado automático.

## Exploración de las ranuras de implementación de Azure App Service

La funcionalidad de ranuras de implementación en App Service es una herramienta eficaz que permite obtener una vista previa, administrar, probar e implementar los diferentes entornos de desarrollo.

### Exploración de los entornos de ensayo

Al implementar la aplicación web, la aplicación web en Linux, el back-end móvil o la aplicación de API en Azure App Service, puede usar una ranura de implementación independiente en lugar de la ranura de producción predeterminada. Este enfoque está disponible si ejecuta en el nivel de plan de App Service **Estándar**, **Premium** o **Aislado**. Las ranuras de implementación son aplicaciones activas con sus propios nombres de host. Los elementos de contenido y configuración se pueden intercambiar entre dos ranuras de implementación, incluida la ranura de producción.

Implementar la aplicación en una ranura que no sea de producción tiene los siguientes beneficios:

- Puede validar los cambios de la aplicación en una ranura de implementación de ensayo antes de intercambiarla con la ranura de producción.
- La implementación de una aplicación en una ranura primero e intercambiarla en producción garantiza que todas las instancias de la ranura estén precalentadas antes de ser intercambiadas en producción. Esto elimina el tiempo de inactividad cuando implementa su aplicación. La redirección de tráfico es perfecta y no se pierden solicitudes debido a operaciones de intercambio. Puede automatizar todo este flujo de trabajo configurando intercambio automático cuando no sea necesaria la validación previa al intercambio.
- Después de un intercambio, la aplicación de producción anterior se encuentra en la ranura de ensayo. Si los cambios intercambiados en la ranura de producción no son como esperaba, puede realizar el mismo intercambio inmediatamente para recuperar su "último sitio en buen estado" conocido.

Cada nivel de plan de App Service admite un número diferente de ranuras de implementación. No hay cargo adicional por usar ranuras de implementación. Para saber cuántas ranuras admite el nivel de la aplicación, consulte los [límites de App Service](https://learn.microsoft.com/es-es/azure/azure-resource-manager/management/azure-subscription-service-limits#app-service-limits).

Para escalar la aplicación a un nivel diferente, asegúrese de que el nivel de destino admita el número de ranuras que ya usa la aplicación. Por ejemplo, si la aplicación tiene más de cinco ranuras, no puede reducirla al nivel **Estándar**, porque el nivel **Estándar** solo admite cinco ranuras de implementación.

Al crear una nueva ranura de implementación, la nueva ranura no tiene contenido, aunque clone la configuración de una ranura diferente. Puede implementar en la ranura desde una rama de repositorio diferente o un repositorio diferente.

La URL de la ranura tiene el formato `http://sitename-slotname.azurewebsites.net`. Para mantener la longitud de la URL dentro de los límites necesarios del sistema de nombres de dominio, el nombre del sitio se trunca en 40 caracteres. La combinación del nombre del sitio y el nombre de la ranura debe tener menos de 59 caracteres.

### Examen del intercambio de ranuras

Al intercambiar dos ranuras, App Service completa el siguiente proceso para garantizar que la ranura de destino no experimente tiempo de inactividad:

1. Aplique la siguiente configuración de la ranura de destino (por ejemplo, la ranura de producción) a todas las instancias de la ranura de origen:

   - Configuración de aplicación específica de la ranura y cadenas de conexión, si es aplicable.
   - Configuración de implementación continua, si está habilitada.
   - Configuración de autenticación de App Service, si está habilitada.

   Cuando se aplica cualquiera de las configuraciones a la ranura de origen, el cambio desencadena el reinicio de todas las instancias de la ranura de origen. Durante el **intercambio con vista previa**, esto marca el final de la primera fase. La operación de intercambio se pausa y puede validar que la ranura de origen funciona correctamente con la configuración de la ranura de destino.

1. Espere a que cada instancia en la ranura de origen complete su reinicio. Si alguna instancia no se reinicia correctamente, la operación de intercambio revierte todos los cambios en la ranura de origen y detiene la operación.

1. Si la caché local está habilitada, active la inicialización de caché local realizando una solicitud HTTP a la raíz de la aplicación ("/") en cada instancia de la ranura de origen. Espere hasta que cada instancia devuelva alguna respuesta HTTP. La inicialización de caché local causa otro reinicio en cada instancia.

1. Si el intercambio automático está habilitado con precalentamiento personalizado, active la inicialización de aplicación realizando una solicitud HTTP a la raíz de la aplicación ("/") en cada instancia de la ranura de origen.

   - Si `applicationInitialization` no está especificado, active una solicitud HTTP a la raíz de la aplicación de la ranura de origen en cada instancia.

   - Una instancia se considera precalentada si devuelve alguna respuesta HTTP.

1. Si todas las instancias en la ranura de origen se precalientan correctamente, intercambie las dos ranuras cambiando las reglas de enrutamiento para las dos ranuras. Después de este paso, la ranura de destino (por ejemplo, la ranura de producción) tiene la aplicación previamente precalentada en la ranura de origen.

1. Ahora que la ranura de origen tiene la aplicación previa al intercambio que estaba previamente en la ranura de destino, realice la misma operación aplicando todos los valores y reiniciando las instancias.

En cualquier punto de la operación de intercambio, todo el trabajo de inicialización de las aplicaciones intercambiadas ocurre en la ranura de origen. La ranura de destino permanece en línea mientras se prepara y se precalienta la ranura de origen, sin importar si el intercambio tiene éxito o no. Para intercambiar una ranura de ensayo con la ranura de producción, asegúrese de que la ranura de producción sea siempre la ranura de destino. De esta manera, la operación de intercambio no afecta su aplicación de producción.

Al clonar la configuración desde otra ranura de implementación, la configuración clonada es editable. Algunos elementos de configuración siguen el contenido en un intercambio (no específicos de la ranura), mientras que otros elementos de configuración permanecen en la misma ranura después de un intercambio (específicos de la ranura). La tabla siguiente muestra la configuración que cambia al intercambiar ranuras.

| Configuración que se intercambia                                           | Configuración que no se intercambia                            |
| ------------------------------------------------------------------- | ------------------------------------------------------- |
| Configuración general, como versión de marco, 32/64 bits, WebSockets | Puntos de conexión de publicación                                    |
| Configuración de aplicación (se puede configurar para mantenerse en una ranura)                 | Nombres de dominio personalizado                                     |
| Cadenas de conexión (se pueden configurar para mantenerse en una ranura)           | Certificados no públicos y configuración de TLS/SSL             |
| Asignaciones de controladores                                                    | Configuración de escala                                          |
| Certificados públicos                                                 | Programadores de WebJobs                                      |
| Contenido de WebJobs                                                     | Restricciones de IP                                         |
| Conexiones híbridas                                                  | Siempre activo                                               |
| Red de entrega de contenido de Azure                                      | Configuración del registro de diagnósticos                                 |
| Puntos de conexión de servicio                                                   | Compartir recursos entre orígenes (CORS)                    |
| Asignaciones de ruta                                                       | Integración de red virtual                             |
|                                                                     | Identidades administradas                                      |
|                                                                     | Configuración que termina con el sufijo `\_EXTENSION_VERSION` |

:information_source: Para que la configuración sea intercambiable, agregue la configuración de aplicación `WEBSITE_OVERRIDE_PRESERVE_DEFAULT_STICKY_SLOT_SETTINGS` en cada ranura de la aplicación y establezca su valor en `0` o `false`. Estas configuraciones son todas intercambiables o no todas. No puede hacer que solo algunas configuraciones sean intercambiables y otras no. Las identidades administradas nunca se intercambian y no se ven afectadas por esta configuración de aplicación de anulación.

Para configurar una opción de aplicación o una cadena de conexión para que permanezca en una ranura específica (sin intercambiarse), vaya a la página de configuración de esa ranura. Agregue o edite una configuración y seleccione **Configuración de ranura de implementación**. Al activar esta casilla, se indica a App Service que la configuración no se puede intercambiar.

### Intercambio de ranuras de implementación

Puede intercambiar ranuras de implementación en la página de ranuras de implementación de su aplicación y en la página de descripción general. Antes de intercambiar una aplicación de una ranura de implementación a producción, asegúrese de que la producción sea su ranura de destino y de que todos los valores en la ranura de origen estén configurados exactamente como desea en producción.

#### Intercambio manual de ranuras de implementación

Para intercambiar ranuras de implementación:

1. Ve a la página **Ranuras de implementación** de su aplicación y selecciona **Intercambiar**. El cuadro de diálogo **Intercambiar** muestra la configuración en las ranuras de origen y destino seleccionadas que se cambian.

1. Selecciona las ranuras de **Origen** y **Destino** deseadas. Normalmente, el destino es la ranura de producción. También, selecciona las pestañas **Cambios de origen** y **Cambios de destino** y verifica que los cambios de configuración sean los esperados. Cuando haya terminado, puede intercambiar las ranuras inmediatamente seleccionando **Intercambiar**.

   Para ver cómo se ejecutaría la ranura de destino con la nueva configuración antes de que se produzca el intercambio, no seleccione Intercambiar, sino siga las instrucciones en _Intercambio con vista previa_.

1. Cuando haya terminado, cierre el cuadro de diálogo seleccionando **Cerrar**.

##### Intercambio con vista previa (intercambio multifase)

Antes de intercambiar a producción como ranura de destino, valide que la aplicación se ejecuta con la configuración intercambiada. La ranura de origen también se prepara antes de completar el intercambio, lo que es deseable para aplicaciones críticas para el negocio.

Al realizar un intercambio con vista previa, App Service realiza la misma operación de intercambio pero se detiene después del primer paso. Luego puede comprobar el resultado en la ranura de ensayo antes de completar el intercambio.

Si cancela el intercambio, App Service vuelve a aplicar los elementos de configuración a la ranura de origen.

Para intercambiar con vista previa:

1. Siga los pasos en la sección Intercambiar ranuras de implementación, pero seleccione la casilla de verificación **Realizar intercambio con vista previa**. El cuadro de diálogo le muestra cómo cambia la configuración en la ranura de origen en la fase 1, y cómo cambian la ranura de origen y destino en la fase 2.

1. Cuando esté listo para iniciar el intercambio, seleccione **Iniciar intercambio**.

   Cuando finaliza la fase 1, se le notifica en el cuadro de diálogo. Obtenga una vista previa del intercambio en la ranura de origen accediendo a `https://<app_name>-<source-slot-name>.azurewebsites.net`.

1. Cuando esté listo para completar el intercambio pendiente, seleccione **Completar intercambio** en **Acción de intercambio** y seleccione **Completar intercambio**.

   Para cancelar un intercambio pendiente, seleccione **Cancelar intercambio**.

1. Cuando haya terminado, cierre el cuadro de diálogo seleccionando **Cerrar**.

#### Configurar intercambio automático

El intercambio automático agiliza los escenarios de Azure DevOps Services donde desea implementar su aplicación continuamente sin inicios en frío ni tiempo de inactividad para los clientes de la aplicación. Cuando el intercambio automático está habilitado desde una ranura a producción, cada vez que inserte los cambios del código en esa ranura, App Service intercambia automáticamente la aplicación a producción después de que se calienta la ranura de origen.

:information_source: Actualmente, el intercambio automático no es compatible con aplicaciones web en Linux y Web App para Contenedores.

Para configurar el intercambio automático:

1. Vaya a la página de recursos de su aplicación y seleccione la ranura de implementación que deseal configurar para el intercambio automático. La configuración se encuentra en la página **Configuración** > **Configuración general**.

1. Establezca **Intercambio automático habilitado** en **Activado**. Luego, seleccione la ranura de destino deseada para **Ranura de implementación de intercambio automático** y seleccione **Guardar** en la barra de comandos.

1. Ejecute una confirmación de código en la ranura de origen. El intercambio automático se realiza después de un corto tiempo y la actualización se refleja en la URL de la ranura de destino.

#### Especificar calentamiento personalizado

Algunas aplicaciones pueden requerir acciones de preparación personalizadas antes del intercambio. El elemento de configuración `applicationInitialization` en web.config permite especificar acciones de inicialización personalizadas. La operación de intercambio espera a que finalice esta preparación personalizada antes de intercambiar con la ranura de destino. A continuación se muestra un fragmento de web.config de ejemplo.

```xml
<system.webServer>
  <applicationInitialization>
    <add initializationPage="/" hostName="[app hostname]" />
    <add initializationPage="/Home/About" hostName="[app hostname]" />
  </applicationInitialization>
</system.webServer>
```

Para más información sobre personalización del elemento `applicationInitialization`, consulte [Fallos más comunes de intercambio de ranura de implementación y cómo solucionarlos](https://ruslany.net/2017/11/most-common-deployment-slot-swap-failures-and-how-to-fix-them/).

También puede personalizar el comportamiento de calentamiento con una o ambas de las siguientes configuraciones de aplicación:

- `WEBSITE_SWAP_WARMUP_PING_PATH`: Ruta a la que se hace ping para calentar el sitio. Agregue esta configuración de aplicación especificando como valor una ruta personalizada que comience con una barra diagonal. Un ejemplo es `/statuscheck`. El valor predeterminado es `/`.
- `WEBSITE_SWAP_WARMUP_PING_STATUSES`: Códigos de respuesta HTTP válidos para la operación de calentamiento. Agregue esta configuración de aplicación con una lista de códigos HTTP separados por comas. Un ejemplo es `200,202`. Si el código de estado devuelto no está en la lista, las operaciones de calentamiento e intercambio se detienen. De forma predeterminada, todos los códigos de respuesta son válidos.
- `WEBSITE_WARMUP_PATH`: Ruta relativa del sitio a la que se debe hacer ping cada vez que el sitio se reinicie (no solo durante intercambios de ranura). Algunos valores de ejemplo son `/statuscheck` o la ruta raíz, `/`.

#### Revertir y supervisar un intercambio

Si se producen errores en la ranura de destino (por ejemplo, la ranura de producción) después de un intercambio de ranuras, restaure las ranuras a sus estados anteriores al intercambio intercambiando las mismas dos ranuras de inmediato.

Si la operación de intercambio tarda mucho tiempo en completarse, puede obtener información sobre la operación de intercambio en el registro de actividad.

1. En la página de recursos de la aplicación en el portal, en el panel izquierdo, seleccione **Registro de actividad**.

1. Una operación de intercambio aparece en la consulta de registros como **Swap Web App Slots**. Puede expandirla y seleccionar una de las suboperaciones o errores para ver los detalles.
 

### Enrutamiento del tráfico en App Service

De forma predeterminada, todas las solicitudes de cliente a la URL de producción de la aplicación (`http://<app_name>.azurewebsites.net`) se enrutan a la ranura de producción. Puede enrutar una parte del tráfico a otra ranura. Esta característica es útil si necesita comentarios de usuarios para una nueva actualización, pero aún no está listo para publicarla en producción.
#### Enrutar automáticamente el tráfico de producción
1. Vaya a la página de recursos de la aplicación y seleccione **Ranuras de implementación**.
1. En la columna **Tráfico** % de la ranura a la que desea enrutar, especifique un porcentaje (entre 0 y 100) para representar la cantidad de tráfico total que desea enrutar. Seleccione **Guardar**.
Una vez que un cliente se enruta automáticamente a una ranura específica, queda "anclado" a esa ranura durante la vida de esa sesión de cliente. En el navegador del cliente, puede ver a qué ranura está anclada su sesión al revisar la cookie `x-ms-routing-name` en los encabezados HTTP. Una solicitud enrutada a la ranura "staging" tiene la cookie `x-ms-routing-name=staging`. Una solicitud enrutada a la ranura de producción tiene la cookie `x-ms-routing-name=self`.
#### Enrutar manualmente el tráfico de producción
Para permitir que los usuarios opten por participar en la aplicación beta, establezca el mismo parámetro de consulta con el nombre de la ranura de no producción. Aquí tiene un ejemplo:
A las nuevas ranuras se les asigna una regla de enrutamiento de `0%` de forma predeterminada. Los valores predeterminados se muestran en gris. Cuando establece explícitamente el valor de la regla de enrutamiento en `0%`, el valor se muestra en negro; sus usuarios pueden acceder manualmente a la ranura de staging usando el parámetro de consulta `x-ms-routing-name`. No se enrutan a la ranura automáticamente porque el porcentaje de enrutamiento está en 0. Este es un escenario avanzado en el que puede "ocultar" la ranura de staging del público mientras permite que los equipos internos prueben cambios en la ranura.
#### Introducción a características de Application Insights
Las características incluyen, entre otras:
| Característica                     | Descripción                                                                                                                                                 |
| Live Metrics                       | Observe la actividad de la aplicación implementada en tiempo real sin afectar al entorno host.                                                             |
| Availability                       | También conocido como _Synthetic Transaction Monitoring_, sondee los puntos de conexión externos de su aplicación para probar la disponibilidad y capacidad de respuesta general a lo largo del tiempo. |
| Integración con GitHub o Azure DevOps | Cree elementos de trabajo de GitHub o Azure DevOps en el contexto de los datos de Application Insights.                                                 |
| Uso                                | Comprenda qué características son populares entre los usuarios y cómo interactúan y usan su aplicación.                                                   |
| Smart Detection                    | Detección automática de errores y anomalías mediante análisis proactivo de telemetría.                                                                     |
| Application Map                    | Vista de alto nivel, de arriba abajo, de la arquitectura de la aplicación con referencias visuales rápidas del estado y la capacidad de respuesta de los componentes. |
| Distributed Tracing                | Busque y visualice un flujo de extremo a extremo de una ejecución o transacción determinada.                                                              |
#### Qué supervisa Application Insights
Application Insights recopila datos de métricas y telemetría de la aplicación, que describen la actividad y el estado de la aplicación, así como datos de registros de seguimiento.

#### Enrutar automáticamente el tráfico de producción

Para enrutar el tráfico de producción automáticamente:

1. Vaya a la página de recursos de la aplicación y seleccione **Ranuras de implementación**.

1. En la columna **Tráfico** % de la ranura a la que desea enrutar, especifique un porcentaje (entre 0 y 100) para representar la cantidad de tráfico total que desea enrutar. Seleccione **Guardar**.

Una vez guardada la configuración, el porcentaje de clientes especificado se enruta aleatoriamente a la ranura que no es de producción.

Una vez que un cliente se enruta automáticamente a una ranura específica, queda "anclado" a esa ranura durante la vida de esa sesión de cliente. En el navegador del cliente, puede ver a qué ranura está anclada su sesión consultando la cookie `x-ms-routing-name` en los encabezados HTTP. Una solicitud enrutada a la ranura "staging" tiene la cookie `x-ms-routing-name=staging`. Una solicitud enrutada a la ranura de producción tiene la cookie `x-ms-routing-name=self`.

#### Enrutar manualmente el tráfico de producción

Además del enrutamiento automático del tráfico, App Service puede enrutar solicitudes a una ranura específica. Esto es útil cuando desea que los usuarios puedan participar o no participar en la aplicación beta. Para enrutar el tráfico de producción manualmente, use el parámetro de consulta `x-ms-routing-name`.

Para permitir que los usuarios no participen en la aplicación beta, por ejemplo, puede poner este vínculo en la página web:

```html
<a href="<webappname>.azurewebsites.net/?x-ms-routing-name=self">
  Go back to production app
</a>
```

La cadena `x-ms-routing-name=self` especifica la ranura de producción. El explorador del cliente se redirige a la ranura de producción después de acceder al vínculo. Cada solicitud posterior tiene la cookie `x-ms-routing-name=self` que ancla la sesión a la ranura de producción.

Para permitir que los usuarios participen en su aplicación beta, establezca el mismo parámetro de consulta con el nombre de la ranura de no producción. Aquí tiene un ejemplo:

```xml
<webappname>.azurewebsites.net/?x-ms-routing-name=staging</webappname>
```

A las nuevas ranuras se les asigna una regla de enrutamiento de `0%` de forma predeterminada. Los valores predeterminados se muestran en gris. Cuando establece explícitamente el valor de la regla de enrutamiento en `0%`, el valor se muestra en negro; sus usuarios pueden acceder manualmente a la ranura de staging con el parámetro de consulta `x-ms-routing-name`. No se enrutan automáticamente a la ranura porque el porcentaje de enrutamiento está en 0. Este es un escenario avanzado en el que puede "ocultar" su ranura de staging del público mientras permite que los equipos internos prueben cambios en la ranura.

---

<!-- ===== Azure Functions ===== -->

# Azure Functions

## Exploración de Azure Functions

Azure Functions permite desarrollar aplicaciones sin servidor en Microsoft Azure. Puede escribir solo el código que necesita para el problema en cuestión, sin preocuparse por toda una aplicación ni por la infraestructura para ejecutarla.

### Descripción de Azure Functions

Azure Functions es una solución sin servidor que permite escribir menos código, mantener menos infraestructura y ahorrar costos. En lugar de preocuparse por implementar y mantener servidores, la infraestructura en la nube proporciona todos los recursos actualizados necesarios para mantener las aplicaciones en ejecución.

A menudo construimos sistemas para reaccionar a una serie de eventos críticos. Ya sea que esté construyendo una API web, respondiendo a cambios en la base de datos, procesando transmisiones de datos de IoT, o incluso administrando colas de mensajes, todas las aplicaciones necesitan una forma de ejecutar código cuando ocurren estos eventos.

Azure Functions admite _desencadenadores_, que son formas de iniciar la ejecución del código, y _enlaces_, que son formas de simplificar la codificación de datos de entrada y salida. Hay otros servicios de integración y automatización en Azure y todos pueden resolver problemas de integración y automatizar procesos empresariales. Todos pueden definir entrada, acciones, condiciones y salida.

#### Comparar Azure Functions y Azure Logic Apps

Tanto Functions como Logic Apps son servicios de Azure que habilitan cargas de trabajo sin servidor. Azure Functions es un servicio de proceso sin servidor, mientras que Azure Logic Apps es una plataforma de integración de flujos de trabajo sin servidor. Ambos pueden crear _orquestaciones_ complejas. Una orquestación es una colección de funciones o pasos, denominados acciones en Logic Apps, que se ejecutan para realizar una tarea compleja.

Para Azure Functions, desarrolla orquestaciones escribiendo código y usando la [extensión Durable Functions](https://learn.microsoft.com/es-es/azure/azure-functions/durable/durable-functions-overview). Para Logic Apps, crea orquestaciones usando una interfaz gráfica o editando archivos de configuración.

La siguiente tabla enumera algunas de las diferencias clave entre Functions y Logic Apps:

| Tema             | Azure Functions                                                       | Logic Apps                                                                                             |
| ----------------- | --------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------ |
| Development       | Código primero (imperativo)                                               | Diseñador primero (declarativo)                                                                           |
| Conectividad      | Aproximadamente una docena de tipos de enlace integrados, escriba código para enlaces personalizados  | Amplia colección de conectores, Enterprise Integration Pack para escenarios B2B, crear conectores personalizados |
| Acciones           | Cada actividad es una función de Azure; escriba código para funciones de actividad | Amplia colección de acciones preparadas                                                                 |
| Supervisión        | Azure Application Insights                                            | Portal de Azure, registros de Azure Monitor                                                                       |
| Administración        | API REST, Visual Studio                                               | Portal de Azure, API REST, PowerShell, Visual Studio                                                      |
| Contexto de ejecución | Se ejecuta en Azure o localmente                                             | Se ejecuta en Azure, localmente o en instalaciones                                                                 |

#### Comparar Functions y WebJobs

Al igual que Azure Functions, Azure App Service WebJobs con el SDK de WebJobs es un servicio de integración centrado en código diseñado para desarrolladores. Ambos están integrados en Azure App Service y admiten características como la integración del control de código fuente, la autenticación y la supervisión con la integración de Application Insights.

Azure Functions está construido sobre el SDK de WebJobs, por lo que comparte muchos de los mismos desencadenadores de eventos y conexiones a otros servicios de Azure. Aquí hay algunos factores a considerar cuando está eligiendo entre Azure Functions y WebJobs con el SDK de WebJobs:

| Factor                                      | Funciones                                                                                                                                                                 | WebJobs con SDK de WebJobs                                                                                                             |
| ------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------ |
| Modelo de aplicación sin servidor con escalado automático | Sí                                                                                                                                                                       | No                                                                                                                                   |
| Desarrollar y probar en el navegador                 | Sí                                                                                                                                                                       | No                                                                                                                                   |
| Precios de pago por uso                         | Sí                                                                                                                                                                       | No                                                                                                                                   |
| Integración con Logic Apps                 | Sí                                                                                                                                                                       | No                                                                                                                                   |
| Desencadenar eventos                              | Timer<br>Colas y blobs de Azure Storage<br>Colas y temas de Azure Service Bus<br>Azure Cosmos DB<br>Azure Event Hubs<br>HTTP/WebHook (GitHub, Slack)<br>Azure Event Grid | Timer<br>Colas y blobs de Azure Storage<br>Colas y temas de Azure Service Bus<br>Azure Cosmos DB<br>Azure Event Hubs<br>Sistema de archivos |

Azure Functions ofrece más productividad de desarrolladores que Azure App Service WebJobs. También ofrece más opciones para lenguajes de programación, entornos de desarrollo, integración de servicios de Azure y precios. Para la mayoría de los escenarios, es la mejor opción.

### Comparación de las opciones de hospedaje de Azure Functions

Al crear una aplicación de funciones en Azure, debe elegir un plan de hospedaje para la aplicación. Azure proporciona las siguientes opciones de hospedaje para el código de la función:

| Opción de hospedaje                                                                                              | Servicio             | Disponibilidad           | Compatibilidad con contenedores |
| -------------------------------------------------------------------------------------------------------------- | -------------------- | ------------------------ | ----------------- |
| **[Consumption plan](https://learn.microsoft.com/en-us/azure/azure-functions/consumption-plan)**               | Azure Functions      | Generally available (GA) | None              |
| **[Flex Consumption plan](https://learn.microsoft.com/en-us/azure/azure-functions/flex-consumption-plan)**     | Azure Functions      | GA                       | None              |
| **[Premium plan](https://learn.microsoft.com/en-us/azure/azure-functions/functions-premium-plan)**             | Azure Functions      | GA                       | Linux             |
| **[Dedicated plan](https://learn.microsoft.com/en-us/azure/azure-functions/dedicated-plan)**                   | Azure Functions      | GA                       | Linux             |
| **[Container Apps](https://learn.microsoft.com/en-us/azure/azure-functions/functions-container-apps-hosting)** | Azure Container Apps | GA                       | Linux             |

La infraestructura de Azure App Service facilita el hospedaje de Azure Functions tanto en máquinas virtuales Linux como Windows. La opción de hospedaje que elija dicta los siguientes comportamientos:

- Cómo se escala su aplicación de funciones.
- Los recursos disponibles para cada instancia de aplicación de funciones.
- Soporte para funcionalidad avanzada, como conectividad de Azure Virtual Network.
- Soporte para contenedores Linux.

El plan que elija también afecta a los costos de ejecución del código de la función.

#### Información general sobre planes

A continuación se presenta un resumen de los beneficios de las diversas opciones de hospedaje:

##### Plan de consumo

El plan de consumo es el plan de hospedaje predeterminado. Pague por los recursos de proceso solo cuando las funciones se estén ejecutando (pago por uso) con escala automática. En el plan de consumo, las instancias del host de Functions se agregan y se eliminan dinámicamente según el número de eventos entrantes.

##### Plan de consumo flexible

Obtenga escalabilidad altamente, combinada con opciones de proceso, redes virtuales y facturación de pago por uso. En el plan de consumo flexible, las instancias del host de Functions se agregan y se eliminan dinámicamente según la concurrencia configurada por instancia y el número de eventos entrantes.

Puede reducir los inicios en frío especificando el número de instancias preaprovisionadas (siempre listas). Se escala automáticamente según la demanda.

##### Plan Premium

Se escala automáticamente según la demanda mediante trabajadores preactivados, que ejecutan aplicaciones sin demora después de estar inactivas, se ejecutan en instancias más potentes y se conectan a redes virtuales.

Considere el plan Premium de Azure Functions en las siguientes situaciones:

- Sus aplicaciones de funciones se ejecutan continuamente o casi continuamente.
- Desea más control sobre sus instancias y desea implementar máltiples aplicaciones de funciones en el mismo plan con escalado orientado por eventos.
- Tiene un número alto de ejecuciones pequeñas y una factura de ejecución alta, pero segundos GB bajos en el plan de consumo.
- Necesita más opciones de CPU o memoria de las que proporciona el plan de consumo.
- Su código necesita ejecutarse más tiempo que el tiempo máximo de ejecución permitido en el plan de consumo.
- Requiere conectividad de red virtual.
- Desea proporcionar una imagen de Linux personalizada en la que ejecutar sus funciones.

##### Plan dedicado

Ejecute sus funciones dentro de un plan de App Service a tasas regulares del plan de App Service. Es mejor para escenarios de larga duración donde no se puede usar Durable Functions.

Considere un plan de App Service en las siguientes situaciones:

- Debe tener facturación completamente predecible, o necesita escalar manualmente las instancias.
- Desea ejecutar máltiples aplicaciones web y aplicaciones de funciones en el mismo plan
- Necesita acceso a opciones de tamaño de proceso más grandes.
- Aislamiento de proceso completo y acceso a la red seguro proporcionado por un Entorno de App Service (ASE).
- Uso de memoria alto y escalado alto (ASE).

##### Container Apps

Cree e implemente aplicaciones de funciones en contenedores en un entorno completamente administrado alojado por Azure Container Apps.

Utilice el modelo de programación de Azure Functions para crear aplicaciones de funciones sin servidor, orientadas por eventos y nativas de la nube. Ejecute sus funciones junto con otros microservicios, APIs, sitios web y flujos de trabajo como programas alojados en contenedores.

Considere alojar sus funciones en Container Apps en las siguientes situaciones:

- Desea empaquetar bibliotecas personalizadas con el código de su función para respaldar aplicaciones de línea de negocio.
- Necesita migrar la ejecución de código de aplicaciones locales o heredadas a microservicios nativos de la nube que se ejecutan en contenedores.
- Desea evitar la sobrecarga y complejidad de administrar clústeres de Kubernetes e infraestructura de proceso dedicada.
- Necesita la potencia de procesamiento de alta gama proporcionada por recursos de proceso de CPU dedicada para sus funciones.

#### Duraci\u00f3n del tiempo de espera de la aplicaci\u00f3n de funciones

La propiedad `functionTimeout` del archivo de proyecto _host.json_ especifica la duración del tiempo de espera de las funciones en una aplicación de funciones. Esta propiedad se aplica específicamente a las ejecuciones de funciones. Una vez que el desencadenador inicia la ejecución de la función, la función debe devolver una respuesta dentro de la duración del tiempo de espera.

La siguiente tabla muestra los valores predeterminados y máximos (en minutos) para planes específicos:

| Plan                  | Predeterminado | Máximo¹   |
| --------------------- | ------- | ---------- |
| Plan de consumo flexible | 30      | Sin límite² |
| Plan Premium          | 30⁴     | Sin límite² |
| Plan dedicado        | 30⁴     | Sin límite³ |
| Container Apps        | 30      | Sin límite⁵ |
| Plan de consumo      | 5       | 10         |

¹ Independientemente de la configuración de tiempo de espera de la aplicación de funciones, 230 segundos es el tiempo máximo que una función desencadenada por HTTP puede tomar para responder a una solicitud. Esto se debe al tiempo de inactividad predeterminado del equilibrador de carga de Azure. Para tiempos de procesamiento más largos, considere usar el patrón asíncrono de Funciones duraderas o diferir el trabajo real y devolver una respuesta inmediata.
² No hay una duración de tiempo de espera de ejecución máximo aplicada. Sin embargo, se da un período de gracia de 60 minutos a la ejecución de una función durante el escalado en los planes de consumo flexible y Premium, y se da un período de gracia de 10 minutos durante las actualizaciones de plataforma.
³ Requiere que el plan de App Service esté configurado en Siempre activo. Se da un período de gracia de 10 minutos durante las actualizaciones de plataforma.
⁴ El tiempo de espera predeterminado para la versión 1.x del runtime del host de Functions es _sin límite_.
⁵ Cuando el número mínimo de réplicas se establece en cero, el tiempo de espera predeterminado depende de los desencadenadores específicos utilizados en la aplicación.

#### Requisitos de la cuenta de almacenamiento

En cualquier plan, una aplicación de funciones requiere una cuenta de Azure Storage de propósito general que admita almacenamiento de Blob, Queue, Files y Table de Azure. Esto se debe a que Functions se basa en Azure Storage para operaciones como administrar desencadenadores y registrar ejecuciones de funciones, pero algunas cuentas de almacenamiento no admiten colas y tablas.

La misma cuenta de almacenamiento que utiliza la aplicación de funciones también puede ser utilizada por los desencadenadores y los enlaces para almacenar los datos de la aplicación. Sin embargo, para operaciones que requieren mucho almacenamiento, debe utilizar una cuenta de almacenamiento separada.

### Escalado de Azure Functions

La siguiente tabla compara los comportamientos de escalado de los distintos planes de hospedaje. El número máximo de instancias se da por aplicación de función (Consumo) o por plan (Premium/Dedicado), a menos que se indique lo contrario.

| Plan                  | Escalar horizontalmente                                                                                                                                                                                                   | Máximo # de instancias                                                            |
| --------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------- |
| Plan de consumo      | Orientado por eventos. Se escala automáticamente, incluso durante períodos de carga alta. La infraestructura de Functions escala los recursos de CPU y memoria agregando más instancias según el número de eventos de desencadenador entrantes. | Windows: 200<br>Linux: 100¹                                                |
| Plan de consumo flexible | Escalado por función. Las decisiones de escalado orientado por eventos se calculan sobre la base de función, proporcionando una forma más determinista de escalar las funciones en su aplicación.                                       | Limitado solo por el uso total de memoria de todas las instancias en una región determinada. |
| Plan Premium          | Orientado por eventos. Se escala automáticamente según el número de eventos en los que se desencadenan sus funciones.                                                                                                    | Windows: 100<br>Linux: 20-100²                                             |
| Plan dedicado³       | Escalado manual/automático                                                                                                                                                                            | 10-30<br>100 (ASE)                                                         |
| Container Apps        | Orientado por eventos. Se escala automáticamente agregando más instancias del host de Functions, según el número de eventos en los que se desencadenan sus funciones.                                                    | 10-300⁴                                                                    |

1. Durante el escalado horizontal, actualmente hay un límite de 500 instancias por suscripción por hora para aplicaciones de Linux 1. en un plan de Consumo.
2. En algunas regiones, las aplicaciones de Linux en un plan Premium pueden escalar a 100 instancias.
3. Para límites específicos de las distintas opciones de plan de App Service, consulte [Límites del plan de App Service](https://learn.microsoft.com/en-us/azure/azure-resource-manager/management/azure-subscription-service-limits#app-service-limits).
4. En Container Apps, puede establecer el número máximo de réplicas, que se respeta siempre que haya suficiente cuota de núcleos disponible

## Desarrollo de Azure Functions

Las funciones comparten algunos conceptos técnicos principales y componentes, independientemente del lenguaje o enlace que utilice.

### Exploración del desarrollo de Azure Functions

Una aplicación de funciones proporciona un contexto de ejecución en Azure en el que se ejecutan las funciones. Como tal, es la unidad de implementación y administración para las funciones. Una aplicación de funciones se compone de una o más funciones individuales que se administran, implementan y escalan juntas. Todas las funciones en una aplicación de funciones comparten el mismo plan de precios, método de implementación y versión de runtime. Piense en una aplicación de funciones como una forma de organizar y administrar colectivamente sus funciones.

:information_source: En Functions 2.x, todas las funciones en una aplicación de funciones deben crearse en el mismo idioma. En versiones anteriores del runtime de Azure Functions, esto no era necesario.

#### Desarrollar y probar Azure Functions localmente

Functions facilita el uso de su editor de código preferido y herramientas de desarrollo para crear y probar funciones en su computadora local. Sus funciones locales pueden conectarse a servicios de Azure activos, y puede depurarlas en su computadora local usando el runtime completo de Functions.

La forma en que desarrolla funciones en su máquina local depende de sus preferencias de lenguaje y herramientas. Para obtener más información, consulte [Codificar y probar Azure Functions localmente](https://learn.microsoft.com/en-us/azure/azure-functions/functions-develop-local).

:information_source: Debido a limitaciones en la edición del código de función en Azure Portal, debe desarrollar sus funciones localmente e publicar su proyecto de código a una aplicación de funciones en Azure. Para obtener más información, consulte [Limitaciones de desarrollo en Azure Portal](https://learn.microsoft.com/en-us/azure/azure-functions/functions-how-to-use-azure-function-app-settings#development-limitations-in-the-azure-portal)

##### Archivos del proyecto local

Un directorio de proyecto de Functions contiene los siguientes archivos en la carpeta raíz del proyecto, independientemente del lenguaje:

- `host.json`
- `local.settings.json`
- Otros archivos en el proyecto dependen de su idioma y funciones específicas.

El archivo de metadatos `host.json` contiene opciones de configuración que afectan a todas las funciones de una instancia de aplicación de funciones. Otras opciones de configuración de la aplicación de funciones se administran según dónde se ejecute la aplicación de funciones:

- **Implementada en Azure:** en la configuración de la aplicación
- **En el equipo local:** en el archivo `local.settings.json`.

Las configuraciones en `host.json` relacionadas con los enlaces se aplican igualmente a cada función en la aplicación de funciones. También puede invalidar o aplicar la configuración por entorno mediante la configuración de la aplicación. Para obtener más información, consulte la [referencia de host.json](https://learn.microsoft.com/es-es/azure/azure-functions/functions-host-json).

El archivo `local.settings.json` almacena la configuración de la aplicación y la configuración usada por las herramientas de desarrollo local. La configuración del archivo `local.settings.json` solo se usa cuando el proyecto se ejecuta localmente. Al publicar el proyecto en Azure, asegúrese de agregar también la configuración necesaria a la configuración de la aplicación de funciones.

:bangbang: Dado que el `local.settings.json` puede contener secretos, como cadenas de conexión, nunca debe almacenarlo en un repositorio remoto.

##### Sincronizar configuraciones

Al desarrollar las funciones localmente, cualquier configuración local que requiera la aplicación también debe estar presente en la configuración de la aplicación de funciones implementada. También puede descargar la configuración actual de la aplicación de funciones al proyecto local.

### Creación de desencadenadores y enlaces

Un desencadenador define cómo se invoca una función, y una función debe tener exactamente un desencadenador. Los desencadenadores tienen datos asociados, que a menudo se proporcionan como la carga de la función.

Enlazar a una función es una manera de conectar declarativamente otro recurso a la función; los enlaces pueden conectarse como _enlaces de entrada_, _enlaces de salida_ o ambos. Los datos de los enlaces se proporcionan a la función como parámetros.

Puede mezclar y combinar diferentes enlaces según sus necesidades. Los enlaces son opcionales y una función puede tener uno o varios enlaces de entrada o salida.

Los desencadenadores y los enlaces permiten evitar la codificación rígida del acceso a otros servicios. La función recibe datos (por ejemplo, el contenido de un mensaje de cola) en los parámetros de la función. Los datos se envían (por ejemplo, para crear un mensaje de cola) usando el valor devuelto de la función.

Al desarrollar las funciones localmente, debe tener en cuenta los comportamientos de los desencadenadores y los enlaces. Para los desencadenadores HTTP, puede llamar al punto de conexión HTTP en el equipo local usando `http://localhost/`. Para las funciones desencadenadas de forma no HTTP, hay varias opciones para ejecutarlas localmente:

- La forma más fácil de probar los enlaces durante el desarrollo local es usar cadenas de conexión que apunten a servicios de Azure activos. Puede apuntar a servicios activos agregando la configuración de cadenas de conexión adecuada en la matriz `Values` en el archivo local.settings.json. Al hacerlo, las ejecuciones locales durante las pruebas usan los datos del servicio activo. Por ello, considere configurar servicios separados para usar durante el desarrollo y las pruebas, y luego cambiar a diferentes servicios durante la producción.
- Para los desencadenadores basados en almacenamiento, puede usar el [emulador Azurite](/es-es/azure/storage/common/storage-use-azurite) local al probar funciones con enlaces de Azure Storage (Queue Storage, Blob Storage y Table Storage), sin tener que conectarse a servicios de almacenamiento remotos.
- Puede ejecutar manualmente funciones con desencadenadores que no son HTTP usando puntos de conexión de administrador especiales. Para más información, vea [Ejecutar manualmente una función no desencadenada por HTTP](/es-es/azure/azure-functions/functions-manually-run-non-http).

#### Definiciones de desencadenadores y enlaces

Los desencadenadores y los enlaces se definen de manera diferente según el lenguaje de desarrollo.

| Lenguaje                                | Configurar desencadenadores y enlaces mediante...                   |
| --------------------------------------- | ------------------------------------------------------- |
| Biblioteca de clases de C#               | Decorar métodos y parámetros con atributos de C#    |
| Java                                    | Decorar métodos y parámetros con anotaciones de Java |
| JavaScript/PowerShell/Python/TypeScript | Actualizar el esquema de _function.json_                         |

Para los lenguajes que dependen de _function.json_, el portal proporciona una interfaz de usuario para agregar enlaces en la pestaña **Integración**. También puede editar el archivo directamente en el portal en la pestaña **Código + prueba** de la función.

En .NET y Java, el tipo de parámetro define el tipo de datos para los datos de entrada. Por ejemplo, use `string` para enlazar con el texto de un desencadenador de cola, una matriz de bytes para leer como binario y un tipo personalizado para deserializar en un objeto. Dado que las funciones de biblioteca de clases de .NET y las funciones de Java no dependen de _function.json_ para las definiciones de enlace, no se pueden crear ni editar en el portal. La edición en el portal de C# se basa en el script de C#, que usa _function.json_ en lugar de atributos.

Para los lenguajes de tipo dinámico como JavaScript, use la propiedad `dataType` en el archivo _function.json_. Por ejemplo, para leer el contenido de una solicitud HTTP en formato binario, establezca `dataType` en `binary`:

```json
{
  "dataType": "binary",
  "type": "httpTrigger",
  "name": "req",
  "direction": "in"
}
```

Otras opciones para `dataType` son `stream` y `string`.

#### Dirección del enlace

Todos los desencadenadores y enlaces tienen una propiedad de dirección en el archivo _function.json_:

- Para los desencadenadores, la dirección es siempre `in`
- Los enlaces de entrada y salida usan `in` y `out`
- Algunos enlaces admiten una dirección especial `inout`. Si usa `inout`, solo el **Editor avanzado** está disponible a través de la pestaña **Integrar** en el portal.

Cuando usa atributos en una biblioteca de clases para configurar desencadenadores y enlaces, la dirección se proporciona en un constructor de atributos o se infiere del tipo de parámetro.

#### Ejemplo de desencadenador y enlace de Azure Functions

Suponga que quiere escribir una nueva fila en Azure Table Storage cada vez que aparece un nuevo mensaje en Azure Queue Storage. Este escenario se puede implementar usando un desencadenador de Azure Queue Storage y un enlace de salida de Azure Table Storage.

Aquí está el archivo _function.json_ para este escenario.

```json
{
  "disabled": false,
  "bindings": [
    {
      "type": "queueTrigger",
      "direction": "in",
      "name": "myQueueItem",
      "queueName": "myqueue-items",
      "connection": "MyStorageConnectionAppSetting"
    },
    {
      "tableName": "Person",
      "connection": "MyStorageConnectionAppSetting",
      "name": "tableBinding",
      "type": "table",
      "direction": "out"
    }
  ]
}
```

El primer elemento de la matriz `bindings` es el desencadenador de Queue Storage. Las propiedades `type` y `direction` identifican el desencadenador. La propiedad `name` identifica el parámetro de función que recibe el contenido del mensaje de cola. El nombre de la cola que se va a supervisar está en `queueName`, y la cadena de conexión está en la configuración de la aplicación identificada por `connection`.

El segundo elemento de la matriz `bindings` es el enlace de salida de Azure Table Storage. Las propiedades `type` y `direction` identifican el enlace. La propiedad `name` especifica cómo la función proporciona la nueva fila de tabla, en este caso mediante el valor devuelto por la función. El nombre de la tabla está en `tableName`, y la cadena de conexión está en la configuración de la aplicación identificada por `connection`.

##### Ejemplo de función de C#

A continuación se muestra el mismo ejemplo representado en una función de C#. La misma información de desencadenador y enlace, nombres de colas y tablas, cuentas de almacenamiento y parámetros de función para entrada y salida se proporcionan mediante atributos en lugar de un archivo _function.json_.

```csharp
public static class QueueTriggerTableOutput
{
    [FunctionName("QueueTriggerTableOutput")]
    [return: Table("outTable", Connection = "MY_TABLE_STORAGE_ACCT_APP_SETTING")]
    public static Person Run(
        [QueueTrigger("myqueue-items", Connection = "MY_STORAGE_ACCT_APP_SETTING")]JObject order,
        ILogger log)
    {
        return new Person() {
                PartitionKey = "Orders",
                RowKey = Guid.NewGuid().ToString(),
                Name = order["Name"].ToString(),
                MobileNumber = order["MobileNumber"].ToString() };
    }
}

public class Person
{
    public string PartitionKey { get; set; }
    public string RowKey { get; set; }
    public string Name { get; set; }
    public string MobileNumber { get; set; }
}
```

### Conexión de funciones a servicios de Azure

Como procedimiento recomendado de seguridad, Azure Functions aprovecha la funcionalidad de configuración de la aplicación de Azure App Service para ayudarle a almacenar de forma más segura cadenas, claves y otros tokens necesarios para conectarse a otros servicios. La configuración de la aplicación en Azure se almacena cifrada y la aplicación accede a ella en tiempo de ejecución como pares de nombre y valor de variables de entorno. Para los desencadenadores y los enlaces que requieren una propiedad de conexión, se establece el nombre de la configuración de la aplicación en lugar de la cadena de conexión real. No se puede configurar un enlace directamente con una cadena de conexión o clave.

El proveedor de configuración predeterminado usa variables de entorno. Estas variables se definen en la configuración de la aplicación cuando se ejecuta en Azure y en el archivo de configuración local cuando se desarrolla localmente.

#### Configurar una conexión basada en identidad

Algunas conexiones en Azure Functions están configuradas para usar una identidad en lugar de un secreto. La compatibilidad depende de la extensión que usa la conexión. En algunos casos, es posible que todavía se requiera una cadena de conexión en Functions aunque el servicio al que se conecta admita conexiones basadas en identidad.

:information_source: Una aplicación que se ejecuta en un plan de Consumo o Premium Elástico usa la configuración `WEBSITE_AZUREFILESCONNECTIONSTRING` y `WEBSITE_CONTENTSHARE` cuando se conecta a Azure Files en la cuenta de almacenamiento usada por la aplicación de funciones. Azure Files no admite el uso de identidad administrada cuando se accede al recurso compartido de archivos.

Cuando se hospeda en el servicio Azure Functions, las conexiones basadas en identidades usan una identidad administrada. La identidad asignada por el sistema se usa de forma predeterminada, aunque se puede especificar una identidad asignada por el usuario con las propiedades `credential` y `clientID`. No se admite la configuración de una identidad asignada por el usuario con un identificador de recurso. Cuando se ejecuta en otros contextos, como el desarrollo local, se usa la identidad del desarrollador, aunque esto puede personalizarse.

#### Conceder permiso a la identidad

Las identidades deben tener permisos para realizar las acciones previstas. Normalmente, esto se hace asignando un rol en el control de acceso basado en roles de Azure o especificando la identidad en una directiva de acceso, según el servicio al que se conecte.

:bangbang: Algunos permisos pueden ser expuestos por el servicio de destino que no son necesarios para todos los contextos. Siempre que sea posible, siga el **principio de privilegio mínimo**, concediendo a la identidad solo los privilegios necesarios.

---

# PARTE 2 — Desarrollo para Azure Storage (15-20 %)

---

<!-- ===== Azure Cosmos DB ===== -->

# Azure Cosmos DB

## Exploración de Azure Cosmos DB

Azure Cosmos DB es un sistema de base de datos distribuido globalmente que le permite leer y escribir datos desde las réplicas locales de la base de datos y replica los datos de forma transparente en todas las regiones asociadas a la cuenta de Cosmos.

### Identificación de los principales beneficios de Azure Cosmos DB

Azure Cosmos DB es una base de datos NoSQL totalmente administrada diseñada para proporcionar baja latencia, escalabilidad elástica del rendimiento, semántica bien definida para la coherencia de datos y alta disponibilidad.

Puede configurar las bases de datos para que estén distribuidas globalmente y disponibles en cualquiera de las regiones de Azure. Para reducir la latencia, coloque los datos cerca de donde están los usuarios. La elección de las regiones necesarias depende del alcance global de la aplicación y de dónde se encuentran los usuarios.

Con Azure Cosmos DB, puede agregar o quitar las regiones asociadas a la cuenta en cualquier momento. La aplicación no necesita pausarse ni reimplementarse para agregar o quitar una región.

#### Principales ventajas de la distribución global

Con su novedoso protocolo de replicación multimaestro, cada región admite tanto escrituras como lecturas. La funcionalidad multimaestro también permite:

- Escalabilidad elástica de escritura y lectura ilimitada.
- 99,999 % de disponibilidad de lectura y escritura en todo el mundo.
- Lecturas y escrituras garantizadas servidas en menos de 10 milisegundos en el percentil 99.

La aplicación puede realizar lecturas y escrituras casi en tiempo real en todas las regiones que eligió para la base de datos. Azure Cosmos DB controla internamente la replicación de datos entre regiones con garantías del nivel de coherencia del nivel seleccionado.

Ejecutar una base de datos en varias regiones del mundo aumenta la disponibilidad de la base de datos. Si una región no está disponible, otras regiones controlan automáticamente las solicitudes de la aplicación. Azure Cosmos DB ofrece una disponibilidad de lectura y escritura del 99,999 % para bases de datos en varias regiones.

### Exploración de la jerarquía de recursos

La cuenta de Azure Cosmos DB es la unidad fundamental de distribución global y alta disponibilidad. La cuenta de Azure Cosmos DB contiene un nombre único del Sistema de nombres de dominio (DNS) y puede administrar una cuenta mediante Azure Portal, la CLI de Azure o usando diferentes SDK específicos de lenguaje. Para distribuir globalmente los datos y el rendimiento en varias regiones de Azure, puede agregar y quitar regiones de Azure a la cuenta en cualquier momento.

#### Elementos de una cuenta de Azure Cosmos DB

Un contenedor de Azure Cosmos DB es la unidad fundamental de escalabilidad. Prácticamente puede tener un rendimiento aprovisionado (RU/s) y almacenamiento ilimitados en un contenedor. Azure Cosmos DB particiona el contenedor de forma transparente usando la clave de partición lógica que especifique para escalar elásticamente el rendimiento aprovisionado y el almacenamiento.

Actualmente, puede crear un máximo de 50 cuentas de Azure Cosmos DB en una suscripción de Azure (se puede aumentar a través de una solicitud de soporte técnico). Después de crear una cuenta en la suscripción de Azure, puede administrar los datos de la cuenta creando bases de datos, contenedores y elementos.

La siguiente imagen muestra la jerarquía de las diferentes entidades de una cuenta de Azure Cosmos DB:

![Imagen que muestra la jerarquía de entidades de Azure Cosmos DB: las cuentas de base de datos están en la parte superior, las bases de datos se agrupan bajo las cuentas y los contenedores se agrupan bajo las bases de datos.](https://learn.microsoft.com/en-us/training/wwl-azure/explore-azure-cosmos-db/media/cosmos-entities.png)

#### Bases de datos de Azure Cosmos DB

Puede crear una o varias bases de datos de Azure Cosmos DB en la cuenta. Una base de datos es análoga a un espacio de nombres. Una base de datos es la unidad de administración de un conjunto de contenedores de Azure Cosmos DB.

#### Contenedores de Azure Cosmos DB

Un contenedor de Azure Cosmos DB es donde se almacenan los datos. A diferencia de la mayoría de las bases de datos relacionales, que escalan verticalmente con tamaños de máquinas virtuales más grandes, Azure Cosmos DB escala horizontalmente.

Los datos se almacenan en uno o más servidores denominados _particiones_. Para aumentar las particiones, aumenta el rendimiento, o crecen automáticamente a medida que aumenta el almacenamiento. Esta relación proporciona una cantidad prácticamente ilimitada de rendimiento y almacenamiento para un contenedor.

Al crear un contenedor, debe proporcionar una clave de partición. La clave de partición es una propiedad que selecciona de los elementos para ayudar a Azure Cosmos DB a distribuir los datos de forma eficiente entre particiones. Azure Cosmos DB usa el valor de esta propiedad para enrutar los datos a la partición adecuada para que se escriban, actualicen o eliminen. También puede usar la clave de partición en la cláusula `WHERE` de las consultas para una recuperación de datos eficiente.

El mecanismo de almacenamiento subyacente para los datos en Azure Cosmos DB se denomina _partición física_. Las particiones físicas pueden tener hasta 10 000 unidades de solicitud por segundo y pueden almacenar hasta 50 GB de datos. Azure Cosmos DB abstrae este concepto de particionamiento con una partición lógica, que puede almacenar hasta 20 GB de datos.

Al crear un contenedor, se configura el rendimiento en uno de los siguientes modos:

- **Rendimiento dedicado**: El rendimiento de un contenedor está reservado exclusivamente para ese contenedor. Hay dos tipos de rendimiento dedicado: estándar y escalado automático.
- **Rendimiento compartido**: El rendimiento se especifica en el nivel de la base de datos y luego se comparte con hasta 25 contenedores dentro de la base de datos. El uso compartido del rendimiento excluye los contenedores que están configurados con su propio rendimiento dedicado.

#### Elementos de Azure Cosmos DB

Dependiendo de qué API use, las entidades de datos individuales se pueden representar de varias maneras:

| Entidad de Azure Cosmos DB | API para NoSQL | API para Cassandra | API para MongoDB | API para Gremlin | API para Table |
| ---------------------- | ------------- | ----------------- | --------------- | --------------- | ------------- |
| Azure Cosmos DB item   | Item          | Row               | Document        | Node or edge    | Item          |

### Exploración de los niveles de coherencia

Azure Cosmos DB aborda la coherencia de datos como un espectro de opciones en lugar de dos extremos. La coherencia fuerte y la coherencia eventual están en los extremos del espectro, pero hay muchas opciones de coherencia entre ambos. Los desarrolladores pueden usar estas opciones para tomar decisiones precisas y equilibrar con granularidad alta disponibilidad y rendimiento.

Azure Cosmos DB ofrece cinco niveles bien definidos. De mayor a menor fuerza, los niveles son:

- Fuerte
- Obsolescencia limitada
- Sesión
- Prefijo consistente
- Eventual

Cada nivel proporciona equilibrios de disponibilidad y rendimiento. La siguiente imagen muestra los diferentes niveles de coherencia como un espectro.

![Imagen que muestra la coherencia de datos como un espectro.](https://learn.microsoft.com/en-us/training/wwl-azure/explore-azure-cosmos-db/media/five-consistency-levels.png)

Los niveles de coherencia son independientes de la región y están garantizados para todas las operaciones, independientemente de:

- La región donde se atienden las lecturas y escrituras
- El número de regiones asociadas a su cuenta de Azure Cosmos DB
- Si su cuenta está configurada con una sola región de escritura o con varias.

La coherencia de lectura se aplica a una sola operación de lectura limitada a un rango de claves de partición o una partición lógica.

### Elección del nivel de coherencia adecuado

Cada uno de los modelos de coherencia se puede usar para escenarios específicos del mundo real. Cada uno proporciona compensaciones precisas de disponibilidad y rendimiento respaldadas por SLA completos. Las siguientes consideraciones sencillas le ayudan a tomar la decisión correcta en muchos escenarios comunes.

#### Configurar el nivel de coherencia predeterminado

Puede configurar el nivel de coherencia predeterminado en su cuenta de Azure Cosmos DB en cualquier momento. El nivel de coherencia predeterminado configurado en su cuenta se aplica a todas las bases de datos y contenedores de Azure Cosmos DB de esa cuenta. Todas las lecturas y consultas emitidas contra un contenedor o una base de datos usan el nivel de coherencia especificado de forma predeterminada.

La coherencia de lectura se aplica a una única operación de lectura dentro del ámbito de una partición lógica. La operación de lectura puede emitirla un cliente remoto o un procedimiento almacenado.

#### Garantías asociadas con los niveles de coherencia

Azure Cosmos DB garantiza que el 100 % de las solicitudes de lectura cumplan la garantía de coherencia del nivel elegido. Las definiciones precisas de los cinco niveles de coherencia en Azure Cosmos DB usando el lenguaje de especificación TLA+ se proporcionan en el repositorio de GitHub [azure-cosmos-tla](https://github.com/Azure/azure-cosmos-tla).

##### Coherencia fuerte

La coherencia fuerte ofrece una garantía de linealidad. La linealidad se refiere a servir solicitudes de forma simultánea. Las lecturas se garantiza que devuelvan la versión más reciente confirmada de un elemento. Un cliente nunca ve una escritura no confirmada o parcial. Los usuarios siempre se garantiza que lean la escritura más reciente confirmada.

##### Coherencia de obsolescencia limitada

En la coherencia de obsolescencia limitada, el retraso de los datos entre dos regiones cualesquiera siempre es menor que una cantidad especificada. La cantidad puede ser "K" versiones (es decir, "actualizaciones") de un elemento o "T" intervalos de tiempo, lo que se alcance primero. En otras palabras, al elegir la obsolescencia limitada, la máxima "obsolescencia" de los datos en cualquier región se puede configurar de dos maneras:

- El número de versiones (_K_) del elemento
- El intervalo de tiempo (_T_) las lecturas pueden rezagarse con respecto a las escrituras

La obsolescencia limitada es bene ficiosa principalmente para cuentas de escritura de región única con dos o más regiones. Si el retraso de datos en una región (determinado por partición física) supera el valor de obsolescencia configurado, las escrituras para esa partición se aceleran hasta que la obsolescencia vuelva a estar dentro del límite superior configurado.

Para una cuenta de una sola región, la obsolescencia limitada proporciona las mismas garantías de coherencia de escritura que Sesión y Coherencia final. Con la obsolescencia limitada, los datos se replican en una mayoría local (tres réplicas en un conjunto de cuatro réplicas) en la región única.

##### Session consistency

En la coherencia de sesión, dentro de una única sesión de cliente, se garantiza que las lecturas respeten las garantías de lectura de sus propias escrituras (read-your-writes) y de escritura después de lectura (write-follows-reads). Esta garantía asume una única sesión "escritora" o el uso compartido del token de sesión para varios escritores.

Al igual que todos los niveles de coherencia más débiles que Fuerte, las escrituras se replican en un mínimo de tres réplicas (en un conjunto de cuatro réplicas) en la región local, con replicación asincrónica a todas las demás regiones.

##### Consistent prefix consistency

En el prefijo coherente, las actualizaciones realizadas como escrituras de documento único ven coherencia final. Las actualizaciones realizadas como lote dentro de una transacción se devuelven coherentes con la transacción en la que se confirmaron. Las operaciones de escritura dentro de una transacción de varios documentos siempre son visibles juntas.

Suponga que se realizan dos operaciones de escritura en los documentos Doc1 y Doc2, dentro de las transacciones T1 y T2. Cuando el cliente realiza una lectura en cualquier réplica, el usuario ve "Doc1 v1 y Doc2 v1" o "Doc1 v2 y Doc2 v2", pero nunca "Doc1 v1 y Doc2 v2" ni "Doc1 v2 y Doc2 v1" para la misma operación de lectura o consulta.

##### Eventual consistency

En la coherencia final, no hay garantía de ordenación para las lecturas. En ausencia de más escrituras, las réplicas convergen eventualmente.

La coherencia final es la forma más débil de coherencia porque un cliente podría leer valores que son más antiguos de los que leyó antes. La coherencia final es ideal cuando la aplicación no requiere ninguna garantía de ordenación. Los ejemplos incluyen recuento de Retweets, Me gusta o comentarios sin hilo.

### Exploración de las API compatibles

Azure Cosmos DB ofrece múltiples API de base de datos, que incluyen NoSQL, MongoDB, PostgreSQL, Cassandra, Gremlin y Table. Al usar estas API, puede modelar datos del mundo real utilizando documentos, valores clave, gráficos y modelos de datos de familia de columnas. Estas API permiten que sus aplicaciones traten Azure Cosmos DB como si fuera varias otras tecnologías de bases de datos, sin la sobrecarga de enfoques de administración y escala. Azure Cosmos DB le ayuda a utilizar los ecosistemas, herramientas y habilidades que ya tiene para el modelado de datos y consultas con sus diversas API.

Todas las API ofrecen escalado automático de almacenamiento y rendimiento, flexibilidad y garantías de rendimiento. No hay una API mejor, y puede elegir cualquiera de las API para construir su aplicación

#### Consideraciones al elegir una API

La API para NoSQL es nativa de Azure Cosmos DB.

Las API para MongoDB, PostgreSQL, Cassandra, Gremlin y Table implementan el protocolo de red de motores de base de datos de código abierto. Estas API son más adecuadas si se cumplen las siguientes condiciones:

- Si ya tiene aplicaciones existentes de MongoDB, PostgreSQL, Cassandra o Gremlin
- Si no desea reescribir toda su capa de acceso a datos
- Si quiere usar el ecosistema de desarrollo de código abierto, controladores de cliente, experiencia y recursos para su base de datos

#### API para NoSQL

La API de Azure Cosmos DB para NoSQL almacena datos en formato de documento. Ofrece la mejor experiencia de extremo a extremo ya que se tiene control total sobre la interfaz, el servicio y las bibliotecas de cliente del SDK. Cualquier nueva característica que se implemente en Azure Cosmos DB está disponible primero en las cuentas de API para NoSQL. Las cuentas de NoSQL permiten consultar elementos usando la sintaxis del Lenguaje de consulta estructurado (SQL).

#### API para MongoDB

La API de Azure Cosmos DB para MongoDB almacena datos en una estructura de documentos, mediante el formato BSON. Es compatible con el protocolo de conexión de MongoDB; sin embargo, no usa ningún código nativo relacionado con MongoDB. La API para MongoDB es una excelente opción si desea usar el ecosistema y las habilidades más amplias de MongoDB, sin renunciar al uso de las características de Azure Cosmos DB.

#### API para PostgreSQL

Azure Cosmos DB for PostgreSQL es un servicio administrado para ejecutar PostgreSQL a cualquier escala, con la capacidad de tablas distribuidas de [Citus open source](https://github.com/citusdata/citus). Almacena datos en un solo nodo o distribuidos en una configuración multinodo.

#### API para Apache Cassandra

La API de Azure Cosmos DB para Cassandra almacena datos en un esquema orientado a columnas. Apache Cassandra ofrece un enfoque altamente distribuido y de escalado horizontal para almacenar grandes volúmenes de datos, con un enfoque flexible para un esquema orientado a columnas. La API para Cassandra en Azure Cosmos DB se alinea con esta filosofía para abordar las bases de datos NoSQL distribuidas. Esta API para Cassandra es compatible en protocolo de conexión con Apache Cassandra nativo.

#### API para Apache Gremlin

La API de Azure Cosmos DB para Gremlin permite a los usuarios realizar consultas de grafos y almacena los datos como bordes y vértices.

Use la API para Gremlin en escenarios como:

- Involving dynamic data
- Que involucra datos con relaciones complejas
- Que involucra datos demasiado complejos para modelarse con bases de datos relacionales
- Si desea usar el ecosistema y las habilidades existentes de Gremlin

#### API para Table

La API de Azure Cosmos DB para Table almacena datos en formato de clave-valor. Si actualmente usa Azure Table Storage, puede que observe algunas limitaciones en latencia, escalado, rendimiento, distribución global, administración de índices y rendimiento bajo de consultas. La API para Table supera estas limitaciones y se recomienda migrar la aplicación si desea aprovechar las ventajas de Azure Cosmos DB. La API para Table solo admite escenarios OLTP.

### Descripción de las unidades de solicitud

Con Azure Cosmos DB, se paga por el rendimiento aprovisionado y el almacenamiento consumido por hora. El rendimiento debe aprovisionarse para garantizar que los recursos del sistema sean siempre suficientes para la base de datos de Azure Cosmos.

El costo de todas las operaciones de base de datos se normaliza en Azure Cosmos DB y se expresa en _unidades de solicitud_ (o RU, abreviado). Una unidad de solicitud representa los recursos del sistema como CPU, IOPS y memoria necesarios para realizar las operaciones de base de datos admitidas por Azure Cosmos DB.

El costo de realizar una lectura de punto, que consiste en recuperar un único elemento por su identificador y el valor de la clave de partición, para un elemento de 1 KB es de 1 RU. A todas las demás operaciones de base de datos se les asigna igualmente un costo en RU. Independientemente de la API que use para interactuar con el contenedor de Azure Cosmos, los costos se miden en RU. Ya sea que la operación de base de datos sea una escritura, una lectura de punto o una consulta, los costos se miden en RU.

A continuación, la imagen muestra la idea general de las RU:

![Imagen que muestra cómo las operaciones de base de datos consumen unidades de solicitud.](https://learn.microsoft.com/en-us/training/wwl-azure/explore-azure-cosmos-db/media/request-units.png)

El tipo de cuenta de Azure Cosmos DB que usa determina la forma en que se cobran las RU consumidas. Hay tres modos en los que puede crear una cuenta:

- **Modo de throughput aprovisionado**: En este modo, usted aprovisiona el número de RUs para su aplicación en una base por segundo en incrementos de 100 RUs por segundo. Para escalar el throughput aprovisionado de su aplicación, puede aumentar o disminuir el número de RUs en cualquier momento en incrementos o decrementos de 100 RUs. Puede realizar cambios ya sea programáticamente o usando el portal de Azure. Puede aprovisionar throughput a nivel de contenedor y base de datos.
- **Modo sin servidor**: En este modo, no tiene que aprovisionar ningún throughput al crear recursos en su cuenta de Azure Cosmos DB. Al final de su período de facturación, se le cobra por el número de unidades de solicitud consumidas por sus operaciones de base de datos.
- **Modo de autoescala**: En este modo, puede escalar automática e instantáneamente el throughput (RU/s) de su base de datos o contenedor en función de su uso. Esta operación de escalado no afecta la disponibilidad, latencia, throughput o rendimiento de la carga de trabajo. Este modo es adecuado para cargas de trabajo críticas que tienen patrones de tráfico variables o impredecibles, y requieren SLA en alto rendimiento y escala.

## Trabajo con Azure Cosmos DB

### Exploración del SDK de .NET v3 de Microsoft para Azure Cosmos DB

Esta **sección** se centra en el SDK de .NET v3 de Azure Cosmos DB para la API para NoSQL (paquete NuGet **Microsoft.Azure.Cosmos**). Si está familiarizado con la versión anterior del SDK de .NET, puede que conozca los términos colección y documento.

El repositorio de GitHub [azure-cosmos-dotnet-v3](https://github.com/Azure/azure-cosmos-dotnet-v3/tree/master/Microsoft.Azure.Cosmos.Samples/Usage) incluye las últimas soluciones de ejemplo de .NET. Use estas soluciones para realizar operaciones CRUD (crear, leer, actualizar y eliminar) y otras operaciones comunes en los recursos de Azure Cosmos DB.

Dado que Azure Cosmos DB admite varios modelos de API, la versión 3 del SDK de .NET usa los términos genéricos _contenedor_ e _elemento_. Un _**contenedor**_ puede ser una colección, un grafo o una tabla. Un _**elemento**_ puede ser un documento, un borde o vértice, o una fila, y es el contenido dentro de un contenedor.

A continuación hay ejemplos que muestran algunas de las operaciones clave que debe conocer. Para más ejemplos, visite el enlace de GitHub que se muestra anteriormente. Los ejemplos a continuación usan todos la versión asincrónica de los métodos.

#### CosmosClient

Crea un nuevo `CosmosClient` con una cadena de conexión. `CosmosClient` es seguro para subprocesos. La recomendación es mantener una sola instancia de `CosmosClient` durante la vida útil de la aplicación que permite una gestión eficiente de la conexión y el rendimiento.

```csharp
CosmosClient client = new CosmosClient(endpoint, key);
```

#### Ejemplos de bases de datos

##### Crear una base de datos

El método `CosmosClient.CreateDatabaseAsync` produce una excepción si ya existe una base de datos con el mismo nombre.

```csharp
// Nueva instancia de la clase Database que hace referencia a la base de datos del lado servidor
Database database1 = await client.CreateDatabaseAsync(
    id: "adventureworks-1"
);
```

El método `CosmosClient.CreateDatabaseIfNotExistsAsync` comprueba si existe una base de datos y, si no existe, la crea. Solo se usa el `id` de la base de datos para comprobar si existe una base de datos.

```csharp
// Nueva instancia de la clase Database que hace referencia a la base de datos del lado servidor
Database database2 = await client.CreateDatabaseIfNotExistsAsync(
    id: "adventureworks-2"
);
```

##### Leer una base de datos por ID

Lee una base de datos del servicio Azure Cosmos DB como una operación asincrónica.

```csharp
DatabaseResponse readResponse = await database.ReadAsync();
```

##### Eliminar una base de datos

Elimina una base de datos como una operación asíncrona.

```csharp
await database.DeleteAsync();
```

#### Ejemplos de contenedores

##### Crear un contenedor

El método `Database.CreateContainerIfNotExistsAsync` comprueba si existe un contenedor y, si no existe, lo crea. Solo se usa el `id` del contenedor para comprobar si existe un contenedor.

```csharp
// Establece el rendimiento en el valor mínimo de 400 RU/s
ContainerResponse simpleContainer = await database.CreateContainerIfNotExistsAsync(
    id: containerId,
    partitionKeyPath: partitionKey,
    throughput: 400);
```

##### Obtener un contenedor por ID

```csharp
Container container = database.GetContainer(containerId);
ContainerProperties containerProperties = await container.ReadContainerAsync();
```

##### Eliminar un contenedor

Elimina un contenedor como una operación asíncrona.

```csharp
await database.GetContainer(containerId).DeleteContainerAsync();
```

#### Ejemplos de elementos

##### Crear un elemento

Use el método `Container.CreateItemAsync` para crear un elemento. El método requiere un objeto serializable en JSON que debe contener una propiedad id y un `partitionKey`.

```csharp
ItemResponse<SalesOrder> response = await container.CreateItemAsync(salesOrder, new PartitionKey(salesOrder.AccountNumber));
```

##### Leer un elemento

Use el método `Container.ReadItemAsync` para leer un elemento. El método requiere el tipo al que se serializa el elemento, junto con una propiedad `id` y un `partitionKey`.

```csharp
string id = "[id]";
string accountNumber = "[partition-key]";
ItemResponse<SalesOrder> response = await container.ReadItemAsync(id, new PartitionKey(accountNumber));
```

##### Consultar un elemento

El método `Container.GetItemQueryIterator` crea una consulta para los elementos de un contenedor en una base de datos de Azure Cosmos usando una instrucción SQL con valores parametrizados. Devuelve un `FeedIterator`.

```csharp
QueryDefinition query = new QueryDefinition(
    "select * from sales s where s.AccountNumber = @AccountInput ")
    .WithParameter("@AccountInput", "Account1");

FeedIterator<SalesOrder> resultSet = container.GetItemQueryIterator<SalesOrder>(
    query,
    requestOptions: new QueryRequestOptions()
    {
        PartitionKey = new PartitionKey("Account1"),
        MaxItemCount = 1
    });
```

#### Otros recursos

- El repositorio de GitHub [azure-cosmos-dotnet-v3](https://github.com/Azure/azure-cosmos-dotnet-v3/tree/master/Microsoft.Azure.Cosmos.Samples/Usage) incluye las soluciones de ejemplo de .NET más recientes para realizar operaciones CRUD y otras operaciones comunes en recursos de Azure Cosmos DB.
- Visite este artículo [Ejemplos del SDK .NET V3 de Azure Cosmos DB (Microsoft.Azure.Cosmos) para la API SQL](https://learn.microsoft.com/en-us/azure/cosmos-db/sql-api-dotnet-v3sdk-samples) para obtener vínculos directos a ejemplos específicos del repositorio de GitHub.

### Creación de procedimientos almacenados

Azure Cosmos DB proporciona ejecución transaccional integrada en el lenguaje de JavaScript que le permite escribir **procedimientos almacenados**, desencadenadores y **funciones definidas por el usuario (UDFs)**. Para llamar a un procedimiento almacenado, desencadenador o función definida por el usuario, debe registrarlo. Para más información, consulte [Cómo trabajar con procedimientos almacenados, desencadenadores y funciones definidas por el usuario en Azure Cosmos DB](https://learn.microsoft.com/es-es/azure/cosmos-db/sql/how-to-use-stored-procedures-triggers-udfs).

:information_source: Esta unidad se centra en los procedimientos almacenados; la próxima unidad cubre desencadenadores y funciones definidas por el usuario.

#### Escritura de procedimientos almacenados

Los procedimientos almacenados pueden crear, actualizar, leer, consultar y eliminar elementos dentro de un contenedor de Azure Cosmos. Los procedimientos almacenados se registran por colección y pueden operar en cualquier documento o datos adjuntos presentes en esa colección.

He aquí un procedimiento almacenado simple que devuelve una respuesta "Hello World".

```js
var helloWorldStoredProc = {
  id: "helloWorld",
  serverScript: function () {
    var context = getContext();
    var response = context.getResponse();

    response.setBody("Hello, World");
  },
};
```

El objeto de contexto proporciona acceso a todas las operaciones que se pueden realizar en Azure Cosmos DB y acceso a los objetos de solicitud y respuesta. En este caso, use el objeto de respuesta para establecer el cuerpo de la respuesta que se enviará de vuelta al cliente.

#### Crear un elemento mediante procedimiento almacenado

Al crear un elemento mediante un procedimiento almacenado, el elemento se inserta en el contenedor de Azure Cosmos DB y se devuelve un identificador para el elemento recién creado. La creación de un elemento es una operación asincrónica y depende de las funciones de devolución de llamada de JavaScript. La función de devolución de llamada tiene dos parámetros: uno para el objeto de error si la operación falla y otro para un valor devuelto, en este caso el objeto creado. Dentro de la devolución de llamada, puede controlar la excepción o producir un error. Si no se proporciona una devolución de llamada y hay un error, el tiempo de ejecución de Azure Cosmos DB produce un error.

El procedimiento almacenado también incluye un parámetro para establecer la descripción como un valor booleano. Cuando el parámetro está establecido en true y falta la descripción, el procedimiento almacenado produce una excepción. De lo contrario, el resto del procedimiento almacenado continúa ejecutándose.

Este procedimiento almacenado toma como entrada `documentToCreate`, el cuerpo de un documento que se va a crear en la colección actual. Todas estas operaciones son asincrónicas y dependen de las devoluciones de llamada de funciones de JavaScript.

```js
var createDocumentStoredProc = {
  id: "createMyDocument",
  body: function createMyDocument(documentToCreate) {
    var context = getContext();
    var collection = context.getCollection();
    var accepted = collection.createDocument(
      collection.getSelfLink(),
      documentToCreate,
      function (err, documentCreated) {
        if (err) throw new Error("Error" + err.message);
        context.getResponse().setBody(documentCreated.id);
      }
    );
    if (!accepted) return;
  },
};
```

#### Matrices como parámetros de entrada para procedimientos almacenados

Al definir un procedimiento almacenado en Azure Portal, los parámetros de entrada siempre se envían como una cadena al procedimiento almacenado. Aunque pase una matriz de cadenas como entrada, la matriz se convierte en cadena y se envía al procedimiento almacenado. Para solucionar esto, puede definir una función dentro del procedimiento almacenado para analizar la cadena como una matriz. El código siguiente muestra cómo analizar un parámetro de entrada de cadena como una matriz:

```js
function sample(arr) {
  if (typeof arr === "string") arr = JSON.parse(arr);

  arr.forEach(function (a) {
    // haga algo aquí
    console.log(a);
  });
}
```

#### Ejecución limitada

Todas las operaciones de Azure Cosmos DB deben completarse en un tiempo limitado. Los procedimientos almacenados tienen un tiempo limitado para ejecutarse en el servidor. Todas las funciones de colección devuelven un valor booleano que representa si esa operación se completa o no.

#### Transacciones dentro de procedimientos almacenados

Puede implementar transacciones en elementos dentro de un contenedor utilizando un procedimiento almacenado. Las funciones de JavaScript pueden implementar un modelo basado en continuación para procesar por lotes o reanudar la ejecución. El valor de continuación puede ser cualquier valor de su elección y sus aplicaciones pueden usar este valor para reanudar una transacción desde un nuevo punto de partida. El diagrama a continuación muestra cómo se puede usar el modelo de continuación de transacciones para repetir una función del lado del servidor hasta que la función complete toda su carga de trabajo de procesamiento.

![Este diagrama muestra cómo el modelo de continuación de transacciones puede usarse para repetir una función del lado del servidor hasta que complete toda su carga de procesamiento.](https://learn.microsoft.com/en-us/training/wwl-azure/work-with-cosmos-db/media/transaction-continuation-model.png)

### Creación de desencadenadores y funciones definidas por el usuario

Azure Cosmos DB admite predesencadenadores y postdesencadenadores. Los predesencadenadores se ejecutan antes de modificar un elemento de la base de datos y los postdesencadenadores se ejecutan después de modificar un elemento de la base de datos. Los desencadenadores no se ejecutan automáticamente. Deben especificarse para cada operación de base de datos donde desee que se ejecuten. Después de definir un desencadenador, debe registrarlo usando los SDK de Azure Cosmos DB.

Para obtener ejemplos de cómo registrar y llamar a un desencadenador, consulte [predesencadenadores](https://learn.microsoft.com/es-es/azure/cosmos-db/sql/how-to-use-stored-procedures-triggers-udfs#pre-triggers) y [postdesencadenadores](https://learn.microsoft.com/es-es/azure/cosmos-db/sql/how-to-use-stored-procedures-triggers-udfs#post-triggers).

#### Predesencadenadores

El siguiente ejemplo muestra cómo se usa un predesencadenador para validar las propiedades de un elemento de Azure Cosmos que se está creando. Agrega una propiedad de marca de tiempo a un elemento recién agregado si no contiene una.

```js
function validateToDoItemTimestamp() {
  var context = getContext();
  var request = context.getRequest();

  // Elemento que se creará en la operación actual
  var itemToCreate = request.getBody();

  // validar propiedades
  if (!("timestamp" in itemToCreate)) {
    var ts = new Date();
    itemToCreate["timestamp"] = ts.getTime();
  }

  // Actualiza el elemento que se va a crear
  request.setBody(itemToCreate);
}
```

Los predesencadenadores no pueden tener parámetros de entrada. El objeto de solicitud en el desencadenador se usa para manipular el mensaje de solicitud asociado a la operación. En el ejemplo anterior, el predesencadenador se ejecuta al crear un elemento de Azure Cosmos y el cuerpo del mensaje de solicitud contiene el elemento que se va a crear en formato JSON.

Al registrar desencadenadores, puede especificar las operaciones con las que puede ejecutarse. Este desencadenador debe crearse con un valor `TriggerOperation` de `TriggerOperation.Create`; no está permitido usar el desencadenador en una operación de reemplazo.

Para obtener ejemplos de cómo registrar y llamar a un predesencadenador, visite el artículo de [predesencadenadores](https://learn.microsoft.com/es-es/azure/cosmos-db/sql/how-to-use-stored-procedures-triggers-udfs#pre-triggers).

#### Postdesencadenadores

El siguiente ejemplo muestra un postdesencadenador. Este desencadenador consulta el elemento de metadatos y lo actualiza con los detalles sobre el elemento recién creado.

```js
function updateMetadata() {
  var context = getContext();
  var container = context.getCollection();
  var response = context.getResponse();

  // elemento que se creó
  var createdItem = response.getBody();

  // consultar el documento de metadatos
  var filterQuery = 'SELECT * FROM root r WHERE r.id = "_metadata"';
  var accept = container.queryDocuments(
    container.getSelfLink(),
    filterQuery,
    updateMetadataCallback
  );
  if (!accept) throw "Unable to update metadata, abort";

  function updateMetadataCallback(err, items, responseOptions) {
    if (err) throw new Error("Error" + err.message);
    if (items.length != 1) throw "Unable to find metadata document";

    var metadataItem = items[0];

    // Actualiza metadatos
    metadataItem.createdItems += 1;
    metadataItem.createdNames += " " + createdItem.id;
    var accept = container.replaceDocument(
      metadataItem._self,
      metadataItem,
      function (err, itemReplaced) {
        if (err) throw "Unable to update metadata, abort";
      }
    );
    if (!accept) throw "Unable to update metadata, abort";
    return;
  }
}
```

Un aspecto importante es la ejecución transaccional de los desencadenadores en Azure Cosmos DB. El postdesencadenador se ejecuta como parte de la misma transacción para el propio elemento subyacente. Una excepción durante la ejecución del postdesencadenador hace que falle toda la transacción. Todo lo confirmado se revierte y se devuelve una excepción.

#### Funciones definidas por el usuario

El siguiente ejemplo crea una UDF para calcular el impuesto sobre la renta para varios tramos de ingresos. Esta función definida por el usuario se usaría luego dentro de una consulta. Para los propósitos de este ejemplo, suponga que hay un contenedor llamado "Ingresos" con propiedades de la siguiente manera:

```js
{
   "name": "User One",
   "country": "USA",
   "income": 70000
}
```

El siguiente ejemplo de código es una definición de función para calcular el impuesto sobre la renta para varios tramos de ingresos:

```js
function tax(income) {
  if (income == undefined) throw "no input";

  if (income < 1000) return income * 0.1;
  else if (income < 10000) return income * 0.2;
  else return income * 0.4;
}
```

### Exploración de la fuente de cambios en Azure Cosmos DB

La fuente de cambios en Azure Cosmos DB es un registro persistente de los cambios en un contenedor en el orden en que se producen. La compatibilidad con la fuente de cambios en Azure Cosmos DB funciona escuchando un contenedor de Azure Cosmos DB para detectar cualquier cambio. Luego genera la lista ordenada de documentos que se cambiaron en el orden en que se modificaron. Los cambios persistentes pueden procesarse de forma asincrónica e incremental, y el resultado puede distribuirse entre uno o más consumidores para el procesamiento paralelo.

#### Fuente de cambios y diferentes operaciones

Actualmente, puede ver todas las inserciones y actualizaciones en la fuente de cambios. No puede filtrar la fuente de cambios para un tipo específico de operación. Actualmente la fuente de cambios no registra las operaciones de eliminación. Como solución alternativa, puede agregar un marcador temporal en los elementos que se eliminan. Por ejemplo, puede agregar un atributo en el elemento llamado "deleted", establecer su valor en "true" y, después, establecer un valor de período de vida (TTL) en el elemento. Establecer el TTL garantiza que el elemento se elimine automáticamente.

#### Lectura de la fuente de cambios de Azure Cosmos DB

Puede trabajar con la fuente de cambios de Azure Cosmos DB usando un modelo de inserción o un modelo de extracción. Con un modelo de inserción, el procesador de fuente de cambios inserta el trabajo en un cliente que tiene lógica de negocios para procesarlo. Sin embargo, la complejidad de comprobar el trabajo y almacenar el estado del último trabajo procesado se controla dentro del procesador de fuente de cambios.

Con un modelo de extracción, el cliente tiene que extraer el trabajo del servidor. En este caso, el cliente tiene lógica de negocios para procesar el trabajo y también almacena el estado del último trabajo procesado. El cliente controla el equilibrio de carga entre varios clientes que procesan trabajo en paralelo y el control de errores.

:information_source: Se recomienda usar el modelo de inserción porque no necesitará preocuparse por sondear la fuente de cambios para detectar cambios futuros, almacenar el estado del último cambio procesado y otras ventajas.

La mayoría de los escenarios que usan la fuente de cambios de Azure Cosmos DB usan una de las opciones del modelo de inserción. Sin embargo, hay algunos escenarios en los que puede que quiera el control adicional de bajo nivel del modelo de extracción. El control adicional de bajo nivel incluye:

- Leer cambios de una clave de partición particular
- Controlar el ritmo al que el cliente recibe cambios para el procesamiento
- Realizar una lectura única de los datos existentes en la fuente de cambios (por ejemplo, para realizar una migración de datos)

#### Lectura de la fuente de cambios con un modelo de inserción

Hay dos formas de leer desde la fuente de cambios con un modelo de inserción: los desencadenadores de Azure Cosmos DB de Azure Functions y la biblioteca del procesador de fuente de cambios. Azure Functions usa el procesador de fuente de cambios en segundo plano, por lo que ambas son formas similares de leer la fuente de cambios. Piense en Azure Functions simplemente como una plataforma de hospedaje para el procesador de fuente de cambios, no como una forma completamente diferente de leer la fuente de cambios. Azure Functions usa el procesador de fuente de cambios en segundo plano. Paraleliza automáticamente el procesamiento de cambios entre las particiones del contenedor.

##### Azure Functions

Puede crear pequeñas funciones de Azure Functions reactivas que se desencadenan automáticamente en cada nuevo evento en la fuente de cambios del contenedor de Azure Cosmos DB. Con el [desencadenador de Azure Functions para Azure Cosmos DB](https://learn.microsoft.com/es-es/azure/azure-functions/functions-bindings-cosmosdb-v2-trigger), puede usar la funcionalidad de escalado y detección confiable de eventos del Procesador de fuente de cambios sin necesidad de mantener ninguna infraestructura de trabajo.

![Diagrama que muestra el change feed desencadenando Azure Functions para procesamiento.](https://learn.microsoft.com/en-us/training/wwl-azure/work-with-cosmos-db/media/functions-change-feed.png)

##### Procesador de fuente de cambios (Change feed processor)

El procesador de fuente de cambios forma parte de los SDK [.NET V3](https://github.com/Azure/azure-cosmos-dotnet-v3) y [Java V4](https://github.com/Azure/azure-sdk-for-java/tree/main/sdk/cosmos/azure-cosmos) de Azure Cosmos DB. Simplifica el proceso de lectura de la fuente de cambios y distribuye el procesamiento de eventos entre varios consumidores de forma eficaz.

Hay cuatro componentes principales para implementar el procesador de fuente de cambios:

1. **El contenedor supervisado**: El contenedor supervisado tiene los datos a partir de los cuales se genera la fuente de cambios. Cualquier inserción y actualización en el contenedor supervisado se refleja en la fuente de cambios del contenedor.

1. **El contenedor de concesión**: El contenedor de concesión actúa como almacenamiento de estado y coordina el procesamiento de la fuente de cambios entre varios trabajos. El contenedor de concesión puede almacenarse en la misma cuenta que el contenedor supervisado o en una cuenta separada.

1. **La instancia de proceso**: Una instancia de proceso hospeda el procesador de fuente de cambios para escuchar los cambios. Según la plataforma, podría representarse mediante una máquina virtual, un pod de Kubernetes, una instancia de Azure App Service o una máquina física real. Tiene un identificador único al que se hace referencia como nombre de instancia en todo este artículo.

1. **El delegado**: El delegado es el código que define lo que el desarrollador quiere hacer con cada lote de cambios que lee el procesador de fuente de cambios.

Al implementar el procesador de fuente de cambios, el punto de entrada es siempre el contenedor supervisado; desde una instancia de `Container`, llame a `GetChangeFeedProcessorBuilder`:

```csharp
/// <summary>
/// Inicia Change Feed Processor para escuchar cambios y procesarlos con la implementación de HandleChangesAsync.
/// </summary>
private static async Task<ChangeFeedProcessor> StartChangeFeedProcessorAsync(
    CosmosClient cosmosClient,
    IConfiguration configuration)
{
    string databaseName = configuration["SourceDatabaseName"];
    string sourceContainerName = configuration["SourceContainerName"];
    string leaseContainerName = configuration["LeasesContainerName"];

    Container leaseContainer = cosmosClient.GetContainer(databaseName, leaseContainerName);
    ChangeFeedProcessor changeFeedProcessor = cosmosClient.GetContainer(databaseName, sourceContainerName)
        .GetChangeFeedProcessorBuilder<ToDoItem>(processorName: "changeFeedSample", onChangesDelegate: HandleChangesAsync)
            .WithInstanceName("consoleHost")
            .WithLeaseContainer(leaseContainer)
            .Build();

    Console.WriteLine("Starting Change Feed Processor...");
    await changeFeedProcessor.StartAsync();
    Console.WriteLine("Change Feed Processor started.");
    return changeFeedProcessor;
}
```

Donde el primer parámetro es un nombre único que describe el objetivo de este procesador y el segundo nombre es la implementación del delegado que controla los cambios. A continuación se muestra un ejemplo de un delegado:

```csharp
/// <summary>
/// El delegado recibe lotes de cambios a medida que se generan en el change feed y puede procesarlos.
/// </summary>
static async Task HandleChangesAsync(
    ChangeFeedProcessorContext context,
    IReadOnlyCollection<ToDoItem> changes,
    CancellationToken cancellationToken)
{
    Console.WriteLine($"Started handling changes for lease {context.LeaseToken}...");
    Console.WriteLine($"Change Feed request consumed {context.Headers.RequestCharge} RU.");
    // SessionToken si es necesario para aplicar consistencia de sesión en otra instancia de cliente
    Console.WriteLine($"SessionToken ${context.Headers.Session}");

    // Puede que queramos registrar los diagnósticos de cualquier operación que tardó más de cierto umbral
    if (context.Diagnostics.GetClientElapsedTime() > TimeSpan.FromSeconds(1))
    {
        Console.WriteLine($"Change Feed request took longer than expected. Diagnostics:" + context.Diagnostics.ToString());
    }

    foreach (ToDoItem item in changes)
    {
        Console.WriteLine($"Detected operation for item with id {item.id}, created at {item.creationTime}.");
        // Simular alguna operación asincrónica
        await Task.Delay(10);
    }

    Console.WriteLine("Finished handling changes.");
}
```

Después, defina el nombre de la instancia de proceso o el identificador único con `WithInstanceName`, que debe ser único y diferente en cada instancia de proceso que se implemente y, finalmente, el contenedor para mantener el estado de concesión con `WithLeaseContainer`.

Al llamar a `Build` obtiene la instancia del procesador que puede iniciar llamando a `StartAsync`.

El ciclo de vida normal de una instancia de host es:

1. Leer la fuente de cambios.
1. Si no hay cambios, estar en reposo durante un período de tiempo predefinido (personalizable con `WithPollInterval` en el `Builder`) y volver al paso 1.
1. Si hay cambios, enviarlos al delegado.
1. Cuando el delegado termina de procesar los cambios correctamente, actualizar el almacén de concesiones con el último punto en el tiempo procesado y volver al paso 1.

---

<!-- ===== Azure Blob Storage ===== -->

# Desarrollo de soluciones con Azure Blob Storage

## Exploración de Azure Blob Storage

Azure Blob Storage es la solución de almacenamiento de objetos de Microsoft para la nube. Blob Storage está optimizado para almacenar grandes cantidades de datos no estructurados.

### Exploración de Blob Storage

Azure Blob Storage es la solución de almacenamiento de objetos de Microsoft para la nube. Blob Storage está optimizado para almacenar grandes cantidades de datos no estructurados. Los datos no estructurados son datos que no se adhieren a un modelo o definición de datos particular, como texto o datos binarios.

Blob Storage está diseñado para:

- Servir imágenes o documentos directamente a un explorador.
- Almacenar archivos para acceso distribuido.
- Transmitir vídeo y audio.
- Escribir en archivos de registro.
- Almacenar datos para copias de seguridad y restauración, recuperación ante desastres y archivo.
- Almacenar datos para análisis por un servicio local u hospedado en Azure.

Los usuarios o las aplicaciones cliente pueden acceder a los objetos de Blob Storage a través de HTTP/HTTPS, desde cualquier parte del mundo. Los objetos de Blob Storage son accesibles a través de la API REST de Azure Storage, Azure PowerShell, la CLI de Azure o una biblioteca de cliente de Azure Storage.

Una cuenta de Azure Storage es el contenedor de nivel superior para todo el almacenamiento de Azure Blob. La cuenta de almacenamiento proporciona un espacio de nombres único para los datos de Azure Storage que es accesible desde cualquier lugar del mundo mediante HTTP o HTTPS.

#### Tipos de cuentas de almacenamiento

Azure Storage ofrece dos niveles de rendimiento de cuentas de almacenamiento: estándar y premium. Cada nivel de rendimiento admite diferentes características y tiene su propio modelo de precios.

- **Estándar**: Esta es la cuenta de uso general v2 estándar y se recomienda para la mayoría de los escenarios con Azure Storage.
- **Premium**: Las cuentas premium ofrecen mayor rendimiento al usar unidades de estado sólido. Si crea una cuenta premium, puede elegir entre tres tipos de cuenta: blobs en bloque, blobs en páginas o recursos compartidos de archivos.

La siguiente tabla describe los tipos de cuentas de almacenamiento recomendados por Microsoft para la mayoría de los escenarios con Blob Storage.

| Tipo de cuenta de almacenamiento | Servicios de almacenamiento admitidos                                                    | Opciones de redundancia                   | Uso                                                                                                                                                                                                               |
| --------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| General-purpose v2 estándar | Blob Storage (incluida Data Lake Storage), Queue Storage, Table Storage y Azure Files | LRS / GRS / RA-GRS / ZRS / GZRS / RA-GZRS | Tipo de cuenta de almacenamiento estándar para blobs, recursos compartidos de archivos, colas y tablas. Recomendado para la mayoría de los escenarios usando Azure Storage. Si desea soporte para NFS en Azure Files, use el tipo de cuenta de recursos compartidos de archivos premium. |
| Blobs de bloque premium     | Blob Storage (incluida Data Lake Storage)                                                | LRS y ZRS                                 | Tipo de cuenta de almacenamiento premium para blobs de bloque y blobs de apéndice. Recomendado para escenarios con altas tasas de transacciones u objetos más pequeños, o que requieren latencia de almacenamiento constantemente baja.                             |
| Recursos compartidos de archivos premium | Azure Files                                                               | LRS y ZRS                                 | Tipo de cuenta de almacenamiento premium solo para recursos compartidos de archivos. Recomendado para aplicaciones de escala empresarial o de alto rendimiento.                                                                                               |
| Blobs de página premium     | Solo blobs de página                                                                      | LRS y ZRS                                 | Tipo de cuenta de almacenamiento premium solo para blobs de página.                                                                                                                                                                   |

#### Niveles de acceso para datos de blobs de bloque

Azure Storage proporciona diferentes opciones para acceder a datos de blobs de bloque basadas en patrones de uso. Cada nivel de acceso en Azure Storage está optimizado para un patrón particular de uso de datos. Al seleccionar el nivel de acceso correcto para sus necesidades, puede almacenar los datos de su blob de bloque de la manera más rentable.

Los niveles de acceso disponibles son:

- El nivel de acceso **Activo** (Hot), que está optimizado para acceso frecuente de objetos en la cuenta de almacenamiento. El nivel Activo tiene los costos de almacenamiento más altos, pero los costos de acceso más bajos. Las nuevas cuentas de almacenamiento se crean en el nivel activo de forma predeterminada.

- El nivel de acceso **Accesible** (Cool), que está optimizado para almacenar grandes cantidades de datos a los que se accede raramente y que se almacenan durante un mínimo de 30 días. El nivel Accesible tiene costos de almacenamiento más bajos y costos de acceso más altos en comparación con el nivel Activo.

- El nivel de acceso **Frío** (Cold), que está optimizado para almacenar datos a los que se accede raramente y que se almacenan durante un mínimo de 90 días. El nivel frío tiene costos de almacenamiento más bajos y costos de acceso más altos en comparación con el nivel de acceso.

- El nivel **Archivo** (Archive), que está disponible solo para blobs de bloque individuales. El nivel archivo está optimizado para datos que pueden tolerar varias horas de latencia de recuperación y permanecen en el nivel Archivo durante un mínimo de 180 días. El nivel archivo es la opción más rentable para almacenar datos, pero acceder a esos datos es más caro que acceder a los datos en los niveles activo o accesible.

Si hay un cambio en el patrón de uso de los datos, puede cambiar entre estos niveles de acceso en cualquier momento.

### Descripción de los tipos de recursos de Azure Blob Storage

Blob Storage ofrece tres tipos de recursos:

- La **cuenta de almacenamiento**.
- Un **contenedor** en la cuenta de almacenamiento
- Un **blob** en un contenedor

#### Cuentas de almacenamiento

Una cuenta de almacenamiento proporciona un espacio de nombres único en Azure para los datos. Cada objeto que almacena en Azure Storage tiene una dirección que incluye el nombre único de la cuenta. La combinación del nombre de la cuenta y el punto de conexión de Azure Storage Blob forma la dirección base de los objetos de la cuenta de almacenamiento.

Por ejemplo, si su cuenta de almacenamiento se llama _mystorageaccount_, entonces el punto de conexión predeterminado para Blob storage es:

```txt
http://mystorageaccount.blob.core.windows.net
```

#### Contenedores

Un contenedor organiza un conjunto de blobs, de forma similar a un directorio en un sistema de archivos. Una cuenta de almacenamiento puede incluir un número ilimitado de contenedores, y un contenedor puede almacenar un número ilimitado de blobs.

El nombre de un contenedor debe ser un nombre DNS válido, ya que forma parte del URI único (identificador de recursos uniforme) que se usa para direccionar el contenedor o sus blobs. Siga estas reglas al asignar un nombre a un contenedor:

- Los nombres de contenedor pueden tener entre 3 y 63 caracteres.
- Los nombres de contenedor deben comenzar con una letra o un número, y solo pueden contener letras minúsculas, números y el carácter guion (-).
- No se permiten dos o más caracteres de guion consecutivos en los nombres de contenedor.

El URI de un contenedor es similar a:

```txt
https://myaccount.blob.core.windows.net/mycontainer
```

#### Blobs

Azure Storage admite tres tipos de blobs:

- **Blobs en bloques**: almacenan datos de texto y binarios. Los block blobs están formados por bloques de datos que pueden administrarse de forma individual. Los block blobs pueden almacenar hasta aproximadamente 190.7 TiB.
- **Blobs en anexos**: se componen de bloques como los blobs en bloques, pero están optimizados para las operaciones de anexión. Los blobs de anexo son ideales para escenarios como el registro de datos de máquinas virtuales.
- **Blobs de página** almacenan archivos de acceso aleatorio de hasta 8 TB de tamaño. Los blobs de página almacenan archivos de disco duro virtual (VHD) y sirven como discos para máquinas virtuales de Azure.

El URI de un blob es similar a:

```txt
https://myaccount.blob.core.windows.net/mycontainer/myblob
```

o

```txt
https://myaccount.blob.core.windows.net/mycontainer/myvirtualdirectory/myblob
```

### Exploración de las características de seguridad de Azure Storage

Azure Storage usa cifrado del lado del servicio (SSE) para cifrar automáticamente sus datos cuando se conservan en la nube. El cifrado de Azure Storage protege sus datos y le ayuda a cumplir los compromisos de seguridad y cumplimiento de su organización.

Microsoft recomienda usar cifrado del lado del servicio para proteger sus datos en la mayoría de los escenarios. Sin embargo, las bibliotecas cliente de Azure Storage para Blob Storage y Queue Storage también ofrecen cifrado del lado del cliente para quienes necesitan cifrar datos en el cliente.

#### Cifrado de Azure Storage para datos en reposo

Azure Storage cifra automáticamente sus datos al conservarlos en la nube. El cifrado protege sus datos y ayuda a cumplir sus compromisos organizativos de seguridad y cumplimiento. Los datos en Azure Storage se cifran y descifran de forma transparente mediante cifrado Advanced Encryption Standard (AES) de 256 bits, uno de los cifrados por bloques más sólidos disponibles, y cumple con Federal Information Processing Standards (FIPS) 140-2. El cifrado de Azure Storage es similar al cifrado BitLocker en Windows.

El cifrado de Azure Storage está habilitado para todas las cuentas de almacenamiento y no puede deshabilitarse. Como sus datos están protegidos de forma predeterminada, no necesita modificar su código ni sus aplicaciones para aprovechar el cifrado de Azure Storage.

Los datos de una cuenta de almacenamiento se cifran independientemente del nivel de rendimiento, nivel de acceso o modelo de implementación. Todos los blobs de bloque, append blobs y page blobs nuevos y existentes se cifran, incluidos los blobs en el nivel de archivo. Todas las opciones de redundancia de Azure Storage admiten cifrado, y todos los datos tanto en la región primaria como en la secundaria se cifran cuando la replicación geográfica está habilitada. Todos los recursos de Azure Storage están cifrados, incluidos blobs, discos, archivos, colas y tablas. También se cifra todos los metadatos de los objetos.

No hay costo adicional por el cifrado de Azure Storage.

##### Encryption key management

Los datos en una cuenta de almacenamiento nueva se cifran con claves administradas por Microsoft de forma predeterminada. Puede seguir usando claves administradas por Microsoft para cifrar sus datos, o bien administrar el cifrado con sus propias claves. Si decide administrar el cifrado con sus propias claves, tiene dos opciones. Puede usar cualquiera de los dos tipos de administración de claves, o ambos:

- Puede especificar una _customer-managed key_ para cifrar y descifrar datos en Blob Storage y Azure Files. Las claves administradas por el cliente deben almacenarse en Azure Key Vault o en Azure Key Vault Managed Hardware Security Model (HSM).
- Puede especificar una _customer-provided key_ en operaciones de Blob Storage. Un cliente puede incluir una clave de cifrado en una solicitud de lectura/escritura para controlar de forma granular cómo se cifran y descifran los datos de blobs.

La siguiente tabla compara las opciones de administración de claves para el cifrado de Azure Storage.

| Parámetro de administración de claves | Claves administradas por Microsoft | Claves administradas por el cliente | Claves proporcionadas por el cliente |
| -------------------------------- | ------------------------------------- | ------------------------------------- | ------------------------ |
| Operaciones de cifrado/descifrado | Azure | Azure | Azure |
| Servicios de Azure Storage compatibles | Todos | Blob Storage, Azure Files | Blob Storage |
| Almacenamiento de claves | Almacén de claves de Microsoft | Azure Key Vault o Key Vault HSM | Almacén de claves propio del cliente |
| Responsabilidad de rotación de claves | Microsoft | Cliente | Cliente |
| Control de claves | Microsoft | Cliente | Cliente |
| Alcance de la clave | Cuenta (predeterminado), contenedor o blob | Cuenta (predeterminado), contenedor o blob | N/A |

#### Cifrado del lado del cliente

Las bibliotecas de cliente de Azure Blob Storage para .NET, Java y Python admiten el cifrado de datos en aplicaciones cliente antes de cargarlos en Azure Storage y el descifrado de datos durante la descarga al cliente. Las bibliotecas de cliente de Queue Storage para .NET y Python también admiten el cifrado del lado del cliente.

Las bibliotecas de cliente de Blob Storage y Queue Storage usan AES para cifrar los datos del usuario. Hay dos versiones de cifrado del lado del cliente disponibles en las bibliotecas de cliente:

- La versión 2 utiliza el modo Galois/Counter Mode (GCM) con AES. Los SDK de Blob Storage y Queue Storage admiten cifrado del lado del cliente con v2.
- La versión 1 utiliza el modo Cipher Block Chaining (CBC) con AES. Los SDK de Blob Storage, Queue Storage y Table Storage admiten cifrado del lado del cliente con v1.

## Administración del ciclo de vida de Azure Blob Storage

### Exploración del ciclo de vida de Azure Blob Storage

Los conjuntos de datos tienen ciclos de vida únicos. Al principio del ciclo de vida, las personas acceden frecuentemente a algunos datos. Pero la necesidad de acceso cae dramáticamente a medida que los datos envejecen. Algunos datos permanecen inactivos en la nube y se acceden raramente una vez almacenados. Algunos datos vencen días o meses después de la creación, mientras que otros conjuntos de datos se leen y modifican activamente durante toda su vida.útil.

#### Niveles de acceso

Azure Storage ofrece diferentes niveles de acceso, permitiendo almacenar datos de objetos blob de la manera más rentable. Los niveles de acceso disponibles incluyen:

- **Hot** - Un nivel en línea optimizado para almacenar datos a los que se accede frecuentemente.
- **Cool** - Un nivel en línea optimizado para almacenar datos a los que se accede sin frecuencia y se almacenan durante un mínimo de 30 días.
- **Cold tier** - Un nivel en línea optimizado para almacenar datos a los que se accede raramente y se almacenan durante un mínimo de 90 días. El nivel cold tiene costos de almacenamiento más bajos y costos de acceso más altos en comparación con el nivel cool.
- **Archive** - Un nivel sin conexión optimizado para almacenar datos a los que se accede raramente y se almacenan durante al menos 180 días con requisitos de latencia flexible, en el orden de horas.

Los límites de almacenamiento de datos se establecen a nivel de cuenta y no por nivel de acceso. Puede elegir usar todo su límite en un nivel o en los tres niveles.

#### Administrar el ciclo de vida de los datos

Azure Blob Storage lifecycle management ofrece una directiva basada en reglas que puede usar para mover datos de blobs a los niveles de acceso adecuados o para expirar datos al final de su ciclo de vida.

Con la directiva de administración del ciclo de vida, puede:

- Transicionar blobs de cool a hot inmediatamente cuando se accede a ellos, para optimizar el rendimiento.
- Transicionar versiones actuales de un blob, versiones anteriores de un blob o instantáneas de blobs a un nivel de almacenamiento más frío si estos objetos no se consultan ni modifican durante un período de tiempo, para optimizar costos.
- Eliminar versiones actuales de un blob, versiones anteriores de un blob o instantáneas de blobs al final de sus ciclos de vida.
- Aplicar reglas a toda una cuenta de almacenamiento, a contenedores seleccionados o a un subconjunto de blobs usando prefijos de nombre o etiquetas de índice de blobs como filtros.

Considere un escenario en el que los datos se consultan con frecuencia durante las primeras etapas del ciclo de vida, pero solo de forma ocasional después de dos semanas. Después del primer mes, el conjunto de datos casi no se consulta. En este escenario, el nivel hot es mejor durante las primeras etapas. El nivel cool es el más adecuado para acceso ocasional. El nivel archive es la mejor opción cuando los datos superan un mes de antigüedad. Al mover datos al nivel de almacenamiento adecuado según su antigüedad con reglas de lifecycle management policy, puede diseñar la solución menos costosa para sus necesidades.

### Descripción de las directivas de ciclo de vida de Blob Storage

Una directiva de administración del ciclo de vida es una colección de reglas en un documento JSON. Cada definición de regla dentro de una directiva incluye un conjunto de filtros y un conjunto de acciones. El conjunto de filtros limita las acciones de la regla a un determinado conjunto de objetos dentro de un contenedor o nombres de objetos. El conjunto de acciones aplica las acciones de nivel o eliminación al conjunto filtrado de objetos:

```jsonc
{
  "rules": [
    {
      "name": "rule1",
      "enabled": true,
      "type": "Lifecycle",
      "definition": {
        /*...*/
      }
    },
    {
      "name": "rule2",
      "type": "Lifecycle",
      "definition": {
        /*...*/
      }
    }
  ]
}
```

Una directiva es una colección de reglas:

| Nombre del parámetro | Tipo de parámetro        | Notas                                                                                  |
| --------------------- | ------------------------ | -------------------------------------------------------------------------------------- |
| `rules`        | Matriz de objetos de regla | Se requiere al menos una regla en una directiva. Puede definir hasta 100 reglas en una directiva. |

Cada regla de la directiva tiene varios parámetros:

| Nombre del parámetro | Tipo de parámetro | Notas                                                                                                                      | Requerido |
| --------------------- | -------------- | -------------------------------------------------------------------------------------------------------------------------- | -------- |
| `name`         | String         | Un nombre de regla puede incluir hasta 256 caracteres alfanuméricos. El nombre distingue mayúsculas y minúsculas. Debe ser único dentro de una directiva. | True     |
| `enabled`      | Boolean        | Valor booleano opcional para permitir deshabilitar temporalmente una regla. El valor predeterminado es true.             | False    |
| `type`         | Valor enum     | El tipo válido actualmente es Lifecycle.                                                                                   | True     |
| `definition`   | Object         | Objeto que define la regla de ciclo de vida. Cada definición se compone de un conjunto de filtros y un conjunto de acciones. | True     |

#### Reglas

Cada definición de regla incluye un conjunto de filtros y un conjunto de acciones. El conjunto de filtros limita las acciones de la regla a un determinado conjunto de objetos dentro de un contenedor o nombres de objetos. El conjunto de acciones aplica las acciones de nivel o eliminación al conjunto filtrado de objetos.

La siguiente regla de ejemplo filtra la cuenta para ejecutar las acciones en objetos que existen dentro de `sample-container` y comienzan con `blob1`.

- Mover blob al nivel cool 30 días después de la última modificación
- Mover blob al nivel archive 90 días después de la última modificación
- Eliminar blob 2,555 días (siete años) después de la última modificación
- Eliminar instantáneas de blob 90 días después de la creación de la instantánea

```json
{
  "rules": [
    {
      "enabled": true,
      "name": "sample-rule",
      "type": "Lifecycle",
      "definition": {
        "actions": {
          "version": {
            "delete": {
              "daysAfterCreationGreaterThan": 90
            }
          },
          "baseBlob": {
            "tierToCool": {
              "daysAfterModificationGreaterThan": 30
            },
            "tierToArchive": {
              "daysAfterModificationGreaterThan": 90,
              "daysAfterLastTierChangeGreaterThan": 7
            },
            "delete": {
              "daysAfterModificationGreaterThan": 2555
            }
          }
        },
        "filters": {
          "blobTypes": ["blockBlob"],
          "prefixMatch": ["sample-container/blob1"]
        }
      }
    }
  ]
}
```

#### Filtros de regla

Los filtros limitan las acciones de regla a un subconjunto de blobs dentro de la cuenta de almacenamiento. Si se define más de un filtro, se aplica un AND lógico a todos los filtros. Los filtros incluyen:

| Nombre del filtro | Tipo de filtro                                                                                                                                                 | Es obligatorio |
| --------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------- |
| blobTypes      | Matriz de valores enum predefinidos                                                                                                                          | Sí          |
| prefixMatch    | Matriz de cadenas de prefijos a coincidir. Cada regla puede definir hasta 10 prefijos. Una cadena de prefijo debe comenzar con un nombre de contenedor.     | No          |
| blobIndexMatch | Matriz de valores de diccionario compuesta por claves de etiquetas de índice de blob y condiciones de valor a coincidir. Cada regla puede definir hasta 10 condiciones de etiquetas de índice de blob. | No          |

#### Acciones de regla

Las acciones se aplican a los blobs filtrados cuando se cumple la condición de ejecución.

Lifecycle management admite la jerarquización y eliminación de blobs, y la eliminación de instantáneas de blobs. Defina al menos una acción para cada regla sobre blobs o instantáneas de blobs.

| Acción                      | Versión actual                         | Instantánea   | Versiones anteriores |
| --------------------------- | -------------------------------------- | ------------- | ----------------- |
| tierToCool                  | Compatible con blockBlob               | Compatible    | Compatible        |
| tierToCold                  | Compatible con blockBlob               | Compatible    | Compatible        |
| enableAutoTierToHotFromCool | Compatible con blockBlob               | No compatible | No compatible     |
| tierToArchive               | Compatible con blockBlob               | Compatible    | Compatible        |
| delete                      | Compatible con blockBlob y appendBlob  | Compatible    | Compatible        |

:information_source: Si define más de una acción en el mismo blob, lifecycle management aplica la acción menos costosa al blob. Por ejemplo, la acción `delete` es más barata que la acción `tierToArchive`. La acción `tierToArchive` es más barata que la acción `tierToCool`.

Las condiciones de ejecución se basan en la antigüedad. Los blobs base usan la hora de última modificación para realizar el seguimiento de la antigüedad, y las instantáneas de blobs usan la hora de creación de la instantánea.

| Condición de ejecución de acción   | Valor de condición                       | Descripción                                                                                                                                                                                |
| ---------------------------------- | ---------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| daysAfterModificationGreaterThan   | Valor entero que indica la antigüedad en días | Condición para acciones de blob base.                                                                                                                                                 |
| daysAfterCreationGreaterThan       | Valor entero que indica la antigüedad en días | Condición para acciones de instantáneas de blob.                                                                                                                                     |
| daysAfterLastAccessTimeGreaterThan | Valor entero que indica la antigüedad en días | Condición para la versión actual de un blob cuando el seguimiento de acceso está habilitado.                                                                                       |
| daysAfterLastTierChangeGreaterThan | Valor entero que indica la antigüedad en días | Duración mínima, en días, durante la cual un blob rehidratado se mantiene en niveles hot, cool o cold antes de volver al nivel archive. Esta condición se aplica solo a acciones `tierToArchive`. |

### Implementación de las directivas de ciclo de vida de Blob Storage

Puede agregar, editar o quitar una directiva usando cualquiera de los siguientes métodos:

- Azure portal
- Azure PowerShell
- Azure CLI
- REST APIs

A continuación se muestran los pasos y algunos ejemplos para el Portal y la CLI de Azure.

#### Azure portal

Hay dos formas de agregar una directiva a través de Azure Portal: vista de lista y vista de código. A continuación se muestra un ejemplo de cómo agregar una directiva en la vista de código de Azure Portal.

##### Azure portal Code view

1. En Azure Portal, vaya a su cuenta de almacenamiento.

1. En **Data management**, seleccione **Lifecycle Management** para ver o cambiar directivas de lifecycle management.

1. Seleccione la pestaña **Code View**. En esta pestaña, puede definir una directiva de lifecycle management en JSON.

   El siguiente JSON es un ejemplo de una directiva que mueve un blob en bloques cuyo nombre comienza con _log_ al nivel de acceso esporádico si han pasado más de 30 días desde que se modificó el blob.

   ```json
   {
     "rules": [
       {
         "enabled": true,
         "name": "move-to-cool",
         "type": "Lifecycle",
         "definition": {
           "actions": {
             "baseBlob": {
               "tierToCool": {
                 "daysAfterModificationGreaterThan": 30
               }
             }
           },
           "filters": {
             "blobTypes": ["blockBlob"],
             "prefixMatch": ["sample-container/log"]
           }
         }
       }
     ]
   }
   ```

#### Azure CLI

Para agregar una directiva de administración del ciclo de vida con la CLI de Azure, escriba la directiva en un archivo JSON y, a continuación, llame al comando `az storage account management-policy create` para crear la directiva.

```sh
az storage account management-policy create \
    --account-name <storage-account> \
    --policy @policy.json \
    --resource-group <resource-group>
```

Una directiva de administración del ciclo de vida debe leerse o escribirse completa. No se admiten las actualizaciones parciales.

### Rehidratación de datos de blob desde el nivel de archivo

Mientras un blob está en el nivel de acceso de archivo, se considera sin conexión y no se puede leer ni modificar. Para leer o modificar datos en un blob archivado, primero debe rehidratar el blob a un nivel en línea, ya sea el nivel de acceso frecuente o el esporádico. Hay dos opciones para rehidratar un blob almacenado en el nivel de archivo:

- **Copiar un blob archivado a un nivel en línea**: Puede rehidratar un blob archivado copiándolo a un blob nuevo en el nivel hot o cool con la operación [Copy Blob](https://learn.microsoft.com/en-us/rest/api/storageservices/copy-blob) o [Copy Blob from URL](https://learn.microsoft.com/en-us/rest/api/storageservices/copy-blob-from-url). Microsoft recomienda esta opción para la mayoría de los escenarios.
- **Cambiar el nivel de acceso de un blob a un nivel en línea**: Puede rehidratar un blob archivado a hot o cool cambiando su nivel con la operación [Set Blob Tier](https://learn.microsoft.com/en-us/rest/api/storageservices/set-blob-tier).

La rehidratación de un blob desde el nivel archive puede tardar varias horas en completarse. Microsoft recomienda rehidratar blobs más grandes para un rendimiento óptimo. Rehidratar varios blobs pequeños de forma simultánea puede requerir más tiempo.

#### Prioridad de rehidratación

Al rehidratar un blob, puede establecer la prioridad de la operación de rehidratación mediante el encabezado opcional `x-ms-rehydrate-priority` en una operación [Establecer nivel de blob](https://learn.microsoft.com/es-es/rest/api/storageservices/set-blob-tier) o **Copiar blob/Copiar blob desde URL**. Las opciones de prioridad de rehidratación incluyen:

- **Prioridad estándar**: La solicitud de rehidratación se procesa en el orden en que se recibió y puede tardar hasta 15 horas.
- **Prioridad alta**: La solicitud de rehidratación tiene prioridad sobre las solicitudes de prioridad estándar y puede completarse en menos de una hora para objetos menores de 10 GB.

Para comprobar la prioridad de rehidratación mientras la operación está en curso, llame a [Obtener propiedades del blob](https://learn.microsoft.com/es-es/rest/api/storageservices/get-blob-properties) para devolver el valor del encabezado `x-ms-rehydrate-priority`. La propiedad de prioridad de rehidratación devuelve `Standard` o `High`.

#### Copiar un blob archivado a un nivel en línea

La primera opción para mover un blob del nivel de archivo a un nivel en línea es copiar el blob archivado en un nuevo blob de destino que esté en el nivel de acceso frecuente o esporádico. Puede usar la operación [Copiar blob](https://learn.microsoft.com/es-es/rest/api/storageservices/copy-blob) para copiar el blob. Al copiar un blob archivado en un nuevo blob en un nivel en línea, el blob de origen permanece sin modificar en el nivel de archivo. Debe copiar el blob archivado en un nuevo blob con un nombre diferente o en un contenedor diferente. No puede sobrescribir el blob de origen copiando en el mismo blob.

La rehidratación de un blob archivado copiándolo a un nivel de destino en línea se admite dentro de la misma cuenta de almacenamiento solo para versiones del servicio anteriores a 2021-02-12. A partir de la versión 2021-02-12, puede rehidratar un blob archivado copiándolo a una cuenta de almacenamiento diferente, siempre que la cuenta de destino esté en la misma región que la cuenta de origen.

#### Cambiar el nivel de acceso de un blob a un nivel en línea

La segunda opción para rehidratar un blob del nivel de archivo a un nivel en línea es cambiar el nivel del blob llamando a **Establecer nivel de blob**. Con esta operación, puede cambiar el nivel del blob archivado a frecuente o esporádico.

Una vez iniciada una solicitud de **Establecer nivel de blob**, no se puede cancelar. Durante la operación de rehidratación, la configuración del nivel de acceso del blob continúa mostrándose como archivado hasta que se completa el proceso de rehidratación.

Para aprender a rehidratar un blob cambiando su nivel a un nivel en línea, consulte [Rehidratar un blob cambiando su nivel](https://learn.microsoft.com/es-es/azure/storage/blobs/archive-rehydrate-to-online-tier#rehydrate-a-blob-by-changing-its-tier).

:stop_sign: Cambiar el nivel de un blob no afecta su hora de última modificación. Si hay una directiva de administración del ciclo de vida activa para la cuenta de almacenamiento, rehidratar un blob con **Set Blob Tier** puede provocar que la directiva lo mueva de vuelta al nivel de archivo después de la rehidratación, porque la hora de última modificación supera el umbral definido por la directiva.

## Trabajo con Azure Blob Storage

Las bibliotecas de cliente de Azure Storage para .NET ofrecen una interfaz cómoda para realizar llamadas a Azure Storage.

### Exploración de la biblioteca cliente de Azure Blob Storage

Las bibliotecas de cliente de Azure Storage para .NET ofrecen una interfaz cómoda para realizar llamadas a Azure Storage. La versión más reciente de la biblioteca cliente de Azure Storage es la 12.x. Microsoft recomienda usar la versión 12.x para nuevas aplicaciones.

La siguiente tabla enumera las clases básicas, junto con una breve descripción:

| Clase               | Descripción                                                                                                                                                                    |
| ------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| BlobClient          | BlobClient permite manipular blobs de Azure Storage.                                                                                                                   |
| BlobClientOptions   | Proporciona las opciones de configuración del cliente para conectarse a Azure Blob Storage.                                                                                                |
| BlobContainerClient | BlobContainerClient permite manipular contenedores de Azure Storage y sus blobs.                                                                                     |
| BlobServiceClient   | BlobServiceClient permite manipular los recursos del servicio de Azure Storage y los contenedores de blobs. La cuenta de almacenamiento proporciona el espacio de nombres de nivel superior para el servicio Blob. |
| BlobUriBuilder      | La clase BlobUriBuilder proporciona una manera cómoda de modificar el contenido de una instancia de Uri para apuntar a diferentes recursos de Azure Storage, como una cuenta, un contenedor o un blob. |

Los siguientes paquetes contienen las clases que se usan para trabajar con recursos de datos de Blob Storage:

- [Azure.Storage.Blobs](https://learn.microsoft.com/es-es/dotnet/api/azure.storage.blobs): Contiene las clases principales (objetos de cliente) que puede usar para operar en el servicio, los contenedores y los blobs.
- [Azure.Storage.Blobs.Specialized](https://learn.microsoft.com/es-es/dotnet/api/azure.storage.blobs.specialized): Contiene clases que puede usar para realizar operaciones específicas de un tipo de blob, como los blobs en bloques.
- [Azure.Storage.Blobs.Models](https://learn.microsoft.com/es-es/dotnet/api/azure.storage.blobs.models): Todas las demás clases de utilidad, estructuras y tipos de enumeración.

### Creación de un objeto de cliente

Trabajar con cualquier recurso de Azure mediante el SDK comienza con la creación de un objeto de cliente. En esta sección, aprenderá a crear objetos de cliente para interactuar con los tres tipos de recursos del servicio de almacenamiento: cuentas de almacenamiento, contenedores y blobs.

Cuando la aplicación crea un objeto de cliente, se pasa un URI que hace referencia al punto de conexión al constructor del cliente. Puede construir la cadena de punto de conexión manualmente, como se muestra en los ejemplos de este artículo, o puede consultar el punto de conexión en tiempo de ejecución usando la biblioteca de administración de Azure Storage.

Los ejemplos de código de esta sección usan [DefaultAzureCredential](https://learn.microsoft.com/es-es/dotnet/api/azure.identity.defaultazurecredential) para autenticarse en Azure mediante una entidad de seguridad de Microsoft Entra. El proceso de autenticación incluye la obtención de un token de acceso para la autorización. Este token de acceso se pasa como credencial cuando se crea una instancia del cliente, y la credencial persiste durante toda la vida útil del cliente. La entidad de seguridad de Microsoft Entra que solicita el token debe tener asignado un rol de Azure RBAC adecuado que conceda acceso a los datos de blob.

#### Crear un objeto BlobServiceClient

Un objeto `BlobServiceClient` autorizado permite a la aplicación interactuar con los recursos en el nivel de la cuenta de almacenamiento. `BlobServiceClient` proporciona métodos para recuperar y configurar las propiedades de la cuenta, así como para enumerar, crear y eliminar contenedores dentro de la cuenta de almacenamiento. Este objeto de cliente es el punto de partida para interactuar con los recursos de la cuenta de almacenamiento.

El siguiente ejemplo muestra cómo crear un objeto `BlobServiceClient`:

```csharp
using Azure.Identity;
using Azure.Storage.Blobs;

public BlobServiceClient GetBlobServiceClient(string accountName)
{
    BlobServiceClient client = new(
        new Uri($"https://{accountName}.blob.core.windows.net"),
        new DefaultAzureCredential());

    return client;
}
```

#### Crear un objeto BlobContainerClient

Puede usar un objeto `BlobServiceClient` para crear un nuevo objeto `BlobContainerClient`. Un objeto `BlobContainerClient` permite interactuar con un recurso de contenedor específico. `BlobContainerClient` proporciona métodos para crear, eliminar o configurar un contenedor, e incluye métodos para enumerar, cargar y eliminar los blobs que contiene.

El siguiente ejemplo muestra cómo crear un cliente de contenedor desde un objeto `BlobServiceClient` para interactuar con un recurso de contenedor específico:

```csharp
public BlobContainerClient GetBlobContainerClient(
    BlobServiceClient blobServiceClient,
    string containerName)
{
    // Cree el cliente de contenedor usando el objeto cliente de servicio
    BlobContainerClient client = blobServiceClient.GetBlobContainerClient(containerName);
    return client;
}
```

Si el trabajo está limitado a un único contenedor, puede crear un objeto `BlobContainerClient` directamente sin usar `BlobServiceClient`.

```csharp
public BlobContainerClient GetBlobContainerClient(
    string accountName,
    string containerName,
    BlobClientOptions clientOptions)
{
    // Agregue el nombre del contenedor al final del URI
    BlobContainerClient client = new(
        new Uri($"https://{accountName}.blob.core.windows.net/{containerName}"),
        new DefaultAzureCredential(),
        clientOptions);

    return client;
}
```

#### Crear un objeto BlobClient

Para interactuar con un recurso de blob específico, cree un objeto `BlobClient` desde un cliente de servicio o un cliente de contenedor. Un objeto `BlobClient` permite interactuar con un recurso de blob específico.

El siguiente ejemplo muestra cómo crear un cliente de blob para interactuar con un recurso de blob específico:

```csharp
public BlobClient GetBlobClient(
    BlobServiceClient blobServiceClient,
    string containerName,
    string blobName)
{
    BlobClient client =
        blobServiceClient.GetBlobContainerClient(containerName).GetBlobClient(blobName);
    return client;
}
```

### Administración de propiedades y metadatos de contenedor con .NET

Los contenedores de blobs admiten propiedades del sistema y metadatos definidos por el usuario, además de los datos que contienen.

- **Propiedades del sistema**: Las propiedades del sistema existen en cada recurso de Blob Storage. Algunas se pueden leer o establecer, mientras que otras son de solo lectura. En el fondo, algunas propiedades del sistema corresponden a ciertos encabezados HTTP estándar. La biblioteca de cliente de Azure Storage para .NET mantiene estas propiedades automáticamente.
- **Metadatos definidos por el usuario**: Los metadatos definidos por el usuario consisten en uno o más pares de nombre y valor que especifica para un recurso de Blob Storage. Puede usar los metadatos para almacenar otros valores con el recurso. Los valores de los metadatos son solo para sus propios fines y no afectan al comportamiento del recurso.

  Los pares de nombre y valor de los metadatos son encabezados HTTP válidos y, por ello, deben cumplir todas las restricciones que rigen los encabezados HTTP. Los nombres de metadatos deben ser nombres de encabezado HTTP válidos e identificadores de C# válidos, solo pueden contener caracteres ASCII y deben tratarse como sin distinción entre mayúsculas y minúsculas. Los valores de metadatos que contengan caracteres no ASCII deben estar codificados en Base64 o en URL.

#### Recuperar propiedades del contenedor

Para recuperar las propiedades del contenedor, llame a uno de los siguientes métodos de la clase BlobContainerClient:

- `GetProperties`
- `GetPropertiesAsync`

El siguiente ejemplo de código obtiene las propiedades del sistema de un contenedor y escribe algunos valores de propiedad en una ventana de consola:

```csharp
private static async Task ReadContainerPropertiesAsync(BlobContainerClient container)
{
    try
    {
        // Obtenga algunas propiedades del contenedor y escriba sus valores.
        var properties = await container.GetPropertiesAsync();
        Console.WriteLine($"Properties for container {container.Uri}");
        Console.WriteLine($"Public access level: {properties.Value.PublicAccess}");
        Console.WriteLine($"Last modified time in UTC: {properties.Value.LastModified}");
    }
    catch (RequestFailedException e)
    {
        Console.WriteLine($"HTTP error code {e.Status}: {e.ErrorCode}");
        Console.WriteLine(e.Message);
        Console.ReadLine();
    }
}
```

#### Establecer y recuperar metadatos

Puede especificar los metadatos como uno o más pares de nombre y valor en un recurso de blob o contenedor. Para establecer los metadatos, agregue pares de nombre y valor a un objeto `IDictionary` y, a continuación, llame a uno de los siguientes métodos de la clase `BlobContainerClient` para escribir los valores:

- `SetMetadata`
- `SetMetadataAsync`

El nombre de los metadatos debe cumplir las convenciones de nomenclatura para identificadores de C#. Los nombres de metadatos conservan el caso con el que se crearon, pero no distinguen mayúsculas de minúsculas cuando se establecen o leen. Si se envían dos o más encabezados de metadatos con el mismo nombre para un recurso, Blob Storage los separa por comas, concatena los dos valores y devuelve el código de respuesta HTTP `200 (OK)`.

El siguiente ejemplo de código establece metadatos en un contenedor.

```csharp
public static async Task AddContainerMetadataAsync(BlobContainerClient container)
{
    try
    {
        IDictionary<string, string> metadata =
           new Dictionary<string, string>();

        // Agregue algunos metadatos al contenedor.
        metadata.Add("docType", "textDocuments");
        metadata.Add("category", "guidance");

        // Establezca los metadatos del contenedor.
        await container.SetMetadataAsync(metadata);
    }
    catch (RequestFailedException e)
    {
        Console.WriteLine($"HTTP error code {e.Status}: {e.ErrorCode}");
        Console.WriteLine(e.Message);
        Console.ReadLine();
    }
}
```

Los métodos `GetProperties` y `GetPropertiesAsync` se usan para recuperar metadatos además de propiedades, como se mostró anteriormente.

El siguiente ejemplo de código recupera los metadatos de un contenedor.

```csharp
public static async Task ReadContainerMetadataAsync(BlobContainerClient container)
{
    try
    {
        var properties = await container.GetPropertiesAsync();

        // Enumere los metadatos del contenedor.
        Console.WriteLine("Container metadata:");
        foreach (var metadataItem in properties.Value.Metadata)
        {
            Console.WriteLine($"\tKey: {metadataItem.Key}");
            Console.WriteLine($"\tValue: {metadataItem.Value}");
        }
    }
    catch (RequestFailedException e)
    {
        Console.WriteLine($"HTTP error code {e.Status}: {e.ErrorCode}");
        Console.WriteLine(e.Message);
        Console.ReadLine();
    }
}
```

### Establecimiento y recuperación de propiedades y metadatos de blobs mediante REST

Los contenedores y los blobs admiten metadatos personalizados, representados como encabezados HTTP. Los encabezados de metadatos se pueden establecer en una solicitud que crea un nuevo recurso de contenedor o blob, o en una solicitud que crea explícitamente una propiedad en un recurso existente.

#### Formato del encabezado de metadatos

Los encabezados de metadatos son pares nombre/valor. El formato del encabezado es:

```txt
x-ms-meta-name:string-value
```

A partir de la versión 2009-09-19, los nombres de metadatos deben adherirse a las reglas de nomenclatura para identificadores de C#.

Los nombres no distinguen entre mayúsculas y minúsculas. Los nombres de metadatos preservan el caso con el que se crearon, pero no distinguen entre mayúsculas y minúsculas cuando se establecen o se leen. Si se envían dos o más encabezados de metadatos con el mismo nombre para un recurso, el servicio Blob devuelve el código de estado `400 (Bad Request)`.

Los metadatos constan de pares nombre/valor. El tamaño total de todos los pares de metadatos puede ser de hasta 8 KB.

Los pares nombre/valor de metadatos son encabezados HTTP válidos y, por lo tanto, se adhieren a todas las restricciones que rigen los encabezados HTTP.

#### Operaciones sobre metadatos

Los metadatos de un recurso blob o contenedor pueden recuperarse o establecerse directamente, sin devolver ni alterar el contenido del recurso.

Los valores de metadatos solo pueden leerse o escribirse completos; no se admiten actualizaciones parciales. Establecer metadatos en un recurso sobrescribe cualquier valor de metadatos existente de ese recurso.

##### Recuperación de propiedades y metadatos

Las operaciones GET y HEAD recuperan los encabezados de metadatos del contenedor o blob especificado. Estas operaciones devuelven solo encabezados; no devuelven un cuerpo de respuesta. La sintaxis del URI para recuperar encabezados de metadatos en un contenedor es de la siguiente manera:

```txt
GET/HEAD https://myaccount.blob.core.windows.net/mycontainer?restype=container
```

La sintaxis del URI para recuperar encabezados de metadatos en un blob es de la siguiente manera:

```txt
GET/HEAD https://myaccount.blob.core.windows.net/mycontainer/myblob?comp=metadata
```

##### Configuración de encabezados de metadatos

La operación PUT establece encabezados de metadatos en el contenedor o blob especificado, sobrescribiendo los metadatos existentes en el recurso. Llamar a PUT sin ningún encabezado en la solicitud borra todos los metadatos existentes en el recurso.

La sintaxis del URI para establecer encabezados de metadatos en un contenedor es de la siguiente manera:

```txt
PUT https://myaccount.blob.core.windows.net/mycontainer?comp=metadata&restype=container
```

La sintaxis del URI para establecer encabezados de metadatos en un blob es de la siguiente manera:

```txt
PUT https://myaccount.blob.core.windows.net/mycontainer/myblob?comp=metadata
```

#### Propiedades HTTP estándar para contenedores y blobs

Los contenedores y blobs también admiten ciertas propiedades HTTP estándar. Tanto las propiedades como los metadatos se representan como encabezados HTTP estándar; la diferencia entre ambos está en la nomenclatura de los encabezados. Los encabezados de metadatos se nombran con el prefijo `x-ms-meta-` y un nombre personalizado. Los encabezados de propiedades usan nombres estándar de encabezado HTTP, tal como se especifica en la sección 14 (Header Field Definitions) de la especificación del protocolo HTTP/1.1.

Los encabezados HTTP estándar admitidos en contenedores incluyen:

- ETag
- Last-Modified

Los encabezados HTTP estándar admitidos en blobs incluyen:

- ETag
- Last-Modified
- Content-Length
- Content-Type
- Content-MD5
- Content-Encoding
- Content-Language
- Cache-Control
- Origin
- Range

---

# PARTE 3 — Implementación de la seguridad de Azure (15-20 %)

---

<!-- ===== Autenticación y autorización — Microsoft Entra ID ===== -->

# Autenticación y autorización

## Exploración de la plataforma de identidad de Microsoft

La plataforma de identidad de Microsoft para desarrolladores es un conjunto de herramientas que incluye el servicio de autenticación, bibliotecas de código abierto y herramientas de administración de aplicaciones.

### Exploración de la plataforma de identidad de Microsoft

La plataforma de identidad de Microsoft le ayuda a crear aplicaciones en las que los usuarios y clientes pueden iniciar sesión con sus identidades de Microsoft o cuentas sociales, y proporcionar acceso autorizado a sus propias API o a las API de Microsoft como Microsoft Graph.

Hay varios componentes que conforman Microsoft identity platform:

- **Servicio de autenticación compatible con los estándares OAuth 2.0 y OpenID Connect** que permite a los desarrolladores autenticar varios tipos de identidad, incluidos:

  - Cuentas profesionales o educativas, aprovisionadas mediante Microsoft Entra ID
  - Cuenta personal de Microsoft, como Skype, Xbox y Outlook.com
  - Cuentas sociales o locales, mediante Azure Active Directory B2C
  - Cuentas sociales o locales de clientes, mediante Microsoft Entra External ID

- **Bibliotecas de código abierto**: Microsoft Authentication Libraries (MSAL) y compatibilidad con otras bibliotecas que cumplen estándares

- **Punto de conexión de Microsoft identity platform**: Funciona con Microsoft Authentication Libraries (MSAL) o cualquier otra biblioteca compatible con estándares. Implementa ámbitos legibles por personas, de acuerdo con estándares del sector.

- **Portal de administración de aplicaciones**: Experiencia de registro y configuración en Azure Portal, junto con el resto de capacidades de administración de Azure.

- **API de configuración de aplicaciones y PowerShell**: Configuración programática de aplicaciones mediante Microsoft Graph API y PowerShell, para que pueda automatizar tareas de DevOps.

Para los desarrolladores, Microsoft identity platform ofrece la integración de innovaciones modernas en identidad y seguridad, como autenticación sin contraseña, step-up authentication y Conditional Access. No necesita implementar esta funcionalidad por su cuenta: las aplicaciones integradas con Microsoft identity platform aprovechan estas innovaciones de forma nativa.

### Exploración de las entidades de servicio

Para delegar las funciones de administración de identidades y acceso en Microsoft Entra ID, una aplicación debe registrarse con un inquilino de Microsoft Entra. Al registrar la aplicación en Microsoft Entra ID, se crea una configuración de identidad para la aplicación que le permite integrarse con Microsoft Entra ID. Al registrar una aplicación en Azure Portal, debe elegir si es:

- **Inquilino único**: solo accesible en su inquilino
- **Varios inquilinos**: accesible en otros inquilinos

Si registra una aplicación en el portal, se crean automáticamente un objeto de aplicación (la instancia globalmente única de la aplicación) y un objeto de entidad de servicio en el inquilino principal. También tiene un identificador globalmente único para la aplicación (el identificador de aplicación o cliente). En el portal, puede agregar secretos o certificados y ámbitos para que la aplicación funcione, personalizar la marca de la aplicación en el cuadro de diálogo de inicio de sesión y mucho más.

:information_source: También puede crear objetos principales de servicio en un inquilino mediante Azure PowerShell, Azure CLI, Microsoft Graph y otras herramientas.

#### Objeto de aplicación

Una aplicación de Microsoft Entra tiene el ámbito de su único objeto de aplicación. El objeto de aplicación reside en el inquilino de Microsoft Entra donde se registró la aplicación (conocido como el inquilino "principal" de la aplicación). Un objeto de aplicación se usa como plantilla o plano técnico para crear uno o más objetos de entidad de servicio. Se crea una entidad de servicio en cada inquilino donde se usa la aplicación. De forma similar a una clase en la programación orientada a objetos, el objeto de aplicación tiene algunas propiedades estáticas que se aplican a todas las entidades de servicio creadas (o instancias de aplicación).

El objeto de aplicación describe tres aspectos de una aplicación:

- Cómo el servicio puede emitir tokens para acceder a la aplicación.
- Recursos a los que la aplicación podría necesitar acceder.
- Las acciones que la aplicación puede realizar.

La [entidad Application](https://learn.microsoft.com/es-es/graph/api/resources/application) de Microsoft Graph define el esquema de las propiedades de un objeto de aplicación.

#### Objeto principal de servicio

Para acceder a los recursos protegidos por un inquilino de Microsoft Entra, la entidad que solicita el acceso debe estar representada por una entidad de seguridad. Esto es válido tanto para los usuarios (entidad de seguridad de usuario) como para las aplicaciones (entidad de servicio).

La entidad de seguridad define la directiva de acceso y los permisos para el usuario o la aplicación en el inquilino de Microsoft Entra. Esto habilita características básicas como la autenticación del usuario o la aplicación durante el inicio de sesión y la autorización durante el acceso a los recursos.

Hay tres tipos de entidades de servicio:

- **Aplicación**: Este tipo de entidad de servicio es la representación local, o instancia de aplicación, de un objeto de aplicación global en un único inquilino o directorio. Se crea una entidad de servicio en cada inquilino donde se usa la aplicación, y hace referencia al objeto de aplicación globalmente único. El objeto principal de servicio define qué puede hacer realmente la aplicación en el inquilino específico, quién puede acceder a la aplicación y a qué recursos puede acceder la aplicación.
- **Identidad administrada**: Este tipo de entidad de servicio se usa para representar una identidad administrada. Las identidades administradas proporcionan una identidad para que las aplicaciones la usen al conectarse a recursos que admiten autenticación de Microsoft Entra. Cuando se habilita una identidad administrada, se crea una entidad de servicio que representa esa identidad administrada en su inquilino. Las entidades de servicio que representan identidades administradas pueden recibir acceso y permisos, pero no se pueden actualizar ni modificar directamente.
- **Heredada**: Este tipo de entidad de servicio representa una aplicación heredada, que es una aplicación creada antes de que se introdujeran los registros de aplicaciones o una aplicación creada a través de experiencias heredadas. Una entidad de servicio heredada puede tener:
  - credenciales
  - nombres principales del servicio
  - URL de respuesta
  - y otras propiedades que un usuario autorizado puede editar, pero que no tienen un registro de aplicación asociado.

#### Relación entre objetos de aplicación y entidades de servicio

El objeto de aplicación es la representación _global_ de la aplicación para su uso en todos los inquilinos, y la entidad de servicio es la representación _local_ para su uso en un inquilino específico. El objeto de aplicación sirve como plantilla a partir de la cual se _derivan_ las propiedades comunes y predeterminadas para usarlas al crear los objetos de entidad de servicio correspondientes.

Un objeto de aplicación tiene:

- Una relación uno a uno con la aplicación de software, y
- Relaciones uno a muchos con sus objetos de entidad de servicio correspondientes.

Se debe crear una entidad de servicio en cada inquilino donde se usa la aplicación para establecer una identidad para el inicio de sesión o el acceso a los recursos protegidos por el inquilino. Una aplicación de inquilino único solo tiene una entidad de servicio (en su inquilino principal), creada y autorizada para su uso durante el registro de la aplicación. Una aplicación multiinquilino también tiene una entidad de servicio creada en cada inquilino donde un usuario de ese inquilino dio su consentimiento para su uso.

### Descripción de los permisos y el consentimiento

Las aplicaciones que se integran con la plataforma de identidad de Microsoft siguen un modelo de autorización que los usuarios y administradores la capacidad de controlar cómo se puede acceder a los datos.

La plataforma de identidad de Microsoft implementa el protocolo de autorización OAuth 2.0. [OAuth 2.0](https://learn.microsoft.com/es-es/azure/active-directory/develop/active-directory-v2-protocols) es un método a través del cual una aplicación de terceros puede acceder a recursos hospedados en la web en nombre de un usuario. Cualquier recurso hospedado en la web que se integre con la plataforma de identidad de Microsoft tiene un identificador de recurso o _URI de identificador de aplicación_.

Estos son algunos ejemplos de recursos web hospedados por Microsoft:

- Microsoft Graph: <https://graph.microsoft.com>
- Microsoft 365 Mail API: <https://outlook.office.com>
- Azure Key Vault: <https://vault.azure.net>

Lo mismo ocurre con los recursos de terceros integrados con la plataforma de identidad de Microsoft. Cualquiera de estos recursos también puede definir un conjunto de permisos que se pueden usar para dividir la funcionalidad de ese recurso en partes más pequeñas. Cuando la funcionalidad de un recurso se divide en conjuntos de permisos pequeños, las aplicaciones de terceros se pueden crear para solicitar solo los permisos que necesitan para realizar su función. Los usuarios y los administradores pueden saber a qué datos puede acceder la aplicación.

En OAuth 2.0, estos tipos de conjuntos de permisos se denominan _ámbitos_. También se suelen denominar _permisos_. En la plataforma de identidad de Microsoft, un permiso se representa como un valor de cadena. Una aplicación solicita los permisos que necesita especificando el permiso en el parámetro de consulta `scope`. La plataforma de identidad admite varios [ámbitos de OpenID Connect](https://learn.microsoft.com/es-es/azure/active-directory/develop/v2-permissions-and-consent#openid-connect-scopes) bien definidos y permisos basados en recursos (cada permiso se indica anexando el valor del permiso al identificador del recurso o al URI del identificador de aplicación). Por ejemplo, la cadena de permiso `https://graph.microsoft.com/Calendars.Read` se usa para solicitar permiso para leer los calendarios de los usuarios en Microsoft Graph.

Una aplicación solicita normalmente estos permisos especificando los ámbitos en las solicitudes al punto de conexión de autorización de la plataforma de identidad de Microsoft. Sin embargo, algunos permisos de alto privilegio solo se pueden conceder mediante el consentimiento del administrador. Se pueden solicitar o conceder usando el [punto de conexión de consentimiento del administrador](https://learn.microsoft.com/es-es/azure/active-directory/develop/v2-permissions-and-consent#admin-restricted-permissions).

:information_source: En solicitudes a los puntos de conexión de autorización, token o consentimiento de Microsoft identity platform, si se omite el identificador de recurso en el parámetro `scope`, se asume que el recurso es Microsoft Graph. Por ejemplo, `scope=User.Read` equivale a `https://graph.microsoft.com/User.Read`.

#### Tipos de permisos

La plataforma de identidad de Microsoft admite dos tipos de permisos: _acceso delegado_ y _acceso solo de aplicación_.

- **Acceso delegado**: lo usan aplicaciones con un usuario autenticado presente. En estas aplicaciones, el usuario o un administrador concede consentimiento a los permisos solicitados. La aplicación recibe permiso delegado para actuar como el usuario autenticado cuando llama al recurso de destino.
- **Permisos de acceso solo de aplicación**: los usan aplicaciones que se ejecutan sin un usuario autenticado presente, por ejemplo, servicios en segundo plano o daemons. Solo un administrador puede otorgar consentimiento a estos permisos.

#### Tipos de consentimiento

Las aplicaciones en Microsoft identity platform dependen del consentimiento para obtener acceso a recursos o API necesarias. Hay varios tipos de consentimiento que su aplicación debe conocer para tener éxito. Si está definiendo permisos, también debe comprender cómo sus usuarios obtienen acceso a su aplicación o API.

Hay tres tipos de consentimiento: _consentimiento de usuario estático_, _consentimiento incremental y dinámico del usuario_ y _consentimiento de administrador_.

##### Consentimiento de usuario estático

En el escenario de consentimiento de usuario estático, debe especificar todos los permisos que necesita en la configuración de la aplicación en Azure Portal. Si el usuario (o el administrador, según corresponda) no ha dado su consentimiento para esta aplicación, la plataforma de identidad de Microsoft solicita al usuario que proporcione el consentimiento en ese momento. Los permisos estáticos también permiten a los administradores dar su consentimiento en nombre de todos los usuarios de la organización.

Aunque los permisos estáticos de la aplicación definidos en Azure Portal mantienen el código limpio y sencillo, presenta algunos posibles problemas para los desarrolladores:

- La aplicación debe solicitar todos los permisos que podría necesitar en el primer inicio de sesión del usuario. Esto puede generar una lista larga de permisos que desanime a los usuarios finales a aprobar el acceso inicial.
- La aplicación debe conocer por adelantado todos los recursos a los que podría acceder. Es difícil crear aplicaciones que puedan acceder a una cantidad arbitraria de recursos.

##### Consentimiento incremental y dinámico del usuario

Con el punto de conexión de la plataforma de identidad de Microsoft, puede ignorar los permisos estáticos definidos en la información de registro de la aplicación en Azure Portal y solicitar permisos de forma incremental. Puede solicitar un conjunto mínimo de permisos de antemano y solicitar más a medida que el cliente use más características de la aplicación.

Para ello, puede especificar los ámbitos que necesita la aplicación en cualquier momento incluyendo los nuevos ámbitos en el parámetro `scope` al solicitar un token de acceso, sin necesidad de predefinirlos en la información de registro de la aplicación. Si el usuario aún no ha dado su consentimiento a los nuevos ámbitos agregados a la solicitud, se le pedirá que dé su consentimiento solo para los nuevos permisos. El consentimiento incremental o dinámico solo se aplica a los permisos delegados y no a los permisos de solo acceso de aplicación.

:bangbang: El consentimiento dinámico puede ser conveniente, pero plantea un desafío importante para permisos que requieren consentimiento de administrador, porque la experiencia de consentimiento de administrador no conoce esos permisos en el momento del consentimiento. Si necesita permisos privilegiados de administrador o su aplicación usa consentimiento dinámico, debe registrar todos los permisos en Azure Portal (no solo el subconjunto que requiere consentimiento de administrador). Esto permite que los administradores del tenant den consentimiento en nombre de todos los usuarios.

##### Consentimiento de administrador

Se requiere consentimiento de administrador cuando la aplicación necesita acceso a ciertos permisos de alto privilegio. Esto garantiza que los administradores tengan controles adicionales antes de autorizar aplicaciones o usuarios para acceder a datos altamente privilegiados de la organización.

El consentimiento de administrador en nombre de una organización sigue requiriendo los permisos estáticos registrados para la aplicación. Configure esos permisos en el portal de registro de aplicaciones si necesita que un administrador otorgue consentimiento para toda la organización. Esto reduce los ciclos necesarios para que el administrador configure la aplicación.

#### Solicitar consentimiento individual del usuario

En una solicitud de autorización de OpenID Connect u OAuth 2.0, una aplicación puede solicitar los permisos que necesita usando el parámetro de consulta scope. Por ejemplo, cuando un usuario inicia sesión en una aplicación, la aplicación envía una solicitud como el siguiente ejemplo. Se agregan saltos de línea para facilitar la lectura.

```http
GET https://login.microsoftonline.com/common/oauth2/v2.0/authorize?
client_id=00001111-aaaa-2222-bbbb-3333cccc4444
&response_type=code
&redirect_uri=http%3A%2F%2Flocalhost%2Fmyapp%2F
&response_mode=query
&scope=
https%3A%2F%2Fgraph.microsoft.com%2Fcalendars.read%20
https%3A%2F%2Fgraph.microsoft.com%2Fmail.send
&state=12345
```

El parámetro `scope` es una lista separada por espacios de permisos delegados que solicita la aplicación. Cada permiso se indica anexando el valor del permiso al identificador del recurso (el URI del identificador de aplicación). En el ejemplo de solicitud, la aplicación necesita permiso para leer el calendario del usuario y enviar correo como el usuario.

Una vez que el usuario escribe sus credenciales, la plataforma de identidad de Microsoft busca un registro coincidente de consentimiento del usuario. Si el usuario no ha dado su consentimiento a ninguno de los permisos solicitados anteriormente, y si el administrador no ha dado su consentimiento a estos permisos en nombre de toda la organización, la plataforma de identidad de Microsoft pide al usuario que conceda los permisos solicitados.

### Descripción del acceso condicional

La característica de acceso condicional en Microsoft Entra ID ofrece una de las varias formas que puede usar para proteger la aplicación y un servicio. El acceso condicional permite a los desarrolladores y clientes empresariales proteger los servicios de múltiples maneras, entre las que se incluyen:

- [Autenticación multifactor](https://learn.microsoft.com/en-us/azure/active-directory/authentication/concept-mfa-howitworks)
- Permitir solo dispositivos inscritos en Intune para acceder a servicios específicos
- Restringir ubicaciones de usuario y rangos de IP

#### ¿Cómo impacta el acceso condicional en una aplicación?

En la mayoría de los casos comunes, el acceso condicional no cambia el comportamiento de una aplicación ni requiere cambios del desarrollador. Solo en ciertos casos en los que una aplicación solicita de forma indirecta o silenciosa un token para un servicio, la aplicación requiere cambios de código para controlar los desafíos del acceso condicional. Puede ser tan sencillo como realizar una solicitud de inicio de sesión interactivo.

En concreto, los siguientes escenarios requieren código para manejar desafíos de Conditional Access:

- Aplicaciones que ejecutan el flujo on-behalf-of
- Aplicaciones que acceden a varios servicios/recursos
- Aplicaciones de página única que usan MSAL.js
- Aplicaciones web que llaman a un recurso

Las directivas de Conditional Access se pueden aplicar tanto a la aplicación como a una API web a la que su aplicación accede. Según el escenario, un cliente empresarial puede aplicar y quitar estas directivas en cualquier momento. Para que la aplicación siga funcionando cuando se aplique una nueva directiva, implemente el manejo de desafíos.

#### Ejemplos de Conditional Access

Algunos escenarios requieren cambios de código para controlar el acceso condicional, mientras que otros funcionan tal como están. Aquí hay algunos escenarios que usan el acceso condicional para la autenticación multifactor y que ofrecen información sobre la diferencia.

- Está creando una aplicación iOS de inquilino único y aplica una directiva de Conditional Access. La aplicación inicia sesión de un usuario y no solicita acceso a una API. Cuando el usuario inicia sesión, la directiva se invoca automáticamente y el usuario debe realizar autenticación multifactor.
- Está creando una aplicación que usa un servicio de nivel intermedio para acceder a una API de nivel inferior. Un cliente empresarial de la compañía que usa esta aplicación aplica una directiva a la API de nivel inferior. Cuando un usuario final inicia sesión, la aplicación solicita acceso al nivel intermedio y envía el token. El nivel intermedio ejecuta el flujo on-behalf-of para solicitar acceso a la API de nivel inferior. En ese momento, se presenta un "claims challenge" al nivel intermedio. El nivel intermedio devuelve ese desafío a la aplicación, que debe cumplir la directiva de Conditional Access.

## Implementación de la autenticación con la biblioteca de autenticación de Microsoft (MSAL)

La Biblioteca de autenticación de Microsoft (MSAL) permite a los desarrolladores adquirir tokens de la plataforma de identidad de Microsoft para autenticar usuarios y acceder a API web protegidas.

### Exploración de la biblioteca de autenticación de Microsoft (MSAL)

La Biblioteca de autenticación de Microsoft (MSAL) permite a los desarrolladores adquirir tokens de seguridad de la plataforma de identidad de Microsoft para autenticar usuarios y acceder a API web protegidas. Se puede usar para proporcionar acceso seguro a Microsoft Graph, otras API de Microsoft, API web de terceros o su propia API web. MSAL admite muchas arquitecturas y plataformas de aplicaciones diferentes, incluidas .NET, JavaScript, Java, Python, Android e iOS.

MSAL le ofrece muchas formas de obtener tokens, con una API consistente para muchas plataformas. El uso de MSAL proporciona los siguientes beneficios:

- Sin necesidad de usar directamente las librerías de OAuth o código contra el protocolo en su aplicación.
- Adquiere tokens en nombre de un usuario o en nombre de una aplicación (cuando corresponda a la plataforma).
- Mantiene una caché de tokens y actualiza los tokens por usted cuando están cerca de expirar. No necesita manejar la expiración de tokens por su cuenta.
- Lo ayuda a especificar qué audiencia desea que su aplicación inicie sesión.
- Lo ayuda a configurar su aplicación desde archivos de configuración.
- Lo ayuda a solucionar problemas de su aplicación exponiendo excepciones prácticas, registro y telemetría.

#### Tipos de aplicación y escenarios

Usando MSAL, un token se puede adquirir de muchos tipos de aplicaciones: aplicaciones web, API web, aplicaciones de página única (JavaScript), aplicaciones móviles y nativas, y aplicaciones daemon y del lado del servidor. MSAL actualmente admite las plataformas y marcos enumerados en la siguiente tabla.

| Biblioteca             | Plataformas y marcos compatibles                                                                 |
| ---------------------- | ------------------------------------------------------------------------------------------------ |
| MSAL para Android      | Android                                                                                          |
| MSAL Angular           | Aplicaciones de página única con marcos Angular y Angular.js                                    |
| MSAL para iOS y macOS  | iOS y macOS                                                                                      |
| MSAL Go (Preview)      | Windows, macOS, Linux                                                                            |
| MSAL Java              | Windows, macOS, Linux                                                                            |
| MSAL.js                | Marcos JavaScript/TypeScript como Vue.js, Ember.js o Durandal.js                               |
| MSAL.NET               | .NET Framework, .NET, .NET MAUI, WINUI, Xamarin Android, Xamarin iOS, Universal Windows Platform |
| MSAL Node              | Aplicaciones web con Express, aplicaciones de escritorio con Electron y apps de consola multiplataforma |
| MSAL Python            | Windows, macOS, Linux                                                                            |
| MSAL React             | Aplicaciones de página única con React y bibliotecas basadas en React (Next.js, Gatsby.js)     |

#### Flujos de autenticación

La siguiente tabla muestra algunos de los diferentes flujos de autenticación que proporciona la Biblioteca de autenticación de Microsoft (MSAL). Estos flujos se pueden usar en diversos escenarios de aplicación.

| Flujo de autenticación                  | Permite                                                                                                                                                                                          | Tipos de aplicación compatibles           |
| --------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ----------------------------------------- |
| Authorization code                      | Inicio de sesión de usuario y acceso a API web en nombre del usuario.                                                                                                                           | Desktop, Mobile, SPA (requires PKCE), Web |
| Client credentials                      | Acceso a API web usando la identidad de la propia aplicación. Normalmente se usa para comunicación servidor a servidor y scripts automatizados sin interacción del usuario.                     | Daemon                                    |
| Device code                             | Inicio de sesión de usuario y acceso a API web en nombre del usuario en dispositivos con entrada limitada, como smart TVs e IoT. También se usa en aplicaciones de interfaz de línea de comandos (CLI). | Desktop, Mobile                           |
| Implicit grant                          | Inicio de sesión de usuario y acceso a API web en nombre del usuario. El flujo implicit grant ya no se recomienda; use authorization code con PKCE.                                             | SPA, Web                                  |
| On-behalf-of (OBO)                      | Acceso desde una API web "upstream" a una API web "downstream" en nombre del usuario. La identidad del usuario y los permisos delegados se transfieren a la API downstream desde la API upstream. | Web API                                   |
| Username/password (ROPC)                | Permite que una aplicación inicie sesión del usuario administrando directamente su contraseña. El flujo ROPC NO se recomienda.                                                                  | Desktop, Mobile                           |
| Integrated Windows authentication (IWA) | Permite que aplicaciones en equipos unidos a dominio o Microsoft Entra adquieran un token en silencio (sin interacción de interfaz de usuario).                                                  | Desktop, Mobile                           |

##### Aplicaciones cliente públicas y cliente confidenciales

La Biblioteca de autenticación de Microsoft (MSAL) define dos tipos de clientes: clientes públicos y clientes confidenciales. Un cliente es una entidad de software que tiene un identificador único asignado por un proveedor de identidades. Los tipos de clientes difieren según su capacidad para autenticarse de forma segura con el servidor de autorización y mantener información confidencial de prueba de identidad de modo que no sea accesible ni conocida por un usuario dentro del ámbito de su acceso.

Al examinar la naturaleza pública o confidencial de un cliente determinado, se evalúa la capacidad de ese cliente para demostrar su identidad al servidor de autorización. Esto es importante porque el servidor de autorización debe poder confiar en la identidad del cliente para emitir tokens de acceso.

- **Aplicaciones cliente públicas**: se ejecutan en dispositivos, como escritorio, API sin explorador, móviles o aplicaciones de explorador del lado cliente. No se puede confiar en que mantengan secretos de aplicación de forma segura, por lo que solo pueden acceder a API web en nombre del usuario. Siempre que el código fuente o bytecode compilado se distribuye, puede ser leído, desensamblado o inspeccionado por partes no confiables. Como además solo admiten flujos de cliente público y no pueden mantener secretos en configuración, no pueden tener client secrets.
- **Aplicaciones cliente confidenciales**: se ejecutan en servidores, como aplicaciones web, API web o servicios/daemons. Se consideran difíciles de acceder por usuarios o atacantes y, por tanto, pueden mantener secretos de configuración para demostrar su identidad. El client ID se expone a través del navegador web, pero el secreto se envía solo por el canal de back-end y nunca se expone directamente.

### Inicialización de aplicaciones cliente

Con MSAL.NET 3.x, la forma recomendada de crear una instancia de una aplicación es usar los generadores de aplicaciones: `PublicClientApplicationBuilder` y `ConfidentialClientApplicationBuilder`. Ofrecen un mecanismo eficaz para configurar la aplicación desde el código, desde un archivo de configuración o incluso mezclando ambos enfoques.

Antes de inicializar una aplicación, primero debe registrarla para que pueda integrarse con la plataforma de identidad de Microsoft. Después del registro, es posible que necesite la siguiente información (que se puede encontrar en Azure Portal):

- **Application (client) ID** - Es una cadena que representa un GUID.
- **Directory (tenant) ID** - Proporciona capacidades de administración de identidades y acceso (IAM) para aplicaciones y recursos usados por su organización. Puede indicar si está creando una aplicación de negocio solo para su organización (también llamada aplicación de inquilino único).
- La URL del proveedor de identidades (denominada **instance**) y la audiencia de inicio de sesión de su aplicación. Estos dos parámetros se conocen en conjunto como authority.
- **Client credentials** - pueden tomar la forma de un secreto de aplicación (cadena client secret) o un certificado (de tipo `X509Certificate2`) si es una aplicación cliente confidencial.
- Para aplicaciones web y, a veces, para aplicaciones cliente públicas (en particular cuando la aplicación necesita usar un broker), debe establecer el **Redirect URI** donde el proveedor de identidades devolverá los tokens de seguridad a la aplicación.

#### Inicialización de aplicaciones cliente públicas y confidenciales desde código

El siguiente código crea una instancia de una aplicación de cliente público, iniciando la sesión de los usuarios en la nube pública de Microsoft Azure, con sus cuentas profesionales o educativas, o sus cuentas personales de Microsoft.

```csharp
IPublicClientApplication app = PublicClientApplicationBuilder.Create(clientId).Build();
```

Del mismo modo, el siguiente código crea una instancia de una aplicación confidencial (una aplicación web ubicada en `https://myapp.azurewebsites.net`) que controla los tokens de los usuarios en la nube pública de Microsoft Azure, con sus cuentas profesionales y educativas o sus cuentas personales de Microsoft. La aplicación se identifica con el proveedor de identidades compartiendo un secreto de cliente:

```csharp
string redirectUri = "https://myapp.azurewebsites.net";
IConfidentialClientApplication app = ConfidentialClientApplicationBuilder.Create(clientId)
    .WithClientSecret(clientSecret)
    .WithRedirectUri(redirectUri )
    .Build();
```

#### Modificadores de constructor

En los fragmentos de código que usan generadores de aplicaciones, los métodos `.With` se pueden aplicar como modificadores (por ejemplo, `.WithAuthority` y `.WithRedirectUri`).

- Modificador `.WithAuthority`: establece la authority predeterminada de la aplicación en una authority de Microsoft Entra, con la posibilidad de elegir Azure Cloud, audiencia, tenant (tenant ID o nombre de dominio), o proporcionar directamente el URI de authority.

  ```csharp
  IPublicClientApplication app;
  app = PublicClientApplicationBuilder.Create(clientId)
      .WithAuthority(AzureCloudInstance.AzurePublic, tenantId)
      .Build();
  ```

- Modificador `.WithRedirectUri`: reemplaza el redirect URI predeterminado.

  ```csharp
  IPublicClientApplication app;
  app = PublicClientApplicationBuilder.Create(client_id)
      .WithAuthority(AzureCloudInstance.AzurePublic, tenant_id)
      .WithRedirectUri("http://localhost")
      .Build();
  ```

#### Modificadores comunes para aplicaciones cliente públicas y confidenciales

La tabla siguiente muestra algunos modificadores que puede establecer en un cliente público o confidencial.

| Modificador                                         | Descripción                                                                                                                                                                                                            |
| --------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| .WithAuthority()                                    | Establece la authority predeterminada de la aplicación en una authority de Microsoft Entra, con la posibilidad de elegir Azure Cloud, audiencia, tenant (tenant ID o nombre de dominio), o proporcionar directamente el URI de authority. |
| .WithTenantId(string tenantId)                      | Reemplaza el tenant ID o la descripción del tenant.                                                                                                                                                                    |
| .WithClientId(string)                               | Reemplaza el client ID.                                                                                                                                                                                                |
| .WithRedirectUri(string redirectUri)                | Reemplaza el redirect URI predeterminado. Esto es útil para escenarios que requieren un broker.                                                                                                                       |
| .WithComponent(string)                              | Establece el nombre de la biblioteca que usa MSAL.NET (por motivos de telemetría).                                                                                                                                    |
| .WithDebugLoggingCallback()                         | Si se invoca, la aplicación llama a Debug.Write para habilitar trazas de depuración.                                                                                                                                  |
| .WithLogging()                                      | Si se invoca, la aplicación llama a un callback con trazas de depuración.                                                                                                                                             |
| .WithTelemetry(TelemetryCallback telemetryCallback) | Establece el delegado usado para enviar telemetría.                                                                                                                                                                    |

#### Modificadores específicos para aplicaciones cliente confidenciales

Los modificadores específicos de un generador de aplicaciones cliente confidencial se pueden encontrar en la clase `ConfidentialClientApplicationBuilder`. Los diferentes métodos se pueden encontrar en la [documentación del SDK de Azure para .NET](https://learn.microsoft.com/es-es/dotnet/api/microsoft.identity.client.confidentialclientapplicationbuilder).

Los modificadores como `.WithCertificate(X509Certificate2 certificate)` y `.WithClientSecret(string clientSecret)` son mutuamente excluyentes. Si proporciona ambos, MSAL lanza una excepción significativa.

---

<!-- ===== Shared Access Signatures ===== -->

# Implementación de firmas de acceso compartido

Una firma de acceso compartido (SAS) es un URI que concede derechos de acceso restringidos a recursos de Azure Storage. Puede proporcionar una firma de acceso compartido a los clientes a los que desea conceder acceso delegado a determinados recursos de la cuenta de almacenamiento.

## Descripción de las firmas de acceso compartido

Una firma de acceso compartido (SAS) es un URI firmado que apunta a uno o varios recursos de almacenamiento e incluye un token que contiene un conjunto especial de parámetros de consulta. El token indica cómo el cliente puede acceder a los recursos. Uno de los parámetros de consulta, la firma, se construye a partir de los parámetros de SAS y se firma con la clave que se usó para crear la SAS. Azure Storage usa esta firma para autorizar el acceso al recurso de almacenamiento.

### Tipos de firmas de acceso compartido

Azure Storage admite tres tipos de firmas de acceso compartido:

- **SAS de delegación de usuario**: Una SAS de delegación de usuario está protegida con credenciales de Microsoft Entra y también por los permisos especificados para la SAS. Una SAS de delegación de usuario se aplica solo a Blob Storage.
- **SAS de servicio**: Una SAS de servicio está protegida con la clave de la cuenta de almacenamiento. Una SAS de servicio delega el acceso a un recurso en los siguientes servicios de Azure Storage: Blob Storage, Queue Storage, Table Storage o Azure Files.
- **SAS de cuenta**: Una SAS de cuenta está protegida con la clave de la cuenta de almacenamiento. Una SAS de cuenta delega el acceso a los recursos en uno o varios de los servicios de almacenamiento. Todas las operaciones disponibles a través de una SAS de servicio o de delegación de usuario también están disponibles a través de una SAS de cuenta.

:information_source: Microsoft recomienda usar las credenciales de Microsoft Entra cuando sea posible como procedimiento recomendado de seguridad, en lugar de usar la clave de cuenta, que puede ser más fácilmente comprometida. Cuando el diseño de la aplicación requiera firmas de acceso compartido para acceder a Blob Storage, use las credenciales de Microsoft Entra para crear una SAS de delegación de usuario cuando sea posible para mayor seguridad.

### Funcionamiento de las firmas de acceso compartido

Cuando usa una SAS para acceder a los datos almacenados en Azure Storage, necesita dos componentes. El primero es un URI al recurso al que desea acceder. La segunda parte es un token de SAS que ha creado para autorizar el acceso a ese recurso.

En un único URI, como `https://medicalrecords.blob.core.windows.net/patient-images/patient-116139-nq8z7f.jpg?sp=r&st=2020-01-20T11:42:32Z&se=2020-01-20T19:42:32Z&spr=https&sv=2019-02-02&sr=b&sig=SrW1HZ5Nb6MbRzTbXCaPm%2BJiSEn15tC91Y4umMPwVZs%3D`, puede separar el URI del token de SAS de la siguiente manera:

- **URI**: `https://medicalrecords.blob.core.windows.net/patient-images/patient-116139-nq8z7f.jpg?`
- **SAS token**: `sp=r&st=2020-01-20T11:42:32Z&se=2020-01-20T19:42:32Z&spr=https&sv=2019-02-02&sr=b&sig=SrW1HZ5Nb6MbRzTbXCaPm%2BJiSEn15tC91Y4umMPwVZs%3D`

El propio token de SAS consta de varios componentes.

| Componente                                           | Descripción                                                                                                                                                                                                    |
| ---------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| sp=r                                                 | Controla los derechos de acceso. Los valores pueden ser: a para agregar, c para crear, d para eliminar, l para enumerar, r para leer o w para escribir. Este ejemplo es de solo lectura. El ejemplo sp=acdlrw concede todos los derechos disponibles. |
| st=2020-01-20T11:42:32Z                              | La fecha y hora en que comienza el acceso.                                                                                                                                                                          |
| se=2020-01-20T19:42:32Z                              | La fecha y hora en que termina el acceso. Este ejemplo concede ocho horas de acceso.                                                                                                                                 |
| sv=2019-02-02                                        | La versión de la API de almacenamiento que se va a usar.                                                                                                                                                                         |
| sr=b                                                 | El tipo de almacenamiento al que se accede. En este ejemplo, b es para blob.                                                                                                                                            |
| sig=SrW1HZ5Nb6MbRzTbXCaPm%2BJiSEn15tC91Y4umMPwVZs%3D | La firma criptográfica.                                                                                                                                                                                   |

### Procedimientos recomendados

Para reducir los posibles riesgos del uso de una SAS, Microsoft proporciona las siguientes instrucciones:

- Para distribuir de forma segura una SAS y evitar ataques de tipo man-in-the-middle, use siempre HTTPS.
- La SAS más segura es una SAS de delegación de usuario. Úsela siempre que sea posible porque elimina la necesidad de almacenar la clave de la cuenta de almacenamiento en el código. Debe usar Microsoft Entra ID para administrar las credenciales. Es posible que esta opción no sea viable para su solución.
- Intente establecer la hora de expiración al valor útil más pequeño. Si una clave de SAS se ve comprometida, solo se puede explotar durante un breve período.
- Aplique la regla de privilegios mínimos requeridos. Conceda solo el acceso que sea necesario. Por ejemplo, en la aplicación, el acceso de solo lectura es suficiente.
- Hay algunas situaciones en las que una SAS no es la solución correcta. Cuando existe un riesgo inaceptable al usar una SAS, cree un servicio de nivel intermedio para administrar los usuarios y su acceso al almacenamiento.

## Cuándo usar firmas de acceso compartido

Use una SAS cuando quiera proporcionar acceso seguro a los recursos de la cuenta de almacenamiento a cualquier cliente que de otro modo no tenga permisos para esos recursos.

Un escenario común en el que una SAS es útil es un servicio donde los usuarios leen y escriben sus propios datos en la cuenta de almacenamiento. En un escenario donde una cuenta de almacenamiento almacena datos de usuario, hay dos patrones de diseño típicos:

- Los clientes cargan y descargan datos a través de un servicio proxy de front-end, que realiza la autenticación. Este servicio proxy de front-end tiene la ventaja de permitir la validación de las reglas de negocio, pero para grandes cantidades de datos o transacciones de alto volumen, crear un servicio que pueda escalar para satisfacer la demanda puede ser costoso o difícil.

  ![Scenario diagram: Front-end proxy service](https://learn.microsoft.com/en-us/training/wwl-azure/implement-shared-access-signatures/media/storage-proxy-service.png)

- Un servicio ligero autentica el cliente según sea necesario y, a continuación, genera una SAS. Una vez que la aplicación cliente recibe la SAS, puede acceder a los recursos de la cuenta de almacenamiento directamente con los permisos definidos por la SAS y durante el intervalo permitido por la SAS. La SAS mitiga la necesidad de enrutar todos los datos a través del servicio proxy de front-end.

  ![Scenario diagram: SAS provider service](https://learn.microsoft.com/en-us/training/wwl-azure/implement-shared-access-signatures/media/storage-provider-service.png)

Muchos servicios del mundo real pueden usar una combinación de estos dos enfoques. Por ejemplo, algunos datos podrían procesarse y validarse a través del proxy de front-end, mientras que otros datos se guardan o leen directamente mediante SAS.

Además, se requiere una SAS para autorizar el acceso al objeto de origen en una operación de copia en ciertos escenarios:

- Al copiar un blob en otro blob que reside en una cuenta de almacenamiento diferente, debe usar una SAS para autorizar el acceso al blob de origen. Opcionalmente, también puede usar una SAS para autorizar el acceso al blob de destino.

- Al copiar un archivo en otro archivo que reside en una cuenta de almacenamiento diferente, debe usar una SAS para autorizar el acceso al archivo de origen. Opcionalmente, también puede usar una SAS para autorizar el acceso al archivo de destino.

- Al copiar un blob en un archivo, o un archivo en un blob, debe usar una SAS para autorizar el acceso al objeto de origen, incluso si los objetos de origen y destino residen en la misma cuenta de almacenamiento.

## Exploración de directivas de acceso almacenadas

Una directiva de acceso almacenada proporciona un nivel adicional de control sobre las firmas de acceso compartido (SAS) de nivel de servicio en el lado del servidor. Establecer una directiva de acceso almacenada agrupa las SAS y proporciona más restricciones para las firmas vinculadas por la directiva. Puede usar una directiva de acceso almacenada para cambiar la hora de inicio, la hora de expiración o los permisos de una firma, o para revocarla después de emitirse.

Los siguientes recursos de almacenamiento admiten directivas de acceso almacenadas:

- Blob containers
- File shares
- Queues
- Tables

### Creación de una directiva de acceso almacenada

La directiva de acceso para una SAS consta de la hora de inicio, la hora de expiración y los permisos de la firma. Puede especificar todos estos parámetros en el URI de la firma y ninguno en la directiva de acceso almacenada; todos en la directiva de acceso almacenada y ninguno en el URI; o alguna combinación de los dos. Sin embargo, no puede especificar un parámetro determinado tanto en el token de SAS como en la directiva de acceso almacenada.

Para crear o modificar una directiva de acceso almacenada, llame a la operación `Set ACL` para el recurso (consulte [Set Container ACL](https://learn.microsoft.com/es-es/rest/api/storageservices/set-container-acl), [Set Queue ACL](https://learn.microsoft.com/es-es/rest/api/storageservices/set-queue-acl), [Set Table ACL](https://learn.microsoft.com/es-es/rest/api/storageservices/set-table-acl) o [Set Share ACL](https://learn.microsoft.com/es-es/rest/api/storageservices/set-share-acl)) con un cuerpo de solicitud que especifique los términos de la directiva de acceso. El cuerpo de la solicitud incluye un identificador firmado único de su elección, de hasta 64 caracteres de longitud, y los parámetros opcionales de la directiva de acceso, de la siguiente manera:

:information_source: Cuando establece una directiva de acceso almacenada en un contenedor, tabla, cola o recurso compartido, puede tardar hasta 30 segundos en surtir efecto. Durante este tiempo, las solicitudes de una SAS asociada a la directiva de acceso almacenada pueden producir un error con el código de estado 403 (Prohibido), hasta que la directiva de acceso se active. Las restricciones del intervalo de entidades de tabla (`startpk`, `startrk`, `endpk` y `endrk`) no se pueden especificar en una directiva de acceso almacenada.

A continuación se muestran ejemplos de creación de una directiva de acceso almacenada con C# .NET y la CLI de Azure.

```csharp
BlobSignedIdentifier identifier = new BlobSignedIdentifier
{
    Id = "stored access policy identifier",
    AccessPolicy = new BlobAccessPolicy
    {
        ExpiresOn = DateTimeOffset.UtcNow.AddHours(1),
        Permissions = "rw"
    }
};

blobContainer.SetAccessPolicy(permissions: new BlobSignedIdentifier[] { identifier });
```

```sh
az storage container policy create \
    --name <stored access policy identifier> \
    --container-name <container name> \
    --start <start time UTC datetime> \
    --expiry <expiry time UTC datetime> \
    --permissions <(a)dd, (c)reate, (d)elete, (l)ist, (r)ead, or (w)rite> \
    --account-key <storage account key> \
    --account-name <storage account name> \
```

### Modificación o revocación de una directiva de acceso almacenada

Para modificar los parámetros de la directiva de acceso almacenada puede llamar a la operación de lista de control de acceso para el tipo de recurso para reemplazar la directiva existente. Por ejemplo, si la directiva existente concede permisos de lectura y escritura a un recurso, puede modificarla para conceder solo permisos de lectura para todas las solicitudes futuras.

Para revocar una directiva de acceso almacenada puede eliminarla, cambiarle el nombre modificando el identificador firmado o cambiar la hora de expiración a un valor en el pasado. Cambiar el identificador firmado rompe las asociaciones entre las firmas existentes y la directiva de acceso almacenada. Cambiar la hora de expiración a un valor en el pasado hace que las firmas asociadas expiren. Eliminar o modificar la directiva de acceso almacenada afecta inmediatamente a todas las SAS asociadas a ella.

Para quitar una sola directiva de acceso, llame a la operación `Set ACL` del recurso, pasando el conjunto de identificadores firmados que desea mantener en el contenedor. Para quitar todas las directivas de acceso del recurso, llame a la operación `Set ACL` con un cuerpo de solicitud vacío.

---

<!-- ===== Microsoft Graph ===== -->

# Microsoft Graph

## Exploración de Microsoft Graph

Use la gran cantidad de datos de Microsoft Graph para crear aplicaciones para organizaciones y consumidores que interactúen con millones de usuarios.

### Descripción de Microsoft Graph

Microsoft Graph es la puerta de enlace a los datos e inteligencia en Microsoft 365. Proporciona un modelo de programación unificado que puede usar para acceder a la enorme cantidad de datos de Microsoft 365, Windows 10 y Enterprise Mobility + Security.

![Microsoft Graph, Microsoft Graph data connect y Microsoft Graph connectors permiten ampliar las experiencias de Microsoft 365 y crear aplicaciones inteligentes.](https://learn.microsoft.com/en-us/training/wwl-azure/microsoft-graph/media/microsoft-graph-data-connectors.png)

En la plataforma de Microsoft 365, tres componentes principales facilitan el acceso y el flujo de datos:

- La API de Microsoft Graph ofrece un único punto de conexión, `https://graph.microsoft.com`. Puede usar las API REST o los SDK para acceder al punto de conexión. Microsoft Graph también incluye servicios que administran la identidad, el acceso, el cumplimiento normativo y la seguridad de usuarios y dispositivos.

- Los [conectores de Microsoft Graph](https://learn.microsoft.com/es-es/microsoftsearch/connectors-overview) trabajan en la dirección entrante, **entregando datos externos a la nube de Microsoft en los servicios y aplicaciones de Microsoft Graph**, para mejorar las experiencias de Microsoft 365 como Microsoft Search. Existen conectores para muchos orígenes de datos de uso común como Box, Google Drive, Jira y Salesforce.

- [Microsoft Graph Data Connect](https://learn.microsoft.com/es-es/graph/overview#access-microsoft-graph-data-at-scale-using-microsoft-graph-data-connect) proporciona un conjunto de herramientas para simplificar la entrega segura y escalable de **datos de Microsoft Graph a almacenes de datos de Azure populares**. Los datos almacenados en caché sirven como orígenes de datos para las herramientas de desarrollo de Azure que puede usar para crear aplicaciones inteligentes.

### Consulta de Microsoft Graph mediante REST

Microsoft Graph es una API web RESTful que permite acceder a recursos del servicio en la nube de Microsoft. Después de registrar la aplicación y obtener tokens de autenticación para un usuario o servicio, puede realizar solicitudes a la API de Microsoft Graph.

La API de Microsoft Graph define la mayoría de sus recursos, métodos y enumeraciones en el espacio de nombres OData, `microsoft.graph`, en los [metadatos de Microsoft Graph](https://learn.microsoft.com/es-es/graph/traverse-the-graph#microsoft-graph-api-metadata). Algunos conjuntos de API se definen en sus sub-espacios de nombres, como la [API de registros de llamadas](https://learn.microsoft.com/es-es/graph/api/resources/callrecords-api-overview) que define recursos como [callRecord](https://learn.microsoft.com/es-es/graph/api/resources/callrecords-callrecord) en `microsoft.graph.callRecords`.

A menos que se especifique explícitamente en el tema correspondiente, se asume que los tipos, métodos y enumeraciones son parte del espacio de nombres `microsoft.graph`.

#### Llamar a un método de la API REST

Para leer o escribir en un recurso como un usuario o un mensaje de correo electrónico, construya una solicitud parecida al siguiente ejemplo:

```http
{HTTP method} https://graph.microsoft.com/{version}/{resource}?{query-parameters}
```

Los componentes de una solicitud incluyen:

- `{HTTP method}` - El método HTTP usado en la solicitud a Microsoft Graph.
- `{version}` - La versión de la API de Microsoft Graph que usa la aplicación.
- `{resource}` - El recurso de Microsoft Graph al que hace referencia.
- `{query-parameters}` - Opciones de consulta de OData opcionales o parámetros del método REST que personalizan la respuesta.

Después de realizar una solicitud, se devuelve una respuesta que incluye:

- Código de estado - Un código de estado HTTP que indica éxito o error.
- Mensaje de respuesta - Los datos solicitados o el resultado de la operación. El mensaje de respuesta puede estar vacío para algunas operaciones.
- `nextLink` - Si la solicitud devuelve muchos datos, debe paginarlos usando la URL devuelta en `@odata.nextLink`.

#### Métodos HTTP

Microsoft Graph usa el método HTTP de la solicitud para determinar qué hace la solicitud. La API admite los siguientes métodos.

| Método | Descripción                                  |
| ------ | -------------------------------------------- |
| GET    | Leer datos de un recurso.                   |
| POST   | Crear un nuevo recurso o realizar una acción. |
| PATCH  | Actualizar un recurso con nuevos valores.           |
| PUT    | Reemplazar un recurso por uno nuevo.           |
| DELETE | Quitar un recurso.                           |

- Para los métodos CRUD `GET` y `DELETE`, no se requiere ningún cuerpo de solicitud.
- Los métodos `POST`, `PATCH` y `PUT` requieren un cuerpo de solicitud especificado en formato JSON que contiene información adicional, como los valores de las propiedades del recurso.

#### Versión

Microsoft Graph actualmente admite dos versiones: `v1.0` y `beta`.

- `v1.0` incluye las API de disponibilidad general. Use la versión v1.0 para todas las aplicaciones de producción.
- `beta` incluye las API que están actualmente en versión preliminar. Dado que es posible que se introduzcan cambios importantes en las API beta, se recomienda usar la versión beta solo para probar aplicaciones en desarrollo; no use las API beta en las aplicaciones de producción.

#### Recurso

Un recurso puede ser una entidad o un tipo complejo, normalmente definido con propiedades. Las entidades se diferencian de los tipos complejos en que siempre incluyen una propiedad **id**.

La URL incluye el recurso con el que interactúa en la solicitud, como `me`, **user**, **group**, **drive** y **site**. A menudo, los recursos de nivel superior también incluyen _relaciones_, que puede usar para acceder a otros recursos, como `me/messages` o `me/drive`. También puede interactuar con los recursos usando _métodos_; por ejemplo, para enviar un correo electrónico, use `me/sendMail`.

Cada recurso puede requerir permisos diferentes para acceder a él. A menudo se necesita un nivel de permisos más alto para crear o actualizar un recurso que para leerlo. Para obtener información detallada sobre los permisos necesarios, consulte el tema de referencia del método.

#### Parámetros de consulta

Los parámetros de consulta pueden ser opciones de consulta del sistema OData u otras cadenas que un método acepta para personalizar su respuesta.

Puede usar opciones de consulta del sistema OData opcionales para incluir más o menos propiedades que la respuesta predeterminada. Puede filtrar la respuesta para los elementos que coincidan con una consulta personalizada o proporcionar otros parámetros para un método.

Por ejemplo, agregar el siguiente parámetro `filter` restringe los mensajes devueltos con la propiedad `emailAddress` de `jon@contoso.com`.

```http
GET https://graph.microsoft.com/v1.0/me/messages?filter=emailAddress eq 'jon@contoso.com'
```

#### Otros recursos

A continuación hay enlaces a algunas herramientas que puede usar para construir y probar solicitudes usando las API de Microsoft Graph.

- [Graph Explorer](https://developer.microsoft.com/graph/graph-explorer)
- [Postman](https://www.getpostman.com/)

### Consulta de Microsoft Graph mediante SDK

Los SDK de Microsoft Graph están diseñados para simplificar la creación de aplicaciones de alta calidad, eficientes y resistentes que acceden a Microsoft Graph. Los SDK incluyen dos componentes: una biblioteca de servicios y una biblioteca central.

La biblioteca de servicios contiene modelos y constructores de solicitudes que se generan a partir de metadatos de Microsoft Graph para proporcionar una experiencia uniforme y descubrible.

La biblioteca principal proporciona un conjunto de características que mejoran el trabajo con todos los servicios de Microsoft Graph. La compatibilidad integrada con el manejo de reintentos, redirecciones seguras, autenticación transparente y compresión de carga útil mejora la calidad de las interacciones de su aplicación con Microsoft Graph, sin complejidad adicional y manteniendo el control total. La biblioteca principal también proporciona compatibilidad para tareas comunes como paginar colecciones y crear solicitudes por lotes.

En esta sección, aprenderá sobre los SDK disponibles y verá algunos ejemplos de código de algunas de las operaciones más comunes.

:information_source: Los ejemplos de código de esta unidad se basan en la versión 5.65 del SDK de Microsoft Graph para .NET.

#### Instalar el SDK de Microsoft Graph para .NET

El SDK de .NET de Microsoft Graph se incluye en los siguientes paquetes NuGet:

- [Microsoft.Graph](https://github.com/microsoftgraph/msgraph-sdk-dotnet) - Contiene los modelos y constructores de solicitudes para acceder al punto de conexión `v1.0` con la fluent API. Microsoft.Graph tiene una dependencia de Microsoft.Graph.Core.
- [Microsoft.Graph.Beta](https://github.com/microsoftgraph/msgraph-beta-sdk-dotnet) - Contiene los modelos y constructores de solicitudes para acceder al punto de conexión `beta` con la fluent API. Microsoft.Graph.Beta tiene una dependencia de Microsoft.Graph.Core.
- [Microsoft.Graph.Core](https://github.com/microsoftgraph/msgraph-sdk-dotnet) - La biblioteca principal para realizar llamadas a Microsoft Graph.

#### Crear un cliente de Microsoft Graph

El cliente de Microsoft Graph está diseñado para simplificar las llamadas a Microsoft Graph. Puede usar una sola instancia de cliente durante la vida de la aplicación. A continuación se muestran ejemplos de código de cómo crear una instancia de cliente de Microsoft Graph. El proveedor de autenticación se encarga de adquirir tokens de acceso para la aplicación. Los distintos proveedores de aplicación admiten distintos escenarios de cliente. Para detalles sobre qué proveedor y opciones son adecuados para su escenario, consulte [Choose an Authentication Provider](https://learn.microsoft.com/en-us/graph/sdks/choose-authentication-providers).

```csharp
var scopes = new[] { "User.Read" };

// Las apps multiinquilino pueden usar "common"
// Las apps de inquilino único deben usar el tenant ID de Azure Portal
var tenantId = "common";

// Valor del registro de la aplicación
var clientId = "YOUR_CLIENT_ID";

// using Azure.Identity;
var options = new TokenCredentialOptions
{
    AuthorityHost = AzureAuthorityHosts.AzurePublicCloud
};

// Función de callback que recibe el aviso para el usuario
// El aviso contiene el código de dispositivo generado que debe
// introducir durante el proceso de autenticación en el navegador
Func<DeviceCodeInfo, CancellationToken, Task> callback = (code, cancellation) => {
    Console.WriteLine(code.Message);
    return Task.FromResult(0);
};

// https://learn.microsoft.com/dotnet/api/azure.identity.devicecodecredential
var deviceCodeCredential = new DeviceCodeCredential(
    callback, tenantId, clientId, options);

var graphClient = new GraphServiceClient(deviceCodeCredential, scopes);
```

#### Leer información de Microsoft Graph

Para leer información de Microsoft Graph, primero debe crear un objeto de solicitud y luego ejecutar el método `GET` en la solicitud.

```csharp
// GET https://graph.microsoft.com/v1.0/me

var user = await graphClient.Me
    .Request()
    .GetAsync();
```

#### Recuperar una lista de entidades

Recuperar una lista de entidades es similar a recuperar una sola entidad, excepto que existen otras opciones para configurar la solicitud. El parámetro de consulta `$filter` puede usarse para reducir el conjunto de resultados solo a las filas que coincidan con la condición proporcionada. El parámetro de consulta `$orderBy` solicita que el servidor devuelva la lista de entidades ordenada por las propiedades especificadas.

```csharp
// GET https://graph.microsoft.com/v1.0/me/messages?
// $select=subject,sender&$filter=subject eq 'Hello world'
var messages = await graphClient.Me.Messages
    .GetAsync(requestConfig =>
    {
        requestConfig.QueryParameters.Select =
            ["subject", "sender"];
        requestConfig.QueryParameters.Filter =
            "subject eq 'Hello world'";
    });
```

#### Eliminar una entidad

Las solicitudes de eliminación se construyen de la misma manera que las solicitudes para recuperar una entidad, pero utilizan una solicitud `DELETE` en lugar de una `GET`.

```csharp
// DELETE https://graph.microsoft.com/v1.0/me/messages/{message-id}
// messageId es una cadena que contiene la propiedad id del mensaje
await graphClient.Me.Messages[messageId]
    .DeleteAsync();
```

#### Crear una nueva entidad

Para SDK de estilo fluido y basado en plantillas, los nuevos elementos pueden agregarse a colecciones con un método `POST`.

```csharp
// POST https://graph.microsoft.com/v1.0/me/calendars
var calendar = new Calendar
{
    Name = "Volunteer",
};

var newCalendar = await graphClient.Me.Calendars
    .PostAsync(calendar);
```

#### Otros recursos

- [Microsoft Graph REST API v1.0 reference](https://learn.microsoft.com/en-us/graph/api/overview)

### Aplicación de procedimientos recomendados en Microsoft Graph

Esta sección describe los procedimientos recomendados que puede aplicar para ayudar a las aplicaciones a sacar el máximo partido de Microsoft Graph y hacer que la aplicación sea más confiable para los usuarios finales.

#### Autenticación

Para acceder a los datos en Microsoft Graph, su aplicación necesita adquirir un token de acceso OAuth 2.0 y presentarlo a Microsoft Graph en uno de los siguientes métodos:

- El encabezado de solicitud HTTP _Autorización_, como un token _Bearer_
- El constructor del cliente de gráfico, cuando usa una biblioteca cliente de Microsoft Graph

Use la API de la Biblioteca de autenticación de Microsoft, [MSAL](https://learn.microsoft.com/es-es/azure/active-directory/develop/active-directory-v2-libraries) para adquirir el token de acceso a Microsoft Graph.

#### Consentimiento y autorización

Aplique las siguientes mejoras prácticas para consentimiento y autorización en su aplicación:

- **Use el principio de mínimo privilegio**. Solicite solo los permisos necesarios y únicamente cuando los necesite. Para las API que llama su aplicación, revise la sección de permisos en los temas del método. Por ejemplo, consulte [creating a user](https://learn.microsoft.com/en-us/graph/api/user-post-users) y elija los permisos menos privilegiados.
- **Use el tipo correcto de permiso según el escenario**. Si está creando una aplicación interactiva con un usuario autenticado, su aplicación debe usar permisos delegados. Si, en cambio, su aplicación se ejecuta sin un usuario autenticado, como un servicio en segundo plano o daemon, debe usar permisos de aplicación.

  :stop_sign: Usar permisos de aplicación en escenarios interactivos puede poner su aplicación en riesgo de cumplimiento y seguridad. Asegúrese de comprobar los privilegios del usuario para garantizar que no tenga acceso no deseado a la información ni esté eludiendo directivas configuradas por un administrador.

- **Considere la experiencia del usuario final y del administrador**. Esto afectará directamente ambas experiencias. Por ejemplo:

  - Considere quién da consentimiento a su aplicación, ya sean usuarios finales o administradores, y configure su aplicación para [solicitar permisos de forma adecuada](https://learn.microsoft.com/en-us/azure/active-directory/develop/v2-permissions-and-consent).
  - Asegúrese de comprender la diferencia entre [consentimiento estático, dinámico e incremental](https://learn.microsoft.com/en-us/azure/active-directory/develop/v2-permissions-and-consent#consent-types).

- **Considere aplicaciones multiinquilino**. Espere que los clientes tengan distintos controles de aplicación y consentimiento en diferentes estados. Por ejemplo:

  - Los administradores del tenant pueden deshabilitar la capacidad de los usuarios finales para dar consentimiento a aplicaciones. En este caso, un administrador tendría que dar consentimiento en nombre de sus usuarios.
  - Los administradores del tenant pueden establecer directivas personalizadas de autorización, como bloquear que los usuarios lean perfiles de otros usuarios o limitar la creación de grupos de autoservicio a un conjunto reducido de usuarios. En este caso, su aplicación debe estar preparada para gestionar una respuesta de error 403 al actuar en nombre de un usuario.

#### Manejar respuestas de manera efectiva

Dependiendo de las solicitudes que haga a Microsoft Graph, sus aplicaciones deben estar preparadas para gestionar distintos tipos de respuestas. A continuación se muestran algunas de las prácticas más importantes para asegurar que su aplicación se comporte de forma fiable y predecible para los usuarios finales. Por ejemplo:

- **Paginación**: Al consultar colecciones de recursos, debe esperar que Microsoft Graph devuelva el conjunto de resultados en varias páginas debido a límites de tamaño de página del lado servidor. Su aplicación siempre debe contemplar que las respuestas estén paginadas y usar la propiedad `@odata.nextLink` para obtener el siguiente conjunto paginado de resultados hasta leer todas las páginas. La página final no contendrá la propiedad `@odata.nextLink`. Para más información, consulte [paging](https://learn.microsoft.com/en-us/graph/paging).
- **Enumeraciones evolutivas**: Agregar miembros a enumeraciones existentes puede romper aplicaciones que ya usan esos enum. Los enum evolutivos son un mecanismo que usa Microsoft Graph API para agregar nuevos miembros a enumeraciones existentes sin provocar cambios incompatibles para las aplicaciones. De forma predeterminada, una operación GET devuelve solo los miembros conocidos de propiedades con tipos enum evolutivos y su aplicación necesita manejar solo esos miembros conocidos. Si diseña su aplicación para manejar también miembros desconocidos, puede habilitar su recepción mediante el encabezado de solicitud HTTP `Prefer`.

#### Almacenamiento local de datos

Su aplicación idealmente debe hacer llamadas a Microsoft Graph para recuperar datos en tiempo real según sea necesario. Solo debe almacenar en caché o almacenar localmente datos necesarios para un escenario específico. Si ese caso de uso está cubierto por sus términos de uso y política de privacidad, y no viola los [Términos de uso de las API de Microsoft](https://learn.microsoft.com/es-es/legal/microsoft-apis/terms-of-use?context=/graph/context), su aplicación también debe implementar políticas adecuadas de retención y eliminación.

---

<!-- ===== Azure Key Vault ===== -->

# Azure Key Vault

## Implementación de Azure Key Vault

Azure Key Vault es un servicio en la nube para almacenar y acceder de forma segura a secretos. Un secreto es cualquier elemento al que desee controlar rigurosamente el acceso, como claves de API, contraseñas, certificados o claves criptográficas.

### Exploración de Azure Key Vault

El servicio Azure Key Vault admite dos tipos de contenedores: almacenes y grupos de módulos de seguridad de hardware (HSM) administrados. Los almacenes admiten el almacenamiento de claves, secretos y certificados respaldados por software y HSM. Los grupos de HSM administrados solo admiten claves respaldadas por HSM.

Azure Key Vault ayuda a resolver los siguientes problemas:

- **Administración de secretos**: Azure Key Vault puede usarse para almacenar de forma segura y controlar rigurosamente el acceso a tokens, contraseñas, certificados, claves de API y otros secretos.

- **Administración de claves**: Azure Key Vault también puede usarse como solución de administración de claves. Facilita la creación y el control de las claves de cifrado usadas para cifrar los datos.

- **Administración de certificados**: Azure Key Vault también es un servicio que permite aprovisionar, administrar e implementar fácilmente certificados SSL/TLS públicos y privados para usarlos con Azure y los recursos internos conectados.

Azure Key Vault tiene dos niveles de servicio: Estándar, que cifra con una clave de software, y Premium, que incluye claves protegidas por módulo de seguridad de hardware (HSM). Para ver una comparación entre los niveles Estándar y Premium, consulte la [página de precios de Azure Key Vault](https://azure.microsoft.com/pricing/details/key-vault/).

#### Principales ventajas de usar Azure Key Vault

- **Secretos de aplicación centralizados**: Centralizar el almacenamiento de secretos de aplicación en Azure Key Vault le permite controlar su distribución. Por ejemplo, en lugar de almacenar la cadena de conexión en el código de la aplicación, puede almacenarla de forma segura en Key Vault. Sus aplicaciones pueden acceder de forma segura a la información que necesitan mediante URI. Estos URI permiten que las aplicaciones recuperen versiones específicas de un secreto.
- **Almacenar secretos y claves de forma segura**: El acceso a un almacén de claves requiere autenticación y autorización adecuadas antes de que un llamador (usuario o aplicación) pueda obtener acceso. La autenticación se realiza mediante Microsoft Entra ID. La autorización puede realizarse mediante Azure role-based access control (Azure RBAC) o mediante una directiva de acceso de Key Vault. Azure RBAC puede usarse tanto para administrar los almacenes como para acceder a los datos almacenados en un almacén, mientras que la directiva de acceso de Key Vault solo puede usarse al intentar acceder a datos almacenados en un almacén. Los Azure Key Vault pueden estar protegidos por software o, con el nivel Azure Key Vault Premium, protegidos por hardware security modules (HSMs).
- **Supervisar el acceso y el uso**: Puede supervisar la actividad habilitando el registro para sus almacenes. Tiene control sobre los registros y puede protegerlos restringiendo el acceso; también puede eliminar los registros que ya no necesita. Azure Key Vault puede configurarse para:

  - Archivar en una cuenta de almacenamiento.
  - Transmitir a un Event Hub.
  - Enviar los registros a Azure Monitor logs.

- **Administración simplificada de secretos de aplicación**: La información de seguridad debe protegerse, debe seguir un ciclo de vida y debe estar altamente disponible. Azure Key Vault simplifica el proceso para cumplir estos requisitos mediante:

  - Eliminar la necesidad de conocimiento interno de Hardware Security Modules.
  - Escalar con poca antelación para satisfacer los picos de uso de su organización.
  - Replicar el contenido de su Key Vault dentro de una región y hacia una región secundaria. La replicación de datos garantiza alta disponibilidad y elimina la necesidad de que el administrador realice acciones para desencadenar la conmutación por error.
  - Proporcionar opciones estándar de administración de Azure mediante el portal, Azure CLI y PowerShell.
  - Automatizar ciertas tareas de certificados que compra a entidades de certificación públicas (CA), como la inscripción y la renovación.

### Descripción de los procedimientos recomendados de Azure Key Vault

Azure Key Vault es una herramienta para almacenar y acceder de forma segura a secretos. Un secreto es cualquier elemento al que desee controlar rigurosamente el acceso, como claves de API, contraseñas o certificados. Un almacén es un grupo lógico de secretos.

#### Autenticación

Para realizar cualquier operación con Key Vault, primero debe autenticarse. Hay tres formas de autenticarse en Key Vault:

- **Managed identities for Azure resources**: Cuando implementa una aplicación en una máquina virtual de Azure, puede asignar una identidad a la máquina virtual que tenga acceso a Key Vault. También puede asignar identidades a otros recursos de Azure. La ventaja de este enfoque es que la aplicación o el servicio no administra la rotación del primer secreto. Azure rota automáticamente el secreto de cliente de la entidad de servicio asociado con la identidad. Recomendamos este enfoque como procedimiento recomendado.
- **Entidad de servicio y certificado**: Puede usar una entidad de servicio y un certificado asociado que tenga acceso a Key Vault. No recomendamos este enfoque porque el propietario de la aplicación o el desarrollador debe rotar el certificado.
- **Entidad de servicio y secreto**: Aunque puede usar una entidad de servicio y un secreto para autenticarse en Key Vault, no lo recomendamos. Es difícil rotar automáticamente el secreto de arranque que se usa para autenticarse en Key Vault.

#### Cifrado de datos en tránsito

Azure Key Vault aplica el protocolo Transport Layer Security (TLS) para proteger los datos cuando viajan entre Azure Key Vault y los clientes. Los clientes negocian una conexión TLS con Azure Key Vault. TLS proporciona autenticación sólida, privacidad e integridad de mensajes (permitiendo detectar manipulación, interceptación y falsificación de mensajes), interoperabilidad, flexibilidad de algoritmos y facilidad de implementación y uso.

Perfect Forward Secrecy (PFS) protege las conexiones entre los sistemas cliente de los clientes y los servicios en la nube de Microsoft mediante claves únicas. Las conexiones también usan longitudes de clave de cifrado de 2,048 bits basadas en RSA. Esta combinación dificulta que alguien intercepte y acceda a los datos en tránsito.

#### Procedimientos recomendados de Azure Key Vault

- **Usar almacenes de claves independientes**: Se recomienda usar un almacén por aplicación y por entorno (Desarrollo, Preproducción y Producción). Este patrón le ayuda a no compartir secretos entre entornos y también reduce el riesgo si se produce una vulneración.
- **Controlar el acceso al almacén**: Los datos de Key Vault son confidenciales y críticos para el negocio; debe proteger el acceso a los almacenes de claves permitiendo solo aplicaciones y usuarios autorizados.
- **Copia de seguridad**: Cree copias de seguridad periódicas del almacén al actualizar, eliminar o crear objetos dentro de él.
- **Registro**: Asegúrese de activar el registro y las alertas.
- **Opciones de recuperación**: Active [soft-delete](https://learn.microsoft.com/en-us/azure/key-vault/general/soft-delete-overview) y la protección contra purga si desea protegerse contra la eliminación forzada del secreto.

### Autenticación en Azure Key Vault

La autenticación con Key Vault funciona con Microsoft Entra ID, que es responsable de autenticar la identidad de cualquier entidad de seguridad.

Para las aplicaciones, hay dos formas de obtener una entidad de servicio:

- Habilitar una **managed identity** asignada por el sistema para la aplicación. Con managed identity, Azure administra internamente la entidad de servicio de la aplicación y autentica automáticamente la aplicación con otros servicios de Azure. Managed identity está disponible para aplicaciones implementadas en varios servicios.
- Si no puede usar identidad administrada, registre la aplicación en su tenant de Microsoft Entra. El registro también crea un segundo objeto de aplicación que identifica la aplicación en todos los tenants.

:information_source: Se recomienda usar una identidad administrada asignada por el sistema.

A continuación se muestra información sobre cómo autenticarse en Key Vault sin usar una identidad administrada.

#### Autenticación en Key Vault desde el código de la aplicación

El SDK de Key Vault utiliza la biblioteca cliente de Azure Identity, lo que permite una autenticación uniforme en Key Vault en todos los entornos con el mismo código. La tabla siguiente proporciona información sobre las bibliotecas cliente de Azure Identity:

| .NET                                                                                                   | Python                                                                                                   | Java                                                                                                 | JavaScript                                                                                                       |
| ------------------------------------------------------------------------------------------------------ | -------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------- |
| [Azure Identity SDK .NET](https://learn.microsoft.com/en-us/dotnet/api/overview/azure/identity-readme) | [Azure Identity SDK Python](https://learn.microsoft.com/en-us/python/api/overview/azure/identity-readme) | [Azure Identity SDK Java](https://learn.microsoft.com/en-us/java/api/overview/azure/identity-readme) | [Azure Identity SDK JavaScript](https://learn.microsoft.com/en-us/javascript/api/overview/azure/identity-readme) |

#### Autenticación en Key Vault con REST

Los tokens de acceso deben enviarse al servicio mediante el encabezado HTTP de autorización:

```http
PUT /keys/MYKEY?api-version=<api_version>  HTTP/1.1
Authorization: Bearer <access_token>
```

Cuando no se proporciona un token de acceso, o cuando el servicio no acepta un token, se devuelve un error `HTTP 401` al cliente e incluirá el encabezado `WWW-Authenticate`, por ejemplo:

```http
401 Not Authorized
WWW-Authenticate: Bearer authorization="…", resource="…"
```

Los parámetros del encabezado `WWW-Authenticate` son:

- authorization: Dirección del servicio de autorización OAuth2 que puede usarse para obtener un token de acceso para la solicitud.
- resource: Nombre del recurso (`https://vault.azure.net`) que se usa en la solicitud de autorización.

Otros recursos

- [Azure Key Vault developer's guide](https://learn.microsoft.com/en-us/azure/key-vault/general/developers-guide)
- [Azure Key Vault availability and redundancy](https://learn.microsoft.com/en-us/azure/key-vault/general/disaster-recovery-guidance)

---

<!-- ===== Managed Identities ===== -->

# Identidades administradas

## Implementación de identidades administradas

Un desafío común para los desarrolladores es la administración de secretos y credenciales que se usan para proteger la comunicación entre los diferentes componentes que conforman una solución. Las identidades administradas eliminan la necesidad de que los desarrolladores administren credenciales.

### Exploración de las identidades administradas

Si bien los desarrolladores pueden almacenar los secretos de forma segura en Azure Key Vault, los servicios necesitan una forma de acceder a Azure Key Vault. Las identidades administradas proporcionan una identidad administrada automáticamente en Microsoft Entra ID para que las aplicaciones la usen al conectarse a recursos que admiten la autenticación de Microsoft Entra. Las aplicaciones pueden usar identidades administradas para obtener tokens de Microsoft Entra sin tener que administrar ninguna credencial.

#### Tipos de identidades administradas

Hay dos tipos de identidades administradas:

- Una **identidad administrada asignada por el sistema** se habilita directamente en una instancia de servicio de Azure. Cuando se habilita la identidad, Azure crea una identidad para la instancia en el inquilino de Microsoft Entra de confianza para la suscripción de la instancia. Después de crear la identidad, las credenciales se aprovisionan en la instancia. El ciclo de vida de una identidad asignada por el sistema está directamente vinculado a la instancia de servicio de Azure en la que se habilita. Si se elimina la instancia, Azure limpia automáticamente las credenciales y la identidad en Microsoft Entra ID.
- Una **identidad administrada asignada por el usuario** se crea como un recurso independiente de Azure. Mediante un proceso de creación, Azure crea una identidad en el inquilino de Microsoft Entra de confianza para la suscripción en uso. Después de crear la identidad, puede asignarse a una o más instancias de servicio de Azure. El ciclo de vida de una identidad asignada por el usuario se administra por separado del ciclo de vida de las instancias de servicio de Azure a las que se asigna.

Internamente, las identidades administradas son entidades de servicio de un tipo especial, bloqueadas para usarse solo con recursos de Azure. Cuando se elimina la identidad administrada, la entidad de servicio correspondiente se elimina automáticamente.

#### Características de las identidades administradas

A continuación, la tabla destaca algunas de las diferencias clave entre los dos tipos de identidades administradas.

| Propiedad                      | Identidad administrada asignada por el sistema                                                                                                                    | Identidad administrada asignada por el usuario                                                               |
| ------------------------------ | ----------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- |
| Creación                       | Se crea como parte de un recurso de Azure (por ejemplo, una máquina virtual de Azure o Azure App Service)                                                        | Se crea como un recurso de Azure independiente                                                               |
| Ciclo de vida                  | Comparte el ciclo de vida con el recurso de Azure con el que se crea la identidad administrada. Cuando se elimina el recurso principal, también se elimina la identidad administrada. | Ciclo de vida independiente. Debe eliminarse explícitamente.                                                |
| Uso compartido entre recursos de Azure | No se puede compartir; solo puede asociarse con un único recurso de Azure.                                                                                      | Se puede compartir. La misma identidad administrada asignada por el usuario puede asociarse a más de un recurso de Azure. |

A continuación hay casos de uso comunes para identidades administradas:

- Identidad administrada asignada por el sistema

  - Cargas de trabajo contenidas dentro de un solo recurso de Azure.
  - Cargas de trabajo que necesitan identidades independientes.
  - Por ejemplo, una aplicación que se ejecuta en una sola máquina virtual.

- Identidad administrada asignada por el usuario

  - Cargas de trabajo que se ejecutan en múltiples recursos y pueden compartir una sola identidad.
  - Cargas de trabajo que necesitan preautorización para un recurso seguro, como parte de un flujo de aprovisionamiento.
  - Cargas de trabajo donde los recursos se reciclan frecuentemente, pero los permisos deben mantenerse consistentes.
  - Por ejemplo, una carga de trabajo donde múltiples máquinas virtuales necesitan acceder al mismo recurso.

#### Cuándo usar identidades administradas

La siguiente imagen proporciona una descripción general de los escenarios que admiten el uso de identidades administradas. Por ejemplo, puede usar identidades administradas si desea construir una aplicación utilizando Azure App Services que acceda a Azure Storage sin tener que administrar credenciales.

![Imagen que muestra una lista de orígenes que obtienen acceso a destinos a través de Microsoft Entra ID.](https://learn.microsoft.com/en-us/training/wwl-azure/implement-managed-identities/media/managed-identities-use-case.png)

#### ¿Qué servicios de Azure admiten identidades administradas?

Managed identities for Azure resources se puede usar para autenticar en servicios que admiten autenticación de Microsoft Entra. Para obtener una lista de servicios de Azure que admiten esta característica, visite [Services that support managed identities for Azure resources](https://learn.microsoft.com/en-us/azure/active-directory/managed-identities-azure-resources/services-support-msi).

El resto de este módulo usa máquinas virtuales de Azure en los ejemplos, pero los mismos conceptos y acciones similares pueden aplicarse a cualquier recurso de Azure que admita autenticación de Microsoft Entra.

### Descripción del flujo de autenticación de las identidades administradas

En esta sección, aprenderá cómo funcionan las identidades administradas con máquinas virtuales de Azure. A continuación se muestran los flujos que detallan cómo funcionan los dos tipos de identidades administradas con una máquina virtual de Azure.

#### Cómo funciona una identidad administrada asignada por el sistema con una máquina virtual de Azure

1. Azure Resource Manager recibe una solicitud para habilitar la identidad administrada asignada por el sistema en una máquina virtual.

1. Azure Resource Manager crea una entidad de servicio en Microsoft Entra ID para la identidad de la máquina virtual. La entidad de servicio se crea en el inquilino de Microsoft Entra en el que confía la suscripción.

1. Azure Resource Manager configura la identidad en la máquina virtual actualizando el punto de conexión de identidad del Azure Instance Metadata Service con el identificador de cliente y el certificado de la entidad de servicio.

1. Después de que la máquina virtual tenga una identidad, use la información de la entidad de servicio para conceder a la máquina virtual acceso a recursos de Azure. Para llamar a Azure Resource Manager, use role-based access control en Microsoft Entra ID para asignar el rol adecuado a la entidad de servicio de la máquina virtual. Para llamar a Key Vault, conceda al código acceso al secreto o clave específicos en Key Vault.

1. El código que se ejecuta en la máquina virtual puede solicitar un token al punto de conexión del servicio de metadatos de instancia de Azure, accesible solo desde dentro de la máquina virtual: `http://169.254.169.254/metadata/identity/oauth2/token`

1. Se realiza una llamada a Microsoft Entra ID para solicitar un token de acceso (como se especifica en el paso 5) usando el identificador de cliente y el certificado configurados en el paso 3. Microsoft Entra ID devuelve un token de acceso JSON Web Token (JWT).

1. El código envía el token de acceso en una llamada a un servicio que admite la autenticación de Microsoft Entra.

#### Cómo funciona una identidad administrada asignada por el usuario con una máquina virtual de Azure

1. Azure Resource Manager recibe una solicitud para crear una identidad administrada asignada por el usuario.

1. Azure Resource Manager crea una entidad de servicio en Microsoft Entra ID para la identidad administrada asignada por el usuario. La entidad de servicio se crea en el inquilino de Microsoft Entra en el que confía la suscripción.

1. Azure Resource Manager recibe una solicitud para configurar la identidad administrada asignada por el usuario en una máquina virtual y actualiza el punto de conexión de identidad del Servicio de metadatos de instancia de Azure con el identificador de cliente de la entidad de servicio de la identidad administrada asignada por el usuario y el certificado.

1. Después de crear la identidad administrada asignada por el usuario, use la información de la entidad de servicio para conceder a la identidad acceso a los recursos de Azure. Para llamar a Azure Resource Manager, use el control de acceso basado en roles en Microsoft Entra ID para asignar el rol adecuado a la entidad de servicio de la identidad asignada por el usuario. Para llamar a Key Vault, conceda al código acceso al secreto o clave específicos en Key Vault.

   :information_source: También puede realizar este paso antes del paso 3.

1. El código que se ejecuta en la máquina virtual puede solicitar un token al punto de conexión de identidad del Servicio de metadatos de instancia de Azure, accesible solo desde dentro de la máquina virtual: `http://169.254.169.254/metadata/identity/oauth2/token`

1. Se realiza una llamada a Microsoft Entra ID para solicitar un token de acceso (como se especifica en el paso 5) usando el identificador de cliente y el certificado configurados en el paso 3. Microsoft Entra ID devuelve un token de acceso JSON Web Token (JWT).

1. El código envía el token de acceso en una llamada a un servicio que admite la autenticación de Microsoft Entra.

### Configuración de las identidades administradas

Puede configurar una máquina virtual de Azure con una identidad administrada durante la creación de la máquina virtual o después. En esta unidad se usan ejemplos de CLI que muestran los comandos para las identidades asignadas por el sistema y por el usuario.

#### Identidad administrada asignada por el sistema

Para crear o habilitar una máquina virtual de Azure con la identidad administrada asignada por el sistema, la cuenta necesita la asignación del rol **Colaborador de máquina virtual**. No se requieren otras asignaciones de roles de directorio de Microsoft Entra.

##### Habilitar la identidad administrada asignada por el sistema durante la creación de una máquina virtual de Azure

El siguiente ejemplo crea una máquina virtual llamada myVM con una identidad administrada asignada por el sistema, según lo solicitado por el parámetro `--assign-identity`, con el `--role` y el `--scope` especificados. Los parámetros `--admin-username` y `--admin-password` especifican el nombre de usuario y la contraseña de la cuenta de administrador para el inicio de sesión en la máquina virtual. Actualice estos valores según corresponda para su entorno:

```sh
az vm create --resource-group myResourceGroup \
    --name myVM --image win2016datacenter \
    --generate-ssh-keys \
    --assign-identity \
    --role contributor \
    --scope mySubscription \
    --admin-username azureuser \
    --admin-password myPassword12
```

##### Habilitar la identidad administrada asignada por el sistema en una máquina virtual de Azure existente

Use el comando `az vm identity assign` para asignar la identidad asignada por el sistema a una máquina virtual existente:

```sh
az vm identity assign -g myResourceGroup -n myVm
```

#### Identidad administrada asignada por el usuario

Para asignar una identidad asignada por el usuario a una máquina virtual durante su creación, la cuenta necesita las asignaciones de los roles **Colaborador de máquina virtual** y **Operador de identidad administrada**. No se requieren otras asignaciones de roles de directorio de Microsoft Entra.

Habilitar las identidades administradas asignadas por el usuario es un proceso de dos pasos:

1. Crear la identidad asignada por el usuario
1. Asignar la identidad a una máquina virtual

##### Crear una identidad asignada por el usuario

Cree una identidad administrada asignada por el usuario con `az identity create`. El parámetro `-g` especifica el grupo de recursos donde se crea la identidad administrada asignada por el usuario, y el parámetro `-n` especifica su nombre.

```sh
az identity create -g myResourceGroup -n myUserAssignedIdentity
```

##### Asignar una identidad administrada asignada por el usuario durante la creación de una máquina virtual de Azure

El siguiente ejemplo crea una máquina virtual asociada a la nueva identidad asignada por el usuario, según lo especificado por el parámetro `--assign-identity`, con el `--role` y el `--scope` dados.

```sh
az vm create \
--resource-group <RESOURCE GROUP> \
--name <VM NAME> \
--image UbuntuLTS \
--admin-username <USER NAME> \
--admin-password <PASSWORD> \
--assign-identity <USER ASSIGNED IDENTITY NAME> \
--role <ROLE> \
--scope <SUBSCRIPTION>
```

##### Asignar una identidad administrada asignada por el usuario a una máquina virtual de Azure existente

Asigne la identidad asignada por el usuario a la máquina virtual con `az vm identity assign`.

```sh
az vm identity assign \
    -g <RESOURCE GROUP> \
    -n <VM NAME> \
    --identities <USER ASSIGNED IDENTITY>
```

#### SDK de Azure con compatibilidad para identidades administradas de recursos de Azure

Azure admite varias plataformas de programación a través de una serie de [SDK de Azure](https://azure.microsoft.com/downloads). Varios de ellos se han actualizado para admitir identidades administradas para los recursos de Azure y proporcionan ejemplos correspondientes para demostrar el uso.

| SDK     | Ejemplo                                                                                                                                                                                    |
| ------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| .NET    | [Administrar recursos desde una máquina virtual habilitada con identidades administradas para recursos de Azure](https://github.com/Azure-Samples/aad-dotnet-manage-resources-from-vm-with-msi)       |
| Java    | [Administrar almacenamiento desde una máquina virtual habilitada con identidades administradas para recursos de Azure](https://github.com/Azure-Samples/compute-java-manage-resources-from-vm-with-msi-in-aad-group) |
| Node.js | [Crear una máquina virtual con identidad administrada asignada por el sistema habilitada](https://azure.microsoft.com/resources/samples/compute-node-msi-vm/)                                              |
| Python  | [Crear una máquina virtual con identidad administrada asignada por el sistema habilitada](https://azure.microsoft.com/resources/samples/compute-python-msi-vm/)                                            |
| Ruby    | [Crear una máquina virtual de Azure con una identidad asignada por el sistema habilitada](https://github.com/Azure-Samples/compute-ruby-msi-vm/)                                                             |

### Obtención de un token de acceso

Una aplicación cliente puede solicitar un token de acceso solo de aplicación de identidades administradas para recursos de Azure para acceder a un recurso determinado. El token se basa en la entidad de servicio de las identidades administradas para recursos de Azure. El método recomendado es usar `DefaultAzureCredential`.

La biblioteca de identidad de Azure admite un tipo `DefaultAzureCredential`. `DefaultAzureCredential` intenta autenticarse automáticamente a través de varios mecanismos, incluidas las variables de entorno o un inicio de sesión interactivo. El tipo de credencial se puede usar en el entorno de desarrollo con sus propias credenciales. También se puede usar en el entorno de Azure de producción con una identidad administrada. No se requieren cambios de código al implementar la aplicación.

:information_source: `DefaultAzureCredential` está diseñado para simplificar el comienzo con el SDK al controlar escenarios comunes con comportamientos predeterminados razonables. Los desarrolladores que quieran más control o cuyo escenario no sea atendido por la configuración predeterminada deben usar otros tipos de credenciales.

El `DefaultAzureCredential` intenta autenticarse mediante los siguientes mecanismos, en este orden, deteniéndose cuando uno tiene éxito:

1. **Entorno**: `DefaultAzureCredential` lee la información de cuenta especificada a través de variables de entorno y la usa para autenticarse.
1. **Identidad administrada**: Si la aplicación se implementa en un host de Azure con Identidad administrada habilitada, `DefaultAzureCredential` se autentica con esa cuenta.
1. **Visual Studio**: Si el desarrollador se ha autenticado a través de Visual Studio, `DefaultAzureCredential` se autentica con esa cuenta.
1. **CLI de Azure**: Si el desarrollador ha autenticado una cuenta a través del comando `az login` de la CLI de Azure, `DefaultAzureCredential` se autentica con esa cuenta. Los usuarios de Visual Studio Code pueden autenticar su entorno de desarrollo con la CLI de Azure.
1. **Azure PowerShell**: Si el desarrollador ha autenticado una cuenta a través del comando `Connect-AzAccount` de Azure PowerShell, `DefaultAzureCredential` se autentica con esa cuenta.
1. **Explorador interactivo**: Si está habilitado, `DefaultAzureCredential` autenticará de forma interactiva al desarrollador a través del explorador predeterminado del sistema actual. De forma predeterminada, este tipo de credencial está deshabilitado.

#### Ejemplos

Los siguientes ejemplos usan el SDK de identidad de Azure que se puede agregar a un proyecto con este comando:

```sh
dotnet add package Azure.Identity
```

##### Autenticarse con DefaultAzureCredential

Este ejemplo muestra cómo autenticar el `SecretClient` de la biblioteca de cliente [Azure.Security.KeyVault.Secrets](https://github.com/Azure/azure-sdk-for-net/tree/Azure.Identity_1.8.2/sdk/keyvault/Azure.Security.KeyVault.Secrets) con `DefaultAzureCredential`.

```csharp
// Crear un cliente de secretos usando DefaultAzureCredential
var client = new SecretClient(new Uri("https://myvault.vault.azure.net/"), new DefaultAzureCredential());
```

##### Especificar una identidad administrada asignada por el usuario con `DefaultAzureCredential`

Este ejemplo muestra cómo configurar `DefaultAzureCredential` para autenticar una identidad asignada por el usuario cuando se implementa en un host de Azure. Luego autentica un `BlobClient` de la biblioteca de cliente [Azure.Storage.Blobs](https://github.com/Azure/azure-sdk-for-net/tree/Azure.Identity_1.8.2/sdk/storage/Azure.Storage.Blobs) con la credencial.

```csharp
// Cuando se implemente en un host de Azure, la credencial de Azure predeterminada autenticará la identidad administrada asignada por el usuario especificada.

string userAssignedClientId = "<your managed identity client Id>";
var credential = new DefaultAzureCredential(new DefaultAzureCredentialOptions { ManagedIdentityClientId = userAssignedClientId });

var blobClient = new BlobClient(new Uri("https://myaccount.blob.core.windows.net/mycontainer/myblob"), credential);
```

##### Definir un flujo de autenticación personalizado con `ChainedTokenCredential`

Si bien `DefaultAzureCredential` es generalmente la forma más rápida de empezar a desarrollar aplicaciones para Azure, los usuarios más avanzados pueden querer personalizar las credenciales que se consideran al autenticarse. `ChainedTokenCredential` permite a los usuarios combinar varias instancias de credenciales para definir una cadena personalizada de credenciales. Este ejemplo muestra cómo crear un `ChainedTokenCredential` que intenta autenticarse con identidad administrada y volver a autenticarse a través de la CLI de Azure si la identidad administrada no está disponible en el entorno actual. La credencial se usa luego para autenticar un `EventHubProducerClient` de la biblioteca de cliente [Azure.Messaging.EventHubs](https://github.com/Azure/azure-sdk-for-net/tree/Azure.Identity_1.8.2/sdk/eventhub/Azure.Messaging.EventHubs).

```csharp
// Autenticarse usando identidad administrada si está disponible; de lo contrario, usar la CLI de Azure.

var credential = new ChainedTokenCredential(new ManagedIdentityCredential(), new AzureCliCredential());

var eventHubProducerClient = new EventHubProducerClient("myeventhub.eventhubs.windows.net", "myhubpath", credential);
```

---

<!-- ===== Azure App Configuration ===== -->

# Azure App Configuration

## Implementación de Azure App Configuration

Azure App Configuration proporciona un servicio para administrar de forma centralizada la configuración de las aplicaciones y las marcas de características.

### Exploración del servicio Azure App Configuration

Azure App Configuration proporciona un servicio para administrar de forma centralizada la configuración de las aplicaciones y las marcas de características. Los programas modernos, especialmente los que se ejecutan en la nube, generalmente tienen muchos componentes distribuidos por naturaleza. Distribuir la configuración entre estos componentes puede provocar errores difíciles de diagnosticar durante una implementación. Use App Configuration para almacenar toda la configuración de su aplicación y proteger su acceso en un solo lugar.

App Configuration ofrece las siguientes ventajas:

- Un servicio totalmente administrado que se puede configurar en minutos
- Representaciones y asignaciones de claves flexibles
- Etiquetado con etiquetas
- Reproducción de la configuración en un momento dado
- Interfaz de usuario dedicada para la administración de marcas de características
- Comparación de dos conjuntos de configuraciones en dimensiones definidas de forma personalizada
- Seguridad mejorada a través de identidades administradas de Azure
- Cifrado de información confidencial en reposo y en tránsito
- Integración nativa con marcos populares

App Configuration complementa a Azure Key Vault, que se usa para almacenar secretos de aplicación. App Configuration facilita la implementación de los siguientes escenarios:

- Centralizar la administración y distribución de datos de configuración jerárquicos para distintos entornos y geografías
- Cambiar dinámicamente la configuración de la aplicación sin necesidad de volver a implementar ni reiniciar una aplicación
- Controlar la disponibilidad de características en tiempo real

#### Usar App Configuration

La forma más sencilla de agregar un almacén de App Configuration a la aplicación es mediante una biblioteca de cliente que proporciona Microsoft. Según el lenguaje de programación y el marco, están disponibles los siguientes métodos.

| Lenguaje y marco de programación    | Cómo conectarse                                                                                                                                             |
| ---------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------- |
| .NET                               | [Proveedor](https://learn.microsoft.com/es-es/dotnet/api/Microsoft.Extensions.Configuration.AzureAppConfiguration) de App Configuration para .NET               |
| ASP.NET Core                       | [Proveedor](https://learn.microsoft.com/es-es/dotnet/api/Microsoft.Extensions.Configuration.AzureAppConfiguration) de App Configuration para .NET               |
| .NET Framework y ASP.NET           | [Generador](https://github.com/aspnet/MicrosoftConfigurationBuilders/blob/main/README.md#azureappconfigurationbuilder) de App Configuration para .NET            |
| Java Spring                        | [Proveedor](https://microsoft.github.io/spring-cloud-azure/docs/azure-app-configuration/2.9.0/reference/html/index.html) de App Configuration para Spring Cloud |
| JavaScript/Node.js                 | [Proveedor](https://github.com/Azure/azure-sdk-for-js/tree/main/sdk/appconfiguration/app-configuration) de App Configuration para JavaScript                    |
| Python                             | [Proveedor](https://github.com/Azure/azure-sdk-for-python/tree/main/sdk/appconfiguration/azure-appconfiguration) de App Configuration para Python               |
| Otros                              | App Configuration [REST API](https://learn.microsoft.com/en-us/rest/api/appconfiguration/)                                                                 |

### Creación de pares clave-valor

Azure App Configuration almacena datos de configuración como pares clave-valor.

#### Claves

Las claves sirven como nombre para los pares clave-valor y se usan para almacenar y recuperar los valores correspondientes. Es una práctica común organizar claves en un espacio de nombres jerárquico usando un delimitador de caracteres, como `/` o `:`. Use una convención que se adapte mejor a su aplicación. App Configuration trata las claves como un todo. No analiza las claves para determinar cómo está estructurado su nombre ni aplica reglas sobre ellas.

Aquí hay un ejemplo de nombres de clave estructurados en una jerarquía basada en servicios de componentes:

```txt
AppName:Service1:ApiEndpoint
AppName:Service2:ApiEndpoint
```

El uso de datos de configuración dentro de los marcos de aplicación puede dictar esquemas específicos de nomenclatura para pares clave-valor. Por ejemplo, el marco Spring Cloud de Java define recursos `Environment` que suministran configuración a una aplicación Spring. Estos recursos se parametrizan con variables que incluyen _application name_ y _profile_. Las claves para datos de configuración relacionados con Spring Cloud suelen comenzar con estos dos elementos separados por un delimitador.

Las claves almacenadas en App Configuration distinguen mayúsculas y minúsculas, y son cadenas basadas en Unicode. Las claves `app1` y `App1` son diferentes en un almacén de App Configuration. Téngalo en cuenta cuando use valores de configuración dentro de una aplicación, porque algunos marcos manejan las claves sin distinguir mayúsculas y minúsculas.

Puede usar cualquier carácter Unicode en los nombres de clave introducidos en App Configuration, excepto `*`, `,` y `\`. Estos caracteres están reservados. Si necesita incluir un carácter reservado, debe escaparlo usando `\{Reserved Character}`. Existe un límite combinado de 10,000 caracteres en un par clave-valor. Este límite incluye todos los caracteres de la clave, su valor y todos los atributos opcionales asociados. Dentro de este límite, puede tener muchos niveles jerárquicos para las claves.

##### Diseñar espacios de nombres de claves

Hay dos enfoques generales para nombrar claves usadas para datos de configuración: plano o jerárquico. Estos métodos son similares desde el punto de vista de uso de la aplicación, pero la nomenclatura jerárquica ofrece muchas ventajas:

- Más fácil de leer. En lugar de una secuencia larga de caracteres, los delimitadores en una clave jerárquica funcionan como espacios en una oración.
- Más fácil de administrar. Una jerarquía de nombres de clave representa grupos lógicos de datos de configuración.
- Más fácil de usar. Es más sencillo escribir una consulta que aplique coincidencia de patrón sobre claves en una estructura jerárquica y recupere solo una parte de los datos de configuración.

##### Etiquetar claves

Los pares clave-valor en App Configuration pueden tener opcionalmente un atributo de etiqueta. Las etiquetas se usan para diferenciar pares clave-valor con la misma clave. Una clave _app1_ con etiquetas _A_ y _B_ forma dos claves separadas en un almacén de App Configuration. De forma predeterminada, un par clave-valor no tiene etiqueta. Para hacer referencia explícita a un par clave-valor sin etiqueta, use `\0` (codificado en URL como `%00`).

Las etiquetas proporcionan una manera conveniente de crear variantes de una clave. Un uso común de las etiquetas es especificar varios entornos para la misma clave:

```txt
Key = AppName:DbEndpoint & Label = Test
Key = AppName:DbEndpoint & Label = Staging
Key = AppName:DbEndpoint & Label = Production
```

##### Versionar valores de clave

App Configuration no versiona automáticamente los valores de clave cuando se modifican. Use etiquetas como una forma de crear múltiples versiones de un valor de clave. Por ejemplo, puede introducir un número de versión de la aplicación o un identificador de confirmación de Git en las etiquetas para identificar valores de clave asociados con una compilación de software específica.

##### Consultar valores de clave

Cada par clave-valor se identifica de forma única por su clave más una etiqueta que puede ser `\0`. Puede consultar un almacén de App Configuration para obtener pares clave-valor especificando un patrón. El almacén devuelve todos los pares que coinciden con el patrón, incluidos sus valores y atributos.

#### Valores

Los valores asignados a las claves también son cadenas Unicode. Puede usar todos los caracteres Unicode para los valores. Existe un tipo de contenido opcional definido por el usuario asociado a cada valor. Use este atributo para almacenar información, por ejemplo un esquema de codificación, sobre un valor que ayude a su aplicación a procesarlo correctamente.

Los datos de configuración almacenados en un almacén de App Configuration, que incluyen todas las claves y valores, se cifran en reposo y en tránsito. App Configuration no es una solución de reemplazo para Azure Key Vault. No almacene secretos de aplicación en él.

### Administración de características de la aplicación

Feature management es una práctica moderna de desarrollo de software que desacopla la liberación de funcionalidades del despliegue de código y permite cambios rápidos en la disponibilidad de características bajo demanda. Usa una técnica llamada feature flags (también conocida como feature toggles, feature switches, etc.) para administrar dinámicamente el ciclo de vida de una característica.

#### Conceptos básicos

A continuación se presentan varios términos nuevos relacionados con la administración de características:

- **Feature flag**: Una feature flag es una variable con estado binario de encendido o apagado. La feature flag también tiene un bloque de código asociado. El estado de la feature flag activa si el bloque de código se ejecuta o no.
- **Feature manager**: Un feature manager es un paquete de aplicación que controla el ciclo de vida de todas las feature flags de una aplicación. Normalmente proporciona funcionalidad adicional, como el almacenamiento en caché de feature flags y la actualización de sus estados.
- **Filter**: Un filter es una regla para evaluar el estado de una feature flag. Un grupo de usuarios, un tipo de dispositivo o navegador, una ubicación geográfica y una ventana temporal son ejemplos de lo que un filter puede representar.

Una implementación eficaz de la administración de características consta de al menos dos componentes que funcionan conjuntamente:

- Una aplicación que hace uso de feature flags.
- Un repositorio independiente que almacena las feature flags y sus estados actuales.

Cómo interactúan estos componentes se ilustra en los siguientes ejemplos.

#### Uso de feature flags en código

El patrón básico para implementar feature flags en una aplicación es simple. Puede pensar en una feature flag como una variable de estado booleana usada con una sentencia condicional `if` en su código:

```csharp
if (featureFlag) {
    // Ejecute el siguiente código
}
```

En este caso, si `featureFlag` está establecido en `True`, el bloque de código encerrado se ejecuta; de lo contrario, se omite. Puede establecer el valor de `featureFlag` de forma estática, como en el siguiente ejemplo de código:

```csharp
bool featureFlag = true;
```

Puede también evaluar el estado de la marca según ciertas reglas:

```csharp
bool featureFlag = isBetaUser();
```

Puede extender la condicional para establecer el comportamiento de la aplicación para cualquiera de los dos estados:

```csharp
if (featureFlag) {
    // El siguiente código se ejecutará si el valor de featureFlag es true
} else {
    // El siguiente código se ejecutará si el valor de featureFlag es false
}
```

#### Declaración de feature flags

Cada feature flag tiene dos partes: un nombre y una lista de uno o más filters que se usan para evaluar si el estado de una característica está activado (es decir, cuando su valor es `True`). Un filter define un caso de uso para cuándo debe activarse una característica.

Cuando una marca de características tiene varios filtros, la lista de filtros se recorre en orden hasta que uno de ellos determina que la característica debe habilitarse. En ese punto, la feature flag está _on_ y se omiten los resultados de filtros restantes. Si ningún filter indica que la característica debe habilitarse, la feature flag está _off_.

El administrador de características admite _appsettings.json_ como origen de configuración para las marcas de características. El siguiente ejemplo muestra cómo configurar marcas de características en un archivo JSON:

```jsonc
"FeatureManagement": {
    "FeatureA": true, // Feature flag activada
    "FeatureB": false, // Feature flag desactivada
    "FeatureC": {
        "EnabledFor": [
            {
                "Name": "Percentage",
                "Parameters": {
                    "Value": 50
                }
            }
        ]
    }
}
```

#### Repositorio de feature flags

Para usar las marcas de características de forma eficaz, debe externalizar todas las marcas de características usadas en una aplicación. Este enfoque le permite cambiar los estados de las marcas de características sin modificar ni volver a implementar la propia aplicación.

Azure App Configuration está diseñado para ser un repositorio centralizado de feature flags. Puede usarlo para definir distintos tipos de feature flags y manipular sus estados de manera rápida y confiable. Luego puede usar las bibliotecas de App Configuration para varios marcos de lenguaje y acceder fácilmente a estas feature flags desde su aplicación.

### Protección de los datos de configuración de la aplicación

#### Cifrar datos de configuración mediante claves administradas por el cliente

Azure App Configuration cifra información confidencial en reposo usando una clave de cifrado AES de 256 bits proporcionada por Microsoft. Cada instancia de App Configuration tiene su propia clave de cifrado administrada por el servicio y utilizada para cifrar información confidencial. La información confidencial incluye los valores encontrados en pares clave-valor. Cuando la capacidad de clave administrada por el cliente está habilitada, App Configuration usa una identidad administrada asignada a la instancia de App Configuration para autenticarse con Microsoft Entra ID. Luego, la identidad administrada llama a Azure Key Vault y encapsula la clave de cifrado de la instancia de App Configuration. La clave encapsulada se almacena y la clave sin encapsular se almacena en caché dentro de App Configuration durante una hora. App Configuration actualiza cada hora la versión sin encapsular de la clave de cifrado de la instancia de App Configuration. Esto garantiza disponibilidad en condiciones operativas normales.

##### Habilitar la capacidad de clave administrada por el cliente

A continuación se requieren componentes para habilitar correctamente la capacidad de clave administrada por el cliente para Azure App Configuration:

- Instancia de Azure App Configuration de nivel Standard
- Azure Key Vault con las características soft-delete y purge-protection habilitadas
- Una clave RSA o RSA-HSM dentro de Key Vault: la clave no debe estar expirada, debe estar habilitada y debe tener habilitadas las capacidades de encapsular y desencapsular.

Una vez configurados estos recursos, quedan dos pasos para que Azure App Configuration pueda usar la clave de Key Vault:

- Asignar una identidad administrada a la instancia de Azure App Configuration.
- Conceder a la identidad permisos `GET`, `WRAP` y `UNWRAP` en la directiva de acceso del Key Vault de destino.

#### Usar puntos de conexión privados para Azure App Configuration

Puede usar private endpoints para Azure App Configuration para permitir que los clientes de una red virtual accedan de forma segura a los datos mediante un private link. El private endpoint usa una dirección IP del espacio de direcciones de la red virtual para su almacén de App Configuration. El tráfico de red entre los clientes de la red virtual y el almacén de App Configuration recorre la red virtual mediante un private link en la red troncal de Microsoft, eliminando la exposición a Internet pública.

Usar private endpoints para su almacén de App Configuration le permite:

- Proteger los detalles de configuración de su aplicación configurando el firewall para bloquear todas las conexiones a App Configuration en el punto de conexión público.
- Incrementar la seguridad de la red virtual asegurando que los datos no salgan de ella.
- Conectarse de forma segura al almacén de App Configuration desde redes locales que se conectan a la red virtual usando VPN o ExpressRoute con private peering.

#### Managed identities

Una identidad administrada de Microsoft Entra ID permite que Azure App Configuration acceda fácilmente a otros recursos protegidos por Microsoft Entra ID, como Azure Key Vault. La identidad es administrada por la plataforma de Azure. No requiere que aprovisione ni rote secretos.

A su aplicación se le pueden conceder dos tipos de identidades:

- Una **system-assigned identity** está vinculada a su almacén de configuración. Se elimina si se elimina su almacén de configuración. Un almacén de configuración solo puede tener una system-assigned identity.
- Una **user-assigned identity** es un recurso independiente de Azure que puede asignarse a su almacén de configuración. Un almacén de configuración puede tener varias user-assigned identities.

##### Agregar una identidad asignada por el sistema

Para configurar una identidad administrada con la CLI de Azure, use el comando `az appconfig identity assign` en un almacén de configuración existente. El siguiente ejemplo de Azure CLI crea una identidad asignada por el sistema para un almacén de Azure App Configuration llamado `myTestAppConfigStore`.

```sh
az appconfig identity assign \
    --name myTestAppConfigStore \
    --resource-group myResourceGroup
```

##### Agregar una identidad asignada por el usuario

La creación de un almacén de App Configuration con una identidad asignada por el usuario requiere que cree la identidad y luego asigne su identificador de recurso al almacén. A continuación, los ejemplos de Azure CLI crean una identidad asignada por el usuario llamada `myUserAssignedIdentity` y la asignan a un almacén de Azure App Configuration llamado `myTestAppConfigStore`.

Cree una identidad con el comando `az identity create`:

```sh
az identity create --resource-group myResourceGroup --name myUserAssignedIdentity
```

Asigne la nueva identidad asignada por el usuario al almacén de configuración `myTestAppConfigStore`:

```sh
az appconfig identity assign --name myTestAppConfigStore \
    --resource-group myResourceGroup \
    --identities /subscriptions/[subscription id]/resourcegroups/myResourceGroup/providers/Microsoft.ManagedId
```

---

# PARTE 4 — Supervisión, solución de problemas y optimización (5-10 %)

---

<!-- ===== Application Insights ===== -->

# Application Insights

## Supervisión del rendimiento de las aplicaciones

Instrumentar y supervisar sus aplicaciones le ayuda a maximizar su disponibilidad y rendimiento.

### Exploración de Application Insights

Application Insights es una extensión de Azure Monitor y proporciona características de Application Performance Monitoring (APM). Las herramientas de APM son útiles para supervisar aplicaciones desde desarrollo, pasando por pruebas, hasta producción de las siguientes maneras:

- Comprender de forma proactiva cómo está funcionando una aplicación.
- Revisar de forma reactiva los datos de ejecución de la aplicación para determinar la causa de un incidente.

Además de recopilar métricas y datos de telemetría de la aplicación, que describen las actividades y el estado de la aplicación, Application Insights también puede usarse para recopilar y almacenar datos de registros de seguimiento de la aplicación.

El seguimiento de registros se asocia con otra telemetría para ofrecer una vista detallada de la actividad. Agregar registros de seguimiento a aplicaciones existentes solo requiere proporcionar un destino para los registros; el marco de registro rara vez necesita cambiarse.

#### Introducción a características de Application Insights

Las características incluyen, entre otras:

| Característica                     | Descripción                                                                                                                                                 |
| ---------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------- |
| Live Metrics                       | Observe la actividad de la aplicación implementada en tiempo real sin afectar al entorno host.                                                             |
| Availability                       | También conocida como _Synthetic Transaction Monitoring_, sondea los puntos de conexión externos de su aplicación para probar la disponibilidad y capacidad de respuesta general a lo largo del tiempo. |
| Integración con GitHub o Azure DevOps | Cree elementos de trabajo de GitHub o Azure DevOps en el contexto de los datos de Application Insights.                                                 |
| Uso                                | Comprenda qué características son populares entre los usuarios y cómo interactúan y usan su aplicación.                                                   |
| Smart Detection                    | Detección automática de errores y anomalías mediante análisis proactivo de telemetría.                                                                     |
| Application Map                    | Vista de alto nivel, de arriba hacia abajo, de la arquitectura de la aplicación con referencias visuales rápidas del estado y la capacidad de respuesta de los componentes. |
| Distributed Tracing                | Busque y visualice un flujo de extremo a extremo de una ejecución o transacción determinada.                                                              |

#### Qué supervisa Application Insights

Application Insights recopila datos de métricas y telemetría de la aplicación, que describen las actividades y el estado de la aplicación, así como datos de registros de seguimiento.

- **Tasas de solicitudes, tiempos de respuesta y tasas de error**: averigüe qué páginas son más populares, a qué horas del día y dónde están sus usuarios. Vea qué páginas tienen mejor rendimiento. Si sus tiempos de respuesta y tasas de error aumentan cuando hay más solicitudes, es posible que tenga un problema de recursos.
- **Tasas de dependencias, tiempos de respuesta y tasas de error**: averigüe si servicios externos están ralentizando su aplicación.
- **Excepciones**: analice estadísticas agregadas o seleccione instancias concretas y profundice en el seguimiento de pila y solicitudes relacionadas. Se notifican excepciones tanto del servidor como del explorador.
- **Vistas de página y rendimiento de carga**: informados por los exploradores de sus usuarios.
- **Llamadas AJAX** desde páginas web: tasas, tiempos de respuesta y tasas de error.
- **Recuento de usuarios y sesiones**.
- **Contadores de rendimiento** de sus máquinas servidor Windows o Linux, como CPU, memoria y uso de red.
- **Diagnósticos del host** desde Docker o Azure.
- **Registros de seguimiento de diagnóstico** de su aplicación, para que pueda correlacionar eventos de seguimiento con solicitudes.
- **Eventos y métricas personalizados** que escriba en el código del cliente o del servidor para hacer seguimiento de eventos de negocio como elementos vendidos o juegos ganados.

#### Introducción a Application Insights

Application Insights es uno de los muchos servicios alojados en Microsoft Azure, y la telemetría se envía allí para análisis y visualización. Registrarse es gratuito y, si elige el plan de precios básico de Application Insights, no hay cargos hasta que su aplicación tenga un uso significativo.

Hay varias formas de empezar a supervisar y analizar el rendimiento de la aplicación:

- **En tiempo de ejecución**: instrumente su aplicación web en el servidor. Ideal para aplicaciones ya implementadas. Evita actualizaciones de código.
- **En tiempo de desarrollo**: agregue Application Insights a su código. Permite personalizar la recopilación de telemetría y enviar más telemetría.
- **Instrumente sus páginas web** para vistas de página, AJAX y otra telemetría del lado cliente.
- **Analice el uso de aplicaciones móviles** integrándose con Visual Studio App Center.
- **Pruebas de disponibilidad**: haga ping a su sitio web regularmente desde nuestros servidores.

### Descripción de las métricas basadas en registros

Las métricas basadas en registros de Application Insights le permiten analizar el estado de sus aplicaciones supervisadas, crear paneles potentes y configurar alertas. Hay dos tipos de métricas:

- **Métricas basadas en registros**: tras bastidores, se traducen en [consultas Kusto](https://learn.microsoft.com/en-us/azure/kusto/query/) a partir de eventos almacenados.
- **Métricas estándar**: se almacenan como series temporales preagregadas.

Dado que las _métricas estándar_ están preagregadas durante la recopilación, tienen mejor rendimiento al consultar. Las métricas estándar son una mejor opción para paneles y alertas en tiempo real. Las _métricas basadas en registros_ tienen más dimensiones, lo que las convierte en una mejor opción para análisis de datos y diagnósticos ad hoc. Use el [selector de espacio de nombres](https://learn.microsoft.com/en-us/azure/azure-monitor/essentials/metrics-getting-started#create-your-first-metric-chart) para alternar entre métricas basadas en registros y métricas estándar en [metrics explorer](https://learn.microsoft.com/en-us/azure/azure-monitor/essentials/metrics-getting-started).

#### Métricas basadas en registros

Los desarrolladores pueden usar el SDK para enviar eventos manualmente (escribiendo código que invoca explícitamente el SDK) o confiar en la recopilación automática de eventos mediante auto-instrumentación. En cualquier caso, el back-end de Application Insights almacena todos los eventos recopilados como registros, y las hojas de Application Insights en Azure Portal actúan como herramienta analítica y de diagnóstico para visualizar datos basados en eventos desde los registros.

Usar registros para conservar un conjunto completo de eventos puede aportar gran valor analítico y de diagnóstico. Por ejemplo, puede obtener un recuento exacto de solicitudes a una URL concreta con el número de usuarios distintos que realizaron esas llamadas. También puede obtener seguimientos de diagnóstico detallados, incluidas excepciones y llamadas a dependencias para cualquier sesión de usuario. Este tipo de información puede mejorar de forma significativa la visibilidad sobre el estado y uso de la aplicación, y reducir el tiempo necesario para diagnosticar problemas.

Al mismo tiempo, recopilar un conjunto completo de eventos puede ser poco práctico (o incluso imposible) para aplicaciones que generan un gran volumen de telemetría. Para situaciones en las que el volumen de eventos es demasiado alto, Application Insights implementa varias técnicas de reducción de volumen de telemetría, como muestreo y filtrado, que reducen el número de eventos recopilados y almacenados. Lamentablemente, reducir el número de eventos almacenados también reduce la precisión de las métricas que, tras bastidores, deben realizar agregaciones en tiempo de consulta de los eventos almacenados en registros.

#### Métricas preagregadas

Las métricas preagregadas no se almacenan como eventos individuales con muchas propiedades. En su lugar, se almacenan como series temporales preagregadas y solo con dimensiones clave. Esto hace que las nuevas métricas sean superiores en tiempo de consulta: recuperar datos ocurre más rápido y requiere menos capacidad de proceso. Esto habilita nuevos escenarios, como alertas casi en tiempo real sobre dimensiones de métricas, paneles más reactivos y más.

:bangbang: Tanto las métricas basadas en registros como las métricas preagregadas coexisten en Application Insights. Para diferenciar ambas, en la UX de Application Insights las métricas preagregadas ahora se denominan "Standard metrics (preview)", mientras que las métricas tradicionales de eventos se renombraron como "Log-based metrics".

Los SDK más recientes (SDK [Application Insights 2.7](https://www.nuget.org/packages/Microsoft.ApplicationInsights/2.7.2) o posterior para .NET) preagregan métricas durante la recopilación. Esto aplica a las [métricas estándar enviadas de forma predeterminada](https://learn.microsoft.com/en-us/azure/azure-monitor/essentials/metrics-supported#microsoftinsightscomponents), por lo que la precisión no se ve afectada por muestreo o filtrado. También aplica a métricas personalizadas enviadas con [GetMetric](https://learn.microsoft.com/en-us/azure/azure-monitor/app/api-custom-events-metrics#getmetric), lo que reduce la ingesta de datos y el costo.

Para los SDK que no implementan preagregación, el back-end de Application Insights sigue rellenando las nuevas métricas agregando los eventos recibidos por el punto de conexión de recopilación de eventos de Application Insights. Aunque no se beneficie del menor volumen de datos transmitidos por red, aún puede usar las métricas preagregadas y experimentar mejor rendimiento y compatibilidad con alertas dimensionales casi en tiempo real.

Vale la pena mencionar que el punto de conexión de recopilación preagrega eventos antes del muestreo de ingesta, lo que significa que el [ingestion sampling](https://learn.microsoft.com/en-us/azure/azure-monitor/app/sampling) nunca afectará la precisión de las métricas preagregadas, independientemente de la versión del SDK que use con su aplicación.

### Instrumentación de una aplicación para la supervisión

A nivel básico, "instrumentar" simplemente significa habilitar que una aplicación capture telemetría. Hay dos métodos para instrumentar su aplicación:

- Instrumentación automática (autoinstrumentation)
- Instrumentación manual

**Autoinstrumentation** habilita la recopilación de telemetría mediante configuración sin tocar el código de la aplicación. Aunque es más cómodo, suele ser menos configurable. Tampoco está disponible en todos los lenguajes. Consulte [entornos y lenguajes compatibles con Autoinstrumentation](https://learn.microsoft.com/en-us/azure/azure-monitor/app/codeless-overview). Cuando autoinstrumentation está disponible, es la forma más sencilla de habilitar Azure Monitor Application Insights.

**Manual instrumentation** consiste en programar contra la API de Application Insights u OpenTelemetry. En el contexto del usuario, normalmente se refiere a instalar un SDK específico del lenguaje en una aplicación. Esto significa que debe gestionar usted mismo las actualizaciones a la última versión del paquete. Puede usar esta opción si necesita hacer llamadas de dependencia o API personalizadas que no se capturan de forma predeterminada con autoinstrumentation. Hay dos opciones para la instrumentación manual:

- [Application Insights SDKs](https://learn.microsoft.com/en-us/azure/azure-monitor/app/asp-net-core)
- [Azure Monitor OpenTelemetry Distros](https://learn.microsoft.com/en-us/azure/azure-monitor/app/opentelemetry-enable).

#### Habilitar mediante SDK de Application Insights

Solo necesita instalar el SDK de Application Insights en las siguientes circunstancias:

- Requiere eventos y métricas personalizados.
- Requiere control sobre el flujo de telemetría.
- Auto-Instrumentation no está disponible (normalmente debido a limitaciones de lenguaje o plataforma).

Para usar el SDK, instala un pequeño paquete de instrumentación en tu aplicación e instrumenta la aplicación web, cualquier componente de fondo y JavaScript dentro de las páginas web. La aplicación y sus componentes no tienen que estar alojadosen Azure. La instrumentación monitorea tu aplicación y dirige los datos de telemetría a un recurso de Application Insights utilizando un token único.

Una lista de versiones y nombres de SDK se aloja en GitHub. Para más información, visite [Versión del SDK](https://github.com/microsoft/ApplicationInsights-dotnet/blob/develop/docs/versions_and_names.md).

#### Habilitar mediante OpenTelemetry

Microsoft trabajó con partes interesadas del proyecto de dos proyectos de telemetría de código abierto anteriormente populares, [OpenCensus](https://opencensus.io/) y [OpenTracing](https://opentracing.io/). Juntos, ayudamos a crear un único proyecto, OpenTelemetry. OpenTelemetry incluye contribuciones de todos los vendedores principales de la nube y de Gestión del rendimiento de aplicaciones (APM) y vive dentro de la [Fundación de cálculo nativo de la nube (CNCF)](https://www.cncf.io/). Microsoft es miembro Platino de la CNCF.

Algunos términos heredados en Application Insights son confusos debido a la convergencia de la industria en OpenTelemetry. La siguiente tabla destaca estas diferencias. Los términos de OpenTelemetry están reemplazando los términos de Application Insights.

| Application Insights      | OpenTelemetry                             |
| ------------------------- | ----------------------------------------- |
| Autocollectors            | Instrumentation libraries                 |
| Channel                   | Exporter                                  |
| Codeless / Agent-based    | Autoinstrumentation                       |
| Traces                    | Logs                                      |
| Requests                  | Server Spans                              |
| Dependencies              | Other Span Types (Client, Internal, etc.) |
| Operation ID              | Trace ID                                  |
| ID or Operation Parent ID | Span ID                                   |

### Selección de una prueba de disponibilidad

Después de implementar la aplicación web o el sitio web, puede configurar pruebas periódicas para supervisar la disponibilidad y la capacidad de respuesta. Application Insights envía solicitudes web a la aplicación a intervalos regulares desde puntos de todo el mundo. Puede alertarle si su aplicación no responde o responde demasiado lento. Puede crear hasta 100 pruebas de disponibilidad por recurso de Application Insights.

Las pruebas de disponibilidad no requieren cambios en el sitio web que está probando y funcionan para cualquier punto de conexión HTTP o HTTPS accesible desde Internet pública. También puede probar la disponibilidad de una API REST de la que dependa su servicio.

Puede crear hasta 100 pruebas de disponibilidad por recurso de Application Insights, y existen tres tipos de pruebas de disponibilidad:

- **Standard test:** Es un tipo de prueba de disponibilidad que comprueba la disponibilidad de un sitio web enviando una sola solicitud, similar a la prueba URL ping en desuso. Además de validar si un punto de conexión responde y medir el rendimiento, las pruebas estándar también incluyen validez del certificado TLS/SSL, verificación proactiva de vigencia, verbo de solicitud HTTP (por ejemplo, `GET`, `HEAD` y `POST`), encabezados personalizados y datos personalizados asociados con la solicitud HTTP.
- **Prueba personalizada TrackAvailability:** Si decide crear una aplicación personalizada para ejecutar pruebas de disponibilidad, puede usar el método [TrackAvailability()](https://learn.microsoft.com/en-us/dotnet/api/microsoft.applicationinsights.telemetryclient.trackavailability) para enviar los resultados a Application Insights.
- [URL ping test (classic)](https://learn.microsoft.com/en-us/azure/azure-monitor/app/monitor-web-app-availability): Puede crear esta prueba a través del portal para validar si un punto de conexión responde y medir el rendimiento asociado con esa respuesta. También puede establecer criterios de éxito personalizados junto con características más avanzadas, como analizar solicitudes dependientes y permitir reintentos.

:bangbang: **Pruebas URL ping:** El 30 de septiembre de 2026, las pruebas URL ping en Application Insights se retirarán. Las pruebas URL ping existentes se eliminarán de sus recursos. Revise los [precios](https://azure.microsoft.com/pricing/details/monitor) de las pruebas estándar y [migre](https://aka.ms/availabilitytestmigration) a su uso antes del 30 de septiembre de 2026 para asegurarse de que pueda seguir ejecutando pruebas de disponibilidad de un solo paso en sus recursos de Application Insights.

### Solución de problemas de rendimiento con el Mapa de aplicación

El Mapa de aplicación le ayuda a detectar cuellos de botella de rendimiento o zonas activas de errores en todos los componentes de la aplicación distribuida. Cada nodo del mapa representa un componente de la aplicación o sus dependencias, y tiene un indicador clave de rendimiento de estado y estado de alertas. Puede profundizar desde cualquier componente hacia diagnósticos más detallados, como eventos de Application Insights. Si su aplicación usa servicios de Azure, también puede profundizar hacia diagnósticos de Azure, como recomendaciones de SQL Database Advisor.

Los componentes son partes implementables de forma independiente de su aplicación distribuida/de microservicios. Los equipos de desarrollo y operaciones tienen visibilidad a nivel de código o acceso a la telemetría generada por estos componentes de aplicación.

- Los componentes son diferentes de las dependencias externas "observadas" como SQL, Event Hubs, etc., a las que su equipo/organización podría no tener acceso (código o telemetría).
- Los componentes se ejecutan en cualquier número de instancias de servidor/rol/contenedor.
- Los componentes pueden ser claves de instrumentación de Application Insights separadas (incluso si las suscripciones son diferentes) o diferentes roles que reportan a una sola clave de instrumentación de Application Insights. La experiencia de mapa en versión preliminar muestra los componentes sin importar su configuración.

Puede ver la topología de aplicación completa en múltiples niveles de componentes de aplicación relacionados. Los componentes podrían ser diferentes recursos de Application Insights o diferentes roles en un solo recurso. El mapa de aplicación encuentra componentes siguiendo las llamadas de dependencia HTTP hechas entre servidores con el SDK de Application Insights instalado.

Esta experiencia comienza con la detección progresiva de los componentes. Al cargar por primera vez el mapa de aplicación, se desencadena un conjunto de consultas para detectar los componentes relacionados con este componente. Un botón en la esquina superior izquierda se actualiza con el número de componentes en su aplicación a medida que se descubren.

Al seleccionar **Actualizar componentes del mapa** se actualiza con todos los componentes descubiertos hasta ese momento. Dependiendo de la complejidad de su aplicación, esto puede tardar un minuto en cargar.

Si todos los componentes son roles dentro de un recurso único de Application Insights, este paso de detección no es necesario. La carga inicial de tal aplicación tiene todos sus componentes.

![Captura de Application Map que muestra la carga inicial de una aplicación donde todos los componentes son roles dentro de un único recurso de Application Insights.](https://learn.microsoft.com/en-us/training/wwl-azure/monitor-app-performance/media/application-map.png)

Uno de los objetivos clave con esta experiencia es poder visualizar topologías complejas con cientos de componentes. Haga clic en cualquier componente para ver información relacionada y vaya a la experiencia de triaje de rendimiento y errores para ese componente.

![Captura que muestra los detalles de un componente en Application Map.](https://learn.microsoft.com/en-us/training/wwl-azure/monitor-app-performance/media/application-map-component.png)

Application Map usa la propiedad de nombre de rol en la nube para identificar los componentes en el mapa. Puede establecer manualmente o reemplazar el nombre de rol en la nube y cambiar lo que se muestra en Application Map.

---

# PARTE 5 — Conexión y consumo de servicios de Azure y de terceros (20-25 %)

---

<!-- ===== API Management ===== -->

# API Management

## Exploración de API Management

API Management ayuda a las organizaciones a publicar API para desarrolladores externos, socios e internos a fin de desbloquear el potencial de sus datos y servicios.

### Descripción del servicio API Management

API Management proporciona la funcionalidad principal para garantizar un programa de API exitoso mediante participación de desarrolladores, información empresarial, análisis, seguridad y protección. Cada API consta de una o más operaciones, y cada API puede agregarse a uno o más productos. Para usar una API, los desarrolladores se suscriben a un producto que contiene esa API y luego pueden llamar a la operación de la API, sujeto a cualquier directiva de uso que esté en vigor.

#### Componentes de API Management

Azure API Management se compone de una _puerta de enlace de API_, un _plano de administración_ y un _portal para desarrolladores_. Estos componentes están hospedados en Azure y son totalmente administrados de forma predeterminada. API Management está disponible en varios [planes](https://learn.microsoft.com/es-es/azure/api-management/api-management-features) que difieren en capacidad y características.

- La **puerta de enlace de API** es el punto de conexión que:
  - Acepta llamadas de API y las enruta a los back-ends adecuados
  - Verifica las claves de API y otras credenciales presentadas con las solicitudes
  - Aplica cuotas de uso y límites de frecuencia
  - Transforma solicitudes y respuestas especificadas en instrucciones de directiva
  - Almacena en caché las respuestas para mejorar la latencia de respuesta y minimizar la carga de los servicios de back-end
  - Emite registros, métricas y seguimientos para supervisión, informes y solución de problemas
- El **plano de administración** es la interfaz administrativa donde configura el programa de API. Úselo para:
  - Aprovisionar y configurar los ajustes del servicio API Management
  - Definir o importar el esquema de la API
  - Empaquetar las API en productos
  - Configurar directivas como cuotas o transformaciones en las API
  - Obtener información de los análisis
  - Administrar usuarios
- El **portal para desarrolladores** es un sitio web generado automáticamente y totalmente personalizable con la documentación de las API. Con el portal para desarrolladores, los desarrolladores pueden:
  - Leer la documentación de la API
  - Llamar a una API a través de la consola interactiva
  - Crear una cuenta y suscribirse para obtener claves de API
  - Acceder a los análisis sobre su propio uso
  - Descargar definiciones de API
  - Administrar claves de API

#### Productos

Los productos son la forma en que las API se exponen a los desarrolladores. Los productos de API Management tienen una o más API y se configuran con un título, una descripción y términos de uso. Los productos pueden ser **Abiertos** o **Protegidos**. Los productos protegidos deben suscribirse antes de poder usarse, mientras que los productos abiertos se pueden usar sin una suscripción. La aprobación de la suscripción se configura en el nivel del producto y puede requerir la aprobación del administrador o aprobarse automáticamente.

#### Grupos

Los grupos se usan para administrar la visibilidad de los productos para los desarrolladores. API Management tiene los siguientes grupos del sistema inmutables:

- **Administradores**: Administran las instancias del servicio API Management y crean las API, operaciones y productos que usan los desarrolladores. Los administradores de la suscripción de Azure son miembros de este grupo.
- **Desarrolladores**: Usuarios del portal para desarrolladores autenticados que crean aplicaciones con las API. Los desarrolladores reciben acceso al portal para desarrolladores y crean aplicaciones que llaman a las operaciones de una API.
- **Invitados**: Usuarios del portal para desarrolladores no autenticados. Se les puede conceder cierto acceso de solo lectura, como la capacidad de ver las API pero no llamarlas.

Además de estos grupos del sistema, los administradores pueden crear grupos personalizados o usar grupos externos en los inquilinos de Microsoft Entra asociados.

#### Desarrolladores

Los desarrolladores representan las cuentas de usuario en una instancia del servicio API Management. Los administradores pueden crear o invitar a los desarrolladores a unirse, o pueden registrarse desde el portal para desarrolladores. Cada desarrollador es miembro de uno o más grupos y puede suscribirse a los productos que conceden visibilidad a esos grupos.

#### Directivas

Las directivas son una colección de instrucciones que se ejecutan secuencialmente en la solicitud o respuesta de una API. Las instrucciones populares incluyen la conversión de formato de XML a JSON y la limitación de velocidad de llamadas para restringir el número de llamadas entrantes de un desarrollador, y están disponibles muchas otras directivas.

Las expresiones de directiva se pueden usar como valores de atributo o valores de texto en cualquiera de las directivas de API Management, a menos que la directiva especifique lo contrario. Algunas directivas, como las directivas de flujo de control y de establecer variable, se basan en expresiones de directiva.

Las directivas se pueden aplicar en diferentes ámbitos, según sus necesidades: global (todas las API), un producto, una API específica o una operación de API.

### Exploración de las puertas de enlace de API

La solución puede contener varios servicios de front-end y back-end. En este escenario, ¿cómo sabe un cliente qué puntos de conexión llamar? ¿Qué sucede cuando se introducen nuevos servicios o se refactorizan los servicios existentes? ¿Cómo controlan los servicios la terminación SSL, la autenticación y otros aspectos?

La puerta de enlace de API Management (también denominada plano de datos o tiempo de ejecución) es el componente de servicio responsable de proxy las solicitudes de API, aplicar directivas y recopilar telemetría.

Una puerta de enlace de API se sitúa entre los clientes y los servicios. Actúa como proxy inverso, enrutando las solicitudes de los clientes a los servicios. También puede realizar varias tareas transversales, como autenticación, terminación SSL y limitación de velocidad. Si no implementa una puerta de enlace, los clientes deben enviar solicitudes directamente a los servicios de back-end. Sin embargo, hay algunos problemas potenciales al exponer los servicios directamente a los clientes:

- Puede dar lugar a código de cliente complejo. El cliente debe realizar un seguimiento de varios puntos de conexión y controlar los errores de forma resistente.
- Crea acoplamiento entre el cliente y el back-end. El cliente necesita saber cómo se descomponen los servicios individuales. Eso hace que sea más difícil mantener el cliente y también más difícil refactorizar los servicios.
- Una sola operación podría requerir llamadas a varios servicios.
- Cada servicio orientado al público debe controlar aspectos como la autenticación, SSL y la limitación de velocidad del cliente.
- Los servicios deben exponer un protocolo compatible con el cliente, como HTTP o WebSocket. Esto limita la elección de los protocolos de comunicación.
- Los servicios con puntos de conexión públicos son una posible superficie de ataque y deben protegerse.

Una puerta de enlace ayuda a resolver estos problemas desacoplando los clientes de los servicios.

#### Administrado y autohospedado

API Management ofrece puertas de enlace administradas y autohospedadas:

- **Administrado**: La puerta de enlace administrada es el componente de puerta de enlace predeterminado que se implementa en Azure para cada instancia de API Management en cada nivel de servicio. Con la puerta de enlace administrada, todo el tráfico de API fluye a través de Azure independientemente de dónde estén hospedados los back-ends que implementan las API.
- **Autohospedado**: La puerta de enlace autohospedada es una versión opcional y en contenedor de la puerta de enlace administrada predeterminada. Es útil para escenarios híbridos y de nube múltiple donde hay un requisito de ejecutar las puertas de enlace fuera de Azure en los mismos entornos donde están hospedados los back-ends de API. La puerta de enlace autohospedada permite a los clientes con infraestructura de TI híbrida administrar las API hospedadas en entornos locales y en nubes desde un único servicio API Management en Azure.

### Exploración de API Management policies

En Azure API Management, las directivas permiten al publicador cambiar el comportamiento de la API a través de la configuración. Las directivas son una colección de instrucciones que se ejecutan secuencialmente en la solicitud o respuesta de una API.

Las directivas se aplican dentro de la puerta de enlace que se sitúa entre el consumidor de API y la API administrada. La puerta de enlace recibe todas las solicitudes y normalmente las reenvía sin cambios a la API subyacente. Sin embargo, una directiva puede aplicar cambios tanto a la solicitud entrante como a la respuesta saliente. Las expresiones de directiva se pueden usar como valores de atributo o valores de texto en cualquiera de las directivas de API Management, a menos que la directiva especifique lo contrario.

#### Descripción de la configuración de directivas

La definición de directiva es un documento XML simple que describe una secuencia de instrucciones de entrada y salida. El XML se puede editar directamente en la ventana de definición.

La configuración se divide en `inbound`, `backend`, `outbound` y `on-error`. La serie de instrucciones de directiva especificadas se ejecuta en orden para una solicitud y una respuesta.

```xml
<policies>
  <inbound>
    <!-- aquí van las instrucciones que se aplican a la solicitud -->
  </inbound>
  <backend>
        <!-- aquí van las instrucciones que se aplican antes de reenviar la solicitud
          al servicio back-end -->
  </backend>
  <outbound>
    <!-- aquí van las instrucciones que se aplican a la respuesta -->
  </outbound>
  <on-error>
    <!-- aquí van las instrucciones que se aplican si existe una condición de error -->
  </on-error>
</policies>
```

Si se produce un error durante el procesamiento de una solicitud, los pasos restantes en las secciones `inbound`, `backend` u `outbound` se omiten y la ejecución salta a las instrucciones de la sección `on-error`. Al colocar instrucciones de directiva en la sección `on-error`, puede revisar el error usando la propiedad `context.LastError`, inspeccionar y personalizar la respuesta de error con la directiva `set-body` y configurar lo que sucede si se produce un error.

#### Expresiones de directiva

A menos que la directiva especifique lo contrario, las expresiones de directiva se pueden usar como valores de atributo o valores de texto en cualquiera de las directivas de API Management. Una expresión de directiva es:

- una sola instrucción de C# incluida en `@(expression)`, o
- un bloque de código de C# de varias instrucciones, incluido en `@{expression}`, que devuelve un valor

Cada expresión tiene acceso a la variable `context` proporcionada implícitamente y a un subconjunto permitido de tipos de .NET Framework.

Las [expresiones de directiva](https://learn.microsoft.com/es-es/azure/api-management/api-management-policy-expressions) proporcionan un medio sofisticado para controlar el tráfico y modificar el comportamiento de la API sin necesidad de escribir código especializado ni modificar los servicios de back-end.

El siguiente ejemplo usa expresiones de directiva y la directiva set-header para agregar datos de usuario a la solicitud entrante. El encabezado agregado incluye el identificador de usuario asociado con la clave de suscripción en la solicitud y la región donde está hospedada la puerta de enlace que procesa la solicitud.

```xml
<policies>
    <inbound>
        <base />
        <set-header name="x-request-context-data" exists-action="override">
            <value>@(context.User.Id)</value>
            <value>@(context.Deployment.Region)</value>
      </set-header>
    </inbound>
</policies>
```

#### Aplicar directivas especificadas en distintos ámbitos

Si tiene una directiva en el nivel global y una directiva configurada para una API, siempre que se use esa API en particular se aplican ambas directivas. API Management permite el orden determinista de las instrucciones de directiva combinadas a través del elemento base.

```xml
<policies>
    <inbound>
        <cross-domain />
        <base />
        <find-and-replace from="xyz" to="abc" />
    </inbound>
</policies>
```

En la definición de directiva del ejemplo anterior, la instrucción `cross-domain` se ejecutaría primero. La directiva `find-and-replace` se ejecutaría después de cualquier directiva en un ámbito más amplio.

### Filtrar el contenido de la respuesta

La directiva definida en el siguiente ejemplo muestra cómo filtrar elementos de datos de la carga de respuesta según el producto asociado a la solicitud.

El fragmento asume que el contenido de la respuesta tiene formato JSON y contiene propiedades de nivel raíz llamadas _minutely_, _hourly_, _daily_ y _flags_.

```xml
<policies>
  <inbound>
    <base />
  </inbound>
  <backend>
    <base />
  </backend>
  <outbound>
    <base />
    <choose>
      <when condition="@(context.Response.StatusCode == 200 && context.Product.Name.Equals("Starter"))">
        <!-- Tenga en cuenta que no usamos preserveContent=true al deserializar el flujo del cuerpo de la respuesta en un objeto JSON, ya que no pretendemos volver a acceder a él. Vea los detalles en https://learn.microsoft.com/azure/api-management/api-management-transformation-policies#SetBody -->
        <set-body>
          @{
            var response = context.Response.Body.As<JObject>();
            foreach (var key in new [] {"minutely", "hourly", "daily", "flags"}) {
            response.Property (key).Remove ();
           }
          return response.ToString();
          }
        </set-body>
      </when>
    </choose>
  </outbound>
  <on-error>
    <base />
  </on-error>
</policies>
```

### Creación de directivas avanzadas

Esta sección proporciona una referencia para las siguientes directivas de API Management:

- Flujo de control: aplica condicionalmente instrucciones de directiva según los resultados de la evaluación de expresiones booleanas.
- Reenviar solicitud: reenvía la solicitud al servicio de back-end.
- Limitar simultaneidad: evita que las directivas incluidas se ejecuten con más del número especificado de solicitudes a la vez.
- Registrar en Event Hub: envía mensajes en el formato especificado a un Event Hub definido por una entidad de registrador.
- Respuesta simulada: anula la ejecución de la canalización y devuelve una respuesta simulada directamente al llamador.
- Reintentar: reintenta la ejecución de las instrucciones de directiva incluidas, si y hasta que se cumpla la condición. La ejecución se repite en los intervalos de tiempo especificados y hasta el recuento de reintentos especificado.

#### Flujo de control

La directiva `choose` aplica instrucciones de directiva incluidas según el resultado de la evaluación de expresiones booleanas, de forma similar a una construcción if-then-else o switch en un lenguaje de programación.

```xml
<choose>
    <when condition="Boolean expression | Boolean constant">
        <!— una o más instrucciones de directiva que se aplicarán si la condición anterior es verdadera  -->
    </when>
    <when condition="Boolean expression | Boolean constant">
        <!— una o más instrucciones de directiva que se aplicarán si la condición anterior es verdadera  -->
    </when>
    <otherwise>
        <!— una o más instrucciones de directiva que se aplicarán si ninguna de las condiciones anteriores es verdadera  -->
</otherwise>
</choose>
```

La directiva de flujo de control debe contener al menos un elemento `<when/>`. El elemento `<otherwise/>` es opcional. Las condiciones de los elementos `<when/>` se evalúan en el orden en que aparecen dentro de la directiva. Las instrucciones de directiva incluidas dentro del primer elemento `<when/>` se aplican cuando el atributo de condición es verdadero. Las directivas incluidas dentro del elemento `<otherwise/>`, si está presente, se aplican si todos los atributos de condición de los elementos `<when/>` son falsos.

#### Reenviar solicitud

La directiva `forward-request` reenvía la solicitud entrante al servicio de back-end especificado en el contexto de la solicitud. La URL del servicio de back-end se especifica en la configuración de la API y se puede cambiar con la directiva de configuración del servicio back-end.

Quitar esta directiva hace que la solicitud no se reenvíe al servicio back-end. Las directivas de la sección outbound se evalúan inmediatamente después de que finaliza correctamente la ejecución de las directivas de la sección inbound.

```xml
<forward-request timeout="time in seconds" follow-redirects="true | false"/>
```

#### Limitar simultaneidad

La directiva `limit-concurrency` impide que las directivas incluidas se ejecuten más del número especificado de solicitudes a la vez. Cuando las solicitudes superan ese número, las nuevas solicitudes fallan inmediatamente con un código de estado _429 Too Many Requests_.

```xml
<limit-concurrency key="expression" max-count="number">
        <!— instrucciones de directiva anidadas -->
</limit-concurrency>
```

#### Registrar en Event Hub

La directiva `log-to-eventhub` envía mensajes en el formato especificado a un Event Hub definido por una entidad Logger. Como su nombre indica, la directiva se usa para guardar información de contexto de solicitud o respuesta seleccionada para análisis en línea o sin conexión.

```xml
<log-to-eventhub logger-id="id de la entidad logger" partition-id="índice de la partición donde se envían los mensajes" partition-key="valor usado para la asignación de partición">
  Expresión que devuelve una cadena para registrar
</log-to-eventhub>
```

#### Respuesta simulada

La directiva `mock-response`, como su nombre indica, se usa para simular API y operaciones. Anula la ejecución normal de la canalización y devuelve una respuesta simulada al autor de la llamada. La directiva siempre intenta devolver respuestas con la mayor fidelidad posible. Da preferencia a ejemplos de contenido de respuesta, cuando están disponibles. Genera respuestas de ejemplo a partir de esquemas, cuando se proporcionan esquemas y no hay ejemplos. Si no se encuentran ejemplos ni esquemas, se devuelven respuestas sin contenido.

```xml
<mock-response status-code="code" content-type="media type"/>
```

#### Retry

La directiva `retry` ejecuta sus directivas secundarias una vez y luego reintenta su ejecución hasta que la `condition` de reintento sea `false` o se agote el `count` de reintentos.

```xml
<retry
    condition="boolean expression or literal"
    count="number of retry attempts"
    interval="retry interval in seconds"
    max-interval="maximum retry interval in seconds"
    delta="retry interval delta in seconds"
    first-fast-retry="boolean expression or literal">
        <!-- One or more child policies. No restrictions -->
</retry>
```

#### Devolver respuesta

La directiva `return-response` anula la ejecución de la canalización y devuelve una respuesta predeterminada o personalizada al autor de la llamada. La respuesta predeterminada es `200 OK` sin cuerpo. La respuesta personalizada puede especificarse mediante una variable de contexto o instrucciones de directiva. Cuando se proporcionan ambas, la instrucción de directiva modifica la variable de contexto antes de devolverse al llamador.

```xml
<return-response response-variable-name="existing context variable">
  <set-header/>
  <set-body/>
  <set-status/>
</return-response>
```

#### Otros recursos

- Visite [API Management policies](https://learn.microsoft.com/en-us/azure/api-management/api-management-policies) para ver más ejemplos de directivas.
- [Manejo de errores en directivas de API Management](https://learn.microsoft.com/en-us/azure/api-management/api-management-error-handling-policies)

### Protección de API mediante suscripciones

Al publicar API mediante API Management, es fácil y habitual proteger el acceso a esas API mediante claves de suscripción. Los desarrolladores que necesiten consumir las API publicadas deben incluir una clave de suscripción válida en las solicitudes HTTP cuando llamen a esas API. La puerta de enlace de API Management rechaza las llamadas sin clave de suscripción y esas llamadas no se reenvían a los servicios back-end.

Para obtener una clave de suscripción para acceder a las API, se necesita una suscripción. Una suscripción es esencialmente un contenedor con nombre para un par de claves de suscripción. Los desarrolladores que necesiten consumir las API publicadas pueden obtener suscripciones. Y no necesitan aprobación de los publicadores de API. Los publicadores de API también pueden crear suscripciones directamente para consumidores de API.

:information_source: API Management también admite otros mecanismos para proteger el acceso a las API, incluidos: OAuth2.0, certificados de cliente y listas de IP permitidas.

#### Suscripciones y claves

Una clave de suscripción es una clave única generada automáticamente que se puede pasar en los encabezados de la solicitud del cliente o como parámetro de cadena de consulta. La clave está directamente relacionada con una suscripción, que puede tener alcance en diferentes áreas. Las suscripciones le proporcionan un control granular sobre permisos y directivas.

Los tres ámbitos de suscripción principales son:

| Ámbito     | Detalles                                                                                                                                                                                                                                                                    |
| ---------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| All APIs   | Se aplica a cada API accesible desde la puerta de enlace. Este ámbito proporciona acceso a todas las API configuradas en el servicio API Management.                                                                                                                       |
| Single API | Este ámbito se aplica a una sola API importada y a todos sus puntos de conexión. Permite un control de acceso detallado y puede usarse para limitar el acceso a API específicas dentro del servicio API Management.                                                        |
| Product    | Un producto es una colección de una o más API que configura en API Management. Puede asignar API a más de un producto. Los productos pueden tener diferentes reglas de acceso, cuotas de uso y términos de uso. Este ámbito se aplica a un producto específico dentro de API Management. |

Las aplicaciones que llaman a una API protegida deben incluir la clave en cada solicitud.

Puede regenerar estas claves de suscripción en cualquier momento, por ejemplo, si sospecha que una clave se compartió con usuarios no autorizados.

![Imagen que muestra la pantalla de suscripciones.](https://learn.microsoft.com/en-us/training/wwl-azure/explore-api-management/media/subscription-keys.png)

Cada suscripción tiene dos claves, una primaria y otra secundaria. Tener dos claves facilita la regeneración cuando sea necesario. Por ejemplo, si desea cambiar la clave primaria y evitar tiempo de inactividad, use la clave secundaria en sus aplicaciones.

En productos donde las suscripciones están habilitadas, los clientes deben proporcionar una clave al llamar a las API de ese producto. Los desarrolladores pueden obtener una clave enviando una solicitud de suscripción. Si aprueba la solicitud, debe enviarles la clave de suscripción de forma segura, por ejemplo, en un mensaje cifrado. Este paso es una parte central del flujo de trabajo de API Management.

#### Llamar a una API con la clave de suscripción

Las aplicaciones deben incluir una clave válida en todas las solicitudes HTTP cuando llaman a puntos de conexión de API protegidos por suscripción. Las claves pueden enviarse en el encabezado de la solicitud o como cadena de consulta en la URL.

El nombre de encabezado predeterminado es **Ocp-Apim-Subscription-Key** y la cadena de consulta predeterminada es **subscription-key**.

Para probar sus llamadas de API, puede usar el portal para desarrolladores o herramientas de línea de comandos, como curl. Aquí hay un ejemplo de una solicitud `GET` usando el portal para desarrolladores, que muestra el encabezado de clave de suscripción:

![Llamada a la API desde el portal para desarrolladores](https://learn.microsoft.com/en-us/training/wwl-azure/explore-api-management/media/key-header-portal.png)

Así puede pasar una clave en el encabezado de la solicitud usando **curl**:

```sh
curl --header "Ocp-Apim-Subscription-Key: <key string>" https://<apim gateway>.azure-api.net/api/path
```

Aquí hay un comando curl de ejemplo que pasa una clave en la URL como cadena de consulta:

```sh
curl https://<apim gateway>.azure-api.net/api/path?subscription-key=<key string>
```

Si la clave no se pasa en el encabezado o como cadena de consulta en la URL, obtendrá una respuesta **401 Acceso denegado** de la puerta de enlace de API.

### Protección de API mediante certificados

Los certificados pueden usarse para proporcionar autenticación mutua de Transport Layer Security (TLS) entre el cliente y la puerta de enlace de API. Puede configurar la puerta de enlace de API Management para permitir solo solicitudes con certificados que contengan una huella digital específica. La autorización a nivel de puerta de enlace se administra mediante directivas de entrada.

#### Autenticación de cliente mediante Transport Layer Security

Con autenticación de cliente TLS, la puerta de enlace de API Management puede inspeccionar el certificado contenido en la solicitud del cliente y comprobar propiedades como:

| Propiedad                  | Descripción                                                |
| -------------------------- | ---------------------------------------------------------- |
| Certificate Authority (CA) | Permitir solo certificados firmados por una CA específica  |
| Thumbprint                 | Permitir certificados que contengan una huella específica  |
| Subject                    | Permitir solo certificados con un asunto específico        |
| Expiration Date            | No permitir certificados expirados                         |

Estas propiedades no son mutuamente excluyentes y pueden combinarse para formar sus propios requisitos de directiva. Por ejemplo, puede especificar que el certificado enviado en la solicitud esté firmado y no esté expirado.

Los certificados de cliente se firman para garantizar que no sean manipulados. Cuando un socio le envía un certificado, verifique que provenga de él y no de un impostor. Hay dos formas comunes de verificar un certificado:

- Compruebe quién emitió el certificado. Si el emisor es una entidad de certificación en la que confía, puede usar el certificado. Puede configurar las entidades de certificación de confianza en Azure Portal para automatizar este proceso.
- Si el certificado lo emite el socio, verifique que provenga de él. Por ejemplo, si entrega el certificado en persona, puede estar seguro de su autenticidad. Estos se conocen como certificados autofirmados.

#### Aceptación de certificados de cliente en el nivel Consumption

El nivel Consumption de API Management está diseñado para ajustarse a principios de diseño serverless. Si compila sus API con tecnologías serverless, como Azure Functions, este nivel es una buena opción. En el nivel Consumption, debe habilitar explícitamente el uso de certificados de cliente, lo cual puede hacer en la página **Custom domains**. Este paso no es necesario en otros niveles.

![Configurar la puerta de enlace para solicitar certificados](https://learn.microsoft.com/en-us/training/wwl-azure/explore-api-management/media/configure-request-certificates.png)

#### Directivas de autorización de certificados

Cree estas directivas en el archivo de directivas de procesamiento de entrada dentro de la puerta de enlace de API Management:

![Botón de directiva de procesamiento de entrada](https://learn.microsoft.com/en-us/training/wwl-azure/explore-api-management/media/inbound-policy.png)

##### Comprobar la huella digital de un certificado de cliente

Todo certificado de cliente incluye una huella digital (thumbprint), que es un hash calculado a partir de otras propiedades del certificado. La huella digital garantiza que los valores del certificado no se hayan alterado desde que la entidad de certificación lo emitió. Puede comprobar la huella digital en su directiva. El siguiente ejemplo comprueba la huella digital del certificado enviado en la solicitud:

```xml
<choose>
    <when condition="@(context.Request.Certificate == null || context.Request.Certificate.Thumbprint != "desired-thumbprint")" >
        <return-response>
            <set-status code="403" reason="Invalid client certificate" />
        </return-response>
    </when>
</choose>
```

##### Comprobar la huella digital con certificados cargados en API Management

En el ejemplo anterior, solo funcionaría una huella digital, por lo que solo se validaría un certificado. Normalmente, cada cliente o empresa asociada enviaría un certificado distinto con una huella diferente. Para admitir este escenario, obtenga los certificados de sus socios y use la página **Client certificates** en Azure portal para cargarlos en el recurso de API Management. Después agregue este código a su directiva:

```xml
<choose>
    <when condition="@(context.Request.Certificate == null || !context.Request.Certificate.Verify()  || !context.Deployment.Certificates.Any(c => c.Value.Thumbprint == context.Request.Certificate.Thumbprint))" >
        <return-response>
            <set-status code="403" reason="Invalid client certificate" />
        </return-response>
    </when>
</choose>
```

##### Comprobar el emisor y el asunto de un certificado de cliente

Este ejemplo comprueba el emisor y el asunto del certificado pasado en la solicitud:

```xml
<choose>
    <when condition="@(context.Request.Certificate == null || context.Request.Certificate.Issuer != "trusted-issuer" || context.Request.Certificate.SubjectName.Name != "expected-subject-name")" >
        <return-response>
            <set-status code="403" reason="Invalid client certificate" />
        </return-response>
    </when>
</choose>
```

---

<!-- ===== Azure Event Grid ===== -->

# Azure Event Grid

## Información general

Azure Event Grid está profundamente integrado con servicios de Azure y puede integrarse con servicios de terceros. Simplifica el consumo de eventos y reduce costos al eliminar la necesidad de sondeo constante. Event Grid enruta de forma eficiente y confiable eventos de recursos de Azure y no Azure, y los distribuye a puntos de conexión de suscriptores registrados.

### Exploración de Azure Event Grid

Azure Event Grid es un servicio de distribución de mensajes Pub Sub, totalmente administrado y altamente escalable, que ofrece patrones flexibles de consumo de mensajes mediante los protocolos Hypertext Transfer Protocol (HTTP) y Message Queuing Telemetry Transport (MQTT). Con Azure Event Grid, puede crear canalizaciones de datos con datos de dispositivos, integrar aplicaciones y crear arquitecturas serverless controladas por eventos. Event Grid permite a los clientes publicar y suscribirse a mensajes a través de los protocolos MQTT v3.1.1 y v5.0 para admitir soluciones de Internet of Things (IoT). A través de HTTP, Event Grid le permite crear soluciones impulsadas por eventos donde un servicio publicador anuncia cambios de estado de su sistema (eventos) a aplicaciones suscriptoras. Event Grid puede configurarse para enviar eventos a suscriptores (entrega push) o los suscriptores pueden conectarse a Event Grid para leer eventos (entrega pull). Event Grid admite la especificación CloudEvents 1.0 para proporcionar interoperabilidad entre sistemas.

#### Conceptos de Azure Event Grid

Hay varios conceptos en Azure Event Grid que necesita comprender para empezar.

##### Publicadores

Un publicador es la aplicación que envía eventos a Event Grid. Puede ser la misma aplicación donde se originaron los eventos, es decir, el origen del evento. Los servicios de Azure publican eventos en Event Grid para anunciar una ocurrencia en su servicio. También puede publicar eventos desde su propia aplicación. Las organizaciones que hospedan servicios fuera de Azure también pueden publicar eventos a través de Event Grid.

Un _partner_ es un tipo de publicador que envía eventos desde su sistema para ponerlos a disposición de los clientes de Azure. Los partners no solo pueden publicar eventos en Azure Event Grid, sino que también pueden recibir eventos desde él. Estas capacidades están habilitadas mediante la característica Partner Events.

##### Eventos y CloudEvents

Un evento es la cantidad más pequeña de información que describe completamente algo que sucedió en el sistema. Cada evento tiene información común como el `origen` del evento, la `hora` en que tuvo lugar el evento y un identificador único. Cada evento también tiene información específica que solo es relevante para el tipo específico de evento.

Event Grid cumple con la especificación de estándar abierto [CloudEvents 1.0](https://github.com/cloudevents/spec) de Cloud Native Computing Foundation usando el [enlace de protocolo HTTP](https://github.com/cloudevents/spec/blob/v1.0.2/cloudevents/bindings/http-protocol-binding.md) con [formato JSON](https://github.com/cloudevents/spec/blob/v1.0.2/cloudevents/formats/json-format.md). Esto significa que sus soluciones publican y consumen mensajes de eventos usando un formato como el siguiente ejemplo:

```json
{
  "specversion": "1.0",
  "type": "com.yourcompany.order.created",
  "source": "https://yourcompany.com/orders/",
  "subject": "O-28964",
  "id": "A234-1234-1234",
  "time": "2018-04-05T17:31:00Z",
  "comexampleextension1": "value",
  "comexampleothervalue": 5,
  "datacontenttype": "application/json",
  "data": {
    "orderId": "O-28964",
    "URL": "https://com.yourcompany/orders/O-28964"
  }
}
```

El tamaño máximo permitido para un evento es de 1 MB. Los eventos de más de 64 KB se cobran en incrementos de 64 KB.

##### Orígenes de eventos

Un origen de evento es donde ocurre el evento. Cada origen de evento está relacionado con uno o más tipos de eventos. Por ejemplo, Azure Storage es el origen de eventos para los eventos de blob creado. IoT Hub es el origen de eventos para eventos de dispositivo creado. Su aplicación es el origen de eventos para eventos personalizados que usted define. Los orígenes de eventos son responsables de enviar eventos a Event Grid.

##### Temas

Un tema contiene los eventos que se han publicado en Event Grid. Normalmente se usa un recurso de tema para una colección de eventos relacionados. Para responder a ciertos tipos de eventos, los suscriptores (un servicio de Azure u otras aplicaciones) deciden a qué temas suscribirse. Hay varios tipos de temas: temas personalizados, temas del sistema y temas de socios.

**Los temas del sistema** son temas integrados proporcionados por servicios de Azure. No ve temas del sistema en su suscripción de Azure porque el editor es propietario de los temas, pero puede suscribirse a ellos. Para suscribirse, proporciona información sobre el recurso del que desea recibir eventos. Siempre que tenga acceso al recurso, puede suscribirse a sus eventos.

**Los temas personalizados** son temas de aplicaciones y terceros. Cuando crea o se le asigna acceso a un tema personalizado, ve ese tema personalizado en su suscripción.

**Los temas de socios** son un tipo de tema utilizado para suscribirse a eventos publicados por un socio. La característica que habilita este tipo de integración se denomina Partner Events. A través de esa integración, obtiene un tema de socio donde se ponen a disposición eventos de un sistema asociado. Una vez que tiene un tema de socio, crea una suscripción de evento como lo haría para cualquier otro tipo de tema.

##### Suscripciones de eventos

Una suscripción indica a Event Grid qué eventos de un tema le interesa recibir. Al crear la suscripción, se proporciona un punto de conexión para controlar el evento. Puede filtrar los eventos que se envían al punto de conexión. Puede filtrar por tipo de evento o patrón de asunto. Establezca una expiración para las suscripciones de eventos que solo se necesitan durante un tiempo limitado y no desea preocuparse por limpiarlas.

##### Controladores de eventos

Desde la perspectiva de Event Grid, un controlador de eventos es el lugar donde se envía el evento. El controlador realiza alguna acción adicional para procesar el evento. Event Grid admite varios tipos de controladores. Puede usar un servicio de Azure admitido o su propio webhook como controlador. Dependiendo del tipo de controlador, Event Grid sigue diferentes mecanismos para garantizar la entrega del evento. Para controladores de webhook HTTP, el evento se reintenta hasta que el controlador devuelve un código de estado `200 – OK`. Para la cola de Azure Storage, los eventos se reintentan hasta que el servicio Queue procesa correctamente el envío de mensajes a la cola.

##### Seguridad

Event Grid proporciona seguridad para suscribirse a temas y al publicar eventos en temas. Al suscribirse, debe tener permisos adecuados en el tema de Event Grid. Si utiliza entrega de inserción, el controlador de eventos es un servicio de Azure y se usa una identidad administrada para autenticar Event Grid, la identidad administrada debe tener un rol RBAC apropiado. Por ejemplo, si envía eventos a Event Hubs, la identidad administrada utilizada en la suscripción de eventos debe ser miembro del rol Event Hubs Data Sender.

### Descripción de los esquemas de eventos

Azure Event Grid admite dos tipos de esquemas de eventos: esquema de eventos de Event Grid y esquema de eventos de nube. Los eventos constan de un conjunto de cuatro propiedades de cadena requeridas. Las propiedades son comunes a todos los eventos de cualquier editor.

El objeto de datos tiene propiedades específicas de cada editor. Para temas del sistema, estas propiedades son específicas del proveedor de recursos, como Azure Storage o Azure Event Hubs.

Los orígenes de eventos envían eventos a Azure Event Grid en una matriz, que puede tener varios objetos de evento. Al publicar eventos en un tema de Event Grid, la matriz puede tener un tamaño total de hasta 1 MB. Cada evento en la matriz está limitado a 1 MB. Si un evento o la matriz es mayor que los límites de tamaño, recibe la respuesta `413 Payload Too Large`. Las operaciones se cobran en incrementos de 64 KB. Entonces, los eventos de más de 64 KB incurren en cargos de operaciones como si fueran múltiples eventos. Por ejemplo, un evento de 130 KB incurriría en cargos como si fueran tres eventos separados.

Event Grid envía los eventos a los suscriptores en una matriz que tiene un solo evento. Puede encontrar el esquema JSON para el evento de Event Grid y la carga de datos de cada editor de Azure en el [almacén de esquemas de eventos](https://github.com/Azure/azure-rest-api-specs/tree/master/specification/eventgrid/data-plane).

#### Esquema de evento

A continuación se muestra un ejemplo de las propiedades utilizadas por todos los publicadores de eventos:

```ts
[
  {
    "topic": string,
    "subject": string,
    "id": string,
    "eventType": string,
    "eventTime": string,
    "data":{
      object-unique-to-each-publisher
    },
    "dataVersion": string,
    "metadataVersion": string
  }
]
```

#### Propiedades del evento

Todos los eventos tienen los siguientes datos de nivel superior iguales:

| Propiedad       | Tipo   | Obligatorio                                                                                                                                              | Descripción                                                                                                                          |
| --------------- | ------ | -------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------ |
| topic           | string | No. Si no se incluye, Event Grid lo agrega al evento. Si se incluye, debe coincidir exactamente con el identificador de Azure Resource Manager del tema de Event Grid. | Ruta completa del recurso al origen del evento. Este campo no es escribible. Event Grid proporciona este valor.                     |
| subject         | string | Sí                                                                                                                                                       | Ruta al asunto del evento definida por el publicador.                                                                                |
| eventType       | string | Sí                                                                                                                                                       | Uno de los tipos de evento registrados para este origen de eventos.                                                                  |
| eventTime       | string | Sí                                                                                                                                                       | Hora en que se genera el evento según la hora UTC del proveedor.                                                                     |
| id              | string | Sí                                                                                                                                                       | Identificador único del evento.                                                                                                      |
| data            | object | No                                                                                                                                                       | Datos del evento específicos del proveedor del recurso.                                                                              |
| dataVersion     | string | No. Si no se incluye, se agrega con un valor vacío.                                                                                                     | Versión del esquema del objeto de datos. El publicador define la versión del esquema.                                               |
| metadataVersion | string | No. Si no se incluye, Event Grid lo agrega al evento. Si se incluye, debe coincidir exactamente con `metadataVersion` del esquema de Event Grid (actualmente, solo `1`). | Versión del esquema de los metadatos del evento. Event Grid define el esquema de las propiedades de nivel superior. Event Grid proporciona este valor. |

Para temas personalizados, el publicador del evento determina el objeto de datos. Los datos de nivel superior deben tener los mismos campos que los eventos estándar definidos por recursos.

Al publicar eventos en temas personalizados, cree asuntos para los eventos que faciliten a los suscriptores saber si están interesados en el evento. Los suscriptores usan el asunto para filtrar y enrutar eventos. Considere proporcionar la ruta donde ocurrió el evento, para que los suscriptores puedan filtrar por segmentos de esa ruta. La ruta permite a los suscriptores filtrar eventos de forma más amplia o más específica. Por ejemplo, si proporciona una ruta de tres segmentos como `/A/B/C` en el asunto, los suscriptores pueden filtrar por el primer segmento `/A` para obtener un conjunto amplio de eventos. Esos suscriptores obtienen eventos con asuntos como `/A/B/C` o `/A/D/E`. Otros suscriptores pueden filtrar por `/A/B` para obtener un conjunto más reducido de eventos.

A veces su asunto necesita más detalle sobre lo que ocurrió. Por ejemplo, el publicador **Storage Accounts** proporciona el asunto `/blobServices/default/containers/<container-name>/blobs/<file>` cuando se agrega un archivo a un contenedor. Un suscriptor podría filtrar por la ruta `/blobServices/default/containers/testcontainer` para obtener todos los eventos de ese contenedor, pero no de otros contenedores de la cuenta de almacenamiento. Un suscriptor también podría filtrar o enrutar por el sufijo `.txt` para trabajar solo con archivos de texto.

#### Esquema de eventos en la nube

Además de su esquema de eventos predeterminado, Azure Event Grid admite de forma nativa eventos en la implementación JSON de CloudEvents v1.0 y enlace de protocolo HTTP. CloudEvents es una especificación abierta para describir datos de eventos.

CloudEvents simplifica la interoperabilidad al proporcionar un esquema de evento común para publicar y consumir eventos basados en la nube. Este esquema permite herramientas uniformes, formas estándar de enrutamiento y manejo de eventos, y formas universales de deserializar el esquema de evento externo. Con un esquema común, puede integrar más fácilmente el trabajo entre plataformas.

Aquí hay un ejemplo de un evento de Azure Blob Storage en formato CloudEvents:

```json
{
  "specversion": "1.0",
  "type": "Microsoft.Storage.BlobCreated",
  "source": "/subscriptions/{subscription-id}/resourceGroups/{resource-group}/providers/Microsoft.Storage/storageAccounts/{storage-account}",
  "id": "9aeb0fdf-c01e-0131-0922-9eb54906e209",
  "time": "2019-11-18T15:13:39.4589254Z",
  "subject": "blobServices/default/containers/{storage-container}/blobs/{new-file}",
  "dataschema": "#",
  "data": {
    "api": "PutBlockList",
    "clientRequestId": "4c5dd7fb-2c48-4a27-bb30-5361b5de920a",
    "requestId": "9aeb0fdf-c01e-0131-0922-9eb549000000",
    "eTag": "0x8D76C39E4407333",
    "contentType": "image/png",
    "contentLength": 30699,
    "blobType": "BlockBlob",
    "url": "https://gridtesting.blob.core.windows.net/testcontainer/{new-file}",
    "sequencer": "000000000000000000000000000099240000000000c41c18",
    "storageDiagnostics": {
      "batchId": "681fe319-3006-00a8-0022-9e7cde000000"
    }
  }
}
```

Una descripción detallada de los campos disponibles, sus tipos y definiciones en CloudEvents v1.0 está [disponible aquí](https://github.com/cloudevents/spec/blob/v1.0/spec.md#required-attributes).

Los valores de los encabezados para los eventos entregados en el esquema de CloudEvents y el esquema de Event Grid son los mismos excepto para `content-type`. Para el esquema de CloudEvents, ese valor de encabezado es `"content-type":"application/cloudevents+json; charset=utf-8"`. Para el esquema de Event Grid, ese valor de encabezado es `"content-type":"application/json; charset=utf-8"`.

Puede usar Event Grid tanto para la entrada como para la salida de eventos en el esquema CloudEvents. Puede usar CloudEvents para eventos del sistema, como eventos de Blob Storage y eventos de IoT Hub, y eventos personalizados. También puede transformar esos eventos en tránsito de un lado a otro.

### Exploración de la durabilidad de la entrega de eventos

Event Grid proporciona entrega duradera. Intenta entregar cada evento al menos una vez para cada suscripción coincidente de forma inmediata. Si el punto de conexión de un suscriptor no confirma la recepción de un evento o si hay un error, Event Grid reintenta la entrega según una programación de reintentos y una directiva de reintentos fijas. De forma predeterminada, Event Grid entrega un evento a la vez al suscriptor, y la carga es una matriz con un solo evento.

:information_source: Event Grid no garantiza el orden de entrega de eventos, por lo que los suscriptores pueden recibirlos desordenados.

#### Programación de reintentos

Cuando Event Grid recibe un error por un intento de entrega de evento, Event Grid decide si debe: reintentar la entrega, enviar el evento a la cola de mensajes no enviados o descartarlo según el tipo de error.

Si el error devuelto por el punto de conexión suscrito es un error relacionado con la configuración que no se puede corregir con reintentos, Event Grid: realizará el envío a la cola de mensajes no enviados del evento o descartará el evento si la cola de mensajes no enviados no está configurada.

La siguiente tabla describe los tipos de puntos de conexión y errores para los que no se produce el reintento:

| Tipo de punto de conexión | Códigos de error                                                              |
| --------------- | ------------------------------------------------------------------------ |
| Recursos de Azure | 400 (Solicitud incorrecta), 413 (Entidad de solicitud demasiado grande)                     |
| Webhook           | 400 (Solicitud incorrecta), 413 (Entidad de solicitud demasiado grande), 401 (No autorizado) |

:bangbang: Si la cola de mensajes no enviados no está configurada para un punto de conexión, los eventos se descartarán cuando se produzcan los errores anteriores. Considere configurar la cola de mensajes no enviados si no desea que estos tipos de eventos se descarten.

Si el error devuelto por el punto de conexión suscrito no está entre la lista anterior, Event Grid espera 30 segundos para obtener una respuesta después de entregar un mensaje. Después de 30 segundos, si el punto de conexión no respondió, el mensaje se pone en cola para reintento. Event Grid usa una directiva de reintento con retroceso exponencial para la entrega de eventos.

Si el punto de conexión responde en 3 minutos, Event Grid intenta quitar el evento de la cola de reintentos en función del mejor esfuerzo, pero aún se pueden recibir duplicados. Event Grid agrega una pequeña aleatorización a todos los pasos de reintento y puede omitir oportunistamente ciertos reintentos si un punto de conexión tiene un estado incorrecto de forma constante, está inactivo durante un período prolongado o parece estar saturado.

#### Directiva de reintentos

Puede personalizar la directiva de reintentos al crear una suscripción de eventos con las dos configuraciones siguientes. Un evento se descarta si se alcanza alguno de los límites de la directiva de reintentos.

- **Número máximo de intentos**: El valor debe ser un entero entre 1 y 30. El valor predeterminado es 30.
- **Período de vida del evento (TTL)**: El valor debe ser un entero entre 1 y 1440. El valor predeterminado es 1440 minutos.

El siguiente ejemplo muestra cómo establecer el número máximo de intentos en 18 con la CLI de Azure.

```sh
az eventgrid event-subscription create \
  -g gridResourceGroup \
  --topic-name <topic_name> \
  --name <event_subscription_name> \
  --endpoint <endpoint_URL> \
  --max-delivery-attempts 18
```

#### Procesamiento por lotes de salida

Puede configurar Event Grid para agrupar en lotes los eventos de entrega para mejorar el rendimiento HTTP en escenarios de alto rendimiento. El procesamiento por lotes está desactivado de forma predeterminada y se puede activar por suscripción a través del portal, la CLI, PowerShell o los SDK.

La entrega por lotes tiene dos configuraciones:

- **Número máximo de eventos por lote**: Número máximo de eventos que Event Grid entrega por lote. No se superará este número, pero se pueden entregar menos eventos si no hay otros disponibles en el momento de la publicación. Event Grid no retrasa los eventos para crear un lote si hay menos eventos disponibles. Debe estar entre 1 y 5000.
- **Tamaño de lote preferido en kilobytes**: Límite máximo objetivo para el tamaño del lote en kilobytes. De forma similar a los eventos máximos, el tamaño del lote puede ser menor si no hay más eventos disponibles en el momento de la publicación. Es posible que un lote sea mayor que el tamaño de lote preferido si un solo evento es mayor que el tamaño preferido. Por ejemplo, si el tamaño preferido es 4 KB y se envía un evento de 10 KB a Event Grid, el evento de 10 KB se entregará en su propio lote en lugar de descartarse.

#### Entrega retrasada

A medida que un punto de conexión experimenta errores de entrega, Event Grid comienza a retrasar la entrega y el reintento de eventos a ese punto de conexión. Por ejemplo, si los primeros 10 eventos publicados en un punto de conexión fallan, Event Grid asume que el punto de conexión tiene problemas y retrasará todos los reintentos posteriores y las nuevas entregas durante algún tiempo, en algunos casos hasta varias horas.

El propósito funcional de la entrega retrasada es proteger los puntos de conexión con estado incorrecto y el sistema de Event Grid. Sin el retroceso y el retraso de la entrega a los puntos de conexión con estado incorrecto, la directiva de reintentos y las capacidades de volumen de Event Grid pueden saturar fácilmente un sistema.

#### Eventos de la cola de mensajes no enviados

Cuando Event Grid no puede entregar un evento dentro de un período de tiempo determinado o después de intentar entregarlo un número de veces, puede enviar el evento no entregado a una cuenta de almacenamiento. Este proceso se conoce como **dead-lettering**. Event Grid envía un evento a dead-letter cuando se cumple **una de las siguientes** condiciones.

- El evento no se entrega dentro del período de **período de vida**.
- El **número de intentos** de entrega del evento supera el límite.

Si se cumple alguna de las condiciones, el evento se descarta o se envía a la cola de mensajes no enviados. De forma predeterminada, Event Grid no activa el envío a la cola de mensajes no enviados. Para habilitarlo, debe especificar una cuenta de almacenamiento para conservar eventos no entregados al crear la suscripción de eventos. Usted extrae eventos desde esa cuenta de almacenamiento para resolver entregas.

Si Event Grid recibe un código de respuesta 400 (Solicitud incorrecta) o 413 (Entidad de solicitud demasiado grande), programa inmediatamente el evento para enviarlo a la cola de mensajes no enviados. Estos códigos de respuesta indican que la entrega del evento falló.

Hay un retraso de cinco minutos entre el último intento de entrega de un evento y la entrega a la ubicación de la cola de mensajes no enviados. Este retraso está diseñado para reducir el número de operaciones de Blob Storage. Si la ubicación de la cola de mensajes no enviados no está disponible durante cuatro horas, el evento se descarta.

#### Propiedades de entrega personalizadas

Las suscripciones de eventos permiten configurar encabezados HTTP que se incluyen en los eventos entregados. Esta funcionalidad permite establecer encabezados personalizados que son necesarios para un destino. Puede establecer hasta 10 encabezados al crear una suscripción de eventos. Cada valor de encabezado no debe ser mayor de 4096 bytes. Puede establecer encabezados personalizados en los eventos que se entregan a los siguientes destinos:

- Webhooks
- Azure Service Bus topics and queues
- Azure Event Hubs
- Relay Conexiones híbridas

Antes de establecer la ubicación de la cola de mensajes no enviados, debe tener una cuenta de almacenamiento con un contenedor. Proporcione el punto de conexión de este contenedor al crear la suscripción de eventos.

### Control del acceso a los eventos

Azure Event Grid permite controlar el nivel de acceso otorgado a diferentes usuarios para realizar diversas operaciones de administración, como enumerar suscripciones de eventos, crear nuevas y generar claves. Event Grid usa el control de acceso basado en roles de Azure (RBAC de Azure).

#### Roles integrados

Event Grid proporciona los siguientes roles integrados:

| Rol                                 | Descripción                                               |
| ----------------------------------- | --------------------------------------------------------- |
| Lector de suscripciones de Event Grid      | Le permite leer las suscripciones de eventos de Event Grid.             |
| Colaborador de suscripciones de Event Grid | Le permite administrar las operaciones de suscripción de eventos de Event Grid. |
| Colaborador de Event Grid              | Le permite crear y administrar recursos de Event Grid.          |
| Remitente de datos de Event Grid              | Le permite enviar eventos a temas de Event Grid.                |

Los roles Lector de suscripciones de Event Grid y Colaborador de suscripciones de Event Grid son para administrar suscripciones de eventos. Son importantes al implementar dominios de eventos porque dan a los usuarios los permisos que necesitan para suscribirse a temas en el dominio de eventos. Estos roles se centran en las suscripciones de eventos y no conceden acceso para acciones como la creación de temas.

El rol Colaborador de Event Grid le permite crear y administrar recursos de Event Grid.

#### Permisos para suscripciones de eventos

Si usa un controlador de eventos que no es un webhook (como un centro de eventos o un almacenamiento de colas), necesita acceso de escritura a ese recurso. Esta comprobación de permisos evita que un usuario no autorizado envíe eventos al recurso.

Debe tener el permiso **Microsoft.EventGrid/EventSubscriptions/Write** en el recurso que es el origen del evento. Necesita este permiso porque está escribiendo una nueva suscripción en el ámbito del recurso. El recurso necesario difiere según si se suscribe a un tema del sistema o a un tema personalizado. Ambos tipos se describen en esta sección.

| Tipo de tema  | Descripción                                                                                                                                                                                                                                                               |
| ------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| Temas del sistema | Necesitan permiso para escribir una nueva suscripción de eventos en el ámbito del recurso que publica el evento. El formato del recurso es: `/subscriptions/{subscription-id}/resourceGroups/{resource-group-name}/providers/{resource-provider}/{resource-type}/{resource-name}` |
| Temas personalizados | Necesitan permiso para escribir una nueva suscripción de eventos en el ámbito del tema de Event Grid. El formato del recurso es: `/subscriptions/{subscription-id}/resourceGroups/{resource-group-name}/providers/Microsoft.EventGrid/topics/{topic-name}`                          |

### Recepción de eventos mediante webhooks

Los webhooks son una de las muchas formas de recibir eventos de Azure Event Grid. Cuando un nuevo evento está listo, el servicio Event Grid envía una solicitud HTTP POST al punto de conexión configurado con el evento en el cuerpo de la solicitud.

Al igual que muchos otros servicios que admiten webhooks, Event Grid requiere que demuestre la propiedad del punto de conexión de webhook antes de empezar a entregar eventos a ese punto de conexión. Este requisito evita que un usuario malintencionado inunde el punto de conexión con eventos.

Cuando se usa cualquiera de los siguientes tres servicios de Azure, la infraestructura de Azure controla automáticamente esta validación:

- Azure Logic Apps with Event Grid Connector
- Azure Automation via webhook
- Azure Functions with Event Grid Trigger

#### Validación del punto de conexión con eventos de Event Grid

Si usa cualquier otro tipo de punto de conexión, como una función de Azure basada en desencadenador HTTP, el código del punto de conexión debe participar en un protocolo de enlace de validación con Event Grid. Event Grid admite dos formas de validar la suscripción.

- **Protocolo de enlace sincrónico**: En el momento de la creación de la suscripción de eventos, Event Grid envía un evento de validación de suscripción al punto de conexión. El esquema de este evento es similar a cualquier otro evento de Event Grid. La parte de datos de este evento incluye una propiedad `validationCode`. La aplicación verifica que la solicitud de validación es para una suscripción de eventos esperada y devuelve el código de validación en la respuesta de forma sincrónica. Este mecanismo de protocolo de enlace es compatible con todas las versiones de Event Grid.
- **Protocolo de enlace asincrónico**: En ciertos casos, no puede devolver el código de validación en la respuesta de forma sincrónica. Por ejemplo, si usa un servicio de terceros (como [Zapier](https://zapier.com/) o [IFTTT](https://ifttt.com/)), no puede responder mediante programación con el código de validación.

A partir de la versión 2018-05-01-preview, Event Grid admite un protocolo de enlace de validación manual. Si crea una suscripción de eventos con un SDK o herramienta que usa la versión de API 2018-05-01-preview o posterior, Event Grid envía una propiedad `validationUrl` en la parte de datos del evento de validación de suscripción. Para completar el protocolo de enlace, busque esa URL en los datos del evento y realice una solicitud GET a ella. Puede usar un cliente REST o el explorador web.

La URL proporcionada es válida durante 5 minutos. Durante ese tiempo, el estado de aprovisionamiento de la suscripción de eventos es `AwaitingManualAction`. Si no completa la validación manual dentro de 5 minutos, el estado de aprovisionamiento se establece en `Failed`. Debe crear nuevamente la suscripción de eventos antes de iniciar la validación manual.

Este mecanismo de autenticación también requiere que el punto de conexión del webhook devuelva un código de estado HTTP 200 para que sepa que el POST del evento de validación fue aceptado antes de poder pasar al modo de validación manual. En otras palabras, si el punto de conexión devuelve 200 pero no devuelve una respuesta de validación de forma sincrónica, el modo pasa a validación manual. Si se realiza un GET en la URL de validación dentro de 5 minutos, el protocolo de enlace de validación se considera exitoso.

:information_source: No se admite el uso de certificados autofirmados para la validación. Use un certificado firmado de una entidad de certificación (CA) comercial en su lugar.

### Filtrado de eventos

Al crear una suscripción de eventos, tiene tres opciones para filtrar:

- Tipos de eventos
- El asunto comienza o termina con
- Campos y operadores avanzados

#### Filtrado por tipo de evento

De forma predeterminada, todos los tipos de eventos para el origen del evento se envían al punto de conexión. Puede decidir enviar solo ciertos tipos de eventos al punto de conexión. Por ejemplo, puede recibir notificaciones de las actualizaciones de los recursos, pero no de otras operaciones como las eliminaciones. En ese caso, filtre por el tipo de evento `Microsoft.Resources.ResourceWriteSuccess`. Proporcione una matriz con los tipos de eventos o especifique `All` para obtener todos los tipos de eventos del origen del evento.

La sintaxis JSON para filtrar por tipo de evento es:

```json
"filter": {
  "includedEventTypes": [
    "Microsoft.Resources.ResourceWriteFailure",
    "Microsoft.Resources.ResourceWriteSuccess"
  ]
}
```

#### Filtrado por asunto

Para un filtrado simple por asunto, especifique un valor inicial o final para el asunto. Por ejemplo, puede especificar que el asunto termina en `.txt` para obtener solo los eventos relacionados con la carga de un archivo de texto en la cuenta de almacenamiento. O bien, puede filtrar el asunto que comienza con `/blobServices/default/containers/testcontainer` para obtener todos los eventos de ese contenedor pero no de otros contenedores de la cuenta de almacenamiento.

La sintaxis JSON para filtrar por asunto es:

```json
"filter": {
  "subjectBeginsWith": "/blobServices/default/containers/mycontainer/log",
  "subjectEndsWith": ".jpg"
}
```

#### Filtrado avanzado

Para filtrar por valores en los campos de datos y especificar el operador de comparación, use la opción de filtrado avanzado. En el filtrado avanzado, especifique:

- tipo de operador: el tipo de comparación.
- clave: el campo de los datos del evento que usa para el filtrado. Puede ser un número, un valor booleano o una cadena.
- valor o valores: el valor o los valores con los que se compara la clave.

La sintaxis JSON para usar filtros avanzados es:

```json
"filter": {
  "advancedFilters": [
    {
      "operatorType": "NumberGreaterThanOrEquals",
      "key": "Data.Key1",
      "value": 5
    },
    {
      "operatorType": "StringContains",
      "key": "Subject",
      "values": ["container1", "container2"]
    }
  ]
}
```

---

<!-- ===== Azure Event Hubs ===== -->

# Azure Event Hubs

## Información general

Azure Event Hubs es una plataforma de streaming de macrodatos y un servicio de ingesta de eventos. Puede recibir y procesar millones de eventos por segundo. Los datos enviados a un Event Hub pueden transformarse y almacenarse mediante cualquier proveedor de análisis en tiempo real o adaptadores de procesamiento por lotes/almacenamiento.

### Descripción de Azure Event Hubs

Azure Event Hubs es un servicio nativo de streaming de datos en la nube que puede transmitir millones de eventos por segundo, con baja latencia, desde cualquier origen hacia cualquier destino. Event Hubs es compatible con Apache Kafka. Le permite ejecutar cargas de trabajo de Kafka existentes sin cambios de código.

Con Event Hubs, puede ingerir, almacenar en búfer, almacenar y procesar su flujo en tiempo real para obtener conclusiones accionables. Event Hubs usa un modelo de consumidor particionado. Permite que varias aplicaciones procesen el flujo de forma simultánea y le permite controlar la velocidad de procesamiento. Event Hubs también se integra con Azure Functions para arquitecturas sin servidor.

Existe un amplio ecosistema para el protocolo estándar de la industria AMQP 1.0. Los SDK están disponibles en lenguajes como .NET, Java, Python y JavaScript, por lo que puede comenzar a procesar sus flujos desde Event Hubs. Todos los lenguajes cliente admitidos proporcionan integración de bajo nivel.

#### Capacidades clave

Obtenga información sobre las capacidades clave de Azure Event Hubs en las siguientes secciones.

##### Apache Kafka on Azure Event Hubs

Event Hubs es un motor de transmisión de eventos multiprotocolo que admite de forma nativa el protocolo AMQP (Advanced Message Queuing Protocol), Apache Kafka y protocolos HTTPS. Debido a que admite Apache Kafka, puede llevar cargas de trabajo de Kafka a Event Hubs sin realizar cambios de código. No necesita configurar, configurar o administrar sus propios clústeres de Kafka ni utilizar una oferta de Kafka como servicio que no sea nativa de Azure.

##### Schema Registry en Event Hubs

El Registro de esquemas de Azure en Event Hubs proporciona un repositorio centralizado para administrar esquemas de aplicaciones de transmisión de eventos. El Registro de esquemas viene gratis con cada espacio de nombres de Event Hubs. Se integra con sus aplicaciones de Kafka o aplicaciones basadas en SDK de Event Hubs.

##### Procesamiento en tiempo real de eventos de transmisión con Stream Analytics

Event Hubs se integra con Azure Stream Analytics para habilitar el procesamiento de transmisión en tiempo real. Con el editor sin código integrado, puede desarrollar un trabajo de Stream Analytics utilizando funcionalidad de arrastrar y soltar, sin escribir código.

Alternativamente, los desarrolladores pueden usar el lenguaje de consultas de Stream Analytics basado en SQL para realizar el procesamiento de transmisión en tiempo real y aprovechar una amplia gama de funciones para analizar datos de transmisión.

#### Conceptos clave

Event Hubs contiene los siguientes componentes clave:

- **Aplicaciones productoras**: Estas aplicaciones pueden ingerir datos en un centro de eventos utilizando SDK de Event Hubs o cualquier cliente productor de Kafka.
- **Espacio de nombres**: El contenedor de administración para uno o más centros de eventos o temas de Kafka. Las tareas de administración como asignar capacidad de transmisión, configurar seguridad de red y permitir recuperación ante desastres geográfica se manejan a nivel de espacio de nombres.
- **Event Hubs/Tema de Kafka**: En Event Hubs, puede organizar eventos en un centro de eventos o un tema de Kafka. Es un registro distribuido de solo anexión, que puede comprender una o más particiones.
- **Particiones**: Se utilizan para escalar un centro de eventos. Son como carriles en una autopista. Si necesita más rendimiento de transmisión, puede agregar más particiones.
- **Aplicaciones consumidoras**: Estas aplicaciones pueden consumir datos buscando a través del registro de eventos y manteniendo el desplazamiento del consumidor. Los consumidores pueden ser clientes consumidores de Kafka o clientes de SDK de Event Hubs.
- **Grupo de consumidores**: Este grupo lógico de instancias de consumidor lee datos de un centro de eventos o tema de Kafka. Permite que múltiples consumidores lean los mismos datos de transmisión en un centro de eventos de forma independiente a su propio ritmo y con sus propios desplazamientos.

### Exploración de la captura de Event Hubs

Azure Event Hubs le permite capturar automáticamente los datos de transmisión en Event Hubs en una cuenta de almacenamiento de Azure Blob o Azure Data Lake Storage de su elección, con la flexibilidad adicional de especificar un intervalo de tiempo o tamaño. La configuración de Capture es rápida, no hay costos administrativos para ejecutarlo y se escala automáticamente con las unidades de rendimiento de Event Hubs en el nivel estándar o unidades de procesamiento en el nivel premium.

![Imagen que muestra la captura de datos de Event Hubs en Azure Storage o Azure Data Lake Storage](https://learn.microsoft.com/en-us/training/wwl-azure/azure-event-hubs/media/event-hubs-capture.png)

Event Hubs Capture le permite procesar canalizaciones basadas en tiempo real y por lotes en la misma transmisión. Esto significa que puede construir soluciones que crecen con sus necesidades a lo largo del tiempo.

Event Hubs es un búfer duradero de retención de tiempo para la ingesta de telemetría, similar a un registro distribuido. La clave para el escalado en Event Hubs es el modelo de consumidor particionado. Cada partición es un segmento de datos independiente y se consume de forma independiente. Con el tiempo, estos datos envejecen en función del período de retención configurable. Como resultado, un centro de eventos dado nunca se llena demasiado.

Event Hubs Capture le permite especificar su propia cuenta de Azure Blob Storage y contenedor, o cuenta de Azure Data Lake Store, que se utilizan para almacenar los datos capturados. Estas cuentas pueden estar en la misma región que su centro de eventos o en otra región, lo que aumenta la flexibilidad de la función Event Hubs Capture.

Los datos capturados se escriben en formato Apache Avro: un formato binario compacto y rápido que proporciona estructuras de datos ricas con esquema en línea. Este formato se usa ampliamente en el ecosistema de Hadoop, Stream Analytics y Azure Data Factory. Más información sobre cómo trabajar con Avro está disponible más adelante en este artículo.

#### Ventana de captura

Event Hubs Capture le permite configurar una ventana para controlar la captura. Esta ventana es una configuración de tamaño mínimo y tiempo con una "política de primer ganador", lo que significa que el primer desencadenador encontrado causa una operación de captura. Cada partición se captura de forma independiente y escribe un blob de bloque completado en el momento de la captura, nombrado para el tiempo en el que se encontró el intervalo de captura. La convención de nomenclatura de almacenamiento es la siguiente:

```txt
{Namespace}/{EventHub}/{PartitionId}/{Year}/{Month}/{Day}/{Hour}/{Minute}/{Second}
```

Tenga en cuenta que los valores de fecha se rellenan con ceros; un nombre de archivo de ejemplo podría ser:

```txt
https://mystorageaccount.blob.core.windows.net/mycontainer/mynamespace/myeventhub/0/2017/12/08/03/03/17.avro
```

#### Escalado de unidades de rendimiento

El tráfico de Event Hubs se controla mediante unidades de rendimiento. Una sola unidad de rendimiento permite 1 MB por segundo o 1000 eventos por segundo de entrada y el doble de esa cantidad de salida. Los Event Hubs estándar se pueden configurar con 1-20 unidades de rendimiento, y puede comprar más con una solicitud de soporte de aumento de cuota. El uso más allá de sus unidades de rendimiento compradas se limita. Event Hubs Capture copia datos directamente del almacenamiento interno de Event Hubs, omitiendo cuotas de salida de unidades de rendimiento y guardando su salida para otros lectores de procesamiento, como Stream Analytics o Spark.

Una vez configurada, la captura de Event Hubs se ejecuta automáticamente cuando se envía el primer evento y sigue ejecutándose. Para facilitar que el procesamiento descendente sepa que el proceso está funcionando, Event Hubs escribe archivos vacíos cuando no hay datos. Este proceso proporciona una cadencia predecible y marcador que puede alimentar sus procesadores por lotes.

### Escalado de la aplicación de procesamiento

Para escalar la aplicación de procesamiento de eventos, puede ejecutar varias instancias de la aplicación y hacer que equilibren la carga entre ellas. En versiones anteriores, **EventProcessorHost** le permitía equilibrar la carga entre múltiples instancias de su programa y hacer puntos de control de eventos al recibir. En versiones más recientes (5.0 en adelante), **EventProcessorClient** (.NET y Java), o **EventHubConsumerClient** (Python y JavaScript) te permite hacer lo mismo.

:information_source: La clave para escalar en Event Hubs es la idea de consumidores particionados. En contraste con el patrón de consumidores en competencia, el patrón de consumidor particionado permite escala alta al eliminar el cuello de botella de contención y facilitar el paralelismo de extremo a extremo.

#### Escenario de ejemplo

Como escenario de ejemplo, considere una empresa de seguridad del hogar que monitorea 100,000 hogares. Cada minuto, obtiene datos de varios sensores como detector de movimiento, sensor de puerta/ventana abierta, detector de rotura de vidrio, etc., instalados en cada hogar. La empresa proporciona un sitio web para que los residentes monitoreen la actividad de su hogar casi en tiempo real.

Cada sensor envía datos a un centro de eventos. El centro de eventos está configurado con 16 particiones. En el lado del consumidor, necesita un mecanismo que pueda leer estos eventos, consolidarlos y volcarlos en una blob de almacenamiento, que luego se proyecta a una página web fácil de usar.

Al diseñar el consumidor en un entorno distribuido, el escenario debe controlar los siguientes requisitos:

- **Escala**: Cree múltiples consumidores, siendo cada consumidor propietario de leer desde algunas particiones de Event Hubs.
- **Equilibrio de carga**: Aumente o reduzca los consumidores dinámicamente. Por ejemplo, cuando se agrega un nuevo tipo de sensor (por ejemplo, un detector de monóxido de carbono) a cada hogar, aumenta el número de eventos. En ese caso, el operador (un humano) aumenta el número de instancias consumidoras. Luego, el grupo de consumidores puede reequilibrar el número de particiones que poseen, para compartir la carga con los consumidores recientemente añadidos.
- **Reanudación sin problemas en caso de fallos**: Si un consumidor (**consumidor A**) falla (por ejemplo, la máquina virtual que aloja el consumidor se bloquea de repente), otros consumidores pueden retomar las particiones propiedad de **consumidor A** y continuar. Además, el punto de continuación, llamado _punto de control_ u _offset_, debe estar en el punto exacto donde **consumidor A** falló, o ligeramente antes que eso.
- **Consume events**: Aunque los tres puntos anteriores tratan la administración del consumidor, debe existir código para consumir los eventos y hacer algo útil con ellos. Por ejemplo, agregarlos y cargarlos en Blob Storage.

#### Cliente del procesador de eventos o consumidor

No necesita crear su propia solución para cumplir estos requisitos. Los SDK de Azure Event Hubs proporcionan esta funcionalidad. En los SDK de .NET o Java, usa un cliente de procesamiento de eventos (`EventProcessorClient`), y en los SDK de Python y JavaScript, usa `EventHubConsumerClient`.

Para la mayoría de escenarios de producción, recomendamos usar el cliente de procesamiento de eventos para leer y procesar eventos. Los clientes de procesamiento de eventos pueden trabajar de forma cooperativa dentro del contexto de un grupo de consumidores para un centro de eventos determinado. Los clientes administran automáticamente la distribución y el balanceo de carga cuando las instancias pasan a estar disponibles o no disponibles para el grupo.

#### Seguimiento de propiedad de partición

Una instancia del procesador de eventos normalmente posee y procesa eventos de una o más particiones. La propiedad de las particiones se distribuye uniformemente entre todas las instancias activas del procesador de eventos asociadas con una combinación de centro de eventos y grupo de consumidores.

A cada procesador de eventos se le asigna un identificador único y reclama la propiedad de las particiones agregando o actualizando una entrada en un almacén de puntos de control. Todas las instancias del procesador de eventos se comunican con este almacén periódicamente para actualizar su propio estado de procesamiento y obtener información sobre otras instancias activas. Estos datos se usan luego para equilibrar la carga entre los procesadores activos.

#### Recibir mensajes

Al crear un procesador de eventos, especifique las funciones que procesan eventos y errores. Cada llamada a la función que procesa eventos entrega un único evento de una partición específica. Es su responsabilidad controlar este evento. Si quiere asegurarse de que el consumidor procesa todos los mensajes al menos una vez, debe escribir su propio código con lógica de reintento. Pero tenga cuidado con los mensajes dudosos.

Se recomienda hacer las cosas con relativa rapidez. Es decir, realizar el mínimo procesamiento posible. Si necesita escribir en el almacenamiento y hacer algún enrutamiento, es mejor usar dos grupos de consumidores y tener dos procesadores de eventos.

#### Puntos de control

Los _puntos de control_ son un proceso mediante el cual un procesador de eventos marca o confirma la posición del último evento procesado correctamente dentro de una partición. El marcado de un punto de control normalmente se realiza dentro de la función que procesa los eventos y ocurre por partición dentro de un grupo de consumidores.

Si un procesador de eventos se desconecta de una partición, otra instancia puede reanudar el procesamiento de la partición en el punto de control confirmado anteriormente por el último procesador de esa partición en ese grupo de consumidores. Cuando el procesador se conecta, pasa el desplazamiento al centro de eventos para especificar la ubicación desde la que empezar a leer. De esta forma, puede usar los puntos de control tanto para marcar eventos como "completados" por las aplicaciones de bajada como para proporcionar resistencia cuando un procesador de eventos deja de funcionar. Es posible volver a datos más antiguos especificando un desplazamiento inferior de este proceso de punto de control.

#### Seguridad de subprocesos e instancias del procesador

De forma predeterminada, la función que procesa los eventos se llama secuencialmente para una partición determinada. Los eventos posteriores y las llamadas a esta función desde la misma partición se ponen en cola en segundo plano mientras que la bomba de eventos sigue ejecutándose en el fondo en otros subprocesos. Los eventos de distintas particiones se pueden procesar simultáneamente y cualquier estado compartido al que se accede entre particiones debe sincronizarse.

### Control del acceso a los eventos

Azure Event Hubs admite tanto Microsoft Entra ID como las firmas de acceso compartido (SAS) para controlar la autenticación y la autorización. Azure proporciona los siguientes roles integrados de Azure para autorizar el acceso a los datos de Event Hubs con Microsoft Entra ID y OAuth:

- [Propietario de datos de Azure Event Hubs](https://learn.microsoft.com/es-es/azure/role-based-access-control/built-in-roles#azure-event-hubs-data-owner): Use este rol para dar _acceso completo_ a los recursos de Event Hubs.
- [Remitente de datos de Azure Event Hubs](https://learn.microsoft.com/es-es/azure/role-based-access-control/built-in-roles#azure-event-hubs-data-sender): Use este rol para dar _acceso de envío_ a los recursos de Event Hubs.
- [Receptor de datos de Azure Event Hubs](https://learn.microsoft.com/es-es/azure/role-based-access-control/built-in-roles#azure-event-hubs-data-receiver): Use este rol para dar _acceso de recepción_ a los recursos de Event Hubs.

#### Autorizar el acceso con identidades administradas

Para autorizar una solicitud al servicio Event Hubs desde una identidad administrada en la aplicación, debe configurar la configuración de control de acceso basado en roles de Azure para esa identidad administrada. Azure Event Hubs define roles de Azure que abarcan los permisos para enviar y leer desde Event Hubs. Cuando el rol de Azure se asigna a una identidad administrada, se concede a la identidad administrada acceso a los datos de Event Hubs en el ámbito adecuado.

#### Autorizar el acceso con la Plataforma de identidad de Microsoft

Una ventaja clave de usar Microsoft Entra ID con Event Hubs es que las credenciales ya no necesitan almacenarse en el código. En su lugar, puede solicitar un token de acceso de OAuth 2.0 de la plataforma de identidad de Microsoft. Microsoft Entra autentica la entidad de seguridad (un usuario, un grupo o una entidad de servicio) que ejecuta la aplicación. Si la autenticación se realiza correctamente, Microsoft Entra ID devuelve el token de acceso a la aplicación, y la aplicación puede usar el token de acceso para autorizar las solicitudes a Azure Event Hubs.

#### Autorizar el acceso a los publicadores de Event Hubs con firmas de acceso compartido

Un publicador de eventos define un punto de conexión virtual para un centro de eventos. El publicador solo se puede usar para enviar mensajes a un centro de eventos y no para recibirlos. Normalmente, un centro de eventos emplea un publicador por cliente. Todos los mensajes que se envían a cualquiera de los publicadores de un centro de eventos se ponen en cola dentro de ese centro de eventos. Los publicadores permiten el control de acceso detallado.

A cada cliente de Event Hubs se le asigna un token único que se carga en el cliente. Un cliente que contiene un token solo puede enviar a un publicador y no a ningún otro. Si varios clientes comparten el mismo token, cada uno de ellos comparte el publicador.

Todos los tokens se asignan con claves de firma de acceso compartido. Normalmente, todos los tokens se firman con la misma clave. Los clientes no conocen la clave, lo que les impide fabricar tokens. Los clientes operan con los mismos tokens hasta que expiran.

#### Autorizar el acceso a los consumidores de Event Hubs con firmas de acceso compartido

Para autenticar las aplicaciones de back-end que consumen los datos generados por los productores de Event Hubs, la autenticación de tokens de Event Hubs requiere que sus clientes tengan asignados los derechos de **administración** o los privilegios de **escucha** a su espacio de nombres de Event Hubs o instancia de centro de eventos o tema. Los datos se consumen desde Event Hubs usando grupos de consumidores. Aunque la directiva de SAS le ofrece un ámbito granular, este ámbito se define solo en el nivel de entidad y no en el nivel de consumidor. Significa que los privilegios definidos en el nivel de espacio de nombres o el nivel de instancia del centro de eventos o tema son para los grupos de consumidores de esa entidad.

### Operaciones comunes con la biblioteca de cliente de Event Hubs

Esta unidad contiene ejemplos de operaciones comunes que puede realizar con la biblioteca de cliente de Event Hubs (`Azure.Messaging.EventHubs`) para interactuar con un Event Hubs.

#### Inspeccionar Event Hubs

Muchas operaciones de Event Hubs tienen lugar dentro del ámbito de una partición específica. Dado que Event Hubs es propietario de las particiones, sus nombres se asignan en el momento de la creación. Para comprender qué particiones están disponibles, consulte Event Hubs usando uno de los clientes de Event Hubs. A modo de ilustración, se muestra `EventHubProducerClient` en estos ejemplos, pero el concepto y la forma son comunes en todos los clientes.

```csharp
var connectionString = "<< CONNECTION STRING FOR THE EVENT HUBS NAMESPACE >>";
var eventHubName = "<< NAME OF THE EVENT HUB >>";

await using (var producer = new EventHubProducerClient(connectionString, eventHubName))
{
    string[] partitionIds = await producer.GetPartitionIdsAsync();
}
```

#### Publicar eventos en Event Hubs

Para publicar eventos, debe crear un `EventHubProducerClient`. Los productores publican eventos en lotes y pueden solicitar una partición específica o permitir que el servicio Event Hubs decida en qué partición deben publicarse los eventos. Se recomienda usar el enrutamiento automático cuando la publicación de eventos necesita estar altamente disponible o cuando los datos de eventos deben distribuirse uniformemente entre las particiones. Nuestro ejemplo aprovecha el enrutamiento automático.

```csharp
var connectionString = "<< CONNECTION STRING FOR THE EVENT HUBS NAMESPACE >>";
var eventHubName = "<< NAME OF THE EVENT HUB >>";

await using (var producer = new EventHubProducerClient(connectionString, eventHubName))
{
    using EventDataBatch eventBatch = await producer.CreateBatchAsync();
    eventBatch.TryAdd(new EventData(new BinaryData("First")));
    eventBatch.TryAdd(new EventData(new BinaryData("Second")));

    await producer.SendAsync(eventBatch);
}
```

#### Leer eventos de un Event Hubs

Para leer eventos de un Event Hubs, debe crear un `EventHubConsumerClient` para un grupo de consumidores dado. Cuando se crea un Event Hubs, proporciona un grupo de consumidores predeterminado que se puede usar para empezar a explorar Event Hubs. En nuestro ejemplo, nos centramos en leer todos los eventos publicados en Event Hubs usando un iterador.

:information_source: Es importante tener en cuenta que este enfoque de consumo está diseñado para mejorar la experiencia de exploración de la biblioteca de cliente de Event Hubs y la creación de prototipos. Se recomienda no usarlo en escenarios de producción. Para uso en producción, se recomienda usar el **[Cliente del procesador de eventos](https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/eventhub/Azure.Messaging.EventHubs.Processor)**, ya que proporciona una experiencia más sólida y con mejor rendimiento.

```csharp
var connectionString = "<< CONNECTION STRING FOR THE EVENT HUBS NAMESPACE >>";
var eventHubName = "<< NAME OF THE EVENT HUB >>";

string consumerGroup = EventHubConsumerClient.DefaultConsumerGroupName;

await using (var consumer = new EventHubConsumerClient(consumerGroup, connectionString, eventHubName))
{
    using var cancellationSource = new CancellationTokenSource();
    cancellationSource.CancelAfter(TimeSpan.FromSeconds(45));

    await foreach (PartitionEvent receivedEvent in consumer.ReadEventsAsync(cancellationSource.Token))
    {
        // En este punto, el bucle esperará a que haya eventos disponibles en Event Hub. Cuando haya
        // un evento disponible, el bucle iterará con el evento recibido. Como no especificamos
        // un tiempo de espera máximo, el bucle esperará indefinidamente a menos que se solicite
        // la cancelación mediante el token de cancelación.
    }
}
```

#### Leer eventos de un Event Hubs partition

Para leer desde una partición específica, el consumidor debe especificar en qué parte del flujo de eventos empezar a recibir eventos. En nuestro ejemplo, nos centramos en leer todos los eventos publicados para la primera partición de Event Hubs.

```csharp
var connectionString = "<< CONNECTION STRING FOR THE EVENT HUBS NAMESPACE >>";
var eventHubName = "<< NAME OF THE EVENT HUB >>";

string consumerGroup = EventHubConsumerClient.DefaultConsumerGroupName;

await using (var consumer = new EventHubConsumerClient(consumerGroup, connectionString, eventHubName))
{
    EventPosition startingPosition = EventPosition.Earliest;
    string partitionId = (await consumer.GetPartitionIdsAsync()).First();

    using var cancellationSource = new CancellationTokenSource();
    cancellationSource.CancelAfter(TimeSpan.FromSeconds(45));

    await foreach (PartitionEvent receivedEvent in consumer.ReadEventsFromPartitionAsync(partitionId, startingPosition, cancellationSource.Token))
    {
        // En este punto, el bucle esperará a que haya eventos disponibles en la partición. Cuando haya
        // un evento disponible, el bucle iterará con el evento recibido. Como no especificamos
        // un tiempo de espera máximo, el bucle esperará indefinidamente a menos que se solicite
        // la cancelación mediante el token de cancelación.
    }
}
```

#### Procesar eventos con un cliente del procesador de eventos

Para la mayoría de los escenarios de producción, se recomienda usar `EventProcessorClient` para leer y procesar eventos. Dado que `EventProcessorClient` tiene una dependencia de los blobs de Azure Storage para la persistencia de su estado, debe proporcionar un `BlobContainerClient` para el procesador, que se ha configurado para la cuenta de almacenamiento y el contenedor que se deben usar.

```csharp
var cancellationSource = new CancellationTokenSource();
cancellationSource.CancelAfter(TimeSpan.FromSeconds(45));

var storageConnectionString = "<< CONNECTION STRING FOR THE STORAGE ACCOUNT >>";
var blobContainerName = "<< NAME OF THE BLOB CONTAINER >>";

var eventHubsConnectionString = "<< CONNECTION STRING FOR THE EVENT HUBS NAMESPACE >>";
var eventHubName = "<< NAME OF THE EVENT HUB >>";
var consumerGroup = "<< NAME OF THE EVENT HUB CONSUMER GROUP >>";

Task processEventHandler(ProcessEventArgs eventArgs) => Task.CompletedTask;
Task processErrorHandler(ProcessErrorEventArgs eventArgs) => Task.CompletedTask;

var storageClient = new BlobContainerClient(storageConnectionString, blobContainerName);
var processor = new EventProcessorClient(storageClient, consumerGroup, eventHubsConnectionString, eventHubName);

processor.ProcessEventAsync += processEventHandler;
processor.ProcessErrorAsync += processErrorHandler;

await processor.StartProcessingAsync();

try
{
    // El procesador realiza su trabajo en segundo plano; bloquear hasta la cancelación
    // para permitir que se lleve a cabo el procesamiento.

    await Task.Delay(Timeout.Infinite, cancellationSource.Token);
}
catch (TaskCanceledException)
{
    // Esto es lo esperado cuando se cancela el retraso.
}

try
{
    await processor.StopProcessingAsync();
}
finally
{
    // Para evitar fugas, los controladores deben quitarse cuando el procesamiento se complete.

    processor.ProcessEventAsync -= processEventHandler;
    processor.ProcessErrorAsync -= processErrorHandler;
}
```

---

<!-- ===== Azure Message Queues — Comparativa ===== -->

# Colas de mensajes de Azure

## Descripción de las colas de mensajes de Azure

Azure admite dos tipos de mecanismos de cola: **colas de Service Bus** y **colas de Storage**.

Las colas de Service Bus forman parte de una infraestructura de mensajería de Azure más amplia que admite colas, publicación-suscripción y patrones de integración más avanzados. Están diseñadas para integrar aplicaciones o componentes de aplicaciones que pueden abarcar varios protocolos de comunicación, contratos de datos, dominios de confianza o entornos de red.

Las colas de Storage forman parte de la infraestructura de Azure Storage. Permiten almacenar grandes cantidades de mensajes. Accede a los mensajes desde cualquier parte del mundo mediante llamadas autenticadas con HTTP o HTTPS. Un mensaje de cola puede tener un tamaño de hasta 64 KB. Una cola puede contener millones de mensajes, hasta el límite de capacidad total de una cuenta de almacenamiento. Las colas se usan normalmente para crear un trabajo pendiente que se procesa de forma asincrónica.

### Elección de una solución de cola de mensajes

Las colas de Storage y las colas de Service Bus tienen un conjunto de características ligeramente diferente. Puede elegir una u otra, o ambas, según las necesidades de la solución en particular.

Al determinar qué tecnología de cola se adapta al propósito de una solución determinada, los arquitectos de soluciones y los desarrolladores deben tener en cuenta estas recomendaciones.

#### Consideración del uso de colas de Service Bus

Como arquitecto o desarrollador de soluciones, **debe considerar el uso de colas de Service Bus** cuando:

- Su solución necesita recibir mensajes sin tener que sondear la cola. Con Service Bus, puede lograrlo usando una operación de recepción de sondeo largo con los protocolos basados en TCP que admite Service Bus.
- Su solución requiere que la cola proporcione una entrega ordenada con garantía de primero en entrar, primero en salir (FIFO).
- Su solución necesita admitir la detección automática de duplicados.
- Desea que la aplicación procese mensajes como flujos de larga ejecución en paralelo (los mensajes se asocian a un flujo usando la propiedad **ID de sesión** del mensaje). En este modelo, cada nodo de la aplicación consumidora compite por flujos, en lugar de por mensajes. Cuando se asigna un flujo a un nodo consumidor, el nodo puede examinar el estado del flujo de la aplicación mediante transacciones.
- Su solución requiere comportamiento transaccional y atomicidad al enviar o recibir varios mensajes de una cola.
- La aplicación maneja mensajes que pueden superar los 64 KB pero probablemente no alcancen el límite de 256 KB o 1 MB, según el nivel de servicio elegido (aunque las colas de Service Bus pueden controlar mensajes de hasta 100 MB).
- Tiene el requisito de proporcionar un modelo de acceso basado en roles para las colas y diferentes derechos o permisos para remitentes y receptores.

#### Consideración del uso de colas de Storage

Como arquitecto o desarrollador de soluciones, **debe considerar el uso de colas de Storage** cuando:

- La aplicación debe almacenar más de 80 gigabytes de mensajes en una cola.
- La aplicación desea realizar un seguimiento del progreso del procesamiento de un mensaje en la cola. Es útil si el trabajo que procesa un mensaje se bloquea. Otro trabajo puede usar esa información para continuar desde donde lo dejó el trabajo anterior.
- Necesita registros del lado del servidor de todas las transacciones ejecutadas en las colas.

---

<!-- ===== Azure Service Bus ===== -->

# Exploración de Azure Service Bus

Azure Service Bus es un agente de mensajes empresarial completamente administrado con colas de mensajes y temas de publicación-suscripción. Service Bus se usa para desacoplar aplicaciones y servicios. Los datos se transfieren entre distintas aplicaciones y servicios mediante **mensajes**. Un mensaje es un contenedor decorado con metadatos que contiene datos. Los datos pueden ser cualquier tipo de información, incluidos datos estructurados codificados con formatos comunes como JSON, XML, Apache Avro y texto sin formato.

Los escenarios de mensajería comunes incluyen:

- **Mensajería**: Transferencia de datos empresariales, como órdenes de venta o compra, diarios o movimientos de inventario.
- **Desacoplar aplicaciones**: Mejorar la confiabilidad y escalabilidad de aplicaciones y servicios. El cliente y el servicio no tienen que estar en línea al mismo tiempo.
- **Temas y suscripciones**: Habilitar relaciones 1:n entre publicadores y suscriptores.
- **Sesiones de mensajes**: Implementar flujos de trabajo que requieren ordenamiento de mensajes o aplazamiento de mensajes.

## Niveles de servicio de Service Bus

Service Bus ofrece niveles básico, estándar y premium. El nivel **premium** de Service Bus Messaging aborda solicitudes comunes de clientes sobre escala, rendimiento y disponibilidad para aplicaciones críticas para la misión. Se recomienda el nivel premium para escenarios de producción. Aunque los conjuntos de características son casi idénticos, estos dos niveles de Service Bus Messaging están diseñados para servir casos de uso diferentes. Para obtener más información sobre los niveles disponibles, visite [Precios de Service Bus](https://azure.microsoft.com/pricing/details/service-bus/).

Algunas diferencias de alto nivel entre los niveles premium y estándar se destacan en la siguiente tabla.

| Premium | Estándar |
| --- | --- |
| Alto rendimiento | Rendimiento variable |
| Rendimiento predecible | Latencia variable |
| Precios fijos | Precios variables según el uso |
| Capacidad de escalar la carga de trabajo hacia arriba y hacia abajo | N/A |
| Tamaño de mensaje hasta 100 MB | Tamaño de mensaje hasta 256 KB |

## Características avanzadas

Service Bus incluye características avanzadas que le permiten resolver problemas más complejos de mensajería. La siguiente tabla describe varias de estas características.

| Feature               | Description                                                                                                                                                                                                                                                 |
| --------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| Sesiones de mensajes | Para crear una garantía de primero en entrar, primero en salir (FIFO) en Service Bus, use sesiones. Las sesiones de mensajes permiten el manejo exclusivo y ordenado de secuencias ilimitadas de mensajes relacionados. |
| Autoenrutamiento | La función de autoenrutamiento encadena una cola o suscripción a otra cola o tema que está en el mismo espacio de nombres. |
| Cola de cartas muertas | Service Bus admite una cola de cartas muertas (DLQ). Una DLQ contiene mensajes que no se pueden entregar a ningún receptor. Service Bus le permite eliminar mensajes de la DLQ e inspeccionarlos. |
| Entrega programada | Puede enviar mensajes a una cola o tema para un procesamiento demorado. Puede programar un trabajo para que esté disponible para procesamiento por un sistema en una hora determinada. |
| Aplazamiento de mensajes | Un cliente de cola o suscripción puede aplazar la recuperación de un mensaje hasta una hora posterior. El mensaje permanece en la cola o suscripción, pero se deja a un lado. |
| Transacciones | Una transacción agrupa dos o más operaciones juntas en un ámbito de ejecución. Service Bus admite operaciones de agrupación contra una única entidad de mensajería dentro del alcance de una única transacción. Una entidad de mensaje puede ser una cola, tema o suscripción. |
| Filtrado y acciones | Los suscriptores pueden definir qué mensajes desean recibir de un tema. Estos mensajes se especifican en forma de una o más reglas de suscripción nombradas. |
| Autoeliminación al estar inactivo | La autoeliminación al estar inactivo le permite especificar un intervalo de inactividad después del cual se elimina automáticamente una cola. La duración mínima es de 5 minutos. |
| Detección de duplicados | Un error podría causar que el cliente tenga dudas sobre el resultado de una operación de envío. La detección de duplicados permite al remitente reenvíar el mismo mensaje, o para que la cola o tema descarte cualquier copia duplicada. |
| Protocolos de seguridad | Service Bus admite protocolos de seguridad como Firmas de acceso compartido (SAS), Control de acceso basado en roles (RBAC) e Identidades administradas para recursos de Azure. |
| Recuperación ante desastres geográficos | Cuando las regiones de Azure o los centros de datos experimentan tiempo de inactividad, la recuperación ante desastres geográficos permite que el procesamiento de datos continúe funcionando en una región o datacenter diferente. |
| Seguridad | Service Bus es compatible con la versión 1.0 estándar de Protocolo de cola de mensajes avanzados (AMQP) y protocolos HTTP/REST. |

## Cumplimiento de estándares y protocolos

El protocolo de conexión principal para Service Bus es el [Protocolo de mensajería de cola avanzada (AMQP) 1.0](https://learn.microsoft.com/es-es/azure/service-bus-messaging/service-bus-amqp-overview), un estándar abierto ISO/IEC. Permite que los clientes escriban aplicaciones que funcionen contra Service Bus y agentes locales como ActiveMQ o RabbitMQ. La [Guía del protocolo AMQP](https://learn.microsoft.com/en-us/azure/service-bus-messaging/service-bus-amqp-protocol-guide) proporciona información detallada en caso de que necesite crear tal abstracción.

Service Bus Premium es totalmente compatible con la API [Java Message Service (JMS) 2.0](https://learn.microsoft.com/en-us/azure/service-bus-messaging/how-to-use-java-message-service-20) de Java/Jakarta EE.

## Bibliotecas de cliente

Las bibliotecas de cliente de Service Bus completamente compatibles están disponibles a través del SDK de Azure.

- [Azure Service Bus for .NET](https://learn.microsoft.com/en-us/dotnet/api/overview/azure/service-bus)
- [Azure Service Bus libraries for Java](https://learn.microsoft.com/en-us/java/api/overview/azure/servicebus)
- [Azure Service Bus provider for Java JMS 2.0](https://learn.microsoft.com/en-us/azure/service-bus-messaging/how-to-use-java-message-service-20)
- [Azure Service Bus Modules for JavaScript and TypeScript](https://learn.microsoft.com/en-us/javascript/api/overview/azure/service-bus)
- [Azure Service Bus libraries for Python](https://learn.microsoft.com/en-us/python/api/overview/azure/servicebus)

## Descubra colas, temas y suscripciones de Service Bus

Las entidades de mensajería que forman el núcleo de las funcionalidades de mensajería en Service Bus son **colas**, **temas y suscripciones** y reglas y acciones.

### Colas

Las colas ofrecen entrega de mensajes **Primero en entrar, primero en salir** (FIFO) a uno o más consumidores competidores. Es decir, los receptores típicamente reciben y procesan mensajes en el orden en que se agregaron a la cola. Y, solo un consumidor de mensajes recibe y procesa cada mensaje. Debido a que los mensajes se almacenan de forma duradera en la cola, los productores (remitentes) y consumidores (receptores) no tienen que procesar mensajes simultáneamente.

Una ventaja relacionada es la **nivelación de carga**, que permite a los productores y consumidores enviar y recibir mensajes a diferentes velocidades. En muchas aplicaciones, la carga del sistema varía con el tiempo. Sin embargo, el tiempo de procesamiento requerido para cada unidad de trabajo suele ser constante. Intermediar productores y consumidores de mensajes con una cola significa que la aplicación consumidora solo debe poder manejar la carga promedio en lugar de la carga máxima.

Usar colas para intermediar entre productores y consumidores de mensajes proporciona un desacoplamiento inherente entre los componentes. Como productores y consumidores no tienen conocimiento entre sí, un consumidor puede actualizarse sin afectar al productor.

Puede crear colas usando Azure Portal, PowerShell, CLI o plantillas de Resource Manager. Después, envíe y reciba mensajes usando clientes escritos en C#, Java, Python y JavaScript.

### Modos de recepción

Puede especificar dos modos diferentes en los que Service Bus recibe mensajes: **Receive and delete (recibir y eliminar)** o **Peek lock (inspección con bloqueo)**.

#### Recibir y eliminar

En este modo, cuando Service Bus recibe la solicitud del consumidor, marca el mensaje como consumido y lo devuelve a la aplicación consumidora. Este modo es el modelo más simple. Funciona mejor para escenarios en los que la aplicación puede tolerar no procesar un mensaje si se produce un error. Por ejemplo, considere un escenario en el que el consumidor emite la solicitud de recepción y luego se bloquea antes de procesarlo. Como Service Bus marca el mensaje como consumido, la aplicación comienza a consumir mensajes al reiniciarse. Se pierde el mensaje que consumió antes del bloqueo.

#### Modo Peek lock (inspección con bloqueo)

En este modo, la operación de recepción se convierte en dos fases, lo que hace posible admitir aplicaciones que no pueden tolerar la pérdida de mensajes.

1. Encuentra el siguiente mensaje que se va a consumir, lo _bloquea_ para evitar que otros consumidores lo reciban y, luego, devuelve el mensaje a la aplicación.
1. Después de que la aplicación termina de procesar el mensaje, solicita al servicio Service Bus completar la segunda fase del proceso de recepción. Después, el servicio **marca el mensaje como consumido**.

Si la aplicación no puede procesar el mensaje por algún motivo, puede solicitar al servicio Service Bus que **abandone** el mensaje. Service Bus **desbloquea** el mensaje y lo deja disponible para volver a recibirse, ya sea por el mismo consumidor o por otro consumidor competidor. En segundo lugar, existe un **tiempo de espera** asociado al bloqueo. Si la aplicación no procesa el mensaje antes de que expire el tiempo de espera del bloqueo, Service Bus desbloquea el mensaje y lo deja disponible para volver a recibirse.

### Temas y suscripciones

Una cola permite procesar un mensaje por un único consumidor. En contraste con las colas, los temas y suscripciones proporcionan una forma de comunicación de uno a varios en un patrón **publicación y suscripción (publish and subscribe)**. Es útil para escalar a grandes números de destinatarios. Cada mensaje publicado queda disponible para cada suscripción registrada en el tema. El publicador envía un mensaje a un tema y uno o más suscriptores reciben una copia del mensaje.

Las suscripciones pueden usar más filtros para restringir los mensajes que desean recibir. Los publicadores envían mensajes a un tema de la misma manera que envían mensajes a una cola. Pero los consumidores no reciben mensajes directamente del tema. En su lugar, los consumidores reciben mensajes desde suscripciones del tema. Una suscripción de tema se asemeja a una cola virtual que recibe copias de los mensajes que se envían al tema. Los consumidores reciben mensajes de una suscripción de forma idéntica a como reciben mensajes de una cola.

La funcionalidad de envío de mensajes de una cola se asigna directamente a un tema y su funcionalidad de recepción de mensajes se asigna a una suscripción. Entre otras cosas, esta característica significa que las suscripciones admiten los mismos patrones descritos antes en esta sección para las colas: consumidor competidor, desacoplamiento temporal, nivelación de carga y balanceo de carga.

## Reglas y acciones

En muchos escenarios, los mensajes que tienen características específicas deben procesarse de diferentes formas. Para habilitar este procesamiento, puede configurar suscripciones para encontrar mensajes que tengan propiedades deseadas y luego realizar ciertas modificaciones en esas propiedades. Si bien las suscripciones de Service Bus ven todos los mensajes enviados al tema, puede copiar solo un subconjunto de esos mensajes a la cola de suscripción virtual. Este filtrado se logra usando filtros de suscripción. Tales modificaciones se llaman **acciones de filtro**. Cuando se crea una suscripción, puede proporcionar una expresión de filtro que funciona en las propiedades del mensaje. Las propiedades pueden ser tanto propiedades del sistema (por ejemplo, **Etiqueta**) como propiedades personalizadas de la aplicación (por ejemplo, **NombraDaTienda**). La expresión de filtro SQL es opcional en este caso. Sin una expresión de filtro SQL, cualquier acción de filtro definida en una suscripción se realiza en todos los mensajes para esa suscripción.

## Exploración de cargas de mensajes y serialización de Service Bus

Los mensajes llevan una carga y metadatos. Los metadatos están en forma de propiedades de pares clave-valor y describen la carga y dan instrucciones de manejo a Service Bus y aplicaciones. Ocasionalmente, solo esos metadatos son suficientes para llevar la información que el remitente desea comunicar a los receptores, y la carga permanece vacía.

Un mensaje de Service Bus consta de una sección de carga binaria que Service Bus nunca controla de ninguna forma en el lado del servicio, y dos conjuntos de propiedades. Las _propiedades del agente_ están definidas por el sistema. Estas propiedades predefinidas controlan la funcionalidad de nivel de mensaje dentro del agente, o se asignan a elementos de metadatos comunes y estandarizados. Las _propiedades del usuario_ son una colección de pares clave-valor definidos y establecidos por la aplicación.

### Enrutamiento y correlación de mensajes

Un subconjunto de las propiedades del agente, específicamente `To`, `ReplyTo`, `ReplyToSessionId`, `MessageId`, `CorrelationId` y `SessionId`, ayuda a las aplicaciones a enrutar mensajes a destinos particulares. Los siguientes patrones describen el enrutamiento:

- **Solicitud/respuesta simple (Simple request/reply)**: Un publicador envía un mensaje a una cola y espera una respuesta del consumidor del mensaje. El publicador posee una cola para recibir respuestas. La dirección de esa cola está contenida en la propiedad `ReplyTo` del mensaje saliente. Cuando el consumidor responde, copia el `MessageId` del mensaje procesado en la propiedad `CorrelationId` del mensaje de respuesta y entrega el mensaje al destino indicado por la propiedad `ReplyTo`. Un mensaje puede generar múltiples respuestas, según el contexto de la aplicación.
- **Solicitud/respuesta de multidifusión (Multicast request/reply)**: Como variación del patrón anterior, un publicador envía el mensaje a un tema y varios suscriptores pasan a ser candidatos para consumirlo. Cada suscriptor podría responder de la forma descrita anteriormente. Si `ReplyTo` apunta a un tema, ese conjunto de respuestas de descubrimiento puede distribuirse a una audiencia.
- **Multiplexación (Multiplexing)**: Esta característica de sesión permite la multiplexación de flujos de mensajes relacionados a través de una sola cola o suscripción, de forma que cada sesión (o grupo) de mensajes relacionados, identificados por valores coincidentes de `SessionId`, se enruta a un receptor específico mientras el receptor mantiene la sesión bloqueada. Obtenga más información sobre los detalles de las sesiones [aquí](https://learn.microsoft.com/en-us/azure/service-bus-messaging/message-sessions).
- **Solicitud/respuesta multiplexada (Multiplexed request/reply):** Esta característica de sesión habilita respuestas multiplexadas, lo que permite que varios publicadores compartan una cola de respuesta. Al establecer `ReplyToSessionId`, el publicador puede instruir a uno o más consumidores para que copien ese valor en la propiedad `SessionId` del mensaje de respuesta. La cola o el tema de publicación no necesitan ser compatibles con sesión. Cuando se envía el mensaje, el publicador puede esperar a que una sesión con el `SessionId` dado se materialice en la cola aceptando condicionalmente un receptor de sesión.

El enrutamiento dentro de un espacio de nombres de Service Bus usa el encadenamiento de reenvío automático y las reglas de suscripción a temas. El enrutamiento entre espacios de nombres se puede realizar con Azure Logic Apps. La propiedad `To` está reservada para uso futuro. Las aplicaciones que implementen el enrutamiento deben hacerlo basándose en las propiedades del usuario y no apoyarse en la propiedad `To`; sin embargo, hacerlo ahora no causará problemas de compatibilidad.

### Serialización de carga

Cuando está en tránsito o almacenado dentro de Service Bus, la carga siempre es un bloque binario opaco. La propiedad `ContentType` permite a las aplicaciones describir la carga, siendo el formato sugerido para los valores de la propiedad una descripción de tipo de contenido MIME según IETF RFC2045; por ejemplo, `application/json;charset=utf-8`.

A diferencia de las variantes de Java o .NET Standard, la versión de .NET Framework de la API de Service Bus admite la creación de instancias de `BrokeredMessage` pasando objetos .NET arbitrarios al constructor.

El protocolo SBMP heredado serializa objetos con el serializador binario predeterminado o con un serializador proporcionado externamente. El protocolo AMQP serializa objetos en un objeto AMQP. El receptor puede recuperar esos objetos con el método `GetBody<T>()`, proporcionando el tipo esperado. Con AMQP, los objetos se serializan en un grafo AMQP de objetos `ArrayList` e `IDictionary<string,object>`, y cualquier cliente AMQP puede decodificarlos.

Aunque esta serialización automática es conveniente, si las aplicaciones deben tomar control explícito de la serialización de objetos y convertir sus grafos de objetos en flujos antes de incluirlos en un mensaje, deben realizar la operación inversa en el lado del receptor. Si bien AMQP tiene un potente modelo de codificación binaria, está vinculado al ecosistema de mensajería AMQP y los clientes HTTP tienen dificultades para decodificar estas cargas.

---

<!-- ===== Azure Queue Storage ===== -->

# Exploración de Azure Queue Storage

Azure Queue Storage es un servicio para almacenar grandes cantidades de mensajes. Se accede a los mensajes desde cualquier parte del mundo mediante llamadas autenticadas con HTTP o HTTPS. Un mensaje de cola puede tener un tamaño de hasta 64 KB. Una cola puede contener millones de mensajes, hasta el límite de capacidad total de una cuenta de almacenamiento. Las colas se usan normalmente para crear un trabajo pendiente que se procesa de forma asincrónica.

El servicio Cola contiene los siguientes componentes:

![Imagen que muestra los componentes del servicio de colas](https://learn.microsoft.com/en-us/training/wwl-azure/discover-azure-message-queue/media/queue-storage-service-components.png)

- **Formato de URL**: Las colas se pueden direccionar con el formato de URL `https://<storage account>.queue.core.windows.net/<queue>`. Por ejemplo, la siguiente URL direcciona una cola del diagrama anterior: `https://myaccount.queue.core.windows.net/images-to-download`
- **Cuenta de almacenamiento**: Todo el acceso a Azure Storage se realiza a través de una cuenta de almacenamiento.
- **Cola**: Una cola contiene un conjunto de mensajes. Todos los mensajes deben estar en una cola. El nombre de la cola debe estar en minúsculas.
- **Mensaje**: Un mensaje, en cualquier formato, de hasta 64 KB. Para la versión 2017-07-29 o posterior, el tiempo de vida máximo puede ser cualquier número positivo, o -1 para indicar que el mensaje no caduca. Si se omite este parámetro, el tiempo de vida predeterminado es de siete días.

## Crear y administrar Azure Queue Storage y mensajes con .NET

En esta sección se explica cómo crear colas y administrar mensajes en Azure Queue Storage mediante fragmentos de código de un proyecto .NET.

Los ejemplos de código dependen de los siguientes paquetes NuGet:

- [Biblioteca Azure.Core para .NET](https://www.nuget.org/packages/azure.core/): Este paquete proporciona primitivas, abstracciones y asistentes compartidos para las bibliotecas de cliente del SDK de Azure para .NET modernas.
- [Biblioteca de cliente Azure.Storage.Common para .NET](https://www.nuget.org/packages/azure.storage.common/): Este paquete proporciona infraestructura compartida por las otras bibliotecas de cliente de Azure Storage.
- [Biblioteca de cliente Azure.Storage.Queues para .NET](https://www.nuget.org/packages/azure.storage.queues/): Este paquete permite trabajar con Azure Queue Storage para almacenar mensajes a los que accede un cliente.
- [Biblioteca System.Configuration.ConfigurationManager para .NET](https://www.nuget.org/packages/system.configuration.configurationmanager/): Este paquete proporciona acceso a los archivos de configuración para las aplicaciones cliente.

### Creación del cliente del servicio de cola

La clase `QueueClient` permite recuperar colas almacenadas en Queue Storage. A continuación se muestra una forma de crear el cliente del servicio:

```csharp
QueueClient queueClient = new QueueClient(connectionString, queueName);
```

### Creación de una cola

Este ejemplo muestra cómo crear una cola si aún no existe:

```csharp
// Obtener la cadena de conexión desde la configuración de la aplicación
string connectionString = ConfigurationManager.AppSettings["StorageConnectionString"];

// Crear una instancia de QueueClient para crear y manipular la cola
QueueClient queueClient = new QueueClient(connectionString, queueName);

// Crear la cola
queueClient.CreateIfNotExists();
```

### Inserción de un mensaje en una cola

Para insertar un mensaje en una cola existente, llame al método `SendMessage`. Un mensaje puede ser una cadena (en formato UTF-8) o una matriz de bytes. El siguiente código crea una cola (si no existe) y agrega un mensaje:

```csharp
// Obtener la cadena de conexión desde la configuración de la aplicación
string connectionString = ConfigurationManager.AppSettings["StorageConnectionString"];

// Crear una instancia de QueueClient para crear y manipular la cola
QueueClient queueClient = new QueueClient(connectionString, queueName);

// Crear la cola si aún no existe
queueClient.CreateIfNotExists();

if (queueClient.Exists())
{
    // Enviar un mensaje a la cola
    queueClient.SendMessage(message);
}
```

### Inspección del siguiente mensaje

Puede echar un vistazo a los mensajes de la cola sin quitarlos llamando al método `PeekMessages`. Si no pasa un valor para el parámetro `maxMessages`, el valor predeterminado es ver un mensaje.

```csharp
// Obtener la cadena de conexión desde la configuración de la aplicación
string connectionString = ConfigurationManager.AppSettings["StorageConnectionString"];

// Crear una instancia de QueueClient que se usará para manipular la cola
QueueClient queueClient = new QueueClient(connectionString, queueName);

if (queueClient.Exists())
{
    // Inspeccionar el siguiente mensaje
    PeekedMessage[] peekedMessage = queueClient.PeekMessages();
}
```

### Cambio del contenido de un mensaje en cola

Puede cambiar el contenido de un mensaje en el lugar en la cola. Si el mensaje representa una tarea de trabajo, puede usar esta característica para actualizar el estado de la tarea. El siguiente código actualiza el mensaje de la cola con nuevo contenido y establece el tiempo de espera de visibilidad para extenderlo otros 60 segundos. Esto guarda el estado del trabajo asociado al mensaje y da al cliente otro minuto para continuar trabajando en el mensaje.

```csharp
// Obtener la cadena de conexión desde la configuración de la aplicación
string connectionString = ConfigurationManager.AppSettings["StorageConnectionString"];

// Crear una instancia de QueueClient que se usará para manipular la cola
QueueClient queueClient = new QueueClient(connectionString, queueName);

if (queueClient.Exists())
{
    // Obtener el mensaje de la cola
    QueueMessage[] message = queueClient.ReceiveMessages();

    // Actualizar el contenido del mensaje
    queueClient.UpdateMessage(message[0].MessageId,
            message[0].PopReceipt,
            "Updated contents",
            TimeSpan.FromSeconds(60.0)  // Hacerlo invisible durante otros 60 segundos
        );

}
```

### Extracción del siguiente mensaje de la cola

Quite un mensaje de una cola en dos pasos. Cuando llama a `ReceiveMessages`, obtiene el siguiente mensaje en una cola. Un mensaje devuelto de `ReceiveMessages` se vuelve invisible para cualquier otro código que lea mensajes de esta cola. De forma predeterminada, este mensaje permanece invisible durante 30 segundos. Para terminar de quitar el mensaje de la cola, también debe llamar a `DeleteMessage`. Este proceso de dos pasos para quitar un mensaje garantiza que si el código no puede procesar un mensaje debido a un error de hardware o software, otra instancia del código puede obtener el mismo mensaje y volver a intentarlo. El código llama a `DeleteMessage` justo después de que se haya procesado el mensaje.

```csharp
// Obtener la cadena de conexión desde la configuración de la aplicación
string connectionString = ConfigurationManager.AppSettings["StorageConnectionString"];

// Crear una instancia de QueueClient que se usará para manipular la cola
QueueClient queueClient = new QueueClient(connectionString, queueName);

if (queueClient.Exists())
{
    // Obtener el siguiente mensaje
    QueueMessage[] retrievedMessage = queueClient.ReceiveMessages();

    // Procesar (es decir, imprimir) el mensaje en menos de 30 segundos
    Console.WriteLine($"Dequeued message: '{retrievedMessage[0].Body}'");

    // Eliminar el mensaje
    queueClient.DeleteMessage(retrievedMessage[0].MessageId, retrievedMessage[0].PopReceipt);

}
```

### Obtención de la longitud de la cola

Puede obtener una estimación del número de mensajes en una cola. El método `GetProperties` devuelve las propiedades de la cola, incluido el recuento de mensajes. La propiedad `ApproximateMessagesCount` contiene el número aproximado de mensajes en la cola. Este número no es menor que el número real de mensajes en la cola, pero podría ser mayor.

```csharp
/// Crear una instancia de QueueClient que se usará para manipular la cola
QueueClient queueClient = new QueueClient(connectionString, queueName);

if (queueClient.Exists())
{
    QueueProperties properties = queueClient.GetProperties();

    // Recuperar el recuento aproximado de mensajes almacenado en caché.
    int cachedMessagesCount = properties.ApproximateMessagesCount;

    // Mostrar el número de mensajes.
    Console.WriteLine($"Number of messages in queue: {cachedMessagesCount}");

}
```

### Eliminación de una cola

Para eliminar una cola y todos los mensajes que contiene, llame al método `Delete` en el objeto de cola.

```csharp
/// Obtener la cadena de conexión desde la configuración de la aplicación
string connectionString = ConfigurationManager.AppSettings["StorageConnectionString"];

// Crear una instancia de QueueClient que se usará para manipular la cola
QueueClient queueClient = new QueueClient(connectionString, queueName);

if (queueClient.Exists())
{
    // Eliminar la cola
    queueClient.Delete();
}
```
