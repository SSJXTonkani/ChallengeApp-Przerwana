
using System;
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
       
        public Statistics GetStatisticsWithFor()
        {
            var statistiscs = new Statistics();
            statistiscs.Average = 0;
            statistiscs.Max = float.MinValue;
            statistiscs.Min = float.MaxValue;

            var index = 0;

            for (float i = 0; i < this.grades.Count; i++)
            {
                statistiscs.Max = Math.Max(statistiscs.Max, this.grades[index]);
                statistiscs.Min = Math.Min(statistiscs.Min, this.grades[index]);
                statistiscs.Average += this.grades[index];
                index++;
            }

            statistiscs.Average /= this.grades.Count;

            return statistiscs;
        }
        public Statistics GetStatisticsWithForeach()
        {
            var statistiscs = new Statistics();
            statistiscs.Average = 0;
            statistiscs.Max = float.MinValue;
            statistiscs.Min = float.MaxValue;

            var index = 0;

            foreach (var grade in this.grades)
            {
                statistiscs.Max = Math.Max(statistiscs.Max, this.grades[index]);
                statistiscs.Min = Math.Min(statistiscs.Min, this.grades[index]);
                statistiscs.Average += this.grades[index];
                index++;
            }

            statistiscs.Average /= this.grades.Count;

            return statistiscs;
        }
        public Statistics GetStatisticsWithWhile()
        {
            var statistiscs = new Statistics();
            statistiscs.Average = 0;
            statistiscs.Max = float.MinValue;
            statistiscs.Min = float.MaxValue;

            var index = 0;

            while (index < this.grades.Count)
            {
                statistiscs.Max = Math.Max(statistiscs.Max, this.grades[index]);
                statistiscs.Min = Math.Min(statistiscs.Min, this.grades[index]);
                statistiscs.Average += this.grades[index];
                index++;
            }
            statistiscs.Average /= this.grades.Count;
            return statistiscs;
        }
        public Statistics GetStatisticsWithDoWhile()
        {
            var statistiscs = new Statistics();
            statistiscs.Average = 0;
            statistiscs.Max = float.MinValue;
            statistiscs.Min = float.MaxValue;

            var index = 0;

            do
            {
                statistiscs.Max = Math.Max(statistiscs.Max, this.grades[index]);
                statistiscs.Min = Math.Min(statistiscs.Min, this.grades[index]);
                statistiscs.Average += this.grades[index];
                index++;
            } while (index < this.grades.Count);

            statistiscs.Average /= this.grades.Count;

            return statistiscs;
        }
    }
}