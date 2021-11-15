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
    /// Interaction logic for vtnVistaPreviaUsuarios.xaml
    /// </summary>
    public partial class vtnVistaPreviaUsuarios : Window
    {
        private String usuarioFiltrado = "";
        public vtnVistaPreviaUsuarios(String usuario)
        {
            usuarioFiltrado = usuario;
            InitializeComponent();
        }
        /// <summary>
        /// Metodo para tomar la lista de usuarios filtrados por el usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CollectionViewSource_Filter(object sender, FilterEventArgs e)
        {
            Usuario usuario = e.Item as Usuario;
            if ((usuarioFiltrado == "") == false)
            {
                if (usuario.Usu_nombreUsuario.StartsWith(usuarioFiltrado, StringComparison.CurrentCultureIgnoreCase))
                {
                    e.Accepted = true;
                }
                else
                {
                    e.Accepted = false;
                }
            }
        }
        /// <summary>
        /// Metodo para imprimir el documento dinamico
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnImprimir_Click(object sender, RoutedEventArgs e)
        {
            PrintDialog printDocument = new PrintDialog();
            if (printDocument.ShowDialog() == true) {
                printDocument.PrintDocument(((IDocumentPaginatorSource)Document).DocumentPaginator, "Impresión Documento Dinámico");
            }
        }

        private void btnVolver_Click(object sender, RoutedEventArgs e)
        {
            VtnListaUsuarios listadoUsuarios = new VtnListaUsuarios();
            this.Hide();
            listadoUsuarios.Show();
        }
    }
}
