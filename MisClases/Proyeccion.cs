using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace MisClases
{
    public class Proyeccion : INotifyPropertyChanged
    {
        private int proy_codigo;
        private string peli_codigo;
        private string proy_fecha_hora;

        public string Proy_fecha_hora
        {
            get { return proy_fecha_hora; }
            set { proy_fecha_hora = value;
            Notificador("Proy_fecha_hora");
            }
            
        }
       
        private string proy_nroSala;


        public int Proy_codigo
        {
            get { return proy_codigo; }
            set { proy_codigo = value;
            Notificador("Proy_codigo");
            }
        }
        
    
     
        public string Proy_nroSala
        {
            get { return proy_nroSala; }
            set { proy_nroSala = value;
            Notificador("Proy_nroSala");
            }
        }
     
        public string Peli_codigo
        {
            get { return peli_codigo; }
            set { peli_codigo = value;
            Notificador("Peli_codigo");
            }
        }
        public Pelicula Pelicula { get; set;}
        public Sala Sala { get; set; }

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
