   M S B A M L   `   `   `  ���� D  @MisClases, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null8*clr-namespace:MisClases;assembly=MisClases	MisClases  
 Vistas   Vistas.VtnClienteAlta   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     <DATOS*clr-namespace:MisClases;assembly=MisClases       � Title$  Alta de Cliente��$	��510��$	��394�� � 	Resources  �� 
TargetType �� Property �� Value �� Triggers P� Property P� Value   oCliente S� 
ObjectType   MisClases.Cliente  	oCliente2  TextBoxErrorTemplate	 � Color
 � Offset  EstiloError �� Path �� Self �� RelativeSource��%^  '��       '��     '�� j    &	  �    &	 �    &	 �    &	 X    7  �� " ��.���  � ��$ Rockwell)���  � ��$ 18(���  � �� �	#FF7E0404��  � ��
 �������  � ��$ 5q���  � ��
 ����� P�  �@J�IsMouseOver . . ���  � ��$ 22(���  � ��$
 Bold"���  � �� �#0ED119�� " ��.���  � ��$ Rockwell)���  � ��
 �������  � ��$ 18(��� " ��.���  � ��$ Rockwell)���  � ��
 �������  � ��$ 18(�S� "    �� .R�]� .+�A� $��Right=�$	��2,0q�$��10��$��10������ .��� $	 	#11FF1111��$
 0Q�� $	 	#FFFF0000��$
 1Q��� �� " ��.���  � ��$ 4,4,10,4q���  �@=�ErrorTemplate8    P�  �@=�HasError . . ���  �@�ToolTip �� $) #(Validation.Errors)[0].ErrorContent�# Z .���  � RowDefinitions �� �� �� �� �� �� ��  � ColumnDefinitions �� �� .+��� -   $��
textBlock1��$��2��$��23��$��Center=�$��0q�$��ALTA DE CLIENTE��$��Center=�$��22(�$��Rockwell)�
��������� -   $��
textBlock2��$��1��$��23��$��Center=�$��0q�$	��DNI��$��Center=��� -   $��
textBlock3��$��2��$��23��$��Center=�$��0q�$��Nombre��$��Center=��� -   $��
textBlock4��$��3��$��23��$��Center=�$��0q�$��Apellido��$��Center=��� -   $��
textBlock5��$��4��$��23��$��Center=�$��0q�$��Telefono��$��Center=��� -   $��
textBlock6��$��5��$��23��$��Center=�$��0q�$��Email��$��Center=��� -   $��txtDni��$��1��$��1��$��23��$��Center=�$��0q�$��Center=�$	��120��#��[ ����  �� Source# [  $ Cli_dni� �� ValidatesOnDataErrors .  �� ValidatesOnExceptions . �� -   $��	txtNombre��$��1��$��2��$��23��$��Center=�$��0q�$��Center=�$	��120��#��[ ���� # [  $ 
Cli_nombre� .  . �� -	   $��txtApellido��$��1��$��3��$��23��$��Center=�$��0q�$��Center=�$	��120��#��[ ���� # [  $ Cli_apellido� .  . �� -
   $��txtTelefono��$��1��$��4��$��23��$��Center=�$��0q�$��Center=�$	��120��#��[ ���� # [  $ Cli_telefono� .  . �� -   $��txtEmail��$��1��$��5��$��23��$��Center=�$��0q�$��Center=�$	��120��#��[ ���� # [  $ 	Cli_email� .  . �� -   $��
btnAceptar��$��Agregar��$��6��$��40��$��Center=�$��45,15,26,12q�$��Center=�$	��115��
�������� -   $��btnCancelar��$��Cancelar��$��1��$��6��$��40��$��Center=�$��33,15,33,12q�$��Center=�$	��115������  �� ImageSource$) #Images/abmbackground%20-%20alta.png�� j� Stretch$ UniformToFill=�