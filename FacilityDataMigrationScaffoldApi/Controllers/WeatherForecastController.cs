using EntityModel;
using Microsoft.AspNetCore.Mvc;

namespace FacilityDataMigrationScaffoldApi.Controllers
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
        private readonly MyRequestContext _rc;

        public WeatherForecastController(ILogger<WeatherForecastController> logger,MyRequestContext rc)
        {
            _logger = logger;
            _rc = rc;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length) ] + " " + _rc.FacilityId.ToString()
            })
            .ToArray();
        }
    }
}
