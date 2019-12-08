using DataAccess;
using DatabaseData.Models.Report;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace DatabaseData.DataDelegates.ReportQuery
{
    internal class EmployeePerformanceDelegate : DataReaderDelegate<IReadOnlyList<EmployeePerformanceReport>>
    {
        private readonly int year;
        private readonly int month;

        public EmployeePerformanceDelegate(int year, int month)
            : base("Restaurant.EmployeePerformance")
        {
            this.year = year;
            this.month = month;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("Year", year);
            command.Parameters.AddWithValue("Month", month);
        }

        public override IReadOnlyList<EmployeePerformanceReport> Translate(SqlCommand command, IDataRowReader reader)
        {
            List<EmployeePerformanceReport> employeePerformanceReports = new List<EmployeePerformanceReport>();

            while(reader.Read())
            {
                employeePerformanceReports.Add(new EmployeePerformanceReport(
                    reader.GetString("FirstName"), reader.GetString("LastName"),
                    reader.GetInt32("HoursWorked"), reader.GetInt32("OrdersServed"),
                    reader.GetValue<decimal>("TotalTipEarnings"), reader.GetValue<decimal>("AverageTipOrder")));
            }

            return employeePerformanceReports;
        }
    }
}
