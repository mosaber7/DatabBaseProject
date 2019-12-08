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

        public IReadOnlyList<FoodYearInfo> MostOrderedFoodInYear(int year)
        {
            return executor.ExecuteReader(new MostOrderedFoodInYearDelegate(year));
        }

        public IReadOnlyList<WaitersWork> WaitersWorkOnDate (DateTimeOffset date)
        {
            return executor.ExecuteReader(new WaitersWorkOnDayDelegate(date));
        }

        public IReadOnlyList<EmployeePerformanceReport> EmployeesPerformance (int year, int month)
        {
            return executor.ExecuteReader(new EmployeePerformanceDelegate(year, month));
        }
    }
}
