   M S B A M L   `   `   `  ���� T  PMahApps.Metro, Version=2.0.0.0, Culture=neutral, PublicKeyToken=51482d6f650b2b3fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  E AManagerWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:ManagerWPF.ViewsManagerWPF.Views !   ManagerWPF.Views.MainWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     Kmah;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     0localclr-namespace:ManagerWPF.Views     _ [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a3i+http://schemas.microsoft.com/xaml/behaviors    � WindowStartupLocation$  CenterScreen=� � Title$ Manager��$	��450��$	��800��*  $Microsoft.Xaml.Behaviors.Interaction   Triggers +  %Microsoft.Xaml.Behaviors.EventTrigger     	EventName$ Loaded��*  $Microsoft.Xaml.Behaviors.TriggerBase   Actions. 2  ,Microsoft.Xaml.Behaviors.InvokeCommandAction     Command �� *LoadedWindowCommand+.���  � RowDefinitions �� $
��Auto ��� $��* �.+���  �� Orientation$ 
Horizontal=�.+��� $��	Zatrudnij��$��25��$	��100��$��5q����� *ToEmployeeCommand+�� $��Zwolnij��$��25��$	��100��$��5q����� *DismissCommand+���� *SelectedEmployee+�� $��Edytuj��$��25��$	��100��$��5q����� *EditCommand+���� *SelectedEmployee+��  �� DisplayMemberPath$
 Name��	 �� SelectedValuePath$	 Id��$��25��$	��110��$��5q����� *Groups+
 �� SelectedValue
 �� *SelectedGroupId+�� $��	Odśwież��$��25��$	��100��$��5q����� *RefreshEmployeeCommand+�� $��
Ustawienia��$��25��$	��100��$��5q����� *PropertiesCommand+&   System.Windows.Controls.DataGrid  $��1��$��5q�   CanUserAddRows .     
IsReadOnly .    SelectionMode$ Single=�   AutoGenerateColumns .  ���� *	Employees+ �� SelectedItem �� *SelectedEmployee+   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   
Visibility$ Hidden=�   Width5  /System.Windows.Controls.DataGridLengthConverter$
 Auto 1	  +System.Windows.Controls.DataGridBoundColumn 	  Binding �� *
EmployeeId+     Header$ Imię��$
 Auto  �� *	FirstName+  $ Nazwisko��$
 Auto  �� *
LastName+  $ Uwagi��$ *  �� *
Comments+  $ Data Zatrudnienia��$
 Auto  �� *DateToEmployee+  $ Data Zwolnienia��$
 Auto  �� *DateDismiss+  $ Zarobki��$
 Auto  �� *Money+  $ Hidden=�$
 Auto  �� *	GroupId+