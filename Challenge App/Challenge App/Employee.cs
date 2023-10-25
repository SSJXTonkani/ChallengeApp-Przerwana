
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
        public int Age { get;private set; }
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
            this.grades.Add(grade);
        }

        public Statistics GetStatistics()
        {
            var statistiscs =  new Statistics();
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