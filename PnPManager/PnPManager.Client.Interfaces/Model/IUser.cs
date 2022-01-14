using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PnPManager.Client.Interfaces.Model
{
  public interface IUser
  {

    string Name { get; set; }

    string Guid { get; set; }

  }
}
