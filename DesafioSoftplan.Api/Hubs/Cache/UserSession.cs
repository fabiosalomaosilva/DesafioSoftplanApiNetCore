using System;

namespace DesafioSoftplan.Api.Hubs.Cache
{
    public class UserSession
    {
        public const long TicksPerSecond = 10000000;
        public User User { get; set; }
        public long LastConnectedTime { get; set; }

        public UserSession()
        {
            LastConnectedTime = 0;
        }

        public bool IsConnected()
        {
            long gap = DateTime.Now.Ticks - this.LastConnectedTime;
            return gap < TicksPerSecond * 5;
        }
    }

}
