namespace DatabaseData.Models
{
    public class Ingredient
    {
        public string Name { get; }

        public decimal AmountUsed { get; }

        public Ingredient(string name, decimal amountUsed)
        {
            Name = name;
            AmountUsed = amountUsed;
        }
    }
}
