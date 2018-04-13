using System;
using System.Collections.Generic;
using System.Text;

namespace BikeRental
{
    /*
        Esta clase representa la promoci☺n vigente para el plan familiar
         */
    class Promotion
    {
        // Porcentaje de descuento. Deberia almacenarse en base de datos 
        static decimal discount = 30;

        // Fraccion del precio a pagar con descuento. Sin descuento = 1.
        public static decimal Multiplier(int items)
        {
            return !IsValid(items) ? 1 : (100 - discount) / 100;
        }

        // Verifica las condiciones para que el descuento se aplique
        static bool IsValid(int items)
        {
            return items >= 3 && items <= 5;
        }
    }
}
