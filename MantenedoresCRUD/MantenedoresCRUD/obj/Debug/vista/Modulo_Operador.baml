   M S B A M L   `   `   `  ����K  GMantenedoresCRUD, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:MantenedoresCRUD.vistaMantenedoresCRUD.vista  5   	   ,    &MantenedoresCRUD.vista.Modulo_Operador   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:MantenedoresCRUD.vista     5   	     � Title$  Modulo_Operador��5   	   $��700         ��6!   $
��1000��5	      
������  � WindowStartupLocation$ CenterScreen=�61    � 
ResizeMode$ NoResize=�6V    � WindowStyle$
 None=�6l    � AllowsTransparency .  � Icon$ ../skyicon.ico��6�   .��5
      � -   5        ���	#FF517E9C � ColumnDefinitions 5   
   �� 5      $
��169* �6   �� 5      $
��831* �6    � RowDefinitions 5   
   �� 5      $	��65* �6   �� 5      $	��69* �6   �� 5      $
��466* �6   .+�5   
   �� ���	#FFF5F5FF$
��Left=�6%   $	��626��6@   $��	10,64,0,0q�6M   
�������$	��Top=�6o   $	��980��6�   $��3��6�   $��2��6�   �� 5   
   -   5         ��Name$ buttonCerrar��5      $��X��6'   $
��Left=�63   $��
777,14,0,0q�6N   $	��Top=�6b   $��44��6z   $��41��6�   ���	#FF294A61$
��Bold"�6�   
�������$��1��6�   ��6�   Z� 6�   �� 5   
   -   5        	 ��Name$	 image��5      $
��Left=�6   $��71��6:   $��26,10.167,0,0q�6F   $��1��6]   $	��Top=�6j   $	��172��6�   $��Resources/sky logo.png��6�   $��2��6�   $��2��6�   �� 5   
   -   5        
 ��Name$
 labelSaludo��5      $��HOLA OPERADOR��6%   $
��Left=�6=   $��29,28.167,0,0q�6X   $��1��6o   $	��Top=�6|   $	��385��6�   $
��Thin"�6�   $��16(�6�   $��1��6�   �� 5   
   -   5        $
 label1��5      $��MODULO OPEDAROR��6    $
��Left=�6:   $��	10,14,0,0q�6U   $	��Top=�6h   $��16(�6�   $��Medium"�6�   
�������$��2��6�   �� 5   
   -   5        $ button��5      $��LOGOUT��6!   $
��Left=�62   $��755,10.167,0,0q�6M   $��1��6e   $	��Top=�6r   $��53��6�   $��31��6�   $��1��6�   ��6�   Z� 6�   �� 5   
   -   5         ��Name$ groupBox��5      $��	Funciones��6%   $
��Left=�68   $��26,9.667,0,0q�6S   $��2��6i   $	��Top=�6v   $	��131��6�   $	��315��6�   $��2��6�   .��5      �� -   5        $ buttonIngresarVuelo��5      |�.  $��Programar Vuelo��6D   $
��Left=�6^   $��
144,45,0,0q�6y   $	��Top=�6�   $	��154��6�   $��61��6�   
���������5      �� 5       �� Color$ 	#FF8BABB9��6&    �� Opacity$	 0.7Q�68   5       5!      �� 5"   
   -	   5        $ 	groupBox1��5"      $��
Visualizar��6&   $
��Left=�6:   $��201,9.667,0,0q�6U   $��2��6l   $	��Top=�6y   $	��131��6�   $	��235��6�   $��1��6�   �� 5#   
   -
   5        $ 	groupBox2��5#      $��Busqueda��6&   $
��Left=�68   $��453,9.667,0,0q�6S   $��2��6j   $	��Top=�6w   $	��131��6�   $	��343��6�   $��1��6�   �� 5$   
   -   5        $ 	groupBox3��5$      $��Datos��6&   $
��Left=�65   $��26,140.667,0,0q�6P   $��2��6h   $	��Top=�6u   $	��382��6�   $	��951��6�   $��2��6�   �� 5%   
   -   5        $ buttonMantenimientos��5%      $��Programar Mantenimiento��6/   $
��Left=�6Q   $��7,35.667,0,0q�6l   $��2��6�   $	��Top=�6�   $	��156��6�   $��26��6�   
�������$��1��6�   |�.  ��5&      �� 5'      $ 	#FF8BABB9��6"   $	 0.7Q�64   5)      �� 5*   
   -   5        $ buttonIngresarAeronave��5*      $��Ingresar Aeronave��61   $
��Left=�6M   $��39,35.667,0,0q�6h   $��2��6   $	��Top=�6�   $	��113��6�   
�������$��26��6�   |�.  ��5+      �� 5,      $ 	#FF8BABB9��6"   $	 0.7Q�64   5.      �� 5/   
   -   5        $ buttonHabilitarPiloto��5/      $��Habilitar Piloto��60   $
��Left=�6K   $��39,107.667,0,0q�6f   $��2��6~   $	��Top=�6�   $	��113��6�   $��25��6�   
�������|�.  ��50      �� 51      $ 	#FF8BABB9��6"   $	 0.7Q�64   53      �� 54   
   -   5        $ button3��54      $��Ingresar Piloto��6"   $
��Left=�6<   $��39,71.667,0,0q�6W   $��2��6n   $	��Top=�6{   $	��113��6�   $��26��6�   
�������|�.  ��55      �� 56      $ 	#FF8BABB9��6"   $	 0.7Q�64   58      �� 59   
   -   5        $ btnAeronaves��59      $��	Aeronaves��6'   $
��Left=�6;   $��223,35.667,0,0q�6V   $��2��6n   $	��Top=�6{   $	��191��6�   
�������$��26��6�   $��1��6�   |�.  ��5:      �� 5;      $ 	#FF8BABB9��6"   $	 0.7Q�64   5=      �� 5>   
   -   5        $ 
btnPilotos��5>      $��Pilotos��6%   $
��Left=�67   $��223,71.667,0,0q�6R   $��2��6j   $	��Top=�6w   $	��191��6�   
�������$��26��6�   $��1��6�   |�.  ��5?      �� 5@      $ 	#FF8BABB9��6"   $	 0.7Q�64   5B      �� 5C   
   -   5        $ buttonVuelos��5C      $��Vuelos��6'   $
��Left=�68   $��223,107.667,0,0q�6S   $��2��6l   $	��Top=�6y   $	��191��6�   $��25��6�   
�������$��1��6�   |�.  ��5D      �� 5E      $ 	#FF8BABB9��6"   $	 0.7Q�64   5G      �� 5H   
   -   5         ��Name$ comboBox��5H      $
��Left=�6%   $��480,39.667,0,0q�6@   $��2��6X   $	��Top=�6e   $	��157��6}   $��1��6�   ��6�   Z� 6�   �� 5I   
   -   5        $ btnBuscarAvion��5I      $��Buscar��6)   $
��Left=�6:   $��698,63.667,0,0q�6U   $��2��6m   $	��Top=�6z   $��86��6�   $��34��6�   
�������$��1��6�   |�.  ��5J      �� 5K      $ 	#FF8BABB9��6"   $	 0.7Q�64   5M      �� 5N   
   -   5         ��Name$ textBoxMatricula��5N      $
��Left=�6,   $��23��6G   $��485,94.667,0,0q�6S   $��2��6k    �� TextWrapping$
 Wrap=�6x   $�� ��6�   $	��Top=�6�   $	��152��6�   $��1��6�   �� 5O   
   -   5        $ buttonMininizar��5O      $��-��6*   $
��Left=�66   $��
733,14,0,0q�6Q   $	��Top=�6e   $��40��6}   ���	#FF294A61$
��Bold"�6�   
�������$��41��6�   $��1��6  |�.  ��6�   Z� 6  &   System.Windows.Controls.DataGrid  5P   
   -   5          Name$ dataGrid_nave��5P      $
��Left=�6*   $��39,161.667,0,0q�6E   $��2��6]   $	��Top=�6j   $	��926��6�   $	��348��6�      
IsReadOnly . $��2��6�      RowStyle 5Q      �� 5R       �� 
TargetType)  #System.Windows.Controls.DataGridRow"  6    �� Triggers 5S      �� 5T       �� Binding 6&   �� *Estado+ �� Value FUERA DE VUELO6A   .a�5U      ��  �� Property � �� �� Value
 �  ��6I   5V      5X         Columns 5Z      4  .System.Windows.Controls.DataGridTemplateColumn  5[      ,  &System.Windows.Controls.DataGridColumn   Header$ 	Seleccion��6)      CellTemplate 5\      �� 5]      .R�5^      �� ���	#FF33588D
�������|�.  .��6a   Seleccionar6n   5_      5a      5c      �� 5d   
   -   5        $  comboBoxTipoAeronavePiloto��5d      $
��Left=�67   $��860,35.667,-149,0q�6R   $��2��6m   $	��Top=�6z   $	��120��6�   $��1��6�   �� 5e   
   -   5        $
 labelRutPiloto��5e      $	��Rut��6(   $
��Left=�66   $��860,63.667,-129,0q�6Q   $��2��6l   $	��Top=�6y   $	��100��6�   $��1��6�   �� 5f   
   -   5        $ textBoxRutPiloto��5f      $
��Left=�6,   $��23��6G   $��860,94.667,-149,0q�6S   $��2��6n   $
 Wrap=�6{   $�� ��6�   $	��Top=�6�   $	��120��6�   $��1��6�   �� 5g   
   -   5        $ btnBuscarPiloto��5g      $��Buscar��6*   $
��Left=�6;   $��1016,63.667,-256,0q�6V   $��2��6r   $	��Top=�6   $��71��6�   $��30��6�   
�������$��1��6�   |�.  ��5h      �� 5i      $ 	#FF8BABB9��6"   $	 0.7Q�64   5k      5m      5n      