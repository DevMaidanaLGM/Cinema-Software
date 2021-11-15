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
using System.IO;
using System.Net;



namespace Vistas
{
    /// <summary>
    /// Lógica de interacción para vtnMasInfo.xaml
    /// </summary>
    /// 
    
    public partial class vtnMasInfo : Window
    {

        public string codigo;
        Pelicula pelicula = new Pelicula();
        public vtnMasInfo(string peli_codigo)
        {
          
            InitializeComponent();
            codigo = peli_codigo;
            llenarCampos();
           //MessageBox.Show(peli_codigo);
            //PRUEBA
            var image = new BitmapImage();
            int BytesToRead = 100;
            //Pelicula pelicula = new Pelicula();
            pelicula = TrabajarPeliculas.traerPelicula(codigo);
            string url = pelicula.Peli_imagen.ToString();
            WebRequest request = WebRequest.Create(new Uri(url, UriKind.Absolute));
            request.Timeout = -1;
            WebResponse response = request.GetResponse();
            Stream responseStream = response.GetResponseStream();
            BinaryReader reader = new BinaryReader(responseStream);
            MemoryStream memoryStream = new MemoryStream();

            byte[] bytebuffer = new byte[BytesToRead];
            int bytesRead = reader.Read(bytebuffer, 0, BytesToRead);

            while (bytesRead > 0)
            {
                memoryStream.Write(bytebuffer, 0, bytesRead);
                bytesRead = reader.Read(bytebuffer, 0, BytesToRead);
            }

            image.BeginInit();
            memoryStream.Seek(0, SeekOrigin.Begin);
            image.StreamSource = memoryStream;
            image.EndInit();

            imgPoster.Source = image;

            
        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            
         
        }


        private void llenarCampos() {
            //Pelicula pelicula;
            try
            {
                pelicula = TrabajarPeliculas.traerPelicula(codigo);
                txtGenero.Text = pelicula.Peli_genero;
                txtCodigo.Text = pelicula.Peli_codigo;
                txtTitulo.Text = pelicula.Peli_titulo;
                txtDuracion.Text = pelicula.Peli_duracion;
                txtCategoria.Text = pelicula.Peli_clase;
                //imgPoster.Source = new BitmapImage(new Uri(pelicula.Peli_imagen, UriKind.RelativeOrAbsolute));
                //imgPoster
                ///////////////////////////////
                MessageBox.Show("avance"+pelicula.Peli_avance.ToString());
                MessageBox.Show("Entro" + pelicula.Peli_imagen.ToString());
                mediaMovie.Source = new Uri(pelicula.Peli_avance);
                //MessageBox.Show("Entro"+pelicula.Peli_imagen);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            mediaMovie.LoadedBehavior = MediaState.Manual;
            mediaMovie.UnloadedBehavior = MediaState.Manual;
            mediaMovie.Stop();
        }
    }
}
