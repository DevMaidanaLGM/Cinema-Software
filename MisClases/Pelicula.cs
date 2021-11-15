using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace MisClases
{
    public class Pelicula : INotifyPropertyChanged
    {
        private string peli_codigo;
        private string peli_titulo;
        private string peli_duracion;
        private string peli_genero;
        private string peli_clase;
        private string peli_imagen;
        private string peli_avance;



        public string Peli_avance
        {
            get { return peli_avance; }
            set { peli_avance = value;
            Notificador("Peli_avance");
            }

        } 

        public string Peli_imagen
        {
            get { return peli_imagen; }
            set { peli_imagen = value;
            Notificador("Peli_imagen");
            }
        }
        

        public string Peli_codigo
        {
            get { return peli_codigo; }
            set { peli_codigo = value;
            Notificador("Peli_codigo");
            }
        }
       

        public string Peli_titulo
        {
            get { return peli_titulo; }
            set { peli_titulo = value;
            Notificador("Peli_titulo");
            }
        }
        

        public string Peli_duracion
        {
            get { return peli_duracion; }
            set { peli_duracion = value;
            Notificador("Peli_duracion");
            }
        }
       

        public string Peli_genero
        {
            get { return peli_genero; }
            set { peli_genero = value;
            Notificador("Peli_genero");
            }
        }
       

        public string Peli_clase
        {
            get { return peli_clase; }
            set { peli_clase = value;
            Notificador("Peli_clase");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        //notificador de cambios en las propiedades
        public void Notificador(string prop)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }
    }
}
