using aspclass6.Controllers;
using Xunit;

namespace XUnitTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1, "Jenifer")] //pass
        [InlineData(1, "Mira")]     //fail
        [InlineData(2, "Thammira")]     //fail
        [InlineData(3, "not found")] //pass
        [InlineData(4, "found")]     //fail 
        [InlineData(2, "thamira")]
        public void Test1(int Id,string name)
        {
            //Arrange
            StudentController sc = new StudentController();

            //Act
            string result = sc.GetStudentName(Id);

            //Assert

            Assert.Equal(result, name);
        }
    }
}