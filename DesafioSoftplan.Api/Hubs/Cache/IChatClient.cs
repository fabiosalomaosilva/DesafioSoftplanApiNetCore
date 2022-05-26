using System.Threading.Tasks;

namespace DesafioSoftplan.Api.Hubs.Cache
{
    public interface IChatClient
    {
        Task ReceiveMessage(ChatMessage chatMessage);
    }
}
