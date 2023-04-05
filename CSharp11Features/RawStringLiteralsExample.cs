using System.Text;

namespace CSharp11Features;

internal class RawStringLiteralsExample : IExample
{
    public void Execute()
    {
        var sb = new StringBuilder();

        //Classic with escape (\)
        var xmlPrologue = "<?xml version \"1.0\" encoding=\"UTF-8\"?>";

        //with verbatim string (two double quotes "")
        var xmlPrologue2 = @"<?xml version ""1.0"" encoding=""UTF-8""?>";

        //with raw string literals (triple "")
        var xmlPrologue3 = """<?xml version "1.0" encoding="UTF-8"?>""";

        //variant of raw string literals - what if you have triple double quotes? Use Four double quotes.
        var xmlPrologue4 = """"<?xml version "1.0" encoding="UTF-8"?>"""";

        //works also with json (and it's nice to read) 
        var jsonExample = """
            {
                "value": 123
            }
            """;

        int value = 123;
        var jsonExampleWithStringInterpolation = $$"""
            {
                "value": {{value}}
            }
            """;

        sb.AppendLine(xmlPrologue);
        sb.AppendLine(xmlPrologue2);
        sb.AppendLine(xmlPrologue3);
        sb.AppendLine(xmlPrologue4);
        sb.AppendLine(jsonExample);
        sb.AppendLine(jsonExampleWithStringInterpolation);

        //logic for writing xml

        Console.WriteLine(sb.ToString());
    }
}