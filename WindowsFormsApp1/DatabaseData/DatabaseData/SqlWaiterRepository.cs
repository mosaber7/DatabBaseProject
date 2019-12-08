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

        /// <summary>
        /// Creates a WaiterRepository based on the connectionString
        /// </summary>
        /// <param name="connectionString">ConnectionString to the Database in SQL format</param>
        public SqlWaiterRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        /// <summary>
        /// Adds a waiter into the database
        /// </summary>
        /// <param name="FirstName">Waiter's first name</param>
        /// <param name="LastName">Waiter's last name</param>
        /// <param name="Salary">Waiter's salary or hourly pay</param>
        /// <returns>Waiter's information</returns>
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

        /// <summary>
        /// Removes a Waiter from the Database
        /// </summary>
        /// <param name="firstName">Waiter's first name</param>
        /// <param name="lastName">Waiter's last name</param>
        /// <returns>Waiter's information</returns>
        public Waiter FireWaiter(string firstName, string lastName)
        {
            return executor.ExecuteNonQuery(new FireWaiterDelegate(firstName, lastName));
        }

        /// <summary>
        /// Returns the list will all the waiters currently working
        /// </summary>
        /// <returns>List of waiters currently working</returns>
        public IReadOnlyList<Waiter> FetchAllCurrentylWorkingWaiters()
        {
            return executor.ExecuteReader(new FetchAllCurrentlyWorkingWaitersDelegate());
        }

        /// <summary>
        /// Returns a list of all the waiters
        /// </summary>
        /// <returns>List of waiters</returns>
        public IReadOnlyList<Waiter> FetchAllWaiters()
        {
            return executor.ExecuteReader(new FetchAllWaitersDelegate());
        }

        /// <summary>
        /// Opens a shift for a waiter
        /// </summary>
        /// <param name="firstName">Waiter's first name</param>
        /// <param name="lastName">Waiter's last name</param>
        /// <returns>Date where the shift starts</returns>
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

        /// <summary>
        /// Adds a complete shift into a waiter
        /// </summary>
        /// <param name="firstName">Waiter's Name</param>
        /// <param name="lastName">Waiter's Last Name</param>
        /// <param name="startingTime">Starting time of the shift</param>
        /// <param name="endingTime">Ending time of the shift</param>
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

        /// <summary>
        /// Closes a shift from a waiter
        /// </summary>
        /// <param name="firstName">Waiter's First Name</param>
        /// <param name="lastName">Waiter's Last Name</param>
        /// <returns>Date of when the shift was closed</returns>
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
