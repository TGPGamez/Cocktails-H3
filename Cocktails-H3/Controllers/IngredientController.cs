//using Cocktails_H3.Models;
//using Cocktails_H3.Models.Entities;
//using System.Collections.Generic;

//namespace Cocktails_H3.Controllers
//{
//    public class IngredientController : IController<Ingredient, string>
//    {
//        public void Create(Ingredient ingredient)
//        {
//            using (CocktailDBContext ctx = new CocktailDBContext())
//            {
//                ctx.Ingredients_Recipes.Add(ingredient);
//                ctx.SaveChanges();
//            }
//        }

//        public void Delete(string key)
//        {
//            using (CocktailDBContext ctx = new CocktailDBContext())
//            {
//                foreach (Ingredient ingredient in ctx.Ingredients_Recipes)
//                {
//                    if (ingredient.Name.ToLower() == key.ToLower())
//                    {
//                        ctx.Ingredients_Recipes.Remove(ingredient);
//                        break;
//                    }
//                }
//                ctx.SaveChanges();
//            }
//        }

//        public void DeleteAll()
//        {
//            using (CocktailDBContext ctx = new CocktailDBContext())
//            {
//                ctx.Ingredients_Recipes.RemoveRange(ctx.Ingredients_Recipes);
//                ctx.SaveChanges();
//            }
//        }

//        public Ingredient Get(string key)
//        {
//            throw new System.NotImplementedException();
//        }

//        public List<Ingredient> GetAll()
//        {
//            List<Ingredient> ingredients = new List<Ingredient>();
//            using (CocktailDBContext ctx = new CocktailDBContext())
//            {
//                foreach (Ingredient ingredient in ctx.Ingredients_Recipes)
//                {
//                    ingredients.Add(ingredient);
//                }
//            }
//            return ingredients;
//        }

//        public void Update(Ingredient obj)
//        {
//            throw new System.NotImplementedException();
//        }
//    }
//}
