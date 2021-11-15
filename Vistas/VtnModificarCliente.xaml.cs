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
    /// Interaction logic for VtnModificarCliente.xaml
    /// </summary>
    public partial class VtnModificarCliente : Window
    {
        public VtnModificarCliente()
        {
            InitializeComponent();

            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
        }

        private void btnAceptar_Click(object sender, RoutedEventArgs e)
        {
            if (txtDni.Text == "" || txtNombre.Text == "" || txtApellido.Text == "" || txtTelefono.Text == "" || txtEmail.Text == "")
            {
                MessageBox.Show("Faltan completar campos", "ATENCION");
            }
            else
            {
                MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Confirma guardar los cambios?", "ATENCION", System.Windows.MessageBoxButton.YesNo);
                if(messageBoxResult == MessageBoxResult.Yes){
                    int dni = Convert.ToInt32(txtDni.Text);
                    string nombre = txtNombre.Text;
                    string apellido = txtApellido.Text;
                    string telefono = txtTelefono.Text;
                    string email = txtEmail.Text;

                    Cliente oCliente = new Cliente();

                    oCliente.Cli_dni = dni;
                    oCliente.Cli_nombre = nombre;
                    oCliente.Cli_apellido = apellido;
                    oCliente.Cli_telefono = telefono;
                    oCliente.Cli_email = email;
                    TrabajarClientes.ModificarCliente(oCliente);

                    MessageBox.Show("Se guardaron los datos correctamente " + "\nDNI: " + oCliente.Cli_dni + "\nNombre: " + oCliente.Cli_nombre + "\nApellido: " + oCliente.Cli_apellido, "CORRECTO");
                    this.Hide();
                }
                
            }
        
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }
    }
}
