using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StefaniniInternship.Prototypes
{
    public class Dish
    {
        public string Name { get; set; }

        public string Description { get; set; }
        public int PrepTime { get; set; }
        
        public List<Ingredient> Ingredients { get; set; }
       
        private double _price;
        
        public double Price {
            get { return _price; }
            set
            {
                var rawPrice = Ingredients.Select(ingredient => ingredient.Price).Sum() * 1.2;
                _price = Math.Round(rawPrice, 2);
            }
        }

    }
}
