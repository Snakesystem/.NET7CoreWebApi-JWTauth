using Microsoft.AspNetCore.Mvc;

namespace AuthNet7WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };


        [HttpGet]
        [Route("get")]
        public IActionResult Get()
        {
            return Ok(Summaries);
        }
    }
}