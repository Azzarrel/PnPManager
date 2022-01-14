using PnPManager.ActionBoard.ViewModel;
using System.Windows;

namespace PnPManager.ActionBoard
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      DataContext = new MainWindowViewModel();
      InitializeComponent();
    }

  }
}
