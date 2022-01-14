using PnPManager.Essentials;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PnPManager.Configuration.Model
{
  public class LoginCache : NotifyBase
  {

    public string ServerName
    {
      get { return Get<string>(); }
      set { Set(value); }
    }
    public string UserName
    {
      get { return Get<string>(); }
      set { Set(value); }
    }

    public string Password
    {
      get { return Get<string>(); }
      set { Set(HashPassword(value)); }
    }


    public static string HashPassword(string password)
    {
      byte[] bytes = Encoding.UTF8.GetBytes(password);
      SHA256Managed hashstring = new SHA256Managed();
      byte[] hash = hashstring.ComputeHash(bytes);
      string hashString = string.Empty;

      return Convert.ToBase64String(hash);


    }

  }
}
