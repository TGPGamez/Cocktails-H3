using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails_H3.Models.Entities
{
    public abstract class Liquid : Ingridient
    {
        public double AmountML { get; set; }

        public Liquid(string name, double amountML) : base(name)
        {
            this.AmountML = amountML;
        }

        public Liquid()
        {

        }
    }
}
