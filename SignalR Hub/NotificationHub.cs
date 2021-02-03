using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalR_Hub.Controllers
{
    public class NotificationHub : Hub
    {

        public async Task SendMessage(string sender, string message)
        {
            await Clients.All.SendAsync("BroadcastMessage", sender, message);
        }

    }
}
