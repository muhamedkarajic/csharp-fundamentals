using System;
using Models;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new InMemoryBook("New book");
            book.GradeAdded += OnGradeAdded;

            EnterGrades(book);

            var statistics = book.GetStatistics();
            Console.WriteLine($"For the book named {book.Name}");
            Console.WriteLine($"The lowest grade is {statistics.Lowest}");
            Console.WriteLine($"The highest grade is {statistics.Highest}");
            Console.WriteLine($"The average grade is {statistics.Average:N1}");
            Console.WriteLine($"Grade Letter: {statistics.Letter}");
        }

        private static void EnterGrades(IBook book)
        {
            while (true)
            {
                Console.Write("Please enter a grade ('q' to quit): ");
                var input = Console.ReadLine();
                if (input == "q")
                    break;

                try
                {
                    var grade = Double.Parse(input);
                    book.AddGrade(grade);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine($"Grade of {Double.Parse(input):N2}, added succesfully.");
                }
            }
        }

        static void OnGradeAdded(object sender, EventArgs e)
        {
            Console.WriteLine("Event: GRADE ADDED");
        }
    }
}
