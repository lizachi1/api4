using Microsoft.AspNetCore.SignalR;

namespace SignalR;

public class ChatHub : Hub
{
    public async Task Send(string message, string userName)
    {
        float first = float.Parse(message);
        float second = float.Parse(userName);
        await Clients.All.SendAsync("Receive", first + second, first * second);
    }
}