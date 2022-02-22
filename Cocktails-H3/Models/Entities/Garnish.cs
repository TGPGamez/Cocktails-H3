using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails_H3.Models.Entities
{
    public class Garnish : Ingredient
    {
        public string Desc { get; set; }

        public Garnish(string name, string desc) : base(name)
        {
            this.Desc = desc;
        }

        public Garnish(string name) : base(name)
        {
        }

        public Garnish() : base()
        {
        }

        public override string ToString()
        {
            return $"{this.Name} : {this.Desc}";
        }
    }
}
