using System;

namespace DatabaseData.Models
{
    public class Order
    {
        public int OrderID { get; }

        public Waiter WaiterInCharge { get; }

        public int TableNumber { get; }

        public DateTimeOffset OrderedOn { get; }

        public Order(int id, Waiter waiter, int tableNum, DateTimeOffset timeOfOrder)
        {
            OrderID = id;
            WaiterInCharge = waiter;
            TableNumber = tableNum;
            OrderedOn = timeOfOrder;
        }
    }
}
