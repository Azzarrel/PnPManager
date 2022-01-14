using PnPManager.ActionBoard.Model;
using PnPManager.ActionBoard.Model.Actions;
using PnPManager.Essentials;
using System.Collections.ObjectModel;

namespace PnPManager.ActionBoard.ViewModel
{
  public class MainWindowViewModel : NotifyBase
  {

    public ActorViewModel ActorViewModel
    {
      get { return Get<ActorViewModel>(); }
      set { Set(value); }
    }

    public Actor SelectedActor
    {
      get { return Get<Actor>(); }
      set 
      { 
        Set(value);
        ActorViewModel.SelectedActor = value;
      }
    }

    public ObservableCollection<Actor> Actors
    {
      get { return Get<ObservableCollection<Actor>>(); }
      set { Set(value); }
    }

    public MainWindowViewModel()
    {
      Actors = new ObservableCollection<Actor>();
      ActorViewModel = new ActorViewModel(Actors);

      AddDummyData();
    }

    public void AddDummyData()
    {
      Actor goblin = new Actor();
      goblin.Name = "Boblin";
      goblin.Description = "Hello World";
      Weapon dagger = new Weapon();
      dagger.Name = "Dagger";
      dagger.ActionPoints = "6";
      dagger.Skill = "12";
      dagger.Slice = "6+1D6";
      dagger.Stamina = "2";
      goblin.Weapons.Add(dagger);
      Resource health = new Resource();
      health.Tag = "HP";
      health.Name = "Health Points";
      health.Value = 20;
      health.CurrentValue = -5;
      health.Color = "#FFAA0000";
      goblin.Attributes.Add(health);
      Resource stamina = new Resource();
      stamina.Tag = "ST";
      stamina.Name = "Stamina";
      stamina.Value = 44;
      stamina.CurrentValue = 20;
      stamina.Color = "#FF00BB00";
      goblin.Attributes.Add(stamina);
      Resource mana = new Resource();
      mana.Tag = "MA";
      mana.Name = "Mana";
      mana.Value = 8;
      mana.CurrentValue = 8;
      mana.Color = "#FF0000FF";
      goblin.Attributes.Add(mana);
      AttributeBase agility = new AttributeBase();
      agility.Tag = "AG";
      agility.Name = "Agility";
      agility.Value = 12;
      goblin.Attributes.Add(agility);
      foreach(Weapon w in goblin.Weapons)
      {
        goblin.AttackActions.Add(new AttackAction(w));
        goblin.DefenseActions.Add(new BlockAction(w));
      }

      Actors.Add(goblin);
      SelectedActor = goblin;
    }



  }
}
