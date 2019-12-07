using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseData.Models
{
    public class Waiter
    {
        public string FirstName { get; }

        public string LastName { get; }

        public decimal Salary { get; }

        public Waiter(string first, string last)
        {
            FirstName = first;
            LastName = last;
            Salary = -1;
        }

        public Waiter(string first, string last, decimal salary)
        {
            FirstName = first;
            LastName = last;
            Salary = salary;
        }
    }
}
