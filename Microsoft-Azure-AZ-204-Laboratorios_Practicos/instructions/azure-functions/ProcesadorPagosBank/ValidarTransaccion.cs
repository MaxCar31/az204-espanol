using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProcesadorPagosBank;

public class ValidarTransaccion
{
    private readonly ILogger<ValidarTransaccion> _logger;

    public ValidarTransaccion(ILogger<ValidarTransaccion> logger)
    {
        _logger = logger;
    }

    [Function("ValidarTransaccion")]
    public IActionResult Run([HttpTrigger(AuthorizationLevel.Function, "get", "post")] HttpRequest req)
    {
        _logger.LogInformation("C# HTTP trigger function processed a request.");
        return new OkObjectResult("Transaccion validada correctamente");
    }
}
