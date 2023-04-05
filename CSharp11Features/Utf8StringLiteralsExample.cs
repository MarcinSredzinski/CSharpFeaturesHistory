using System.Text;

namespace CSharp11Features;

internal class Utf8StringLiteralsExample : IExample
{
    public void Execute()
    {
        //Text as utf8 byte array
        ReadOnlySpan<byte> text = "Potato Potato"u8;


        //Notice difference in the size of the array
        ReadOnlySpan<byte> u16A = Encoding.Unicode.GetBytes("A"); //Two elements
        ReadOnlySpan<byte> u8A = "A"u8; //One element
    }
}
