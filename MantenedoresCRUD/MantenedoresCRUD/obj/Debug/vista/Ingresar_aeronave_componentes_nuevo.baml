   M S B A M L   `   `   `  ����K  GMantenedoresCRUD, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:MantenedoresCRUD.vistaMantenedoresCRUD.vista  5   	   @    :MantenedoresCRUD.vista.Ingresar_aeronave_componentes_nuevo   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:MantenedoresCRUD.vista     5   	     � Title$)  #Ingresar_aeronave_componentes_nuevo��5   	   $	��253��65   $	��653��6B    � WindowStyle$
 None=�6N   .��5	      � ���	#FF517E9C$��0,0,0,2q�6"   .+�5
   
   �� ���	#FFF4F4F5$��10,39,10,10q�6%   
���   �6:   �� 5   
   -   5         ��Name$ labelTitulo��5      $��Nuevo componente��6%   $
��Left=�6@   $��10,0,0,0q�6[   $	��Top=�6m   $��16(�6�   $��Medium"�6�   
�������6�   �� 5   
   -   5        $ labelNombre��5      $��Nombre��6%   $
��Left=�66   $��	21,52,0,0q�6Q   $	��Top=�6d   �� 5   
   -   5         ��Name$ textBoxNombre��5      $
��Left=�6)   $��23��6D   $��
174,55,0,0q�6P    �� TextWrapping$
 Wrap=�6d   $�� ��6x   $	��Top=�6�   $	��120��6�   �� 5   
   -   5        $ labelhorasVuelo��5      $��Horas de vuelo��6)   $
��Left=�6B   $��	21,83,0,0q�6]   $	��Top=�6p   �� 5   
   -   5        $ textBoxHorasVuelo��5      $
��Left=�6-   $��23��6H   $��
174,86,0,0q�6T   $
 Wrap=�6h   $�� ��6|   $	��Top=�6�   $	��120��6�   �� 5   
   -   5        $ labelLimiteHoras��5      $��Limite de horas de vuelo��6*   $
��Left=�6M   $��
21,114,0,0q�6h   $	��Top=�6|   �� 5   
   -   5        $ textBoxLimiteHoras��5      $
��Left=�6.   $��23��6I   $��174,117,0,0q�6U   $
 Wrap=�6j   $�� ��6~   $	��Top=�6�   $	��120��6�   �� 5   
   -   5        $ labelVencimiento��5      $��Fecha vencimiento��6*   $
��Left=�6F   $��
21,145,0,0q�6a   $	��Top=�6u   (  "System.Windows.Controls.DatePicker  5   
   -	   5          Name$  datePickerFechaVencimiento��5      $
��Left=�69   $��174,147,0,0q�6T   $	��Top=�6i   $	��120��6�   �� 5   
   -
   5         ��Name$ buttonAgregar��5      $��Agregar��6(   $
��Left=�6:   $��
21,185,0,0q�6U   $	��Top=�6i   $��75��6�   6�   �� 5   
   -   5        $ 
labelPadre��5      $;��5Si el componente pertenece a otro, seleccionelo aquí��6$   $
��Left=�6c   $��
328,52,0,0q�6~   $	��Top=�6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dataGridComponentePadre��5      $
��Left=�64   $��
337,78,0,0q�6O   $	��Top=�6c    J� RenderTransformOrigin$ -0.167,-3.308&�6{   $	��127��6�   $	��281��6�   	   
IsReadOnly	 . 
   AutoGenerateColumns
 .     Columns 5      4  .System.Windows.Controls.DataGridTemplateColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 	Seleccion��6)      CellTemplate 5      �� 5      .R�5      �� $ buttonSeleccionar��6%   -   5        ���	#FF33588D
�������|�.  .��5   �   Seleccionar6�   5      5      0  *System.Windows.Controls.DataGridTextColumn  5      $ Id��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *Id Componente+  5       $ Nombre��6%    65   �� *Nombre+  5!      $ Horas de vuelo��6%    6=   �� *Horas de vuelo+  5"      $ Id padre��6%    67   �� *Componente Padre+5$      5%      5&      