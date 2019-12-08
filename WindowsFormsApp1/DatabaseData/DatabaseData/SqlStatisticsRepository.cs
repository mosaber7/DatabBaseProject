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

        /// <summary>
        /// Creates a StatisticsRepository based on the connectionString
        /// </summary>
        /// <param name="connectionString">ConnectionString to the Database in SQL format</param>
        public SqlStatisticsRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        /// <summary>
        /// Get all the sales made in a day
        /// </summary>
        /// <param name="date">The date we are trying to retreive the information from</param>
        /// <returns>List of sales made in the day</returns>
        public IReadOnlyList<ItemSale> GetDaySales (DateTimeOffset date)
        {
            return executor.ExecuteReader(new SalesFromDayDelegate(date));
        }

        /// <summary>
        /// Returns the list of foods ordered with the most ordered on top
        /// </summary>
        /// <param name="year">Year we want to retrieve the information from</param>
        /// <returns>List of most ordered foods from a year</returns>
        public IReadOnlyList<FoodYearInfo> MostOrderedFoodInYear(int year)
        {
            return executor.ExecuteReader(new MostOrderedFoodInYearDelegate(year));
        }

        /// <summary>
        /// Gets a list on how much work the waiters did on that day
        /// </summary>
        /// <param name="date">The date we are trying to retreive the information from</param>
        /// <returns>List of information on the waiters' work</returns>
        public IReadOnlyList<WaitersWork> WaitersWorkOnDate (DateTimeOffset date)
        {
            return executor.ExecuteReader(new WaitersWorkOnDayDelegate(date));
        }

        /// <summary>
        /// Gets a list on the performance of the employees based on tips and also
        /// how much they earned on that month of work
        /// </summary>
        /// <param name="year">Year we are trying to retrieve the information from</param>
        /// <param name="month">Month we are trying to retrieve the information from</param>
        /// <returns>List of Employee performance reports</returns>
        public IReadOnlyList<EmployeePerformanceReport> EmployeesPerformance (int year, int month)
        {
            return executor.ExecuteReader(new EmployeePerformanceDelegate(year, month));
        }

        /// <summary>
        /// Gets a list on the profit made by the restaurant each month bounded
        /// by the given dates passed as parameters
        /// </summary>
        /// <param name="startingDate">Starting Date</param>
        /// <param name="endingDate">Ending Date</param>
        /// <returns>List of each month's money flow information</returns>
        public IReadOnlyList<MonthProfitReport> ProfitMade (DateTimeOffset startingDate, DateTimeOffset endingDate)
        {
            return executor.ExecuteReader(new ProfitMadeDelegate(startingDate, endingDate));
        }
    }
}
