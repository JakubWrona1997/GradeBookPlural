using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Jakob");
            book.GradeAdded += OnGradeAdded;

            var flag = false;
            while (!flag)
            {   
                Console.WriteLine("Please provide a grade, if you want to exit press q");
                var input = Console.ReadLine();
                if(input =="q")
                {
                    flag = true;
                    continue;
                }
                try
                {
                var grade = double.Parse(input);
                book.AddGrade(grade);
                }
                catch(ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);                    
                }
                catch(FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("**");
                }
            }                             
            var stats = book.GetStatistics();
            
            Console.WriteLine($"For the Book named {book.Name}:\n Lowest grade is {stats.Low}, Highest is {stats.High},Average:{stats.Average}, Letter:{stats.Letter}");     
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
        static void OnGradeAdded(object sender, EventArgs e)
        {
            Console.WriteLine("A grade was added!");
        }
    }
}
