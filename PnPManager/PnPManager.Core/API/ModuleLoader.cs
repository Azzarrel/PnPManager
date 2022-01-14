using PnPManager.Client.Model;
using PnPManager.Configuration;
using PnPManager.Essentials;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PnPManager.Core.API
{
  public class ModuleLoader
  {

    private string m_ModulePath = Path.Combine(Assembly.GetEntryAssembly().Location, "modules");

    public ModuleBase LoadModule()
    {
      try
      {
        foreach(string folder in Directory.GetDirectories(m_ModulePath))
        {

          var moduleInfo = XMLService.Load<ModuleInfo>(folder, "moduleInfo.xml").FirstOrDefault();
          var assembly = Assembly.LoadFrom(Path.Combine(folder, moduleInfo.AssemblyPath));

          FactoryBase factory = (FactoryBase)Activator.CreateInstance(assembly.GetType("Factory"));
          return factory.Initialze();


        }
      }
      catch { }
      return null;
    }

  }
}
