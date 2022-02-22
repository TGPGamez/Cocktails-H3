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
        static void Main(string[] args)
        {
            List<Ingridient> ingridients = new List<Ingridient>()
            {
                new Alcohol("Vodka", 20),
                new Soft("Cola", 50)
            };
            //using (var ctx = new CocktailDBContext())
            //{
            //    var drink = new Drink(GlasType.Collins, new Cocktail("Vodka og Cola", ingridients));
            //    ctx.Drinks.Add(drink);
            //    ctx.SaveChanges();

            //}

            using (var ctx = new CocktailDBContext())
            {
                foreach (Drink drink in ctx.Drinks)
                {
                    Console.WriteLine("Test");
                    //Console.WriteLine($"{drink.ID}: {drink.Cocktail.Name}");
                }
            }
            Console.WriteLine("Te");
            Console.ReadKey();

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


        }
    }
}
