namespace CSharp9Features
{
    internal class KnownObjectTypeShorthandInstantation
    {
        internal void Execute()
        {
            Person person = new() { Age = 1 }; //Type is assumed based on the variable type. 
        }
    }
}
