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
        public DateTime Retrieval { get; set; }
        public DateTime Yield { get; set; }

        protected abstract decimal Price();
        protected abstract double TotalTime();

        public decimal Amount()
        {
            return Price() * (decimal)TotalTime() * Bikes.Count * Promotion.Multiplier(Bikes.Count);
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

        public static decimal Multiplier(int bikes)
        {
            return !IsValid(bikes) ? 1 : (100 - discount) / 100;
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

        protected override double TotalTime()
        {
            return TimeSpan.FromTicks(Yield.Ticks - Retrieval.Ticks).TotalHours;
        }
    }

    public class DayRental : BikeRental
    {
        protected override decimal Price()
        {
            return 20;
        }

        protected override double TotalTime()
        {
            return TimeSpan.FromTicks(Yield.Ticks - Retrieval.Ticks).TotalDays;
        }
    }

    public class WeekRental : BikeRental
    {
        protected override decimal Price()
        {
            return 60;
        }

        protected override double TotalTime()
        {
            return TimeSpan.FromTicks(Yield.Ticks - Retrieval.Ticks).TotalDays / 7;
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
