using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentAdmissionManagement.Models;

namespace StudentAdmissionManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentAdmissionController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<StudentAdmissionDetailsModel> Get()
        {
            StudentAdmissionDetailsModel obj1 = new StudentAdmissionDetailsModel();
            StudentAdmissionDetailsModel obj2 = new StudentAdmissionDetailsModel();

            obj1.StudentId = 101;
            obj1.StudentName = "Adam";
            obj1.StudentClass = "XII";
            obj1.DateofJoining = System.DateTime.Today;

            obj2.StudentId = 102;
            obj2.StudentName = "Amy";
            obj2.StudentClass = "X";
            obj2.DateofJoining = System.DateTime.Today;

            List<StudentAdmissionDetailsModel> lsobj = new List<StudentAdmissionDetailsModel>
            {
                obj1,
                obj2
            };

            return lsobj;


        }
    }
}
