using DataAccess;
using DatabaseData.Models;
using System.Data.SqlClient;
using System.Collections.Generic;


namespace DatabaseData.DataDelegates.Query.Orders
{
    internal class FetchAllOrdersFromTableDelegate : DataReaderDelegate<IReadOnlyList<Order>>
    {
        private readonly int tableNumber;

        public FetchAllOrdersFromTableDelegate(int tableNumber)
            : base("Restaurant.FetchAllOrdersOfTable")
        {
            this.tableNumber = tableNumber;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("TableNumber", tableNumber);
        }

        public override IReadOnlyList<Order> Translate(SqlCommand command, IDataRowReader reader)
        {
            List<Order> listOfOrders = new List<Order>();

            while(reader.Read())
            {
                listOfOrders.Add(new Order(
                    reader.GetInt32("OrderID"), new Waiter(
                        reader.GetString("FirstName"), reader.GetString("LastName")),
                    tableNumber, reader.GetDateTimeOffset("OrderedOn")));
            }

            return listOfOrders;
        }
    }
}
