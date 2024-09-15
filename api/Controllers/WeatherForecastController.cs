using CafeApi.Data;
using CafeApi.Models.Dto;
using Microsoft.AspNetCore.Mvc;

namespace CafeApi.Controllers
{
    [ApiController]
	[Route("[controller]")]
	public class WeatherForecastController : ControllerBase
	{
		private readonly IConfiguration configuration;

		private static readonly string[] Summaries =
		[
			"Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
		];

		private readonly ILogger<WeatherForecastController> logger;

		public WeatherForecastController(ILogger<WeatherForecastController> _logger, IConfiguration _configuration)
		{
			logger = _logger;
			configuration = _configuration;
		}

		[HttpGet(Name = "GetWeatherForecast")]
		public IEnumerable<WeatherForecast> Get()
		{
			using (var context = new CafeDbContext(configuration))
			{
				var books = context.Cafe.ToList();
				Console.WriteLine("Fetched from DB");
			}
				return Enumerable.Range(1, 5).Select(index => new WeatherForecast
			{
				Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
				TemperatureC = Random.Shared.Next(-20, 55),
				Summary = Summaries[Random.Shared.Next(Summaries.Length)]
			})
			.ToArray();
		}
	}
}
