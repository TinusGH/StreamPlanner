using StreamPlanner.Models;
using StreamPlanner.Shared;

namespace StreamPlanner.Repositories
{
    public class InMemoryGameRepository : IGameRepository
    {

        private readonly List<Game> _games = new()
        {
            new Game
            {
                Name = "Final Fantasy VII - Remake Intergrade",
                GameStatus = GameStatus.Playing,
                StreamType = StreamType.letsPlay
            },
            new Game 
            { 
                Name = "Final Fantasy VII - Remake Intergrade: Episode INTERmission", 
                GameStatus = GameStatus.NotStarted, 
                StreamType = StreamType.letsPlay 
            },
            new Game
            {
                Name = "Final Fantasy VII - Rebirth",
                GameStatus = GameStatus.NotStarted,
                StreamType = StreamType.letsPlay
            },
            new Game
            {
                Name = "Clair Obscur: Expedition 33",
                GameStatus = GameStatus.Playing,
                StreamType = StreamType.letsPlay
            },
            new Game
            {
                Name = "Palworld",
                GameStatus = GameStatus.Playing,
                StreamType = StreamType.chillStream
            },
        };

        public IEnumerable<Game> GetAll()
        {
            return _games;
        }

        public Game GetByIndex(int index)
        {
            if (index < 0 || index >= _games.Count)
                throw new ArgumentOutOfRangeException(nameof(index));

            return _games[index];
        }

        public void Update(Game game)
        {
            // Nothing needed for in-memory
            // Later this saves to DB
        }
    }
}

