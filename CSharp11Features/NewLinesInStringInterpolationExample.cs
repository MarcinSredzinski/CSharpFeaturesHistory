namespace CSharp11Features;

internal class NewLinesInStringInterpolationExample : IExample
{
    public void Execute()
    {
        var potato = "Potato";
        Console.WriteLine($"Hello, {potato
            .ToLower()}");
    }
}
