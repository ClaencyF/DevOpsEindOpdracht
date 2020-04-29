using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RecipeAPI
{
    public class Recipe
    {
        public Recipe()
        {
        //    this.Ingredients = new HashSet<Ingredient>();
        }

        [Key]
        public int Recipe_Id { get; set; }

        [Required]
        [StringLength(500, ErrorMessage ="Name length can't be more than 500 characters.")]
        public string Name { get; set; }

        public string Description { get; set; }

       // public ICollection<Ingredient> Ingredients { get; set; }

        [Range(0,5)]
        public int Rating { get; set; }

        [JsonIgnore]
        public virtual Author Author { get; set; }
       // public int Author_Id { get; set; }

    }
}
