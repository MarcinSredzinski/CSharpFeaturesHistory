using CSharp11Features.GenericAttributes.Genres;

namespace CSharp11Features.GenericAttributes;

[AuthorGenre<Fantasy>()]
public class UKLeGuin : IAuthor
{
    public string? FirstName { get; set; }
}
