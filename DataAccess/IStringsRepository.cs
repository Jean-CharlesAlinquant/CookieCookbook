namespace CookieCookbook.DataAcess;

public interface IStringsRepository
{
    List<string> Read(string filePath);
    void Write(string filePath, List<string> lines);
}