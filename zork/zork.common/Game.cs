using System;
using System.IO;
using Newtonsoft.Json;
using zork.common;



namespace zork.common
{
    public class Game
    {

        public IOutputService Output { get; private set; }

        public IInputService Input { get; private set; }

        public World World { get; set; }

        [JsonIgnore]
        public Player Player { get; private set; }

        [JsonIgnore]
        public bool IsRunning { get; private set; }

        [JsonIgnore]
        public CommandManager CommandManager { get; }

        public Game(World world, Player player)
        {
            World = world;
            Player = player;
        }

        public Game()
        {
            Command[] commands =
            {
                new Command("LOOK", new string[] { "LOOK", "L" },
                    (game, commandContext) => Output.WriteLine($"{game.Player.Location.Name}\n{game.Player.Location.Description}")),

                new Command("QUIT", new string[] { "QUIT", "Q" },
                    (game, commandContext) => game.IsRunning = false),

                new Command("NORTH", new string[] { "NORTH", "N" }, MovementCommands.North),

                new Command("SOUTH", new string[] { "SOUTH", "S" }, MovementCommands.South),

                new Command("EAST", new string[] { "EAST", "E" }, MovementCommands.East),

                new Command("WEST", new string[] { "WEST", "W" }, MovementCommands.West),

                new Command("REWARD",new string[]{"REWARD", "R" }, Reward ),

                new Command ("SCORE", "Score", Score)

            };

            CommandManager = new CommandManager(commands);
        }

        private static void Quit(Game game, CommandContext commandContext)
        {
            game.IsRunning = false;
        }

        private static void Reward(Game game, CommandContext commandContext)
        {
            game.Player.Score++;
            game.Output.WriteLine("You have been awarded 1 point!");

        }

        private static void Score(Game game, CommandContext commandContext)
        {
            game.Output.WriteLine($"Your score would be {game.Player.Score}, in {game.Player.Moves} move(s)");
        }

        public static Game LoadFromFile(string filename, IOutputService output, IInputService input)
        {
            return Load(File.ReadAllText(filename), output, input);
        }

        public static Game Load(string jsonString, IOutputService output, IInputService input)
        {
            Game game = JsonConvert.DeserializeObject<Game>(jsonString);
            game.Output = output;
            game.Input = input;
            game.Player = game.World.SpawnPlayer();
            game.IsRunning = true;
            game.Input.InputReceived += game.InputReceived;
            output.WriteLine("Welcome to Zork!");
            game.CommandManager.PerformCommand(game, "LOOK");




            return game;
        }

        private void InputReceived(object sender, string inputString)
        {
           Room previousRoom = Player.Location;
           if (CommandManager.PerformCommand(this, inputString))
           {
               Player.Moves++;
                if(previousRoom != Player.Location)
                {
                    CommandManager.PerformCommand(this, "Look");
                    previousRoom = Player.Location;
                }
           }
           else
           {
               Output.WriteLine("That's not a verb I recognize.");
           }
        }
        

    }
}

