using StreamPlanner;
using StreamPlanner.Shared;

var games = new List<Game>()
{
    new Game() { Name = "Final Fantasy VII - Remake Intergrade", GameStatus = GameStatus.Playing, StreamType = StreamType.letsPlay },
    new Game() { Name = "Final Fantasy VII - Remake Intergrade: Episode INTERmission", GameStatus = GameStatus.NotStarted, StreamType = StreamType.letsPlay },
    new Game() { Name = "Final Fantasy VII - Rebirth", GameStatus = GameStatus.NotStarted, StreamType = StreamType.letsPlay },
    new Game() { Name = "Clair Obscur: Expedition 33", GameStatus = GameStatus.Playing, StreamType = StreamType.letsPlay },
    new Game() { Name = "Palworld", GameStatus = GameStatus.Playing, StreamType = StreamType.chillStream },
};

Console.WriteLine("Welcome to the Stream Planner! \nThese are the current games:\n");

foreach (var game in games)
{
    Console.WriteLine($"{game.Name} | {game.GameStatus} | {game.StreamType} | {game.Votes}");
}

bool running = true;

while (running)
{
    Console.Clear();

    Console.WriteLine("\nCurrent Games:");
    for (int i = 0; i < games.Count; i++)
    {
        var game = games[i];
        Console.WriteLine($"{i + 1}. {game.Name} | {game.GameStatus} | {game.StreamType} | {game.Votes}");
    }

    Console.WriteLine("\nMenu");
    Console.WriteLine("1. Mark a game as playing");
    Console.WriteLine("2. Mark a game as Completed");
    Console.WriteLine("3. Vote for a game");
    Console.WriteLine("4. Exit");

    Console.WriteLine("Choose an option: ");
    var choice = Console.ReadLine();
    string? input;

    switch (choice)
    {
        case "1":
            #region Practice Phase 1 & 2
            //Practice Phase 1
            //Console.WriteLine("Enter the name of the game: ");
            //var gameName = Console.ReadLine();

            //foreach(var game in games)
            //{
            //    if (game.Name.Equals(gameName, StringComparison.OrdinalIgnoreCase))
            //    {
            //        game.GameStatus = GameStatus.Playing;
            //        Console.WriteLine($"{game.Name} is now marked as playing.");
            //    }
            //}

            ////Practice Phase 2
            //Console.WriteLine("Enter the number of the game: ");
            //input = Console.ReadLine();

            //if (int.TryParse(input, out int gameNumber))
            //{
            //    if (gameNumber >= 1 && gameNumber <= games.Count)
            //    {
            //        var selectedGame = games[gameNumber - 1];
            //        selectedGame.GameStatus = GameStatus.Playing;
            //        Console.WriteLine($"{selectedGame.Name} is now marked as Playing.");
            //        Pause();
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid number. Please try again.");
            //        Pause();
            //    }
            //}
            #endregion
            MarkGameAsPlaying(games);
            break;

        case "2":
            #region Practice Phase 1 & 2
            //Practice Phase 1
            //Console.Write("Enter the name of the game: ");
            //gameName = Console.ReadLine();

            //foreach (var game in games)
            //{
            //    if (game.Name.Equals(gameName, StringComparison.OrdinalIgnoreCase))
            //    {
            //        game.GameStatus = GameStatus.Completed;
            //        Console.WriteLine($"{game.Name} is now marked as completed.");
            //    }
            //}

            ////Practice Phase 2
            //Console.WriteLine("Enter the number of the game: ");
            //input = Console.ReadLine();
            //if (int.TryParse(input, out gameNumber))
            //{
            //    if (gameNumber >= 1 && gameNumber <= games.Count)
            //    {
            //        var selectedGame = games[gameNumber - 1];

            //        selectedGame.GameStatus = GameStatus.Completed;
            //        Console.WriteLine($"{selectedGame.Name} is now marked as Completed.");
            //        Pause();
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid number. Please try again.");
            //        Pause();
            //    }
            //}
            #endregion
            MarkGameAsCompleted(games);
            break;

        case "3":
            #region Practice Phase 1 & 2
            ////Practice Phase 2
            //Console.WriteLine("Enter the number of the game you want to vote for: ");
            //input = Console.ReadLine();

            //if (int.TryParse(input, out gameNumber))
            //{
            //    if (gameNumber >= 1 && gameNumber <= games.Count)
            //    {
            //        var selectedGame = games[gameNumber - 1];
            //        selectedGame.Votes++;
            //        Console.WriteLine($"You voted for {selectedGame.Name}. Total votes: {selectedGame.Votes}");
            //        Pause();
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid Number");
            //        Pause();
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Please enter a valid number.");
            //    Pause();
            //}
            #endregion
            VoteForGame(games);
            break;

        case "4":
            running = false;
            break;

        default:
            Console.WriteLine("Invalid Option. Please try again");
            Pause();
            break;
    }
}

Console.WriteLine("\nCurrent Games:");

foreach (var game in games)
{
    Console.WriteLine($"{game.Name} | {game.GameStatus} | {game.StreamType} | {game.Votes}");
}

Console.WriteLine("\nPress any key to exit...");
Console.ReadKey();


void Pause()
{
    Console.WriteLine("\nPress any key to continue...");
    Console.ReadKey();
}

void MarkGameAsPlaying(List<Game> games)
{
    Console.WriteLine("Enter the number of the game: ");
    var input = Console.ReadLine();

    if (int.TryParse(input, out int gameNumber))
    {
        if (gameNumber >= 1 && gameNumber <= games.Count)
        {
            var selectedGame = games[gameNumber - 1];
            selectedGame.GameStatus = GameStatus.Playing;
            Console.WriteLine($"{selectedGame.Name} is now marked as Playing.");
            Pause();
        }
        else
        {
            Console.WriteLine("Invalid number. Please try again.");
            Pause();
        }
    }
    else
    {
        Console.WriteLine("Please enter a valid number.");
        Pause();
    }
}

void MarkGameAsCompleted(List<Game> games)
{
    Console.WriteLine("Enter the number of the game: ");
    var input = Console.ReadLine();
    if (int.TryParse(input, out int gameNumber))
    {
        if (gameNumber >= 1 && gameNumber <= games.Count)
        {
            var selectedGame = games[gameNumber - 1];
            selectedGame.GameStatus = GameStatus.Completed;
            Console.WriteLine($"{selectedGame.Name} is now marked as Completed.");
            Pause();
        }
        else
        {
            Console.WriteLine("Invalid number. Please try again.");
            Pause();
        }
    }
    else
    {
        Console.WriteLine("Please enter a valid number.");
        Pause();
    }
}

void VoteForGame(List<Game> games)
{
    Console.WriteLine("Enter the number of the game you want to vote for: ");
    var input = Console.ReadLine();
    if (int.TryParse(input, out int gameNumber))
    {
        if (gameNumber >= 1 && gameNumber <= games.Count)
        {
            var selectedGame = games[gameNumber - 1];
            selectedGame.Votes++;
            Console.WriteLine($"You voted for {selectedGame.Name}. Total votes: {selectedGame.Votes}");
            Pause();
        }
        else
        {
            Console.WriteLine("Invalid Number");
            Pause();
        }
    }
    else
    {
        Console.WriteLine("Please enter a valid number.");
        Pause();
    }
}

