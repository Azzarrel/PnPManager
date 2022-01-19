using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PnPManager.Client.Essentials
{
  public class ModelBase : NotifyBase
  {

    public int ID
    {
      get { return Get<int>(); }
      set { Set(value); }
    }

  }
}
