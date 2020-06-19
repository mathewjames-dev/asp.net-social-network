using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace SocialNetwork.Classes.Hubs
{
    public class GlobalHub : Hub
    {
        /*
         * Global Broadcast Function
         */
        public Task Broadcast(string user, string message)
        {
            /*
             * Send the user and message to all users.
             */
            return Clients.All.SendAsync("BroadcastMessage", user, message);
        }
    }
}
