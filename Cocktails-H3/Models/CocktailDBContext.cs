using Cocktails_H3.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails_H3.Models
{
    public class CocktailDBContext : DbContext
    {
        public DbSet<Drink> Drinks { get; set; }
        //public DbSet<Cocktail> Cocktails { get; set; }
        public DbSet<Ingredient> Ingredients_Recipes { get; set; }
        //public DbSet<Liquid> Liquids { get; set; }
        //public DbSet<Alcohol> Alcohols { get; set; }
        //public DbSet<Soft> Softs { get; set; }

        

        public CocktailDBContext() : base()
        {
            this.Configuration.LazyLoadingEnabled = false;
        }
    }
}
