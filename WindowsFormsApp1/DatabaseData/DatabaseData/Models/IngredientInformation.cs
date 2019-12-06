using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseData.Models
{
    public class IngredientInformation
    {
        public string Name { get; }

        public decimal Amount { get; }

        public string Units { get; }

        public decimal CostPerUnit { get; }

        public IngredientInformation(string name, decimal amount, string units, decimal cost)
        {
            Name = name;
            Amount = amount;
            Units = units;
            CostPerUnit = cost;
        }
    }
}
