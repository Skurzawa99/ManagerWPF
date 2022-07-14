using ManagerWPF.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerWPF.Models
{
    public class UserProporties : IDataErrorInfo
    {
        private bool _isServerAdressValid;
        private bool _isSerwerNameValid;
        private bool _isDatabaseNameValid;
        private bool _isUserNameValid;
        private bool _isUserPasswordValid;

        public string SerwerAdress
        {
            get
            {
                return Settings.Default.SerwerAdress;
            }
            set
            {
                Settings.Default.SerwerAdress = value;
            }
        }
        public string SerwerName
        {
            get
            {
                return Settings.Default.SerwerName;
            }
            set
            {
                Settings.Default.SerwerName = value;
            }
        }
        public string DatabaseName
        {
            get
            {
                return Settings.Default.DatabaseName;
            }
            set
            {
                Settings.Default.DatabaseName = value;
            }
        }

        public string UserName
        {
            get
            {
                return Settings.Default.UserName;
            }
            set
            {
                Settings.Default.UserName = value;
            }
        }
        public string UserPassword
        {
            get
            {
                return Settings.Default.UserPassword;
            }
            set
            {
                Settings.Default.UserPassword = value;
            }
        }
        internal void Save()
        {
            Settings.Default.Save();
        }

        public string this[string columnName]
        {
            get
            {
                switch (columnName)
                {
                    case nameof(SerwerAdress):
                        if (string.IsNullOrWhiteSpace(SerwerAdress))
                        {
                            Error = "Pole Adres serwera jest wymagane";
                            _isServerAdressValid = false;
                        }
                        else
                        {
                            Error = string.Empty;
                            _isServerAdressValid = true;
                        }
                        break;
                    case nameof(SerwerName):
                        if (string.IsNullOrWhiteSpace(SerwerName))
                        {
                            Error = "Pole nazwa  serwera jest wymagane";
                            _isSerwerNameValid = false;
                        }
                        else
                        {
                            Error = string.Empty;
                            _isSerwerNameValid = true;
                        }
                        break;
                    case nameof(DatabaseName):
                        if (string.IsNullOrWhiteSpace(DatabaseName))
                        {
                            Error = "Pole nazwa bazy danych jest wymagane";
                            _isDatabaseNameValid = false;
                        }
                        else
                        {
                            Error = string.Empty;
                            _isDatabaseNameValid = true;
                        }
                        break;
                    case nameof(UserName):
                        if (string.IsNullOrWhiteSpace(UserName))
                        {
                            Error = "Pole użytkownik serwera jest wymagane";
                            _isUserNameValid = false;
                        }
                        else
                        {
                            Error = string.Empty;
                            _isUserNameValid = true;
                        }
                        break;
                    case nameof(UserPassword):
                        if (string.IsNullOrWhiteSpace(UserPassword))
                        {
                            Error = "Pole hasło serwera jest wymagane";
                            _isUserPasswordValid = false;
                        }
                        else
                        {
                            Error = string.Empty;
                            _isUserPasswordValid = true;
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
                return _isServerAdressValid &&
                    _isSerwerNameValid &&
                    _isDatabaseNameValid &&
                    _isUserNameValid &&
                    _isUserPasswordValid;
            }
        }
    }
}
