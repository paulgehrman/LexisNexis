using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexisNexis.Shared.Models
{
    public class RecipeInstruction
    {
        public int RecipeInstructionId { get; set; }
        public int RecipeId { get; set; }
        public string Instruction { get; set; }

        public RecipeInstruction(int recipeId, string instruction)
        {
            this.RecipeId = recipeId;
            this.Instruction = instruction;
        }
    }
}
