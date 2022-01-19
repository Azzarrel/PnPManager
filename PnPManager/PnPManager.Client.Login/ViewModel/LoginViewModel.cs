using PnPManager.Client.Configuration;
using PnPManager.Client.Configuration.Model;
using PnPManager.Client.Core.API;
using PnPManager.Client.Essentials;
using PnPManager.Client.Structure.WPF.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PnPManager.Client.Login.ViewModel
{

  public enum LoginState
  {
    Register,
    Login,
  }

  public class LoginViewModel : NotifyBase
  {


    #region Properties

    public LoginClient LoginClient { get; set; }

    public LoginCache Login
    {
      get { return Get<LoginCache>(); }
      set { Set((value)); }
    }

    public string ConfirmationPassword
    {
      get { return Get<string>(); }
      set { Set(LoginCache.HashPassword(value)); }
    }

    public LoginState State
    {
      get { return Get<LoginState>(); }
      set { Set((value)); }
    }

    #endregion Properties

    #region Constructor

    public LoginViewModel()
    {
      Login = CacheManager.LoadLogin() ?? new LoginCache();
      State = LoginState.Login;
      CreateCommands();
    }

    #endregion Constructor

    public ICommand LoginCommand { get; set; }
    public ICommand SwitchStateCommand { get; set; }

    public void CreateCommands()
    {
      LoginCommand = new RelayCommand(ExecuteLogin);
      SwitchStateCommand = new RelayCommand(ExecuteSwitchState);
    }

    public void ExecuteLogin()
    {
      LoginClient = new LoginClient(Login.ServerName);
      CacheManager.SaveLogin(Login);
      if(State == LoginState.Register)
      {
        var user = LoginClient.RegisterUserAsync(Login).Result;
      }
      LoginClient.LogInUserAsync(Login);
    }


    public void ExecuteSwitchState()
    {
     State = (State == LoginState.Login) ? LoginState.Register : LoginState.Login;
    }
  }
}
