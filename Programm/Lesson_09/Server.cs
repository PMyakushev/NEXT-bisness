using Microsoft.AspNetCore.Mvc;

namespace Server.Controllers;

[ApiController]
[Route("api/v2/[controller]")]

public class WeatherForecastController : ControllerBase
{
    [HttpGet]
    [Route("getweather")]

    public string[] Get()
    {
        string[] su = { "Облачно", "Ясно", "Нормально"};
        string[] list = new string[3];
        list[0] = $"Погода +{Random.Shared.Next(0, 30)} градусов, {su[Random.Shared.Next(su.Length)]} ";
        list[1] = $"Погода +{Random.Shared.Next(0, 30)} градусов, {su[Random.Shared.Next(su.Length)]} ";
        list[2] = $"Погода +{Random.Shared.Next(0, 30)} градусов, {su[Random.Shared.Next(su.Length)]} ";
        return list;
    }

    [HttpGet]
    [Route("nameyeap")]

    public string[] GetYep()
    {
        string[] su = { "Облачно", "Ясно", "Нормально"};
        string[] list = new string[3];
        list[0] = $"Погода +{Random.Shared.Next(0, 30)} градусов, {su[Random.Shared.Next(su.Length)]} ";
        list[1] = $"Погода +{Random.Shared.Next(0, 30)} градусов, {su[Random.Shared.Next(su.Length)]} ";
        list[2] = $"Погода +{Random.Shared.Next(0, 30)} градусов, {su[Random.Shared.Next(su.Length)]} ";
        return list;
    }    
}