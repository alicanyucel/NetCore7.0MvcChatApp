using Microsoft.AspNetCore.SignalR;
namespace SignalChatNetCore7._0.Hubs
{
    public class ChatHub:Hub
    {
        public async Task SendMessage(string user,string message)
        {
            // clientları dinle
            await Clients.All.SendAsync("mesal alındı",user,message);
        }
    }
}
