using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BikeRental
{
    public abstract class BikeRental
    {
        public DateTime Retrieval { get; set; }
        public DateTime Yield { get; set; }

        protected abstract decimal Price();
        protected abstract decimal TotalTime();

        public decimal Amount()
        {
            return Price() * TotalTime();
        }
    }
}
