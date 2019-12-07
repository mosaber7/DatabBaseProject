using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseData.Models.Report
{
    public class ItemSale
    {
        public string Name { get; }

        public decimal TotalSale { get; }

        public int AmountSold { get; }

        public DateTimeOffset Date { get; }

        public ItemSale(string name, decimal totalSale, int amountSold, DateTimeOffset date)
        {
            Name = name;
            TotalSale = totalSale;
            AmountSold = amountSold;
            Date = date;
        }
    }
}
