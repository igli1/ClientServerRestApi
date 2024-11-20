using Microsoft.AspNetCore.Mvc;
using Server.Models;

namespace Server.Controllers;

[ApiController]
[Route("api/[controller]")]
public class LogController : ControllerBase
{
    public LogController()
    {
        
    }

    [HttpPost("Post")]
    public IActionResult Post([FromBody] LogDto model)
    {
        Console.WriteLine($"Received: {model.Log}");
        return Ok();
    }
}