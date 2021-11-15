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
    /// Interaction logic for vtnNuevaProyeccion.xaml
    /// </summary>
    public partial class vtnNuevaProyeccion : Window
    {
        int nroSala;
        string peliCodigo;
        int VAR_GROBAL = TrabajarProyecciones.TraerID() + 1;
    
        //List de proyecciones
        static List<Proyeccion> listP = new List<Proyeccion>();
        public vtnNuevaProyeccion()
        {
            InitializeComponent();
            txtCodigo.Text = VAR_GROBAL.ToString();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
        }
        /// <summary>
        /// Metodo para agregar una pelicula
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAceptar_Click(object sender, RoutedEventArgs e)
        {
            //Validacion
            if (validacion() == false)
            {
                MessageBox.Show("Ingrese todos los campos por favor");
            }
            else if (TrabajarProyecciones.vali_id(Convert.ToInt32(txtCodigo.Text)))
            {
                //si el id ya esta, mostrará el siguiente mensaje
                MessageBox.Show("Verifique el ID. Ya se encuentra registrado");

            }

            else
            {

                MessageBoxResult respuesta = MessageBox.Show("Desea guardar los cambios? ", "¡Atencion!", MessageBoxButton.YesNo);
                if (respuesta == MessageBoxResult.Yes)
                {
                    //Object
                    Proyeccion proyec = new Proyeccion();
                    proyec.Proy_codigo = Convert.ToInt32(txtCodigo.Text);
                    proyec.Proy_fecha_hora = txtFecha.Text;
                    proyec.Sala = new Sala();
                    proyec.Sala.Sala_nro = nroSala;
                    proyec.Peli_codigo = peliCodigo ;

                    //Add in list
                    listP.Add(proyec);

                    TrabajarProyecciones.AgregarProyecciones(proyec);
                    MessageBox.Show("Se guardo correctamente la proyeccion");
                    this.Hide();

                }
            }
        }
        /// <summary>
        /// Metodo para devolver la lista 
        /// </summary>
        /// <returns></returns>
        public List<Proyeccion> getList() {
            return listP;
        }
        /// <summary>
        /// Metodo para validar campos
        /// </summary>
        /// <returns></returns>
        public Boolean validacion() {
            bool bandera;
            if (txtCodigo.Text.Length == 0 || txtFecha.Text.Length == 0 ||
                txtFecha.Text.Length == 0 )
            {
                bandera = false;
            }
            else {
                bandera = true;
            }
            return bandera;
        }
        
        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //cargar combo Tipo de Sala
            for (int i = 0; i < TrabajarProyecciones.cargarComboNewPro().Count; i++)
            {
                cmbNroSala.Items.Add(TrabajarProyecciones.cargarComboNewPro().ElementAt(i).Sala_denominacion.ToString());
                
            }
            //cargar combo Peliculas
            for (int i = 0; i < TrabajarProyecciones.cargarComboCodigoPeli().Count; i++)
            {
                cmbCodPeli.Items.Add(TrabajarProyecciones.cargarComboCodigoPeli().ElementAt(i).Peli_codigo.ToString());

            }
        }

        private void cmbNroSala_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            nroSala = TrabajarProyecciones.cargarComboNewPro().ElementAt(cmbNroSala.SelectedIndex).Sala_nro;
            MessageBox.Show(nroSala.ToString());
        }

        private void cmbCodPeli_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
             peliCodigo = TrabajarProyecciones.cargarComboCodigoPeli().ElementAt(cmbCodPeli.SelectedIndex).Peli_clase;
            MessageBox.Show(peliCodigo);
        }
        
    }
}
