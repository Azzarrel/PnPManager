using PnPManager.ActionBoard.Model.Actions;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace PnPManager.ActionBoard.Converter
{
  public class SolidColorConvertere : IValueConverter
  {
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
      if(value is string s)
      {
        return new SolidColorBrush((Color)ColorConverter.ConvertFromString(s));
      }
      return new SolidColorBrush(Colors.Black);
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
      throw new NotImplementedException();
    }
  }
}
