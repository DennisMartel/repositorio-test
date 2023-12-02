using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Usuarios
    {
        public string CtrlRegistro(Usuario usuario)
        {
            Usuario model = new Usuario();
            string respuesta = "";

            if (string.IsNullOrEmpty(usuario.Name) || string.IsNullOrEmpty(usuario.Email)
                ||string.IsNullOrEmpty(usuario.Password))
            {
                respuesta = "Todos los campos son obligatorios";    
            } else
            {
                model.registro(usuario);
            }


            return respuesta;
        }
    }
}
