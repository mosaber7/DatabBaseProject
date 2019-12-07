using DataAccess;
using DatabaseData.Models;
using System.Data;
using System.Data.SqlClient;
using System;


namespace DatabaseData.DataDelegates.NonQuery.Orders
{
    internal class CancelOrderDelegate : NonQueryDataDelegate<int>
    {
        private readonly int orderID;

        public CancelOrderDelegate(int orderID)
            : base("Restaurant.CancelOrder")
        {
            this.orderID = orderID;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("OrderID", orderID);
        }

        public override int Translate(SqlCommand command)
        {
            return orderID;
        }
    }
}
