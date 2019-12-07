using DataAccess;
using DatabaseData.Models;
using System.Data;
using System.Data.SqlClient;
using System;

namespace DatabaseData.DataDelegates.NonQuery.Orders
{
    internal class DeliveredOrderDelegate : NonQueryDataDelegate<int>
    {
        private readonly int orderID;
        private readonly decimal tip;

        public DeliveredOrderDelegate(int orderID, decimal tip)
            : base("Restaurant.DeliveredOrder")
        {
            this.orderID = orderID;
            this.tip = tip;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("OrderID", orderID);
            command.Parameters.AddWithValue("Tip", tip);
        }

        public override int Translate(SqlCommand command)
        {
            return orderID;
        }
    }
}
