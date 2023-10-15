using GameCrud.Models;

namespace GameCrud.Services.Game
{
    public interface IGameService
    {
        void CreateGame(GameModel request);
        GameModel GetGame(Guid id);
        void UpdateInsertGame(GameModel game);
        bool DeleteGame(Guid id);
    }
}
