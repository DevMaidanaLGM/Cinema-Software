   M S B A M L   `   `   `  ���� D  @MisClases, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null8*clr-namespace:MisClases;assembly=MisClases	MisClases  O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 
 Vistas    Vistas.VtnModificarCliente   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     <DATOS*clr-namespace:MisClases;assembly=MisClases     8TIPOS&clr-namespace:System;assembly=mscorlib       � Title$  Modificar Cliente��$	��510��$	��394�� � 	Resources  �� 
TargetType �� Property �� Value   oCliente S� 
ObjectType    MisClases.TrabajarClientes S� 
MethodName S� MethodParameters  TextBoxErrorTemplate � Color	 � Offset  EstiloError
 �� Triggers P� Property P� Value �� Path �� Self �� RelativeSource��%  '��       '�� �     '�� �     &	  P    &	     &	     7  �� " ��.���  � ��$ Rockwell)���  � ��$ 18(���  � �� �	#FF7E0404��  � ��
 �������  � ��$ 5q���  � ��
 ������� " ��.���  � ��$ Rockwell)���  � ��
 �������  � ��$ 18(��� " ��.���  � ��$ Rockwell)���  � ��
 �������  � ��$ 18(�S� "  $ TraerCliente�� ��1111���� .R�]� .+�A� $��Right=�$	��2,0q�$��10��$��10������ .��� $ 	#11FF1111��$	 0Q�� $ 	#FFFF0000��$	 1Q��� �� " ��.���  � ��$ 4,4,10,4q���  �@=�ErrorTemplate8   
 P�  �@=�HasError . . ���  �@�ToolTip �� $) #(Validation.Errors)[0].ErrorContent�# Z .���  � RowDefinitions �� �� �� �� �� �� �� ��  � ColumnDefinitions �� �� .+��� -   $��
textBlock1��$��2��$��23��$��Center=�$��0q�$��MODIFICAR CLIENTE��$��Center=�$��22(�$��Rockwell)�
��������� -   $��
textBlock2��$��2��$��23��$��Center=�$��75,14,79,22q�$	��DNI��$��Center=��� -   $��
textBlock3��$��3��$��23��$��Center=�$��57,14,61,22q�$��Nombre��$��Center=��� -   $��
textBlock4��$��4��$��23��$��Center=�$��55,14,59,22q�$��Apellido��$��Center=��� -   $��
textBlock5��$��5��$��23��$��Center=�$��55,13,59,22q�$��Telefono��$��Center=��� -   $��
textBlock6��$��6��$��23��$��Center=�$��68,14,72,22q�$��Email��$��Center=��� -   $��txtDni��$��1��$��2��$��23��$��Center=�$��31,14,35,22q�$��Center=�$	��120��#��[ ����  �� Source# [  $ Cli_dni� �� ValidatesOnDataErrors .  �� ValidatesOnExceptions . �� -   $��	txtNombre��$��1��$��3��$��23��$��Center=�$��31,14,35,22q�$��Center=�$	��120��#��[ ���� # [  $ 
Cli_nombre� .  . �� -	   $��txtApellido��$��1��$��4��$��23��$��Center=�$��31,14,35,22q�$��Center=�$	��120��#��[ ���� # [  $ Cli_apellido� .  . �� -
   $��txtTelefono��$��1��$��5��$��23��$��Center=�$��31,13,35,22q�$��Center=�$	��120��#��[ ���� # [  $ Cli_telefono� .  . �� -   $��txtEmail��$��1��$��6��$��23��$��Center=�$��31,14,35,22q�$��Center=�$	��120��#��[ ���� # [  $ 	Cli_email� .  . �� -   $��
btnAceptar��$��	Modificar��$��7��$��40��$��Center=�$��
43,7,28,12q�$��Center=�$	��115��
�������� -   $��btnCancelar��$��Cancelar��$��1��$��7��$��40��$��Center=�$��
34,7,38,12q�$��Center=�$	��115���� -   $��
textBlock7��$��1��$��23��$
��Left=�$��	55,18,0,0q�$��BUSCAR��$	��Top=��� -   $��	txtBuscar��$��1��$��1��$��23��$
��Left=�$��	32,18,0,0q�$	��Top=�$	��120��.������ # [  $ MethodParameters[0]� �� BindsDirectlyToSource .  �� UpdateSourceTrigger$ PropertyChanged=� .  . .������  �� ImageSource$) #Images/abmbackground%20-%20alta.png�� j� Stretch$ UniformToFill=�