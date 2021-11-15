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
    /// Lógica de interacción para VtnListaUsuarios.xaml
    /// </summary>
    public partial class VtnListaUsuarios : Window
    {

        private CollectionViewSource vistaColeccionFiltrada; // vista de colección filtrada
        private String txtUsername = "";
        public VtnListaUsuarios()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;

            vistaColeccionFiltrada = Resources["UsuariosOrdenados"] as CollectionViewSource; // x:Key del CollectionViewSource (XAML)

        }

        private void btnVolver_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }

        private void txtNombreUsuario_TextChanged(object sender, TextChangedEventArgs e)
        {


            txtUsername = txtNombreUsuario.Text.ToString();
            //  MessageBox.Show(txtUsername);

            if (vistaColeccionFiltrada != null)
            {
                // Se invoca al método eventVistaUsuario_Filter a medida que escriba en el TextBox
                vistaColeccionFiltrada.Filter += eventVistaUsuario_Filter;
            }
        }


        private void eventVistaUsuario_Filter(object sender, FilterEventArgs e)
        {
            Usuario usuario = e.Item as Usuario;

            // Se realiza la búsqueda por el Rol

            if ((txtUsername == "") == false)
            {
                if (usuario.Usu_nombreUsuario.StartsWith(txtUsername, StringComparison.CurrentCultureIgnoreCase))
                {
                    e.Accepted = true;
                }
                else
                {
                    e.Accepted = false;
                }
            }

        }

        private void btnVistaPrevia_Click(object sender, RoutedEventArgs e)
        {
            vtnVistaPreviaUsuarios vistaPreviaUsuarios = new vtnVistaPreviaUsuarios(txtUsername);
            vistaPreviaUsuarios.Show();
            this.Hide();
        }












    }
}








