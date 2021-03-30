using Models;
using Xunit;

namespace Tests
{
    public class BookTests
    {
        [Fact]
        public void BookCalculatesAnAverageGrade()
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
            Assert.Equal(90.5, results.Highest, 1);
            Assert.Equal(77.3, results.Lowest, 1);
        }
    }
}
