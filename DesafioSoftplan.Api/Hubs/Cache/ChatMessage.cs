namespace DesafioSoftplan.Api.Hubs.Cache
{
    public class ChatMessage
    {
        public string id { get; set; }
        public string user { get; set; }
        public string message { get; set; }

        public string consumer { get; set; }
    }
}
