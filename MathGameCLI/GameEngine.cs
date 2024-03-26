﻿using MathGameCLI.Models;

namespace MathGameCLI
{
    internal class GameEngine
    {
        internal void DivisionGame(string message)
        {
            var score = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                var divisionNumbers = Helpers.GetDivisionNumbers();
                var firstNumber = divisionNumbers[0];
                var secondNumber = divisionNumbers[1];

                Console.WriteLine($"{firstNumber} / {secondNumber}");

                var result = Console.ReadLine();
                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber / secondNumber)
                {
                    Console.WriteLine("Answer was correct! Type any key for the next question");
                    score++;
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Answer was incorrect. Type any key for the next question");
                    Console.ReadKey();
                }

                if (i == 4) Console.WriteLine($"Game Over. Your score is {score}");
            }

            Helpers.AddToHistory(score, GameType.Division);
        }

        internal void MultiplicationGame(string message)
        {
            var random = new Random();
            var score = 0;

            int firstNumber;
            int secondNumber;

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);

                Console.WriteLine($"{firstNumber} * {secondNumber}");

                var result = Console.ReadLine();
                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber * secondNumber)
                {
                    Console.WriteLine("Answer was correct! Type any key for the next question");
                    score++;
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Answer was incorrect. Type any key for the next question");
                    Console.ReadKey();
                }

                if (i == 4) Console.WriteLine($"Game Over. Your score is {score}");
            }

            Helpers.AddToHistory(score, GameType.Multiplication);
        }

        public void SubtractionGame(string message)
        {
            var random = new Random();
            var score = 0;

            int firstNumber;
            int secondNumber;

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);

                Console.WriteLine($"{firstNumber} - {secondNumber}");

                var result = Console.ReadLine();
                result = Helpers.ValidateResult(result);
                if (int.Parse(result) == firstNumber - secondNumber)
                {
                    Console.WriteLine("Answer was correct! Type any key for the next question");
                    score++;
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Answer was incorrect. Type any key for the next question");
                    Console.ReadKey();
                }

                if (i == 4) Console.WriteLine($"Game Over. Your score is {score}");
            }

            Helpers.AddToHistory(score, GameType.Subtraction);
        }

        public void AdditionGame(string message)
        {
            var random = new Random();
            var score = 0;

            int firstNumber;
            int secondNumber;

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);

                Console.WriteLine($"{firstNumber} + {secondNumber}");

                var result = Console.ReadLine();
                result = Helpers.ValidateResult(result);
                if (int.Parse(result) == firstNumber + secondNumber)
                {
                    Console.WriteLine("Answer was correct! Type any key for the next question");
                    score++;
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Answer was incorrect. Type any key for the next question");
                    Console.ReadKey();
                }

                if (i == 4) Console.WriteLine($"Game Over. Your score is {score}");
            }

            Helpers.AddToHistory(score, GameType.Addition);
        }
    }
}
