using PnPManager.Essentials;

namespace PnPManager.ActionBoard.Model
{
  public class Armor : NotifyBase
  {

    public int Toughness
    {
      get { return Get<int>(); }
      set { Set(value); }
    }

    public int MagicResist
    {
      get { return Get<int>(); }
      set { Set(value); }
    }

    public string Strenght
    {
      get { return Get<string>(); }
      set { Set(value); }
    }

    public string Handycap
    {
      get { return Get<string>(); }
      set { Set(value); }
    }

  }
}
