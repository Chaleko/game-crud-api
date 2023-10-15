using GameCrud.Contracts.GameCrud;
using GameCrud.Models;
using GameCrud.Services.Game;
using Microsoft.AspNetCore.Mvc;

namespace GameCrud.Controllers;

[ApiController]
[Route("[controller]")]
public class  GameController : ControllerBase
{
    private readonly IGameService _gameService;

    public GameController(IGameService gameService)
    {
        _gameService = gameService;
    }

    [HttpPost]
    public IActionResult CreateGame(CreateGameReq req)
    {
        var game = new GameModel(
            Guid.NewGuid(),
            req.Name,
            req.Description,
            req.StartDateTime,
            req.EndDateTime,
            DateTime.Today,
            req.Category,
            req.Platform);

        _gameService.CreateGame(game);

        var response = new GameResp(
            game.Id,
            game.Name,
            game.Description,
            game.StartDateTime,
            game.EndDateTime,
            game.LastModifiedDateTime,
            game.Category, 
            game.Platform);

        return CreatedAtAction(
            actionName: nameof(GetGame),
            routeValues: new {id = game.Id},
            value: response);
    }

    [HttpGet("{id:guid}")]
    public IActionResult GetGame(Guid id)
    {
        GameModel game = _gameService.GetGame(id);

        if (game != null)
        {
            var response = new GameResp(
            game.Id,
            game.Name,
            game.Description,
            game.StartDateTime,
            game.EndDateTime,
            game.LastModifiedDateTime,
            game.Category,
            game.Platform);

            return Ok(response);
        }
        
        return BadRequest();
    }

    [HttpPut("{id:guid}")]
    public IActionResult UpdateInsertGame(Guid id, UpdateInsertGameReq req)
    {
        var game = new GameModel(
            id,
            req.Name,
            req.Description,
            req.StartDateTime,
            req.EndDateTime,
            DateTime.Today,
            req.Category,
            req.Platform);

        _gameService.UpdateInsertGame(game);
        return NoContent();
    }

    [HttpDelete("{id:guid}")]
    public IActionResult DeleteGame(Guid id)
    {
        if (_gameService.DeleteGame(id)) return Ok(id); 
            else return BadRequest();
    }
}