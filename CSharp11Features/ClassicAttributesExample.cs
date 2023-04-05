using CSharp11Features.GenericAttributes;

namespace CSharp11Features;

public class ClassicAttributesExample : IExample
{

    public void Execute()
    {
        SampleClass sampleClass = new SampleClass();

        var authors = Attribute.GetCustomAttributes(sampleClass.GetType()).Where(a => a is AuthorAttribute);

        foreach (AuthorAttribute author in authors)
        {
            Console.WriteLine(author.Name);
        }
    }
}