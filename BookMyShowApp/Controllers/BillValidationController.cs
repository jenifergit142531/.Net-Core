using BookMyShowApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookMyShowApp.Controllers
{

    [Route("check")]
    public class BillValidationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public IActionResult Validation()
        {
            return View();
        }

       
        [HttpPost]
        public IActionResult Validation(Bills b)
        {
            if (ModelState.IsValid)
                return Content("You have booked the tickets successfully,Check your mail for the ticket details");
            else
                return Content("Try booking again..");
          
        }
    }
}
