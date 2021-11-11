using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Capa_Datos
{
    public abstract class ClassDatos /*esta clase no puede ser instanciada, solo se puede usar como clase base*/
    {
        private readonly string Conexion;
        public ClassDatos() /*creamos el metodo constructor*/
        {
            //Conexion = "Data Source=DESKTOP-LKM28N4;Initial Catalog=tablaprueba1;Integrated Security=True";
            Conexion = "Data Source=DESKTOP-597BORI;Initial Catalog=tablaprueba1;Integrated Security=True";
        }
        protected SqlConnection ObtenerConexion() /*metodo para obtener la conexion esta protegido para que solo se pueda acceder por medio de una clase derivada*/
        {
            return new SqlConnection (Conexion);
        }
    }
}
