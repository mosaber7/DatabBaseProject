using DataAccess;
using DatabaseData.Models;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace DatabaseData.DataDelegates.Query.Orders
{
    internal class FetchAllFoodsFromOrderDelegate : DataReaderDelegate<IReadOnlyList<Food>>
    {
        private readonly int orderID;

        public FetchAllFoodsFromOrderDelegate(int orderID)
            : base ("Restaurant.FetchAllFoodsFromOrder")
        {
            this.orderID = orderID;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("OrderID", orderID);
        }

        public override IReadOnlyList<Food> Translate(SqlCommand command, IDataRowReader reader)
        {
            List<Food> foods = new List<Food>();

            while (reader.Read())
            {
                foods.Add(new Food(
                    reader.GetInt32("FoodID"),
                    reader.GetString("Name"),
                    reader.GetInt32("Quantity"),
                    reader.GetValue<decimal>("Price")));
            }

            return foods;
        }
    }
}
