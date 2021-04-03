using System;
using Models;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("New book");
            book.AddGrade(89.89);
            book.AddGrade(25.42);
            book.AddGrade(92.11);
            book.GetStatistics();
            
            var statistics = book.GetStatistics();
            Console.WriteLine($"The lowest grade is {statistics.Lowest}");
            Console.WriteLine($"The highest grade is {statistics.Highest}");
            Console.WriteLine($"The average grade is {statistics.Average:N1}");
            Console.WriteLine($"Grade Letter: {statistics.Letter}");
        }
    }
}
