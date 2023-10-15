using GameCrud.Models;

namespace GameCrud.Services.Game
{
    public class GameService : IGameService
    {
        private static readonly Dictionary<Guid, GameModel> _gameModels = new();
        public void CreateGame(GameModel game)
        {
            _gameModels.Add(game.Id, game);
        }

        public GameModel GetGame(Guid id)
        {
            if (_gameModels.TryGetValue(id, out var game))
            {
                return game;
            }

            return null;
        }

        public void UpdateInsertGame(GameModel game)
        {
            _gameModels[game.Id] = game;
        }

        public bool DeleteGame(Guid id)
        {
            if (_gameModels.TryGetValue(id, out var game))
            {
                _gameModels.Remove(id);
                return true;
            }
            
            return false;
        }
    }
}
