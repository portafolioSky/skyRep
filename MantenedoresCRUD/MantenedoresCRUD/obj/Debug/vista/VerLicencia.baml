   M S B A M L   `   `   `  ����K  GMantenedoresCRUD, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:MantenedoresCRUD.vistaMantenedoresCRUD.vista  5   	   (    "MantenedoresCRUD.vista.VerLicencia   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:MantenedoresCRUD.vista     5   	     � Title$  VerLicencia��5   	   $	��363��6   $	��418��6*   
������  � WindowStartupLocation$ CenterScreen=�6O    � 
ResizeMode$ NoResize=�6t    � WindowStyle$
 None=�6�    � AllowsTransparency .  � Icon$ ../skyicon.ico��6�   .��5	      � $��
10,8,25,24q�6   .+�5
   
   � ���	#FF1F4F6E$	��346��6'   $	��Top=�64   $��
0,-6,-25,0q�6L    � ColumnDefinitions 5      �� 5       � RowDefinitions 5      �� 5      .+�5      �� ���	#FFF5F5FF$��
10,42,0,41q�6)   
�������$
��Left=�6L   $	��388��6g   �� 5      -   5         ��Name$ label1��5      $��LICENCIA��6$   $
��Left=�67   $��	169,5,0,0q�6R   $	��Top=�6e   $��16(�6}   $��Medium"�6�   
�������$��32��6�   $��85��6�   �� 5      -   5        	 ��Name$	 button��5      $��ACEPTAR��6%   $
��Left=�67   $��169,271,0,0q�6R   $	��Top=�6g   $��75��6   $��22��6�   ���	#FF3F6BA0
�������6�   �� 5      ���	#FFD8D8D8$
��Left=�6)   $	��201��6D   $��	41,65,0,0q�6Q   
�������$	��Top=�6s   $	��329��6�   
 J� Opacity$	
 0.4Q�6�   �� 5      -   5        $ label��5      $��Rut Piloto:��6#   $
��Left=�69   $��	87,77,0,0q�6T   $	��Top=�6g   $��24��6   $��65��6�   �� 5      -   5        $ label2��5      $��Nombre Piloto:��6$   $
��Left=�6=   $��
62,112,0,0q�6X   $	��Top=�6l   $��29��6�   $��90��6�   �� 5      -   5        $ label3��5      $��Tipo de Licencia:��6$   $
��Left=�6@   $��
54,146,0,0q�6[   $	��Top=�6o   $��26��6�   $��98��6�   �� 5      -   5        $ label4��5      $��Fecha Emisión:��6$   $
��Left=�6=   $��
64,182,0,0q�6X   $	��Top=�6l   $��24��6�   $��88��6�   �� 5      -   5        $ label5��5      $��Fecha Expiración:��6$   $
��Left=�6@   $��
51,216,0,0q�6[   $	��Top=�6o   $��24��6�   $	��101��6�   �� 5      -   5        $ labelRut��5      $��Label��6&   $
��Left=�66   $��
196,77,0,0q�6Q   $	��Top=�6e   $��24��6}   $	��151��6�   �� 5      -	   5        $ labelNombre��5      $��Label��6)   $
��Left=�69   $��196,114,0,0q�6T   $	��Top=�6i   $��30��6�   $	��151��6�   �� 5      -
   5        $ 	labelTipo��5      $��Label��6'   $
��Left=�67   $��196,149,0,0q�6R   $	��Top=�6g   $��24��6   $	��151��6�   �� 5      -   5        $ labeEmision��5      $��Label��6)   $
��Left=�69   $��196,183,0,0q�6T   $	��Top=�6i   $��23��6�   $	��151��6�   �� 5      -   5        $ labelExpira��5      $��Label��6)   $
��Left=�69   $��196,216,0,0q�6T   $	��Top=�6i   $��24��6�   $	��151��6�   �� 5      $
��Left=�6   $��21��63   $��	44,95,0,0q�6?   $	��Top=�6R   $	��323��6j   �� 5       $
��Left=�6   $��25��63   $��
44,131,0,0q�6?   $	��Top=�6S   $	��323��6k   �� 5!      $
��Left=�6   $��15��63   $��
44,173,0,0q�6?   $	��Top=�6S   $	��323��6k   �� 5"      $
��Left=�6   $��16��63   $��
44,206,0,0q�6?   $	��Top=�6S   $	��323��6k   �� 5#      ���	#FF8181E0$
��Left=�6)   $	��196��6D   $��
157,67,0,0q�6Q   $	��Top=�6e   $	��210��6}   $
 0.215Q�6�   �� 5$      -   5         ��Name$ groupBox��5$      $��Licencia de vuelo��6)   $
��Left=�6D   $��	41,56,0,0q�6_   $	��Top=�6r   $	��210��6�   $	��329��6�   5%      5&      5'      