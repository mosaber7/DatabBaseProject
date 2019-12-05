using System.Collections.Generic;
using DataAccess;
using DatabaseData.Models;
using DatabaseData.DataDelegates.NonQuery;
using DatabaseData.DataDelegates;
using System;
using DatabaseData.DataDelegates.Query;

namespace DatabaseData
{
    class SqlWaiterRepository
    {
        private readonly SqlCommandExecutor executor;

        public SqlWaiterRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        public void CreateWaiter(string FirstName, string LastName, decimal Salary)
        {
            if (FirstName.Length == 0)
            {
                throw new ArgumentException("Empty first Name");
            }
            if(LastName.Length == 0)
            {
                throw new ArgumentException("Empty last name");
            }
            executor.ExecuteNonQuery(new AddWaiterDelegate(FirstName, LastName, Salary));
        }

        public IReadOnlyList<Waiter> FetchAllCurrentylWorkingWaiters()
        {
            return executor.ExecuteReader(new FetchAllCurrentlyWorkingWaitersDelegate());
        }

        public void AddShift(string firstName, string lastName, DateTimeOffset timeOfShift)
        {
            if (firstName.Length == 0)
            {
                throw new ArgumentException("Empty first Name");
            }
            if (lastName.Length == 0)
            {
                throw new ArgumentException("Empty last name");
            }
            executor.ExecuteNonQuery(new AddShiftDelegate(firstName, lastName, timeOfShift));
        }

        public void CloseShift(string firstName, string lastName)
        {
            if (firstName.Length == 0)
            {
                throw new ArgumentException("Empty first Name");
            }
            if (lastName.Length == 0)
            {
                throw new ArgumentException("Empty last name");
            }
            executor.ExecuteNonQuery(new CloseShiftDelegate(firstName, lastName, DateTimeOffset.Now));
        }
    }
}
