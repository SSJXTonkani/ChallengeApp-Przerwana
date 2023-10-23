
using Challenge_App;

namespace ChallengeApp.Tests
{
    public class TypeTests
    {
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



