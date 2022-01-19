using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PnPManager.Client.Configuration
{
  public static class XMLService
  {

    public static void Write<T>(string folder, string file, T item)
    {
      Directory.CreateDirectory(folder);
      using(var writer = new StreamWriter(Path.Combine(folder, file)))
      {
        var serializer = new XmlSerializer(typeof(T));
        serializer.Serialize(writer, item);
      }
    }

    public static T Load<T>(string folder, string file)
    {
      try
      {
        using(var reader = new StreamReader(Path.Combine(folder, file)))
        {
          var serializer = new XmlSerializer(typeof(T));
          var result = (T)serializer.Deserialize(reader);
          return result;
        }
      }
      catch
      {
        return default(T);
      }
    }


  }
}
