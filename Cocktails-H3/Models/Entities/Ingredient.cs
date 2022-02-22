using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails_H3.Models.Entities
{
    public abstract class Ingredient
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public Ingredient(string name)
        {
            this.Name = name;
        }

        public Ingredient()
        {

        }

        
    }
}
