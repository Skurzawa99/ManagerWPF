   M S B A M L   `   `   `  ����T  PMahApps.Metro, Version=2.0.0.0, Culture=neutral, PublicKeyToken=51482d6f650b2b3fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	   E AManagerWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:ManagerWPF.ViewsManagerWPF.Views 5   	   &    ManagerWPF.Views.AddEmployeeView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Kmah;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	   0localclr-namespace:ManagerWPF.Views     5   	   -   5        $��AddEditEmployeeWindow��5
   	     � WindowStartupLocation$  CenterScreen=�5	   	    � Title$ Zatrudnienie pracownika��5   	   $	��350��6)   $	��333��66   .��5      �  � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� $	��Id:��5      $��5q�5      y�5      �� *
IsUpdate+    BooleanToVisibilityConverter �� 	Converter# [  5      �� 5    
   $��1��5"       �� 
IsReadOnly . $��5q�5%      y�5!      �� *
IsUpdate+# [  ��5$      �� *Employee.EmployeeId+5%      �� 5'   
   $��Imie:��5(      $��1��5)      $��5q�5*      �� 5+   
   $��1��5,      $��1��5-      $��5q�5/      ��5.      �� *Employee.FirstName+ �� UpdateSourceTrigger$ PropertyChanged=� �� ValidatesOnDataErrors . 5/      �� 51   
   $��	Nazwisko:��52      $��2��53      $��5q�54      �� 55   
   $��2��56      $��1��57      $��5q�59      ��58      �� *Employee.LastName+$ PropertyChanged=� . 59      �� 5;   
   $��Data zatrudnienia:��5<      $��3��5=      $��5q�5>      (  "System.Windows.Controls.DatePicker  5?   
   $��3��5A      $��1��5B      $��5q�5C         SelectedDateFormat$ Short=�5D      	   SelectedDate	 5@      �� *Employee.DateToEmployee+$ PropertyChanged=� . 5D      �� 5F   
   $��Zarobki:��5G      $��4��5H      $��5q�5I      *   $MahApps.Metro.Controls.NumericUpDown  5K   
   $��4��5M      $��1��5N      $��5q�5O      
   Value
 5L      �� *Employee.Money+5O      �� 5Q   
   $��Uwagi:��5R      $��5��5S      $��5q�5T      �� 5U   
   $��5��5V      $��1��5W       �� TextWrapping$
 Wrap=�5X       �� AcceptsReturn . $��5q�5[      ��5Z      �� *Employee.Comments+5[      �� 5]   
   $��Data zwolnienia:��5_      $��6��5`      $��5q�5a      y�5^      �� *IsUpdateDismiss+# [  5a        5b   
   $��6��5e      $��1��5f      $��5q�5g      y�5c      �� *IsUpdateDismiss+# [  	 5d      �� *Employee.DateDismiss+$ PropertyChanged=� . 5g      �� 5i   
    �� Orientation$ 
Horizontal=�6   $��1��6.   $��7��6>   $��Right=�6K   .+�5j      �� $��Anuluj��6   $��25��6�   $	��100��6�   $��5q�6�   ��6&   �� *CloseCommand+��6G   ��  �� ElementName$ AddEditEmployeeWindow��6�   �� 5k      $��Akceptuj��6   $��25��6�   $	��100��6�   $��5q�6�   ��6(   �� *ConfirmCommand+��6L   �� $ AddEditEmployeeWindow��6�   5l      5m      5n      