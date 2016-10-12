using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace SignalRDemo.Hubs
{
    public class GameHallHub : Hub
    {
        public void Send(string name, string message)
        {
            Clients.All.hello(name, message);
        }

        public async void CreateRoom()
        {
            await Groups.Add(this.Context.ConnectionId, Guid.NewGuid().ToString());
        }
    }
}