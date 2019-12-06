using DataAccess;
using DatabaseData.Models;
using System.Data;
using System.Data.SqlClient;
using System;

namespace DatabaseData.DataDelegates.NonQuery.Orders
{
    internal class AddOrderDelegate : NonQueryDataDelegate<Order>
    {
        private readonly int orderID;
        private readonly string waiterFirstName;
        private readonly string waiterLastName;
        private readonly int tableNumber;
        private readonly DateTimeOffset orderdedOn;

        public AddOrderDelegate(string waiterFirstName, string waiterLastName, int tableNumber)
            : base("Restaurant.AddOrderNoDate")
        {
            this.waiterFirstName = waiterFirstName;
            this.waiterLastName = waiterLastName;
            this.tableNumber = tableNumber;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("WaiterFirstName", waiterFirstName);
            command.Parameters.AddWithValue("WaiterLastName", waiterLastName);
            command.Parameters.AddWithValue("TableNumber", tableNumber);

            var id = command.Parameters.Add("OrderID", SqlDbType.Int);
            id.Direction = ParameterDirection.Output;

            var date = command.Parameters.Add("OrderID", SqlDbType.DateTimeOffset);
            date.Direction = ParameterDirection.Output;
        }

        public override Order Translate(SqlCommand command)
        {
            return new Order((int)command.Parameters["OrderID"].Value,
                new Models.Waiter(waiterFirstName, waiterLastName),
                tableNumber,
                (DateTimeOffset)command.Parameters["OrderDate"].Value);
        }
    }
}
