using Business.Abstract;
using Business.Concrete;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

namespace Api.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;
    IDbOrderService _dbOrderService;

    public WeatherForecastController(ILogger<WeatherForecastController> logger,IDbOrderService dbOrderService)
    {
        _logger = logger;
        _dbOrderService = dbOrderService;
    }
    
    

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
        var result = _dbOrderService.GetAll().Data.Take(1000);

        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }

    



}
