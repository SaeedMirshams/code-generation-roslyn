using IASC.Sample.Application.DTOs;
using IASC.Sample.Domain.Enums;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IASC.Sample.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet("Echo")]
        public object Echo(string text)
        {
            return new { text = text };
        }
    }
}
