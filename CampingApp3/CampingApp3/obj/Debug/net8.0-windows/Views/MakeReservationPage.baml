   M S B A M L   `   `   `  ����  CampingApp3J4clr-namespace:CampingApp3.Views;assembly=CampingApp3CampingApp3.Views  5   	   +    %CampingApp3.Views.MakeReservationPage   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Flocal4clr-namespace:CampingApp3.Views;assembly=CampingApp3     5   	     � Title$  MakeReservationPage��5	   	   $	��450��6%   $	��800��62    � 	Resources 5
         HoverButtonStyle �� 
TargetType �� Property �� Value �� 
TargetType �� Triggers P� Property P� Value��%  &	        �� 5   
   " ��6)   .�5      ��  � �� �	#FF282C316+   �� 5       � �� �	#FF2C9BFF6+   �� 5       � ��$ 0q�60   �� 5       �@�FocusVisualStyle 61   Z� �� 5       � �� 5      �� 5      " ��6&   .R�5      �� #��z��6!   #��z��5   !   #��z��5   !   ._�5      �� $��Center=�6/   $��Center=�6L   5       5      P� 5       �@J�IsMouseOver$
 True��6=   . �5   "   ��  � �� �	#FF3A3E446?   5      5      5      5       5!      .��5"      �� ���	#FF0E3A64$��2q�6%   ._�5#   
   � -   5        	 �Name$	 MainWindowGrid��5#      ���#20262B.+�5$      �� -   5        
 ��Name$
 	pnlTopBar��5$      ���#282C31$��50��6A    �� Orientation$ 
Horizontal=�6M   $	��Top=�6f   .+�5%      �� -   5         ��Name$ btnMinimize��5%      $	��➖��6.   #��[  6:   $��	695,0,0,0q�6d   $��50��6w   $��50��6�   $��Century Gothic)�6�   6�   �� 5&      -   5        $ btnTerminate��5&      $��✖️��6/   #��[  6<   $��5,0,0,0q�6f   $��50��6w   $��50��6�   $��Century Gothic)�6�   6�   5'      �� 5(      $��10,10,669,324q�6   $��/imgRoundedKangaroo.png��6+   �� 5)      $��Make Reservation��6   $
��Left=�60   $��
130,10,0,0q�6K   $	��Top=�6_   $	��300��6w   $��24(�6�   $��	Yu Gothic)�6�   
�������$
��Bold"�6�   �� 5*      $��Number of Guests?
��6   $
��Left=�65   $��
12,276,0,0q�6P   $	��Top=�6d   
�������$��52��6�   $	��320��6�   $��22(�6�   $��Yu Gothic UI Semibold)�6�   �� 5+      -   5         ��Name$ aantPersonen��5+      $
��Left=�6-   $��
12,328,0,0q�6H   $	��Top=�6\   $	��268��6t    J� RenderTransformOrigin$ 0.366,0.295&�6�   $��24(�6�   $��46��6�    �� 
IsReadOnly$
 True��6�   z�5,      V� 5-      .~�5.      ��  �� ScaleX$ 1Q�6)    �� ScaleY$ 1Q�64   �� 5/      �� 50      T� 51      52      54      �� 55      -   5        $ Cancel��55      $��Cancel��6:   
���  ��$
��Left=�6\   $��464,351,0,0q�6w   $	��Top=�6�   $��48��6�   $	��124��6�   $��22(�6�   �� 56      -   5        $	 Pay��56      $��To Checkout��67   
���2�2�$
��Left=�6d   $��596,351,0,0q�6   $	��Top=�6�   $��48��6�   $	��186��6�   $��22(�6�   �� 57      $��536,60,12,118q�6   $��/mascot.png��6+   58      59      5:      