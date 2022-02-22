using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails_H3.Models.Entities
{
    public class Soft : Liquid
    {
        public Soft(string name, double amountML) : base(name, amountML)
        {

        }

        public Soft(string name) : base(name)
        {

        }

        public Soft() : base()
        {

        }
    }
}
