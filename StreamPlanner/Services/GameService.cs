using StreamPlanner.Shared;

namespace StreamPlanner.Services
{
    public class GameService : IGameService
    {
        private readonly List<Game> _games; //Encapsulation of the game list

        public GameService(List<Game> games)
        {
            _games = games ?? throw new ArgumentNullException(nameof(games));
        }

        public IEnumerable<Game> GetAllGames()
        {
            return _games;
        }

        public IEnumerable<Game> GetGamesByStatus(GameStatus? status)
        {
            if (status == null)
                return _games;
            return _games.Where(g => g.GameStatus == status);
        }

        public Game MarkAsPlaying(int index)
        {
            if (index < 0 || index >= _games.Count)
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Invalid game index.");
            }
            _games[index].GameStatus = GameStatus.Playing;
            return _games[index];
        }

        public Game MarkAsCompleted(int index)
        {
            if (index < 0 || index >= _games.Count)
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Invalid game index.");
            }
            _games[index].GameStatus = GameStatus.Completed;
            return _games[index];
        }

        public Game Vote(int index)
        {
            if (index < 0 || index >= _games.Count)
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Invalid game index.");
            }
            _games[index].Votes++;
            return _games[index];
        }
    }
}
