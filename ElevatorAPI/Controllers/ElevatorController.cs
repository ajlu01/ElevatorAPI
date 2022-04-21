using Microsoft.AspNetCore.Mvc;

namespace ElevatorAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ElevatorController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<ElevatorController> _logger;

        public ElevatorController(ILogger<ElevatorController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<Elevator> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new Elevator
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}