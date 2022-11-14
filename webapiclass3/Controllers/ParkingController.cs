using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using webapiclass3.Model;

namespace webapiclass3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    // [SecretKey]
    public class ParkingController : ControllerBase
    {
        private readonly IParking _parking;

        public ParkingController (IParking parking)
        {
            _parking = parking;
        }
       /* [Route ("info/details")]
        public IActionResult Index()
        {

            /* without DI
            var pi = new ParkingInformation();
            var result = pi.GetDetails();
            return Ok(result); 


            //WITH DI

            var result = _parking.GetDetails();
            return Ok(result);

           

        }
        [Route("info/show")]
        public IActionResult Display()
        {
            var result2 = _parking.Show();
            return Ok(result2);
        }
    */

        //method for odata implementation

        [HttpGet (nameof(GetCarInfo))]
        [EnableQuery]
        public IActionResult GetCarInfo() => Ok(_parking.GetCarParkings());

    }
}
