namespace PnPManager.ActionBoard.Model.Actions
{
  public class AttackAction : ActionBase
  {


    #region Properties


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

    #endregion Properties

    #region Constructor




    public AttackAction()
    {

    }
    public AttackAction(Weapon weapon)
    {
      Name = $"Attack ({weapon.Name}) AP: {weapon.ActionPoints}";
      ActionPoints = weapon.ActionPoints;
      Stamina = weapon.Stamina;
      Slice = weapon.Slice;
      Skill = weapon.Skill;
      Impulse = weapon.Impulse;
      Magic = weapon.Magic;
      ArmorPen = weapon.ArmorPen;

    }
    public AttackAction(Weapon weapon, CombatAbility combatAbility)
    {
      Name = $"Attack ({weapon.Name}) AP: {weapon.ActionPoints}";
      ActionPoints = weapon.ActionPoints;
      Stamina = weapon.Stamina;
      Slice = weapon.Slice;
      Skill = weapon.Skill;
      Impulse = weapon.Impulse;
      Magic = weapon.Magic;
      ArmorPen = weapon.ArmorPen;

    }
    #endregion Constructor


  }
}
