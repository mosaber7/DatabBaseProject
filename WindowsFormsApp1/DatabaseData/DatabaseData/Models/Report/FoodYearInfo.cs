using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseData.Models.Report
{
    public class FoodYearInfo
    {
        public string Name { get; }

        public int AmountSoldInYear { get; }

        public decimal TotalEarnings { get; }

        public FoodYearInfo(string name, int amount, decimal total)
        {
            Name = name;
            AmountSoldInYear = amount;
            TotalEarnings = total;
        }
    }
}
