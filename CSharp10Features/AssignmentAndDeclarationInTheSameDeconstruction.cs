namespace CSharp10Features;

internal class AssignmentAndDeclarationInTheSameDeconstruction
{
    (string firstName, string lastName, int age) Person = ("Joseph", "Smith", 99);

    /// <summary>
    /// Just an example of getting the data from somewhere
    /// </summary>
    /// <param name="firstName">For demonstration purposes</param>
    /// <returns></returns>
    private (string firstName, string lastName, int age) GetPersonBy(string firstName)
    {
        return Person;
    }

    internal void Execute()
    {
        string firstName = "Joseph";
        (firstName, string lastName, _) = GetPersonBy(firstName);
        Console.WriteLine($"{firstName} {lastName}");
    }
}
