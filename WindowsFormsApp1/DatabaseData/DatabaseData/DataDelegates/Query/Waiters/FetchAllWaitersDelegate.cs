using DataAccess;
using DatabaseData.Models;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace DatabaseData.DataDelegates.Query.Waiters
{
    internal class FetchAllWaitersDelegate : DataReaderDelegate<IReadOnlyList<Waiter>>
    {
        public FetchAllWaitersDelegate()
            : base("Restaurant.FetchAllWaiters")
        {
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);
        }

        public override IReadOnlyList<Waiter> Translate(SqlCommand command, IDataRowReader reader)
        {
            List<Waiter> waiters = new List<Waiter>();

            while (reader.Read())
            {
                waiters.Add(new Waiter(
                    reader.GetString("FirstName"),
                    reader.GetString("LastName"),
                    reader.GetValue<decimal>("Salary")));
            }

            return waiters;
        }
    }
}
