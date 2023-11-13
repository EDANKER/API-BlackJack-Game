using Microsoft.AspNetCore.Mvc;

namespace ApiBlackJak.Controllers;

[ApiController]
[Route("/api/[controller]")]
public class PlayerGetDataController : ControllerBase
{
    [HttpGet("/DataPlayer")]
    public IActionResult DataPlayer()
    {
        return Ok();
    }

    [HttpGet("/ChatMessagePlayer")]
    public IActionResult ChatMessagePlayer()
    {
        return Ok();
    }

    [HttpGet("?Bank")]
    public IActionResult Bank()
    {
        return Ok();
    }

    [HttpGet("/DataDiller")]
    public IActionResult DataDiller()
    {
        return Ok();
    }
}