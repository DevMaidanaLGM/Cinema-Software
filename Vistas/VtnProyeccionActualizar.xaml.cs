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

using System.Data;

using MisClases;

namespace Vistas
{
    /// <summary>
    /// Interaction logic for VtnProyeccionActualizar.xaml
    /// </summary>
    public partial class VtnProyeccionActualizar : Window
    {
        int nroSala;
        string peliCodigo;
        int codigoProy;

        public VtnProyeccionActualizar(int proyCod)
        {
            InitializeComponent();
            this.codigoProy = proyCod;
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;

        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Proyeccion proy = new Proyeccion();
            proy=TrabajarProyecciones.TraerProyeccion(codigoProy);
            txtCodigo.Text = Convert.ToString(proy.Proy_codigo);
            cmbNroSala.SelectedItem = proy.Sala.Sala_denominacion;
            txtFecha.Text = proy.Proy_fecha_hora;
            cmbCodPeli.SelectedItem = proy.Pelicula.Peli_titulo;

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
            
        }

        private void cmbCodPeli_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            peliCodigo = TrabajarProyecciones.cargarComboCodigoPeli().ElementAt(cmbCodPeli.SelectedIndex).Peli_clase;
            
        }

        private void btnModificar_Click(object sender, RoutedEventArgs e)
        {
            if (txtFecha.Text == "" || cmbNroSala.Text == "" || cmbCodPeli.Text == "")
            {
                MessageBox.Show("Faltan completar campos", "ATENCION");
            }
            else
            {
                MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Confirma guardar los cambios?", "ATENCION", System.Windows.MessageBoxButton.YesNo);
                if (messageBoxResult == MessageBoxResult.Yes)
                {
                    int proyCod = Convert.ToInt32(txtCodigo.Text);
                    string fecha = txtFecha.Text;
                    string nroSala = cmbNroSala.Text.Substring(0,1);
                    string codPelicula = cmbCodPeli.Text.Substring(0,3);


                    Proyeccion oProyeccion = new Proyeccion();
                    oProyeccion.Pelicula = new Pelicula();
                    oProyeccion.Sala = new Sala();

                    oProyeccion.Proy_codigo = proyCod;
                    oProyeccion.Proy_fecha_hora = fecha;
                    oProyeccion.Pelicula.Peli_codigo = codPelicula;
                    oProyeccion.Sala.Sala_nro = Convert.ToInt32(nroSala);

                    TrabajarProyecciones.ModificarProyeccion(oProyeccion);

                    this.Hide();
                    VtnListadoProyecciones vtnListadoProyecciones = new VtnListadoProyecciones();
                    vtnListadoProyecciones.Show();

                }

            }
        }
    }
}
