using Cocktails_H3.Controllers;
using Cocktails_H3.Models;
using Cocktails_H3.Models.Entities;
using Cocktails_H3.Testing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails_H3
{
    class Program
    {
        static DrinkController drinkController = new DrinkController();
        static IngredientController ingredientController = new IngredientController();

        static int Main(string[] args)
        {
            //List<Ingridient> ingridients = new List<Ingridient>()
            //{
            //    new Alcohol("Vodka", 20),
            //    new Soft("Cola", 50)
            //};
            //using (var ctx = new CocktailDBContext())
            //{
            //    var drink = new Drink(GlasType.Collins, new Cocktail("Vodka og Cola", ingridients));
            //    ctx.Drinks.Add(drink);
            //    ctx.SaveChanges();

            //}

            //using (var ctx = new CocktailDBContext())
            //{
            //    foreach (Drink drink in ctx.Drinks)
            //    {
            //        ctx.Entry(drink).Reference("Cocktail").Load();
            //        Console.WriteLine($"{drink.Cocktail.Name}");
            //    }
            //}
            //Console.WriteLine("Te");
            //Console.ReadKey();

            //using (var ctx = new SchoolContext())
            //{
            //    var stud = new Student() { StudentName = "Bill" };

            //    ctx.Students.Add(stud);
            //    ctx.SaveChanges();
            //}

            //using(var ctx = new SchoolContext())
            //{
            //    foreach (Student student in ctx.Students)
            //    {
            //        Console.WriteLine(student.StudentName);
            //    }
            //}

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Choose an option:");
                Console.WriteLine(" 1. List with all drinks");
                Console.WriteLine(" 2. Create drink");
                Console.WriteLine(" 3. Delete drink");
                Console.WriteLine(" 4. Search for drinks");
                Console.WriteLine(" 5. Set default drinks");
                Console.Write("\r\nSelect an option: ");
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1: ShowAllCocktails(); break;
                    case ConsoleKey.D2: CreateCocktail(); break;
                    case ConsoleKey.D3: DeleteCocktail(); break;
                    case ConsoleKey.D4: SearchDrink(); break;
                    case ConsoleKey.D5: SetDefaultDrinks(); break;
                    default: return 0;
                }
            }
        }

        static void ShowAllCocktails()
        {
            Console.Clear();
            Console.WriteLine("List with cocktails:");
            foreach (Drink drink in drinkController.GetAll())
            {
                ShowDrinkDetailed(drink);
            }
            PressAnyKeyToLeave();
        }

        #region Create drink
        static void CreateCocktail()
        {
            Console.Clear();
            try
            {
                string name = Create_GetDrinkNameInput();
                GlassType glassType = Create_GetDrinkGlass();
                List<Ingredient> ingredients = Create_GetIngredients();

                drinkController.Create(new Drink(glassType, new Cocktail(name, ingredients)));
                Console.WriteLine("Drink was created!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Drink was not created: " + ex.Message);
            } 
            finally
            {
                PressAnyKeyToLeave();
            }
        }

        static string Create_GetDrinkNameInput()
        {
            string nameInput = " ";
            while (string.IsNullOrWhiteSpace(nameInput))
            {
                Console.Clear();
                Console.Write("Name of drink: ");
                nameInput = Console.ReadLine();
            }
            return nameInput;
        }

        static GlassType Create_GetDrinkGlass()
        {
            string[] glassTypes = Enum.GetNames(typeof(GlassType));
            int typeInput = -1;
            while (typeInput == -1)
            {
                Console.Clear();
                for (int i = 0; i < glassTypes.Length; i++)
                {
                    Console.WriteLine($" {i}. {glassTypes[i]}");
                }
                Console.Write("\r\nGlass type nr: ");
                typeInput = IsGlassType(int.Parse(Console.ReadLine()));
            }
            
            return (GlassType)typeInput;
        }

        static int IsGlassType(int value)
        {
            GlassType glassType = (GlassType)value;

            if (!Enum.IsDefined(typeof(GlassType), glassType))
            {
                return -1;
            }
            return value;
        }

        static List<Ingredient> Create_GetIngredients(List<Ingredient> ingredients = null)
        {
            List<Ingredient> ingredients_in_db = ingredientController.GetAll();
            if (ingredients == null)
            {
                ingredients = new List<Ingredient>();
            }
            for (int i = 0; i < ingredients_in_db.Count; i++)
            {
                Console.WriteLine($" {i}. {ingredients_in_db[i]}");
            }
            Console.Write("\r\nIngredient: ");
            int choice = int.Parse(Console.ReadLine());

            Console.Write("\r\nAmount: ");
            string amount = Console.ReadLine();

            if (ingredients_in_db[choice].GetType() == typeof(Soft))
            {
                ingredients.Add(new Soft(ingredients_in_db[choice].Name, int.Parse(amount)));
            } else if (ingredients_in_db[choice].GetType() == typeof(Alcohol))
            {
                ingredients.Add(new Alcohol(ingredients_in_db[choice].Name, int.Parse(amount)));
            }
            else if (ingredients_in_db[choice].GetType() == typeof(Garnish))
            {
                ingredients.Add(new Garnish(ingredients_in_db[choice].Name, amount));
            }

            Console.WriteLine("Do you want more ingredients, type 'Y' ");
            ConsoleKeyInfo key = Console.ReadKey();

            if (key.Key == ConsoleKey.Y)
            {
                Create_GetIngredients(ingredients);
            }
            return ingredients;

        }

        #endregion

        static void DeleteCocktail()
        {
            Console.Clear();
            Console.Write("Drink name to delete: ");
            try
            {
                drinkController.Delete(Console.ReadLine());
                Console.WriteLine("Removed drink...");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Drink was not removed: " + ex.Message);
            }
            PressAnyKeyToLeave();
        }

        static void SearchDrink()
        {
            ConsoleKey pressedKey = ConsoleKey.D1;
            bool rightInput = false;
            while (rightInput == false)
            {
                Console.Clear();
                Console.WriteLine("Choose an option:");
                Console.WriteLine(" 1. Name");
                Console.WriteLine(" 2. Ingredient name");
                Console.WriteLine(" 3. Glass type");
                Console.Write("Select an option: ");
                pressedKey = Console.ReadKey().Key;
                if ((int)pressedKey >= 49 && (int)pressedKey <= 51)
                {
                    rightInput = true;
                }
            }
            Console.WriteLine();
            Console.Write("Search: ");
            List<Drink> searchForDrinks = drinkController.GetBySearch(Console.ReadLine(), (int)pressedKey - 48);
            
            Console.WriteLine("Drinks founded:\r\n");
            foreach (Drink drink in searchForDrinks)
            {
                ShowDrinkDetailed(drink);
            }
            if (searchForDrinks.Count == 0)
            {
                Console.WriteLine("Didn't find any cocktail with that name.");
            }
            PressAnyKeyToLeave();
        }

        static void SetDefaultDrinks()
        {
            Data.SetDefaultDrinks();
            //Data.SetDefaultIngredients();
        }

        static void ShowDrinkDetailed(Drink drink)
        {
            Console.WriteLine($"Drink: {drink.Cocktail.Name}");
            Console.WriteLine($"Glass used: {drink.GlasType}");
            Console.WriteLine("Ingridients:");
            foreach (Ingredient ingridient in drink.Cocktail.Ingredients)
            {
                Console.WriteLine(" - " + ingridient.ToString());
            }
            Console.WriteLine();
        }

        static void PressAnyKeyToLeave()
        {
            Console.WriteLine("\r\nPress any key to leave");
            Console.ReadKey();
        }
    }
}
