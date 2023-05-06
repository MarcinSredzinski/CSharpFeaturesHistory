using CSharp11Features.GenericAttributes.Genres;

namespace CSharp11Features.GenericAttributes;

[AuthorGenre<SciFi>()]
public class PWatts : IAuthor
{
    public string? FirstName { get; set; }
}
