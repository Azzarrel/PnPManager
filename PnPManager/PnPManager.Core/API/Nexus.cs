
using Microsoft.AspNetCore.SignalR.Client;
using Newtonsoft.Json;
using PnPManager.Client.Model;
using PnPManager.Configuration.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PnPManager.Core.API
{
  public class Nexus
  {

    private LoginClient m_LoginClient;
    public LoginClient LoginClient
    { get
      {
        if(m_LoginClient == null && HttpClient != null)
          m_LoginClient = new LoginClient(HttpClient);

        return m_LoginClient;
      }
         
      private set { m_LoginClient = value; }
    }


    public HttpClient HttpClient { get; private set; }


    public Nexus()
    {
      LoginClient = new LoginClient(new HttpClient());
    }


    public User Login(LoginCache login)
    {
      HttpClient httpClient = CreateHttpClient(login.ServerName);
      LoginClient = new LoginClient(httpClient);
      return LoginClient.LogInUserAsync(login).Result;
    }

    public void Register(LoginCache login)
    {
      HttpClient httpClient = CreateHttpClient(login.ServerName);
      LoginClient = new LoginClient(httpClient);
      LoginClient.RegisterUserAsync(login);
    }

    public void Ping()
    {
     
    }

    private HttpClient CreateHttpClient(string serverName)
    {
      HttpClient httpClient = new HttpClient();
      httpClient.BaseAddress = new Uri($"http://{serverName}:5000");
      return httpClient;
    }
  }
}
