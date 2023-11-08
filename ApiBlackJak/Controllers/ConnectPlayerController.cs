using ApiBlackJak.Model;
using Microsoft.AspNetCore.Mvc;

namespace ApiBlackJak.Controllers;

[ApiController]
[Route("/api/[controller]")]
public class ConnectPlayerController : ControllerBase
{
    [HttpPost("/addPlayer")]
    public IActionResult AddPlayer(string id, string name, Hands hands)
    {
        return Ok();
    }

    [HttpPost("/exitPlayer")]
    public IActionResult ExitPlayer()
    {
        return Ok();
    }

    [HttpPost("/spectatorExitPlayer")]
    public IActionResult SpectatorExitPlayer()
    {
        return Ok();
    }
}