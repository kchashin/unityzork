using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.ComponentModel;
using System.Linq;

namespace zork.common
{
    public class Player : INotifyPropertyChanged
    {
     //   private int zScore;

   //   public int Score
   //   {
   //       get => zScore;
   //       set
   //       {
   //           zScore = value;
   //          ScoreChanger?.Invoke(this, ScoreText.text);
   //       }
   //   }

        public event PropertyChangedEventHandler PropertyChanged;

        public event EventHandler<int> ScoreChanged;
        
        public event EventHandler<int> MovesChanged;

        public event EventHandler<int> LocationChanged;

        public int Moves { get; set; }

        public int Score { get; set; }

        public int Health { get; set; }

        public World World { get; }

        [JsonIgnore]
        public Room Location { get; set; }

        [JsonIgnore]
        public string LocationName
        {
            get
            {
                return Location?.Name;
            }
            set
            {
                Location = World?.RoomsByName.GetValueOrDefault(value);
            }
        }
        public Player(World world, string startingLocation)
        {
            World = world;
            LocationName = startingLocation;
        }
        public bool Move(Directions direction)
        {
            bool isValidMove = Location.Neighbors.TryGetValue(direction, out Room destination);
            if (isValidMove)
            {
                Location = destination;
            }
            return isValidMove;
        }

        




    }
}