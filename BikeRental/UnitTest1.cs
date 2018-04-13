using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BikeRental;

namespace RentalTests
{
    [TestClass]
    public class RentalTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Rentals rentals = new Rentals();

            rentals.Items.Add(new HourRental()
            {
                Retrieval = new DateTime(2018, 4, 12, 10, 0, 0),
                Yield = new DateTime(2018, 4, 13, 10, 0, 0)
            });
            rentals.Items.Add(new DayRental()
            {
                Retrieval = new DateTime(2018, 4, 9, 10, 0, 0),
                Yield = new DateTime(2018, 4, 13, 10, 0, 0)
            });
            rentals.Items.Add(new WeekRental()
            {
                Retrieval = new DateTime(2018, 4, 6, 10, 0, 0),
                Yield = new DateTime(2018, 4, 13, 10, 0, 0)
            });

            decimal amount = rentals.TotalAmount();
        }
    }
}
