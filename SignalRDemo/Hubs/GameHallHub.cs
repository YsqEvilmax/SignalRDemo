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

        public void Update(Role role)
        {
            Clients.Caller.getRole(role);
        }
    }

    public class Role
    {
        public string Name { get; set; }
    }
}