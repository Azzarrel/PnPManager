using PnPManager.Client.Essentials;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PnPManager.Client.Main.Model
{
  public class ModuleInfo : NotifyBase
  {

    public string IconPath
    {
      get { return Get<string>(); }
      set { Set((value)); }
    }

    public string Description
    {
      get { return Get<string>(); }
      set { Set((value)); }
    }

    public string AssemblyPath
    {
      get { return Get<string>(); }
      set { Set((value)); }
    }


  }
}
