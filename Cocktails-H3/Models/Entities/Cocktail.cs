using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails_H3.Models.Entities
{
    public class Cocktail
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Ingredient> Ingredients { get; set; }


        public Cocktail(string name, List<Ingredient> ingredients)
        {
            this.Name = name;
            this.Ingredients = ingredients;
        }

        public Cocktail() : base()
        {
            this.Ingredients = new List<Ingredient>();
        }
    }
}
