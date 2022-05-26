using DesafioSoftplan.Api.Hubs.Cache;
using Microsoft.AspNetCore.SignalR;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Timers;

namespace DesafioSoftplan.Api.Hubs.Cache
{
    public class UserSessionCache : IUserSessionCache
  {
    private Dictionary<string, UserSession> _userSession;
    private System.Timers.Timer _timer;
    private IHubContext<ChatHub> _hub;


    public UserSessionCache(IHubContext<ChatHub> hub)
    {
      _userSession = new Dictionary<string, UserSession>();
      _timer = new System.Timers.Timer();
      _timer.Interval = 1000;
      _timer.Elapsed += new ElapsedEventHandler(_timer_Elapsed);
      _timer.AutoReset = true;

      _hub = hub;
    }

    void _timer_Elapsed(object sender, ElapsedEventArgs e)
    {
      PingSubscribers();
    }

    public void UpdateCache(User user)
    {
      var newSessions = _userSession.Count == 0;
      if (newSessions)
      {
        if (!_timer.Enabled)
        {
          _timer.Enabled = true;
          _timer.Start();
        }
      }
      this.AddOrUpdateUserSession(user);
    }

    private void PingSubscribers()
    {
      if (_userSession.Count() > 0)
      {
        var validSessions = _userSession.ToList().Where(x => x.Value.IsConnected());
        if (validSessions != null)
        {
          var allUsers = string.Join("||", validSessions.Select(x => JsonConvert.SerializeObject(x.Value.User)));
          _hub.Clients.All.SendAsync("notifyAdmin", allUsers);
        }
      }
    }

    private void AddOrUpdateUserSession(User user)
    {
      var existSesssion = _userSession.ContainsKey(user.Email);
      if (existSesssion)
      {
        var currentSession = _userSession[user.Email];
        currentSession.LastConnectedTime = DateTime.Now.Ticks;
        currentSession.User = user;
        return;
      }
      var session = new UserSession
      {
        User = user,
        LastConnectedTime = DateTime.Now.Ticks
      };

      _userSession.Add(user.Email, session);
    }
  }
}
