using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PnPManager.Essentials
{
  public class ModuleBase : NotifyBase
  {

    public int ID
    {
      get { return Get<int>(); }
      set { Set(value); }
    }

    public string IconPath
    {
      get { return Get<string>(); }
      set { Set(value); }
    }

    public string Name
    {
      get { return Get<string>(); }
      set { Set(value); }
    }



  }
}
