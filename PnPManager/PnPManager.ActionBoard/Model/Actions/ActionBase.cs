using PnPManager.Essentials;

namespace PnPManager.ActionBoard.Model
{
  public class ActionBase : NotifyBase
  {
    public string Name
    {
      get { return Get<string>(); }
      set { Set(value); }
    }
    public string ActionPoints
    {
      get { return Get<string>(); }
      set { Set(value); }
    }

    public string Stamina
    {
      get { return Get<string>(); }
      set { Set(value); }
    }

  }
}
