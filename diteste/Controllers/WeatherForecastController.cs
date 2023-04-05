using Microsoft.AspNetCore.Mvc;

namespace diteste.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{    

    private readonly ILogger<WeatherForecastController> _logger;
    private readonly ITeste1 _teste1;
    private readonly ITeste2 _teste2;

    public WeatherForecastController(
        ILogger<WeatherForecastController> logger,
        ITeste1 teste1, 
        ITeste2 teste2
    )
    {
        _logger = logger;
        _teste1 = teste1;
        _teste2 = teste2;
    }

    [HttpGet]
    public IActionResult Executar(){
        _teste1.Executar();
        _teste2.Executar();
        return Ok();
    }
    
}
