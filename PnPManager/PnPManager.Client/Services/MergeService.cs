using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PnPManager.Client.Services
{
  public class MergeService
  {

    //ToDo: evtl Singleton
    public static bool Merge(string path)
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
