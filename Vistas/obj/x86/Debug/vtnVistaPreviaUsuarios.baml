   M S B A M L   `   `   `  ����D  @MisClases, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null8*clr-namespace:MisClases;assembly=MisClases	MisClases  5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R8clr-namespace:System.ComponentModel;assembly=WindowsBaseSystem.ComponentModel 5   	   R8clr-namespace:System.ComponentModel;assembly=WindowsBaseSystem.ComponentModel 5   	   
 Vistas#   Vistas.vtnVistaPreviaUsuarios   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   <DATOS*clr-namespace:MisClases;assembly=MisClases     5   	   Hscm8clr-namespace:System.ComponentModel;assembly=WindowsBase     5   	   ScomponentModel8clr-namespace:System.ComponentModel;assembly=WindowsBase     5   	     � Title$  Vista previa de impresion��5   	   $	��445��6+   $	��690��68    � 	Resources 5       �� 
TargetType �� Property �� Value   ListadoUsuarios S� 
ObjectType    MisClases.TrabajarUsuarios S� 
MethodName  UsuariosOrdenados �� Source �� SortDescriptions+  %System.ComponentModel.SortDescription	   PropertyName��%�  '��       &	      &	 A    7   �� 5
   
   " ��6   .�5      ��  � ��$ Rockwell)�6+   �� 5       � ��$ 18(�6)   �� 5       � �� �	#FF7E04046+   �� 5       � ��
 �����6,   �� 5       � ��$ 5q�60   �� 5       � ��
 �����6+   5      S� 5   
   "  65   $ TraerUsuariosCol��6b   �� 5   
   -   5        8    5        5      $	 Usu_nombreUsuario��61   5      5      .��5      � 
 � RowDefinitions
 5   
   �� 5      $��* �6   �� 5       $
��Auto �6   .+�5"   
   -� $��0,0,12,0q�6   $��0��6/   .��5$      /� -   5         �Name$ Document��5$      .T�5%      �� .r�5&      �� -   5        $��
LvUsuarios��5&   ~   $��0,0,0,0q�6m   ��6   ��  �� Source# [  �� View 5'      �� 5(      .P�5)   "   �� $��Codigo��61    �� DisplayMemberBinding 6A   ��  �� Path$ Usu_id��� 5*   "   $��Nombre de usuario��61    �� Width$	 200��6�    6L   �� $ Usu_nombreUsuario�6�   �� 5+   "   $��Nombre��61   $	 200��6z    6A   �� $ Usu_apellidoNombre�6z   �� 5,   "   $	��Rol��61   $	 100��6z    6>   �� $ Roles.Rol_descripcion�6z   5-      5/      50      51      52      �� 54   
   -   5        $��btnImprimir��54   l   $��1��6   $��Imprimir��6   $��41��61   $
��Left=�6=   $��
253,18,0,0q�6X   $	��Top=�6   $	��120��6�   6�   �� 55   
   -   5        $��	btnVolver��55   j   $��1��6   $��Volver��6   $��41��6/   $
��Left=�6;   $��
514,18,0,0q�6V   $	��Top=�6{   $	��120��6�   6�   5:      5;      