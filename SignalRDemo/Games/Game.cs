using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SignalRDemo.Games
{
    public abstract class Game
    {
        public RoleManager roleManager = new RoleManager();

        public abstract void Initialize();
    }
}