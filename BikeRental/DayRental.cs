using System;
using System.Collections.Generic;
using System.Text;

namespace BikeRental
{
    /*
        Esta clase representa el alquiler por día, con sus propias funciones de cálculo
         */
    public class DayRental : BikeRental
    {
        protected override decimal Price()
        {
            return 20;  // Deberia almacenarse en base de datos
        }

        protected override decimal TotalTime()
        {
            return (decimal)TimeSpan.FromTicks(Yield.Ticks - Retrieval.Ticks).TotalDays;
        }
    }
}
