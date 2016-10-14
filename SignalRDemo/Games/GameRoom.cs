using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SignalRDemo.Games
{
    public class GameRoom
    {
        public GameRoom(string name)
        {
            Name = name;
            PlayerManager = new PlayerManager();
        }
        public string Name { get; }

        public Game Game { get; set; }
        public PlayerManager PlayerManager { get; }
    }

    public class GameRoomManager : Manager<GameRoom>
    {
        public GameRoom AllocRoom(string roomName = null)
        {
            GameRoom room = null;
            if (string.IsNullOrEmpty(roomName) || !All.Any(x => x.Name == roomName))
            {
                room = new GameRoom(roomName);
                All.Add(room);
            }
            else
            {
                room = All.Find(x => x.Name == roomName);
            }

            return room;
        }

        public void BanRoom()
        {
            All.RemoveAll(x => x.PlayerManager.All.Count == 0);
        }
    }
}