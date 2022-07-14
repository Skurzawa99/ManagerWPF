using ManagerWPF.Command;
using ManagerWPF.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace ManagerWPF.ViewModels
{
    public class ProportiesViewModel : BaseViewModel
    {
        private UserProporties _userProporties;
        private readonly bool _canCloseWindow;

        public ProportiesViewModel(bool canCloseWindow)
        {
            CloseCommand = new RelayCommand(Close);
            ConfirmCommand = new RelayCommand(Confirm);
            _userProporties = new UserProporties();
            _canCloseWindow = canCloseWindow;
        }

        public ICommand CloseCommand { get; set; }
        public ICommand ConfirmCommand { get; set; }

        public UserProporties UserProporties
        {
            get { return _userProporties; }
            set
            {
                _userProporties = value;
                OnPropertyChanged();
            }
        }


        private void Close(object obj)
        {
            if (_canCloseWindow)
                CloseWindow(obj as Window);
            else
                Application.Current.Shutdown();
        }

        private void Confirm(object obj)
        {
            if (!UserProporties.IsValid)
                return;

            UserProporties.Save();
            RestartApplication();
        }

        private void RestartApplication()
        {
            Process.Start(Application.ResourceAssembly.Location);
            Application.Current.Shutdown();
        }

        private void CloseWindow(Window window)
        {
            window.Close();
        }
    }
}
