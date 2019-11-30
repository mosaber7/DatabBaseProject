namespace DatabaseData.Models
{
    public class MenuItem
    {
        public string Name { get; }

        public string Description { get; }

        public decimal Price { get; }

        public Ingredient[] Ingredients { get; }

        public MenuItem(string name, string descr, decimal price, Ingredient[] listOfIngredients)
        {
            Name = name;
            Description = descr;
            Price = price;
            Ingredients = listOfIngredients;
        }
    }
}
