   M S B A M L   `   `   `  ����F  BCampingApp3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:CampingApp3.ResourcesCampingApp3.Resources  5   	       CampingApp3.Views.Index   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4Menu#clr-namespace:CampingApp3.Resources     5   	     � Title$  Index��5	   	   $	��450��6   $	��800��6$    � 	Resources 5
       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $ ../Styles/Button.xaml?�6%   �� 5      $ ../Styles/Text.xaml?�6%   �� 5      $ ../Styles/Page.xaml?�6%   %    5      .��5      �� ���	#FF0E3A64$��2q�6%   ._�5   
   � -   5        $��gridSideBar��5      ���#20262B.+�5      � -   5         �Name$ 	pnlTopBar��5      ���#282C31$��50��6;   $	��Top=�6G   .+�5      ��  �� Orientation$ 
Horizontal=�6   5      �� 5      -   5         ��Name$ lblLoggedIn��5      $�� ��6-   $
��Left=�68   $��
181,10,0,0q�6S   $	��Top=�6g   $��40��6   $	��459��6�   $��14(�6�   $��	Yu Gothic)�6�   
�������6�   �� 5"      $ 
Horizontal=�6   $��Right=�66   .+�5$      �� -   5         ��Name$ btnMinimize��5$      $	��➖��62      HoverButtonStyle#��[  6>   $��50��6h   $��50��6s   $��Century Gothic)�6   6�   �� 5%      -   5        $ btnFullscreen��5%      $
��🔲��64   #��[  6A   $��50��6k   $��50��6v   $��Century Gothic)�6�   6�   �� 5&      -   5        $ btnTerminate��5&      $��✖️��63   #��[  6@   $��1,0,0,0q�6j   $��50��6{   $��50��6�   $��Century Gothic)�6�   6�   5'      5(      �� 5+      -   5         ��Name$ pnlSelectionBar��5+      ���#282C31$	��180��6G   $ Vertical=�6S   $
��Left=�6j   .+�5,      �� $	��100��6   $	��100��6%   $g��aC:\Users\leond\source\CampingApp3\CampingApp3\CampingApp3\Resources\Images\imgRoundedKangaroo.png��61   $��0,20,0,0q�6�   	 J� Effect	 5-      3  -System.Windows.Media.Effects.DropShadowEffect  5.      
   ShadowDepth$
 0Q�6+      Color$ 	#FF2B88CA��6;      Opacity$ 1Q�6M      
BlurRadius$ 65Q�6Y   50      51      o� 54      
������ $	��180��55      $
��Left=�56      $��	0,155,0,0q�57      .@�59         CampingApp3.Resources.Btn    BtnStyle#��[ 6    d� 	IsChecked$
 TrueY�5;      $��-5,0,0,0q�5<      ��5:      �� *HomeCommand+.��5>      � .+�5?      �� $
��Home��6$     
Text_Style#��[ 5@   $   5A      5C        5E      #��[ 6   $��-5,0,0,0q�5G      ��5F      �� *ReservationCommand+.��5I      � .+�5J      �� $��Reservation��6$   #��[ 5K   $   $��0,16,0,0q�6H   $��92��6Z   $	��Top=�6e   $��Center=�6}   5L      5M        5O      -   5          Name$ loginBtn��5O      #��[ 6-   $��-5,0,0,0q�5Q      ��5P      �� *LoginCommand+.��5S      � .+�5T      �� $��Login��6$   #��[ 5U      $��Stretch=�6=   $��	67,0,67,0q�6[   5V      5W        5X      -	   5        $ accInfo��5X      #��[ 6,   $	��178��5Y   <   $
��Left=�6H   $��-5,0,0,0q�6c   ��6   �� *AccountCommand+.��5[      � .+�5\      �� $��
My Account��6$   #��[ 5]      $��40,0,0,0q�68   $	��113��6J   5^      5`        5a      -
   5        $ btnAdminPage��5a      #��[ 62   $	��178��5b   :   $
��Left=�6F   $��-5,0,0,0q�6a   ��6   �� *AdminCommand+.��5c      � .+�5d      �� $��Admin��6$   #��[ 5e      $��	63,0,64,0q�6A   $��Stretch=�6T   5f      5g      5h      � 5k      -   5        $ pnlMain��5k      ���#20262B$��Stretch=�69   $��Stretch=�6W   $��
180,50,0,0q�6s    � RowDefinitions 5l      �� 5m      $��* �6$    � ColumnDefinitions 5o      �� 5p      $��* �6'   .+�5r      �� -   5         ��Name$
 Home��5r   !   $��0��6/   $��0��6<   ��6L   �� *CurrentView+5s      5t      5u      5v      