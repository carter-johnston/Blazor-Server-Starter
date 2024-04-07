using BlazorServerStarter.Configuration;
using BlazorServerStarter.Models;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;

namespace BlazorServerStarter.Services;

public class WeatherForecastService(IHttpClientFactory _httpClientFactory, 
    IOptions<WeatherApiClientSettings> weatherApiSettings) 
    : IWeatherForecastService
{
    public async Task<WeatherForecast> GetForecastForJacksonvilleAsync()
    {
        var client = _httpClientFactory.CreateClient();

        client.BaseAddress = new Uri(weatherApiSettings.Value.BaseUrl);

        var response = await client.GetAsync($"V1/forecast.json?key={weatherApiSettings.Value.Key}&q=Jacksonville");

        var result = new WeatherForecast();

        if (response.IsSuccessStatusCode)
        {
            var content = await response.Content.ReadAsStringAsync();

            result = JsonConvert.DeserializeObject<WeatherForecast>(content) 
                ?? new();
        }

        return result;
    }
}
