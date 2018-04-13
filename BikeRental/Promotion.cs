using System;
using System.Collections.Generic;
using System.Text;

namespace BikeRental
{
    class Promotion
    {
        static decimal discount = 30;

        public static decimal Multiplier(int items)
        {
            return !IsValid(items) ? 1 : (100 - discount) / 100;
        }

        static bool IsValid(int items)
        {
            return items >= 3 && items <= 5;
        }
    }
}
