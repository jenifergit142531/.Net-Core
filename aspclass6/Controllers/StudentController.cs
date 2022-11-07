using Microsoft.AspNetCore.Mvc;

namespace aspclass6.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string GetStudentName(int Id)
        {
            string name;
            if (Id == 1)
            {
                name = "Jenifer";
            }
            else if (Id == 2)
            {
                name = "Thamira";

            }
            else
            {
                name = "not found";
            }
            return name;
        }
    }
}
