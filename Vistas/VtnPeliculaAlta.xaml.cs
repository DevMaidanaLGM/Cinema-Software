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
using Microsoft.Win32;

namespace Vistas
{
    /// <summary>
    /// Interaction logic for VtnPeliculaAlta.xaml
    /// </summary>
    public partial class VtnPeliculaAlta : Window
    {
        private string imagePath;
        private string videoPath;
        private Uri imagePathUri;
            
        public VtnPeliculaAlta()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            mediaMovie.LoadedBehavior = MediaState.Manual;
            mediaMovie.UnloadedBehavior = MediaState.Manual;
            mediaMovie.Stop();
            this.Close();
        }

        private void btnAceptar_Click(object sender, RoutedEventArgs e)
        {
            if (txtCodigo.Text == "" || txtTitulo.Text == "" || txtDuracion.Text == "" || cboGenero.Text == "" || cboClase.Text == "")
            {
                MessageBox.Show("Faltan completar campos", "ATENCIÓN!");
            }
            else
            {
                MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("¿Está seguro de guardar estos datos?", "ATENCION", System.Windows.MessageBoxButton.YesNo,MessageBoxImage.Question);
                if (messageBoxResult == MessageBoxResult.Yes)
                {
                    string codigo = txtCodigo.Text;
                    string titulo = txtTitulo.Text;
                    string duracion = txtDuracion.Text;
                    string genero = cboGenero.Text;
                    string clase = cboClase.Text;
                    string imagen = txtImagen.Text;
                    string avance = txtAvance.Text;


                    Pelicula oPelicula = new Pelicula();

                    oPelicula.Peli_codigo = codigo;
                    oPelicula.Peli_titulo = titulo;
                    oPelicula.Peli_duracion = duracion;
                    oPelicula.Peli_genero = genero;
                    oPelicula.Peli_clase = clase;
                    oPelicula.Peli_imagen = imagen;
                    oPelicula.Peli_avance = avance;

                    TrabajarPeliculas.AgregarPelicula(oPelicula);

                    MessageBox.Show("La pelicula se agregó con éxito!" + "\nCodigo: " + oPelicula.Peli_codigo + "\nTitulo: " +
                        oPelicula.Peli_titulo + "\nDuracion: " + oPelicula.Peli_duracion + "\nGenero: " + oPelicula.Peli_genero, "Pelicula Guardada",MessageBoxButton.OK,MessageBoxImage.Information);


                    mediaMovie.LoadedBehavior = MediaState.Manual;
                    mediaMovie.UnloadedBehavior = MediaState.Manual;
                    mediaMovie.Stop();
                    this.Hide();
                }

            }
        }

        private void txtImagen_TextChanged(object sender, TextChangedEventArgs e)
        {
            imgPoster.Source = new BitmapImage(new Uri(txtImagen.Text, UriKind.RelativeOrAbsolute));
           
        }

        private void btnPosterOpen_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            // Display OpenFileDialog by calling ShowDialog method 
            Nullable<bool> result = openFileDialog.ShowDialog();


            // Get the selected file name and display in a TextBox 
            if (result == true)
            {
                // Open document 
                string filename = openFileDialog.FileName;
                imagePath = filename;
                imagePathUri = new Uri(filename);
                MessageBox.Show(imagePath);
                txtImagen.Text = imagePath;
               
                
            }
        }

        private void btnVideoOpen_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "Video files (*.mp4)|*.mp4|All files (*.*)|*.*";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            // Display OpenFileDialog by calling ShowDialog method 
            Nullable<bool> result = openFileDialog.ShowDialog();

            mediaMovie.LoadedBehavior = MediaState.Manual;
            mediaMovie.UnloadedBehavior = MediaState.Manual;
            // Get the selected file name and display in a TextBox 
            if (result == true)
            {
                // Open document 
                string filename = openFileDialog.FileName;
                videoPath = filename;
                MessageBox.Show(videoPath);
                mediaMovie.Source = new Uri(videoPath);
                txtAvance.Text = videoPath;
                mediaMovie.Play();
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
