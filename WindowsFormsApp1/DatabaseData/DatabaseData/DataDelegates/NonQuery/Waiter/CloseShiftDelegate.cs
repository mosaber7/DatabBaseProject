using DataAccess;
using DatabaseData.Models;
using System;
using System.Data.SqlClient;

namespace DatabaseData.DataDelegates.NonQuery
{
    internal class CloseShiftDelegate : NonQueryDataDelegate<DateTimeOffset>
    {
        private readonly string waiterFirstName;
        private readonly string waiterLastName;
        private readonly DateTimeOffset clockOut;

        public CloseShiftDelegate(string waiterFirstName, string waiterLastName, DateTimeOffset clockOut)
            : base("Restaurant.AddShift")
        {
            this.waiterFirstName = waiterFirstName;
            this.waiterLastName = waiterLastName;
            this.clockOut = clockOut;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("WaiterFirstName", waiterFirstName);
            command.Parameters.AddWithValue("WaiterLastName", waiterLastName);
            command.Parameters.AddWithValue("ClockOut", clockOut);
        }

        public override DateTimeOffset Translate(SqlCommand command)
        {
            return clockOut;
        }
    }
}
