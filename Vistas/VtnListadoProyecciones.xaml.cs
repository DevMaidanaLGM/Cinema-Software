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
    /// Interaction logic for VtnListadoProyecciones.xaml
    /// </summary>
    public partial class VtnListadoProyecciones : Window
    {
        public VtnListadoProyecciones()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DataTable tabla = TrabajarProyecciones.listado();

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                DataRow row = tabla.Rows[i];
                string fechaH = row["proy_fecha_hora"].ToString();
                string fecha = fechaH.Substring(0, 8);
                DateTime fechanew = Convert.ToDateTime(fecha);
                DateTime fechaActual = DateTime.Now;
                DateTime fechaM7 = fechaActual.AddDays(7);

                    var data = new Proyeccion { Proy_codigo = (int)row["proy_codigo"], Proy_fecha_hora = fechanew.ToString().Substring(0, 8), Proy_nroSala = row["proy_fecha_hora"].ToString().Substring(8), Pelicula = new Pelicula { Peli_titulo = row["peli_titulo"].ToString() }, Sala = new Sala { Sala_denominacion = row["sala_denominacion"].ToString() } };
                    dataGridUsuarios.Items.Add(data);              

            }
        }

        private void btnVolver_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }

        /// <summary>
        /// Metodo para modificar una pelicula
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Proyeccion p = new Proyeccion();
            p = this.dataGridUsuarios.SelectedItem as Proyeccion;
            if (p != null )
            {
                VtnProyeccionActualizar vtnProyeccionActualizar = new VtnProyeccionActualizar(p.Proy_codigo);
                vtnProyeccionActualizar.Show();
                this.Hide();
            }
            else {
                MessageBox.Show("Debe seleccionar una pelicula");
            }
           
        }
    }
}
