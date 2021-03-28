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
        static List<double> grades;

        static public void AddGrade(double grade)
        {
            grades.Add(grade);
        }
    }
}