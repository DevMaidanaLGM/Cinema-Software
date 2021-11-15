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
using System.Text.RegularExpressions;

namespace Vistas
{
    /// <summary>
    /// Interaction logic for VtnVentaTicket.xaml
    /// </summary>
    public partial class VtnVentaTicket : Window
    {
      int VAR_GROBAL = TrabajarTickets.TraerID() + 1;
      string butaca=""; 
      string sala_deno="";
      string var_codiPeli = "";
      //string fila;
      //string nro;
      int sala;
        string var2;
  
      int cod_proy;
      private string nombre;
        public VtnVentaTicket( string nombre)
        {
            InitializeComponent();

            btnSelectBut.IsEnabled = false;
            cmbCliente.IsEnabled = false;
            txtnone.IsEnabled = false;
            txtPrecio.IsEnabled = false;

                       
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            lblFecha.Content= DateTime.Now.ToString("d/M/y");
            txtNroTicket.Text = VAR_GROBAL.ToString();

            this.nombre = nombre;


            //cargar combo de peliculas
            for (int i = 0; i < TrabajarPeliculas.cargarCombo().Count; i++)
            {
                cmb_pelicula.Items.Add(TrabajarPeliculas.cargarCombo().ElementAt(i).Peli_titulo.ToString());
                // MessageBox.Show(TrabajarClientes.cargarCombo().ElementAt(i).Cli_dni.ToString());
            }

           

            //cargar combo de clientes
            for (int i = 0; i < TrabajarClientes.cargarCombo().Count; i++)
            {
                cmbCliente.Items.Add(TrabajarClientes.cargarCombo().ElementAt(i).Cli_nombre.ToString());
               // MessageBox.Show(TrabajarClientes.cargarCombo().ElementAt(i).Cli_dni.ToString());
            }

         


        }
        public VtnVentaTicket(string nombre, string var, string var2, string butaca)
        {
            InitializeComponent();
            this.nombre = nombre;
            this.butaca = butaca;
            this.var2 = var2;
            txtnone.Text = butaca;
            btnSelectBut.IsEnabled = false;
            cmbCliente.IsEnabled = true;
            txtnone.IsEnabled = true;
            txtPrecio.IsEnabled = true;
            cmb_pelicula.IsEnabled = false;
            cmbFecha.IsEnabled = false;


            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            lblFecha.Content = DateTime.Now.ToString("d/M/y");
            txtNroTicket.Text = VAR_GROBAL.ToString();

            this.nombre = nombre;

           

            ////cargar combo de peliculas
            //for (int i = 0; i < TrabajarPeliculas.cargarCombo().Count; i++)
            //{
            
            cmb_pelicula.Items.Add(var);
            cmb_pelicula.SelectedItem = var;
            cmbFecha.Items.Add(var2);
            cmbFecha.SelectedItem = var2;

            //cmb_pelicula.IsInitialized.Equals(var);
            //    // MessageBox.Show(TrabajarClientes.cargarCombo().ElementAt(i).Cli_dni.ToString());
            //}



            //cargar combo de clientes
            for (int i = 0; i < TrabajarClientes.cargarCombo().Count; i++)
            {
                cmbCliente.Items.Add(TrabajarClientes.cargarCombo().ElementAt(i).Cli_nombre.ToString());
                // MessageBox.Show(TrabajarClientes.cargarCombo().ElementAt(i).Cli_dni.ToString());
            }




        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            int numeroTicket = Convert.ToInt32(txtNroTicket.Text);
            DateTime fecha = Convert.ToDateTime(DateTime.Today.ToString("d/M/y"));

            string docu = cmbCliente.Text;
            string dni_n = docu.Substring(0, 4);
            int dni = Convert.ToInt32(dni_n);
            
            string fila = txtnone.Text.Substring(0,1);
            //MessageBox.Show("Fila: " +fila);
            string numero = txtnone.Text.Substring(1,1);
            //MessageBox.Show("Nro: " + numero);
            //decimal precio = Convert.ToDecimal( txtPrecio.Text);
            if (this.isNumeric(txtPrecio.Text))
            {
                decimal precio = Convert.ToDecimal(txtPrecio.Text);
                Ticket oTicket = new Ticket();

                oTicket.Tick_nro = VAR_GROBAL;
                oTicket.Tick_fechaVenta = fecha;
                oTicket.Cli_dni = dni;
                oTicket.Proy_codigo = cod_proy;
                oTicket.But_fila = fila;
                oTicket.But_nro = numero;
                oTicket.Butaca = new Butaca();
                oTicket.Butaca.But_codigo = TrabajarButacas.TraerCodBut(fila, numero, sala);
                oTicket.Precio = precio;


                //MessageBox.Show(oTicket.Tick_nro.ToString() + oTicket.Tick_fechaVenta.ToString() + oTicket.Cli_dni.ToString() + oTicket.Proy_codigo.ToString()+ oTicket.But_fila.ToString()+ oTicket.But_nro.ToString()+ "But_codigo" + oTicket.Butaca.But_codigo.ToString()+ "/// "+oTicket.Precio.ToString());
                TrabajarTickets.AgregarTicket(oTicket);

                //update tabla butaca
                TrabajarButacas.UpdateButaca(TrabajarButacas.TraerCodBut(fila, numero, sala));

                VtnTicketVenta venta = new VtnTicketVenta(Convert.ToInt32(txtNroTicket.Text), dni, nombre);
                venta.Show();
                this.Hide();


            }
            else {
                MessageBox.Show("Debe ingresar un precio"); 
            
            }
            //Ticket oTicket = new Ticket();

            //oTicket.Tick_nro = VAR_GROBAL;
            //oTicket.Tick_fechaVenta = fecha;
            //oTicket.Cli_dni = dni;
            //oTicket.Proy_codigo = cod_proy;
            //oTicket.But_fila = fila;
            //oTicket.But_nro = numero;
            //oTicket.Butaca = new Butaca();
            //MessageBox.Show("FILA: "+ fila + " NUMERO: "+ numero + " SALA: " + sala);
            //oTicket.Butaca.But_codigo = TrabajarButacas.TraerCodBut(fila, numero, sala);
            //oTicket.Precio = precio;
            

            ////MessageBox.Show(oTicket.Tick_nro.ToString() + oTicket.Tick_fechaVenta.ToString() + oTicket.Cli_dni.ToString() + oTicket.Proy_codigo.ToString()+ oTicket.But_fila.ToString()+ oTicket.But_nro.ToString()+ "But_codigo" + oTicket.Butaca.But_codigo.ToString()+ "/// "+oTicket.Precio.ToString());
            //TrabajarTickets.AgregarTicket(oTicket);

            ////update tabla butaca
            //TrabajarButacas.UpdateButaca(TrabajarButacas.TraerCodBut(fila, numero, sala));

            //VtnTicketVenta venta = new VtnTicketVenta(Convert.ToInt32(txtNroTicket.Text), dni, nombre);
            //venta.Show();
            //this.Hide();
        }

        private bool isNumeric(string precio) {
            Regex r = new Regex(@"^[0-9].");
            return r.IsMatch(precio);
        
        }
        private void cmb_pelicula_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

          
           // cmbProyeccion.Items.Clear();
          
            cmbFecha.Items.Clear();
        }

        private void cmb_pelicula_IsMouseCapturedChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            //var_hora= TrabajarPeliculas.idPeli(cmb_pelicula.Text);
           

            //for (int i = 0; i < TrabajarProyecciones.cargarCombo(var_hora).Count; i++)
            //{
            //    //cmbProyeccion.Items.Add(TrabajarProyecciones.cargarCombo(var_hora).ElementAt(i).Proy_fecha_hora);
            //    //hora = TrabajarProyecciones.cargarCombo(var_hora).ElementAt(i).Proy_codigo;

            //}
           



            //carga el combo con las fechas de la pelicula seleccionada.
            var_codiPeli = TrabajarPeliculas.idPeli(cmb_pelicula.Text);
            cmbFecha.Items.Clear();
            for (int i = 0; i < TrabajarProyecciones.cargarComboFecha(var_codiPeli).Count; i++)
            {
                cmbFecha.Items.Add(TrabajarProyecciones.cargarComboFecha(var_codiPeli).ElementAt(i).Proy_fecha_hora);
            }

        
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            //vtnButacas3D vtn = new vtnButacas3D();
            //vtn.Show();
        }

        private void cmbFecha_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if (butaca != "")
            {
                var_codiPeli = TrabajarPeliculas.idPeli(cmb_pelicula.Text);
               // MessageBox.Show(var_codiPeli);
                cod_proy = TrabajarProyecciones.TraerIDProy(var2, var_codiPeli);
               // MessageBox.Show("Codigo Proyecicon es: "+cod_proy);



            //sala_deno = TrabajarProyecciones.cargarCombo(var_codiPeli).ElementAt(cmbFecha.SelectedIndex).Sala.Sala_denominacion;
            //    MessageBox.Show("Sala: " + sala_deno);
                sala = TrabajarProyecciones.TraerIDSala(var2, var_codiPeli);
            //   MessageBox.Show("Codigo Sala:" + sala);


            }
            else
            {
                //MessageBox.Show("Indice selccionado: "+ cmbFecha.SelectedIndex.ToString());
                //MessageBox.Show(var_codiPeli);
                //MessageBox.Show("codigo proyeccion: " + TrabajarProyecciones.cargarCombo(var_codiPeli).ElementAt(cmbFecha.SelectedIndex).Proy_codigo.ToString());
                cod_proy= TrabajarProyecciones.cargarCombo(var_codiPeli).ElementAt(cmbFecha.SelectedIndex).Proy_codigo;
                //MessageBox.Show("ida: "+TrabajarProyecciones.cargarCombo(var_codiPeli).ElementAt(cmbFecha.SelectedIndex).Sala.Sala_denominacion);
                sala_deno = TrabajarProyecciones.cargarCombo(var_codiPeli).ElementAt(cmbFecha.SelectedIndex).Sala.Sala_denominacion;
                btnSelectBut.IsEnabled = true;
            
            
            
            }



          
        }

        private void button3_Click_1(object sender, RoutedEventArgs e)
        {
            if (sala_deno == "2D")
            {
                vtnButacas2D ventana2d = new vtnButacas2D(cmb_pelicula.Text, cmbFecha.Text, nombre, TrabajarPeliculas.idPeli(cmb_pelicula.Text));
                ventana2d.Show();
                this.Hide();
            }
            else
            {
                vtnButacas3D ventana3d = new vtnButacas3D(cmb_pelicula.Text, cmbFecha.Text, nombre, TrabajarPeliculas.idPeli(cmb_pelicula.Text));
                ventana3d.Show();
                this.Hide();

            }
        }

       
       

    
     

      

     
        

    
       

      

       
    }
}
