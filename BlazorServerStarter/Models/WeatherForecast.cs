using Newtonsoft.Json;

namespace BlazorServerStarter.Models;

public class WeatherForecast
{
    public Location? Location { get; set; }

    public Current? Current { get; set; }

    public Forecast? Forecast { get; set; }
}

public class Current
{
    [JsonProperty("last_updated_epoch")]
    public int? LastUpdatedEpoch { get; set; }

    [JsonProperty("last_updated")]
    public string? LastUpdated { get; set; }

    [JsonProperty("temp_c")]
    public decimal? TemperatureInC { get; set; }

    [JsonProperty("temp_f")]
    public decimal? TemperatureInF { get; set; }

    [JsonProperty("is_day")]
    public bool? IsDay { get; set; }
}

public class Location
{
    public string? Name { get; set; }

    public string? Region { get; set; }

    [JsonProperty("lat")]
    public decimal? Latitude { get; set; }

    [JsonProperty("lon")]
    public decimal? Longitude { get; set; }

    public string? LocalTime { get; set; }
}

public class Forecast
{
    [JsonProperty("forecastday")]
    public List<ForecastDay>? ForecastDay { get; set; }
}

public class ForecastDay
{
    public string? Date { get; set; }

    public int? date_epoch { get; set; }

    [JsonProperty("day")]
    public Day? Day { get; set; }

    [JsonProperty("astro")]
    public Astro? Astro { get; set; }

    [JsonProperty("hour")]
    public List<Hour>? Hour { get; set; }
}

public class Astro
{
    public string? Sunrise { get; set; }

    public string? Sunset { get; set; }

    public string? Moonrise { get; set; }

    public string? Moonset { get; set; }

    [JsonProperty("moon_phase")]
    public string? MoonPhase { get; set; }

    [JsonProperty("moon_illumination")]
    public string? MoonIllumination { get; set; }

    [JsonProperty("is_moon_up")]
    public bool? IsMoonUp { get; set; }

    [JsonProperty("is_sun_up")]
    public bool? IsSunUp { get; set; }
}

public class Hour
{
    [JsonProperty("time_epoch")]
    public int? TimeEpoch { get; set; }

    public string? Time { get; set; }

    [JsonProperty("temp_c")]
    public decimal? TemperatureInC { get; set; }

    [JsonProperty("temp_f")]
    public decimal? TemperatureInF { get; set; }

    [JsonProperty("is_day")]
    public bool? IsDay { get; set; }

    [JsonProperty("condition")]
    public Condition Condition { get; set; } = new();

    [JsonProperty("wind_mph")]
    public decimal? WindInMilesPerHour { get; set; }

    [JsonProperty("wind_kph")]
    public decimal? WindInKilometersPerHour { get; set; }

    [JsonProperty("wind_degree")]
    public int? WindDegree { get; set; }

    [JsonProperty("wind_dir")]
    public string? WindDirection { get; set; }

    [JsonProperty("pressure_mb")]
    public decimal? PressureInMillibars { get; set; }

    [JsonProperty("pressure_in")]
    public decimal? PressureInNewtons { get; set; }

    [JsonProperty("precip_mm")]
    public decimal? PrecipitationInMilimeters { get; set; }

    [JsonProperty("precip_in")]
    public decimal? PrecipitationInInches { get; set; }

    [JsonProperty("snow_cm")]
    public decimal? SnowLevelInCentimeters { get; set; }

    public int? Humidity { get; set; }

    public int? Cloud { get; set; }

    [JsonProperty("feelslike_c")]
    public decimal? FeelsLikeTemperatureInC { get; set; }

    [JsonProperty("feelslike_f")]
    public decimal? FeelsLikeTemperatureInF { get; set; }

    [JsonProperty("windchill_c")]
    public decimal? WindChillInC { get; set; }
    
    [JsonProperty("windchill_f")]
    public decimal? WindChillInF { get; set; }

    [JsonProperty("heatindex_c")]
    public decimal? HeatIndexInC { get; set; }

    [JsonProperty("heatindex_f")]
    public decimal? HeatIndexInF { get; set; }

    [JsonProperty("dewpoint_c")]
    public decimal? DewPointInC { get; set; }

    [JsonProperty("dewpoint_f")]
    public decimal? DewPointInF { get; set; }

    [JsonProperty("will_it_rain")]
    public bool? WillItRain { get; set; }

    [JsonProperty("chance_of_rain")]
    public int? ChanceOfRain { get; set; }

    [JsonProperty("will_it_snow")]
    public bool? WillItSnow { get; set; }

    [JsonProperty("chance_of_snow")]
    public int? ChanceOfSnow { get; set; }

    [JsonProperty("vis_km")]
    public decimal? VisibilityInKilometers { get; set; }

    [JsonProperty("vis_miles")]
    public decimal? VisibilityInMiles { get; set; }

    [JsonProperty("gust_mph")]
    public decimal? WindGustInMilesPerHour { get; set; }

    [JsonProperty("gust_kph")]
    public decimal? WindGustInKilometersPerHour { get; set; }

    [JsonProperty("uv")]
    public decimal? UltraVioletLevel { get; set; }
}

public class Day
{
    [JsonProperty("maxtemp_c")]
    public decimal? MaxTemperatureInC { get; set; }

    [JsonProperty("maxtemp_f")]
    public decimal? MaximumTemperatureInF { get; set; }

    [JsonProperty("mintemp_c")]
    public decimal? MinimumTemperatureInC { get; set; }

    [JsonProperty("mintemp_f")]
    public decimal? MinimumTemperatureInF { get; set; }

    [JsonProperty("avgtemp_c")]
    public decimal? AverageTemperatureInC { get; set; }

    [JsonProperty("avgtemp_f")]
    public decimal? AverageTemperatureInF { get; set; }

    [JsonProperty("maxwind_mph")]
    public decimal? MaxWindInMilesPerHour { get; set; }

    [JsonProperty("maxwind_kph")]
    public decimal? MaxWindInKilometers { get; set; }

    [JsonProperty("totalprecip_mm")]
    public decimal? TotalPrecipitationInMilimeters { get; set; }

    [JsonProperty("totalprecip_in")]
    public decimal? TotalPrecipitationInInches { get; set; }

    [JsonProperty("totalsnow_cm")]
    public decimal? TotalSnowInCentimeters { get; set; }

    [JsonProperty("avgvis_km")]
    public decimal? AverageVisibilityInKilometers { get; set; }

    [JsonProperty("avgvis_miles")]
    public decimal? AverageVisibilityInMiles { get; set; }

    [JsonProperty("avghumidity")]
    public decimal? AverageHumidity { get; set; }

    [JsonProperty("daily_will_it_rain")]
    public bool? DailyWillItRain { get; set; }

    [JsonProperty("daily_chance_of_rain")]
    public int? daily_chance_of_rain { get; set; }

    [JsonProperty("daily_chance_of_snow")]
    public int? DailyChanceOfSnow { get; set; }

    [JsonProperty("condition")]
    public Condition? Condition { get; set; }

    [JsonProperty("uv")]
    public decimal? UltraVioletLevel { get; set; }
}

public class Condition
{
    public string Text { get; set; } = string.Empty;

    public string? Icon { get; set; }

    public int? Code { get; set; }
}