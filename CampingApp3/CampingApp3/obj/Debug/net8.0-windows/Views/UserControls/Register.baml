   M S B A M L   `   `   `  ����F  BCampingApp3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:CampingApp3.Views.UserControlsCampingApp3.Views.UserControls  5      -    'CampingApp3.Views.UserControls.Register   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      >local,clr-namespace:CampingApp3.Views.UserControls     5        � 	Resources  5	       �� MergedDictionaries �� Source�� 5
   
    5      �� 5      $- '/CampingApp3;component/Styles/Page.xaml?�6%   %    5      .��5      � ���#20262B.+�5   
   �� -   5         ��Name$ lblAlreadyReg��5      $��Already registered?��6+   $
��Left=�6F   $	��Top=�6a   ���#7F7F7F$��Century Gothic)�6�   $��14(�6�   $��
34,228,0,0q�6�   �� 5   
   -   5        $ lblLogin��5      $��Login��6&   ���#7F7F7F$
��Left=�6H   $	��Top=�6c   $��Century Gothic)�6|   $��14(�6�   $��
34,244,0,0q�6�   �� 5   
   -   5        $ lblHere��5      $
��here��6%   ���#2C9BFF$��Century Gothic)�6F   $��14(�6b   $��	Underline{�6p   $��75,244,505,284q�6�    J� InputBindings 5      d� 5       d� MouseAction$ 	LeftClicke�6J    �� Command 6   �� *NavigateToLoginCommand+6J   5      �� 5   
   $��Register��6   
�������$
��Left=�67   $	��Top=�6R   $��Century Gothic)�6j   $��24(�6�   $��10,10,10,506q�6�   �� 5   
   $E��?Create a new account to access your reservations and dashboard.��6   $
��Left=�6[   $	��Top=�6v   
�������$��Century Gothic)�6�   $��14(�6�   $��10,44,10,483q�6�   �� 5   
   -   5         ��Name$ lblMail��5      $��Email:��6!   $
��Left=�62   $	��Top=�6M   $��
27,117,0,0q�6e   
�������$��Century Gothic)�6�   $��18(�6�   �� 5   
   -   5         ��Name$ 	txtbEmail��5      $
��Left=�6%   $��207,123,0,0q�6@   	 �� TextWrapping$
	 Wrap=�6U   $��Enter your email��6i   $	��Top=�6�   $	��230��6�   ���#7F7F7F$��Century Gothic)�6�   $��14(�6�   6  �� 5!   
   -   5        $ lblPhoneNumber��5!      $��Phone Number:��6(   $
��Left=�6@   $	��Top=�6[   $��
27,142,0,0q�6s   
�������$��Century Gothic)�6�   $��18(�6�   �� 5"   
   -   5        $ txtbPhoneNumber��5"      $
��Left=�6+   $��207,148,0,0q�6F   $
	 Wrap=�6[   $��Enter your phone number��6o   $	��Top=�6�   $	��230��6�   ���#7F7F7F$��Century Gothic)�6�   $��14(�6�   6%  �� 5$   
   -   5        $ lblPassword��5$      $��	Password:��6%   $
��Left=�69   $	��Top=�6T   $��
27,166,0,0q�6l   
�������$��Century Gothic)�6�   $��18(�6�   G� 5%   
   -	   5        
 G�Name$
 pwboxPassword��5%      $
��Left=�6-   $��207,172,0,0q�6H   $	��Top=�6]   $	��230��6u   ���#7F7F7F$��Century Gothic)�6�   $��14(�6�   �� 5'   
   -
   5        $ lblConfirmPassword��5'      $��Confirm Password:��6,   $
��Left=�6H   $	��Top=�6c   $��
27,190,0,0q�6{   
�������$��Century Gothic)�6�   $��18(�6�   G� 5(   
   -   5        $
 pwboxConfirmPassword��5(      $
��Left=�64   $��207,196,0,0q�6O   $	��Top=�6d   $	��230��6|   ���#7F7F7F$��Century Gothic)�6�   $��14(�6�   �� 5*   
   -   5         ��Name$ btnRegister��5*      $��Register��6&   $��337,233,0,0q�69   $	��Top=�6N   $
��Left=�6f   $	��100��6�   ���#2C9BFF
�������$��Century Gothic)�6�   $��18(�6�   6�   5,      5-      