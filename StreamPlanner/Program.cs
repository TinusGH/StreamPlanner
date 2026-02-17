using StreamPlanner.Models;
using StreamPlanner.Repositories;
using StreamPlanner.Services;
using StreamPlanner.Shared;

#region practice phase 4
//var games = new List<Game>()
//{
//    new Game() { Name = "Final Fantasy VII - Remake Intergrade", GameStatus = GameStatus.Playing, StreamType = StreamType.letsPlay },
//    new Game() { Name = "Final Fantasy VII - Remake Intergrade: Episode INTERmission", GameStatus = GameStatus.NotStarted, StreamType = StreamType.letsPlay },
//    new Game() { Name = "Final Fantasy VII - Rebirth", GameStatus = GameStatus.NotStarted, StreamType = StreamType.letsPlay },
//    new Game() { Name = "Clair Obscur: Expedition 33", GameStatus = GameStatus.Playing, StreamType = StreamType.letsPlay },
//    new Game() { Name = "Palworld", GameStatus = GameStatus.Playing, StreamType = StreamType.chillStream },
//};

// Dependency Injection of the game list into the GameService

//IGameService gameService = new GameService(games);
#endregion
IGameRepository repository = new InMemoryGameRepository();
IGameService gameService = new GameService(repository);

Console.WriteLine("Welcome to the Stream Planner! \nThese are the current games:\n");

foreach (var game in gameService.GetAllGames())
{
    Console.WriteLine($"{game.Name} | {game.GameStatus} | {game.StreamType} | {game.Votes}");
}

bool running = true;

while (running)
{
    Console.Clear();

    Console.WriteLine("\nCurrent Games:");

    IEnumerable<Game>? filteredGames = null;
    while (filteredGames == null)
    {
        Console.WriteLine("Filter by: 1. All, 2. Playing, 3. Completed 4. NotStarted");
        var filterChoice = Console.ReadLine();

        #region Practice Phase 3
        //switch (filterChoice)
        //{
        //    case "1":
        //        filteredGames = games;
        //        break;
        //    case "2":
        //        filteredGames = games.Where(g => g.GameStatus == GameStatus.Playing);
        //        break;
        //    case "3":
        //        filteredGames = games.Where(g => g.GameStatus == GameStatus.Completed);
        //        break;
        //    case "4":
        //        filteredGames = games.Where(g => g.GameStatus == GameStatus.NotStarted);
        //        break;
        //    default:
        //        Console.WriteLine("Invalid filter choice. Please try again.");
        //        break;
        //}
        #endregion

        switch (filterChoice)
        {
            case "1":
                filteredGames = gameService.GetAllGames();
                break;
            case "2":
                filteredGames = gameService.GetGamesByStatus(GameStatus.Playing);
                break;
            case "3":
                filteredGames = gameService.GetGamesByStatus(GameStatus.Completed);
                break;
            case "4":
                filteredGames = gameService.GetGamesByStatus(GameStatus.NotStarted);
                break;
        }

    }

    int i = 1;
    if (!filteredGames.Any())
    {
        Console.WriteLine("No games found with the selected filter.");
    }
    else
    {
        foreach (var game in filteredGames)
        {
            if (game.GameStatus == GameStatus.Playing)
                Console.ForegroundColor = ConsoleColor.Green;

            else if (game.GameStatus == GameStatus.Completed)
                Console.ForegroundColor = ConsoleColor.Blue;

            else Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine($"{i}. {game.Name} | {game.GameStatus} | {game.StreamType} | {game.Votes}");
            Console.ResetColor();
            i++;
        }
    }

    if (filteredGames.Any())
    {

        Console.WriteLine("\nActions Menu");
        Console.WriteLine("1. Mark a game as playing");
        Console.WriteLine("2. Mark a game as Completed");
        Console.WriteLine("3. Vote for a game");
        Console.WriteLine("4. Return");
        Console.WriteLine("5. Exit");

        Console.WriteLine("Choose an option: ");
        var choice = Console.ReadLine();

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
                MarkGameAsPlaying();
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
                MarkGameAsCompleted();
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
                VoteForGame();
                break;

            case "4":
                continue;

            case "5":
                running = false;
                break;

            default:
                Console.WriteLine("Invalid Option. Please try again");
                Pause();
                break;
        }
    }
    else
    {
        Console.WriteLine("\nPress any key to return to the filter Menu");
        Console.ReadKey();
        continue;
    }
}

Console.WriteLine("\nPress any key to exit...");
Console.ReadKey();


void Pause()
{
    Console.WriteLine("\nPress any key to continue...");
    Console.ReadKey();
}

void MarkGameAsPlaying()
{
    Console.WriteLine("Enter the number of the game: ");
    var input = Console.ReadLine();

    if (int.TryParse(input, out int gameNumber))
    {
        #region practice phase 3
        //if (gameNumber >= 1 && gameNumber <= games.Count)
        //{
        //    var selectedGame = games[gameNumber - 1];
        //    selectedGame.GameStatus = GameStatus.Playing;
        //    Console.WriteLine($"{selectedGame.Name} is now marked as Playing.");
        //    Pause();
        //}
        //else
        //{
        //    Console.WriteLine("Invalid number. Please try again.");
        //    Pause();
        //}
        #endregion
        try
        {
            var updatedGame = gameService.MarkAsPlaying(gameNumber - 1);
            Console.WriteLine($"{updatedGame.Name} is now marked as Playing.");
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Invalid number. Please try again.");
        }
    }
    else
    {
        Console.WriteLine("Please enter a valid number.");
    }
    Pause();
}

void MarkGameAsCompleted()
{
    Console.WriteLine("Enter the number of the game: ");
    var input = Console.ReadLine();
    if (int.TryParse(input, out int gameNumber))
    {
        #region practice phase 3
        //if (gameNumber >= 1 && gameNumber <= games.Count)
        //{
        //    var selectedGame = games[gameNumber - 1];
        //    selectedGame.GameStatus = GameStatus.Completed;
        //    Console.WriteLine($"{selectedGame.Name} is now marked as Completed.");
        //    Pause();
        //}
        //else
        //{
        //    Console.WriteLine("Invalid number. Please try again.");
        //    Pause();
        //}
        #endregion
        try
        {
            var updatedGame = gameService.MarkAsCompleted(gameNumber - 1);
            Console.WriteLine($"{updatedGame.Name} is now marked as Completed.");
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Invalid number. Please try again.");
        }
    }
    else
    {
        Console.WriteLine("Please enter a valid number.");
    }
    Pause();
}

void VoteForGame()
{
    Console.WriteLine("Enter the number of the game you want to vote for: ");
    var input = Console.ReadLine();
    if (int.TryParse(input, out int gameNumber))
    {
        #region prectice phase 3
        //if (gameNumber >= 1 && gameNumber <= games.Count)
        //{
        //    var selectedGame = games[gameNumber - 1];
        //    selectedGame.Votes++;
        //    Console.WriteLine($"You voted for {selectedGame.Name}. Total votes: {selectedGame.Votes}");
        //    Pause();
        //}
        //else
        //{
        //    Console.WriteLine("Invalid Number");
        //    Pause();
        //}
        #endregion
        try
        {
            var updatedGame = gameService.Vote(gameNumber - 1);
            Console.WriteLine($"Your vote has been added for {updatedGame.Name}.");
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Invalid number. Please try again.");
        }
    }
    else
    {
        Console.WriteLine("Please enter a valid number.");
    }
    Pause();
}
