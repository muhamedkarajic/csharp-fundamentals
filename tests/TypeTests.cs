using Models;
using Xunit;

namespace Tests
{
    public class TypeTests
    {
        [Fact]
        public void BookGetsChangedName()
        {
          
            var book = GetBookByName("Book Name");
            
            SetBookName(book, "New Book Name");

            Assert.Equal("New Book Name", book.Name);
        }

        [Fact]
        public void BookCalculatesAnAverageGrade()
        {
          
            var book1 = GetBookByName("Book 1");
            var book2 = GetBookByName("Book 2");

            Assert.Equal("Book 1", book1.Name);
            Assert.Equal("Book 2", book2.Name);
            Assert.NotSame(book1, book2);
        }

        [Fact]
        public void TwoVarsCanReferenceSameObject()
        {
          
            var book1 = GetBookByName("Book 1");
            var book2 = book1;

            Assert.Same(book1, book2);
            Assert.True(object.ReferenceEquals(book1, book2));
        }

        private Book GetBookByName(string name)
        {
            return new Book(name);
        }

        private void SetBookName(Book book, string name)
        {
            book.Name = name;
        }
    }
}
