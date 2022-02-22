using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails_H3.Models.Entities
{
    public class Alcohol : Liquid
    {
        public Alcohol(string name, double amountML) : base(name, amountML)
        {

        }

        public Alcohol(string name) : base(name)
        {

        }

        public Alcohol() : base()
        {

        }
    }
}
