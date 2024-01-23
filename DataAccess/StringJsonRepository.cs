using System.Text.Json;

namespace CookieCookbook.DataAcess;

public class StringJsonRepository : StringsRepository
{
    protected override string StringsToText(List<string> lines)
    {
        return JsonSerializer.Serialize(lines);
    }

    protected override List<string> TextToStrings(string fileContent)
    {
        return JsonSerializer.Deserialize<List<string>>(fileContent);
    }
}