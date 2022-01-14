using PnPManager.Client.Model;
using PnPManager.Essentials;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PnPManager.Client.ViewModel
{
  public class MainWindowViewModel : NotifyBase
  {

    public IList<ModuleBase> Modules
    {
      get { return Get<IList<ModuleBase>>(); }
      set { Set((value)); }
    }


    public MainWindowViewModel()
    {
      Modules = new ObservableCollection<ModuleBase>();



      


    }

  }
}
