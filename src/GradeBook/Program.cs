using System.Collections.Generic;
using System.IO;
using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Andres GRADE BOOK");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.5);
            var stats = book.GetStatistics();
            Console.WriteLine($"El grado mas bajo es: {stats.Low}");
            Console.WriteLine($"El grado mas alto es: {stats.High}");
            Console.WriteLine($"La calificacion promedio es: {stats.Average:N1}");
            // Console.WriteLine($"HOla: {stats.name}");
        }
    }
}
