namespace WebApi.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using WebApi.Dtos;

    [ApiController]
    [Route("[controller]")]
    public class MultiTokenController : ControllerBase
    {
        [HttpPost("login")]
        public IActionResult Login([FromBody]LoginDto dto)
        {
            if (dto == null || string.IsNullOrWhiteSpace(dto.UserName) || string.IsNullOrWhiteSpace(dto.Password))
            {
                return BadRequest(new { code = 1, msg = "参数不能为空" });
            }

            return Ok(new
            {
                code = 0,
                msg = "ok",
                data = $"{dto.UserName}-token"
            });
        }

        [HttpGet("do")]
        public IActionResult Do([FromQuery] string account, [FromHeader(Name = "token")] string token)
        {
            if (string.IsNullOrWhiteSpace(account) || string.IsNullOrWhiteSpace(token))
            {
                return BadRequest(new { code = 1, msg = "参数不能为空" });
            }

            if (!token.StartsWith(account))
            {
                return BadRequest(new { code = 1, msg = "参数错误" });
            }

            return Ok(new { code = 0, msg = "ok", data = token });
        }
    }
}
