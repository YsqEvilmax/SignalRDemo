using SignalRDemo.Games.KillingGame.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SignalRDemo.Games.KillingGame
{
    public class KillingGame : Game
    {
        public override void Initialize()
        {
            RoleManager.All.Add(new Killer(2));
            RoleManager.All.Add(new Police(2));
            RoleManager.All.Add(new Farmer(5));
        }
    }
}