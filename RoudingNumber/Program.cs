using System;

namespace RoudingNumber
{
    public class Program
    {
        static void Main(string[] args)
        {
        }

        public double RoundingUpToNearest10(double value)
        {
            return Math.Ceiling(value * 10) / 10;
        }
        
        public  double RoundingDownNearest10(double value)
        {
            return Math.Floor(value * 10) / 10;
        }
        public  double RoundingUpAndDownNearest10(double value)
        {
            return Math.Round((value * 10), MidpointRounding.AwayFromZero) / 10;
        }

        public  double RoundingUpToNearest5(double value)
        {
            return Math.Ceiling(value * 20) / 20;
        }

        public  double RoundingDownNearest5(double value)
        {
            return Math.Floor(value * 20) / 20;
        }
        public  double RoundingUpAndDownNearest5(double value)
        {
            return Math.Round(value * 20) / 20;
        }
    }
}
