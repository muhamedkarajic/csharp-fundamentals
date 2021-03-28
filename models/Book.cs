using System;
using System.Collections.Generic;

namespace Models
{
    public class Book 
    {
        public Book()
        {
            grades = new List<double>();
        }

        List<double> grades;
        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }
    }
}