namespace CookieCookbook.DataAcess;

public class StringsTextualRepository : StringsRepository
{
    private static readonly string Separator = Environment.NewLine;

    protected override string StringsToText(List<string> lines)
    {
        return string.Join(Separator, lines);
    }

    protected override List<string> TextToStrings(string fileContent)
    {
        return fileContent.Split(Separator).ToList();
    }
}
