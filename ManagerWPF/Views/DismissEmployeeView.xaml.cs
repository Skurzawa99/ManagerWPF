﻿using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using ManagerWPF.Models.Wrappers;
using ManagerWPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ManagerWPF.Views
{
    /// <summary>
    /// Interaction logic for DismissEmployeeView.xaml
    /// </summary>
    public partial class DismissEmployeeView : MetroWindow
    {
        public DismissEmployeeView(EmployeeWrapper employee)
        {
            InitializeComponent();
            DataContext = new DismissEmployeeViewModel(DialogCoordinator.Instance, employee);
        }
    }
}
