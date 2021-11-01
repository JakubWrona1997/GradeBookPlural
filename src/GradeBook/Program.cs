using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Jakob");
            book.AddGrade(56.1);
            book.AddGrade(31.5);
            
            var stats = book.GetStatistics();
            
            Console.WriteLine($"Lowest grade is {stats.Low}, Highest is {stats.High},Average:{stats.Average}");     
            // foreach (var item in grades)
            // {
            //     Console.WriteLine(item);
            // }

            // if(args.Length > 0)
            // {
            // Console.WriteLine($"Hello {args[0]}");  
            // }
            // else
            // {
            //     Console.WriteLine("Hello!");
            // }
           
        }
    }
}
