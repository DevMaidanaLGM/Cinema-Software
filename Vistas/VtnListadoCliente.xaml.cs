﻿using System;
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

namespace Vistas
{
    /// <summary>
    /// Lógica de interacción para VtnListadoCliente.xaml
    /// </summary>
    public partial class VtnListadoCliente : Window
    {
        public VtnListadoCliente()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
        }

        private void btnVolver_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }
    }
}
