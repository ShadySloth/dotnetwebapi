using Microsoft.AspNetCore.Mvc;

namespace dotnetwebapi.Controllers;

[ApiController]

public class HelloController : ControllerBase
{
    
    [HttpGet]
    [Route("/{id}")]
    public object GetId([FromRoute] int id)
    {
        return "Hello " + id + " :)";
    }

    [HttpGet]
    [Route("/readQuery")]
    public object GetQuery([FromQuery] string someValue)
    {
        return "Some value: " + someValue;
    }

    [HttpGet]
    [Route("/setHeaderWithParam")]
    public object SetHeaderWithParam([FromHeader]string someHeader)
    {
        return "Look at the header!";
    }

    [HttpGet]
    [Route("/setHeaderManually")]
    public object SetHeader()
    {
        HttpContext.Response.Headers["RandomHeader"] = "RandomValue";
        return "Header have been set!";
    }

    [HttpGet]
    [Route("/readThisHeader")]
    public object ReadHeader([FromHeader] string headerName)
    {
        return HttpContext.Request.Headers[headerName][0];
    }

    [HttpGet]
    [Route("/json")]
    public object GetJson()
    {
        return new
        {
            Key = "value"
        };
    }

    [HttpGet]
    [Route("/aStatusCode")]
    public object StatusCode()
    {
        HttpContext.Response.StatusCode = 420;
        
        return null;
    }

    [HttpPost]
    [Route("/postDto")]
    public object GetStringFromBody([FromBody] MyDto dto)
    {
        return dto;
    }

    [HttpGet]
    [Route("/getCustomDto")]
    public object GetCustomDto([FromQuery] MyQueryParamDto dto)
    {
        return dto;
    }
}