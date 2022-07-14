using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerWPF.Models.Wrappers
{
    public class EmployeeWrapper : IDataErrorInfo
    {
        public EmployeeWrapper()
        {
            Group = new GroupWrapper();
        }

        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        private string _dateToEployee;
        public string DateToEmployee 
        {
            get 
            {
                return _dateToEployee;
            } 
            set 
            {
                string[] date = value.Split(' ');
                _dateToEployee = date[0];
            }
        }

        private string _dateDismiss;
        public string DateDismiss 
        { 
            get
            {
                return _dateDismiss;
            }
            set
            {
                if(value != null)
                {
                    string[] date = value.Split(' ');
                    _dateDismiss = date[0];
                }            
            }
        }
        public decimal Money { get; set; }
        public string Comments { get; set; }
        public GroupWrapper Group { get; set; }

        private bool _isFirstNameValid;

        private bool _isLastNameValid;

        private bool _isDateToEmployee;

        private bool _isDateDismiss;


        public string this[string columnName]
        {
            get
            {
                switch (columnName)
                {
                    case nameof(FirstName):
                        if (string.IsNullOrWhiteSpace(FirstName))
                        {
                            Error = "Pole Imie jest wymagane.";
                            _isFirstNameValid = false;
                        }
                        else
                        {
                            Error = string.Empty;
                            _isFirstNameValid = true;
                        }
                        break;
                    case nameof(LastName):
                        if (string.IsNullOrWhiteSpace(LastName))
                        {
                            Error = "Pole Nazwisko jest wymagane.";
                            _isLastNameValid = false;
                        }
                        else
                        {
                            Error = string.Empty;
                            _isLastNameValid = true;
                        }
                        break;
                    case nameof(DateToEmployee):
                        if (string.IsNullOrWhiteSpace(DateToEmployee))
                        {
                            Error = "Pole Data Zatrudnienia jest wymagane.";
                            _isDateToEmployee = false;
                        }
                        else
                        {
                            Error = string.Empty;
                            _isDateToEmployee = true;
                        }
                        break;
                    case nameof(DateDismiss):
                        if (string.IsNullOrWhiteSpace(DateDismiss))
                        {
                            Error = "Pole Data Zwolnienia jest wymagane.";
                            _isDateDismiss = false;
                        }
                        else
                        {
                            Error = string.Empty;
                            _isDateDismiss = true;
                        }
                        break;
                    default:
                        break;
                }

                return Error;
            }
        }
        public string Error { get; set; }

        public bool IsValid
        {
            get
            {
                return _isLastNameValid && _isFirstNameValid && _isDateToEmployee;
            }
        }

        public bool IsValidDismiss
        {
            get
            {
                return _isDateDismiss;
            }
        }

    }
}
