using StefaniniInternship.Prototypes;
using System;
using System.Collections.Generic;
using System.Text;

namespace StefaniniInternship.Seed
{
    public class CafeSeed
    {
        public List<Cook> CooksList()
        {
            Cook john = new Cook { Name = "John" , Dishes = new List<Dish>() };
            Cook andy = new Cook { Name = "Andy" , Dishes = new List<Dish>() };
            Cook oliver = new Cook { Name = "Oliver", Dishes = new List<Dish>() };
            List<Cook> cooks = new List<Cook> { john, andy,oliver};


            return cooks;
        }



        public List<Dish> DishesList()
        {
            Ingredient egg = new Ingredient { Name = "egg", Price = 10 };
            Ingredient bacon = new Ingredient { Name = "Becon", Price = 100 };
            Ingredient milk = new Ingredient { Name = "Milk", Price = 5 };
            Ingredient meat = new Ingredient { Name = "Carne", Price = 150 };
            Ingredient salat = new Ingredient { Name = "Salat", Price = 40 };
            Ingredient sos = new Ingredient { Name = "Cezar", Price = 90 };
            Ingredient garlic = new Ingredient { Name = "Garlic", Price = 0.17 };
            Ingredient onion = new Ingredient { Name = "Onion", Price = 0.33 };
            Ingredient tomatoes = new Ingredient { Name = "Tomatoes", Price = 3.11 };
            Ingredient seasoning = new Ingredient { Name = "Seasoning", Price = 1.27 };
            Ingredient mozzarella = new Ingredient { Name = "Mozzarella", Price = 2.5 };
            Ingredient pepperoncini = new Ingredient { Name = "Pepperoncini", Price = 3.74 };
            Ingredient pesto = new Ingredient { Name = "Pesto", Price = 5.18 };
            Ingredient mushrooms = new Ingredient { Name = "Mushrooms", Price = 2.9 };
            Ingredient tagliatelle = new Ingredient { Name = "Tagliatelle", Price = 6.1 };
            Ingredient pecorino = new Ingredient { Name = "Pecorino", Price = 2.81 };
            Ingredient bucatini = new Ingredient { Name = "Bucatini", Price = 7.2 };
            Ingredient basil = new Ingredient { Name = "Basil", Price = 0.41 };
            Ingredient redPepper = new Ingredient { Name = "Red Pepper", Price = 0.67 };
 

            


            Dish lasagna = new Dish
            {
                Name = "Lasagna",
                Description = "It takes a little work, but it is worth it.",
                Ingredients = new List<Ingredient> { garlic, onion, tomatoes, seasoning, mozzarella },
                PrepTime = 35,
                Price = 0
            };


            Dish pizza = new Dish
            {
                Name = "Pizza",
                Description = "What to do when your 8-year old nephew comes to visit? Make pizza, of course!",
                Ingredients = new List<Ingredient> { garlic, tomatoes, mozzarella, pepperoncini, pesto, mushrooms },
                PrepTime = 17,
                Price = 0
            };



            Dish pastaAllaGricia = new Dish
            {
                Name = "Pasta Alla Gricia",
                Description = "Along with carbonara, cacio e pepe, and amatriciana, pasta alla gricia completes the four classic pasta dishes of Rome.",
                Ingredients = new List<Ingredient> { mozzarella, tagliatelle, pecorino },
                PrepTime = 21,
                Price = 0
            };

            Dish bucatiniAmatriciana = new Dish
            {
                Name = "Bucatini all'Amatriciana",
                Description = "Bucatini is one of our top favorite pastas! It's a long thin noodle just like spaghetti.",
                Ingredients = new List<Ingredient> { bucatini, basil, redPepper, onion, garlic },
                PrepTime = 25,
                Price = 0
            };

            List<Dish> dishes = new List<Dish> { lasagna, pizza, pastaAllaGricia, bucatiniAmatriciana};


            return dishes;
        }


    }
}
