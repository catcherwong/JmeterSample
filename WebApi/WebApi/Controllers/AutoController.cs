namespace WebApi.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("[controller]")]
    public class AutoController : ControllerBase
    {
        [HttpPost("step1")]
        public IActionResult Step1([FromBody] AutoDto dto)
        {
            if (dto == null || string.IsNullOrWhiteSpace(dto.Str))
            {
                return BadRequest(new { code = 1, msg = "参数错误" });
            }

            return Ok(new
            {
                code = 0,
                msg = "ok",
                data = "step1"
            }) ;
        }

        [HttpPost("step2")]
        public IActionResult Step2([FromBody] AutoDto dto)
        {
            if (dto == null || string.IsNullOrWhiteSpace(dto.Str) || string.IsNullOrWhiteSpace(dto.R))
                return BadRequest(new { code = 1, msg = "参数错误" });

            // 模拟 必须先从 Step1 接口拿到 data 再访问
            if (!dto.R.Equals("step1"))
                return BadRequest(new { code = 1, msg = "请先访问Step1，再访问此接口" });

            return Ok(new
            {
                code = 0,
                msg = "ok",
                data = "step1+step2"
            });
        }

        [HttpPost("step3")]
        public IActionResult Step3([FromBody] AutoDto dto)
        {
            if (dto == null || string.IsNullOrWhiteSpace(dto.Str) || string.IsNullOrWhiteSpace(dto.R))
                return BadRequest(new { code = 1, msg = "参数错误" });

            // 模拟 必须先从 Step2 接口拿到 data 再访问
            if (!dto.R.Equals("step1+step2"))
                return BadRequest(new { code = 1, msg = "请先访问Step2，再访问此接口" });

            return Ok(new
            {
                code = 0,
                msg = "ok",
                data = "step1+step2+step3"
            });
        }
    }

    public class AutoDto
    { 
        public string Str { get; set; }

        public string R { get; set; }
    }
}
