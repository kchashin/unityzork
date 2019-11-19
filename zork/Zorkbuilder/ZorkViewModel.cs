using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using zork.common;
using System.IO;
using System.ComponentModel;

namespace Zorkbuilder
{
    public class ZorkViewModel : INotifyPropertyChanged
    {
        private Game zGame;

        public event PropertyChangedEventHandler PropertyChanged;

        public string Filename { get; set; }

        public BindingList<Room> Rooms { get; set; }

        public string WelcomeMessage { get; set; }

        public Game Game
        {
            get => zGame;
            set
            {
                if (zGame != value)
                {
                    zGame = value;
                    if (zGame != null)
                    {
                        Rooms = new BindingList<Room>(zGame.World.Rooms);
                    }
                    else
                    {
                        Rooms = new BindingList<Room>(Array.Empty<Room>());
                    }
                }
            }
        }

        public World World
        {
            get => Game?.World;
        }
        public ZorkViewModel(Game game = null) => Game = game;

        public void SaveWorld()
        {
            if (string.IsNullOrEmpty(Filename))
            {
                throw new InvalidProgramException("Filename expected.");
            }

            JsonSerializer serializer = new JsonSerializer
            {
                Formatting = Formatting.Indented
            };
            using (StreamWriter streamWriter = new StreamWriter(Filename))
            using (JsonWriter jsonWriter = new JsonTextWriter(streamWriter))
            {
                serializer.Serialize(jsonWriter, Game);
            }
        }
        /*
        public void RemoveRoom(Room room)
        {
            foreach (Room rooms in Rooms)
            {
                rooms.Name.Remove(room);
            }

            Room.Remove(room);
        }
        */
    }
}
