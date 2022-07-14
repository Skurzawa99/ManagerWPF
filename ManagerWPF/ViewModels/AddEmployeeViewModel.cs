using ManagerWPF.Command;
using ManagerWPF.Models;
using ManagerWPF.Models.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace ManagerWPF.ViewModels
{
    public class AddEmployeeViewModel : BaseViewModel
    {
        private Repository _repository = new Repository();

        public AddEmployeeViewModel(EmployeeWrapper employee = null)
        {
            CloseCommand = new RelayCommand(Close);
            ConfirmCommand = new RelayCommand(Confirm);

            if (employee == null)
            {
                Employee = new EmployeeWrapper();
            }              
            else if (string.IsNullOrWhiteSpace(employee.DateDismiss))
            {
                Employee = employee;
                IsUpdate = true;
            }
            else
            {
                Employee = employee;
                IsUpdate = true;
                IsUpdateDismiss = true;
            }
                
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

        private bool _isUpdate;

        public bool IsUpdate
        {
            get { return _isUpdate; }
            set 
            { 
                _isUpdate = value;
                OnPropertyChanged();
            }
        }

        private bool _isUpdateDismiss;

        public bool IsUpdateDismiss
        {
            get { return _isUpdateDismiss; }
            set 
            { 
                _isUpdateDismiss = value;
                OnPropertyChanged();
            }
        }

        private void Confirm(object obj)
        {
            if (!Employee.IsValid)
                return;

            if (!IsUpdate)
            {
                Employee.Group.Id = 1;
                _repository.AddEmployee(Employee);
            }               
            else
            {
                _repository.UpdateEmployee(Employee);
            }                

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
