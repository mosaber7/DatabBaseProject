using System.Collections.Generic;
using DataAccess;
using DatabaseData.Models;
using DatabaseData.DataDelegates.NonQuery.Waiters;
using System;
using DatabaseData.DataDelegates.Query.Waiters;

namespace DatabaseData
{
    public class SqlWaiterRepository
    {
        private readonly SqlCommandExecutor executor;

        public SqlWaiterRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        public Waiter AddWaiter(string FirstName, string LastName, decimal Salary)
        {
            if (FirstName.Length == 0)
            {
                throw new ArgumentException("Empty first Name");
            }
            if(LastName.Length == 0)
            {
                throw new ArgumentException("Empty last name");
            }
            return executor.ExecuteNonQuery(new AddWaiterDelegate(FirstName, LastName, Salary));
        }

        public Waiter FireWaiter(string firstName, string lastName)
        {
            return executor.ExecuteNonQuery(new FireWaiterDelegate(firstName, lastName));
        }

        public IReadOnlyList<Waiter> FetchAllCurrentylWorkingWaiters()
        {
            return executor.ExecuteReader(new FetchAllCurrentlyWorkingWaitersDelegate());
        }

        public IReadOnlyList<Waiter> FetchAllWaiters()
        {
            return executor.ExecuteReader(new FetchAllWaitersDelegate());
        }

        public DateTimeOffset OpenShift(string firstName,string lastName)
        {
            if (firstName.Length == 0)
            {
                throw new ArgumentException("Empty first Name");
            }
            if (lastName.Length == 0)
            {
                throw new ArgumentException("Empty last name");
            }
            return executor.ExecuteNonQuery(new AddShiftNoDateDelegate(firstName, lastName));
        }

        public void AddShift(string firstName, string lastName, DateTimeOffset startingTime, DateTimeOffset endingTime)
        {
            if (firstName.Length == 0)
            {
                throw new ArgumentException("Empty first Name");
            }
            if (lastName.Length == 0)
            {
                throw new ArgumentException("Empty last name");
            }
            executor.ExecuteNonQuery(new CloseShiftNoDateDelegate(firstName, lastName));
            executor.ExecuteNonQuery(new AddShiftDelegate(firstName, lastName, startingTime));
            executor.ExecuteNonQuery(new CloseShiftDelegate(firstName, lastName, endingTime));
        }

        public DateTimeOffset CloseShift(string firstName, string lastName)
        {
            if (firstName.Length == 0)
            {
                throw new ArgumentException("Empty first Name");
            }
            if (lastName.Length == 0)
            {
                throw new ArgumentException("Empty last name");
            }
            return executor.ExecuteNonQuery(new CloseShiftNoDateDelegate(firstName, lastName));
        }
    }
}
