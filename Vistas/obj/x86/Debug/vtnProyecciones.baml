   M S B A M L   `   `   `  ����
  Vistas    Vistas.DataGrid   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  DataGrid��5   	   $	��415��6   $	��699��6'    � 	Resources 5       �� Source�� 5   
   $ MisEstilos.xaml?�6   %    68   .��5      �  � RowDefinitions 5	   
   �� 5
       � ColumnDefinitions 5   
   �� 5      .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��	dataGrid1��5   j      AutoGenerateColumns .  $	��263��6/   $
��Left=�6<   $��	12,43,0,0q�6W   $	��Top=�6{   $	��653��6�   $��Georgia)�6�   $��16(�6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Codigo��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 65   �� 	 �� Path$	 Proy_codigo�  5      $ Fecha��6%    64   �� $	 
Proy_fecha�  5      $
 Hora��6%    63   �� $	 	Proy_hora�  5      $
 Sala��6%    63   �� $	 Proy_nroSala�5      �� 5   
   -   5        $��
textBlock1��5   U   $��23��6   $��Center=�6    $��220,12,230,340q�6=   $��PROYECCIONES��6g   $��Center=�6{   $��22(�6�   $��Rockwell)�6�   
�������6�   �� 5   
   -   5        $��	btnVolver��5   ^   $��Volver��6   $��43��6"   $
��Left=�6.   $��285,321,0,0q�6I   $	��Top=�6o   $	��107��6�   6�   ��5   
   �� 5      
 �� ImageSource$
 Images/3.jpg��6   66   5      5       