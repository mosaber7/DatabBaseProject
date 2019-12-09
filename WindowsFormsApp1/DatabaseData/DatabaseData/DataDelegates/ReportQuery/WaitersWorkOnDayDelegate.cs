using DataAccess;
using DatabaseData.Models.Report;
using System.Data.SqlClient;
using System.Collections.Generic;
using System;

namespace DatabaseData.DataDelegates.ReportQuery
{
    class WaitersWorkOnDayDelegate : DataReaderDelegate<IReadOnlyList<WaitersWork>>
    {
        private readonly DateTimeOffset date;

        public WaitersWorkOnDayDelegate(DateTimeOffset date)
            : base("Restaurant.WaitersWorkOnDay")
        {
            this.date = date;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("Date", date);
        }

        public override IReadOnlyList<WaitersWork> Translate(SqlCommand command, IDataRowReader reader)
        {
            List<WaitersWork> waitersWorks = new List<WaitersWork>();

            while(reader.Read())
            {
                waitersWorks.Add(new WaitersWork(
                    reader.GetString("FirstName"),
                    reader.GetString("LastName"),
                    reader.GetInt32("HoursWorked"),
                    reader.GetValue<decimal>("WorkersEarnings"),
                    reader.GetInt32("OrdersServed")));
            }

            return waitersWorks;
        }
    }
}
