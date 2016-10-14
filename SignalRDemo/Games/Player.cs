using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SignalRDemo.Games
{
    public class Player
    {
        public Player(string name)
        {
            Name = name;
        }
        public string Name { get; }
    }
    public class PlayerManager : Manager<Player>
    {
    }
}