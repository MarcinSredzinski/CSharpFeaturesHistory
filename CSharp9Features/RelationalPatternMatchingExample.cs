using Common.Library;

namespace CSharp9Features;

internal class RelationalPatternMatchingExample : IExample
{
    WeatherForecast[] forecast = new WeatherForecast[] { new WeatherForecast { Temperature = 10 },
                                                    new WeatherForecast { Temperature = 100 },
                                                    new WeatherForecast { Temperature = -110 },
                                                    new WeatherForecast { Temperature = 30 }};

    public void Execute()
    {
        foreach (var weatherForecast in forecast)
        {
            weatherForecast.Description = weatherForecast.Temperature switch
            {
                < -100 => "you will probably freeze to death",
                < 0 => "it will be cold",
                < 30 => "It will be ok",
                > 99 => "you will probably feel very warm",
                _ => "I didn't think about other cases"
            };
        }
    }
}
internal record WeatherForecast
{
    public int Temperature { get; set; }
    public string? Description { get; set; }
}