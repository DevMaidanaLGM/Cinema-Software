   M S B A M L   `   `   `  ����D  @MisClases, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null8*clr-namespace:MisClases;assembly=MisClases	MisClases  5   	   
 Vistas    Vistas.VtnListadoPeliculas   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   <DATOS*clr-namespace:MisClases;assembly=MisClases     5   	     � Title$  Listado de Peliculas��5   	   $	��445��6&   $	��598��63    � 	Resources 5       �� 
TargetType �� Property �� Value   ListadoPeliculas S� 
ObjectType!   MisClases.TrabajarPeliculas S� 
MethodName��%X  '��       &	      �� 5   
   " ��6   .�5      ��  � ��$ Rockwell)�6+   �� 5	       � ��$ 18(�6)   �� 5
       � �� �	#FF7E04046+   �� 5       � ��
 �����6,   �� 5       � ��$ 5q�60   �� 5       � ��
 �����6+   5      S� 5   
   "  66   $ TraerPeliculas��6d   6�   5      .��5      � .+�5   
   �� $��	0,51,0,64q�6`   $��Georgia)�6s   $��16(�6�   ��6   ��  �� Source# [   �� View 5      �� 5      .P�5      �� $��Codigo��6%   	 �� Width$	 80��6g   
 �� DisplayMemberBinding
 65   ��  �� Path$ peli_codigo�6t   �� 5      $��Titulo��6%   $		 200��6g   
 65   �� $ peli_titulo�6u   �� 5      $��Duracion��6%   $	 80��6k   
 67   �� $ peli_duracion�6x   �� 5      $��Genero��6%   $		 120��6g   
 65   �� $ peli_genero�6u   �� 5      $��Clase��6%   $	 80��6e   
 64   �� $ 
peli_clase�6r   5      5      �� 5   
   -   5        $��	btnVolver��5   ^   $��Volver��6   $��41��6"   $
��Left=�6.   $��229,353,0,0q�6I   $	��Top=�6o   $	��120��6�   6�   �� 5   
   -   5        $��
textBlock1��5   O   $��24��6   $
��Left=�6    $��
156,12,0,0q�6;   $��LISTADO DE PELICULAS��6a   $	��Top=�6}   $	��257��6�   $��Rockwell)�6�   
�������$��22(�6�   ��5   
   �� 5        �� ImageSource$ Images/3.jpg��6   66   5"      5#      