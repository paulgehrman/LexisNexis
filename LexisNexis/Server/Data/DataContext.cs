using Microsoft.EntityFrameworkCore;
using LexisNexis.Shared.Models;

namespace LexisNexis.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<RecipeIngredient> RecipeIngredients { get; set;}
        public DbSet<RecipeInstruction> RecipeInstructions { get; set; }
    }
}
