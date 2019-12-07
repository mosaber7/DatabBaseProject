using DataAccess;
using System;
using System.Data;
using System.Data.SqlClient;


namespace DatabaseData.DataDelegates.NonQuery.Waiters
{
    internal class CloseShiftNoDateDelegate : NonQueryDataDelegate<DateTimeOffset>
    {
        private readonly string waiterFirstName;
        private readonly string waiterLastName;

        public CloseShiftNoDateDelegate(string waiterFirstName, string waiterLastName)
            : base("Restaurant.CloseShiftNoDate")
        {
            this.waiterFirstName = waiterFirstName;
            this.waiterLastName = waiterLastName;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("WaiterFirstName", waiterFirstName);
            command.Parameters.AddWithValue("WaiterLastName", waiterLastName);

            var date = command.Parameters.Add("ClockOut", SqlDbType.DateTimeOffset);
            date.Direction = ParameterDirection.Output;
        }

        public override DateTimeOffset Translate(SqlCommand command)
        {
            return (DateTimeOffset)command.Parameters["ClockOut"].Value;
        }
    }
}
