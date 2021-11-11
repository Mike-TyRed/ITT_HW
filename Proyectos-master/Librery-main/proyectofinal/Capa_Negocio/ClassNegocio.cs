using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using Capa_Entidad.Cache;

namespace Capa_Negocio
{
    public class ClassNegocio
    {
        ClassADU useradu = new ClassADU();
        public bool loginUser(string usuario, string contraseña) 
        {
            return useradu.Login(usuario,contraseña);
        }
    }
}
