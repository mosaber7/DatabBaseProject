using DataAccess;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DatabaseData.DataDelegates.NonQuery.Waiters
{
    internal class AddShiftNoDateDelegate : NonQueryDataDelegate<DateTimeOffset>
    {
        private readonly string waiterFirstName;
        private readonly string waiterLastName;

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

            var date = command.Parameters.Add("ClockIn", SqlDbType.DateTimeOffset);
            date.Direction = ParameterDirection.Output;
        }

        public override DateTimeOffset Translate(SqlCommand command)
        {
            return (DateTimeOffset)command.Parameters["ClockIn"].Value;
        }
    }
}
