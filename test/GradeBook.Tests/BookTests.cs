using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        // [Fact]
    
        // public void CheckIfStatementWorks()
        // {                        
        //     var book3 = new Book("TestBook");
        //     book3.AddGrade(5.0);        
        //     Assert.Equal(5.0, book3.grades[0]);
        // }    
        [Fact]
        public void BookComputingTest()
        {
            //arrange
            var book = new InMemoryBook("");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.3);        
            //act        
            var result = book.GetStatistics();
            //assert
            Assert.Equal(85.6, result.Average, 1);
            Assert.Equal(90.5, result.High, 1);
            Assert.Equal(77.3, result.Low, 1);
            Assert.Equal('B', result.Letter);
        }
    }
}
