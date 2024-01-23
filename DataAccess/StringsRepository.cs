// Template method Design pattern with TextToStrings and StringsToText as abstract
namespace CookieCookbook.DataAcess;

public abstract class StringsRepository : IStringsRepository
{
    public List<string> Read(string filePath)
    {
        if (File.Exists(filePath))
        {
            var fileContent = File.ReadAllText(filePath);
            return TextToStrings(fileContent);
        }
        return new List<string>();
    }

    protected abstract List<string> TextToStrings(string fileContent);

    public void Write(string filePath, List<string> lines)
    {
        File.WriteAllText(filePath, StringsToText(lines));
    }

    protected abstract string StringsToText(List<string> lines);
}
