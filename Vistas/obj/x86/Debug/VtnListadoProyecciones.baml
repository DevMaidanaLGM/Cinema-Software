   M S B A M L   `   `   `  ����D  @MisClases, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null8*clr-namespace:MisClases;assembly=MisClases	MisClases  5   	   
 Vistas#   Vistas.VtnListadoProyecciones   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   <DATOS*clr-namespace:MisClases;assembly=MisClases     5   	   -   5          � Title$  Listado de Proyecciones��5   	   $	��426��6)   $	��870��66    � 	Resources 5       �� MergedDictionaries �� Source   ListadoProyecciones S� 
ObjectType$   MisClases.TrabajarProyecciones S� 
MethodName�� 5   
    5      �� 5	      $ MisEstilos.xaml?�6%   6@   %:   &	        S� 5      "  6=   $ listado��6n   6�   5      .��5      � .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dataGridUsuarios��5         CanUserAddRows . $
��Left=�6C   $��	36,54,0,0q�6^   $	��Top=�6q   $	��210��6�   $	��659��6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 Cod Proyeccion��6m   
   Width5  /System.Windows.Controls.DataGridLengthConverter$	
 100 6�   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   ��  �� Path$ Proy_codigo�   ClipboardContentBinding 6J   Z� 6�     5      $	 Fecha��6q   $	
 100 6�    6%   �� $ Proy_fecha_hora� 6N   Z� 6�     5      $
	 Hora��6n   $	
 100 6}    6%   �� $ Proy_nroSala� 6K   Z� 6}     5      $
	 Sala��6x   $	
 100 6�    6%   �� $ Sala.Sala_denominacion� 6U   Z� 6�     5      $	 Pelicula��6v   $	
 100 6�    6%   �� $ Pelicula.Peli_titulo� 6S   Z� 6�   5      �� 5   
   -   5        $��	btnVolver��5   ^   $��Volver��6   $��43��6"   $
��Left=�6.   $��306,303,0,0q�6I   $	��Top=�6o   $	��107��6�   6�   �� 5   
   -   5        $��
textBlock1��5   O   $��23��6   $
��Left=�6    $��
222,12,0,0q�6;   $��LISTADO DE PROYECCIONES��6a   $	��Top=�6�   �� 5   
   -   5        $��button1��5   a   $��	Modificar��6   $��37��6%   $
��Left=�61   $��701,164,0,0q�6L   $	��Top=�6p   $	��135��6�   6�   ��5   
   �� 5        �� ImageSource$ Images/3.jpg��6   66   5#      5$      