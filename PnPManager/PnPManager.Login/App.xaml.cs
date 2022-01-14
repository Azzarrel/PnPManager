using PnPManager.Login.View;
using PnPManager.Login.ViewModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace PnPManager.Login
{
  /// <summary>
  /// Interaction logic for App.xaml
  /// </summary>
  public partial class App : Application
  {

    protected override void OnStartup(StartupEventArgs e)
    {
      LoginViewModel vm = new LoginViewModel();
      MainWindow = new LoginWindow(vm);
      MainWindow.ShowDialog();
      base.OnStartup(e);
    }

  }
}
