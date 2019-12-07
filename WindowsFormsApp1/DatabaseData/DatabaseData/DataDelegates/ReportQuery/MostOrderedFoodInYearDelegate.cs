using DataAccess;
using DatabaseData.Models.Report;
using System.Data.SqlClient;
using System.Collections.Generic;
using System;

namespace DatabaseData.DataDelegates.ReportQuery
{
    internal class MostOrderedFoodInYearDelegate : DataReaderDelegate<IReadOnlyList<FoodYearInfo>>
    {
        private readonly int year;

        public MostOrderedFoodInYearDelegate(int year)
            : base("Restaurant.MostOrderedFoodInYear")
        {
            this.year = year;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("Year", year);
        }

        public override IReadOnlyList<FoodYearInfo> Translate(SqlCommand command, IDataRowReader reader)
        {
            List<FoodYearInfo> foodYearInfos = new List<FoodYearInfo>();

            while(reader.Read())
            {
                foodYearInfos.Add(new FoodYearInfo(
                    reader.GetString("ProductName"),
                    reader.GetInt32("AmountSoldInYear"),
                    reader.GetValue<decimal>("TotalEarnings")));
            }

            return foodYearInfos;
        }
    }
}
