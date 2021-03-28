using System;
using System.Collections.Generic;

namespace Models
{
    public class Book 
    {
        public Book(string name)
        {
            this.name = name;
            grades = new List<double>();
        }

        string name;
        List<double> grades;

        public void AddGrade(double grade)
        {
            if(grade > 100)
                throw new Exception("Grade can't be higher then 100.0");
            else if(grade < 0)
                throw new Exception("Grade can't be less then 0.0");

            grades.Add(grade);
        }

        public void ShowStatistics()
        {
            var lowestGrade = double.MaxValue;
            var highestGrade = double.MinValue;
            
            var result = 0.0;
            foreach (var grade in grades)
            {
                lowestGrade = Math.Min(grade, lowestGrade);
                highestGrade = Math.Max(grade, highestGrade);
                result += grade;
            }

            Console.WriteLine($"The lowest grade is {lowestGrade}");
            Console.WriteLine($"The highest grade is {highestGrade}");
            Console.WriteLine($"The average grade is {result / grades.Count:N2}");
        }
    }
}