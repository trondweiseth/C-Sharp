using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_codecamp
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Message("name");
            string phrase = Message("favorite saying");
            DisplayOutput(name, phrase);
            WaitForInput();
        }

        public static string Message(string msg)
        {
            PrintColorMessage(ConsoleColor.Yellow, $"Please enter your {msg}: ");
            return Console.ReadLine();
        }

        public static void DisplayOutput(string name, string phrase)
        {
            PrintColorMessage(ConsoleColor.Yellow, "========================================================");
            PrintColorMessage(ConsoleColor.Green, $"Your name is: {name}");
            PrintColorMessage(ConsoleColor.Green, $"Your favourite saying is: {phrase}");
            PrintColorMessage(ConsoleColor.Yellow, "========================================================");
        }

        // Waiting for userinput before closing console
        static void WaitForInput()
        {
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }

        public static void PrintColorMessage(ConsoleColor color, string colormsg)
        {
            Console.ForegroundColor = color;
            Console.Write($"\n{colormsg}");
            Console.ResetColor();
        }
    }
}
