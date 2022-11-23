using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentAttendanceManagement.Models;

namespace StudentAttendanceManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentAttendanceController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<StudentAttendanceDetailsModel> Get()
        {
            StudentAttendanceDetailsModel obj1 = new StudentAttendanceDetailsModel();
            StudentAttendanceDetailsModel obj2 = new StudentAttendanceDetailsModel();
            obj1.StudentId = 101;
            obj1.StudentName = "Adam";
            obj1.AttendancePercentage = 94.24;
            
           

            obj2.StudentId = 102;
            obj2.StudentName = "Amy";
            obj2.AttendancePercentage =74.64;

            List<StudentAttendanceDetailsModel> lsobj = new List<StudentAttendanceDetailsModel>
            {
                obj1,
                obj2
            };

            return lsobj;


        }

    }
}
