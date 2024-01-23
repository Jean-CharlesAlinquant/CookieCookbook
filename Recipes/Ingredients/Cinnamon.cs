namespace CookieCookbook.Recipes.Ingredients;

public class Cinnamon : Spice
{
    public override int Id { get; } = 7;
    public override string Name { get; } = "Cinnamon";
    public override string PreparationInstructions =>
         $"Take half a teaspoon. {base.PreparationInstructions}";
}