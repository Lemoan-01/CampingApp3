   M S B A M L   `   `   `  ����F  BCampingApp3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:CampingApp3.Views.UserControlsCampingApp3.Views.UserControls  5      *    $CampingApp3.Views.UserControls.Login   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      >local,clr-namespace:CampingApp3.Views.UserControls     5        � 	Resources  5	       �� MergedDictionaries �� Source�� 5
   
    5      �� 5      $- '/CampingApp3;component/Styles/Page.xaml?�6%   %    5      .��5      � ���#20262B � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��10q�6"   .+�5      �� $��Login��6   
�������$��Century Gothic)�68   $��24(�6T   �� 5      $>��8Please, log in to access your reservations and dashboard��6   $
��Left=�6X   $	��Top=�6s   
�������$��Century Gothic)�6�   $��14(�6�   $��0,5,0,0q�6�   5      �� 5   
   -   5         ��Name$ lblEmail��5      $��Email:��6"   $
��Left=�63   $��Center=�6N   $��	27,20,0,0q�6i   $��1��6|   
�������$��Century Gothic)�6�   $��18(�6�   �� 5    
   -   5         ��Name$ 	txtbEmail��5       $
��Left=�6%   $��
133,20,0,0q�6@   $��1��6T    �� TextWrapping$
 Wrap=�6a   $��Enter your email��6u   $��Center=�6�   $	��230��6�   ���#7F7F7F$��Century Gothic)�6�   $��14(�6�   6(  �� 5#   
   -   5        $ lblPassword��5#      $��	Password:��6%   $
��Left=�69   $��Center=�6T   $��	27,70,0,0q�6o   $��1��6�   
�������$��Century Gothic)�6�   $��18(�6�   G� 5$   
   -   5         G�Name$ pwboxPassword��5$      $
��Left=�6-   $��
133,70,0,0q�6H   $��1��6\   $��Center=�6i   $	��230��6�   ���#7F7F7F$��Century Gothic)�6�   $��14(�6�   �� 5'   
   -   5         ��Name$ btnLogin��5'      $��Login��6#   $
��Left=�63   $��	263,5,0,0q�6N   $��2��6a   $	��Top=�6n   $	��100��6�   ���#2C9BFF
�������$��Century Gothic)�6�   $��18(�6�   6�   �� 5*   
   -   5        	 ��Name$	 lblNotRegYet��5*      $��Not registered yet? ��6*   $
��Left=�6F   $	��Top=�6a   $��32,3,452,350q�6y   $��Century Gothic)�6�   $��14(�6�   ���#7F7F7F$��2��6�   �� 5+   
   -   5        $	 lblHere��5+      $
��here��5,      $��87,23,493,331q�5-      $��Century Gothic)�5.      $��14(�5/      ���#2C9BFF$��	Underline{�51      $��2��52      
 J� InputBindings
 53      d� 54       d� MouseAction$ 	LeftClicke�6M    �� Command 6   �� *NavigateToRegisterCommand+6M   56      �� 59   
   -   5        $	 	lblSignup��59      $��Sign up��6'   $
��Left=�66   $	��Top=�6Q   $��32,23,534,329q�6i   $��Century Gothic)�6�   $��14(�6�   ���#7F7F7F$��2��6�   5:      5;      