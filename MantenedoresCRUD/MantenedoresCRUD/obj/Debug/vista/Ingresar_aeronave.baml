   M S B A M L   `   `   `  ����K  GMantenedoresCRUD, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:MantenedoresCRUD.vistaMantenedoresCRUD.vista  5   	   .    (MantenedoresCRUD.vista.Ingresar_aeronave   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:MantenedoresCRUD.vista     5   	     � Title$  Ingresar_aeronave��5   	   $��393.05��6#   $	��375��63    � WindowStyle$
 None=�6?   .��5	      � ���	#FF517E9C.+�5
   
   �� ���	#FFF4F4F5$��10,56,10,10q�6%   
���   �6:   �� 5   
   -   5         ��Name$ labelTitulo��5      $��Ingresar aeronave��6%   $
��Left=�6A   $��	10,14,0,0q�6\   $	��Top=�6o   $��16(�6�   $��Medium"�6�   
�������6�   �� 5   
   -   5        $ 	labelPaso��5      $��Paso 1: ingresar aeronave��6#   $
��Left=�6G   $��	21,70,0,0q�6b   $	��Top=�6u   �� 5   
   -   5        $ labelMatricula��5      $��	Matricula��6(   $
��Left=�6<   $��
21,121,0,0q�6W   $	��Top=�6k   �� 5   
   -   5         ��Name$ textBoxMatricula��5      $
��Left=�6,   $��23��6G   $��227,124,0,0q�6S    �� TextWrapping$
 Wrap=�6h   $�� ��6|   $	��Top=�6�   $	��120��6�   �� 5   
   -   5        $ 
labelMarca��5      $��Marca��6$   $
��Left=�64   $��
21,149,0,0q�6O   $	��Top=�6c   �� 5   
   -   5        $ textBoxMarca��5      $
��Left=�6(   $��23��6C   $��227,152,0,0q�6O   $
 Wrap=�6d   $�� ��6x   $	��Top=�6�   $	��120��6�   �� 5   
   -   5        $ labelModelo��5      $��Modelo��6%   $
��Left=�66   $��
21,175,0,0q�6Q   $	��Top=�6e   �� 5   
   -   5        $ textBoxModelo��5      $
��Left=�6)   $��23��6D   $��227,178,0,0q�6P   $
 Wrap=�6e   $�� ��6y   $	��Top=�6�   $	��120��6�   �� 5   
   -	   5        $ labelFechaFabricacion��5      $��Fecha de fabricacion��6/   $
��Left=�6N   $��
21,201,0,0q�6i   $	��Top=�6}   (  "System.Windows.Controls.DatePicker  5   
   -
   5          Name$  DatePickerFechaFabricacion��5      $
��Left=�69   $��227,203,0,0q�6T   $	��Top=�6i   $	��120��6�   �� 5   
   -   5        $ labelHorasVuelo��5      $��Horas de vuelo��6)   $
��Left=�6B   $��
21,227,0,0q�6]   $	��Top=�6q   �� 5   
   -   5        $ textBoxHorasVuelo��5      $
��Left=�6-   $��23��6H   $��227,232,0,0q�6T   $
 Wrap=�6i   $�� ��6}   $	��Top=�6�   $	��120��6�   �� 5   
   -   5        $ labelCertificadoDGAC��5      $$��Fecha emision certificado DGAC��6.   $
��Left=�6W   $��
21,258,0,0q�6r   $	��Top=�6�     5   
   -   5        $ datePickerCertificado��5      $
��Left=�64   $��227,259,0,0q�6O   $	��Top=�6d   $	��120��6|   �� 5   
   -   5        $ labelVencimiento��5      $(��"Fecha vencimiento certificado DGAC��6*   $
��Left=�6W   $��
20,284,0,0q�6r   $	��Top=�6�     5   
   -   5        $ datePickerVencimiento��5      $
��Left=�64   $��227,288,0,0q�6O   $	��Top=�6d   $	��120��6|   �� 5   
   -   5         ��Name$ buttonSiguiente��5      $��	Siguiente��6*   $
��Left=�6>   $��
21,327,0,0q�6Y   $	��Top=�6m   $��75��6�    J� RenderTransformOrigin$ 	4.76,-3.2&�6�   6�   �� 5   
   -   5         ��Name$ comboBoxTipo��5      $
��Left=�6)   $��
227,96,0,0q�6D   $	��Top=�6X   $	��120��6p   �� 5   
   -   5        $ 	labelTipo��5      $��Tipo aeronave��6#   $
��Left=�6;   $��	21,92,0,0q�6V   $	��Top=�6i   5      5       