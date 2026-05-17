using Microsoft.Identity.Client;
using dotenv.net;
using System.Net.Http.Headers;
using System.Text.Json;

// Cargar variables de entorno desde el archivo .env
DotEnv.Load();
var envVars = DotEnv.Read();

// Recuperar el ID de aplicación de Azure AD y el ID de inquilino de las variables de entorno
string _clientId = envVars["CLIENT_ID"];
string _tenantId = envVars["TENANT_ID"];

// Definir los ámbitos requeridos para la autenticación
string[] _scopes = { "User.Read" };

// Crear la aplicación de cliente público MSAL con la autoridad y URI de redirección
var app = PublicClientApplicationBuilder.Create(_clientId)
    .WithAuthority(AzureCloudInstance.AzurePublic, _tenantId)
    .WithDefaultRedirectUri()
    .Build();

AuthenticationResult result;
try
{
    var accounts = await app.GetAccountsAsync();
    result = await app.AcquireTokenSilent(_scopes, accounts.FirstOrDefault())
                .ExecuteAsync();
}
catch (MsalUiRequiredException)
{
    result = await app.AcquireTokenInteractive(_scopes)
                .ExecuteAsync();
}

Console.WriteLine($"Token de Acceso:\n{result.AccessToken}\n");

// Llamar a Microsoft Graph para obtener la información del usuario
using var httpClient = new HttpClient();
httpClient.DefaultRequestHeaders.Authorization =
    new AuthenticationHeaderValue("Bearer", result.AccessToken);

var graphResponse = await httpClient.GetAsync("https://graph.microsoft.com/v1.0/me");
graphResponse.EnsureSuccessStatusCode();

var content = await graphResponse.Content.ReadAsStringAsync();
Console.WriteLine("Información del usuario desde Microsoft Graph:");
Console.WriteLine(content);

// Si deseas leer campos específicos
using var jsonDoc = JsonDocument.Parse(content);
var root = jsonDoc.RootElement;
Console.WriteLine();
Console.WriteLine($"displayName: {root.GetProperty("displayName").GetString()}");
Console.WriteLine($"userPrincipalName: {root.GetProperty("userPrincipalName").GetString()}");
Console.WriteLine($"id: {root.GetProperty("id").GetString()}");