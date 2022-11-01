using BookMyShowApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookMyShowApp.Controllers
{
    public class MovieController : Controller
    {
        [Route("Moviehome")]
        public IActionResult Index()
        {
            Movie[] mv = new Movie[]
            {
                new Movie
                {
                    Mid=101,
                    MovieName="Tenet",
                    Director="Nolan",
                    Genre="sci-fic"
                },
                 new Movie
                {
                    Mid=102,
                    MovieName="Avatar",
                    Director="Cameron",
                    Genre="sci-fic"
                },
                  new Movie
                {
                    Mid=103,
                    MovieName="Gone Girl",
                    Director="Steven",
                    Genre="Thriller"
                },
                   new Movie
                {
                    Mid=104,
                    MovieName="Dominion",
                    Director="Steven",
                    Genre="Fictional"
                },
            };
            return View(mv);
        }
    }
}
