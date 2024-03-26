namespace MathGameCLI
{
    internal class Menu
    {
        GameEngine gameClass = new();

        internal void ShowMenu(string name, DateTime date)
        {
            Console.Clear();
            Console.WriteLine($"Hi {name}. It's {date}. Welcome to the [[**Math Game CLI**]]");
            Console.WriteLine("Press any key to proceed to the menu...");
            Console.ReadKey();
            Console.WriteLine("\n");

            var isGameOn = true;

            do
            {
                Console.Clear();
                Console.WriteLine($@"
Select menu option:
[v] - view previous games
[a] - addition
[s] - subtraction
[m] - multiplication
[d] - division
[e] - exit the program");

                Console.WriteLine("----------------------------");

                var selected = Console.ReadLine().ToLower().Trim();

                switch (selected)
                {
                    case "v":
                        Helpers.PrintGames();
                        break;
                    case "a":
                        gameClass.AdditionGame("selected [Addition] mode");
                        break;
                    case "s":
                        gameClass.SubtractionGame("selected [Subtraction] mode");
                        break;
                    case "m":
                        gameClass.MultiplicationGame("selected [Multiplication] mode");
                        break;
                    case "d":
                        gameClass.DivisionGame("selected [Division] mode");
                        break;
                    case "e":
                        Console.WriteLine("Exiting the program...");
                        isGameOn = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input.");
                        break;
                }
            } while (isGameOn);
        }
    }
}
