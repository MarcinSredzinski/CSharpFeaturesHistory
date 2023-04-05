using CSharp11Features.GenericAttributes.Genres;

namespace CSharp11Features.GenericAttributes;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class AuthorGenreAttribute<T> : Attribute where T : IGenre
{
}