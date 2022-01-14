using PnPManager.Essentials;

namespace PnPManager.ActionBoard.Model.Actions
{
  public class AttributeBase : NotifyBase
  {
    public string Tag
    {
      get { return Get<string>(); }
      set { Set(value); }
    }

    public string Name
    {
      get { return Get<string>(); }
      set { Set(value); }
    }

    public int Value
    {
      get { return Get<int>(); }
      set { Set(value); }
    }

    public string Color
    {
      get { return Get<string>(); }
      set { Set(value); }
    }

  }
}
