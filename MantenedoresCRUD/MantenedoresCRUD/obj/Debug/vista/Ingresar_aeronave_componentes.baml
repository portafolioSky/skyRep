   M S B A M L   `   `   `  ����K  GMantenedoresCRUD, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:MantenedoresCRUD.vistaMantenedoresCRUD.vista  5   	   :    4MantenedoresCRUD.vista.Ingresar_aeronave_componentes   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:MantenedoresCRUD.vista     5   	     � Title$#  Ingresar_aeronave_componentes��5   	   $��454.319��6/   $��396.681��6@    � WindowStyle$
 None=�6P   .��5	      � ���	#FF517E9C$��0,0,2,2q�6"    � ColumnDefinitions 5
   
   �� 5      $
��273* �6   �� 5      $	��18* �6   �� 5      $	��89* �6   .+�5   
   �� ���	#FFF4F4F5$��10,36,10,10q�6%   
���   �$��3��6I   �� 5   
   -   5         ��Name$ labelTitulo��5      $%��Ingresar aeronave - componentes��6%   $
��Left=�6O   $��10,0,0,0q�6j   $	��Top=�6|   $��16(�6�   $��Medium"�6�   
�������6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dataGridComponentes��5      $
��Left=�60   $��
24,144,0,0q�6K   $	��Top=�6_   $	��218��6w   $	��330��6�   $��3��6�      
IsReadOnly .    AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6%   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 61   �� *Id Componente+  5      $ Nombre��6%   	 65   �� *Nombre+  5      $ Horas de vuelo��6%   	 6=   �� *Horas de vuelo+  5      $ Fecha vencimiento��6%   	 6@   �� *Fecha Vencimiento+  5      $ Id padre��6%   	 67   �� *Componente Padre+5      �� 5   
   -   5        $ 	labelPaso��5      $#��Paso 2 - Ingresar componentes��6#   $
��Left=�6K   $��	24,45,0,0q�6f   $	��Top=�6y   �� 5   
   -   5        
 ��Name$
 buttonAgregarComponente��5      $��Agregar��62   $
��Left=�6D   $��
24,119,0,0q�6_   $	��Top=�6s   $��75��6�   6�   �� 5   
   -   5        $ labelListado��5      $��Componenten ingresados��6&   $
��Left=�6G   $��	24,88,0,0q�6b   $	��Top=�6u   �� 5   
   -   5        $
 buttonListo��5      $��Listo��6&   $
��Left=�66   $��
24,367,0,0q�6Q   $	��Top=�6e   $��75��6}   6�   5      5       