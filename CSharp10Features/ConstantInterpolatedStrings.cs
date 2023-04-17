namespace CSharp10Features;

internal static class ConstantInterpolatedStrings
{
    internal const string baseString = "Hello";
    internal const string expandedString = baseString + " World!";
    internal const string expandedWithConstInterpolation = $"{baseString} There";
}
