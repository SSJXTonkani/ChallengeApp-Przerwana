
using Challenge_App;


namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void GradeAsLetterIsEqualToMaxPoints()
        {

            var employee = new Employee("jacek", "wafel", 29);
            employee.AddGrade('A');
            employee.AddGrade(70);
            employee.AddGrade(66);
            employee.AddGrade(29);

            var statistics = employee.GetStatistics();

            Assert.AreEqual(100, statistics.Max);
            
        }
        [Test]
        public void GradeAsLetterIsEqualToMinPoints()
        {

            var employee = new Employee("jacek", "wafel", 29);
            employee.AddGrade('A');
            employee.AddGrade(70);
            employee.AddGrade(66);
            employee.AddGrade('E');

            var statistics = employee.GetStatistics();

            Assert.AreEqual(20, statistics.Min);

        }
        [Test]
        public void GradeAsLetterIsEqualToAveragePoints()
        {

            var employee = new Employee("jacek", "wafel", 29);
            employee.AddGrade('A');
            employee.AddGrade('A');
            employee.AddGrade('C');
            employee.AddGrade('E');

            var statistics = employee.GetStatistics();

            Assert.AreEqual(70, statistics.Average);

        }
    }
}


