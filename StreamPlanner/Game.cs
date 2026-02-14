using StreamPlanner.Shared;
namespace StreamPlanner
{
    internal class Game
    {
        public required string Name { get; set; }
        public GameStatus GameStatus { get; set; } = GameStatus.NotStarted;
        public StreamType StreamType { get; set; }
        public int Votes { get; set; } = 0;
    }
}
