   M S B A M L   `   `   `  ����K  GMantenedoresCRUD, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:MantenedoresCRUD.vistaMantenedoresCRUD.vista  5   	   *    $MantenedoresCRUD.vista.Vuelo_Resumen   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:MantenedoresCRUD.vista     5   	     � Title$  Vuelo_Resumen��5   	   $��700.5��6   $	��797��6.   
������  � WindowStartupLocation$ CenterScreen=�6S    � 
ResizeMode$ NoResize=�6x    � WindowStyle$
 None=�6�    � AllowsTransparency .  � Icon$ ../skyicon.ico��6�   .��5	      � -   5        ���	#FF1F4F6E$��0,0,6,0q�5	   V    � ColumnDefinitions 5
   
   �� 5       � RowDefinitions 5   
   �� 5      $	��19* �6   �� 5      $
��156* �6   .+�5   
   �� ���	#FFF5F5FF$	��643��6%   $��	10,45,0,0q�62   
�������$	��Top=�6T   $��2��6l   $
��Left=�6}   $	��770��6�   �� 5   
   -   5         ��Name$ image��5      $
��Left=�6   $��71��6:   $��10,0,0,0q�6F   $��1��6X   $	��Top=�6e   $	��172��6}   $��Resources/sky logo.png��6�   �� 5   
   $��DETALLE DEL VUELO��6   $
��Left=�6,   $��	10,14,0,0q�6G   $	��Top=�6Z   $��16(�6r   $��Medium"�6�   
�������$��31��6�   $	��172��6�   �� 5   
   -   5        	 ��Name$	 buttonCancel��5      $��Cancelar��6'   $
��Left=�6:   $��	698,0,0,0q�6U   $��1��6h   $	��Top=�6u   $��52��6�   $��32��6�   ��6�   Z� 6�   �� 5   
   $��Resumen del vuelo��6   $
��Left=�6,   $��
126,53,0,0q�6G   $��1��6[   $	��Top=�6h   $��26��6�   $	��220��6�   �� 5   
   ���	#FFB4BBBB$
��Left=�6%   $	��195��6@   $��
18,345,0,0q�6M   $��1��6a   
�������$	��Top=�6}   $	��755��6�   
 J� Opacity$	
 0.2Q�6�   �� 5   
   $��Tripulación��6   $
��Left=�6)   $��
17,336,0,0q�6D   $��1��6X   $	��Top=�6e   $	��205��6}   $	��757��6�   �� 5   
   ���	#FFD4D4D6$
��Left=�6%   $	��150��6@   $��421,371,0,0q�6M   $��1��6b   
�������$	��Top=�6~   $	��343��6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   $	
 0.4Q�6�   �� 5   
   $��Datos Copiloto��6   $
��Left=�6+   $��421,362,0,0q�6F   $��1��6[   $	��Top=�6h   $	��160��6�   $	��344��6�   �� 5   
   ���	#FFD4D4D6$
��Left=�6%   $	��150��6@   $��
25,371,0,0q�6M   $��1��6a   
�������$	��Top=�6}   $	��342��6�   $ 0.5,0.5&�6�   $	
 0.4Q�6�   z�5      V� 5      .~�5      �� �� 5       �� AngleX$ 0.076Q�6$   �� 5      T� 5        T� X$ -0.082Q�6)   5!      5#      �� 5$   
   $��Datos Piloto��6   $
��Left=�6)   $��
24,362,0,0q�6D   $��1��6X   $	��Top=�6e   $	��160��6}   $	��344��6�   �� 5%   
   ���	#FFD4D4D6$
��Left=�6%   $	��226��6@   $��	24,88,0,0q�6M   $��1��6`   
�������$	��Top=�6|   $	��334��6�   $	
 0.4Q�6�   �� 5&   
   ���	#FFD4D4D6$
��Left=�6%   $	��226��6@   $��
422,88,0,0q�6M   $��1��6a   
�������$	��Top=�6}   $	��343��6�   $	
 0.4Q�6�   �� 5'   
   $��Datos Vuelo��6   $
��Left=�6)   $��	24,79,0,0q�6D   $��1��6W   $	��Top=�6d   $	��236��6|   $	��335��6�   �� 5(   
   $��Datos del aeronave��6   $
��Left=�60   $��
421,79,0,0q�6K   $��1��6_   $	��Top=�6l   $	��236��6�   $	��343��6�   �� 5)   
   $��Ciudad de origen��6   $
��Left=�6,   $��
33,223,0,0q�6G   $��1��6[   $	��Top=�6h   $��26��6�   $	��106��6�   �� 5*   
   $��Condición del vuelo��6   $
��Left=�6/   $��
33,193,0,0q�6J   $��1��6^   $	��Top=�6k   $��26��6�   $	��118��6�   �� 5+   
   $��Cantidad horas vuelo��6   $
��Left=�60   $��
33,167,0,0q�6K   $��1��6_   $	��Top=�6l   $��26��6�   $	��123��6�   �� 5,   
   $��Fecha de llegada��6   $
��Left=�6+   $��
33,139,0,0q�6F   $��1��6Z   $	��Top=�6g   $��26��6   $	��106��6�   �� 5-   
   $��Fecha de salida��6   $
��Left=�6*   $��
33,111,0,0q�6E   $��1��6Y   $	��Top=�6f   $��26��6~   $��90��6�   �� 5.   
   $��Ciudad de destino��6   $
��Left=�6-   $��
33,251,0,0q�6H   $��1��6\   $	��Top=�6i   $	��107��6�   $��26��6�   �� 5/   
   -   5         ��Name$ label��5/      $��Km recorridos��6   $
��Left=�67   $��
33,279,0,0q�6R   $��1��6f   $	��Top=�6s   $��86��6�   $��26��6�   �� 50   
   $��:��6   $
��Left=�6   $��159,111,0,0q�68   $��1��6M   $	��Top=�6Z   $��26��6r   $��13��6~   �� 51   
   $��:��6   $
��Left=�6   $��159,139,0,0q�68   $��1��6M   $	��Top=�6Z   $��26��6r   $��13��6~   �� 52   
   $��:��6   $
��Left=�6   $��159,167,0,0q�68   $��1��6M   $	��Top=�6Z   $��26��6r   $��13��6~   �� 53   
   $��:��6   $
��Left=�6   $��159,195,0,0q�68   $��1��6M   $	��Top=�6Z   $��26��6r   $��13��6~   �� 54   
   $��:��6   $
��Left=�6   $��159,223,0,0q�68   $��1��6M   $	��Top=�6Z   $��26��6r   $��13��6~   �� 55   
   $��:��6   $
��Left=�6   $��159,251,0,0q�68   $��1��6M   $	��Top=�6Z   $��26��6r   $��13��6~   �� 56   
   $��:��6   $
��Left=�6   $��159,279,0,0q�68   $��1��6M   $	��Top=�6Z   $��26��6r   $��13��6~   �� 57   
   -   5        $ labelFeParida��57      $�� ��6'   $
��Left=�62   $��172,111,0,0q�6M   $��1��6b   $	��Top=�6o   $��80��6�   $��26��6�   �� 58   
   -   5        $ labelFeLlegada��58      $�� ��6(   $
��Left=�63   $��172,139,0,0q�6N   $��1��6c   $	��Top=�6p   $��80��6�   $��26��6�   �� 59   
   -   5        $ labelCantHorasVuelo��59      $�� ��6-   $
��Left=�68   $��172,167,0,0q�6S   $��1��6h   $	��Top=�6u   $	��158��6�   $��26��6�   �� 5:   
   -   5        $ labelCondiVuelo��5:      $�� ��6)   $
��Left=�64   $��172,195,0,0q�6O   $��1��6d   $	��Top=�6q   $	��174��6�   $��26��6�   �� 5;   
   -	   5        $ labelCiudadOrigen��5;      $�� ��6+   $
��Left=�66   $��172,223,0,0q�6Q   $��1��6f   $	��Top=�6s   $��99��6�   $��26��6�   �� 5<   
   -
   5        $ labelCiudadDestino��5<      $�� ��6,   $
��Left=�67   $��172,251,0,0q�6R   $��1��6g   $	��Top=�6t   $��99��6�   $��26��6�   �� 5=   
   -   5        $ labelKmDistancia��5=      $�� ��6*   $
��Left=�65   $��1��6P   $	��Top=�6]   $��172,279,0,0q�6u   $��99��6�   $��26��6�   �� 5>   
   -   5        $ labelHoraSalida��5>      $�� ��6)   $
��Left=�64   $��270,111,0,0q�6O   $��1��6d   $	��Top=�6q   $��26��6�   $��60��6�   �� 5?   
   -   5        $ labelHoraLlegada��5?      $�� ��6*   $
��Left=�65   $��270,142,0,0q�6P   $��1��6e   $	��Top=�6r   $��60��6�   $��33��6�   �� 5@   
   $��	Matricula��6   $
��Left=�6$   $��433,111,0,0q�6?   $��1��6T   $	��Top=�6a   $��26��6y   $��59��6�   �� 5A   
   $��Velocidad maxima��6   $
��Left=�6+   $��433,279,0,0q�6F   $��1��6[   $	��Top=�6h   $��26��6�   $	��143��6�   �� 5B   
   $��Venc. certificado DGAC��6   $
��Left=�61   $��1��6L   $	��Top=�6Y   $��433,251,0,0q�6q   $��26��6�   $	��170��6�   �� 5C   
   $��Ultimo vuelo��6   $
��Left=�6'   $��433,223,0,0q�6B   $��1��6W   $	��Top=�6d   $��26��6|   $��78��6�   �� 5D   
   $��Horas de vuelo��6   $
��Left=�6)   $��433,195,0,0q�6D   $��1��6Y   $	��Top=�6f   $��26��6~   $��90��6�   �� 5E   
   $��Tipo de Aeronave��6   $
��Left=�6+   $��433,167,0,0q�6F   $��1��6[   $	��Top=�6h   $��26��6�   $	��103��6�   �� 5F   
   $��Marca��6   $
��Left=�6    $��433,139,0,0q�6;   $��1��6P   $	��Top=�6]   $��26��6u   $��43��6�   �� 5G   
   $��:��6   $
��Left=�6   $��599,111,0,0q�68   $��1��6M   $	��Top=�6Z   $��26��6r   $��13��6~   �� 5H   
   $��:��6   $
��Left=�6   $��599,139,0,0q�68   $��1��6M   $	��Top=�6Z   $��26��6r   $��13��6~   �� 5I   
   $��:��6   $
��Left=�6   $��599,167,0,0q�68   $��1��6M   $	��Top=�6Z   $��26��6r   $��13��6~   �� 5J   
   $��:��6   $
��Left=�6   $��599,195,0,0q�68   $��1��6M   $	��Top=�6Z   $��26��6r   $��13��6~   �� 5K   
   $��:��6   $
��Left=�6   $��1��68   $	��Top=�6E   $ 0.808,0.673&�6]   $��599,223,0,0q�6�   $��26��6�   $��13��6�   �� 5L   
   $��:��6   $
��Left=�6   $��599,251,0,0q�68   $��1��6M   $	��Top=�6Z   $��26��6r   $��13��6~   �� 5M   
   $��:��6   $
��Left=�6   $��599,279,0,0q�68   $��1��6M   $	��Top=�6Z   $��26��6r   $��13��6~   �� 5N   
   -   5        $ labelMatricula��5N      $�� ��6(   $
��Left=�63   $��612,111,0,0q�6N   $��1��6c   $	��Top=�6p   $��26��6�   $	��149��6�   �� 5O   
   -   5        $ 
labelMarca��5O      $�� ��6$   $
��Left=�6/   $��612,139,0,0q�6J   $��1��6_   $	��Top=�6l   $��26��6�   $	��149��6�   �� 5P   
   -   5        $ labelTipoAeronave��5P      $�� ��6+   $
��Left=�66   $��612,167,0,0q�6Q   $��1��6f   $	��Top=�6s   $��26��6�   $	��149��6�   �� 5Q   
   -   5        $ labelHorasVueloAeronave��5Q      $�� ��61   $
��Left=�6<   $��612,195,0,0q�6W   $��1��6l   $	��Top=�6y   $��26��6�   $	��149��6�   �� 5R   
   -   5        $ labelUltmioVueloAeronave��5R      $�� ��62   $
��Left=�6=   $��612,223,0,0q�6X   $��1��6m   $	��Top=�6z   $��26��6�   $	��149��6�   �� 5S   
   -   5        $ labelVencDgac��5S      $�� ��6'   $
��Left=�62   $��609,251,0,0q�6M   $��1��6b   $	��Top=�6o   $��26��6�   $	��152��6�   �� 5T   
   -   5        $ labelVelMaxAeronave��5T      $�� ��6-   $
��Left=�68   $��609,279,0,0q�6S   $��1��6h   $	��Top=�6u   $��26��6�   $	��152��6�   �� 5U   
   $��
Rut Piloto��6   $
��Left=�6%   $��
40,401,0,0q�6@   $��1��6T   $	��Top=�6a   �� 5V   
   $��Nombre Piloto��6   $
��Left=�6(   $��
40,431,0,0q�6C   $��1��6W   $	��Top=�6d   �� 5W   
   $��Tipo de licencia��6   $
��Left=�6+   $��
40,457,0,0q�6F   $��1��6Z   $	��Top=�6g   �� 5X   
   $��Horas a volar��6   $
��Left=�6(   $��40,485,0,113q�6C   $��1��6Y   �� 5Y   
   $��:��6   $
��Left=�6   $��159,401,0,0q�68   $��1��6M   $	��Top=�6Z   $��26��6r   $��13��6~   �� 5Z   
   $��:��6   $
��Left=�6   $��159,485,0,0q�68   $��1��6M   $	��Top=�6Z   $��26��6r   $��13��6~   �� 5[   
   $��:��6   $
��Left=�6   $��159,457,0,0q�68   $��1��6M   $	��Top=�6Z   $��26��6r   $��13��6~   �� 5\   
   $��:��6   $
��Left=�6   $��159,429,0,0q�68   $��1��6M   $	��Top=�6Z   $��26��6r   $��13��6~   �� 5]   
   -   5        $ labelRutPiloto��5]      $�� ��6(   $
��Left=�63   $��172,401,0,0q�6N   $��1��6c   $	��Top=�6p   $	��158��6�   �� 5^   
   -   5        $ labelNombrePiloto��5^      $�� ��6+   $
��Left=�66   $��172,429,0,0q�6Q   $��1��6f   $	��Top=�6s   $	��158��6�   �� 5_   
   -   5        $ labelTipoLicenciaPiloto��5_      $�� ��61   $
��Left=�6<   $��172,457,0,0q�6W   $��1��6l   $	��Top=�6y   $	��158��6�   �� 5`   
   -   5        $ labelHorasPiloto��5`      $�� ��6*   $
��Left=�65   $��1��6P   $	��Top=�6]   $��172,485,0,0q�6u   $	��141��6�   �� 5a   
   $��Rut Copiloto��6   $
��Left=�6(   $��433,403,0,0q�6C   $��1��6X   $	��Top=�6e   �� 5b   
   $��Nombre Copiloto��6   $
��Left=�6+   $��433,431,0,0q�6F   $��1��6[   $	��Top=�6h   �� 5c   
   $��Tipo de Licencia��6   $
��Left=�6,   $��433,459,0,0q�6G   $��1��6\   $	��Top=�6i   �� 5d   
   $��Horas a volar��6   $
��Left=�6)   $��433,487,0,0q�6D   $��1��6Y   $	��Top=�6f   �� 5e   
   $��:��6   $
��Left=�6   $��1��68   $	��Top=�6E   $��26��6]   $��13��6i   $��599,485,0,0q�6t   �� 5f   
   $��:��6   $
��Left=�6   $��1��68   $	��Top=�6E   $��26��6]   $��13��6i   $��599,457,0,0q�6t   �� 5g   
   $��:��6   $
��Left=�6   $��1��68   $	��Top=�6E   $��26��6]   $��13��6i   $��599,429,0,0q�6t   �� 5h   
   $��:��6   $
��Left=�6   $��599,403,0,0q�68   $��1��6M   $	��Top=�6Z   $��26��6r   $��13��6~   �� 5i   
   -   5        $ labelRutCopiloto��5i      $�� ��6*   $
��Left=�65   $��1��6P   $	��Top=�6]   $��612,401,0,0q�6u   $	��120��6�   �� 5j   
   -   5        $ labelNombreCopiloto��5j      $�� ��6-   $
��Left=�68   $��1��6S   $	��Top=�6`   $��612,429,0,0q�6x   $	��138��6�   �� 5k   
   -   5        $ labelTipoLicenciaCopiloto��5k      $�� ��63   $
��Left=�6>   $��1��6Y   $	��Top=�6f   $��612,457,0,0q�6~   $	��138��6�   �� 5l   
   -   5        $ labelHorasCopiloto��5l      $�� ��6,   $
��Left=�67   $��1��6R   $	��Top=�6_   $��612,487,0,0q�6w   $	��138��6�   �� 5m   
   -   5        $	 buttonIngresar��5m      $��Ingresar Vuelo��6)   $
��Left=�6B   $��640,575,0,0q�6]   $��1��6r   $	��Top=�6   $��98��6�   6�   5n      5o      