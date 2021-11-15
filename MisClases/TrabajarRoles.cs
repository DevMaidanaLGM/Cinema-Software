using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace MisClases
{
   public class TrabajarRoles
    {
        public static List<Roles> cargarCombo()
        {

            SqlConnection cnn = new SqlConnection(MisClases.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from Roles";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            cnn.Open();

            List<Roles> lista = new List<Roles>();

            SqlDataReader reader = cmd.ExecuteReader();
            

            while (reader.Read())
            {
                Roles Rol = new Roles();
                Rol.Rol_descripcion = (string)reader["rol_descripcion"];
                lista.Add(Rol);
            }
            return lista;

        }
    }
}
