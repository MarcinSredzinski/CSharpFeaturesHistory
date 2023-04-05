using CSharp11Features.GenericAttributes;
using CSharp11Features.GenericAttributes.Genres;

namespace CSharp11Features;

internal class GenericAttributesExample : IExample
{
    public void Execute()
    {
        var authorsWithGenres = new List<IAuthor>
        {
            new UKLeGuin() { FirstName = "Ursula" },
            new PWatts() { FirstName = "Petter" }
        };

        foreach (var author in authorsWithGenres)
        {
            var genreType = System.Attribute.GetCustomAttributes(author.GetType()).Where(a => a is AuthorGenreAttribute<SciFi>);
            if (genreType.Any())
            {
                //This is just an example of how and why you can use generic attributes. The type in the output is representation of .net class, that can be used in different scenarios. 
                Console.WriteLine($"During his / her lifetime, the {author.FirstName} has mastered C# Type: {genreType.FirstOrDefault()}");
            }
        }
    }
}