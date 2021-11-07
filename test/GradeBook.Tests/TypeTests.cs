using System;
using System.Collections.Generic;
using Xunit;

namespace GradeBook.Tests
{

    public delegate string WriteLogDelegate(string logMessage);

    
    public class TypeTests
    {           
        [Fact]

        public void WriteLogDelegateCanPointToMethod()
        {
            WriteLogDelegate log;
            log = ReturnMessage;
            var result = log("Hello");            

            Assert.Equal("Hello", result);
        }

        private string ReturnMessage(string message)
        {
            return message;
        }  


        [Fact]

        public void ValueTest()
        {
            var x = GetInt();
            SetInt(ref x);

            Assert.Equal(42,x);
        }

        private void SetInt(ref int x)
        {
            x=42;
        }

        private int GetInt()
        {
            return 3;
        }

        [Fact]
        public void StringLikeValue()
        {
            string name = "Kuba";
            var upper = MakeUpparcase(name);

            //assert
            Assert.Equal("Kuba", name);    
            Assert.Equal("KUBA", upper);    
        }

        private string MakeUpparcase(string parameter)
        {
            return parameter.ToUpper();
        }

        [Fact]
        public void PassByReference()
        {
            //arrange
            var book1 = GetBook("Book 1");
            GetBookSetName(ref book1, "New Name");
            //act        
            
            //assert
            Assert.Equal("New Name",book1.Name);
        }

        private void GetBookSetName(ref Book book, string name)
        {
            book = new Book(name);
        }

        [Fact]
        public void PassByValue()
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
