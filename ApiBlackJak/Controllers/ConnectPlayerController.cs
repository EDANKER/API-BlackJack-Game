using ApiBlackJak.Model;
using Microsoft.AspNetCore.Mvc;

namespace ApiBlackJak.Controllers;

[ApiController]
[Route("/api/[controller]")]
public class ConnectPlayerController : ControllerBase
{ 
    private readonly List<Spectator> _spectators = new();
    public readonly List<GamePlayers> _gamePlayers = new();

    [HttpPost("/addPlayerTable")]
    public IActionResult AddPlayer(string id, string name, Hands hands, int account)
    {
        var gamePlayer = new GamePlayers(id, name, hands, account);
        _gamePlayers.Add(gamePlayer);
        return Ok();
    }

    [HttpPost("/spectatorPlayer")]
    public IActionResult SpectatorPlayer(string id, string name)
    {
        var spectator = new Spectator(id, name);
        _spectators.Add(spectator);
        return Ok();
    }

    [HttpPost("/exitPlayer")]
    public IActionResult ExitPlayer(string id, string name, Hands hands, int account)
    {
        var gamePlayer = new GamePlayers(id, name, hands, account);
        _gamePlayers.Remove(gamePlayer);
        return Ok();
    }

    [HttpPost("/exitSpectatorPlayer")]
    public IActionResult ExitSpectatorPlayer(string id, string name)
    {
        var spectator = new Spectator(id, name);
        _spectators.Remove(spectator);
        return Ok();
    }
}