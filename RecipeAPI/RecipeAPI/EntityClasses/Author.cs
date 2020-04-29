using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RecipeAPI
{
    public class Author
    {
         [Required]
         public string Name { get; set; }

         [EmailAddress]
         public string Email_Adress { get; set; }
      
        // public ICollection<Recipe> Recipes { get; set; }

         [Key]
         public int  Author_Id { get; set; }


        [JsonIgnore]
        public ICollection<Recipe> Recipes { get; set; }
    }
}
