using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BikeRental
{
    public class Rentals
    {
        List<BikeRental> Items { get; set; }

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
