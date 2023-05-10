using Common.Library;

namespace CSharp9Features;

public class IsNotNullPatternExample : IExample
{
    public void Execute()
    {
        WeatherForecast? forecast = null;

        if (forecast is not null)
        {
            Console.WriteLine("Potato is not null.");
        }
    }
}