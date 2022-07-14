using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using ManagerWPF.Command;
using ManagerWPF.Models;
using ManagerWPF.Models.Wrappers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace ManagerWPF.ViewModels
{
    public class DismissEmployeeViewModel : BaseViewModel
    {
        private Repository _repository = new Repository();

        private IDialogCoordinator dialogCoordinator;

        public DismissEmployeeViewModel(IDialogCoordinator instance, EmployeeWrapper employee)
        {
            dialogCoordinator = instance;

            Employee = employee;

            CloseCommand = new RelayCommand(Close);
            ConfirmCommand = new AsyncRelayCommand(Confirm);
        }

        public ICommand CloseCommand { get; set; }
        public ICommand ConfirmCommand { get; set; }

        private EmployeeWrapper _employee;

        public EmployeeWrapper Employee
        {
            get { return _employee; }
            set
            {
                _employee = value;
                OnPropertyChanged();
            }
        }

        private async Task Confirm(object obj)
        {
            if (!Employee.IsValidDismiss)
                return;

            var dialog = await dialogCoordinator.ShowMessageAsync(this, "Usuwanie Pracownika", $"Czy na pewno chcesz zwolnić pracownika?", MessageDialogStyle.AffirmativeAndNegative);

            if (dialog != MessageDialogResult.Affirmative)
                return;

            _repository.DismissEmployee(Employee);

            CloseWindow(obj as Window);
        }

        private void Close(object obj)
        {
            CloseWindow(obj as Window);
        }

        private void CloseWindow(Window window)
        {
            window.Close();
        }
    }
}
