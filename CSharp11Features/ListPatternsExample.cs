namespace CSharp11Features;

internal class ListPatternsExample : IExample
{
    public void Execute()
    {
       int[] numbers = {1,2,3,4};

        Console.WriteLine(numbers is [1,2,3,4]);
        Console.WriteLine(numbers is [>0, >=2, 3, >3]);

        if (numbers is [1, _, _, >3])
        {
            Console.WriteLine("It went inside this if.");
        }

        if (numbers is [1, .. var rest])
        {
            Console.WriteLine($"First element is not important, but the rest is: {string.Join(',', rest)}.");
        }

        var name = Array.Empty<string>();
        var fullName = new[] { "Joe Bloggs" };
        var fullNameBroken = new[] { "Joe", "Bloggs" };
        var fullNameBrokenUp = new[] { "mr", "Joe", "Bloggs" };

        var text = fullNameBrokenUp switch
        {
            [] => "Name is empty",
            [var theFullName] => $"My name is: {theFullName}",
            [var firstName, var lastName] => $"My full name is: {firstName} {lastName}",
            _ => "The name doesn't matter"
        };
        Console.WriteLine(text);

    }
}
