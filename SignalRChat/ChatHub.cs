using Microsoft.AspNet.SignalR;

namespace SignalRChat
{
    public class ChatHub : Hub
    {
        public void Hello()
        {
            Clients.All.hello();
        }

        public void Send(string name, string message)
        {
            // call the broadcastMessage method to update clients.
            Clients.All.broadcastMessage(name, message);
        }
    }
}