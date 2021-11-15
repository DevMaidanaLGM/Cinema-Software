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
using Microsoft.Win32;

namespace Vistas
{
    /// <summary>
    /// Lógica de interacción para vtnVideoTest.xaml
    /// </summary>
    public partial class vtnVideoTest : Window
    {

        private string path;
        public vtnVideoTest()
        {
           
            InitializeComponent();

        }

        private void btnPlay_Click(object sender, RoutedEventArgs e)
        {
         
            mediaMovie.Play();
        }

        private void btnPause_Click(object sender, RoutedEventArgs e)
        {
            mediaMovie.Pause();
        }

        private void btnStop_Click(object sender, RoutedEventArgs e)
        {
            mediaMovie.Stop();

        }

        private void sldVolume_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            mediaMovie.Volume = (double)sldVolume.Value;
        }

        private void sldSeek_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            mediaMovie.Position = TimeSpan.FromMinutes(sldSeek.Value);
        }

        private void mediaMovie_Drop(object sender, DragEventArgs e)
        {
            mediaMovie.LoadedBehavior = MediaState.Manual;
            mediaMovie.UnloadedBehavior = MediaState.Manual;
        }

        private void btnAbrir_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "Video files (*.mp4)|*.mp4|All files (*.*)|*.*";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            // Display OpenFileDialog by calling ShowDialog method 
            Nullable<bool> result = openFileDialog.ShowDialog();


            // Get the selected file name and display in a TextBox 
            if (result == true)
            {
                // Open document 
                string filename = openFileDialog.FileName;
                path = filename;
                MessageBox.Show(path);
                mediaMovie.Source = new Uri(path);
            }

            mediaMovie.LoadedBehavior = MediaState.Manual;
            mediaMovie.UnloadedBehavior = MediaState.Manual;
        }

   

        private void btnPause_MouseDown(object sender, MouseButtonEventArgs e)
        {
            mediaMovie.LoadedBehavior = MediaState.Manual;
            mediaMovie.UnloadedBehavior = MediaState.Manual;
            mediaMovie.Pause();
    
        }

        private void btnStop_MouseDown(object sender, MouseButtonEventArgs e)
        {
            mediaMovie.LoadedBehavior = MediaState.Manual;
            mediaMovie.UnloadedBehavior = MediaState.Manual;
            mediaMovie.Stop();
    
            
        }

        private void btnPlay_MouseDown(object sender, MouseButtonEventArgs e)
        {
            mediaMovie.LoadedBehavior = MediaState.Manual;
            mediaMovie.UnloadedBehavior = MediaState.Manual;
            mediaMovie.Play();
        }
    }
}