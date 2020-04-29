using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RecipeAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthorController : Controller
    {

        private readonly CookBookContext context;

        public AuthorController(CookBookContext context)
        {
            this.context = context;
        }

        [Route("authors")]
        [HttpGet]
        public List<Author> GetAllAuthors()
        {
            return context.Authors.ToList();
        }

        [Route("{id}")]
        [HttpGet]
        public IActionResult GetAuthorById(int id)
        {
            var author = context.Authors.Find(id);
            if (author == null)
            {
                return NotFound();
            }
            return Ok(author);
        }

        [HttpPut]
        public IActionResult UpdateAuthor([FromBody] Author updateAuthor)
        {
            var orgAuthor = context.Authors.Find(updateAuthor.Author_Id);
            if (orgAuthor == null)
            {
                return NotFound();
            }

            orgAuthor.Name = updateAuthor.Name;
            orgAuthor.Recipes = updateAuthor.Recipes;


            context.SaveChanges();
            return Ok(orgAuthor);
        }

        [Route("delete/" + "{id}")]
        [HttpDelete]
        public IActionResult DeleteRecipeById(int id)
        {
            var author = context.Authors.Find(id);
            if (author == null)
            {
                return NotFound();
            }
            context.Authors.Remove(author);
            context.SaveChanges();

            return NoContent();
        }
    }
}