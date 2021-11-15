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
using System.Windows.Shapes;
using MisClases;

namespace Vistas
{
    /// <summary>
    /// Interaction logic for VtnPrincipal.xaml
    /// </summary>
    public partial class VtnPrincipal : Window
    {
        private string p;
        private string nombre;
        
     public VtnPrincipal()
        {
            // TODO: Complete member initialization
            InitializeComponent();
            
        }
        public VtnPrincipal(string p, string nombre)
        {
            VtnBienvenida vt = new VtnBienvenida();
            vt.Hide();
            InitializeComponent();
          
            this.nombre = nombre;

        

           WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
          
            this.p = p;
            if (p == "1")
            {
                menuClientes.IsEnabled = false;
                menuTickets.IsEnabled = false;
            }
            else if (p == "2")
            {
                menuUsuarios.IsEnabled = false;
                menuPeliculas.IsEnabled = false;
                //menuButacas.IsEnabled = false;
                menuProyecciones.IsEnabled = false;
            }
        }

        

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            VtnPeliculaAlta vtnPeliculaAlta = new VtnPeliculaAlta();
            vtnPeliculaAlta.Show();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            VtnClienteAlta vtnClienteAlta = new VtnClienteAlta();
            vtnClienteAlta.Show();
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
          
        }

        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
            VtnBienvenida vtnBienvenida = new VtnBienvenida();
            vtnBienvenida.Show();
            this.Hide();
        }

        private void MenuItem_Click5(object sender, RoutedEventArgs e) {
            vtnNuevaProyeccion vtnNp = new vtnNuevaProyeccion();
            vtnNp.Show();
        }

        private void MenuItem_Click6(object sender, RoutedEventArgs e){
            vtnProyeccionesAlmacenadas vtnpro = new vtnProyeccionesAlmacenadas();
            vtnpro.Show();

        }

        private void MenuItem_Click_5(object sender, RoutedEventArgs e)
        {
            VtnListadoProyecciones vtnListadoProy = new VtnListadoProyecciones();
            vtnListadoProy.Show();
        }

        private void MenuItem_Click_6(object sender, RoutedEventArgs e)
        {
            VtnListadoPeliculas vtnListadoPeliculas = new VtnListadoPeliculas();
            vtnListadoPeliculas.Show();
        }

        private void MenuItem_Click_7(object sender, RoutedEventArgs e)
        {
            VtnModificarCliente vtnModificarCliente = new VtnModificarCliente();
            vtnModificarCliente.Show();
        }

        private void MenuItem_Click_8(object sender, RoutedEventArgs e)
        {
            VtnUsuariosAlta vtnUsuarioAlta = new VtnUsuariosAlta();
            vtnUsuarioAlta.Show();
            
        }

            private void Usuario_Click_listado(object sender, RoutedEventArgs e)
        {
            VtnListaUsuarios vtnListaUsuarios = new VtnListaUsuarios();
            vtnListaUsuarios.Show();
            
        }

            private void MenuItem_Click_9(object sender, RoutedEventArgs e)
            {
                VtnVentaTicket vtnVentaTicket = new VtnVentaTicket(nombre);
                //MessageBox.Show(nombre);
                vtnVentaTicket.Show();
            }

            private void Window_Loaded(object sender, RoutedEventArgs e)
            {
                //Reproduccion de Audio
                string path = System.IO.Directory.GetCurrentDirectory().ToString();
                path = path.Remove(path.Length - 9);
                System.Media.SoundPlayer sp = new System.Media.SoundPlayer(@path+"Sonido/checkon.wav");
                sp.Play();
                //sp.PlaySync();
            }

            private void MenuItem_Click_10(object sender, RoutedEventArgs e)
            {
                VtnListadoCliente vtnListadoCliente = new VtnListadoCliente();
                vtnListadoCliente.Show();
            }

            
            }



   
    }

