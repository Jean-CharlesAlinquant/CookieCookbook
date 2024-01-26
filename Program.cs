using CookieCookbook.App;
using CookieCookbook.DataAcess;
using CookieCookbook.FileAccess;
using CookieCookbook.Recipes;
using CookieCookbook.Recipes.Ingredients;

try
{
    const FileFormat Format = FileFormat.Json;
    IStringsRepository stringsRepository = Format == FileFormat.Json ?
        new StringJsonRepository() :
        new StringsTextualRepository();

    const string fileName = "recipes";
    var fileMetaData = new FileMetadata(fileName, Format);

    var ingredientsRegister = new IngredientsRegister();

    var cookiesRecipesApp = new CookiesRecipesApp(
        new RecipesRepository(stringsRepository, ingredientsRegister),
        new RecipesConsoleUserInteraction(ingredientsRegister)
    );
    cookiesRecipesApp.Run(fileMetaData.ToPath());
}
catch (Exception ex)
{
    Console.WriteLine("Sorry! The application experienced" +
        " an unexpected error and will have to be closed. " +
        "The error message: " + ex.Message);

    Console.WriteLine("Press any key to close.");
    Console.ReadKey();
}