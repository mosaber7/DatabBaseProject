using DataAccess;
using DatabaseData.Models;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace DatabaseData.DataDelegates.Query
{
    internal class GetOrdersDelegate : DataReaderDelegate<IReadOnlyList<Order>>
    {
        public GetOrdersDelegate()
            : base("Restaurant.GetOrders")
        {
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);
        }

        public override IReadOnlyList<Order> Translate(SqlCommand command, IDataRowReader reader)
        {
            List<Order> Orders = new List<Order>();

            while (reader.Read())
            {
                Orders.Add(new Order(
                    new Waiter(reader.GetString("FirstName"), reader.GetString("LastName")),
                    reader.GetInt32("TableID"), reader.GetDateTimeOffset("OrderedOn")));
            }

            return Orders;
        }
    }
}
