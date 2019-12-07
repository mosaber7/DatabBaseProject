using DataAccess;
using DatabaseData.Models;
using System;
using System.Data.SqlClient;

namespace DatabaseData.DataDelegates.NonQuery.Waiters
{
    internal class AddShiftDelegate : NonQueryDataDelegate<DateTimeOffset>
    {
        private readonly string waiterFirstName;
        private readonly string waiterLastName;
        private readonly DateTimeOffset clockIn;

        public AddShiftDelegate(string waiterFirstName, string waiterLastName, DateTimeOffset clockIn)
            : base("Restaurant.AddShift")
        {
            this.waiterFirstName = waiterFirstName;
            this.waiterLastName = waiterLastName;
            this.clockIn = clockIn;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("WaiterFirstName", waiterFirstName);
            command.Parameters.AddWithValue("WaiterLastName", waiterLastName);
            command.Parameters.AddWithValue("ClockIn", clockIn);
        }

        public override DateTimeOffset Translate(SqlCommand command)
        {
            return clockIn;
        }
    }
}
