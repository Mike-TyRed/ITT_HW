using System.Data;
using System.Data.SqlClient;
using Capa_Entidad.Cache;

namespace Capa_Datos
{
    public class ClassADU: ClassDatos /*clase de acceso a datos de usuario*/
    {
        public bool Login(string usuario, string contraseña) 
        {
            using (var conexion = ObtenerConexion()) /*creamos una variable implicita de coneccion para optener la coneccion con la bd*/
            {
                conexion.Open();/*no es necesario cerrar la coneccion ya que al terminar el bloque using la conexión será desechada y se liberaran los recursos utilizados*/
                using (var comando = new SqlCommand()) 
                {
                    comando.Connection = conexion;
                    comando.CommandText = "select * from Users where LoginName=@user and password=@pass";/*obtiene la instruccion de Transact-SQL, o tambien el procedimiento almacenado*/
                    comando.Parameters.AddWithValue("@user",usuario);
                    comando.Parameters.AddWithValue("@pass", contraseña);
                    comando.CommandType = CommandType.Text;
                    SqlDataReader reader = comando.ExecuteReader();
                    if (reader.HasRows) /*si el lector dice que tiene filas entonces es que si se encontraron los datos*/
                    {
                        while (reader.Read())
                        {
                            login_cache_usuario.UserID = reader.GetInt32(0);
                            login_cache_usuario.LoginName = reader.GetString(1);
                            login_cache_usuario.Email = reader.GetString(2);
                            login_cache_usuario.Telefono = reader.GetString(3);
                            login_cache_usuario.Password = reader.GetString(4);
                            login_cache_usuario.Cargo = reader.GetString(5);
                        }
                        return true;
                    }
                    else /*no se encontraron los datos*/
                    {
                        return false;
                    }
                }
            }

        }
    }
}
