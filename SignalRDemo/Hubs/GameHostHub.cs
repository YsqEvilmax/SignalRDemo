using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace SignalRDemo.Hubs
{
    public class GameHostHub : Hub
    {
        public void Hello()
        {
            Clients.All.hello();
        }
    }
}