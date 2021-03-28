using Models;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("New book");
            Book.AddGrade(89.2);
        }
    }
}
