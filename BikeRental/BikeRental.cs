using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BikeRental
{
    public abstract class BikeRental
    {
        public Customer Customer { get; set; }
        public List<Bike> Bikes { get; set; }

        protected abstract decimal Price();

        public decimal Amount()
        {
            return Price() * Bikes.Count - Promotion.Percentage(Bikes.Count);
        }
    }

    public class Customer
    {

    }

    public class Bike
    {

    }

    class Promotion
    {
        static decimal discount = 30;

        public static decimal Percentage(int bikes)
        {
            return !IsValid(bikes) ? 0 : discount;
        }

        static bool IsValid(int bikes)
        {
            return bikes >= 3 && bikes <= 5;
        }
    }

    public class HourRental : BikeRental
    {
        protected override decimal Price()
        {
            return 5;
        }
    }

    public class DayRental : BikeRental
    {
        protected override decimal Price()
        {
            return 20;
        }
    }

    public class WeekRental : BikeRental
    {
        protected override decimal Price()
        {
            return 60;
        }
    }

    public class Test
    {
        public Test()
        {
            DayRental dr = new DayRental();
            decimal amount = dr.Amount();
        }
    }
}
