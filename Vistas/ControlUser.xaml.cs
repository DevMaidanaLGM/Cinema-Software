using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MisClases;

namespace Vistas
{
    /// <summary>
    /// Lógica de interacción para ControlUser.xaml
    /// </summary>
    public partial class ControlUser : UserControl
    {
        public ControlUser()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, RoutedEventArgs e)
        {
            string user = txtUsuario.Text;
            string pass = psbContraseña.Password;

            if(TrabajarUsuarios.login(user, pass))
            {
               // MessageBox.Show(TrabajarUsuarios.TraerRol(user, pass).Rol_codigo);
                VtnPrincipal principal = new VtnPrincipal(TrabajarUsuarios.TraerRol(user,pass).Rol_codigo , TrabajarUsuarios.TraerRol(user,pass).Usu_apellidoNombre);
                principal.Show();
                Window.GetWindow(this).Close();
            
            }

            else
            {
                MessageBox.Show("Usuario o contraseña incorrecta");
            }


            //Usuario oUsuario1 = new Usuario();
            //oUsuario1.Usu_id = 1;
            //oUsuario1.Usu_nombreUsuario = "admin";
            //oUsuario1.Usu_contraseña = "123";
            //oUsuario1.Usu_apellidoNombre = "Mario Perez";
            //oUsuario1.Rol_codigo = "1"; // ROL ADMINISTRADOR

            //Usuario oUsuario2 = new Usuario();
            //oUsuario2.Usu_id = 2;
            //oUsuario2.Usu_nombreUsuario = "jose";
            //oUsuario2.Usu_contraseña = "123";
            //oUsuario2.Usu_apellidoNombre = "Juan Sanchez";
            //oUsuario2.Rol_codigo = "2"; // ROL VENDEDOR


        //    if (oUsuario1.Usu_nombreUsuario == user && oUsuario1.Usu_contraseña == pass)
        //    {
        //        MessageBox.Show("Bienvenido Usuario: " + user, "SISTEMA", MessageBoxButton.OK, MessageBoxImage.Information);

        //        VtnBienvenida vt = new VtnBienvenida();


        //        VtnPrincipal principal = new VtnPrincipal(oUsuario1.Rol_codigo);
        //        principal.Show();
        //        Window.GetWindow(this).Close();
               

        //    }
        //    else if (oUsuario2.Usu_nombreUsuario == user && oUsuario2.Usu_contraseña == pass)
        //    {
        //        MessageBox.Show("Bienvenido Usuario: " + user, "SISTEMA", MessageBoxButton.OK, MessageBoxImage.Information);
               
        //        VtnBienvenida vt = new VtnBienvenida();
        //        vt.Close();
        //        VtnPrincipal principal = new VtnPrincipal(oUsuario2.Rol_codigo);
        //        principal.Show();
        //        Window.GetWindow(this).Close();
               

        //    }
        //    else
        //    {
        //        MessageBox.Show("Usuario o contraseña incorrecta");
        //    }

        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
