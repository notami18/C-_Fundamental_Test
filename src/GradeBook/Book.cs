using System.Collections.Generic;
using System;

namespace GradeBook
{
    public class Book
    {
        private List<double> grades;
        public string Name;

        public Book(string name)
        {
            grades = new List<double>();
            Name = name;
        }

        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public Statistics GetStatistics()
        {
            var result = new Statistics();
            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;
            foreach (double number in grades)
            {
                result.Low = Math.Min(number, result.Low);
                result.High = Math.Max(number, result.High); // if (number > result.High)
                result.Average += number;
            }
            result.Average /= grades.Count;
            return result;
        }

        // public void ShowStatics()
        // {
        //     var result = 0.0;
        //     var highGrade = double.MinValue;
        //     var lowerGrade = double.MaxValue;
        //     foreach (double number in grades)
        //     {
        //         lowerGrade = Math.Min(number, lowerGrade);
        //         highGrade = Math.Max(number, highGrade); // if (number > highGrade)
        //         result += number;
        //     }
        //     result /= grades.Count;
        //     Console.WriteLine($"El grado mas bajo es: {lowerGrade}");
        //     Console.WriteLine($"El grado mas alto es: {highGrade}");
        //     Console.WriteLine($"La calificacion promedio es: {result:N1}");
        //     Console.WriteLine($"HOla: {name}");
        // }
    }
}