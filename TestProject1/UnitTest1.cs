using aspclass6.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [DataTestMethod]
        [DataRow (1,"Jenifer")] //pass
        [DataRow(1,"Mira")]     //fail
        [DataRow(2,"Thammira")]     //fail
        [DataRow (3,"not found")] //pass
        [DataRow (4,"found")]     //fail 
        [DataRow (2,"thamira")]   //fail
        public void TestMethod1(int Id,string name)
        {
            //Arrange
            StudentController sc = new StudentController();

            //Act
            string result = sc.GetStudentName(Id);

            //Assert

            Assert.AreEqual(result,name);


        }
    }
}