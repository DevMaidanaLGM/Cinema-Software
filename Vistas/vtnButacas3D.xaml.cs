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
    /// Interaction logic for VtnAsignacionButacas.xaml
    /// </summary>
    public partial class vtnButacas3D : Window
    {
         string var1;
        string var2;
        string nombre_ven;
        string peli_codigo;
        

        public vtnButacas3D(string vaar1, string segunda, string nombre, string peli_codigo)
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            this.var1 = vaar1;
            this.var2 = segunda;
            this.nombre_ven = nombre;
            this.peli_codigo = peli_codigo;
            
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            string path = System.IO.Directory.GetCurrentDirectory().ToString();
            path = path.Remove(path.Length - 9);

            //Traer codigo proyeccion
            for (int i = 0; i < TrabajarButacas.butacaOcupada(TrabajarProyecciones.TraerIDProy(var2, peli_codigo)).Count; i++)
            {
                string but = TrabajarButacas.butacaOcupada(TrabajarProyecciones.TraerIDProy(var2, peli_codigo)).ElementAt(i).But_fila.ToString();
                var brush = new ImageBrush();
                brush.ImageSource = new BitmapImage(new Uri(path + "Images/butacaRoja.png"));
                Button bu = butacas.FindName(but) as Button;
                if (bu != null)
                {
                    bu.Background = brush;
                    bu.BorderBrush = Brushes.Red;
                }

            }

        }

        private void Butacas_Click(object sender, RoutedEventArgs e)
        {
            Button bu = sender as Button;
            //MessageBox.Show("hola"+ var1 + var2);
            string path = System.IO.Directory.GetCurrentDirectory().ToString();
            path = path.Remove(path.Length - 9);



            string valor = bu.Name.ToString();
            // MessageBox.Show(valor);

            if (bu.BorderBrush == Brushes.LightGray)
            {
                var brush = new ImageBrush();
                brush.ImageSource = new BitmapImage(new Uri(path + "Images/butacaVerde.png"));
                bu.Background = brush;
                bu.BorderBrush = Brushes.Green;

                MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Confirma su butaca", "ATENCION", System.Windows.MessageBoxButton.YesNo);
                if (messageBoxResult == MessageBoxResult.Yes)
                {

                    VtnVentaTicket venta = new VtnVentaTicket(nombre_ven, var1, var2, bu.Name);
                    venta.Show();
                    this.Hide();

                }
                else
                {
                    this.Hide();
                }


            }

            else if (bu.BorderBrush == Brushes.Green)
            {
                var brush = new ImageBrush();
                brush.ImageSource = new BitmapImage(new Uri(path + "Images/butacaGris.png"));
                bu.Background = brush;
                bu.BorderBrush = Brushes.LightGray;

            }
            else
            {
                MessageBox.Show("Butaca ocupada!!!");
            }

            //MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Confirma su butaca", "ATENCION", System.Windows.MessageBoxButton.YesNo);
            //if (messageBoxResult == MessageBoxResult.Yes)
            //{

            //    VtnVentaTicket venta = new VtnVentaTicket(nombre_ven, var1, var2, bu.Name);
            //    venta.Show();
            //    this.Hide();

            //}
            //else
            //{
            //    this.Hide();
            //}



           

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
