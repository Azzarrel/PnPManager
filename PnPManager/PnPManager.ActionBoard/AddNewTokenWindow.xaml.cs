using System.Windows;

namespace PnPManager.ActionBoard
{
  /// <summary>
  /// Interaction logic for AddNewTokenWindow.xaml
  /// </summary>
  public partial class AddNewTokenWindow : Window
  {
    public AddNewTokenWindow(object viewModel)
    {
      DataContext = viewModel;
      InitializeComponent();
    }
  }
}
