   M S B A M L   `   `   `  ���� 
  Vistas#    Vistas.vtnModificarProyeccion   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       � Title$  vtnModificarProyeccion��$	��415��$	��699�� � 	Resources  �� Source�� $ MisEstilos.xaml?�%    .���  � ColumnDefinitions �� ��  � RowDefinitions �� .+�&   System.Windows.Controls.DataGrid  -   $��dataGridProyecciones��   AutoGenerateColumns .  $	��263��$
��Left=�$��	12,42,0,0q�$	��Top=�$	��327��$��2��   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ Codigo��1  +System.Windows.Controls.DataGridBoundColumn   Binding �� 	 �� Path$	 Proy_codigo�  $ Fecha�� �� $	 
Proy_fecha�  $
 Hora�� �� $	 	Proy_hora�  $
 Sala�� �� $	 Proy_nroSala��� -   $��
textBlock1��$��23��$��Center=�$��220,12,230,340q�$��PROYECCIONES��$��Center=�$��22(�$��Rockwell)�
��������� -   $��	txtBlock1��$��23��$��Codigo��$��Center=�$��16,74,261,278q�$��Center=�$��1���� -   $��	txtBlock2��$��23��$��Fecha��$��1��$��15,114,261,238q��� -   $��	txtBlock3��$��23��$
��Hora��$��1��$��16,155,272,198q��� -   $��	txtBlock4��$��23��$��Numero de sala��$��1��$��15,194,188,159q��� -   $��	txtBlock5��$��Codigo de pelicula��$��1��$��16,233,160,120q��� -   $��	Modificar��$��40��$	��115��$��1��$��15,308,133,28q�
�������� -	   $��Cancelar��$��40��$	��115��$��1��$��192,308,32,28q��� -
   $��	txtCodigo��$	��120��$��23��$�� ��$��1��$��188,75,30,278q��� -   $��txtFecha��$	��120��$��23��$�� ��$��1��$��187,115,32,238q��� -   $��txtHora��$	��120��$��23��$�� ��$��1��$��188,155,31,198q��� -   $��txtNumeroSala��$	��120��$��23��$�� ��$��1��$��187,195,32,158q��� -   $��txtCodigoPelicula��$	��120��$��23��$�� ��$��1��$��188,233,31,120q����� 
 �� ImageSource$)
 #Images/abmbackground%20-%20alta.png�� j� Stretch$
 Fill=�