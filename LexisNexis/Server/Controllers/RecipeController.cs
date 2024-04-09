using LexisNexis.Server.Data;
using LexisNexis.Shared.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LexisNexis.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipeController : ControllerBase
    {
        private readonly DataContext _context;

        public RecipeController(DataContext context)
        {
            _context = context;
        }

        /******************************************************************
         * Get All Recipes
        *******************************************************************/
        [HttpGet]
        public async Task<ActionResult<List<Recipe>>> GetAllRecipes()
        {
            try
            {
                var list = await _context.Recipes
                    .Include(r => r.RecipeIngredients)
                    .Include(r => r.RecipeInstructions)
                    .ToListAsync();

                return Ok(list);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /******************************************************************
         * Get Recipe
        *******************************************************************/
        [HttpGet("{id}")]
        public async Task<ActionResult<Recipe>> GetRecipe(int id)
        {
            try
            {
                //  var recipe = await _context.Recipes.FindAsync(id);

                var recipes = await _context.Recipes
                   .Include(r => r.RecipeIngredients)
                   .Include(r => r.RecipeInstructions)
                   .ToListAsync();

                var recipe = recipes.Where(r => r.RecipeId == id).FirstOrDefault();


                if (recipe == null)
                {
                    return NotFound("This recipe does not exist.");
                }

                return Ok(recipe);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /******************************************************************
         * Add Recipe
        *******************************************************************/
        [HttpPost]
        public async Task<ActionResult<List<Recipe>>> AddRecipe(Recipe recipe)
        {
            try
            {
                _context.Recipes.Add(recipe);
                await _context.SaveChangesAsync();

                return await GetAllRecipes();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /******************************************************************
         * Update Recipe
        *******************************************************************/
        [HttpPut("{id}")]
        public async Task<ActionResult<List<Recipe>>> UpdateRecipe(int id, Recipe recipe)
        {
            try
            {
                var recipes = await _context.Recipes
                .Include(r => r.RecipeIngredients)
                .Include(r => r.RecipeInstructions)
                .ToListAsync();

                var dbRecipe = recipes.Where(r => r.RecipeId == id).FirstOrDefault();

                //var dbRecipe = await _context.Recipes.FindAsync(id);
                //if (dbRecipe == null)
                //{
                //    return NotFound("This recipe does not exist.");
                //}

                dbRecipe.Title = recipe.Title;
                dbRecipe.Description = recipe.Description;
                dbRecipe.RecipeIngredients = recipe.RecipeIngredients;
                dbRecipe.RecipeInstructions = recipe.RecipeInstructions;

                await _context.SaveChangesAsync();

                return await GetAllRecipes();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /******************************************************************
         * Delete Recipe
        *******************************************************************/
        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Recipe>>> DeleteRecipe(int id)
        {
            try
            {
                var dbRecipe = await _context.Recipes.FindAsync(id);
                if (dbRecipe == null)
                {
                    return NotFound("This recipe does not exist.");
                }

                _context.Recipes.Remove(dbRecipe);
                await _context.SaveChangesAsync();

                return await GetAllRecipes();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
