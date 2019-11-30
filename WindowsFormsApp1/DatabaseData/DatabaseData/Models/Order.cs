using System;

namespace DatabaseData.Models
{
    public class Order
    {
        public Waiter WaiterInCharge { get; }

        public int TableNumber { get; }

        public DateTime OrderedOn { get; }

        public Order(Waiter waiter, int tableNum, DateTime timeOfOrder)
        {
            WaiterInCharge = waiter;
            TableNumber = tableNum;
            OrderedOn = timeOfOrder;
        }
    }
}
