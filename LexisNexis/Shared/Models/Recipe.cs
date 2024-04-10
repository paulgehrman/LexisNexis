namespace LexisNexis.Shared.Models
{
    public class Recipe
    {
        public int RecipeId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string? ImageName { get; set; }
        public byte[]? Image { get; set; }
        public List<RecipeIngredient>? RecipeIngredients { get; set; } = new();
        public List<RecipeInstruction>? RecipeInstructions { get; set; } = new();
    }
    
}
