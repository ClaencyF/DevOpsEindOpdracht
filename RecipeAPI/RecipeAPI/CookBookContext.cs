using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeAPI
{
    public class CookBookContext: DbContext
    {
        public CookBookContext (DbContextOptions<CookBookContext> options): base(options)
        {

        }

        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }


      
    }
}
