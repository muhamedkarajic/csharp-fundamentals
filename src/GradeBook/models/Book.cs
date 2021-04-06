using System;
using System.Collections.Generic;
using System.IO;

namespace Models
{
    public delegate void GradeAddedDelegate(object sender, EventArgs args);

    public class NamedObject : Object
    {
        public NamedObject(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

    }

    public interface IBook
    {
        void AddGrade(double grade);
        Statistics GetStatistics();
        string Name { get; }
        event GradeAddedDelegate GradeAdded;
    }

    public abstract class Book : NamedObject, IBook
    {
        public Book(string name) : base(name) { }

        public abstract void AddGrade(double grade);

        public abstract event GradeAddedDelegate GradeAdded;

        public abstract Statistics GetStatistics();
    }

    public class DiskBook : Book
    {
        public DiskBook(string name) : base(name) { }

        public override event GradeAddedDelegate GradeAdded;

        public override void AddGrade(double grade)
        {
            var writer = File.AppendText($"{Name}.txt");
            writer.WriteLine(grade);
        }

        public override Statistics GetStatistics()
        {
            throw new NotImplementedException();
        }
    }

    public class InMemoryBook : Book
    {
        public InMemoryBook(string name) : base(name)
        {
            grades = new List<double>();
        }

        public override event GradeAddedDelegate GradeAdded;
        List<double> grades;

        public void AddGrade(char letter)
        {
            switch (letter)
            {
                case 'A':
                    AddGrade(90);
                    break;
                case 'B':
                    AddGrade(80);
                    break;
                case 'C':
                    AddGrade(70);
                    break;
                case 'D':
                    AddGrade(60);
                    break;
                case 'E':
                    AddGrade(50);
                    break;
                case 'F':
                    AddGrade(0);
                    break;
                default:
                    throw new Exception("This letter grade is not supported!");
            }
        }

        public override void AddGrade(double grade)
        {
            if (grade > 100)
                throw new Exception("Grade can't be higher then 100.0");
            else if (grade < 0)
                throw new Exception("Grade can't be less then 0.0");

            grades.Add(grade);
            if (GradeAdded != null)
            {
                GradeAdded(this, new EventArgs());
            }
        }

        public override Statistics GetStatistics()
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

            switch (result.Average)
            {
                case var d when d >= 90.0:
                    result.Letter = 'A';
                    break;
                case var d when d >= 80.0:
                    result.Letter = 'B';
                    break;
                case var d when d >= 70.0:
                    result.Letter = 'C';
                    break;
                case var d when d >= 60.0:
                    result.Letter = 'D';
                    break;
                case var d when d >= 50.0:
                    result.Letter = 'E';
                    break;
                case var d when d >= 0.0:
                    result.Letter = 'F';
                    break;
            }

            return result;
        }
    }
}