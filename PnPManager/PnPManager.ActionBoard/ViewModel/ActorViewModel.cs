using PnPManager.ActionBoard.Model;
using PnPManager.Essentials;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace PnPManager.ActionBoard.ViewModel
{
  public class ActorViewModel : NotifyBase
  {

    public ObservableCollection<Actor> Actors
    {
      get { return Get<ObservableCollection<Actor>>(); }
      set { Set(value); }
    }

    public Actor SelectedActor
    {
      get { return Get<Actor>(); }
      set
      {
        Set(value);
      }
    }

    public ActorViewModel(ObservableCollection<Actor> actors)
    {
      Actors = actors;
    }

  }
}
