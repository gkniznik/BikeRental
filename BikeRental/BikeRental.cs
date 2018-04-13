using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BikeRental
{
    /*
     Esta es la clase base de todas las modalidades de alquiler.
         */

    public abstract class BikeRental
    {
        // Fecha y hora de inicio
        public DateTime Retrieval { get; set; }
        // Fecha y hora de devolución
        public DateTime Yield { get; set; }

        // Métodos polimórficos para calcular totales
        protected abstract decimal Price();
        protected abstract decimal TotalTime();

        // Método de cálculo final.
        public decimal Amount()
        {
            return Price() * TotalTime();
        }
    }
}
