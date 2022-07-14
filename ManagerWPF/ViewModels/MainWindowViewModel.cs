using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using ManagerWPF.Command;
using ManagerWPF.Models;
using ManagerWPF.Models.Domains;
using ManagerWPF.Models.Wrappers;
using ManagerWPF.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace ManagerWPF.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {
        private Repository _repository = new Repository();

        public MainWindowViewModel()
        {
            ToEmployeeCommand = new RelayCommand(AddEditEmployee);
            DismissCommand = new RelayCommand(Dismiss, CanDismissEditEmployee);
            EditCommand = new RelayCommand(AddEditEmployee, CanDismissEditEmployee);
            PropertiesCommand = new RelayCommand(PropertiesDatabase);
            RefreshEmployeeCommand = new RelayCommand(RefreshEmployees);
            LoadedWindowCommand = new RelayCommand(LoadedWindow);

            OpenLoginWindow();

            LoadedWindow(null);
        }

        public ICommand ToEmployeeCommand { get; set; }
        public ICommand DismissCommand { get; set; }
        public ICommand EditCommand { get; set; }
        public ICommand PropertiesCommand { get; set; }
        public ICommand RefreshEmployeeCommand { get; set; }
        public ICommand LoginWindowCommand { get; set; }
        public ICommand LoadedWindowCommand { get; set; }

        private ObservableCollection<EmployeeWrapper> _employees;

        public ObservableCollection<EmployeeWrapper> Employees
        {
            get { return _employees; }
            set 
            {
                _employees = value;
                OnPropertyChanged();
            }
        }

        private EmployeeWrapper _selectedEmployee;

        public EmployeeWrapper SelectedEmployee
        {
            get { return _selectedEmployee; }
            set
            { 
                _selectedEmployee = value;
                OnPropertyChanged();
            }
        }

        private int _selectedGroupId;

        public int SelectedGroupId
        {
            get { return _selectedGroupId; }
            set
            {
                _selectedGroupId = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<Group> _group;

        public ObservableCollection<Group> Groups
        {
            get { return _group; }
            set
            {
                _group = value;
                OnPropertyChanged();
            }
        }

        private void InitGroup()
        {
            var groups = _repository.GetGroups();
            groups.Insert(0, new Group { Id = 0, Name = "Wszyscy" });

            Groups = new ObservableCollection<Group>(groups);

            SelectedGroupId = 0;
        }

        private void AddEditEmployee(object obj)
        {
            var _addEditEmployeeWindow = new AddEmployeeView(obj as EmployeeWrapper);
            _addEditEmployeeWindow.Closed += addEditEmployeeWindow_Closed;
            _addEditEmployeeWindow.ShowDialog();
        }

        private void addEditEmployeeWindow_Closed(object sender, EventArgs e)
        {
            RefreshManager();
        }

        private void Dismiss(object obj)
        {
            var _dismissEmployeeWindow = new DismissEmployeeView(obj as EmployeeWrapper);
            _dismissEmployeeWindow.Closed += _dismissEmployeeWindow_Closed;
            _dismissEmployeeWindow.ShowDialog();
        }

        private void _dismissEmployeeWindow_Closed(object sender, EventArgs e)
        {
            RefreshManager();
        }

        private void RefreshEmployees(object obj)
        {
            RefreshManager();
        }

        private bool CanDismissEditEmployee(object obj)
        {
            return SelectedEmployee != null;
        }

        private void RefreshManager()
        {
            Employees = new ObservableCollection<EmployeeWrapper>(
            _repository.GetEmployees(SelectedGroupId));     
        }

        private void PropertiesDatabase(object obj)
        {
            ChangeProperties();
        }

        private void ChangeProperties()
        {
            var addProportiesWindow = new ProportiesView(true);
            addProportiesWindow.Closed += addProportiesWindow_Closed;
            addProportiesWindow.ShowDialog();
        }

        private void addProportiesWindow_Closed(object sender, EventArgs e)
        {
            RefreshManager();
        }

        private async void LoadedWindow(object arg)
        {
            if (!IsValidConnectionToDatabase())
            {
                var metroWindow = Application.Current.MainWindow as MetroWindow;
                var dialog = await metroWindow.ShowMessageAsync("Błąd połączenia",
                    $"Nie można połączyć z bazą danych. Czy chcesz zmienić ustawienia?",
                    MessageDialogStyle.AffirmativeAndNegative);

                if (dialog == MessageDialogResult.Negative)
                {
                    Application.Current.Shutdown();
                }
                else
                {
                    var propertiesWindow = new ProportiesView(false);
                    propertiesWindow.ShowDialog();
                }
            }
            else
            {
                RefreshManager();
                InitGroup();
            }
        }

        private bool IsValidConnectionToDatabase()
        {
            try
            {
                using (var context = new ApplicationDbContext())
                {
                    context.Database.Connection.Open();
                    context.Database.Connection.Close();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void OpenLoginWindow()
        {
            var addLoginWindow = new LoginView();
            addLoginWindow.Closed += addLoginWindow_Closed;
            addLoginWindow.ShowDialog();
        }

        private void addLoginWindow_Closed(object sender, EventArgs e)
        {
            
        }
    }
}
