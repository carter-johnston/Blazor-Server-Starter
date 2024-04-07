
using BlazorServerStarter.Models;

namespace BlazorServerStarter.Services
{
    public interface IWeatherForecastService
    {
        Task<WeatherForecast> GetForecastForJacksonvilleAsync();
    }
}