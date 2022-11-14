
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;



using WebApiClass1.Model;

namespace WebApiClass1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
        IList<Heroes> hero = new List<Heroes>()
        {
            new Heroes()
            {
                CartoonId=100,
                HeroName="Iron Man",
                CartoonName="Avengers",
                Viewers=1200
            },
             new Heroes()
            {
                CartoonId=200,
                HeroName="Shinchan",
                CartoonName="Shinchan",
                Viewers=5000
            },
              new Heroes()
            {
                CartoonId=300,
                HeroName="Bheem",
                CartoonName="Chota Bheem",
                Viewers=700
            },
               new Heroes()
            {
                CartoonId=400,
                HeroName="Tom",
                CartoonName="Tom&Jerry",
                Viewers=7000
            },
        };
        public IList<Heroes> GetHeroes()
        {
            return hero;
        }

        [Route("/getbyhero/{id}")]
        public Heroes GetHeroesbyid(int id)
        {
            Heroes h = hero.FirstOrDefault(e => e.CartoonId == id);
            if (hero == null)
            {
                throw new NotImplementedException();
            }
            return h;

        }
    }
   
}
