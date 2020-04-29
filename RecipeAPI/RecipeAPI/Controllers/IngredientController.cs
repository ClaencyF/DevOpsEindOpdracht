using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RecipeAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IngredientController : Controller
    {

        private readonly CookBookContext context;

        public IngredientController (CookBookContext context)
        {
            this.context = context;
        }
      
        [Route("ingredients")]
        [HttpGet]
        public List<Ingredient> GetAllIngredients()
        {
            return context.Ingredients.ToList();
        }

        [Route("delete/" + "{id}")]
        [HttpDelete]
        public IActionResult DeleteIngredientById(int id)
        {
            var ingr = context.Ingredients.Find(id);
            if (ingr == null)
            {
                return NotFound();
            }
            context.Ingredients.Remove(ingr);
            context.SaveChanges();

            return NoContent();
        }

        [Route("{id}")]
        [HttpGet]
        public IActionResult GetIngredientById(int id)
        {
            var ingredient = context.Ingredients.Find(id);
            if (ingredient == null)
            {
                return NotFound();
            }
            return Ok(ingredient);
        }

        [HttpPut]
        public IActionResult UpdateIngredient([FromBody] Ingredient updateIngredient)
        {
            var orgIngredient = context.Ingredients.Find(updateIngredient.Ingredient_Id);
            if (orgIngredient == null)
            {
                return NotFound();
            }

            orgIngredient.Name = updateIngredient.Name;
            orgIngredient.Description = updateIngredient.Description;
         //   orgIngredient.Recipes = updateIngredient.Recipes;

            context.SaveChanges();
            return Ok(orgIngredient);
        }

    }
}