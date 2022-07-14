using MahApps.Metro.Controls.Dialogs;
using ManagerWPF.Command;
using ManagerWPF.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace ManagerWPF.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private IDialogCoordinator dialogCoordinator;

        public LoginViewModel(IDialogCoordinator instance)
        {
            dialogCoordinator = instance;

            ConfirmCommand = new AsyncRelayCommand(Confirm);
            CloseCommand = new RelayCommand(Close);
        }

        public ICommand ConfirmCommand { get; set; }
        public ICommand CloseCommand { get; set; }

        private string _login;

        public string Login
        {
            get { return _login; }
            set 
            { 
                _login = value;
                OnPropertyChanged();
            }
        }

        private string _password;

        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                OnPropertyChanged();
            }
        }

        private async Task Confirm(object obj)
        {

            if(Password != "a" || Login != "admin")
            {
                await dialogCoordinator.ShowMessageAsync(this, "Błąd", $"Błędne dane", MessageDialogStyle.Affirmative);            
                return;
            }

            CloseWindow(obj as Window);
        }

        private void CloseWindow(Window window)
        {
            window.Close();
        }

        private void Close(object obj)
        {
            Application.Current.Shutdown();
        }
    }
}
