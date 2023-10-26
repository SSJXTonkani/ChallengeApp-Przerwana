
using System.ComponentModel.Design;

namespace Challenge_App

{

    public class Employee
    {
        public Employee(string name, string surname, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }
        public float Result
        {
            get
            {
                return grades.Sum();
            }
        }
        private List<float> grades = new List<float>();


        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine("Invalid grade value");
            }
        }
        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                Console.WriteLine("string is not a number");
            }
        }
        public void AddGrade(double grade)
        {
            var valueinfloat = (float)grade;
            AddGrade(valueinfloat);
        }
        public void AddGrade(int grade)
        {
            var valueinfloat = (float)grade;
            AddGrade(valueinfloat);
        }
        public void AddGrade(long grade)
        {
            var valueinfloat = (float)grade;
            AddGrade(valueinfloat);
        }
        public void AddGrade(ulong grade)
        {
            var valueinfloat = (float)grade;
            AddGrade(valueinfloat);
        }
        public void AddGrade(uint grade)
        {
            var valueinfloat = (float)grade;
            AddGrade(valueinfloat);
        }
        public void AddGrade(decimal grade)
        {
            var valueinfloat = (float)grade;
            AddGrade(valueinfloat);
        }
        public Statistics GetStatistics()
        {
            var statistiscs = new Statistics();
            statistiscs.Average = 0;
            statistiscs.Max = float.MinValue;
            statistiscs.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                statistiscs.Max = Math.Max(statistiscs.Max, grade);
                statistiscs.Min = Math.Min(statistiscs.Min, grade);
                statistiscs.Average += grade;
            }

            statistiscs.Average = statistiscs.Average / this.grades.Count;

            return statistiscs;
        }

    }

}