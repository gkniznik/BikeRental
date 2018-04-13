using System;
using System.Collections.Generic;
using System.Text;

namespace BikeRental
{
    /*
        Esta clase representa el alquiler por semana, con sus propias funciones de c◙lculo
         */
    public class WeekRental : BikeRental
    {
        protected override decimal Price()
        {
            return 60;
        }

        protected override decimal TotalTime()
        {
            return (decimal)TimeSpan.FromTicks(Yield.Ticks - Retrieval.Ticks).TotalDays / 7;
        }
    }
}
