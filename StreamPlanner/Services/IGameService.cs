using StreamPlanner.Shared;

namespace StreamPlanner.Services
{
    public interface IGameService
    {
        IEnumerable<Game> GetAllGames();
        IEnumerable<Game> GetGamesByStatus(GameStatus? status);
        Game MarkAsPlaying(int index);
        Game MarkAsCompleted(int index);
        Game Vote(int index);
    }
}
