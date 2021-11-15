using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace MisClases
{
    public class TrabajarButacas
    {
        public static int TraerCodBut(string fila, string nro, int nro_sala)
        {
            SqlConnection cnn = new SqlConnection(MisClases.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select but_codigo from vistaBuSala WHERE but_fila =@fila and but_nro=@nro and sala_nro=@nro_sala";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            cnn.Open();
            cmd.Parameters.AddWithValue("@fila", fila);
            cmd.Parameters.AddWithValue("@nro", nro);
            cmd.Parameters.AddWithValue("@nro_sala", nro_sala);
           

            SqlDataReader reader = cmd.ExecuteReader();
            int varId = 0;


            if (reader.Read())
            {
                varId = (int)reader["but_codigo"];
            }
            cnn.Close();

            return varId;

        }
        public static void UpdateButaca(int codigo)
        {
            //concexion
            SqlConnection cnn = new SqlConnection(MisClases.Properties.Settings.Default.conexion);

            //configuracion de la consulta
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"update Butaca set but_estado=@estado where but_codigo = @codigo";

            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@estado", "OCUPADO");
            cmd.Parameters.AddWithValue("@codigo", codigo);

            cnn.Open();

            cmd.ExecuteNonQuery();

            cnn.Close();
        }

        public static List<Butaca> butacaOcupada(int id)
        {

            SqlConnection cnn = new SqlConnection(MisClases.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select but_fila, but_nro from vistaButacaDis WHERE proy_codigo=@id ";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            cnn.Open();

            cmd.Parameters.AddWithValue("@id", id);
           // cmd.Parameters.AddWithValue("@estado", "OCUPADO");
          //  cmd.Parameters.AddWithValue("@code", p);

            List<Butaca> lista = new List<Butaca>();

            SqlDataReader reader = cmd.ExecuteReader();
            //Ticket oTicket = null;
            Butaca but = null;
            while (reader.Read())
            {
                but = new Butaca();
                but.But_fila = (string)reader["but_fila"] + (string)reader["but_nro"];
              

                lista.Add(but);
            }
            return lista;

        }
    }

}
