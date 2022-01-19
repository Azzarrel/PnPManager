using PnPManager.Client.Essentials;
using PnPManager.Client.Login.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PnPManager.Client.Login.View
{
  /// <summary>
  /// Interaction logic for LoginWindow.xaml
  /// </summary>
  public partial class LoginWindow : Window
  {
    public NotifyBase ViewModel { get; private set; }

    public LoginWindow(LoginViewModel vm)
    {

      DataContext = ViewModel = vm;
      InitializeComponent();
    }
  }
}
