using StreamPlanner.Models;
using StreamPlanner.Repositories;
using StreamPlanner.Shared;

namespace StreamPlanner.Services
{
    public class GameService : IGameService
    {
        private readonly IGameRepository _repository;

        //Constructor
        //public GameService(List<Game> games)
        //{
        //    _games = games ?? throw new ArgumentNullException(nameof(games));
        //}

        public GameService(IGameRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public IEnumerable<Game> GetAllGames()
        {
            //return _games;
            return _repository.GetAll();
        }

        public IEnumerable<Game> GetGamesByStatus(GameStatus? status)
        {
            //if (status == null)
            //    return _games;
            //return _games.Where(g => g.GameStatus == status);
            var games = _repository.GetAll();

            if (status == null)
                return games;

            return games.Where(g => g.GameStatus == status);
        }

        public Game MarkAsPlaying(int index)
        {
            //if (index < 0 || index >= _games.Count)
            //{
            //    throw new ArgumentOutOfRangeException(nameof(index), "Invalid game index.");
            //}
            //_games[index].GameStatus = GameStatus.Playing;
            //return _games[index];

            var game = _repository.GetByIndex(index);

            game.GameStatus = GameStatus.Playing;

            _repository.Update(game);

            return game;
        }

        public Game MarkAsCompleted(int index)
        {
            //if (index < 0 || index >= _games.Count)
            //{
            //    throw new ArgumentOutOfRangeException(nameof(index), "Invalid game index.");
            //}
            //_games[index].GameStatus = GameStatus.Completed;
            //return _games[index];

            var game = _repository.GetByIndex(index);

            game.GameStatus = GameStatus.Completed;

            _repository.Update(game);

            return game;
        }

        public Game Vote(int index)
        {
            //if (index < 0 || index >= _games.Count)
            //{
            //    throw new ArgumentOutOfRangeException(nameof(index), "Invalid game index.");
            //}
            //_games[index].Votes++;
            //return _games[index];

            var game = _repository.GetByIndex(index);

            game.Votes++;

            _repository.Update(game);

            return game;
        }
    }
}
