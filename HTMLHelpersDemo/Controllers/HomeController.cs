using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HTMLHelpersDemo.Models;

namespace HTMLHelpersDemo.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

  
   public IActionResult Details()
    {
        Employees emp=new Employees ()
        {
            EmpId=101,
            Name="jenifer",
            Gender="female",
           
        };
        ViewData["empdetails"] = emp;

        return View();
        
    }


    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
