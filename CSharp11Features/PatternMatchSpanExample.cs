namespace CSharp11Features;

internal class PatternMatchSpanExample : IExample
{
    public void Execute()
    {
        ReadOnlySpan<char> fullName = "Joe Bloggs";
        if (fullName is "Joe Bloggs")
        {
            Console.WriteLine("Name is Joe Bloggs");
        }
        if (fullName is ['J', ..])
        {
            Console.WriteLine("Name starts with J");
        }
        if (fullName is [.., 's'])
        {
            Console.WriteLine("Name ends with s");
        }
    }
}
