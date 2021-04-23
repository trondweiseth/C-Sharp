using System;
using System.Threading;

// Namespace
namespace ConsoleApp1
{
    // Main Class
    class Program
    {
        // Entry Point Method(Function)
        static void Main(string[] args)
        {
            GetAppInfo(); // Run GetAppInfo function

            GreetingMessage(); // Ask for information and greet the user

            // Wait before clearing the console
            Thread.Sleep(1500);

            // Clear the console
            Console.Clear();

            while (true)
            {
                // Clear the console
                Console.Clear();

                // Create a new random object
                Random random = new Random();

                //int correctNumber
                int correctNumber = random.Next(1, 10);

                // Init guess var
                int guess = 0;

                // While guess is not correct
                while (guess != correctNumber)
                {
                    // Ask user for number
                    PrintColorMessage(ConsoleColor.Magenta, "Guess a number between 1 and 10 => ");

                    // Get user input
                    string input = Console.ReadLine();

                    // Make sure it's a number
                    if (!int.TryParse(input, out guess))
                    {

                        // Tell user it's not a number
                        PrintColorMessage(ConsoleColor.Red, "Please enter an actual number");

                        // Wait before clearing the console
                        Thread.Sleep(800);

                        // Clear the console
                        Console.Clear();

                        // Keep going
                        continue;
                    }

                    // Cast to int and parse it in guess
                    guess = Int32.Parse(input);

                    // Match guess to correct number
                    if (guess != correctNumber)
                    {
                        // Tell user it's the wrong number
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again");

                        // Wait before clearing the console
                        Thread.Sleep(800);

                        // Clear the console
                        Console.Clear();
                    }
                }

                // Tell user it's the right number
                PrintColorMessageNewLine(ConsoleColor.Cyan, "You guessed the right number!");

                // Ask to play again
                PrintColorMessageNewLine(ConsoleColor.Yellow, "Play again? [Y or N] => ");

                // Answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else
                {
                    return;
                }
            }
        }

        // Display app info
        static void GetAppInfo()
        {
            // Set app vars
            var appName = "Number Guesser";
            var appVersion = "1.0.0";
            var appAuthor = "Trond Weiseth";

            PrintColorMessageNewLine(ConsoleColor.Yellow, $"{appName}: Version {appVersion} by {appAuthor}");
        }

        // Aask user for name and greet
        static void GreetingMessage()
        {
            // Ask users name
            PrintColorMessage(ConsoleColor.Cyan, "What is your name? => ");

            // Get user input
            string inputName = Console.ReadLine();

            // Write out app info
            PrintColorMessage(ConsoleColor.Magenta, $"Hello {inputName}, let's play a game...");
        }

        // Print color message without new line
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            // Change console color
            Console.ForegroundColor = color;

            // Tell user it's the right number
            Console.Write($"\n{message}");

            // Reset console color
            Console.ResetColor();
        }

        // Print color message with new line
        static void PrintColorMessageNewLine(ConsoleColor color, string message)
        {
            // Change console color
            Console.ForegroundColor = color;

            // Tell user it's the right number
            Console.WriteLine($"\n{message}");

            // Reset console color
            Console.ResetColor();
        }
    }
}
