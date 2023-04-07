namespace CSharp11Features.FileScopedTypes;

internal class FileScopedTypesExample : IExample
{
    public void Execute()
    {
        var user = new User(); //you can only see the user from User1.cs file, since the class defined in User2 is file-scoped. 
        user.Hello();
    }
}
