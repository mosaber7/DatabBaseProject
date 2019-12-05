using DataAccess;
using DatabaseData.Models;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace DatabaseData.DataDelegates.Query
{
    internal class FetchAllCurrentlyWorkingWaitersDelegate : DataReaderDelegate<IReadOnlyList<Waiter>>
    {
        public FetchAllCurrentlyWorkingWaitersDelegate()
            : base("Restaurant.FetchAllCurrentlyWorkingWaiters")
        {
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);
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
