using CookieCookbook.DataAcess;
using CookieCookbook.Recipes.Ingredients;

namespace CookieCookbook.Recipes;

public class RecipesRepository : IRecipesRepository
{
    private readonly IStringsRepository _stringsRepository;
    private readonly IIngredientsRegister _ingredientsRegister;
    private const string Separator = ",";


    public RecipesRepository(IStringsRepository stringsRepository, IIngredientsRegister ingredientsRegister)
    {
        _stringsRepository = stringsRepository;
        _ingredientsRegister = ingredientsRegister;
    }

    public List<Recipe> Read(string filePath)
    {
        List<string> recipesFromFile = _stringsRepository.Read(filePath);
        var recipes = new List<Recipe>();
        foreach (var ingredientsAsString in recipesFromFile)
        {
            var recipe = RecipeFromStrings(ingredientsAsString);
            recipes.Add(recipe);
        }
        return recipes;
    }

    private Recipe RecipeFromStrings(string ingredientsAsString)
    {
        var ingredients = new List<Ingredient>();
        var ingredientIds = ingredientsAsString.Split(Separator);

        foreach (var ingredientId in ingredientIds)
        {
            var id = int.Parse(ingredientId);
            var ingredient = _ingredientsRegister.GetById(id);
            if (ingredient is not null)
            {
                ingredients.Add(ingredient);
            }
        }
        return new Recipe(ingredients);
    }

    public void Write(string filePath, List<Recipe> allRecipes)
    {
        var recipesAsStrings = new List<string>();
        foreach (var recipe in allRecipes)
        {
            var ingredientIds = new List<int>();
            foreach (var ingredient in recipe.Ingredients)
            {
                ingredientIds.Add(ingredient.Id);
            }
            recipesAsStrings.Add(string.Join(Separator, ingredientIds));
        }

        _stringsRepository.Write(filePath, recipesAsStrings);
    }
}