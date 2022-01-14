using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PnPManager.Configuration
{
  public static class XMLService
  {

    public static void Write<T>(string folder, string file, IEnumerable<T> items)
    {
      Directory.CreateDirectory(folder);
      using(var writer = new StreamWriter(Path.Combine(folder, file)))
      {
        var serializer = new XmlSerializer(typeof(List<T>));
        serializer.Serialize(writer, new List<T>(items));
      }
    }

    public static List<T> Load<T>(string folder, string file)
    {
      try
      {
        using(var reader = new StreamReader(Path.Combine(folder, file)))
        {
          var serializer = new XmlSerializer(typeof(List<T>));
          var result = serializer.Deserialize(reader) as List<T>;
          return result;
        }
      }
      catch
      {
        return new List<T>();
      }

    }

