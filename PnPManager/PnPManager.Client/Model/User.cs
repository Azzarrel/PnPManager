using PnPManager.Client.Interfaces.Model;
using PnPManager.Essentials;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PnPManager.Client.Model
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
