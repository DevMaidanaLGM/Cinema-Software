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

using System.Collections.ObjectModel;
using MisClases;

namespace Vistas
{
    /// <summary>
    /// Interaction logic for VtnUsuariosAlta.xaml
    /// </summary>
    public partial class VtnUsuariosAlta : Window
    {

        ObservableCollection<Usuario> MiLista;
        CollectionView vista;
       

        public VtnUsuariosAlta()
        {
            InitializeComponent();
            //WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
           
            //objetoDataProvider
            MiLista = ((ObjectDataProvider)this.Resources["MisUsuarios"]).Data as ObservableCollection<Usuario>;

            //vista por defecto
            vista = CollectionViewSource.GetDefaultView(MiLista) as CollectionView;
            

            //MessageBox.Show();
            //cargar combo
            for (int i = 0; i < TrabajarRoles.cargarCombo().Count; i++ )
            {
                cmbRolAdd.Items.Add(TrabajarRoles.cargarCombo().ElementAt(i).Rol_descripcion);
            }
            
        }


        private void btnSiguiente_Click(object sender, RoutedEventArgs e)

        {
            vista.MoveCurrentToNext();
            if (vista.IsCurrentAfterLast)
            {
                vista.MoveCurrentToFirst();
            }
        }

        private void btnAnterior_Click(object sender, RoutedEventArgs e)
        { 
           
            vista.MoveCurrentToPrevious();
            if (vista.IsCurrentBeforeFirst)
            {
                vista.MoveCurrentToLast();
            } 
        }

        private void btnPrimero_Click(object sender, RoutedEventArgs e)
        {
            vista.MoveCurrentToFirst();
        }

        private void btnUltimo_Click(object sender, RoutedEventArgs e)
        {
            vista.MoveCurrentToLast();
        }

        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {

            if (txtIdAdd.Text == "" || txtUsuarioAdd.Text == "" || txtContraseñaAdd.Text == "")
            {
                MessageBox.Show("Debe completar todos los campos");

            }
                // a continuacion llamo al metodo vali_id el cual validará si el id por ingresar ya encuntra en la base de datos
            else if(TrabajarUsuarios.vali_id(Convert.ToInt32(txtIdAdd.Text)))
            {
                
                //si el id ya esta, mostrará el siguiente mensaje
                MessageBox.Show("Verifique el ID. Ya se encuentra registrado");
                        
                }
            else{
                // si aun no hay usuario con ese id, se puede insertar el nuevo usuario
                     
                Usuario oUsuario = new Usuario();
                oUsuario.Usu_id = Convert.ToInt32(txtIdAdd.Text);
                oUsuario.Usu_nombreUsuario = txtUsuarioAdd.Text;
                oUsuario.Usu_contraseña = txtContraseñaAdd.Text;
                oUsuario.Usu_apellidoNombre = txtAyNAdd.Text;

                if (cmbRolAdd.Text == "Administrador")
                {
                    oUsuario.Rol_codigo = "1";
                }
                else
                    oUsuario.Rol_codigo = "2";                
                
                oUsuario.Roles = new Roles();
                oUsuario.Roles.Rol_descripcion = cmbRolAdd.Text;
                MiLista.Add(oUsuario);

                TrabajarUsuarios.AgregarUsuario(oUsuario);
               // oUsuario.Rol_codigo = cmbRolAdd.Text;
               
 
                txtIdAdd.Text = "";
                txtIdAdd.Text = "";
                txtUsuarioAdd.Text = "";
                txtContraseñaAdd.Text = "";
                txtAyNAdd.Text = "";
                cmbRolAdd.Text = ""; 
                MessageBox.Show("Datos Guardados Correctamente");

            }
         
        }

        private void btnModificar_Click(object sender, RoutedEventArgs e)
        {

           if (txtIdAdd.Text == ""){
            txtIdAdd.IsEnabled = false;
            txtIdAdd.Text = txtId.Text;
            txtUsuarioAdd.Text = txtUsuario.Text;
            txtContraseñaAdd.Text = txtContraseña.Text;
            txtAyNAdd.Text = txtNyA.Text;
            cmbRolAdd.Text= txtRol.Text;
            btnAgregar.IsEnabled = false;
            btnEliminar.IsEnabled = false;


           }
            else 
           {
            
                 MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Quiere Modificar", "ATENCION", System.Windows.MessageBoxButton.YesNo);
                 if (messageBoxResult == MessageBoxResult.Yes)
                 {
                     Usuario oUsuario = (Usuario)MiLista[vista.CurrentPosition];
                     oUsuario.Usu_id = (int)Convert.ToInt32(txtIdAdd.Text);
                     oUsuario.Usu_nombreUsuario = txtUsuarioAdd.Text;
                     oUsuario.Usu_contraseña = txtContraseñaAdd.Text;
                     oUsuario.Usu_apellidoNombre = txtAyNAdd.Text;

                     if (cmbRolAdd.Text == "Administrador")
                     {
                         oUsuario.Rol_codigo = "1";
                     }
                     else
                     {
                         oUsuario.Rol_codigo = "2";
                     }
                    

                     TrabajarUsuarios.ModificarUsuario(oUsuario);
                     txtIdAdd.IsEnabled = true;
                     btnAgregar.IsEnabled = true;
                     btnEliminar.IsEnabled = true;

                     txtIdAdd.Text = "";
                     txtIdAdd.Text = "";
                     txtUsuarioAdd.Text = "";
                     txtContraseñaAdd.Text = "";
                     txtAyNAdd.Text = "";
                     cmbRolAdd.Text = "";

                 }
                 else
                 {
                     txtIdAdd.IsEnabled = true;
                     btnAgregar.IsEnabled = true;
                     btnEliminar.IsEnabled = true;

                     txtIdAdd.Text = "";
                     txtIdAdd.Text = "";
                     txtUsuarioAdd.Text = "";
                     txtContraseñaAdd.Text = "";
                     txtAyNAdd.Text = "";
                     cmbRolAdd.Text = "";
                 }

         
           }
   
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("¿Desea eliminar?", "ATENCION", System.Windows.MessageBoxButton.YesNo);
            if (messageBoxResult == MessageBoxResult.Yes)
            {
                Usuario oUsuario = new Usuario();
                oUsuario.Usu_id = Convert.ToInt32(txtId.Text);

                MiLista.Remove(((Usuario)vista.CurrentItem));
                TrabajarUsuarios.EliminarUsuario(oUsuario.Usu_id);
            }
                      
        }


        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }

       
    }
}
