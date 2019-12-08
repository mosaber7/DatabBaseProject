using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseData.Models.Report
{
    public class MonthProfitReport
    {
        public int Year { get; }

        public int Month { get; }

        public decimal TotalEarnings { get; }

        public decimal WorkersWagesLoss { get; }

        public decimal IngredientsLoss { get; }

        public decimal MonthProfit { get; }

        public decimal TotalProfitUpToThatMonth { get; }

        public MonthProfitReport(int year, int month, decimal totalEarnings, decimal wages, decimal ingredients, decimal profit, decimal totalProfit)
        {
            Year = year;
            Month = month;
            TotalEarnings = totalEarnings;
            WorkersWagesLoss = wages;
            IngredientsLoss = ingredients;
            MonthProfit = profit;
            TotalProfitUpToThatMonth = totalProfit;
        }
    }
}
