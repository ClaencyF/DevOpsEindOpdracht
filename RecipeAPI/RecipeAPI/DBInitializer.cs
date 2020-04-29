using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeAPI
{
    public class DBInitializer
    {
        public static void Initialize(CookBookContext context)
        {
            //Class to fill database with test data.
            context.Database.EnsureCreated();



            var r1 = new Recipe()
            {
                Name = "Balletjes in tomatensaus.",
                Description = "Vlaamse klassieker.",
                Author = new Author()
                {
                    Name = "Jos",
                    Email_Adress = "aaa@aa.com"
                }
            };
            context.Add(r1);
            context.SaveChanges();
        }
    }
}

