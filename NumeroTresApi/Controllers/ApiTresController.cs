using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NumeroTresApi.Models;

namespace NumeroTresApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiTresController : ControllerBase
    {
        Modeltres model = new Modeltres()
        {
            quote = 0
        };

        [HttpGet]
        public ActionResult<Modeltres> Get(string source, string destination, int packages)
        {
            model.quote = packages * 6;

            return model;
        }
    }
}
