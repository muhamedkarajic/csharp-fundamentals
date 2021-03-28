using Models;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("New book");
            book.AddGrade(189.2);
        }
    }
}
