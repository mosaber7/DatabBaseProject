﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseData.Models.Report
{
    public class WaitersWork
    {
        public string FirstName { get; }

        public string LastName { get; }

        public int MinutesWorked { get; }

        public decimal WorkerEarnings { get; }

        public int OrdersServed { get; }

        public WaitersWork(string firstname, string lastname, int minutesWorked, decimal workersEarnings, int ordersServed)
        {
            FirstName = firstname;
            LastName = lastname;
            MinutesWorked = minutesWorked;
            WorkerEarnings = workersEarnings;
            OrdersServed = ordersServed;
        }
    }
}
