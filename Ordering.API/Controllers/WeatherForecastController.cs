using Microsoft.AspNetCore.Mvc;
using Ordering.Application.WeatherForecasts.Queries.GetWeatherForecasts;

namespace Ordering.API.Controllers;

public class WeatherForecastController : ApiControllerBase
{
    [HttpGet]
    public async Task<IEnumerable<WeatherForecast>> Get()
    {
        return await this.Mediator.Send(new GetWeatherForecastsQuery());
    }
}