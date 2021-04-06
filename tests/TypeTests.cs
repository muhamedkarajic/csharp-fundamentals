using Models;
using Xunit;

namespace Tests
{
    public delegate string WriteLogDelegate(string logMessage);

    public class TypeTests
    {
        int count = 0;

        [Fact]
        public void WriteLogDelegateCanPointToMethod()
        {
            WriteLogDelegate log; 

            log = new WriteLogDelegate(ReturnMessage1);
            log += ReturnMessage2;

            log("Hello");
            Assert.Equal(2, count);
        }

        string ReturnMessage1(string message)
        {
            count++;
            return message.ToUpper();
        }

        string ReturnMessage2(string message)
        {
            count++;
            return message.ToLower();
        }

        [Fact]
        public void StringsBehaveLikeValueTypes()
        {
            string name = "Muhamed";
            string nameUppercase = MakeUppercase(name);

            System.Console.WriteLine(name);
            Assert.Equal("Muhamed", name);
            Assert.Equal("MUHAMED", nameUppercase);
        }

        private string MakeUppercase(string parameter)
        {
            return parameter.ToUpper();
        }

        [Fact]
        public void ValueTypesAlsoPassedByValue()
        {
            var x = GetInt();
            SetInt(ref x);

            Assert.Equal(4, x);
        }

        private void SetInt(ref int x)
        {
            x = 4;
        }

        private int GetInt()
        {
            return 3;
        }

        [Fact]
        public void CanSetNameFromReference()
        {
            var book = GetBookByName("Book Name");

            SetBookNameByReference(ref book, "New Book Name");
            SetBookNameByReferenceOut(out book, "New Book Name");

            Assert.Equal("New Book Name", book.Name);
        }

        [Fact]
        public void CantSetNameFromValue()
        {
            var book = GetBookByName("Book Name");

            SetBookNameByValue(book, "New Book Name");

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

        private void SetBookNameByValue(Book book, string name)
        {
            book.Name = name;
        }

        private void SetBookNameByReferenceOut(out Book book, string name)
        {
            book = new Book(name);
        }

        private void SetBookNameByReference(ref Book book, string name)
        {
            book = new Book(name);
        }
    }
}
