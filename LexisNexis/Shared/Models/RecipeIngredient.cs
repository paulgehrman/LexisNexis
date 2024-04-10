
namespace LexisNexis.Shared.Models
{
    public class RecipeIngredient
    {
        public int RecipeIngredientId { get; set; }
        public int RecipeId { get; set; }
        public string Ingredient { get; set; }

        public RecipeIngredient(int recipeId, string ingredient)
        {
            this.RecipeId = recipeId;
            this.Ingredient = ingredient;
        }
    }
}
