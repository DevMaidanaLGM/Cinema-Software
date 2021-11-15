using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace MisClases
{
    public class TrabajarTickets
    {

        public static Ticket TraerIicket(int cod, int dni)
        {
            SqlConnection cnn = new SqlConnection(MisClases.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from VISTA where tick_nro=@cod";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@cod", cod);
            cmd.Parameters.AddWithValue("@dni", dni);

            cnn.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            Ticket oTicket = null;

            if (reader.Read())
            {
               oTicket = new Ticket();
               oTicket.Tick_nro = cod;
               oTicket.Tick_fechaVenta = (DateTime)reader["tick_fechaVenta"];
               oTicket.Precio = (decimal)reader["tick_precio"];

               oTicket.But_fila = (string)reader["but_fila"] + (string)reader["but_nro"]; 

               oTicket.Cliente = new Cliente();
               oTicket.Cliente.Cli_apellido = (string)reader["cli_apellido"];
               oTicket.Cliente.Cli_nombre = (string)reader["cli_nombre"];
               oTicket.Cliente.Cli_dni = (int)reader["cli_dni"];

               oTicket.Pelicula = new Pelicula();
               oTicket.Pelicula.Peli_titulo = (string)reader["peli_titulo"];

               oTicket.Proyecion = new Proyeccion();
               oTicket.Proyecion.Proy_fecha_hora = (string)reader["proy_fecha_hora"];

               oTicket.Sala = new Sala();
               oTicket.Sala.Sala_denominacion = (string)reader["sala_denominacion"];


            }

            cnn.Close();

            return oTicket;
        }

        public static void AgregarTicket(Ticket oTicket)
        {
            //concexion
            SqlConnection cnn = new SqlConnection(MisClases.Properties.Settings.Default.conexion);

            //configuracion de la consulta - insert con parametros
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"insert into Ticket (tick_nro,tick_fechaVenta,cli_dni,proy_codigo,but_codigo,tick_precio)
            values
                (@nro,@f,@d,@c,@fi,@nu)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@nro", oTicket.Tick_nro);
            cmd.Parameters.AddWithValue("@f", oTicket.Tick_fechaVenta);
            cmd.Parameters.AddWithValue("@d", oTicket.Cli_dni);
            cmd.Parameters.AddWithValue("@c", oTicket.Proy_codigo);
            cmd.Parameters.AddWithValue("@fi", oTicket.Butaca.But_codigo);
            cmd.Parameters.AddWithValue("@nu", oTicket.Precio);

            cnn.Open();

            cmd.ExecuteNonQuery();

            cnn.Close();
        }

        public static int TraerID()
        {
            SqlConnection cnn = new SqlConnection(MisClases.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select TOP 1 * from Ticket ORDER BY tick_nro DESC";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            cnn.Open();

            SqlDataReader reader = cmd.ExecuteReader();
           int  varId = 0;
          

            if (reader.Read())
            {
                varId = (int)reader["tick_nro"];
            }
            cnn.Close();

            return varId;

        }
    }
}
