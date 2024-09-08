using Microsoft.AspNetCore.Mvc;

namespace RazorPagesTest.Controller
{
    [Route("api/search")]
    [ApiController]
    public class TestController : ControllerBase
    {
        // GET: api/MyApi
        [HttpGet]
        public IActionResult Get([FromQuery] string q)
        {
            return Ok(new { message = "Searching for" + q });
        }
    }
}
