using System;

namespace DatabaseData.Models
{
    public class Shift
    {
        public DateTime ClockIn { get; }

        public DateTime ClockOut { get; }

        public Shift(DateTime clockInTime, DateTime clockOutTime)
        {
            ClockIn = clockInTime;
            ClockOut = clockOutTime;
        }
    }
}
