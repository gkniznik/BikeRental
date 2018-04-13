using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BikeRental
{
    /*
        Esta clase representa la factura o ticket para el pago
         */
    public class Rentals
    {
        public List<BikeRental> Items { get; set; }

        public Rentals()
        {
            Items = new List<BikeRental>();
        }

        public decimal TotalAmount()
        {
            return Items.Sum(x => x.Amount()) * Promotion.Multiplier(Items.Count);
        }
    }
}
