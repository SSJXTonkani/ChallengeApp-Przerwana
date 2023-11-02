
using System;
using System.ComponentModel.Design;
using System.Reflection.Metadata;

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

        public Employee()
        {
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
        public void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                    this.grades.Add(100);
                    break;
                case 'B':
                    this.grades.Add(80);
                    break;
                case 'C':
                    this.grades.Add(60);
                    break;
                case 'D':
                    this.grades.Add(40);
                    break;
                case 'E':
                    this.grades.Add(20);
                    break;
                default: Console.WriteLine("Wrong letter");
                    break;
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
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                if (grade >= 0)
                {
                    statistics.Max = Math.Max(statistics.Max, grade);
                    statistics.Min = Math.Min(statistics.Min, grade);
                    statistics.Average += grade;
                }
            }
            statistics.Average /= this.grades.Count;
            
            switch(statistics.Average)
            {
                case var a when a >= 80:
                    statistics.AverageLetter = 'A';
                    break;
                case var a when a >= 60:
                    statistics.AverageLetter = 'B';
                    break;
                case var a when a >= 40:
                    statistics.AverageLetter = 'C';
                    break;
                case var a when a >= 20:
                    statistics.AverageLetter = 'D';
                    break;
                default:
                    statistics.AverageLetter = 'E';
                     break;



            }
            return statistics;
        }

  
      
    }     
}

    


