   M S B A M L   `   `   `  ����D  @MisClases, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null8*clr-namespace:MisClases;assembly=MisClases	MisClases  5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R8clr-namespace:System.ComponentModel;assembly=WindowsBaseSystem.ComponentModel 5   	   R8clr-namespace:System.ComponentModel;assembly=WindowsBaseSystem.ComponentModel 5   	   
 Vistas   Vistas.VtnListaUsuarios   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   <DATOS*clr-namespace:MisClases;assembly=MisClases     5   	   Hscm8clr-namespace:System.ComponentModel;assembly=WindowsBase     5   	   ScomponentModel8clr-namespace:System.ComponentModel;assembly=WindowsBase     5   	     � Title$  Listado de Usuarios��5   	   $	��445��6%   $	��598��62    � 	Resources 5	       �� 
TargetType �� Property �� Value   ListadoUsuarios S� 
ObjectType    MisClases.TrabajarUsuarios S� 
MethodName  UsuariosOrdenados �� Source �� SortDescriptions+  %System.ComponentModel.SortDescription	   PropertyName��%�  '��       &	      &	 F    7   �� 5
   
   " ��6   .�5      ��  � ��$ Rockwell)�6+   �� 5       � ��$ 18(�6)   �� 5       � �� �	#FF7E04046+   �� 5       � ��
 �����6,   �� 5       � ��$ 5q�60   �� 5       � ��
 �����6+   5      S� 5   
   "  65   $ TraerUsuariosCol��6b   6�   �� 5   
   -   5        8    5        5       $	 Usu_nombreUsuario��61   5"      5#      .��5$      � .+�5%   
   �� -   5        $��
lvUsuarios��5%   t   $��	0,90,0,64q�6a   $��Georgia)�6�   $��16(�6�   ��6   �� 
 �� Source#
 [  �� View 5&      �� 5'      .P�5(      �� $��Codigo��6%    �� Width$ 70��6b    �� DisplayMemberBinding 65   ��  �� Path$ Usu_id�6o   �� 5)      $��Nombre de Usuario��6%   $	 150��6x    6@   �� $ Usu_nombreUsuario�6�   �� 5*      $��Apellido y Nombre��6%   $	 150��6y    6@   �� $ Usu_apellidoNombre�6�   �� 5+      $	��Rol��6%   $	 120��6n    62   �� $ Roles.Rol_descripcion�6|   5-      5/      �� 50   
   -   5        $��	btnVolver��50   ^   $��Volver��6   $��41��6"   $
��Left=�6.   $��229,353,0,0q�6I   $	��Top=�6o   $	��120��6�   6�   �� 51   
   -   5        $��btnVistaPrevia��51   d   $��Vista previa��6   $��41��6(   $
��Left=�64   $��411,353,0,0q�6O   $	��Top=�6z   6�   �� 52   
   -   5        $��
textBlock1��52   O   $��24��6   $
��Left=�6    $��
156,12,0,0q�6;   $��LISTADO DE USUARIOS��6a   $	��Top=�6|   $	��257��6�   $��Rockwell)�6�   
�������$��22(�6�   �� 54   
   -   5        $��
textBlock2��54   N   $��23��6   $
��Left=�6    $��	22,61,0,0q�6;   $��Buscar por usuario:��6`   $	��Top=�6{   $	��130��6�   $��Rockwell)�6�   
�������$��15(�6�   �� 55   
   -   5        $��txtNombreUsuario��55   M   $��23��6   $
��Left=�6   $��
156,59,0,0q�69   $	��Top=�6e   $	��120��6}   6�   ��56   
   �� 57       �� ImageSource$ Images/3.jpg��6   66   59      5:      