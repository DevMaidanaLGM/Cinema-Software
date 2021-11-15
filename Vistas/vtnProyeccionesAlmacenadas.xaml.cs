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
using System.Data;


namespace Vistas
{
    /// <summary>
    /// Lógica de interacción para vtnProyeccionesAlmacenadas.xaml
    /// </summary>
    public partial class vtnProyeccionesAlmacenadas : Window
    {
        public vtnProyeccionesAlmacenadas()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
           
        }

        private void btnVolver_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
         
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
             traerProyecciones();

        }
        public void traerProyecciones() {
            DataTable tabla = TrabajarProyecciones.listado();

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                DataRow row = tabla.Rows[i];
                string fechaH = row["proy_fecha_hora"].ToString();
                string fecha = fechaH.Substring(0, 8);
                DateTime fechanew = Convert.ToDateTime(fecha);
                DateTime fechaActual = DateTime.Now;
                DateTime fechaM7 = fechaActual.AddDays(7);

                if (fechanew >= fechaActual && fechanew <= fechaM7)
                {
                    var data = new Proyeccion { Proy_codigo = (int)row["proy_codigo"], Proy_fecha_hora = fechanew.ToString().Substring(0, 8), Proy_nroSala = row["proy_fecha_hora"].ToString().Substring(8), Pelicula = new Pelicula { Peli_titulo = row["peli_titulo"].ToString() }, Sala = new Sala { Sala_denominacion = row["sala_denominacion"].ToString() } };
                    dataGridUsuarios.Items.Add(data);
                }

            }

            
        }

        private void click_masInfo(object sender, RoutedEventArgs e)
        {



            Proyeccion oProyeccion = this.dataGridUsuarios.SelectedItem as Proyeccion;

            oProyeccion = TrabajarProyecciones.TraerProyeccionPorID(oProyeccion.Proy_codigo);
            
            vtnMasInfo vtnMasInfo = new vtnMasInfo(oProyeccion.Peli_codigo);
            vtnMasInfo.Show();


        }

        private void button_Click(object sender, RoutedEventArgs e)
        {






            if (fechaFiltro.Text != null && fechaFiltro.Text !="")
            {
                DataTable tabla = TrabajarProyecciones.listado();
                

                dataGridUsuarios.Items.Clear();
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    DataRow row = tabla.Rows[i];
                    string fechaH = row["proy_fecha_hora"].ToString();
                    string fecha = fechaFiltro.SelectedDate.Value.ToString("dd/MM/yy").Substring(0, 8);

                    
                    if (fecha == row["proy_fecha_hora"].ToString().Substring(0, 8))
                    {
                        var data = new Proyeccion { Proy_codigo = (int)row["proy_codigo"], Proy_fecha_hora = row["proy_fecha_hora"].ToString(), Proy_nroSala = row["proy_fecha_hora"].ToString().Substring(8), Pelicula = new Pelicula { Peli_titulo = row["peli_titulo"].ToString() }, Sala = new Sala { Sala_denominacion = row["sala_denominacion"].ToString() } };
                        dataGridUsuarios.Items.Add(data);
                        //fechaFiltro.Text = "";
                    }
                    //fechaFiltro.Text = "";

                }
                fechaFiltro.Text = "";
                
            }
            else if (txtPelicula.Text !=null && txtPelicula.Text != "")
            {
                MessageBox.Show("....");
                string peli = txtPelicula.Text;
                
                DataTable tabla = TrabajarProyecciones.listado2(peli);
                MessageBox.Show("Registros" + tabla.Rows.Count.ToString());
                dataGridUsuarios.Items.Clear();
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    DataRow row = tabla.Rows[i];
                    string fechaH = row["proy_fecha_hora"].ToString();
                   // string fecha = fechaFiltro.SelectedDate.Value.ToString("dd/MM/yy").Substring(0, 8);


                   
                        var data = new Proyeccion { Proy_codigo = (int)row["proy_codigo"], Proy_fecha_hora = row["proy_fecha_hora"].ToString(), Proy_nroSala = row["proy_fecha_hora"].ToString().Substring(8), Pelicula = new Pelicula { Peli_titulo = row["peli_titulo"].ToString() }, Sala = new Sala { Sala_denominacion = row["sala_denominacion"].ToString() } };
                        dataGridUsuarios.Items.Add(data);
                       
                    

                }
                txtPelicula.Text = "";


            }
            else
            {
                //MessageBox.Show("Selecione un parametro...");
                dataGridUsuarios.Items.Clear();
                traerProyecciones();
            }
           



           
                
            }

       









        }
}

