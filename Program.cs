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

if(numbers.Count > 0)
{
    Console.WriteLine(numbers.Sum() / numbers.Count);
}
else {
    Console.WriteLine("List is empty");
}
            
        }
    }
}
