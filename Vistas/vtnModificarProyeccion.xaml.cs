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
    /// Interaction logic for vtnModificarProyeccion.xaml
    /// </summary>
    public partial class vtnModificarProyeccion : Window
    {
        List<Proyeccion> list = new List<Proyeccion>();
        public vtnModificarProyeccion()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            vtnNuevaProyeccion nuevaProyeccion = new vtnNuevaProyeccion();
            list = nuevaProyeccion.getList();
            this.dataGridProyecciones.ItemsSource = list;
        }
        /// <summary>
        /// Metodo para modificar pelicula
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult respuesta = MessageBox.Show("Esta seguro de realizar la modificacion? ", "¡Atencion!", MessageBoxButton.YesNo);
            if( respuesta == MessageBoxResult.Yes) {
                var codigo = Convert.ToInt32(txtCodigo.Text);
                //Encontrando el indice en la lista
                int index = list.FindIndex(a => a.Proy_codigo == codigo);
                list.RemoveAt(index);
                Proyeccion p = new Proyeccion();
                p.Proy_codigo = Convert.ToInt32(txtCodigo.Text);
                p.Proy_fecha_hora = txtFecha.Text;
           
                p.Proy_nroSala = txtNumeroSala.Text;
                p.Peli_codigo = txtCodigoPelicula.Text;
                //Insertando en la lista con el nuevo indice
                //Le paso un objeto
                list.Insert(index, p);
                //Asignando la lista al dataGrid
                this.dataGridProyecciones.ItemsSource = null;
                this.dataGridProyecciones.ItemsSource = list;
                this.Hide();
            }
        }
        /// <summary>
        /// Metodo para volver
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Metodo para setear al objeto 
        /// </summary>
        /// <param name="proyec"></param>
        private void setProyeccion(Proyeccion proyec) {
            txtCodigo.Text = Convert.ToString(proyec.Proy_codigo);
            txtFecha.Text = proyec.Proy_fecha_hora;
            
            txtNumeroSala.Text = proyec.Proy_nroSala;
            txtCodigoPelicula.Text = proyec.Peli_codigo;

        }
        /// <summary>
        /// Metodo para tomar el objeto seleccionado en el DataGrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridProyecciones_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dataGridProyecciones.SelectedIndex != -1)
            {
                Proyeccion proyeccionSelecionada = this.dataGridProyecciones.SelectedItem as Proyeccion;
                setProyeccion(proyeccionSelecionada);
            }
        }

        /// <summary>
        /// Metodo para limpiar los textBox
        /// </summary>
        /// 
        //public void limpiarText() {
            //foreach (TextBox t in stckTextBox.Children) {
               // if (t.GetType() == typeof(TextBox)) {
                  //  ((TextBox)t).Text = string.Empty;
               // }
       // }

        }

}

