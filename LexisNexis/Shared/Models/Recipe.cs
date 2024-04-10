using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexisNexis.Shared.Models
{
    public class Recipe
    {
        public int RecipeId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<RecipeIngredient>? RecipeIngredients { get; set; } = new();
        public List<RecipeInstruction>? RecipeInstructions { get; set; } = new();
    }
}
