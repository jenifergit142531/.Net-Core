using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApiClass1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LanguageController : ControllerBase
    {
        static List<string> languages = new List<string>()
        {
           "C#","GO","JAVA","SQL"
        };

        [HttpGet]
        [Route("Getall")]
        
        public IEnumerable<string> GetAll()
        {
            return languages;
        }

        [HttpGet]
        [Route("/getbyid/{id}")]
        public string Get(int id)
        {
            return languages[id];
        }
        [HttpDelete]
        [Route("/delete/{id}")]
        public void Delete(int id)
        {
            languages.RemoveAt(id);
        }

    }
}
