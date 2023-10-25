
using Challenge_App;

namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void TestOfStatisticsAverage()
        {

            //Arrange
            var employee = new Employee("Helena", "ze sparty", 21);
            employee.AddGrade(13);
            employee.AddGrade(12);
            employee.AddGrade(13);
            employee.AddGrade(23);
            //Act
            var statistics = employee.GetStatistics();
            //Assert
            Assert.AreEqual((15.25) ,statistics.Average);
           
        }
        [Test]
        public void TestOfStatisticsMaxValue()
        {

            //Arrange
            var employee = new Employee("Helena", "ze sparty", 21);
            employee.AddGrade(13);
            employee.AddGrade(12);
            employee.AddGrade(13);
            employee.AddGrade(23);
            //Act
            var statistics = employee.GetStatistics();
            //Assert
            Assert.AreEqual(23, statistics.Max);

        }
        [Test]
        public void TestOfStatisticsMinValue()
        {

            //Arrange
            var employee = new Employee("Helena", "ze sparty",21);
            employee.AddGrade(13);
            employee.AddGrade(12);
            employee.AddGrade(13);
            employee.AddGrade(23);
            //Act
            var statistics = employee.GetStatistics();
            //Assert
            Assert.AreEqual(12, statistics.Min);

        }
        [Test]
        public void TwoStringsAreEqual()
        {

            //Arrange
            string name1 = ("Helena ze sparty");
            string name2 = ("Helena ze sparty");
            //Act

            //Assert
            Assert.AreEqual(name1, name2);

        }
        [Test]
        public void TwoNumbersFloatAreEqual()
        {

            //Arrange
            float number1 = 1f;
            float number2 = 1f;
            //Act

            //Assert
            Assert.AreEqual(number1, number2);

        }
        [Test]
        public void TwoNumbersIntAreEqual()
        {

            //Arrange
            int number1 = 1;
            int number2 = 1;
            //Act

            //Assert
            Assert.AreEqual(number1, number2);

        }
        [Test]
        public void TwoEmployeesShouldNotEqual()
        {

            //Arrange
            var Employee1 = GetEmployee("adam", "kowal", 22);
            var Employee2 = GetEmployee("Wera", "od aspargera", 19);
            //Act

            //Assert
            Assert.AreNotEqual(Employee1, Employee2);

        }

        private Employee GetEmployee(string name, string surname, int age)
        {
            return new Employee(name, surname, age);
        }
    }
}



