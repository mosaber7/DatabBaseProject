using System.Collections.Generic;

namespace DatabaseData.Models
{
    public class MenuItem
    {
        public string Name { get; }

        public string Description { get; }

        public decimal Price { get; }

        public IReadOnlyList<Ingredient> Ingredients { get; set; }

        public MenuItem(string name, string descr, decimal price)
        {
            Name = name;
            Description = descr;
            Price = price;
        }
    }
}
