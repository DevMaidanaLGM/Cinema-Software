   M S B A M L   `   `   `  ����D  @MisClases, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null8*clr-namespace:MisClases;assembly=MisClases	MisClases  5   	   
 Vistas   Vistas.VtnListadoCliente   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   <DATOS*clr-namespace:MisClases;assembly=MisClases     5   	     � Title$  Lista de clientes��5   	   $	��445��6#   $	��598��60    � 	Resources 5       �� 
TargetType �� Property �� Value   ListadoClientes S� 
ObjectType    MisClases.TrabajarClientes S� 
MethodName��%R  '��       &	      �� 5   
   " ��6   .�5      ��  � ��$ Rockwell)�6+   �� 5	       � ��$ 18(�6)   �� 5
       � �� �	#FF7E04046+   �� 5       � ��
 �����6,   �� 5       � ��$ 5q�60   �� 5       � ��
 �����6+   5      S� 5   
   "  65   $ TraerCli��6b   6z   5      .��5      � .+�5   
   �� $��	0,51,0,64q�6_   $��Georgia)�6r   $��16(�6�   ��6   ��  �� Source# [   �� View 5      �� 5      .P�5      �� $	��Dni��6%   	 �� Width$	 80��6`   
 �� DisplayMemberBinding
 62   ��  �� Path$ cli_dni�6m   �� 5      $��Nombre��6%   $		 100��6f   
 65   �� $ 
cli_nombre�6t   �� 5      $��Apellido��6%   $	 80��6j   
 67   �� $ cli_apellido�6w   �� 5      $��Telefono��6%   $		 120��6j   
 67   �� $ cli_telefono�6x   �� 5      $��Email��6%   $		 150��6d   
 64   �� $ 	cli_email�6r   5      5      �� 5   
   -   5        $��	btnVolver��5   ^   $��Volver��6   $��41��6"   $
��Left=�6.   $��229,353,0,0q�6I   $	��Top=�6o   $	��120��6�   6�   �� 5   
   -   5        $��
textBlock1��5   O   $��24��6   $
��Left=�6    $��
156,12,0,0q�6;   $��LISTADO DE CLIENTES��6a   $	��Top=�6|   $	��257��6�   $��Rockwell)�6�   
�������$��22(�6�   ��5   
   �� 5        �� ImageSource$ Images/3.jpg��6   66   5"      5#      