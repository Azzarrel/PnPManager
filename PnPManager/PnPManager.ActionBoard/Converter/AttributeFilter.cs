using PnPManager.ActionBoard.Model.Actions;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace PnPManager.ActionBoard.Converter
{
  public class AttributeFilter : IValueConverter
  {
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
      if(value is IEnumerable<AttributeBase> attributes)
      {
        return attributes.Where(a => a.GetType() == typeof(AttributeBase));
      }
      return new List<AttributeBase>();
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
      throw new NotImplementedException();
    }
  }
}
