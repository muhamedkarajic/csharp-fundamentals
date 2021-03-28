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
            grades.Add(grade);
        }
    }
}