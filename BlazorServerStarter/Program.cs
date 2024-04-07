using BlazorServerStarter.Components;
using BlazorServerStarter.Configuration;
using BlazorServerStarter.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.FluentUI.AspNetCore.Components;

var builder = WebApplication.CreateBuilder(args);

var config = builder.Configuration;
var services = builder.Services;

services.Configure<WeatherApiClientSettings>(config.GetSection("WeatherApiV1"));

services.AddRazorComponents()
    .AddInteractiveServerComponents();

services.AddHttpClient();
services.AddFluentUIComponents();

services.AddHttpClient<IWeatherForecastService, WeatherForecastService>();

services.AddScoped<IWeatherForecastService, WeatherForecastService>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();