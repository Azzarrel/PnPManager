namespace PnPManager.ActionBoard.Model.Actions
{
  public class DefenseAction : ActionBase
  {
    public string Skill
    {
      get { return Get<string>(); }
      set { Set(value); }
    }



  }
}
