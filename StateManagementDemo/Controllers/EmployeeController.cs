using Microsoft.AspNetCore.Mvc;
using StateManagementDemo.Models;

namespace StateManagementDemo.Controllers
{
    public class EmployeeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            Employee emp = new Employee
            {
                Empid = 101
            };
            return View(emp);
        }

        [HttpPost]
        public IActionResult Index(Employee emp)
        {
            return View();
        }
    }
}
