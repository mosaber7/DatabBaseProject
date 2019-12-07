using DataAccess;
using DatabaseData.Models;
using System.Data.SqlClient;
using System.Collections.Generic;
using System;

namespace DatabaseData.DataDelegates.Query
{

    internal class GetEmployeeShiftDelegate : DataReaderDelegate<(Waiter, Shift)>
    {
        private readonly string FirstName;
        private readonly string LastName;
        public GetEmployeeShiftDelegate(string waiterFirstName, string waiterLastName)
            : base("Restaurant.GetShifts")
        {
            this.FirstName = waiterFirstName;
            this.LastName = waiterLastName;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);
        }

        public override (Waiter, Shift) Translate(SqlCommand command, IDataRowReader reader)
        {

            (Waiter, Shift) waiter;
           
           waiter= (new Waiter(reader.GetString("FirstName"), reader.GetString("LastName")),
                 new Shift(Convert.ToDateTime(reader.GetString("ClockIn")),
                    Convert.ToDateTime(reader.GetString("ClockOut")))
                );
        
            return waiter;
        }
    }
}
