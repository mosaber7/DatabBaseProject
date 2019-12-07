using DataAccess;
using DatabaseData.Models.Report;
using System.Data.SqlClient;
using System.Collections.Generic;
using System;


namespace DatabaseData.DataDelegates.ReportQuery
{
    internal class SalesFromDayDelegate : DataReaderDelegate<IReadOnlyList<ItemSale>>
    {
        private readonly DateTimeOffset date;

        public SalesFromDayDelegate(DateTimeOffset date)
            : base("Restaurant.SalesFromDay")
        {
            this.date = date;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("Date", date);
        }

        public override IReadOnlyList<ItemSale> Translate(SqlCommand command, IDataRowReader reader)
        {
            List<ItemSale> itemSales = new List<ItemSale>();

            while(reader.Read())
            {
                itemSales.Add(new ItemSale(
                    reader.GetString("ProductName"),
                    reader.GetValue<decimal>("TotalSalesOnItem"),
                    reader.GetInt32("OrderedTimes"),
                    date));
            }

            return itemSales;
        }
    }
}
