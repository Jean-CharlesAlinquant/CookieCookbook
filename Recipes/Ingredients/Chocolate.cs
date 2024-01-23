namespace CookieCookbook.Recipes.Ingredients;

public class Chocolate : Ingredient
{
    public override int Id { get; } = 4;
    public override string Name { get; } = "Chocolate";
    public override string PreparationInstructions =>
         $"Melt in a water bath. {base.PreparationInstructions}";
}