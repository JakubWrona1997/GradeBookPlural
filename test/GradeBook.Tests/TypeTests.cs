using System;
using Xunit;

namespace GradeBook.Tests
{
    public class TypeTests
    {
        [Fact]
        public void Test4()
        {
            //arrange
            var book1 = GetBook("Book 1");
            GetBookSetName(book1, "New Name");
            //act        
            
            //assert
            Assert.Equal("Book 1",book1.Name);
        }

        private void GetBookSetName(Book book, string name)
        {
            book = new Book(name);
        }

        [Fact]
        public void CanSetNameFromReference()
        {
            //arrange
            var book1 = GetBook("Book 1");
            SetName(book1, "New Name");
            //act        
            
            //assert
            Assert.Equal("New Name",book1.Name);
        }

        private void SetName(Book book, string name)
        {
            book.Name = name;
        }

        [Fact]
        public void GetBookReturnsDifferentObjects()
        {
            //arrange
            var book1 = GetBook("Book 1");
            var book2 = GetBook("Book 2");
            //act        
            
            //assert
            Assert.Equal("Book 1",book1.Name);
            Assert.Equal("Book 2",book2.Name);
        }
        [Fact]
        public void SameObjectsReference()
        {
            //arrange
            var book1 = GetBook("Book 1");
            var book2 = book1;
            //act        
            
            //assert
            Assert.Same(book1, book2);
        }
        Book GetBook(string name)
        {
            return new Book(name);
        }
    }
}
