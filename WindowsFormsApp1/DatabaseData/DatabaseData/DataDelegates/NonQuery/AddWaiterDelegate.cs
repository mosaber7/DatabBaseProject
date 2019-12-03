using DatabaseData.Models;
using DataAccess;
using System.Data.SqlClient;

namespace DatabaseData.DataDelegates
{
    internal class AddWaiterDelegate : NonQueryDataDelegate<Waiter>
    {
        public readonly string firstName;
        public readonly string lastName;

        public AddWaiterDelegate(string firstname, string lastname)
            : base("Restaurant.AddWaiter")
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
