using Microsoft.AspNetCore.Mvc;
using StateManagementDemo.Models;

namespace StateManagementDemo.Controllers
{
    public class ViewController : Controller
    {
        public IActionResult Index()
        {
            Employee emp = new Employee()
            {
                Empid=101,
                EmpName="Mukesh",
                Role ="SE Tester"

            };
            //simple data
            // ViewData["Message"] = "This is from a view data";

            //complex data - requires type casting while retriving on the view
            // ViewData["empkey"] = emp;


            ViewBag.Message = "This is from viewbag";
            ViewBag.EmpKey = emp;

            return View();
        }
    }
}
