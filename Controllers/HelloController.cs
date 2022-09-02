using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace firstWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloController : ControllerBase
    {
        [HttpGet]
        public  IActionResult Get()
        {
            return Ok("Hello Myself Uzair Its My first Web Api");
        }
        [HttpPost]
        public IActionResult Post(JsonOptions payload)
        {
            return Ok(payload);
        }
    }
}
