
using PnPManager.Configuration;
using PnPManager.Configuration.Model;
using PnPManager.Core.API;
using PnPManager.Essentials;
using PnPManager.Structure.WPF.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PnPManager.Login.ViewModel
{

  public enum LoginState
  {
    Register,
    Login,
  }

  public class LoginViewModel : NotifyBase
  {

    public Nexus Nexus { get; set; }

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

    public LoginViewModel()
    {

      Nexus = new Nexus();
      Login = CacheManager.LoadLogin() ?? new LoginCache();
      State = LoginState.Login;
      CreateCommands();
    }

    public ICommand LoginCommand { get; set; }
    public ICommand SwitchStateCommand { get; set; }

    public void CreateCommands()
    {
      LoginCommand = new RelayCommand(ExecuteLogin);
      SwitchStateCommand = new RelayCommand(ExecuteSwitchState);
    }

    public void ExecuteLogin()
    {    
      CacheManager.SaveLogin(Login);
      if(State == LoginState.Register)
      {
        Nexus.Register(Login);
      }
      Nexus.Login(Login);
    }


    public void ExecuteSwitchState()
    {
     State = (State == LoginState.Login) ? LoginState.Register : LoginState.Login;
    }
  }
}
