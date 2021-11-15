using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MisClases
{
    public class Butaca
    {
        private string but_fila;
        private string but_nro;
        private string but_nroSala;
        private int but_codigo;
        private string but_estado;

        public string But_estado
        {
            get { return but_estado; }
            set { but_estado = value; }
        }


        public int But_codigo
        {
            get { return but_codigo; }
            set { but_codigo = value; }
        }


        public string But_fila
        {
            get { return but_fila; }
            set { but_fila = value; }
        }
       

        public string But_nro
        {
            get { return but_nro; }
            set { but_nro = value; }
        }
        

        public string But_nroSala
        {
            get { return but_nroSala; }
            set { but_nroSala = value; }
        }
    }
}
