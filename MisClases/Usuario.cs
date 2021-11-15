using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.ComponentModel;

namespace MisClases
{
    public class Usuario: INotifyPropertyChanged
    {
        private int usu_id;
        private string usu_nombreUsuario;
        private string usu_apellidoNombre;
        private string usu_contraseña;
        private string rol_codigo;



        public int Usu_id
        {
            get { return usu_id; }
            set { usu_id = value;
            Notificador("Usu_id");
            }
        }
        

        public string Usu_nombreUsuario
        {
            get { return usu_nombreUsuario; }
            set { usu_nombreUsuario = value;
            Notificador("Usu_nombreUsuario");
            }
        }
        

        public string Usu_apellidoNombre
        {
            get { return usu_apellidoNombre; }
            set { usu_apellidoNombre = value;
            Notificador("Usu_apellidoNombre");
            }
        }
        

        public string Usu_contraseña
        {
            get { return usu_contraseña; }
            set { usu_contraseña = value;
            Notificador("Usu_contraseña");
            }
        }

        

        public string Rol_codigo
        {
            get { return rol_codigo; }
            set { rol_codigo = value;
            Notificador("Rol_codigo");
            }
        }

        public Roles Roles { 
            get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        //notificador de cambios en las propiedades
        public void Notificador(string prop)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }
    }
}
