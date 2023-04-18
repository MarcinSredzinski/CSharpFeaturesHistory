namespace CSharp10Features;

/// <summary>
/// Records can now be structs (so you gain having them as value type)
/// Read more here: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/record
/// </summary>
/// <param name="name"></param>
internal record struct RecordStructsExample(string Name);