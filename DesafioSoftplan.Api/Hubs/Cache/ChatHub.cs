using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace DesafioSoftplan.Api.Hubs.Cache
{
    public class ChatHub : Hub<IChatClient>
    {
        private readonly IUserSessionCache _sessionCache;

        public ChatHub(IUserSessionCache sessionCache)
        {
            _sessionCache = sessionCache;
        }
        public async Task SendMessage(ChatMessage chatMessage)
        {

            await Clients.All.ReceiveMessage(chatMessage);
        }

        public async Task UserRegister(User user)
        {
            _sessionCache.UpdateCache(user);
        }
    }
}