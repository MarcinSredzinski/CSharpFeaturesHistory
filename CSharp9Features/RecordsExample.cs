using Common.Library;

namespace CSharp9Features;

internal class RecordsExample : IExample
{
    public void Execute()
    {
        var testPerson1 = new TestPerson("John", "Connor");
        var testPerson2 = new TestPersonClass("Sarah", "Connor");
        //Difference between .ToString() method
        Console.WriteLine(testPerson1);
        Console.WriteLine(testPerson2);

        //Comparing object
        var testPerson3 = new TestPerson("John", "Connor");
        var testPerson4 = new TestPersonClass("Sarah", "Connor");

        Console.WriteLine(Equals(testPerson1, testPerson3));
        Console.WriteLine(Equals(testPerson2,testPerson4));

        Console.WriteLine(ReferenceEquals(testPerson1, testPerson3));
        Console.WriteLine(ReferenceEquals(testPerson2, testPerson4));
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
