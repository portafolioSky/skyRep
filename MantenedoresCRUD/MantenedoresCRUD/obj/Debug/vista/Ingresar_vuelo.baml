   M S B A M L   `   `   `  ����K  GMantenedoresCRUD, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:MantenedoresCRUD.vistaMantenedoresCRUD.vista  5   	   +    %MantenedoresCRUD.vista.Ingresar_vuelo   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:MantenedoresCRUD.vista     5   	     � Title$  Ingresar_vuelo��5   	   $��600         ��6    $	��500��5	      
������  � WindowStartupLocation$ CenterScreen=�60    � 
ResizeMode$ NoResize=�6U    � WindowStyle$
 None=�6k    � AllowsTransparency .  � Icon$ ../skyicon.ico��6�   .��5
      � -   5        ���	#FF1F4F6E � ColumnDefinitions 5   
   �� 5       � RowDefinitions 5   
   �� 5      $	��65* �6   �� 5      $	��69* �6   �� 5      $
��466* �6   .+�5   
   �� ���	#FFF5F5FF$	��545��6%   $��	10,45,0,0q�62   
�������$	��Top=�6T   $��3��6l   $
��Left=�6}   $	��480��6�   �� 5   
   -   5         ��Name$ image��5      $
��Left=�6   $��71��6:   $��10,0,0,0q�6F   $��1��6X   $	��Top=�6e   $	��172��6}   $��Resources/sky logo.png��6�   $��2��6�   �� 5   
   -   5        	 ��Name$	 label1��5      $��Ingresar Vuelo��6    $
��Left=�69   $��	10,14,0,0q�6T   $	��Top=�6g   $��16(�6   $��Medium"�6�   
�������$��31��6�   $	��115��6�   �� 5   
   -   5        
 ��Name$
 buttonCancel��5      $��Cancelar��6'   $
��Left=�6:   $��
426,19,0,0q�6U   $��1��6i   $	��Top=�6v   $��53��6�   $��32��6�   ��6�   Z� 6�   �� 5   
   -   5         ��Name$ 	groupBox3��5      $��Ingresar Datos��6&   $
��Left=�6>   $��	26,48,0,0q�6Y   $��2��6l   $	��Top=�6y   $	��330��6�   $	��453��6�   �� 5   
   -   5        $
 button��5      $��	Siguiente��6!   $
��Left=�65   $��394,411,0,0q�6P   $��2��6e   $	��Top=�6r   $��75��6�   $��22��6�   6�   �� 5   
   -   5        $	 label��5      $&�� PASO 1, INGRESAR DATOS DEL VUELO��6   $
��Left=�6J   $��	35,17,0,0q�6e   $��2��6x   $	��Top=�6�   $��26��6�   $	��220��6�   �� 5   
   -   5        $	 label2��5      $��Fecha de salida��6    $
��Left=�6:   $��	35,80,0,0q�6U   $��2��6h   $	��Top=�6u   $��24��6�   $	��118��6�   �� 5   
   -	   5        $	 label4��5      $��Hora de despegue��6    $
��Left=�6;   $��
35,142,0,0q�6V   $��2��6j   $	��Top=�6w   $��26��6�   $	��118��6�   �� 5   
   -
   5        $	 label5��5      $��Condicion del vuelo��6    $
��Left=�6>   $��
35,209,0,0q�6Y   $��2��6m   $	��Top=�6z   $��26��6�   $	��118��6�   �� 5   
   -   5        $	 label6��5      $��Ciudad de origen��6    $
��Left=�6;   $��
35,265,0,0q�6V   $��2��6j   $	��Top=�6w   $��26��6�   $	��118��6�   �� 5   
   -   5        $	 label7��5      $��Ciudad de destino��6    $
��Left=�6<   $��
35,314,0,0q�6W   $��2��6k   $	��Top=�6x   $��25��6�   $	��118��6�   	� 5   
   -   5         	�Name$ radioButtonIrf��5      $��Instrumentos (IRF)��6/   $
��Left=�6L   $��216,214,0,0q�6g   $��2��6|   $	��Top=�6�   $��16��6�   $	��112��6�    	� 	GroupName$ condicionVuelo��6�   6�   	� 5    
   -   5        $ radioButtonVrf��5       $��Visual(VFR)��6.   $
��Left=�6D   $��355,214,0,0q�6_   $��2��6t   $	��Top=�6�   $��16��6�   $��75��6�   $ condicionVuelo��6�   6�   (  "System.Windows.Controls.DatePicker  5!   
   -   5          Name$ dpFechaSalida��5!      $
��Left=�6,   $��
216,80,0,0q�6G   $��2��6[   $	��Top=�6h   $��24��6�   $	��145��6�      IsTodayHighlighted . 6�   �� 5"   
   -   5         ��Name$ comboBoxOrigen��5"      $
��Left=�6+   $��216,265,0,0q�6F   $��2��6[   $	��Top=�6h   $	��145��6�   $��22��6�   6�   �� 5#   
   -   5        $ comboBoxDestino��5#      $
��Left=�6,   $��216,314,0,0q�6G   $��2��6\   $	��Top=�6i   $	��145��6�   $��22��6�   �� 5$   
   -   5         ��Name$ horaDespegue��5$      $
��Left=�6'   $��216,146,0,0q�6B   $��2��6W   $	��Top=�6d   $	��149��6|    � Minimum$ 0Q�6�    � Maximum$
 23.5Q�6�    �� TickPlacement$ BottomRight=�6�    �� IsSnapToTickEnabled .  �� TickFrequency$	 0.5Q�6�   6�   �� 5%   
   -   5        $	 labelHorasDespegue��5%      $
��Left=�6-   $��370,142,0,0q�6H   $��2��6]   $	��Top=�6j   $��Medium"�6�   ���	#FF7D84CB6�   �� 5&   
   -   5        $	 labelHoraArribo��5&      $
��Left=�6*   $��370,209,0,0q�6E   $��2��6Z   $	��Top=�6g   $��Medium"�6   ���	#FF7D84CB6�   5'      5(      