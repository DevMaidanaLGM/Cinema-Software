using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace MisClases
{
    public class TrabajarClientes
    {
        public Cliente TraerCliente(string cod)
        {
            SqlConnection cnn = new SqlConnection(MisClases.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from Cliente where (cli_dni=@cod)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@cod", cod);

            cnn.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            Cliente oCliente = null;

            if(reader.Read())
            {
                oCliente = new Cliente();
                oCliente.Cli_dni = (int)reader["cli_dni"];
                oCliente.Cli_nombre = (string)reader["cli_nombre"];
                oCliente.Cli_apellido = (string)reader["cli_apellido"];
                oCliente.Cli_telefono = (string)reader["cli_telefono"];
                oCliente.Cli_email = (string)reader["cli_email"];
            }
            cnn.Close();

            return oCliente;

        }

        public static void AgregarCliente(Cliente oCliente)
        {
            //concexion
            SqlConnection cnn = new SqlConnection(MisClases.Properties.Settings.Default.conexion);

            //configuracion de la consulta - insert con parametros
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"insert into Cliente (cli_dni,cli_nombre,cli_apellido,cli_telefono,cli_email)
            values
                (@dni,@n,@a,@t,@e)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@dni", oCliente.Cli_dni);
            cmd.Parameters.AddWithValue("@n", oCliente.Cli_nombre);
            cmd.Parameters.AddWithValue("@a", oCliente.Cli_apellido);
            cmd.Parameters.AddWithValue("@t", oCliente.Cli_telefono);
            cmd.Parameters.AddWithValue("@e", oCliente.Cli_email);

            cnn.Open();

            cmd.ExecuteNonQuery();

            cnn.Close();
        }

        public static void ModificarCliente(Cliente oCliente)
        {
            //concexion
            SqlConnection cnn = new SqlConnection(MisClases.Properties.Settings.Default.conexion);

            //configuracion de la consulta
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"update Cliente set cli_nombre=@n,cli_apellido=@a,cli_telefono=@t,cli_email=@e
                                where cli_dni=@dni";

            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@dni", oCliente.Cli_dni);
            cmd.Parameters.AddWithValue("@n", oCliente.Cli_nombre);
            cmd.Parameters.AddWithValue("@a", oCliente.Cli_apellido);
            cmd.Parameters.AddWithValue("@t", oCliente.Cli_telefono);
            cmd.Parameters.AddWithValue("@e", oCliente.Cli_email);

            cnn.Open();

            cmd.ExecuteNonQuery();

            cnn.Close();
        }

        public static List<Cliente> cargarCombo()
        {

            SqlConnection cnn = new SqlConnection(MisClases.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from Cliente";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            cnn.Open();

            List<Cliente> lista = new List<Cliente>();

            SqlDataReader reader = cmd.ExecuteReader();


            while (reader.Read())
            {
                Cliente oCliente = new Cliente();
                oCliente.Cli_nombre = (Int32)reader["cli_dni"]+ ", "+ (string)reader["cli_nombre"] + " "+(string)reader["cli_apellido"];
                lista.Add(oCliente);
            }
            return lista;

        }


        public DataTable TraerCli()
        {
            SqlConnection cnn = new SqlConnection(MisClases.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from Cliente";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            //guardar en memoria
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }


    }
}
