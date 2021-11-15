using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using System.Data;
using System.Data.SqlClient;

namespace MisClases
{
    public class TrabajarProyecciones
    {

        public static void AgregarProyecciones(Proyeccion oProyeccion)
        {
            //concexion
            SqlConnection cnn = new SqlConnection(MisClases.Properties.Settings.Default.conexion);

            //configuracion de la consulta - insert con parametros
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"insert into Proyeccion (proy_codigo, proy_fecha_hora, peli_codigo, sala_nro)
            values
                (@pco,@pf,@pelic,@pns)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@pco", oProyeccion.Proy_codigo);
            cmd.Parameters.AddWithValue("@pf", oProyeccion.Proy_fecha_hora);
            cmd.Parameters.AddWithValue("@pelic", oProyeccion.Peli_codigo);
            cmd.Parameters.AddWithValue("@pns", oProyeccion.Sala.Sala_nro);

            cnn.Open();

            cmd.ExecuteNonQuery();

            cnn.Close();
        }

        public static DataTable listado()
        {
            SqlConnection cnn = new SqlConnection(MisClases.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from View1";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            //guardar en memoria
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();


            da.Fill(dt);

            return dt;
        }

        public static Boolean vali_id(int id)
        {
            //conexion
            SqlConnection cnn = new SqlConnection(MisClases.Properties.Settings.Default.conexion);

            //configuracion de la consulta
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "select * from Proyeccion where proy_codigo=@id";

            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@id", id);

            cnn.Open();

            cmd.ExecuteNonQuery();

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return true;
            }

            cnn.Close();

            return false;
        }

        public static List<Proyeccion> cargarCombo(string id)
        {

            SqlConnection cnn = new SqlConnection(MisClases.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from Proyeccion inner join Sala on Proyeccion.sala_nro = Sala.sala_nro WHERE peli_codigo=@id";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            cnn.Open();

            cmd.Parameters.AddWithValue("@id", id);

            List<Proyeccion> lista = new List<Proyeccion>();

            SqlDataReader reader = cmd.ExecuteReader();
            //Ticket oTicket = null;
            Proyeccion peli  = null;
            while (reader.Read())
            {
               peli = new Proyeccion();
               peli.Proy_fecha_hora = (string)reader["proy_fecha_hora"];
               peli.Proy_codigo = (int)reader["proy_codigo"];
               peli.Sala = new Sala();
               peli.Sala.Sala_denominacion = (string)reader["sala_denominacion"];
               peli.Sala.Sala_nro = (int)reader["sala_nro"];

                lista.Add(peli);
            }
            return lista;

        }

        public static List<Proyeccion> cargarComboFecha(string id)
        {

            SqlConnection cnn = new SqlConnection(MisClases.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select proy_fecha_hora from Proyeccion WHERE peli_codigo=@id";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            cnn.Open();

            cmd.Parameters.AddWithValue("@id", id);



            List<Proyeccion> lista = new List<Proyeccion>();

            SqlDataReader reader = cmd.ExecuteReader();


            while (reader.Read())
            {
                Proyeccion peli = new Proyeccion();

                peli.Proy_fecha_hora = (string)reader["proy_fecha_hora"];
                lista.Add(peli);
            }
            return lista;

        }

        public static List<Proyeccion> cargarComboHora(string fecha)
        {

            SqlConnection cnn = new SqlConnection(MisClases.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select proy_hora from Proyeccion WHERE proy_fecha=@fecha";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            cnn.Open();

            cmd.Parameters.AddWithValue("@fecha", fecha);


            List<Proyeccion> lista = new List<Proyeccion>();

            SqlDataReader reader = cmd.ExecuteReader();


            while (reader.Read())
            {
                Proyeccion peli = new Proyeccion();

                peli.Proy_fecha_hora = (string)reader["proy_fecha_hora"];
                lista.Add(peli);
            }
            return lista;

        }

        public static int TraerID()
        {
            SqlConnection cnn = new SqlConnection(MisClases.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select TOP 1 * from Proyeccion ORDER BY proy_codigo DESC";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            cnn.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            int varId = 0;


            if (reader.Read())
            {
                varId = (int)reader["proy_codigo"];
            }
            cnn.Close();

            return varId;

        }

        public static int TraerIDProy(string fecha, string peli_codigo)
        {
            SqlConnection cnn = new SqlConnection(MisClases.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select proy_codigo from Proyeccion where proy_fecha_hora = @fecha and peli_codigo= @peli_codigo";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            cnn.Open();
            cmd.Parameters.AddWithValue("@fecha", fecha);
            cmd.Parameters.AddWithValue("@peli_codigo", peli_codigo);

            SqlDataReader reader = cmd.ExecuteReader();
            int varId = 0;


            if (reader.Read())
            {
                varId = (int)reader["proy_codigo"];
            }
            cnn.Close();

            return varId;

        }

        public static int TraerIDSala(string fecha, string peli_codigo)
        {
            SqlConnection cnn = new SqlConnection(MisClases.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select sala_nro from Proyeccion where proy_fecha_hora = @fecha and peli_codigo= @peli_codigo";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            cnn.Open();
            cmd.Parameters.AddWithValue("@fecha", fecha);
            cmd.Parameters.AddWithValue("@peli_codigo", peli_codigo);

            SqlDataReader reader = cmd.ExecuteReader();
            int varId = 0;


            if (reader.Read())
            {
                varId = (int)reader["sala_nro"];
            }
            cnn.Close();

            return varId;

        }
        
        
        
        
        
        
        
        
        // cargar combos de nueva proyeccion
        public static List<Sala> cargarComboNewPro()
        {

            SqlConnection cnn = new SqlConnection(MisClases.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from Sala";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            cnn.Open();

            List<Sala> lista = new List<Sala>();

            SqlDataReader reader = cmd.ExecuteReader();


            while (reader.Read())
            {
                Sala sala = new Sala();
                sala.Sala_denominacion = (int)reader["sala_nro"] + ", " + (string)reader["sala_denominacion"];
                sala.Sala_nro = (int)reader["sala_nro"];

                lista.Add(sala);
            }
            return lista;

        }

        public static List<Pelicula> cargarComboCodigoPeli()
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
                Pelicula peli = new Pelicula();
                peli.Peli_codigo = (string)reader["peli_codigo"] + ", "+  (string)reader["peli_titulo"];
                peli.Peli_clase = (string)reader["peli_codigo"];

                lista.Add(peli);
            }
            return lista;

        }


        public static Proyeccion TraerProyeccion(int cod)
        {
            SqlConnection cnn = new SqlConnection(MisClases.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from vistaModificarProy where (proy_codigo=@cod)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@cod", cod);

            cnn.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            Proyeccion oProyeccion = null;

            if (reader.Read())
            {
                oProyeccion = new Proyeccion();
                oProyeccion.Proy_codigo = (int)reader["proy_codigo"];
                oProyeccion.Proy_fecha_hora = (string)reader["proy_fecha_hora"];
                oProyeccion.Sala = new Sala();
                oProyeccion.Sala.Sala_denominacion = (int)reader["sala_nro"] + ", " + (string)reader["sala_denominacion"];
                oProyeccion.Pelicula = new Pelicula();
                oProyeccion.Pelicula.Peli_titulo = (string)reader["peli_codigo"] + ", " + (string)reader["peli_titulo"];
            }
            cnn.Close();

            return oProyeccion;

        }

        public static void ModificarProyeccion(Proyeccion oProyeccion)
        {
            //concexion
            SqlConnection cnn = new SqlConnection(MisClases.Properties.Settings.Default.conexion);

            //configuracion de la consulta
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"update Proyeccion set proy_fecha_hora=@fyh,peli_codigo=@pc,sala_nro=@sala
                                where proy_codigo=@cod";

            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@cod", oProyeccion.Proy_codigo);
            cmd.Parameters.AddWithValue("@fyh", oProyeccion.Proy_fecha_hora);
            cmd.Parameters.AddWithValue("@pc", oProyeccion.Pelicula.Peli_codigo);
            cmd.Parameters.AddWithValue("@sala", oProyeccion.Sala.Sala_nro);

            cnn.Open();

            cmd.ExecuteNonQuery();

            cnn.Close();
        }

        public static Proyeccion TraerProyeccionPorID(int cod)
        {
            SqlConnection cnn = new SqlConnection(MisClases.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from vistaModificarProy where (proy_codigo=@cod)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@cod", cod);

            cnn.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            Proyeccion oProyeccion = null;

            if (reader.Read())
            {
                oProyeccion = new Proyeccion();
                oProyeccion.Proy_codigo = (int)reader["proy_codigo"];
                oProyeccion.Peli_codigo = (string)reader["peli_codigo"];

            }
            cnn.Close();

            return oProyeccion;

        }


        // para filtro
        public static List<Proyeccion> lista()
        {

            SqlConnection cnn = new SqlConnection(MisClases.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select proy_fecha_hora from Proyeccion ";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            cnn.Open();



            List<Proyeccion> lista = new List<Proyeccion>();

            SqlDataReader reader = cmd.ExecuteReader();


            while (reader.Read())
            {
                Proyeccion peli = new Proyeccion();
                peli.Proy_fecha_hora = (string)reader["proy_fecha_hora"];
                lista.Add(peli);
            }
            return lista;

        }


        public static List<Proyeccion> lista2()
        {

            SqlConnection cnn = new SqlConnection(MisClases.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from vistafiltro ";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            cnn.Open();



            List<Proyeccion> lista = new List<Proyeccion>();

            SqlDataReader reader = cmd.ExecuteReader();


            while (reader.Read())
            {
                Proyeccion peli = new Proyeccion();
                peli.Proy_fecha_hora = (string)reader["proy_fecha_hora"];
                lista.Add(peli);
            }
            return lista;

        }

        public static DataTable listado2(string peli)
        {
            SqlConnection cnn = new SqlConnection(MisClases.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from View1 where peli_titulo like @peliTitulo + '%' ";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@peliTitulo", peli);

            //guardar en memoria
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();


            da.Fill(dt);

            return dt;
        }

     
    }

}
