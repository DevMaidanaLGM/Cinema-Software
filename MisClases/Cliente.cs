using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.ComponentModel;

namespace MisClases
{
    public class Cliente: IDataErrorInfo
    {
        private int cli_dni;
        private string cli_nombre;
        private string cli_apellido;
        private string cli_telefono;
        private string cli_email;

        public int Cli_dni
        {
            get { return cli_dni; }
            set { cli_dni = value; }
        }
        
        public string Cli_nombre
        {
            get { return cli_nombre; }
            set { cli_nombre = value; }
        }
        
        public string Cli_apellido
        {
            get { return cli_apellido; }
            set { cli_apellido = value; }
        }
        
        public string Cli_telefono
        {
            get { return cli_telefono; }
            set { cli_telefono = value; }
        }
        
        public string Cli_email
        {
            get { return cli_email; }
            set { cli_email = value; }
        }



        public string Error
        {
            get { throw new NotImplementedException(); }
        }

        public string this[string columnName]
        {
            get 
            {
                string mensaje = string.Empty;
                //validacion
                if (columnName == "Cli_dni")
                {
                    if (string.IsNullOrEmpty(Convert.ToString(Cli_dni)))
                    {
                        mensaje = "Debe ingresar un valor";
                    }
                }

                if (columnName == "Cli_nombre")
                {
                    if (string.IsNullOrEmpty(Cli_nombre))
                    {
                        mensaje = "Debe ingresar un valor";
                    }
                }

                if (columnName == "Cli_apellido")
                {
                    if (string.IsNullOrEmpty(Cli_apellido))
                    {
                        mensaje = "Debe ingresar un valor";
                    }
                }

                if (columnName == "Cli_telefono")
                {
                    if (string.IsNullOrEmpty(Cli_telefono))
                    {
                        mensaje = "Debe ingresar un valor";
                    }
                }

                if (columnName == "Cli_email")
                {
                    if (string.IsNullOrEmpty(Cli_email))
                    {
                        mensaje = "Debe ingresar un valor";
                    }
                }


                //fin validacion

                return mensaje;
            }
        }
    }
}
