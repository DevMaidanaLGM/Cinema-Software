using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

using System.Collections.ObjectModel;

namespace MisClases
{
    public class TrabajarUsuarios
    {
        public static ObservableCollection<Usuario> TraerUsuarios()
        {
            SqlConnection cnn = new SqlConnection(MisClases.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            //cmd.CommandText = "select * from Usuario";

            cmd.CommandText = "SELECT * FROM usuario INNER JOIN roles ON usuario.rol_codigo = roles.rol_codigo";
            
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            ObservableCollection<Usuario> Lista = new ObservableCollection<Usuario>();

            cnn.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            while(reader.Read())
            {
                Usuario oUsuario = new Usuario();
                oUsuario.Usu_id = (int)reader["usu_id"];
                oUsuario.Usu_nombreUsuario = (string)reader["usu_nombreUsuario"];
                oUsuario.Usu_apellidoNombre = (string)reader["usu_apellidoNombre"];
                oUsuario.Usu_contraseña = (string)reader["usu_contraseña"];
                oUsuario.Rol_codigo = (string)reader["rol_codigo"];
                oUsuario.Roles = new Roles();
                oUsuario.Roles.Rol_descripcion = (string)reader["rol_descripcion"];

               

                Lista.Add(oUsuario);
            }

            return Lista;
        }

        public static Boolean vali_id(int id)
        {
            //conexion
            SqlConnection cnn = new SqlConnection(MisClases.Properties.Settings.Default.conexion);

            //configuracion de la consulta
            SqlCommand cmd = new SqlCommand();
       
            cmd.CommandText = "select * from Usuario where usu_id=@id";

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

        public static void AgregarUsuario(Usuario oUsuario)
        {
            //concexion
            SqlConnection cnn = new SqlConnection(MisClases.Properties.Settings.Default.conexion);

            //configuracion de la consulta - insert con parametros
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"insert into Usuario (usu_id,usu_nombreUsuario,usu_contraseña,usu_apellidoNombre,rol_codigo)
            values
                (@id,@n,@c,@ayn,@r)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@id", oUsuario.Usu_id);
            cmd.Parameters.AddWithValue("@n", oUsuario.Usu_nombreUsuario);
            cmd.Parameters.AddWithValue("@c", oUsuario.Usu_contraseña);
            cmd.Parameters.AddWithValue("@ayn", oUsuario.Usu_apellidoNombre);
            cmd.Parameters.AddWithValue("@r", oUsuario.Rol_codigo);

            cnn.Open();

            cmd.ExecuteNonQuery();

            cnn.Close();
        }

        public static void ModificarUsuario(Usuario oUsuario)
        {
            //concexion
            SqlConnection cnn = new SqlConnection(MisClases.Properties.Settings.Default.conexion);

            //configuracion de la consulta
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"update Usuario set usu_nombreUsuario=@n,usu_contraseña=@c,usu_apellidoNombre=@ayn,rol_codigo=@r
                                where usu_id=@id";

            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@id", oUsuario.Usu_id);
            cmd.Parameters.AddWithValue("@n", oUsuario.Usu_nombreUsuario);
            cmd.Parameters.AddWithValue("@c", oUsuario.Usu_contraseña);
            cmd.Parameters.AddWithValue("@ayn", oUsuario.Usu_apellidoNombre);
            cmd.Parameters.AddWithValue("@r", oUsuario.Rol_codigo);

            cnn.Open();

            cmd.ExecuteNonQuery();

            cnn.Close();
        }

        public static void EliminarUsuario(int id)
        {
            //conexion
            SqlConnection cnn = new SqlConnection(MisClases.Properties.Settings.Default.conexion);

            //configuracion de la consulta
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"delete from Usuario where usu_id=@id";

            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@id", id);

            cnn.Open();

            cmd.ExecuteNonQuery();

            cnn.Close();
        }

        public ObservableCollection<Usuario> TraerUsuariosCol()
        {
            ObservableCollection<Usuario> listaUsuario = new ObservableCollection<Usuario>();

            SqlConnection cnn = new SqlConnection(MisClases.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM usuario INNER JOIN roles ON usuario.rol_codigo = roles.rol_codigo ";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            //guardar en memoria
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Usuario usuario = new Usuario();
                usuario.Usu_id = Convert.ToInt32(dt.Rows[i]["usu_id"]);
                usuario.Usu_nombreUsuario = dt.Rows[i]["usu_nombreUsuario"].ToString();
                usuario.Usu_apellidoNombre = dt.Rows[i]["usu_apellidoNombre"].ToString();
                usuario.Usu_contraseña = dt.Rows[i]["usu_contraseña"].ToString();
                usuario.Roles = new Roles();

                usuario.Roles.Rol_descripcion = dt.Rows[i]["rol_descripcion"].ToString();
                listaUsuario.Add(usuario);
            }

            return listaUsuario;
        }

        public static Boolean login(string user, string pass)
        {
            SqlConnection cnn = new SqlConnection(MisClases.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            //cmd.CommandText = "select * from Usuario";

            cmd.CommandText = "SELECT * FROM usuario where usu_nombreUsuario=@user and usu_contraseña=@pass";

            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@user", user);
            cmd.Parameters.AddWithValue("@pass", pass);

            cnn.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            
            Usuario oUsuario = new Usuario();
            if (reader.Read())
            {
                return true;
            }
            cnn.Close();

            return false;
        }

        public static Usuario TraerRol(string user, string pass)
        {
            SqlConnection cnn = new SqlConnection(MisClases.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            //cmd.CommandText = "select * from Usuario";

            cmd.CommandText = "SELECT * FROM usuario where usu_nombreUsuario=@user and usu_contraseña=@pass";

            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@user", user);
            cmd.Parameters.AddWithValue("@pass", pass);
            
            cnn.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            Usuario oUsuario = new Usuario();
            if (reader.Read())
            {
               
                oUsuario.Usu_id = (int)reader["usu_id"];
                oUsuario.Usu_apellidoNombre = (string)reader["usu_apellidoNombre"];
                oUsuario.Rol_codigo = (string)reader["rol_codigo"];
               




            }

            return oUsuario;
        }
        
    }
}
