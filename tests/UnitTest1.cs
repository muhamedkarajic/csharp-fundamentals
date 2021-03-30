using Models;
using Xunit;

namespace Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // arrange
            var book = new Book("New book");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.3);

            // act
            var results = book.GetStatistics();

            // asset
            Assert.Equal(85.6, results.Average, 1);
        }
    }
}
