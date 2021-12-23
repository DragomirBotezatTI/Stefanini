using StefaniniInternship.Prototypes;
using StefaniniInternship.Seed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StefaniniInternship
{
    public class CafeManager
    {
        private CafeSeed _cafeSeed;
        private List<Dish> _dishes;
        private List<Cook> _cooks;

        public CafeManager()
        {
            _cafeSeed = new CafeSeed();
            _dishes = _cafeSeed.DishesList();
            _cooks = _cafeSeed.CooksList();
        }

        public void Open()
        {
            DisplayDishes();

            var requestedDish = TakeOrder();

            AssignDishToCook(requestedDish);
        }

        private void DisplayDishes()
        {
            Console.WriteLine("----------------------------------------------------------------------------------------");

            foreach (var dish in _dishes)
            {

                Console.WriteLine(dish.Name);
                Console.WriteLine(dish.Description);
                foreach (var ingredient in dish.Ingredients)
                {
                    string separator = ingredient.Name == dish.Ingredients[dish.Ingredients.Count - 1].Name ? ". " : ", ";
                    Console.Write(ingredient.Name + separator);
                }
                Console.WriteLine("\n" + dish.Price + "$\n");

            }
            Console.WriteLine("----------------------------------------------------------------------------------------");
        }

        private Dish TakeOrder()
        {
            Console.Write("\n" + "Insert your order: ");

            var clientInsertedDish = Console.ReadLine();
            var foundDish = _dishes.Where(dish => dish.Name.ToLower() == clientInsertedDish.ToLower()).FirstOrDefault();

            if (foundDish == null)
            {
                Console.WriteLine("\nWrong dish name, please try again: ");
                return TakeOrder();
            }

            return foundDish;
        }

        private void AssignDishToCook(Dish dish)
        {
            var leastLoadedCook = _cooks.OrderBy(cook => cook.Dishes.Count).First();

            if (leastLoadedCook.Dishes.Count == 5)
            {
                Console.WriteLine("No cooks available\n");
                Open();
                return;
            }

            leastLoadedCook.Dishes.Add(dish);
            var totalEstimatedTime = leastLoadedCook.Dishes.Sum(dish => dish.PrepTime);

            Console.WriteLine($"The order will be ready in approximately: {totalEstimatedTime} \n");

            Open();
        }
    }
}

