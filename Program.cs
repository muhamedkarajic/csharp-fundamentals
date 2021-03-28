using System;
namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] { 12.2, 13.3, 10.4, 1.6 };

            var result = 0.0;

            result += numbers[0];
            result += numbers[1];
            result += numbers[2];
            result += numbers[3];

            Console.WriteLine(result / 4);
        }
    }
}
