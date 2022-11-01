using BookMyShowApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookMyShowApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmwebController : ControllerBase
    {
        Movie[] movie = new Movie[]
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
        public IEnumerable<Movie> GetMovies()
        {
            return movie;
        }

    }
}
