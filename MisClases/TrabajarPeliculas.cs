using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace MisClases
{
    public class TrabajarPeliculas
    {
        public static void AgregarPelicula(Pelicula oPelicula)
        {
            //concexion
            SqlConnection cnn = new SqlConnection(MisClases.Properties.Settings.Default.conexion);

            //configuracion de la consulta - insert con parametros
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"insert into Pelicula (peli_codigo, peli_titulo, peli_duracion, peli_genero, peli_clase, peli_imagen, peli_avance)
            values
                (@id,@titulo,@duracion,@genero,@clase, @imagen, @avance)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@id", oPelicula.Peli_codigo);
            cmd.Parameters.AddWithValue("@titulo", oPelicula.Peli_titulo);
            cmd.Parameters.AddWithValue("@duracion", oPelicula.Peli_duracion);
            cmd.Parameters.AddWithValue("@genero", oPelicula.Peli_genero);
            cmd.Parameters.AddWithValue("@clase", oPelicula.Peli_clase);
            cmd.Parameters.AddWithValue("@imagen", oPelicula.Peli_imagen);
            cmd.Parameters.AddWithValue("@avance", oPelicula.Peli_avance);

            cnn.Open();

            cmd.ExecuteNonQuery();

            cnn.Close();
        }
        public DataTable TraerPeliculas()
        {
            SqlConnection cnn = new SqlConnection(MisClases.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from Pelicula";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            //guardar en memoria
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static List<Pelicula> cargarCombo()
        {

            SqlConnection cnn = new SqlConnection(MisClases.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from Pelicula";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            cnn.Open();

            List<Pelicula> lista = new List<Pelicula>();

            SqlDataReader reader = cmd.ExecuteReader();


            while (reader.Read())
            {
                Pelicula pelicula = new Pelicula();
                pelicula.Peli_titulo = (String)reader["peli_titulo"];
               
                lista.Add(pelicula);
            }
            return lista;

        }

        public static string idPeli(string titulo)
        {
            SqlConnection cnn = new SqlConnection(MisClases.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from Pelicula WHERE peli_titulo = @titulo";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            cnn.Open();
            cmd.Parameters.AddWithValue("@titulo", titulo);

         SqlDataReader reader = cmd.ExecuteReader();
         string titu="";
            while (reader.Read())
            {
                
               
               titu= (String)reader["peli_codigo"];
                
            }
            cnn.Close();


            return titu;

        }

        public static Pelicula traerPelicula(string codigo)
        {
            SqlConnection cnn = new SqlConnection(MisClases.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from Pelicula WHERE peli_codigo = @codigo";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            cnn.Open();
            cmd.Parameters.AddWithValue("@codigo", codigo);


            SqlDataReader reader = cmd.ExecuteReader();
            Pelicula pelicula = new Pelicula();
            while (reader.Read())
            {


                pelicula.Peli_titulo = (String)reader["peli_titulo"];
                pelicula.Peli_codigo = (String)reader["peli_codigo"];
                pelicula.Peli_duracion = (String)reader["peli_duracion"];
                pelicula.Peli_avance = (String)reader["peli_avance"];
                pelicula.Peli_clase = (String)reader["peli_clase"];
                pelicula.Peli_imagen = (String)reader["peli_imagen"];
                pelicula.Peli_genero =(String)reader["peli_genero"];
            }
            cnn.Close();


            return pelicula;

        }
    }
}
