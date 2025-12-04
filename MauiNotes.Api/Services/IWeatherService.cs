using MauiNotes.Api.Models;

namespace MauiNotes.Api.Services
{
    public interface IWeatherService
    {
        IEnumerable<WeatherForecast> GetRandomWeatherForecast();
    }
}
