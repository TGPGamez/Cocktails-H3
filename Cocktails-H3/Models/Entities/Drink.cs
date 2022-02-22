using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails_H3.Models.Entities
{
    public class Drink
    {
        public int ID { get; set; }
        public GlassType GlasType { get; set; }
        public Cocktail Cocktail { get; set; }

        public Drink(GlassType glasType, Cocktail cocktail)
        {
            this.GlasType = glasType;
            this.Cocktail = cocktail;
        }

        public Drink() : base()
        {
            this.Cocktail = new Cocktail();
        }
    }
}
