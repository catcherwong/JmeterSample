namespace WebApi.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("[controller]")]
    public class IfController : ControllerBase
    {
        [HttpGet("a")]
        public IActionResult A()
        {
            return Ok(new
            {
                code = 0,
                msg = "ok",
                data = (new System.Random().Next(0, 99999) % 2).ToString()
            });
        }

        [HttpGet("b")]
        public IActionResult B([FromQuery] string data)
        {
            return Ok(new { code = 0, msg = "ok", data = data ?? "empty" });
        }

        [HttpGet("c")]
        public IActionResult C()
        {
            return Ok(new { code = 0, msg = "ok", data = "c" });
        }
    }
}
