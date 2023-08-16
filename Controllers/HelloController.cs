using Microsoft.AspNetCore.Mvc;

namespace dotnetwebapi.Controllers;

[ApiController]

public class HelloController : ControllerBase
{
    
    [HttpGet]
    [Route("/{id}")]
    public String get([FromRoute] int id, [FromQuery]string someValue, [FromHeader]string someValue)
    {
        return "Hello " + id + " :) Some value:" + someValue + "Header: ";
    }
}