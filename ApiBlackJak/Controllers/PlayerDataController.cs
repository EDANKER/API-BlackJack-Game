using ApiBlackJak.Model;
using Microsoft.AspNetCore.Mvc;

namespace ApiBlackJak.Controllers;

[ApiController]
[Route("/api/[controller]")]
public class PlayerDataController : ControllerBase
{
    private List<Bank> _bank = new();
    private static ConnectPlayerController _connectPlayerController = new();
    
    [HttpPut("/addMoney")]
    public IActionResult AddMoney(int money)
    {
        return Ok();
    }

    [HttpPut("/bank")]
    public IActionResult Bank(string id, int account)
    {
        var bank = new Bank(id, account);
        _bank.Add(bank);
        return Ok();
    }
}