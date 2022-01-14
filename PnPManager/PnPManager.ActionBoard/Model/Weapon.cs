using PnPManager.Essentials;

namespace PnPManager.ActionBoard.Model
{
  public class Weapon : NotifyBase
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

    public string Slice
    {
      get { return Get<string>(); }
      set { Set(value); }
    }

    public string Skill
    {
      get { return Get<string>(); }
      set { Set(value); }
    }

    public string Impulse
    {
      get { return Get<string>(); }
      set { Set(value); }
    }

    public string Magic
    {
      get { return Get<string>(); }
      set { Set(value); }
    }

    public string ArmorPen
    {
      get { return Get<string>(); }
      set { Set(value); }
    }

  }
}
