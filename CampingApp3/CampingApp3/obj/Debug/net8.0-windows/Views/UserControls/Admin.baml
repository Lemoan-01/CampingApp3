   M S B A M L   `   `   `  ����F  BCampingApp3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:CampingApp3.Views.UserControlsCampingApp3.Views.UserControls  5      ?$clr-namespace:CampingApp3.ViewModelsCampingApp3.ViewModels  5      *    $CampingApp3.Views.UserControls.Admin   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      >local,clr-namespace:CampingApp3.Views.UserControls     5      3vm$clr-namespace:CampingApp3.ViewModels     5        � 	Resources  5
       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $- '/CampingApp3;component/Styles/Page.xaml?�6%   %    5       � DataContext 5      $  CampingApp3.ViewModels.AdminVM  5   
   .��5      � ���#20262B.+�5   
   �� $��Administration��6   
�������$��Century Gothic)�6=   $��24(�6Y   $��10,10,10,506q�6g   �� 5   
   $W��QManage your reservations and dashboard efficiently with administrative privileges��6   
�������$��Century Gothic)�6�   $��14(�6�   $��10,44,10,483q�6�   �� 5   
   -   5         ��Name$ lblPID��5      $��	Place ID:��6    $
��Left=�64   $	��Top=�6O   $��	10,87,0,0q�6g   
�������$��Century Gothic)�6�   $��18(�6�   �� 5   
   -   5         ��Name$ txtbPID��5      $
��Left=�6#   $��
134,90,0,0q�6>    �� TextWrapping$
 Wrap=�6R   $��Enter placeID��6f   $	��Top=�6{   $	��230��6�   ���#7F7F7F$��Century Gothic)�6�   $��16(�6�   $��26��6:  �� 5   
   -   5        $ lblPrice��5      $��
New price:��6"   $
��Left=�67   $	��Top=�6R   $��
10,137,0,0q�6j   
�������$��Century Gothic)�6�   $��18(�6�   �� 5   
   -   5        $ 	txtbPrice��5      $
��Left=�6%   $��134,143,0,0q�6@   $
 Wrap=�6U   $��Enter new price��6i   $	��Top=�6�   $	��230��6�   ���#7F7F7F$��Century Gothic)�6�   $��16(�6�   $��26��6?  �� 5   
   -   5         ��Name$ btnPrice��5      $��Update��6#   $
��Left=�64   $��427,143,0,0q�6O   $	��Top=�6d   $	��158��6|   ���#2C9BFF
�������$��Century Gothic)�6�   $��18(�6�   6�   �� 5   
   -   5        $ lblBlock��5      $��Block place:��6"   $
��Left=�69   $	��Top=�6T   $��
10,222,0,0q�6l   
�������$��Century Gothic)�6�   $��18(�6�   �� 5    
   -   5        $ txtBlock��5       $
��Left=�6$   $��134,228,0,0q�6?   $
 Wrap=�6T   $��Enter placeID��6h   $	��Top=�6}   $	��230��6�   ���#7F7F7F$��Century Gothic)�6�   $��16(�6�   $��26��6<  (  "System.Windows.Controls.DatePicker  5!   
   -   5          Name$ EndDatePicker��5!      $
��Left=�6,   $��222,329,0,0q�6G   $	��Top=�6\   	 J� RenderTransformOrigin$	 0.316,-1.833&�6t   
 � Language$
 en-US�6�     5"   
   -	   5        $ StartDatePicker��5"      $��0,329,464,0q�6.   $	��Top=�6C   $
��Left=�6[   $	��142��6v   $
 en-US�6�   �� 5#   
   -
   5         ��Name$ lblDates��5#      $3��-Between which days must the place be blocked:��6&   $
��Left=�5$      $	��Top=�6'   $��
10,272,0,0q�5%      
�������$��Century Gothic)�5&      $��18(�6(   $	��239��5'      $��66��6   $
��Wrap=�6$   �� 5(   
   -   5        $ btnBlock��5(      $��Block��6#   $
��Left=�63   $��427,327,0,0q�6N   $	��Top=�6c   $	��158��6{   ���#2C9BFF
�������$��Century Gothic)�6�   $��18(�6�   6�   5+      5,      