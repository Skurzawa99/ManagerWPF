   M S B A M L   `   `   `  ����T  PMahApps.Metro, Version=2.0.0.0, Culture=neutral, PublicKeyToken=51482d6f650b2b3fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	   E AManagerWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:ManagerWPF.ViewsManagerWPF.Views 5   	   !   ManagerWPF.Views.MainWindow   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Kmah;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	   0localclr-namespace:ManagerWPF.Views     5   	   _ [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a3i+http://schemas.microsoft.com/xaml/behaviors  5   	     � WindowStartupLocation$  CenterScreen=�5
   	    � Title$ Manager��5   	   $	��450��6   $	��800��6&   *  $Microsoft.Xaml.Behaviors.Interaction   Triggers 5      +  %Microsoft.Xaml.Behaviors.EventTrigger  5   
      	EventName$ Loaded��6   *  $Microsoft.Xaml.Behaviors.TriggerBase   Actions. 5      2  ,Microsoft.Xaml.Behaviors.InvokeCommandAction     Command 6$   �� *LoadedWindowCommand+5      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $��	Zatrudnij��5      $��25��5      $	��100��5      $��5q�5      ��5      �� *ToEmployeeCommand+5      �� 5!      $��Zwolnij��5"      $��25��5%      $	��100��5&      $��5q�5'      ��5#      �� *DismissCommand+��5$      �� *SelectedEmployee+5'      �� 5)      $��Edytuj��5*      $��25��5-      $	��100��5.      $��5q�5/      ��5+      �� *EditCommand+��5,      �� *SelectedEmployee+5/      �� 51       �� DisplayMemberPath$
 Name��54      	 �� SelectedValuePath$	 Id��55      $��25��56      $	��110��57      $��5q�58      ��52      �� *Groups+
 �� SelectedValue
 53      �� *SelectedGroupId+58      �� 5:      $��	Odśwież��5<      $��25��5=      $	��100��5>      $��5q�5?      ��5;      �� *RefreshEmployeeCommand+5?      �� 5A      $��
Ustawienia��5C      $��25��5D      $	��100��5E      $��5q�5F      ��5B      �� *PropertiesCommand+5F      5G      &   System.Windows.Controls.DataGrid  5I   
   $��1��5J      $��5q�5K         CanUserAddRows .     
IsReadOnly .    SelectionMode$ Single=�5P         AutoGenerateColumns .  ��5L      �� *	Employees+ �� SelectedItem 5M      �� *SelectedEmployee+   Columns 5R      0  *System.Windows.Controls.DataGridTextColumn  5S      ,  &System.Windows.Controls.DataGridColumn   
Visibility$ Hidden=�6D      Width5  /System.Windows.Controls.DataGridLengthConverter$
 Auto 6X   1	  +System.Windows.Controls.DataGridBoundColumn 	  Binding 6%   �� *
EmployeeId+6X     5T         Header$ Imię��6C   $
 Auto 6Q    6%   �� *	FirstName+6Q     5U      $ Nazwisko��6B   $
 Auto 6T    6%   �� *
LastName+6T     5V      $ Uwagi��6B   $ * 6Q    6%   �� *
Comments+6Q     5W      $ Data Zatrudnienia��6H   $
 Auto 6c    6%   �� *DateToEmployee+6c     5X      $ Data Zwolnienia��6E   $
 Auto 6^    6%   �� *DateDismiss+6^     5Y      $ Zarobki��6?   $
 Auto 6P    6%   �� *Money+6P     5Z      $ Hidden=�6A   $
 Auto 6U    6%   �� *	GroupId+6U   5\      5^      5_      