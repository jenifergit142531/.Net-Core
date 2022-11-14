using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webapiclass2.Model;

namespace webapiclass2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameController : ControllerBase
    {
        private readonly IPlayer _player;

        public GameController (IPlayer player)
        {
            _player = player;
        }

        public IActionResult Index()
        {
            var allplayers = _player.GetPlayers();
            return Ok(allplayers);

            
        }

       [Route("playerdetails")]
        public IActionResult Get()
        {
            var personaldetails = _player.GetPersonalDetails();
             return Ok(personaldetails);

        }


            /*public IActionResult Index()
            {
                var allplayers = new AllPlayer();
                var result = allplayers.GetPlayers();
                return Ok(result);


            }

            [Route("playerdetails")]
            public IActionResult Get()
            {
                var ob2 = new PlayerPersonalDetails();
                var result2 = ob2.playerDetails();
                return Ok(result2);
            }*/

        }
}
