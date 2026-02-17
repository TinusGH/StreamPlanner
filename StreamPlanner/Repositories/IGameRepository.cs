using StreamPlanner.Models;

namespace StreamPlanner.Repositories
{
    public interface IGameRepository
    {
        IEnumerable<Game> GetAll();
        Game GetByIndex(int index);
        void Update(Game game);
    }
}
