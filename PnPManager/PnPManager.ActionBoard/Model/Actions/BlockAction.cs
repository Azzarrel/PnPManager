namespace PnPManager.ActionBoard.Model.Actions
{
  public class BlockAction : DefenseAction
  {

    public BlockAction(Weapon weapon)
    {
      Name = $"Block {weapon.Name}";
      ActionPoints = weapon.ActionPoints;
      Stamina = weapon.Stamina;
      Skill = weapon.Skill;
    }

  }
}
