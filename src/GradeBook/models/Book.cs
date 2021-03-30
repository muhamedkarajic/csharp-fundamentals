using System;
using System.Collections.Generic;

namespace Models
{
    public class Book 
    {
        public Book(string name)
        {
            Name = name;
            grades = new List<double>();
        }

        public string Name;
        List<double> grades;

        public void AddGrade(double grade)
        {
            if(grade > 100)
                throw new Exception("Grade can't be higher then 100.0");
            else if(grade < 0)
                throw new Exception("Grade can't be less then 0.0");

            grades.Add(grade);
        }

        public Statistics GetStatistics()
        {
            var result = new Statistics();
            result.Lowest = double.MaxValue;
            result.Highest = double.MinValue;
            
            foreach (var grade in grades)
            {
                result.Lowest = Math.Min(grade, result.Lowest);
                result.Highest = Math.Max(grade, result.Highest);
                result.Average += grade;
            }
            result.Average /= grades.Count;
            
            return result;
        }
    }
}