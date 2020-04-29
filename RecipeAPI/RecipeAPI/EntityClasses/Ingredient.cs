using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeAPI
{
    public class Ingredient
    {
        public Ingredient()
        {
         //   this.Recipes = new HashSet<Recipe>();
        }

        [Key]
        public int Ingredient_Id { get; set; }

        [Required]
        [StringLength(200, ErrorMessage = "Name length can't be more than 200 characters.")]
        public string Name { get; set; }
        
        public string Description { get; set; }
      //  public ICollection<Recipe> Recipes { get; 

    }
}
