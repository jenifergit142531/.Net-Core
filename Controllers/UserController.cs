using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using helloapp.Models;

namespace helloapp.Controllers;

public class UserController : Controller
{



    /*public RedirectResult Index()
    {
        return Redirect("https://www.wikipedia.org/");
    }*/

   /* public RedirectToActionResult Index()
    {
        return RedirectToAction("Hello","Welcome");
    }*/

    /* public RedirectToRouteResult Index()
    {
        return RedirectToRoute(new {Action = "Hello" , Controller="Welcome"});
    }*/

    /* public LocalRedirectResult Index()
    {
        return LocalRedirect("/Welcome/Hello");
    }*/

    /*public IActionResult Index()
    {
        return View ();
    }*/

    public  ViewResult Check(string username,int Attempt=1)
    {
        ViewData["uname"]=username;
        ViewData["Attempts"]=Attempt;

     return View();

    }

    public int add()
    {
        return 10+20;
    }

    public EmptyResult display()
    {
        return new EmptyResult();
    }

    public ContentResult disp()
    {
        return Content("hello");
    }
}

  