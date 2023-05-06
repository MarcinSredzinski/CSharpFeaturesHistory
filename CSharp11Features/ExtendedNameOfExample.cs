namespace CSharp11Features;

internal class ExtendedNameOfExample : IExample
{
    public void Execute()
    {
       
    }

    //The of nameof has been extender, so it's now available e.g. in the attribute and allows to mark properties. 
    [Name(nameof(text))]
    public void Test(string text)
    { }
}
public class NameAttribute : Attribute
{

#pragma warning disable IDE0052 // Remove unread private members
    private readonly string text;
#pragma warning restore IDE0052 // Remove unread private members

    public NameAttribute(string text)
    {
        this.text = text;
    }
}