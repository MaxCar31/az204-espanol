---
lab:
  topic: Autenticación y autorización de Azure
  title: Implementar autenticación interactiva con MSAL.NET
  description: Aprenda cómo implementar autenticación interactiva usando el SDK MSAL.NET y adquirir un token.
  duration: 15 minutes
  level: 300
  islab: true
  primarytopics:
    - .NET
---
# Implementar autenticación interactiva con MSAL.NET

En este ejercicio, registrará una aplicación en Microsoft Entra ID, luego creará una aplicación de consola .NET que usa MSAL.NET para realizar la autenticación interactiva y adquirir un token de acceso para Microsoft Graph. Aprenderá cómo configurar los ámbitos (scopes) de autenticación, manejar el consentimiento del usuario y ver cómo se almacenan en caché los tokens para ejecuciones posteriores.

Tareas realizadas en este ejercicio:

* Registrar una aplicación en la plataforma de identidad de Microsoft
* Crear una aplicación de consola .NET que implemente la clase **PublicClientApplicationBuilder** para configurar la autenticación.
* Adquirir un token de forma interactiva utilizando el permiso **user.read** de Microsoft Graph.

Este ejercicio tarda aproximadamente **15** minutos en completarse.

## Antes de comenzar

Para completar el ejercicio, necesita:

* Una suscripción de Azure. Si aún no tiene una, puede [registrarse para obtener una](https://azure.microsoft.com/).
* [Visual Studio Code](https://code.visualstudio.com/) en una de las [plataformas soportadas](https://code.visualstudio.com/docs/supporting/requirements#_platforms).
* [.NET 8](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) o superior.
* [C# Dev Kit](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csdevkit) para Visual Studio Code.

## Registrar una nueva aplicación

1. En su navegador web, vaya al portal de Azure [https://portal.azure.com](https://portal.azure.com); inicie sesión con sus credenciales de Azure si se le solicita.
2. En el portal, busque y seleccione **Registros de aplicaciones** (App registrations).
3. Seleccione **+ Nuevo registro** (New registration), y cuando aparezca la página **Registrar una aplicación**, ingrese la información de registro de su aplicación:

   | Campo                                    | Valor                                                                                                                        |
   | ---------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------- |
   | **Nombre**                         | Ingrese `myMsalApplication`                                                                                                |
   | **Tipos de cuenta compatibles**    | Seleccione**Solo las cuentas de este directorio organizativo**                                                         |
   | **URI de redirección (opcional)** | Seleccione**Cliente público/nativo (móvil y escritorio)** e ingrese `http://localhost` en el cuadro de la derecha. |
4. Seleccione **Registrar** (Register). Microsoft Entra ID asigna un ID de aplicación (cliente) único a su aplicación, y se le dirigirá a la página de **Información general** (Overview) de su aplicación.
5. En la sección **Esenciales** de la página de **Información general**, registre el **ID de aplicación (cliente)** y el **ID de directorio (inquilino)**. La información es necesaria para la aplicación.

   ![Captura de pantalla que muestra la ubicación de los campos a copiar.](./media/01-app-directory-id-location.png)

## Crear una aplicación de consola .NET para adquirir un token

Ahora que los recursos necesarios están implementados en Azure, el siguiente paso es configurar la aplicación de consola. Los siguientes pasos se realizan en su entorno local.

1. Cree una carpeta llamada **authapp**, o un nombre de su elección, para el proyecto.
2. Inicie **Visual Studio Code**, seleccione **Archivo > Abrir carpeta...** y seleccione la carpeta del proyecto.
3. Seleccione **Ver > Terminal** para abrir un terminal.
4. Ejecute el siguiente comando en el terminal de VS Code para crear la aplicación de consola .NET.

   ```
   dotnet new console
   ```
5. Ejecute los siguientes comandos para agregar los paquetes **Microsoft.Identity.Client** y **dotenv.net** al proyecto.

   ```
   dotnet add package Microsoft.Identity.Client
   dotnet add package dotenv.net
   ```

### Configurar la aplicación de consola

En esta sección creará, y editará, un archivo **.env** para guardar los secretos que registró anteriormente.

1. Seleccione **Archivo > Nuevo archivo...** y cree un archivo llamado *.env* en la carpeta del proyecto.
2. Abra el archivo **.env** y agregue el siguiente código. Reemplace **YOUR_CLIENT_ID** y **YOUR_TENANT_ID** con los valores que registró anteriormente.

   ```
   CLIENT_ID="YOUR_CLIENT_ID"
   TENANT_ID="YOUR_TENANT_ID"
   ```
3. Presione **ctrl+s** para guardar sus cambios.

### Agregar el código inicial para el proyecto

1. Abra el archivo *Program.cs* y reemplace cualquier contenido existente con el siguiente código. Asegúrese de revisar los comentarios en el código.

   ```csharp
   using Microsoft.Identity.Client;
   using dotenv.net;

   // Cargar variables de entorno desde el archivo .env
   DotEnv.Load();
   var envVars = DotEnv.Read();

   // Recuperar el ID de aplicación de Azure AD y el ID de inquilino de las variables de entorno
   string _clientId = envVars["CLIENT_ID"];
   string _tenantId = envVars["TENANT_ID"];

   // AÑADIR CÓDIGO PARA DEFINIR ÁMBITOS Y CREAR CLIENTE



   // AÑADIR CÓDIGO PARA ADQUIRIR UN TOKEN DE ACCESO


   ```
2. Presione **ctrl+s** para guardar sus cambios.

### Agregar código para completar la aplicación

1. Busque el comentario **// AÑADIR CÓDIGO PARA DEFINIR ÁMBITOS Y CREAR CLIENTE** y agregue el siguiente código directamente después del comentario. Asegúrese de revisar los comentarios en el código.

   ```csharp
   // Definir los ámbitos requeridos para la autenticación
   string[] _scopes = { "User.Read" };

   // Crear la aplicación de cliente público MSAL con la autoridad y URI de redirección
   var app = PublicClientApplicationBuilder.Create(_clientId)
       .WithAuthority(AzureCloudInstance.AzurePublic, _tenantId)
       .WithDefaultRedirectUri()
       .Build();
   ```
2. Busque el comentario **// AÑADIR CÓDIGO PARA ADQUIRIR UN TOKEN DE ACCESO** y agregue el siguiente código directamente después del comentario. Asegúrese de revisar los comentarios en el código.

   ```csharp
   // Intentar adquirir un token de acceso de forma silenciosa o interactiva
   AuthenticationResult result;
   try
   {
       // Intentar adquirir token silenciosamente desde caché para la primera cuenta disponible
       var accounts = await app.GetAccountsAsync();
       result = await app.AcquireTokenSilent(_scopes, accounts.FirstOrDefault())
                   .ExecuteAsync();
   }
   catch (MsalUiRequiredException)
   {
       // Si la adquisición silenciosa falla, pedir interactividad al usuario
       result = await app.AcquireTokenInteractive(_scopes)
                   .ExecuteAsync();
   }

   // Mostrar el token de acceso adquirido en la consola
   Console.WriteLine($"Token de Acceso:\n{result.AccessToken}");
   ```
3. Presione **ctrl+s** para guardar el archivo, luego **ctrl+q** para salir del editor.

## Ejecutar la aplicación

Ahora que la aplicación está completa es hora de ejecutarla.

1. Inicie la aplicación ejecutando el siguiente comando:

   ```
   dotnet run
   ```
2. La aplicación abre el navegador predeterminado pidiéndole que seleccione la cuenta con la que desea autenticarse. Si hay varias cuentas listadas, seleccione la asociada con el inquilino usado en la aplicación.
3. Si esta es la primera vez que se autentica en la aplicación registrada, recibirá una notificación de **Permisos solicitados** pidiéndole que apruebe que la aplicación inicie su sesión y lea su perfil, y mantenga el acceso a los datos a los que le ha dado acceso. Seleccione **Aceptar**.

   ![Captura de pantalla que muestra la notificación de permisos solicitados](./media/01-granting-permission.png)
4. Debería ver resultados similares al siguiente ejemplo en la consola.

   ```
   Token de Acceso:
   eyJ0eXAiOiJKV1QiLCJub25jZSI6IlZF.........
   ```
5. Inicie la aplicación por segunda vez y observe que ya no recibe la notificación de **Permisos solicitados**. El permiso que otorgó anteriormente fue almacenado en caché. **Nota:** Si tiene varias cuentas, y con algunas configuraciones de cuentas, es posible que vuelva a ver la notificación.

## Limpiar recursos

Ahora que ha terminado el ejercicio, debe eliminar los recursos de la nube que creó para evitar el uso innecesario de recursos.

1. En su navegador web, vaya al portal de Azure [https://portal.azure.com](https://portal.azure.com); inicie sesión con sus credenciales de Azure si se le solicita.
2. Vaya al grupo de recursos que creó y vea el contenido de los recursos usados en este ejercicio.
3. En la barra de herramientas, seleccione **Eliminar grupo de recursos**.
4. Ingrese el nombre del grupo de recursos y confirme que desea eliminarlo.

> **PRECAUCIÓN:** Al eliminar un grupo de recursos se eliminan todos los recursos que contiene. Si eligió un grupo de recursos existente para este ejercicio, cualquier recurso existente fuera del alcance de este ejercicio también se eliminará.
