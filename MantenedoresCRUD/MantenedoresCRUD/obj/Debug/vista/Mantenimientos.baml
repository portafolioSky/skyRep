   M S B A M L   `   `   `  ����K  GMantenedoresCRUD, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:MantenedoresCRUD.vistaMantenedoresCRUD.vista  5   	   +    %MantenedoresCRUD.vista.Mantenimientos   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:MantenedoresCRUD.vista     5   	     � Title$  Mantenimientos��5   	   $��712.259��6    $��788.931��61   
������  � WindowStartupLocation$ CenterScreen=�6[    � 
ResizeMode$ NoResize=�6�    � WindowStyle$
 None=�6�    � AllowsTransparency .  � Icon$ ../skyicon.ico��6�   .��5      � -   5        ���	#FF517E9C.+�5   
   �� ���	#FFF5F5FF$
��Left=�6%   $	��651��6@   
�������$	��Top=�6\   $	��769��6t   $��	10,49,0,0q�6�   �� 5   
   -   5         ��Name$ buttonCerrar��5      $��X��6'   $
��Left=�63   $��	735,5,0,0q�6N   $	��Top=�6a   $��44��6y   $��39��6�   ���	#FF294A61$
��Bold"�6�   
���������6�   Z� 6�   �� 5   
   -   5         ��Name$ image��5      $
��Left=�6   $��70��6:   $��	26,68,0,0q�6F   $	��Top=�6Y   $	��172��6q   $��Resources/sky logo.png��6}   �� 5   
   -   5         ��Name$ label1��5      $��MANTENIMIENTOS��6    $
��Left=�69   $��10,8,0,0q�6T   $	��Top=�6f   $��16(�6~   $��Medium"�6�   
�������6�   �� 5   
   -   5        	 ��Name$	 groupBox��5      $��Seleccione Aeronave��6%   $
��Left=�6B   $��
50,219,0,0q�6]   $	��Top=�6q   $��63��6�   $	��151��6�   �� 5   
   -   5        
 ��Name$
 comboBoxTipoAeronave��5      $
��Left=�61   $��
68,243,0,0q�6L   $	��Top=�6`   $	��120��6x   6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dataGridListaNave��5      $
��Left=�6.   $��
68,306,0,0q�6I   $	��Top=�6]   $	��146��6u   $	��652��6�      
IsReadOnly . 6�   �� 5   
   -   5        $	 	groupBox1��5      $��	Aeronaves��6&   $
��Left=�69   $��
50,287,0,0q�6T   $	��Top=�6h   $	��179��6�   $	��688��6�     5   
   -	   5        $ dataGridMant��5      $
��Left=�6)   $��
26,500,0,0q�6D   $	��Top=�6X    . $	��182��6�   $	��385��6�   6�   �� 5   
   -
   5        $	 groupBoxMant��5      $"��Mantenimientos de Aeronave :��6)   $
��Left=�6O   $��
10,471,0,0q�6j   $	��Top=�6~   $	��223��6�   $	��417��6�   �� 5   
   -   5        $ buttonMantComponentes��5      $#��Mantenimientos de Componentes��60   $
��Left=�6X   $��240,243,0,0q�6s   $	��Top=�6�   $	��187��6�   $��22��6�   
�������{�.  ��5      �� 5       �� Color$ 	#FF8BABB9��6"    �� Opacity$	 0.7Q�64   5      �� 5   
   -   5        $	 groupBoxComponentes��5      $��Componentes Aeronave ��60   $
��Left=�6O   $��218,219,0,0q�6j   $	��Top=�6   $��63��6�   $	��231��6�   �� 5   
   -   5        $! buttonIngresarMantenimiento��5      $��Ingresar Mantenimiento��66   $
��Left=�6W   $��546,516,0,0q�6r   $	��Top=�6�   $	��152��6�   $��36��6�   {�.  
���������5      �� 5      $ 	#FF8BABB9��6"   $	 0.7Q�64   5       �� 5!   
   -   5        $ buttonBorrarMantenimiento��5!      $��Borrar Mantenimiento��64   $
��Left=�6S   $��546,620,0,0q�6n   $	��Top=�6�   $	��152��6�   $��38��6�   {�.  
���������5"      �� 5#      $ 	#FF8BABB9��6"   $	 0.7Q�64   5%      �� 5&   
   -   5        $" buttonModificarMantenimiento��5&      $��Modificar Mantenimiento��67   $
��Left=�6Y   $��546,568,0,0q�6t   $	��Top=�6�   $	��152��6�   $��36��6�   {�.  
���������5'      �� 5(      $ 	#FF8BABB9��6"   $	 0.7Q�64   5*      �� 5+   
   -   5        $#	 groupBoxControlMantenimientos��5+      $��Control de Mantenimientos��6:   $
��Left=�6]   $��432,471,0,0q�6x   $	��Top=�6�   $	��224��6�   $	��347��6�   �� 5,   
   -   5        $ buttonVolver��5,      $��Volver��6'   $
��Left=�68   $��
706,68,0,0q�6S   $	��Top=�6g   $��52��6   $��31��6�   ��6�   Z� 6�   50      51      