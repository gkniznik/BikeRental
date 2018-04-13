using System;
using System.Collections.Generic;
using System.Text;

namespace BikeRental
{
    /*
        Esta clase representa el alquiler por hora, con sus propias funciones de cálculo
         */
    public class HourRental : BikeRental
    {
        protected override decimal Price()
        {
            return 5;
        }

        protected override decimal TotalTime()
        {
            return (decimal)TimeSpan.FromTicks(Yield.Ticks - Retrieval.Ticks).TotalHours;
        }
    }
}
