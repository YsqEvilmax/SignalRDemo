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
            roleManager.LoadRole(new Killer(2));
            roleManager.LoadRole(new Police(2));
            roleManager.LoadRole(new Farmer(5));
        }
    }
}