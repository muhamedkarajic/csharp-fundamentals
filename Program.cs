using System;
namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] { 12.2, 13.3, 10.4, 1.6 };

            var result = 0.0;

            foreach (var number in numbers)
            {
                result += number;
            }

            if (numbers.Length > 0)
            {
                Console.WriteLine(result / numbers.Length);
            }
            else
            {
                Console.WriteLine("Array is empty.");
            }
        }
    }
}
