   M S B A M L   `   `   `  ����K  GMantenedoresCRUD, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:MantenedoresCRUD.vistaMantenedoresCRUD.vista  5   	   ,    &MantenedoresCRUD.vista.HabilitarPiloto   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:MantenedoresCRUD.vista     5   	     � Title$  HabilitarPiloto��5   	   $��573.039��6!   $	��644��62   
������  � WindowStartupLocation$ CenterScreen=�6W    � 
ResizeMode$ NoResize=�6|    � WindowStyle$
 None=�6�    � AllowsTransparency .  � Icon$ ../skyicon.ico��6�   .��5	      � -   5        ���	#FF1F4F6E$	��573��5	   V   $	��Top=�6c   $
��Left=�6{   $	��644��6�    � ColumnDefinitions 5
   
   �� 5       � RowDefinitions 5   
   �� 5      $	��76* �6   �� 5      $	��81* �6   �� 5      $��9* �6   �� 5      $
��535* �6   .+�5   
   �� ���	#FFF5F5FF$	��518��6%   $��	10,45,0,0q�62   
�������$	��Top=�6T   $��4��6l   $
��Left=�6}   $	��623��6�   �� 5   
   -   5         ��Name$ image��5      $
��Left=�6   $��71��6:   $��10,0,0,0q�6F   $��1��6X   $	��Top=�6e   $	��172��6}   $��Resources/sky logo.png��6�   $��2��6�   �� 5   
   -   5        	 ��Name$	 label1��5      $��Habilitar Piloto��6    $
��Left=�6;   $��	10,14,0,0q�6V   $	��Top=�6i   $��16(�6�   $��Medium"�6�   
�������$��31��6�   $	��130��6�   �� 5   
   -   5        
 ��Name$
 buttonCancel��5      $��Cancelar��6'   $
��Left=�6:   $��	571,0,0,0q�6U   $��1��6h   $	��Top=�6u   $��52��6�   $��32��6�   ��6�   Z� 6�   �� 5   
   -   5        $	 labelHorasDespegue��5      $
��Left=�6-   $��370,133,0,0q�6H   $��3��6]   $	��Top=�6j   $��Medium"�6�   ���	#FF7D84CB6�   �� 5   
   -   5        $	 labelHoraArribo��5      $
��Left=�6*   $��370,200,0,0q�6E   $��3��6Z   $	��Top=�6g   $��Medium"�6   ���	#FF7D84CB6�   �� 5   
   -   5         ��Name$ 	groupBox1��5      $��Seleccionar piloto��6&   $
��Left=�6B   $��	27,96,0,0q�6]   $��3��6p   $	��Top=�6}   $	��316��6�   $	��587��6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dataGridPilotos��5      $
��Left=�6,   $��
37,112,0,0q�6G   $��3��6[   $	��Top=�6h   $	��292��6�   $	��567��6�      
IsReadOnly . 6�   �� 5   
   -	   5         ��Name$ 
textBoxRut��5      $
��Left=�6&   $��23��6A   $��
130,17,0,0q�6M   $��3��6a    �� TextWrapping$
 Wrap=�6n   $	��Top=�6�   $	��120��6�   6�   �� 5   
   -
   5        $ textBoxNombre��5      $
��Left=�6)   $��23��6D   $��
130,59,0,0q�6P   $��3��6d   $
 Wrap=�6q   $	��Top=�6�   $	��120��6�   6�   �� 5   
   $��Nombre:��6   $
��Left=�6#   $��	66,56,0,0q�6>   $��3��6Q   $	��Top=�6^   �� 5   
   $
��RUT:��6   $
��Left=�6    $��	88,14,0,0q�6;   $��3��6N   $	��Top=�6[   �� 5   
   -   5        $ groupBox��5      $��Busqueda��6%   $
��Left=�67   $��27,0,0,0q�6R   $��3��6d   $	��Top=�6q   $��91��6�   $	��278��6�   5       5!      