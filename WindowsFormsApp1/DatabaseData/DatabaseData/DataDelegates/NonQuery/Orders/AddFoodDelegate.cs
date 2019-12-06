using DataAccess;
using DatabaseData.Models;
using System.Data;
using System.Data.SqlClient;
using System;

namespace DatabaseData.DataDelegates.NonQuery.Orders
{
    internal class AddFoodDelegate : NonQueryDataDelegate<Food>
    {
        private readonly string name;
        private readonly int quantity;

        public AddFoodDelegate(string foodName, int quantity)
            : base ("Restaurant.AddFood")
        {
            name = foodName;
            this.quantity = quantity;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);


        }
    }
}
