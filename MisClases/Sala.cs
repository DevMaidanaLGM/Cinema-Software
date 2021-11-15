using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MisClases
{
   public class Sala
    {
        private int sala_nro;
        private string sala_denominacion;
        private int sala_capacidad;

        public int Sala_nro
        {
            get { return sala_nro; }
            set { sala_nro = value; }
        }
       

       public string Sala_denominacion
       {
           get { return sala_denominacion; }
           set { sala_denominacion = value; }
       }
     

       public int Sala_capacidad
       {
           get { return sala_capacidad; }
           set { sala_capacidad = value; }
       }

    }
}
