using aspclass6.Controllers;
using NUnit.Framework;

namespace NUnitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(1, "Jenifer")] //pass
        [TestCase(1, "Mira")]     //fail
        [TestCase(2, "Thammira")]     //fail
        [TestCase(3, "not found")] //pass
        [TestCase(4, "found")]     //fail 
        [TestCase(2, "thamira")]   //fail
        public void Test1(int Id,string name)
        {
            //Arrange
            StudentController sc = new StudentController();

            //Act
            string result = sc.GetStudentName(Id);

            //Assert

            Assert.AreEqual(result, name);
        }
    }
}