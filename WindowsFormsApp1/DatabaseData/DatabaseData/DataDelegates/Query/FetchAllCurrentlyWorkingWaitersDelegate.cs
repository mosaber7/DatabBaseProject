using DataAccess;
using DatabaseData.Models;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace DatabaseData.DataDelegates.Query
{
    internal class FetchAllCurrentlyWorkingWaitersDelegate : DataReaderDelegate<IReadOnlyList<Waiter>>
    {
        private readonly string firstName;
        private readonly string lastName;

        public FetchAllCurrentlyWorkingWaitersDelegate(string firstname, string lastname)
            : base("Restaurant.FetchAllCurrentlyWorkingWaiters")
        {
            firstName = firstname;
            lastName = lastname;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("FirstName", firstName);
            command.Parameters.AddWithValue("LastName", lastName);
        }

        public override IReadOnlyList<Waiter> Translate(SqlCommand command, IDataRowReader reader)
        {
            List<Waiter> waiters = new List<Waiter>();

            while(reader.Read())
            {
                waiters.Add(new Waiter(
                    reader.GetString("FirstName"),
                    reader.GetString("LastName")));
            }

            return waiters;
        }
    }
}
