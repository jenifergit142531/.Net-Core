using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;

namespace webapiclass3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContentFormatController : ControllerBase
    {
       /* public IEnumerable<string> Get()
        {
            IList<string> formats = new List<string>();
            foreach (var item in OutputFormatter)
            {
                formats.Add(item.ToString());
            }

            return formats.AsEnumerable<string>();
        }*/
    }
}
