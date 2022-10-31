using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using helloapp.Models;

namespace helloapp.Controllers;

public class WelcomeController : Controller
{
  
    public string Hello()
    {
        return "Welcome to my web page";
    }
    
    [ActionName("grt")]
    public string Greetings()
    {
        return "Good morning user";
    }
}

