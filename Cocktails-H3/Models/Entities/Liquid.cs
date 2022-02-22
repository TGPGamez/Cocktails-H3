using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails_H3.Models.Entities
{
    public abstract class Liquid : Ingredient
    {
        public double AmountML { get; set; }

        public Liquid(string name, double amountML) : base(name)
        {
            this.AmountML = amountML;
        }

        public Liquid(string name) : base(name)
        {

        }

        public Liquid() : base()
        {

        }

        public override string ToString()
        {
            return $"{this.Name} : {this.AmountML} ml";
        }
    }
}
