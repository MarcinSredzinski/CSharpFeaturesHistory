using System.Buffers;

namespace CSharp11Features;

internal class RefFieldsAndScopedRefExample : IExample
{
    public void Execute()
    {
        var textHolder = new TextHolder(16);
        Span<char> values = stackalloc char[4] { 'c', 'o', 'd', 'e' };
        textHolder.Append(values);
    }
}

public ref struct TextHolder
{
    private readonly Span<char> _chars;
    private int _pos;

    public TextHolder(int size)
    {
        _chars = ArrayPool<char>.Shared.Rent(size);
        _pos = 0;
    }

    /// <summary>
    /// Thanks to the "scoped" keyword, you avoid problems with exposing referenced variables outside of their declaration scope
    /// </summary>
    /// <param name="value"></param>
    public void Append(scoped ReadOnlySpan<char> value)
    {
        if (value.TryCopyTo(_chars.Slice(_pos)))
        {
            _pos += value.Length;
        }
    }

    public override string ToString() => new(Text);

    private ReadOnlySpan<char> Text => _chars[.._pos];
}