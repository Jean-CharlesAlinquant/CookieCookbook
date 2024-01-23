namespace CookieCookbook.Recipes.Ingredients;

public class Butter : Ingredient
{
    public override int Id { get; } = 3;
    public override string Name { get; } = "Butter";
    public override string PreparationInstructions =>
         $"Melt on low heat. {base.PreparationInstructions}";
}