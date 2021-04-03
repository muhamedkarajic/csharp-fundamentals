using System;
using Models;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("New book");
            
            while (true)
            {
                Console.Write("Please enter a grade ('q' to quit): ");
                var input = Console.ReadLine();
                if(input == "q")
                    break;
                
                var grade = double.Parse(input);
                book.AddGrade(grade);
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
