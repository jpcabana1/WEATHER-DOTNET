using System.Collections;

namespace DemoJWT.Service
{
    public class WeatherForecastService : IWeatherForecastService
    {

        public IEnumerable GetWeatherForecast()
        {
            var summaries = new[]
            {
                "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
            };
            var forecast = Enumerable.Range(1, 5).Select(index =>
              new WeatherForecast
              (
                  DateTime.Now.AddDays(index),
                  Random.Shared.Next(-20, 55),
                  summaries[Random.Shared.Next(summaries.Length)]
              ))
              .ToArray();
            return forecast;
        }
    }
    record WeatherForecast(DateTime Date, int TemperatureC, string? Summary)
    {
        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
    }
}