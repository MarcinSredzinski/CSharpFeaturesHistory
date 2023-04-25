namespace CSharp9Features;

internal class InitSettersExample
{
    void Execute()
    {
        var person = new Person();
       // person.Age = 50; - results in error. You can only set init statements in constructor, on base or in initialization of the object.

    }
}
internal class Person
{
    //init - once set, it's readonly
    public int Age { get; init; }
}