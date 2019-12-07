using DataAccess;
using DatabaseData.Models;
using System;
using System.Data.SqlClient;

namespace DatabaseData.DataDelegates.NonQuery.Waiters
{
    internal class AddShiftNoDateDelegate : NonQueryDataDelegate<DateTimeOffset>
    {
        private readonly string waiterFirstName;
        private readonly string waiterLastName;
        private readonly DateTimeOffset clockIn;

        public AddShiftNoDateDelegate(string waiterFirstName, string waiterLastName)
            : base("Restaurant.AddShiftNoDate")
        {
            this.waiterFirstName = waiterFirstName;
            this.waiterLastName = waiterLastName;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("WaiterFirstName", waiterFirstName);
            command.Parameters.AddWithValue("WaiterLastName", waiterLastName);


        }

        public override DateTimeOffset Translate(SqlCommand command)
        {
            return clockIn;
        }
    }
}
