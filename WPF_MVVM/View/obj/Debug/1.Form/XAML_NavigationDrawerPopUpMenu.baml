   M S B A M L   `   `   `  ����  View1    +View._1.Form.XAML_NavigationDrawerPopUpMenu   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35a ]DevExpress.Xpf.Core.v17.1, Version=17.1.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aW SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   V RMaterialDesignThemes.Wpf, Version=2.4.0.1044, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   $	��600��5      $
��1080��6'   
�������  � 
ResizeMode$  NoResize=�6G    � WindowStartupLocation$ CenterScreen=�6]    � WindowStyle$
 None=�6�    � 	Resources 5         OpenMenu �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value  	CloseMenu��%�  &	        &	 �     �� 5	   
   .��5
      U� $ (FrameworkElement.Width)�6,   $ GridMenu��6a   .\�5        $ 0��6'   $ 70Q�63     5      $ 0:0:0.5��6'   $	 200Q�69   5      5      �� 5   
   .��5      U� $ (FrameworkElement.Width)�6,   $ GridMenu��6a   .\�5        $ 0��6'   $	 200Q�63     5      $ 0:0:0.5��6'   $ 70Q�69   5      5      5       � Triggers 5      :� 5   
   	 :� RoutedEvent$	 ButtonBase.Click��6   
 :� 
SourceName$
 ButtonOpenMenu��66   .[�5      �� #��[  6   5      :� 5   
   $	 ButtonBase.Click��6   $
 ButtonCloseMenu��66   .[�5      �� #��[ 6   5      .��5      � ���	#FFDEDEDE.+�5   
   � -   5         �Name$ GridMain��5      $��Right=�6!   $��Bottom=�6=   $	��540��6X   $
��1010��6e   � 5    
   $��60��6   $	��Top=�6   ���	#FF5C99D6 J� Effect 5!      3  -System.Windows.Media.Effects.DropShadowEffect  5"         
BlurRadius$ 1Q�6#      ShadowDepth$ 1Q�62      Color$ 	#FFACACAC��6B   .+�5$      ��  �� Orientation$ 
Horizontal=�6   $��Right=�62   .+�5%      �� $��
Abel Dutra��6   $��Center=�6.   $��16(�6I   '  !MaterialDesignThemes.Wpf.PopupBox  5&         PlacementMode$ BottomAndAlignRightEdges=�6*      	StaysOpen .  $��10q�6e      PopupContent. 5'      �� $	��150��6!   .+�5(      �� $��Settings��6!   �� 5)      $��Account��6!   �� 5*      $
��Help��6!   �� 5+      �� 5,      -   5         ��Name$ 	btnLogOut��5,   !   $��Logout��64   6E   5-      5.      5/      �� 50      $��Center=�6   $��Center=�65   $��22(�6P   Design com WPF6n   51      � 52   
   -   5        $ GridMenu��52      $��70��6!   $
��Left=�6,   ���	#FF31577E 53        54      $ 2Q�6#   $ 1Q�62   $ 	#FFAEAEAE��6B   .+�56      �� .+�57      � $	��150��6   
������� J� RenderTransformOrigin$ 0.5,0.5&�67   z�58      V� 59      .~�5:      �� �� 5;      �� 5<      T� 5=      5>      .+�5@      �� -   5        $ ButtonOpenMenu��5@      $��60��65   $��60��6A   $��5q�6L   $��Right=�6W   $	��Top=�6s    0 ,MaterialDesignFloatingActionMiniAccentButton#��[ 6�   ���	#FF31577E��6�   Z� ��6�   Z� .��5A      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.4.0.1044, Culture=neutral, PublicKeyToken=null]]   Kind$
 Menu=�62   $��25��6>   $��25��6I   5B      �� 5C      -   5        $ ButtonCloseMenu��5C      $y�	Collapsed=�66   $��60��6M   $��60��6Y   $��5q�6d   $��Right=�6o   $	��Top=�6�   #��[ 6�   ���	#FF31577E��6�   Z� ��6�   Z� .��5D        $ 	ArrowLeft=�62   $��25��6C   $��25��6N   5E      �� 5G      $��80��6   $��Bottom=�6(   5H      �� 5I      -   5         ��Name$ ListViewMenu��5I      ���	#FF5C99D6$��Disabled=�6H   .@�5J      �� -   5         ��Name$ ItemHome��5J   #   $��60��65   .��5K      �� $ 
Horizontal=�6%   .+�5L        $ ViewDashboard=�66   $��25��6K   $��25��6W   $��10q�6b   �� 5M      $
��Home��6(   $��Center=�64   $��20 10q�6O   5N      5O      �� 5P      -   5        $ 
ItemCreate��5P   #   $��60��67   .��5Q      �� $ 
Horizontal=�6%   .+�5R        $ Pencil=�66   $��25��6D   $��25��6P   $��10q�6[   �� 5S      $��Create��6(   $��Center=�66   $��20 10q�6Q   5T      5U      �� 5V      $��60��6#   .��5W      �� $ 
Horizontal=�6%   .+�5X        $ Ticket=�66   $��25��6D   $��25��6P   $��10q�6[   �� 5Y      $��Tickets��6(   $��Center=�67   $��20 10q�6S   5Z      5[      �� 5\      $��60��6#   .��5]      �� $ 
Horizontal=�6%   .+�5^        $ Message=�66   $��25��6E   $��25��6Q   $��10q�6\   �� 5_      $��Messages��6(   $��Center=�68   $��20 10q�6T   5`      5a      5b      5c      5d      5e      5f      