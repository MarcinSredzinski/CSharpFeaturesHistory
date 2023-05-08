namespace CSharp9Features;

internal class IsNotNullPatternExample
{
    internal void Execute()
    {
        WeatherForecast? forecast = null;

        if (forecast is not null)
        {
            Console.WriteLine("Potato is not null.");
        }
    }
}