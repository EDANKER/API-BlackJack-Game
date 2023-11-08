using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace ApiBlackJak.Controllers;

[ApiController]
[Route("/api/[controller]")]
public class PlayerCmdController : ControllerBase
{
    private readonly ILogger<PlayerCmdController> _logger;

    public PlayerCmdController(ILogger<PlayerCmdController> logger)
    {
        _logger = logger;
    }
    
    [HttpPost("/more")]
    public IActionResult More()
    {
        return Ok();
    }

    [HttpPost("/hold")]
    public IActionResult Hold()
    {
        return Ok();
    }

    [HttpPost("/double")]
    public IActionResult Double()
    {
        return Ok();
    }
}