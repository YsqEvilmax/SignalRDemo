using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using SignalRDemo.Games.KillingGame;
using SignalRDemo.Games;

namespace SignalRDemo.Hubs
{
    public class KillingGameHub : Hub
    {
        static KillingGameHub()
        {
            _game.Initialize();
        }
        public void Hello()
        {
            Clients.All.hello();
        }

        public void AssignRole()
        {
            Role role = _game.roleManager.GetRole();
            Clients.Caller.ReceiveRole(role);
        }

        static private KillingGame _game = new KillingGame();
    }
}