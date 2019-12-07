using System.Collections.Generic;

namespace DatabaseData.Models
{
    public class Food
    {
        public int ID { get; }

        public string Name { get; }

        public int Quantity { get; }

        public decimal Price { get; }

        public IReadOnlyList<Ingredient> IngredientsUsed { get; set; }

        public Food(int foodId, string name, int quantity)
        {
            ID = foodId;
            Name = name;
            Quantity = quantity;
            IngredientsUsed = null;
            Price = -1;
        }

        public Food(int foodId, string name, int quantity, Ingredient[] listOfIngredients)
        {
            ID = foodId;
            Name = name;
            Quantity = quantity;
            IngredientsUsed = listOfIngredients;
            Price = -1;
        }

        public Food(int foodId, string name, int quantity, decimal price, Ingredient[] listOfIngredients)
        {
            ID = foodId;
            Name = name;
            Quantity = quantity;
            Price = price;
            IngredientsUsed = listOfIngredients;
        }

        public Food(int foodId, string name, int quantity, decimal price)
        {
            ID = foodId;
            Name = name;
            Quantity = quantity;
            Price = price;
            IngredientsUsed = null;
        }
    }
}
