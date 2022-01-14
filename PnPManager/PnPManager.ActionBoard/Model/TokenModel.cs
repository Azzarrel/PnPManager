using PnPManager.Essentials;
using System.Windows.Media;

namespace PnPManager.ActionBoard.Model
{
  public class TokenModel : NotifyBase
  {
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

    public int Value
    {
      get { return Get<int>(); }
      set { Set(value); }
    }

    public int Default1
    {
      get { return Get<int>(); }
      set { Set(value); }
    }

    public int Default2
    {
      get { return Get<int>(); }
      set { Set(value); }
    }

    public int Default3
    {
      get { return Get<int>(); }
      set { Set(value); }
    }


    public int ActionPoints
    {
      get { return Get<int>(); }
      set { Set(value); }
    }
  }
}
