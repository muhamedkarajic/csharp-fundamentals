using System;
using System.Collections.Generic;

namespace Models
{
    public class Statistics
    {

        public double Lowest;
        public double Highest;
        public int Count;
        public double Sum;
        public double Average
        {
            get
            {
                return Sum / Count;
            }
        }
        public char Letter
        {
            get
            {
                switch (Average)
                {
                    case var d when d >= 90.0:
                        return 'A';
                    case var d when d >= 80.0:
                        return 'B';
                    case var d when d >= 70.0:
                        return 'C';
                    case var d when d >= 60.0:
                        return 'D';
                    case var d when d >= 50.0:
                        return 'E';
                    default:
                        return 'F';
                }

            }
        }

        public Statistics()
        {
            Sum = 0.0;
            Count = 0;
            Lowest = double.MaxValue;
            Highest = double.MinValue;
        }

        public void Add(double number)
        {
            Sum += number;
            Count += 1;
            Lowest = Math.Min(number, Lowest);
            Highest = Math.Max(number, Highest);
        }
    }
}