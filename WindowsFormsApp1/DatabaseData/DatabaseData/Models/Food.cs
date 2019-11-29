using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseData.Models
{
    class Food
    {
        public string Name { get; }

        public int Quantity { get; }

        public Ingredient[] IngredientsUsed { get; }

        public Food(string name, int quantity, Ingredient[] listOfIngredients)
        {
            Name = name;
            Quantity = quantity;
            IngredientsUsed = listOfIngredients;
        }
    }
}
