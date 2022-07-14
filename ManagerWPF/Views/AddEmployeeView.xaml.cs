using MahApps.Metro.Controls;
using ManagerWPF.Models.Wrappers;
using ManagerWPF.ViewModels;

namespace ManagerWPF.Views
{
    /// <summary>
    /// Interaction logic for AddEmployee.xaml
    /// </summary>
    public partial class AddEmployeeView : MetroWindow
    {
        public AddEmployeeView(EmployeeWrapper employee = null)
        {
            InitializeComponent();
            DataContext = new AddEmployeeViewModel(employee);
        }
    }
}
