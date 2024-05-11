using Microsoft.FluentUI.AspNetCore.Components;

namespace BlazorServerStarter.Utility;

public static class WeatherForecastUtil
{
    public static Emoji TranslateWeatherConditionToEmoji(string condition)
    {
        return condition switch
        {
            "Cloudy" => new Emojis.TravelPlaces.Color.Default.Cloud(),
            "Partly Cloudy" => new Emojis.TravelPlaces.Color.Default.SunBehindCloud(),
            "Sunny" => new Emojis.TravelPlaces.Color.Default.Sun(),
            "Storm" => new Emojis.TravelPlaces.Color.Default.CloudWithLightningAndRain(),
            "Snowing" => new Emojis.TravelPlaces.Color.Default.CloudWithSnow(),
            "Raining" => new Emojis.TravelPlaces.Color.Default.CloudWithRain(),
            "Raining sunny" => new Emojis.TravelPlaces.Color.Default.SunBehindRainCloud(),
            "Clear" => new Emojis.TravelPlaces.Color.Default.UmbrellaOnGround(),
            "Patchy rain nearby" => new Emojis.TravelPlaces.Color.Default.SunBehindRainCloud(),
            "Mist" => new Emojis.TravelPlaces.Color.Default.Cloud(),
            _ => new Emojis.TravelPlaces.Color.Default.Rainbow()
        };
    }
}
