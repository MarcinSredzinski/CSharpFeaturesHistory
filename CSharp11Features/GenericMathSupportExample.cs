using System.Numerics;

namespace CSharp11Features;

internal class GenericMathSupportExample : IExample
{
    public void Execute()
    {
        var numbers = new[] { 1, 2, 3, 4, 5, 0.21 };
        var sum = SumNumbers(numbers);
    }

    T SumNumbers<T>(T[] values) where T : INumber<T>
    {
        T result = T.Zero;
        foreach (var value in values)
        {
            result += value;
        }
        return result;
    }
}
