using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<double>() { 12.2, 13.3, 10.4, 1.6 };
            numbers.Add(22.1);

            if (numbers.Count > 0)
            {
                Console.WriteLine($"The average of the numbers is: {numbers.Sum() / numbers.Count:N1}");
            }
            else
            {
                Console.WriteLine("List is empty");
            }

        }
    }
}
