using DataAccess;
using DatabaseData.Models.Report;
using System.Data.SqlClient;
using System.Collections.Generic;
using System;

namespace DatabaseData.DataDelegates.ReportQuery
{
    internal class ProfitMadeDelegate : DataReaderDelegate<IReadOnlyList<MonthProfitReport>>
    {
        private readonly DateTimeOffset startingDate;
        private readonly DateTimeOffset endingDate;

        public ProfitMadeDelegate(DateTimeOffset startingDate, DateTimeOffset endingDate)
            : base("Restaurant.ProfitMadeBetweenDates")
        {
            this.startingDate = startingDate;
            this.endingDate = endingDate;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("StartingDate", startingDate);
            command.Parameters.AddWithValue("EndingDate", endingDate);
        }

        public override IReadOnlyList<MonthProfitReport> Translate(SqlCommand command, IDataRowReader reader)
        {
            List<MonthProfitReport> monthProfitReports = new List<MonthProfitReport>();

            while(reader.Read())
            {
                monthProfitReports.Add(new MonthProfitReport(
                    reader.GetInt32("Year"), reader.GetInt32("Month"),
                    reader.GetValue<decimal>("TotalEarnings"),
                    reader.GetValue<decimal>("WorkersWagesLoss"),
                    reader.GetValue<decimal>("IngredientsLoss"),
                    reader.GetValue<decimal>("MonthProfit"),
                    reader.GetValue<decimal>("TotalProfit")));
            }

            return monthProfitReports;
        }
    }
}
