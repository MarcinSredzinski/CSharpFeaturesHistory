namespace CSharp9Features;

internal class LogicalPatternMatchingExample
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
                -101 or -102 => "Close to -100, but you will still freeze",
                < -100 => "you will probably freeze to death",               
                < 0 => "it will be cold",
                < 30 => "It will be ok",
                //here we have an example of logical pattern matching example
                >=30 and < 99 => "Don't stay outside for too long",
                > 99 => "you will probably feel very warm",
                _ => "I didn't think about other cases"
            };
        }
    }
}