using DatabaseData.Models;
using DataAccess;
using System.Data.SqlClient;

namespace DatabaseData.DataDelegates
{
    internal class AddWaiterDelegate : NonQueryDataDelegate<Waiter>
    {
        private readonly string firstName;
        private readonly string lastName;
        private readonly decimal salary;

        public AddWaiterDelegate(string firstname, string lastname, decimal salary)
            : base("Restaurant.AddWaiter")
        {
            firstName = firstname;
            lastName = lastname;
            this.salary = salary;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("FirstName", firstName);
            command.Parameters.AddWithValue("LastName", lastName);
            command.Parameters.AddWithValue("Salary", salary);
        }

        public override Waiter Translate(SqlCommand command)
        {
            return new Waiter(firstName, lastName);
        }
    }
}
