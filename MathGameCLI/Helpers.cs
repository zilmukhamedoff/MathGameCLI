using MathGameCLI.Models;

namespace MathGameCLI
{
    internal class Helpers
    {
        internal static List<Game> games =
        [
            new Game { Date = DateTime.Now.AddDays(1), Score = 5, Type = GameType.Addition },
            new Game { Date = DateTime.Now.AddDays(2), Score = 4, Type = GameType.Multiplication },
            new Game { Date = DateTime.Now.AddDays(3), Score = 4, Type = GameType.Division },
            new Game { Date = DateTime.Now.AddDays(4), Score = 3, Type = GameType.Subtraction },
            new Game { Date = DateTime.Now.AddDays(5), Score = 1, Type = GameType.Addition },
            new Game { Date = DateTime.Now.AddDays(6), Score = 2, Type = GameType.Multiplication },
            new Game { Date = DateTime.Now.AddDays(7), Score = 3, Type = GameType.Division },
            new Game { Date = DateTime.Now.AddDays(8), Score = 4, Type = GameType.Subtraction },
            new Game { Date = DateTime.Now.AddDays(9), Score = 4, Type = GameType.Addition },
            new Game { Date = DateTime.Now.AddDays(10), Score = 1, Type = GameType.Multiplication },
            new Game { Date = DateTime.Now.AddDays(11), Score = 0, Type = GameType.Subtraction },
            new Game { Date = DateTime.Now.AddDays(12), Score = 2, Type = GameType.Division },
            new Game { Date = DateTime.Now.AddDays(13), Score = 5, Type = GameType.Subtraction },
        ];

        internal static int[] GetDivisionNumbers()
        {
            var random = new Random();
            var firstNumber = random.Next(1, 99);
            var secondNumber = random.Next(1, 99);

            var result = new int[2];

            while (firstNumber % secondNumber != 0)
            {
                firstNumber = random.Next(1, 99);
                secondNumber = random.Next(1, 99);
            }

            result[0] = firstNumber;
            result[1] = secondNumber;

            return result;
        }

        internal static void AddToHistory(int score, GameType type)
        {
            games.Add(new Game 
            {
                Date = DateTime.Now, 
                Score = score, 
                Type = type 
            });
        }

        internal static void PrintGames()
        {
            Console.Clear();
            Console.WriteLine("Games History:");
            Console.WriteLine("----------------------------");

            foreach (var game in games) 
            {
                Console.WriteLine($"{game.Date} - {game.Type} : {game.Score} points");
            }

            Console.WriteLine("----------------------------\n");
            Console.WriteLine("Press any key to return to Menu");
            Console.ReadKey();
        }

        internal static string ValidateResult(string? result)
        {
            while (string.IsNullOrEmpty(result) || !Int32.TryParse(result, out _))
            {
                Console.WriteLine("Answer needs to be an Integer. Try again.");
                result = Console.ReadLine();
            }

            return result;
        }

        internal static string GetName()
        {
            Console.Write("Please enter your name");
            var name = Console.ReadLine();

            while (string.IsNullOrEmpty(name)) 
            {
                Console.WriteLine("Name can't be empty");
                name = Console.ReadLine();
            }

            return name;
        }
    }
}
