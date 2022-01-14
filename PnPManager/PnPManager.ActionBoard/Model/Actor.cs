using PnPManager.ActionBoard.Model.Actions;
using PnPManager.Essentials;
using System;
using System.Collections.ObjectModel;

namespace PnPManager.ActionBoard.Model
{
  public class Actor : NotifyBase
  {
    public string Name
    {
      get { return Get<string>(); }
      set { Set(value); }
    }

    public string Description
    {
      get { return Get<string>(); }
      set { Set(value); }
    }

    public int ActionPoints
    {
      get { return Get<int>(); }
      set { Set(value); }
    }


    public ObservableCollection<Weapon> Weapons
    {
      get { return Get<ObservableCollection<Weapon>>(); }
      set { Set(value); }
    }

    public ObservableCollection<Armor> Armor
    {
      get { return Get<ObservableCollection<Armor>>(); }
      set { Set(value); }
    }


    public ObservableCollection<AttributeBase> Attributes
    {
      get { return Get<ObservableCollection<AttributeBase>>(); }
      set { Set(value); }
    }


    public ObservableCollection<AttackAction> AttackActions
    {
      get { return Get<ObservableCollection<AttackAction>>(); }
      set { Set(value); }
    }

    public ObservableCollection<DefenseAction> DefenseActions
    {
      get { return Get<ObservableCollection<DefenseAction>>(); }
      set { Set(value); }
    }

    public ObservableCollection<MoveAction> MoveActions
    {
      get { return Get<ObservableCollection<MoveAction>>(); }
      set { Set(value); }
    }

    public ObservableCollection<Action> SpecialActions
    {
      get { return Get<ObservableCollection<Action>>(); }
      set { Set(value); }
    }

    public Actor()
    {
      Weapons = new ObservableCollection<Weapon>();
      Armor = new ObservableCollection<Armor>();
      Attributes = new ObservableCollection<AttributeBase>();
      AttackActions = new ObservableCollection<AttackAction>();
      DefenseActions = new ObservableCollection<DefenseAction>();
      MoveActions = new ObservableCollection<MoveAction>();
      SpecialActions = new ObservableCollection<Action>();
    }

  }
}
