using Microsoft.AspNetCore.Mvc;

namespace StateManagementDemo.Controllers
{
    public class QueryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult QueryTesting()
        {
            string name = "Jenifer";
            if (!string.IsNullOrEmpty(HttpContext.Request.Query["name"]))
                name = HttpContext.Request.Query["name"];
            return Content("Welcome " + name);
        }
    }
}
