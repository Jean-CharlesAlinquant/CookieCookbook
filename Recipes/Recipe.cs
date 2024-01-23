using CookieCookbook.Recipes.Ingredients;

namespace CookieCookbook.Recipes;

public class Recipe
{
    // TOPTIP: Use IEnumerable instead of List to make sure 
    // the user doesn't accidentely manipulate the list 
    public IEnumerable<Ingredient> Ingredients { get; }

    public Recipe(IEnumerable<Ingredient> ingredients)
    {
        Ingredients = ingredients;
    }

    public override string ToString()
    {
        var steps = new List<string>();
        foreach (var ingredient in Ingredients)
        {
            steps.Add($"{ingredient.Name}. {ingredient.PreparationInstructions}");
        }
        return string.Join(Environment.NewLine, steps);
    }
}