using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows;

namespace PnPManager.Launcher
{
  /// <summary>
  /// Interaction logic for App.xaml
  /// </summary>
  public partial class App : Application
  {

    protected override void OnStartup(StartupEventArgs e)
    {

      string path = Assembly.GetExecutingAssembly().Location.Replace("PnPManager.Launcher.dll", "");
      Assembly core = Assembly.LoadFrom(Path.Combine(path, "lib", "PnPManager.Client.Core.dll"));
      var assemblyResolverType = core.GetTypes().FirstOrDefault(t => t.Name == "AssemblyResolver");
      if(assemblyResolverType != null)
      {

        MethodInfo resolve = assemblyResolverType.GetMethod("AssemblyResolve");
        if(resolve != null)
        {
          resolve.Invoke(null, new object[] { path });
        }


        Assembly login = Assembly.LoadFrom(Path.Combine(path, "lib", "PnPManager.Client.Login.dll"));
        var loginViewModel = Activator.CreateInstance(login.GetType("PnPManager.Client.Login.ViewModel.LoginViewModel"));

        var loginWindow = Activator.CreateInstance(login.GetType("PnPManager.Client.Login.View.LoginWindow"), loginViewModel);

        MainWindow = (Window)loginWindow;
        MainWindow.ShowDialog();
      }


      base.OnStartup(e);
    }



  }
}
