using System;
using System.Collections.Generic;
using System.Text;

namespace BikeRental
{
    public class DayRental : BikeRental
    {
        protected override decimal Price()
        {
            return 20;
        }

        protected override decimal TotalTime()
        {
            return (decimal)TimeSpan.FromTicks(Yield.Ticks - Retrieval.Ticks).TotalDays;
        }
    }
}
