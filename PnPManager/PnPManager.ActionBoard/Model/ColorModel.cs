using PnPManager.Essentials;
using System.Windows.Media;

namespace PnPManager.ActionBoard.Model
{
  public class ColorModel : NotifyBase
  {

    public bool IsChecked
    {
      get { return Get<bool>(); }
      set { Set(value); }
    }

    public string Name
    {
      get { return Get<string>(); }
      set { Set(value); }
    }

    public SolidColorBrush Background
    {
      get { return Get<SolidColorBrush>(); }
      set { Set(value); }
    }

    public ColorModel(string name, Color color)
    {
      IsChecked = false;
      Name = name;
      Background = new SolidColorBrush(color);
    }
  }
}
