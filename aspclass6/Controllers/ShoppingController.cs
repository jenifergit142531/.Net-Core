using aspclass6.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections;

namespace aspclass6.Controllers
{
    public class ShoppingController : Controller
    {
        public IActionResult Index()
        {
            ViewData["data"] = "purchasing wallet here and carries only cards / money";
            ViewBag.ShopName = "Big Casket";
            return View();
        }

        public IActionResult Purchase()
        {
            List<Shopping> ls = new List<Shopping>()
            {
               new Shopping()
            {
                Regno=1001,
                ShopName ="Big casket",
                Location="Pune",
                CustomerRating=5
            },
                new Shopping()
            {
                Regno=1002,
                ShopName ="Flip Go",
                Location="Gurgoan",
                CustomerRating=4
            },
                 new Shopping()
            {
                Regno=1003,
                ShopName ="Amaze",
                Location="Chennai",
                CustomerRating=3
            },
        };
            //ViewBag.ShopDetails = ls;
            ViewData["ShopDetails"] = ls;
             
            return View();
        }
    }
}
