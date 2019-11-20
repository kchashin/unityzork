using System;
using zork.common;

namespace zork.game
{
    class Program
    {
        static void Main(string[] args)
        {
            const string defaultGameFilename = "Zork.json";
            string gameFilename = (args.Length > 0 ? args[(int)CommandLineArguments.GameFilename] : defaultGameFilename);

            ConsoleOutputService output = new ConsoleOutputService();
            ConsoleInputService input = new ConsoleInputService();
            Game game = Game.LoadFromFile(gameFilename, output, input);
            
            
            output.WriteLine("Thank you for playing!");

            while (game.IsRunning)
            {
                output.Write("\n>");
                input.ProcessInput();
            }
        }
        private enum CommandLineArguments
        {
            GameFilename = 0
        }

    }
}
