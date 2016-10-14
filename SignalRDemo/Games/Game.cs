using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SignalRDemo.Games
{
    public abstract class Game
    {
        public Game()
        {
            RoleManager = new RoleManager();
        }
        public RoleManager RoleManager { get; }

        public abstract void Initialize();
    }
}