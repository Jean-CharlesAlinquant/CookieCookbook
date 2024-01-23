using CookieCookbook.Recipes;
using CookieCookbook.Recipes.Ingredients;

namespace CookieCookbook.App;

public interface IRecipesUserInteraction
{
    void ShowMessage(string message);
    void Exit();
    void PrintExistingRecipies(IEnumerable<Recipe> allRecipes);
    void PromptToCreateRecipe();
    IEnumerable<Ingredient> ReadIngredientsFromUser();
}