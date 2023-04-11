namespace NumericIntPointerExample;

/// <summary>
/// Refer to https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/unsafe-code to read some more
/// </summary>
class NumericIntPointerExample
{
    nint intPtr = IntPtr.Zero; //nint is alias for IntPtr (like string is to String)
    nuint uIntPtr = UIntPtr.Zero;
}