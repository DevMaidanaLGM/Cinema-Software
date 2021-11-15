using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MisClases
{
    public class Roles
    {
        private string rol_codigo;
        private string rol_descripcion;

        public string Rol_codigo
        {
            get { return rol_codigo; }
            set { rol_codigo = value; }
        }
   
        public string Rol_descripcion
        {
            get { return rol_descripcion; }
            set { rol_descripcion = value; }
        }
    }
}
