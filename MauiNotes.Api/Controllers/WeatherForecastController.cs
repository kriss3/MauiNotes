using MauiNotes.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace MauiNotes.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
        return GetRandomWeatherForecast();
    }

    
}
