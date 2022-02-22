using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails_H3.Models.Entities
{
    public abstract class Ingridient
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public Ingridient(string name)
        {
            this.Name = name;
        }

        public Ingridient()
        {

        }
    }
}
