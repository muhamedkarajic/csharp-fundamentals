using System;
using Models;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] grades)
        {
            var book = new Book("New book");
            
            foreach (var grade in grades)
            {
                book.AddGrade(Double.Parse(grade));
            }
            
            book.GetStatistics();
            
            var statistics = book.GetStatistics();
            Console.WriteLine($"The lowest grade is {statistics.Lowest}");
            Console.WriteLine($"The highest grade is {statistics.Highest}");
            Console.WriteLine($"The average grade is {statistics.Average:N1}");
            Console.WriteLine($"Grade Letter: {statistics.Letter}");
        }
    }
}
