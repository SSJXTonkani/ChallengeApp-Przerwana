
using Challenge_App;

namespace ChallengeApp.Tests
{
    public class Tests
    {

        [Test]
        public void WhenEmployeeCollectScores_ShouldCorrectResult()
        {
            //Arrange

            var employee = new Employee("Kamila", "Kowalska", 19);
            employee.AddScore(25);
            employee.AddScore(25);
            //Act
            var result = employee.Result;
        //Assert 
            Assert.That(result, Is.EqualTo(50));
        }
    }
    public class Test
    {

        [Test]
        public void WhenEmployeeCollectPoints_ShouldCorrectResult()
        {
            //Arrange

            var employee = new Employee("Ania", "Kowalska", 20);
            employee.AddScore(-10);
            employee.AddScore(25);
            employee.AddScore(-5);
            employee.AddScore(-10);
            employee.AddScore(25);
            employee.AddScore(25);
            //Act
            var result = employee.Result;
            //Assert 
            Assert.That(result, Is.EqualTo(50));
        }
    }
}