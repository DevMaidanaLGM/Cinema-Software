   M S B A M L   `   `   `  ����D  @MisClases, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null8*clr-namespace:MisClases;assembly=MisClases	MisClases  5   	   
 Vistas'   !Vistas.vtnProyeccionesAlmacenadas   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   <DATOS*clr-namespace:MisClases;assembly=MisClases     5   	   -   5          � Title$  Proyecciones disponibles��5   	   $	��632��6*   $	��931��67    � 	Resources 5       �� MergedDictionaries �� Source   ListadoProyecciones S� 
ObjectType$   MisClases.TrabajarProyecciones S� 
MethodName�� 5   
    5	      �� 5
      $ MisEstilos.xaml?�6%   6@   %:   &	        S� 5      "  6=   $ listado��6n   6�   5      .��5      � .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dataGridUsuarios��5         CanUserAddRows . $
��Left=�6C   $��
65,175,0,0q�6^   $	��Top=�6r   $	��210��6�   $	��659��6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5       ,  &System.Windows.Controls.DataGridColumn	   Header$	 Cod Proyeccion��6m   
   Width5  /System.Windows.Controls.DataGridLengthConverter$	
 100 6�   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   ��  �� Path$ Proy_codigo�   ClipboardContentBinding 6J   Z� 6�     5!      $	 Fecha��6q   $	
 100 6�    6%   �� $ Proy_fecha_hora� 6N   Z� 6�     5"      $
	 Hora��6n   $	
 100 6}    6%   �� $ Proy_nroSala� 6K   Z� 6}     5#      $
	 Sala��6x   $	
 100 6�    6%   �� $ Sala.Sala_denominacion� 6U   Z� 6�     5$      $	 Pelicula��6v   $	
 100 6�    6%   �� $ Pelicula.Peli_titulo� 6S   Z� 6�   5&      �� 5-   
   -   5        $��
textBlock1��5-   U   $��23��6   $��Center=�6    $��338,12,354,558q�6=   $��PROYECCIONES��6g   $��Center=�6{   $��22(�6�   $��Rockwell)�6�   
�������6�   �� 5/   
   -   5        $��	btnVolver��5/   ^   $��Volver��6   $��43��6"   $
��Left=�6.   $��391,519,0,0q�6I   $	��Top=�6o   $	��107��6�   6�   �� 50   
   -   5        $��	groupBox1��50   _   $��Filtros��6   $	��100��6$   $
��Left=�61   $��	65,64,0,0q�6L   $	��Top=�6p   $	��659��6�   .��51      � .+�52      �� -   5        $��label1��52   c   $��Fecha:��6   $��28��6)   $
��Left=�65   $��	29,42,0,0q�6P   $	��Top=�6q   (  "System.Windows.Controls.DatePicker  53      -   5        $��fechaFiltro��53   X   $��25��6   $
��Left=�6)   $��
100,45,0,0q�6D   $	��Top=�6k   $	��115��6�   �� 54      -   5        $��label2��54   g   $��	Pelicula:��6   $��27��6,   $
��Left=�68   $��
256,42,0,0q�6S   $	��Top=�6u   $��87��6�   �� 55      -	   5        $��txtPelicula��55   U   $��23��6   $
��Left=�6&   $��
349,43,0,0q�6A   $	��Top=�6h   $	��120��6�   �� 56      -
   5        $��button1��56   f   $��Filtrar��6   $��34��6+   $
��Left=�67   $��
520,35,0,0q�6R   $	��Top=�6u   $	��113��6�   6�   57      58      �� 59   
   -   5        $��button2��59   `   $��Mas info��6   $��54��6$   $
��Left=�60   $��809,331,0,0q�6K   $	��Top=�6o   $��88��6�   6�   ��5:   
   �� 5;       �� ImageSource$ Images/3.jpg��6   66   5=      5>      