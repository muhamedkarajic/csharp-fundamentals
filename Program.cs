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
            book.ShowStatistics();
        }
    }
}
