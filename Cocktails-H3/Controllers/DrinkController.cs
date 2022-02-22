using Cocktails_H3.Models;
using Cocktails_H3.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails_H3.Controllers
{
    public class DrinkController : IController<Drink, string>
    {
        public void Create(Drink drink)
        {
            using (CocktailDBContext ctx = new CocktailDBContext())
            {
                ctx.Drinks.Add(drink);
                ctx.SaveChanges();
            }
        }

        public void Delete(string key)
        {
            using (CocktailDBContext ctx = new CocktailDBContext())
            {
                foreach (Drink drink in ctx.Drinks)
                {
                    ctx.Entry(drink).Reference(d => d.Cocktail).Load();
                    if (drink.Cocktail.Name.ToLower() == key.ToLower())
                    {
                        ctx.Drinks.Remove(drink);
                        break;
                    }
                }
                ctx.SaveChanges();
            }
        }

        public void DeleteAll()
        {
            using (CocktailDBContext ctx = new CocktailDBContext())
            {
                ctx.Drinks.RemoveRange(ctx.Drinks);
                ctx.SaveChanges();
            }
        }

        public Drink Get(string key)
        {
            using (CocktailDBContext ctx = new CocktailDBContext())
            {
                foreach (Drink drink in ctx.Drinks)
                {
                    ctx.Entry(drink).Reference(d => d.Cocktail).Load();
                    if (drink.Cocktail.Name.ToLower() == key.ToLower())
                    {
                        ctx.Entry(drink.Cocktail).Collection(c => c.Ingredients).Load();
                        return drink;
                    }
                }
            }
            return null;
        }

        public List<Drink> GetAll()
        {
            List<Drink> drinks = new List<Drink>();
            using (CocktailDBContext ctx = new CocktailDBContext())
            {
                foreach (Drink drink in ctx.Drinks)
                {
                    ctx.Entry(drink).Reference(d => d.Cocktail).Load();
                    //NOT WORKING
                    ctx.Entry(drink.Cocktail).Collection(c => c.Ingredients).Load();
                    drinks.Add(drink);
                }
            }
            return drinks;
        }

        public void Update(Drink obj)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Used to get drinks by a contain search
        /// </summary>
        /// <param name="searchFor"></param>
        /// <param name="searchOption">Type of search</param>
        /// <returns></returns>
        public List<Drink> GetBySearch(string searchFor, int searchOption)
        {
            List<Drink> drinks = new List<Drink>();
            using (CocktailDBContext ctx = new CocktailDBContext())
            {
                foreach (Drink drink in ctx.Drinks)
                {
                    ctx.Entry(drink).Reference(d => d.Cocktail).Load();
                    ctx.Entry(drink.Cocktail).Collection(c => c.Ingredients).Load();
                    switch (searchOption)
                    {
                        //Search by name
                        case 1:
                            if (drink.Cocktail.Name.ToLower() == searchFor.ToLower())
                            {
                                drinks.Add(drink);
                            }
                            break;
                        //Search by ingredient name
                        case 2:
                            ctx.Entry(drink.Cocktail).Collection(c => c.Ingredients).Load();
                            //Checks if any of the ingredients contains searchFor
                            if (drink.Cocktail.Ingredients.Any(x => x.Name.ToLower().Contains(searchFor.ToLower())))
                            {
                                drinks.Add(drink);
                            }
                            break;
                        //Search by glass type
                        case 3:
                            if (drink.GlasType.ToString().ToLower() == searchFor.ToLower())
                            {
                                drinks.Add(drink);
                            }
                            break;
                        default:
                            break;
                    }
                }
            }
            return drinks;
        }
    }
}
