namespace WebApi.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("[controller]")]
    public class RunController : ControllerBase
    {        
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new 
            {
                code = 0,
                msg = "ok"
            });
        }

        [HttpPost]
        public IActionResult Login(
            [FromQuery] string sign
            , [FromQuery] string appkey
            , [FromBody] LoginDto dto)
        {
            if (string.IsNullOrWhiteSpace(sign) || string.IsNullOrWhiteSpace(appkey) || dto == null)
            {
                return BadRequest(new { code = 1, msg = "参数不能为空" });
            }

            if (dto.UserName.Contains("catcherwong") || dto.Password.Length == 32)
            {
                return Ok(new { code = 0, msg = "ok", data = new { token = System.Guid.NewGuid().ToString("N") } });
            }
            else
            { 
                return BadRequest(new { code = 1, msg = "非法用户" });
            }
        }
    }

    public class LoginDto
    { 
        public string UserName { get; set; }

        public string Password { get; set; }
    }
}
