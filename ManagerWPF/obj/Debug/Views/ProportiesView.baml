   M S B A M L   `   `   `  ����T  PMahApps.Metro, Version=2.0.0.0, Culture=neutral, PublicKeyToken=51482d6f650b2b3fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	   E AManagerWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:ManagerWPF.ViewsManagerWPF.Views 5   	   %   ManagerWPF.Views.ProportiesView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Kmah;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	   0localclr-namespace:ManagerWPF.Views     5   	   -   5        $��PropertiesWindow��5
   	     � WindowStartupLocation$  CenterScreen=�5	   	    � Title$ 
Ustawienia��5   	   $	��250��6   $	��350��6)   .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      .+�5   
   �� $��1��6   $��Adres serwera:��6   $��5q�66   �� 5   
   $��1��6�   $��1��6�   $��5q�6�   ��6   �� *UserProporties.SerwerAdress+ �� UpdateSourceTrigger$ PropertyChanged=� �� ValidatesOnDataErrors . 6�   �� 5   
   $��2��6   $��Nazwa serwera:��6   $��5q�66   �� 5   
   $��1��6~   $��2��6�   $��5q�6�   ��6   �� *UserProporties.SerwerName+$ PropertyChanged=� . 6�   �� 5!   
   $��3��6   $��Nazwa bazy danych:��6   $��5q�6:   �� 5"   
   $��1��6�   $��3��6�   $��5q�6�   ��6   �� *UserProporties.DatabaseName+$ PropertyChanged=� . 6�   �� 5$   
   $��4��6   $��Użytkownik:��6   $��5q�63   �� 5%   
   $��1��6|   $��4��6�   $��5q�6�   ��6   �� *UserProporties.UserName+$ PropertyChanged=� . 6�   �� 5'   
   $��5��6   $��Hasło:��6   $��5q�6.   �� 5(   
   $��1��6�   $��5��6�   $��5q�6�   ��6   �� *UserProporties.UserPassword+$ PropertyChanged=� . 6�   �� 5*   
    �� Orientation$ 
Horizontal=�6   $��6��6.   $��1��6;   $��Right=�6K   .+�5+      �� $��Anuluj��6p   $	��100��6�   $��25��6�   $��5q�6�   ��6   �� *CloseCommand+��66   ��  �� ElementName$ PropertiesWindow��6�   �� 5,      $��Akceptuj��6r   $	��100��6�   $��25��6�   $��5q�6�   ��6   �� *ConfirmCommand+��68   �� $ PropertiesWindow��6�   5-      5/      50      