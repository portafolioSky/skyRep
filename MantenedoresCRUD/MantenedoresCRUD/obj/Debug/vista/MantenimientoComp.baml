   M S B A M L   `   `   `  ����K  GMantenedoresCRUD, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:MantenedoresCRUD.vistaMantenedoresCRUD.vista  5   	   .    (MantenedoresCRUD.vista.MantenimientoComp   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:MantenedoresCRUD.vista     5   	     � Title$  MantenimientoComponente��5   	   $��573.688��6)   $��909.942��6:   
������  � WindowStartupLocation$ CenterScreen=�6d    � 
ResizeMode$ NoResize=�6�    � WindowStyle$
 None=�6�    � AllowsTransparency .  � Icon$ ../skyicon.ico��6�   .��5	      � -   5        ���	#FF517E9C$��0,0,10,0q�5	   V    � RowDefinitions 5
   
   �� 5      .+�5   
   �� ���	#FFF5F5FF$
��Left=�6%   $	��523��6@   
�������$	��Top=�6\   $	��879��6t   $��	10,41,0,0q�6�   �� 5   
   -   5         ��Name$ buttonCerrar��5      $��X��6'   $
��Left=�63   $��	857,5,0,0q�6N   $	��Top=�6a   $��32��6y   $��31��6�   ���	#FF294A61$
��Bold"�6�   
���������6�   Z� 6�   �� 5   
   -   5         ��Name$ image��5      $
��Left=�6   $��70��6:   $��	26,68,0,0q�6F   $	��Top=�6Y   $	��172��6q   $��Resources/sky logo.png��6}   �� 5   
   -   5        	 ��Name$	 label1��5      $��MANTENIMIENTO COMPONENTES��6    $
��Left=�6D   $��10,8,0,0q�6_   $	��Top=�6q   $��16(�6�   $��Medium"�6�   
�������6�   &   System.Windows.Controls.DataGrid  5   
   -   5        
  Name$
 dataGridComp��5      $
��Left=�6)   $��
24,254,0,0q�6D   $	��Top=�6X   $	��300��6p   $	��506��6}      
IsReadOnly . 6�     5   
   -   5        $
 dataGridMantComp��5      $
��Left=�6-   $	��Top=�6H   $	��300��6`   $	��327��6m    . $��549,254,0,0q�6�   6�   �� 5   
   -   5        $ buttonIngresarMantComp��5      
�������$��Ingresar Mantenimiento��6D   $
��Left=�6e   $��157,194,0,0q�6�   $	��Top=�6�   $	��152��6�   $��36��6�   {�.  ��5      �� 5       �� Color$ 	#FF8BABB9��6"    �� Opacity$	 0.7Q�64   5      �� 5   
   -   5        $ buttonBorrarMantComp��5      
�������$��Borrar Mantenimiento��6B   $
��Left=�6a   $��515,194,0,0q�6|   $	��Top=�6�   $	��152��6�   $��36��6�   {�.  ��5      �� 5      $ 	#FF8BABB9��6"   $	 0.7Q�64   5      �� 5   
   -	   5        $ buttonModificarMantComp��5      
�������$��Modificar Mantenimiento��6E   $
��Left=�6g   $��337,194,0,0q�6�   $	��Top=�6�   $	��152��6�   $��36��6�   {�.  ��5      �� 5      $ 	#FF8BABB9��6"   $	 0.7Q�64   5!      �� 5"   
   -
   5         ��Name$# groupBoxControlMantenimientos��5"      $��Control de Mantenimientos��6:   $
��Left=�6]   $��136,168,0,0q�6x   $	��Top=�6�   $��81��6�   $	��554��6�   �� 5#   
   -   5        $ buttonVolver��5#      $��Volver��6'   $
��Left=�68   $��
806,86,0,0q�6S   $	��Top=�6g   $��52��6   $��31��6�   ��6�   Z� 6�   5$      5%      