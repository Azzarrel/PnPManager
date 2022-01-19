using PnPManager.Client.Essentials;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PnPManager.Client.Interfaces.Main.Model;

namespace PnPManager.Client.Main.Model
{
  public class User : NotifyBase, IUser
  {


    public string Name
    {
      get { return Get<string>(); }
      set { Set((value)); }
    }

    public string Guid
    {
      get { return Get<string>(); }
      set { Set((value)); }
    }
  }
}
