namespace CSharp10Features;

internal class ExtendedPropertyPatterns
{
    internal record Box(int weight, Box? box = null);
    internal void Execute()
    {
        var nestedBox = new Box(11);
        var box = new Box(10, nestedBox);

        /*You used to do it like this
        if (box is { box: { weight: > 10 } })
        {
            Console.WriteLine("Nested box weights more than 10 units.");
        }
        But now we can do it like this: */
        if (box is { box.weight: > 10 })
        {
            Console.WriteLine("Nested box weights more than 10 units.");
        }
    }
}