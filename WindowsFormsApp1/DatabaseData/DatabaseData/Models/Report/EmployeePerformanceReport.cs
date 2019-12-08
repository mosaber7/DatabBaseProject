using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseData.Models.Report
{
    public class EmployeePerformanceReport
    {
        public string FirstName { get; }

        public string LastName { get; }

        public int HoursWorked { get; }

        public int OrdersServed { get; }

        public decimal TotalTipEarnings { get; }

        public decimal AverageTipPerOrder { get; }

        public EmployeePerformanceReport(string first, string last, int hoursW, int ordersS, decimal totalTip, decimal averageTip)
        {
            FirstName = first;
            LastName = last;
            HoursWorked = hoursW;
            OrdersServed = ordersS;
            TotalTipEarnings = totalTip;
            AverageTipPerOrder = averageTip;
        }
    }
}
