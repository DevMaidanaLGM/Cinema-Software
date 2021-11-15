using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MisClases
{
    public class Ticket
    {
        private int tick_nro;
        private decimal precio;
      

        public decimal Precio
        {
            get { return precio; }
            set { precio = value; }
        }


        public int Tick_nro
        {
            get { return tick_nro; }
            set { tick_nro = value; }
        }
        private DateTime tick_fechaVenta;

        public DateTime Tick_fechaVenta
        {
            get { return tick_fechaVenta; }
            set { tick_fechaVenta = value; }
        }
        private int cli_dni;

        public int Cli_dni
        {
            get { return cli_dni; }
            set { cli_dni = value; }
        }
        private int proy_codigo;

        public int Proy_codigo
        {
            get { return proy_codigo; }
            set { proy_codigo = value; }
        }
        private string but_fila;

        public string But_fila
        {
            get { return but_fila; }
            set { but_fila = value; }
        }
        private string but_nro;

        public string But_nro
        {
            get { return but_nro; }
            set { but_nro = value; }
        }


        public Cliente   Cliente { get; set; }
        public Proyeccion Proyecion{ get; set; }
        public Pelicula Pelicula { get; set; }
        public Butaca Butaca { get; set; }
        public Sala Sala { get; set; }

        
        
    }



}
