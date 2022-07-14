using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using ManagerWPF.ViewModels;


namespace ManagerWPF.Views
{
    /// <summary>
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView : MetroWindow
    {
        public LoginView()
        {
            InitializeComponent();
            DataContext = new LoginViewModel(DialogCoordinator.Instance);
        }
    }
}
