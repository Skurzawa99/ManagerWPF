using MahApps.Metro.Controls;
using ManagerWPF.ViewModels;


namespace ManagerWPF.Views
{
    /// <summary>
    /// Interaction logic for PropertiesView.xaml
    /// </summary>
    public partial class ProportiesView : MetroWindow
    {
        public ProportiesView(bool canCloseWindow)
        {
            InitializeComponent();
            DataContext = new ProportiesViewModel(canCloseWindow);
        }
    }
}
