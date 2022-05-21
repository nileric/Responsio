using Microsoft.AspNetCore.Mvc;

namespace Responsio.Api.Controllers;

[ApiController]
[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/[controller]")]
public class UserController : ControllerBase
{
    private readonly ILogger<UserController> _logger;

    public UserController(ILogger<UserController> logger)
    {
        _logger = logger;
    }

    [HttpGet("GetWeatherForecast")]
    public string Get()
    {
        return "";
    }

   
}
