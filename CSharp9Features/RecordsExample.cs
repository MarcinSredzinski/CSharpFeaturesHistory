namespace CSharp9Features;

internal class RecordsExample
{
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
