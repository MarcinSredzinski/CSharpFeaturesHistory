namespace CSharp11Features;

internal class ImprovedMethodGroupConversionToDelegate
{
    private static readonly List<int> Ages = Enumerable.Range(0, 100).ToList();

    /// <summary>
    /// Pre c# 11 this code would run faster
    /// </summary>
    /// <returns></returns>
    internal int Sum()
    { 
        return Ages.Where(x => Filter(x)).Sum();
    }

    /// <summary>
    /// Now it is optimized and improved
    /// </summary>
    /// <returns></returns>
    internal int SumMethodGroup()
    {
        return Ages.Where(Filter).Sum();
    }

    static bool Filter(int age)
    {
        return age > 50;
    }
}
