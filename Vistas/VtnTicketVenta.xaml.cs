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
    /// Interaction logic for VtnTicketVenta.xaml
    /// </summary>
    public partial class VtnTicketVenta : Window
    {
        int code;
        int dni;
        string nom_vendedor;
        public VtnTicketVenta( int cod, int doc, string nombre)
        {
            InitializeComponent();
           code = cod;
           dni = doc;
           this.nom_vendedor = nombre;
        }

      

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            gridTicket.DataContext = TrabajarTickets.TraerIicket(code, dni);
            txtvendendor.Text= nom_vendedor;
        }
    }
}
