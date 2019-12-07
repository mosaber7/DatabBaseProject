using DataAccess;
using DatabaseData.Models;
using System.Data.SqlClient;
using System.Collections.Generic;
using System;

namespace DatabaseData.DataDelegates.Query
{
    internal class GetShiftsDelegate : DataReaderDelegate<IReadOnlyList<(Waiter, Shift)>>
    {
        public GetShiftsDelegate()
            : base("Restaurant.GetShifts")
        {
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);
        }
       
        public override IReadOnlyList<(Waiter, Shift)> Translate(SqlCommand command, IDataRowReader reader)
        {

            List<(Waiter, Shift)> Shifts= new List<(Waiter, Shift)>();
            while (reader.Read())
            {
                Shifts.Add((
                    new Waiter(reader.GetString("FirstName"), reader.GetString("LastName")),
                    new Shift(Convert.ToDateTime(reader.GetString("ClockIn")),
                    Convert.ToDateTime(reader.GetString("ClockOut")))))
                            
                       ;
            }

            return Shifts;
        }
    }
}
