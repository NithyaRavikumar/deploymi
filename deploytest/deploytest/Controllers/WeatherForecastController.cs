using DotNetCoreSqlDb.Models;
using Microsoft.AspNetCore.Mvc;

namespace deploytest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly MyDatabaseContext _context;

        public WeatherForecastController(ILogger<WeatherForecastController> logger,MyDatabaseContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public List<Todo> Get()
        {
            var tmp = _context.Todo.ToList();
            return tmp;
        }
    }
}