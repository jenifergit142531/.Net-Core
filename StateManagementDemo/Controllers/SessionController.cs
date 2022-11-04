using Microsoft.AspNetCore.Mvc;

namespace StateManagementDemo.Controllers
{
    public class SessionController : Controller
    {
        const string sName = "_Name";
        const string scity = "_city";
        public IActionResult Index()
        {
            HttpContext.Session.SetString(sName, "Jenifer");
            HttpContext.Session.SetString(scity, "Chennai");
            return View();
        }
        public IActionResult Show()
        {
            ViewBag.Name = HttpContext.Session.GetString(sName);
            ViewBag.City = HttpContext.Session.GetString(scity);
            TempData["sessionId"] = HttpContext.Session.Id;
            ViewData["Message"] = "Session management in asp.net core web app";

            return View();
        }
    }
}
