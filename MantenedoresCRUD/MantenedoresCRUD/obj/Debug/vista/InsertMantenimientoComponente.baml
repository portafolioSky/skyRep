   M S B A M L   `   `   `  ����K  GMantenedoresCRUD, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:MantenedoresCRUD.vistaMantenedoresCRUD.vista  5   	   :    4MantenedoresCRUD.vista.InsertMantenimientoComponente   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:MantenedoresCRUD.vista     5   	     � Title$#  InsertMantenimientoComponente��5   	   $	��300��6/   $	��300��6<    � WindowStartupLocation$ CenterScreen=�6H    � WindowStyle$
 None=�6m   .��5	      � ���	#FFF5F5FF.+�5
   
   �� -   5         ��Name$! buttonIngresarMantenimiento��5
      
�������$��Ingresar��6I   $
��Left=�6\   $��
49,221,0,0q�6w   $	��Top=�6�   $��75��6�    J� RenderTransformOrigin$ -0.503,0.408&�6�   ��5      �� 5       �� Color$ 	#FF8BABB9��6"    �� Opacity$	 0.7Q�64   5      �� 5   
   -   5         ��Name$ textBoxIdComp��5      $
��Left=�6)   $��23��6D   $��
129,50,0,0q�6P    �� TextWrapping$
 Wrap=�6d   $�� ��6x   $	��Top=�6�   $	��145��6�   {�.  6�   (  "System.Windows.Controls.DatePicker  5   
   -   5        	  Name$	 fechaInspeccion��5      $
��Left=�6.   $��
129,87,0,0q�6I   $	��Top=�6]   �� 5   
   -   5        
 ��Name$
 comboBoxEncargado��5      $
��Left=�6.   $��129,161,0,0q�6I   $	��Top=�6^   $	��145��6v    �� 
IsEditable .  �� 
IsReadOnly .  �� Text$ Seleccione Operador��6�   �� 5   
   -   5         ��Name$ labelIdComp��5      $��Id Componente��6%   $
��Left=�6=   $��	10,50,0,0q�6X   $	��Top=�6k   $	��114��6�   �� 5   
   -   5        $ labelInspeccion��5      $��Fecha Inspeccion��6)   $
��Left=�6D   $��	10,87,0,0q�6_   $	��Top=�6r   $	��114��6�   �� 5   
   -   5        $ labelEstado��5      $��Estado��6%   $
��Left=�66   $��
10,124,0,0q�6Q   $	��Top=�6e   $	��114��6}   �� 5   
   -   5        $ labelEncargado��5      $��	Encargado��6(   $
��Left=�6<   $��
10,161,0,0q�6W   $	��Top=�6k   $	��114��6�   �� 5   
   -	   5        $ textBoxEstado��5      $
��Left=�6)   $��23��6D   $��129,124,0,0q�6P   $
 Wrap=�6e   $��
PROGRAMADO��6y   $	��Top=�6�   $	��145��6�   {�.  6�   �� 5   
   -
   5        $ buttonCerrar��5      $��Cerrar��6'   
�������$
��Left=�6K   $��169,221,0,0q�6f   $	��Top=�6{   $��79��6�   ��5      �� 5      $ 	#FF8BABB9��6"   $	 0.7Q�64   5      �� 5   
   -   5         ��Name$ image��5      $
��Left=�6   $��39��6:   $��10,6,0,0q�6F   $	��Top=�6X   $��84��6p   $��Resources/sky logo.png��6{   �� 5   
   -   5        $ label��5      $��INGRESAR MANTENIMIENTO��6   $
��Left=�6@   $��	99,10,0,0q�6[   $	��Top=�6n   5      5      