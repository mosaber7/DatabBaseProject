using DataAccess;
using DatabaseData.Models;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace DatabaseData.DataDelegates.NonQuery.Waiters
{
    internal class FireWaiterDelegate : NonQueryDataDelegate<Waiter>
    {
        private readonly string firstName;
        private readonly string lastName;

        public FireWaiterDelegate(string firstname, string lastname)
            : base("Restaurant.FireWaiter")
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

        public override Waiter Translate(SqlCommand command)
        {
            return new Waiter(firstName, lastName);
        }
    }
}
