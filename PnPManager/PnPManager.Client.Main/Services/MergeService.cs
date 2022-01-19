using PnPManager.Client.Main.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PnPManager.Client.Main.Services
{
  public class MergeService : IMergeService
  {

    //ToDo: evtl Singleton
    public bool Merge(string path)
    {
      try
      {
        Assembly assembly = Assembly.GetCallingAssembly();

        Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary
        {
          Source = new Uri($"pack://application:,,,/{assembly};component/{path}", UriKind.RelativeOrAbsolute)
        });
        return true;
      }
      catch
      {
        return false;
      }
    }

  }
}
