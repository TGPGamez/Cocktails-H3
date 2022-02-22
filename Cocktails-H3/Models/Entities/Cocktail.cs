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
        public List<Ingridient> Ingridients { get; set; }


        public Cocktail(string name, List<Ingridient> ingridients)
        {
            this.Name = name;
            this.Ingridients = ingridients;
        }

        public Cocktail()
        {
            
        }
    }
}
