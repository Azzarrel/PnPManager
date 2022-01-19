
using PnPManager.Client.Essentials;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PnPManager.Client.Main.Interfaces.Services;

namespace PnPManager.Client.Home
{
  public class Factory : FactoryBase
  {

    public IMergeService MergeService { get; private set; }

    public Factory(IMergeService mergeService)
    {
      MergeService = mergeService;
    }

    //public override ModuleBase Initialze()
    //{

    //  MergeService.Merge("Resources/ModuleDataContext");
    //  return new ModuleBase();

    //}


  }
}
