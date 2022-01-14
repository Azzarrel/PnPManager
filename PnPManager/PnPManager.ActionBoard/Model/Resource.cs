using PnPManager.Essentials;

namespace PnPManager.ActionBoard.Model.Actions
{
  public class Resource : AttributeBase
  { 

    public int CurrentValue
    {
      get { return Get<int>(); }
      set { Set(value); }
    }
  }
}
