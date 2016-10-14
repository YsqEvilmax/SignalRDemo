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
        //static KillingGameHub()
        //{
        //    _game.Initialize();
        //}

        //public KillingGameHub()
        //{
        //    _game.Initialize();
        //}
        public void Hello()
        {
            Clients.All.hello();
        }

        public void JoinRoom(string roomName = null)
        {
            GameRoom room = grm.AllocRoom(roomName);
            room.PlayerManager.All.Add(new Player("new"));
        }

        public void LeaveRoom(string roomName)
        {
            GameRoom room = grm.All.Find(x => x.Name == roomName);
            room.PlayerManager.All.RemoveAll(x => x.Name == "new");
        }

        public void AssignRole(string roleName = null)
        {
            if(_game == null)
            {
                _game = new KillingGame();
                _game.Initialize();
            }
            Role role = _game.RoleManager.GetRole();
            Clients.Caller.ReceiveRole(role);
        }

        private KillingGame _game = null;

        static private GameRoomManager grm = new GameRoomManager();
    }
}