using PnPManager.Configuration.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PnPManager.Configuration
{
  public static class CacheManager
  {

    private static string m_CachePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "pnpmanager");

    public static void SaveLogin(LoginCache login)
    {
      XMLService.Write(m_CachePath, "logins.xml", new List<LoginCache>() { login });
    }

    public static LoginCache LoadLogin()
    {
      return XMLService.Load<LoginCache>(m_CachePath, "logins.xml").FirstOrDefault();
    }


    }


  }
}
