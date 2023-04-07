namespace CSharp11Features;

internal class RequiredMembersExample : IExample
{
    public void Execute()
    {
        var potato = new Potato() { Weight = 123 }; //Providing Weight is required at compile time. 
        Console.WriteLine(potato.Weight);
    }
}

internal class Potato
{
    public required int Weight { get; set; }
}