namespace DatabaseData.Models
{
    public class Food
    {
        public int ID { get; }

        public string Name { get; }

        public int Quantity { get; }

        public Ingredient[] IngredientsUsed { get; }

        public Food(int foodId, string name, int quantity, Ingredient[] listOfIngredients)
        {
            ID = foodId;
            Name = name;
            Quantity = quantity;
            IngredientsUsed = listOfIngredients;
        }
    }
}
