   M S B A M L   `   `   `  ����K  GMantenedoresCRUD, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:MantenedoresCRUDMantenedoresCRUD  5   	   !    MantenedoresCRUD.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:MantenedoresCRUD     5   	     � Title$  
MainWindow��5   	   $	��500��6   $	��350��6)   
������  � WindowStartupLocation$ CenterScreen=�6N    � 
ResizeMode$ NoResize=�6s    � WindowStyle$
 None=�6�    � AllowsTransparency .  � Icon$ skyicon.ico��6�   .��5	      �� -   5         �� CornerRadius$ 20��5	   A   ��5
   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      � 	 � Color$	 White��6   � 5      $	 	#FF9CA2BB��6   
 � Offset$
 1Q�61   5      ._�5   
   �  � ColumnDefinitions 5      �� 5       � RowDefinitions 5      �� 5      .+�5      �� ���	#FF08364B$
��Left=�6)   $	��242��6D   $��
21,181,0,0q�6Q   ���	#FF25468D$	��Top=�6x   $	��306��6�    J� Opacity$	 0.1Q�6�   $��2��6�   �� 5      -   5         ��Name$ label��5      $��Usuario:��6#   $
��Left=�66   $��
59,224,0,0q�6Q   $	��Top=�6e   $��26��6}   $��69��6�   
�������$��
ExtraBlack"�6�   $��15(�6�   �� 5      -   5        $ label1��5      $��	Password:��6$   $
��Left=�68   $��
47,276,0,0q�6S   $	��Top=�6g   $��26��6   $��81��6�   
�������$��15(�6�   $��
ExtraBlack"�6�   �� 5      -   5         ��Name$ textBoxUsuario��5      $
��Left=�6.   $��23��6I   $��136,227,0,0q�6U    �� TextWrapping$
 Wrap=�6j   $	��Top=�6~   $	��136��6�   6�   �� 5      -   5         ��Name$ button��5      $��X��6%   $
��Left=�61   $	��Top=�6L   $��28��6d   $��	312,7,0,0q�6o   $��22��6�   $��Black"�6�   $��15(�6�   $��Verdana)�6�   
���   �}�. ��.   J� IsHitTestVisible . |�.  $��RightToLeft=�6i  $��Center=�6�  ��6�   Z� ��6�   Z� 6�  � 5      $
��Left=�6   $	��118��6.   $	��Top=�6;   $	��350��6S   $��0,36,0,0q�6_   .+�5      �� -   5         ��Name$ image��5      $
��Left=�6'   $	��118��6B   $
��52,0q�6O   $	��Top=�6]   $	��245��6u   $"��vista/Resources/sky logo.png��6�   $	 0.9Q�6�   5      G� 5      -   5         G�Name$ passwordBox��5      $
��Left=�6/   $��136,279,0,0q�6J   $	��Top=�6_   $	��136��6w   $��23��6�   �� 5       -   5        $ buttonIngreso��5       $��INGRESAR��6,   $
��Left=�6?   $��136,346,0,0q�6Z   $	��Top=�6o   $��75��6�   
�������$��SemiBold"�6�   6�   �� 5!      -	   5        $ labelIngreso��5!      $��Ingreso al sistema��6*   $
��Left=�6G   $��115,155,0,0q�6b   $	��Top=�6w   5#      5$      5%      