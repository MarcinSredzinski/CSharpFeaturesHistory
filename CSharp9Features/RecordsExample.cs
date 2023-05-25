using Common.Library;

namespace CSharp9Features;

internal class RecordsExample : IExample
{
    public void Execute()
    {
        var testPerson1 = new TestPerson("John", "Connor");
        var testPerson2 = new TestPersonClass("Sarah", "Connor");
        Console.WriteLine(testPerson1);
        Console.WriteLine(testPerson2);
    }
}

//reference type
//immutable
public record TestPerson(string FirstName, string LastName);

public class TestPersonClass
{
    public TestPersonClass(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
    public string FirstName { get; init; }
    public string LastName { get; init; }
}
