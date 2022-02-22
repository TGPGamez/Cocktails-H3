using Cocktails_H3.Controllers;
using Cocktails_H3.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails_H3
{
    public static class Data
    {
        private static DrinkController drCon = new DrinkController();
        //private static IngredientController inCon = new IngredientController();


        public static void SetDefaultIngredients()
        {
            //inCon.DeleteAll();
            //inCon.Create(new Soft("Lime Juice"));
            //inCon.Create(new Soft("Fresh Cream"));
            //inCon.Create(new Soft("Almond Syrup"));
            //inCon.Create(new Soft("Orange Juice"));
            //inCon.Create(new Soft("Tomato Juice"));
            //inCon.Create(new Soft("Water"));
            //inCon.Create(new Soft("Pink Grapefruit Juice"));
            //inCon.Create(new Soft("Cranberry Juice"));
            //inCon.Create(new Soft("Soda"));
            //inCon.Create(new Soft("Lemon Juice"));
            //inCon.Create(new Soft("Pineapple Juice"));
            //inCon.Create(new Soft("Coconut Cream"));
            //inCon.Create(new Soft("Cola"));
            //inCon.Create(new Soft("Peach Puree"));
            //inCon.Create(new Alcohol("Triple Sec"));
            //inCon.Create(new Alcohol("Tequila"));
            //inCon.Create(new Alcohol("Dark Rum"));
            //inCon.Create(new Alcohol("Orange Curacao"));
            //inCon.Create(new Alcohol("Kahlua"));
            //inCon.Create(new Alcohol("Vodka"));
            //inCon.Create(new Alcohol("Cachaca"));
            //inCon.Create(new Alcohol("Bourbon"));
            //inCon.Create(new Alcohol("Italian Sweet Vermouth"));
            //inCon.Create(new Alcohol("French Dry Vermout"));
            //inCon.Create(new Alcohol("Gin"));
            //inCon.Create(new Alcohol("White Rum"));
            //inCon.Create(new Alcohol("Cointreau"));
            //inCon.Create(new Alcohol("Cherry Brandy"));
            //inCon.Create(new Alcohol("Sloe Gin"));
            //inCon.Create(new Alcohol("Prosecco"));

            //inCon.Create(new Garnish("Salt Rim"));
            //inCon.Create(new Garnish("Crushed Ice"));
            //inCon.Create(new Garnish("Lime Segment"));
            //inCon.Create(new Garnish("Lime Section"));
            //inCon.Create(new Garnish("Maraschino Cherry"));
            //inCon.Create(new Garnish("Caster Sugar"));
            //inCon.Create(new Garnish("Ice Cube"));
            //inCon.Create(new Garnish("Celery Stick"));
            //inCon.Create(new Garnish("Worcestershire Sauce"));
            //inCon.Create(new Garnish("Orange Slice"));
            //inCon.Create(new Garnish("Brown Sugar"));
            //inCon.Create(new Garnish("Cube Caster Sugar"));
            //inCon.Create(new Garnish("Dash Angostura Bitters"));
            //inCon.Create(new Garnish("Orange Peel"));
            //inCon.Create(new Garnish("Orange Segment"));
            //inCon.Create(new Garnish("Ice"));
            //inCon.Create(new Garnish("Olive"));
            //inCon.Create(new Garnish("Mint Leave"));
            //inCon.Create(new Garnish("Splash Soda Water"));
            //inCon.Create(new Garnish("Pineapple Segment"));
        }


        public static void SetDefaultDrinks()
        {
            drCon.DeleteAll();

            drCon.Create(new Drink(
                GlassType.OldFashioned, new Cocktail(
                "Margarita", new List<Ingredient>() 
                {
                   new Soft("Lime Juice", 60),
                   new Alcohol("Triple sec", 30),
                   new Alcohol("Tequila", 60),
                   new Garnish("Salt rim", "A little"),
                   new Garnish("Crushed ice", "Up to you"),
                   new Garnish("Lime segment", "x1")
                })
            ));
            drCon.Create(new Drink(
                GlassType.OldFashioned, new Cocktail(
                "Mai Tai", new List<Ingredient>()
                {
                    new Alcohol("Dark Rum", 50),
                    new Soft("Orange Curacao", 15),
                    new Soft("Lime Juice", 10),
                    new Soft("Almond Syrup", 60),
                    new Garnish("Lime Section", "1x"),
                    new Garnish("Maraschino Cherry", "1x"),
                    new Garnish("Lime Segment", "1x")
                })
            ));
            drCon.Create(new Drink(
                GlassType.OldFashioned, new Cocktail(
                "White Russian", new List<Ingredient>()
                {
                    new Soft("Fresh Cream", 30),
                    new Alcohol("Kahlua", 30),
                    new Alcohol("Vodka", 90)
                })
            ));
            drCon.Create(new Drink(
               GlassType.OldFashioned, new Cocktail(
               "Caipirinha", new List<Ingredient>()
               {
                    new Alcohol("Cachaca", 50),
                    new Garnish("Lime Segment", "5x"),
                    new Garnish("Caster Sugar", "2 tsp")
               })
            ));
            drCon.Create(new Drink(
               GlassType.Collins, new Cocktail(
               "Screwdriver", new List<Ingredient>()
               {
                    new Soft("Orange Juice", 135),
                    new Alcohol("Vodka", 45)
               })
            ));
            drCon.Create(new Drink(
               GlassType.Collins, new Cocktail(
               "Bloddy Mary", new List<Ingredient>()
               {
                    new Soft("Tomato Juice", 135),
                    new Alcohol("Vodka", 45),
                    new Garnish("Ice Cube", "Own preference"),
                    new Garnish("Celery Stick", "1x")
               })
            ));
            drCon.Create(new Drink(
               GlassType.Collins, new Cocktail(
               "Whiskey Sour", new List<Ingredient>()
               {
                    new Alcohol("Bourbon", 90),
                    new Soft("Lime Juice", 40),
                    new Garnish("Maraschino Cherry", "1x"),
                    new Garnish("Orange Slice", "0.5x"),
                    new Garnish("Brown Sugar", "Own preference")
               })
            ));
            drCon.Create(new Drink(
              GlassType.OldFashioned, new Cocktail(
              "Old Fashioned", new List<Ingredient>()
              {
                    new Alcohol("Bourbon", 50),
                    new Soft("Water", 5),
                    new Garnish("Cube Caster Sugar", "1x"),
                    new Garnish("Dash Angostura Bitters", "1x"),
                    new Garnish("Orange Peel", "1x"),
                    new Garnish("Ice", "1x")
              })
            ));
            drCon.Create(new Drink(
                GlassType.Martini, new Cocktail(
                "Manhatten", new List<Ingredient>()
                {
                    new Alcohol("Italian Sweet Vermouth", 25),
                    new Alcohol("Bourbon", 45),
                    new Garnish("Maraschino Cherry", "1x"),
                    new Garnish("Dash Angostura Bitters", "1x")
                })
            ));
            drCon.Create(new Drink(
                GlassType.Martini, new Cocktail(
                "Martini", new List<Ingredient>()
                {
                    new Alcohol("French Dry Vermouth", 25),
                    new Alcohol("Gin", 45),
                    new Garnish("Olive", "1x")
                })
            ));
            drCon.Create(new Drink(
                GlassType.Martini, new Cocktail(
                "Daiquiri", new List<Ingredient>()
                {
                    new Soft("Lime Juice", 25),
                    new Alcohol("White Rum", 45),
                    new Garnish("Brown Sugar", "tsp")
                })
            ));
            drCon.Create(new Drink(
                GlassType.Martini, new Cocktail(
                "Cosmopolitan", new List<Ingredient>()
                {
                    new Soft("Lime Juice", 15),
                    new Soft("Pink Grapefruit Juice", 15),
                    new Soft("Cranberry Juice", 15),
                    new Alcohol("Cointreau", 15),
                    new Alcohol("Vodka", 15)
                })
            ));
            drCon.Create(new Drink(
                GlassType.Highball, new Cocktail(
                "Singapore Sling", new List<Ingredient>()
                {
                    new Soft("Soda", 250),
                    new Soft("Cherry Brandy", 20),
                    new Soft("Lemon Juice", 20),
                    new Alcohol("Sloe Gin", 20),
                    new Alcohol("Gin", 45),
                    new Garnish("Orange Segment", "1x"),
                    new Garnish("Brown Sugar", "tsp")
                })
            ));
            drCon.Create(new Drink(
                GlassType.Highball, new Cocktail(
                "Mojito", new List<Ingredient>()
                {
                    new Soft("Lime Juice", 20),
                    new Alcohol("White Rum", 50),
                    new Garnish("Mint Leave", "10x"),
                    new Garnish("Caster Sugar", "2tsp"),
                    new Garnish("Crushed Ice", "Own Preference"),
                    new Garnish("Splash Soda Water", "1x")
                })
            ));
            drCon.Create(new Drink(
                GlassType.Highball, new Cocktail(
                "Mint Julep", new List<Ingredient>()
                {
                    new Soft("Water", 300),
                    new Alcohol("Bourbon", 60),
                    new Garnish("Mint Leave", "4x"),
                    new Garnish("Brown Sugar", "tsp"),
                    new Garnish("Crushed Ice", "4x")
                })
            ));
            drCon.Create(new Drink(
                GlassType.Highball, new Cocktail(
                "Tom Collins", new List<Ingredient>()
                {
                    new Soft("Soda", 220),
                    new Alcohol("Gin", 50),
                    new Soft("Lemon Juice", 25),
                    new Garnish("Maraschino Cherry", "1x"),
                    new Garnish("Orange Slice", "1x"),
                    new Garnish("Brown Sugar", "tsp"),
                    new Garnish("Ice Cube", "3x"),
                })
            ));
            drCon.Create(new Drink(
                GlassType.PocoGrande, new Cocktail(
                "Pin Colada", new List<Ingredient>()
                {
                    new Soft("Pineapple Juice", 70),
                    new Alcohol("White Rum", 30),
                    new Soft("Coconut Cream", 60),
                    new Garnish("Pineapple Segment", "1x"),
                })
            ));
            drCon.Create(new Drink(
                GlassType.Highball, new Cocktail(
                "Sea Breeze", new List<Ingredient>()
                {
                    new Soft("Grapefruit Juice", 50),
                    new Soft("Cranberry Juice", 120),
                    new Alcohol("Vodka", 40),
                    new Garnish("Ice", "1x"),
                    new Garnish("Lime Segment", "1x"),
                })
            ));
            drCon.Create(new Drink(
                GlassType.Highball, new Cocktail(
                "Cuba Libre", new List<Ingredient>()
                {
                    new Soft("Cola", 80),
                    new Soft("Lime Juice", 25),
                    new Alcohol("White Rum", 50),
                    new Garnish("Ice", "3x"),
                })
            ));
            drCon.Create(new Drink(
                GlassType.Flute, new Cocktail(
                "Bellini", new List<Ingredient>()
                {
                    new Soft("Peach Puree", 50),
                    new Alcohol("Prosecco", 100),
                })
            ));

        }
    }
}
