using System.Collections.Generic;

namespace Models
{
    public class Book 
    {
        List<double> grades;
        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }
    }
}