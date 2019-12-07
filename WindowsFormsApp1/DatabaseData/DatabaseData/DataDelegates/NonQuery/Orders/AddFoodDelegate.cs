using DataAccess;
using DatabaseData.Models;
using System.Data;
using System.Data.SqlClient;
using System;

namespace DatabaseData.DataDelegates.NonQuery.Orders
{
    internal class AddFoodDelegate : NonQueryDataDelegate<Food>
    {
        private readonly int orderID;
        private readonly string name;
        private readonly int quantity;

        public AddFoodDelegate(int orderID, string foodName, int quantity)
            : base ("Restaurant.AddFood")
        {
            this.orderID = orderID;
            name = foodName;
            this.quantity = quantity;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("OrderID", orderID);
            command.Parameters.AddWithValue("MenuItemName", name);
            command.Parameters.AddWithValue("Quantity", quantity);

            var id = command.Parameters.Add("FoodID", SqlDbType.Int);
            id.Direction = ParameterDirection.Output;
        }

        public override Food Translate(SqlCommand command)
        {
            return new Food((int)command.Parameters["FoodID"].Value,
                name, quantity, null);
        }
    }
}
