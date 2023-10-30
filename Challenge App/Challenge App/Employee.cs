
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
            var statistiscs1 = new Statistics();
            statistiscs1.Average = 0;
            statistiscs1.Max = float.MinValue;
            statistiscs1.Min = float.MaxValue;

            var index = 0;

            for (float i = 0; i < this.grades.Count; i++)
            {
                statistiscs1.Max = Math.Max(statistiscs1.Max, this.grades[index]);
                statistiscs1.Min = Math.Min(statistiscs1.Min, this.grades[index]);
                statistiscs1.Average += this.grades[index];
                index++;
            }

            statistiscs1.Average /= this.grades.Count;

            return statistiscs1;
        }
        public Statistics GetStatisticsWithForeach()
        {
            var statistiscs2 = new Statistics();
            statistiscs2.Average = 0;
            statistiscs2.Max = float.MinValue;
            statistiscs2.Min = float.MaxValue;

            var index = 0;

            foreach (var grade in this.grades)
            {
                statistiscs2.Max = Math.Max(statistiscs2.Max, this.grades[index]);
                statistiscs2.Min = Math.Min(statistiscs2.Min, this.grades[index]);
                statistiscs2.Average += this.grades[index];
                index++;
            }

            statistiscs2.Average /= this.grades.Count;

            return statistiscs2;
        }
        public Statistics GetStatisticsWithWhile()
        {
            var statistiscs3 = new Statistics();
            statistiscs3.Average = 0;
            statistiscs3.Max = float.MinValue;
            statistiscs3.Min = float.MaxValue;

            var index = 0;

            while (index < this.grades.Count)
            {
                statistiscs3.Max = Math.Max(statistiscs3.Max, this.grades[index]);
                statistiscs3.Min = Math.Min(statistiscs3.Min, this.grades[index]);
                statistiscs3.Average += this.grades[index];
                index++;
            }
            statistiscs3.Average /= this.grades.Count;
            return statistiscs3;
        }
        public Statistics GetStatisticsWithDoWhile()
        {
            var statistiscs4 = new Statistics();
            statistiscs4.Average = 0;
            statistiscs4.Max = float.MinValue;
            statistiscs4.Min = float.MaxValue;

            var index = 0;

            do
            {
                statistiscs4.Max = Math.Max(statistiscs4.Max, this.grades[index]);
                statistiscs4.Min = Math.Min(statistiscs4.Min, this.grades[index]);
                statistiscs4.Average += this.grades[index];
                index++;
            } while (index < this.grades.Count);

            statistiscs4.Average /= this.grades.Count;

            return statistiscs4;
        }
    }
}