namespace CSharp10Features;

internal class LambdaImprovements
{
    internal void RunExample()
    {
        //That's how it used to be in c# 9
        //Func<string> helloWorld = () => "hello world";
        var helloWorld = () => "hello world";
        Console.WriteLine(helloWorld());

        //This way you can have a lambda that returns null of specific type
        var text = string? () => null;
        //having it like this wouldn't work - delegate type cannot be inferred
        //var text2 = () => null;

    }
}