using System.Collections;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WEATHER_DOTNET.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private readonly ILogger<WeatherForecastController> _logger;
    private readonly IWeatherForecastService _forecastService;

    public WeatherForecastController(ILogger<WeatherForecastController> logger, IWeatherForecastService forecastService)
    {
        _logger = logger;
        _forecastService = forecastService;
    }

    [Authorize]
    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable Get()
    {
        return _forecastService.GetWeatherForecast();
    }
}
