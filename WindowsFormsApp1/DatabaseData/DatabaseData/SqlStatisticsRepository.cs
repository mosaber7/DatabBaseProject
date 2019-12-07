using System.Collections.Generic;
using DataAccess;
using DatabaseData.Models.Report;
using System;
using DatabaseData.DataDelegates.ReportQuery;

namespace DatabaseData
{
    public class SqlStatisticsRepository
    {
        private readonly SqlCommandExecutor executor;

        public SqlStatisticsRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        public IReadOnlyList<ItemSale> GetDaySales (DateTimeOffset date)
        {
            return executor.ExecuteReader(new SalesFromDayDelegate(date));
        }
    }
}
