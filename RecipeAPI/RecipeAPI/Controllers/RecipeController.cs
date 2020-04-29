using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace RecipeAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RecipeController : Controller
    {

        private readonly CookBookContext context;

        public RecipeController(CookBookContext context)
        {
            this.context = context;
        }

       [Route("Recipes")]
       [HttpGet]
       public List<Recipe> GetAllRecipes(int? page, string sort, int length = 2, string dir = "asc")
        {

            IQueryable<Recipe> query = context.Recipes;
                    
                     

            //Pages (Lengte kan aangepast worden in de methode hierboven onder de parameter 'length'
            if (page.HasValue)
            {
                query = query.Skip(page.Value * length);
            }
            query = query.Take(length);

            //Sorteer gedeelte
            if (!string.IsNullOrWhiteSpace(sort))
            {
                switch (sort)
                {
                    case "name":
                        if (dir == "asc")
                            query = query.OrderBy(d => d.Name);
                        else if (dir == "desc")
                            query = query.OrderByDescending(d => d.Name);
                    break;

                    case "desc":
                        if (dir == "asc")
                            query = query.OrderBy(d => d.Description);
                        else if (dir == "desc")
                            query = query.OrderByDescending(d => d.Description);
                      break;
                }
            }
            return query.ToList();
        }

        [HttpPost]
        public IActionResult CreateRecipe([FromBody] Recipe newRecipe)
        {
            context.Recipes.Add(newRecipe);
            context.SaveChanges();
            return Created("", newRecipe);
        }

        [Route("byName/{name}")]
        [HttpGet]
        public IActionResult GetRecipe(string name)
        {
            var recipe = context.Recipes
                    .Include(d => d.Author)
                    .ThenInclude(d => d.Author_Id)
                    .SingleOrDefault(d => d.Name == name);
            if (recipe == null)
            {
                return NotFound();
            }
            return Ok(recipe);
        }

        [Route("{id}")]
        [HttpGet]
        public IActionResult GetRecipe(int id)
        {
            var recipe = context.Recipes
                    .Include(d => d.Author)
                    .SingleOrDefault(d => d.Recipe_Id == id);


            if (recipe == null)
            {
                return NotFound();
            }
            return Ok(recipe);
        }

        [Route("delete/"+"{id}")]
        [HttpDelete]
        public IActionResult DeleteRecipe(int id)
        {
            var recipe = context.Recipes.Find(id);
            if (recipe == null)
            {
                return NotFound();
            }
            context.Recipes.Remove(recipe);
            context.SaveChanges();

            return NoContent();
        }

        [HttpPut]
        public IActionResult UpdateRecipe([FromBody] Recipe updateRecipe)
        {
            var orgRecipe = context.Recipes.Find(updateRecipe.Recipe_Id);
            if (orgRecipe == null)
            {
                return NotFound();
            }

            orgRecipe.Name = updateRecipe.Name;
            orgRecipe.Author = updateRecipe.Author;
            orgRecipe.Description = updateRecipe.Description;
            


            context.SaveChanges();
            return Ok(orgRecipe);
        }
    }
}