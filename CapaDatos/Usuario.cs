using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CapaDatos
{
    public class Usuario
    {
        private Conexion con = new Conexion();

        public int id;
        string name, email, password;

        public int Id { 
            get => id; 
            set => id = value; 
        }

        public string Name { 
            get => name; 
            set => name = value;
        }

        public string Email { 
            get => email;
            set => email = value;
        }

        public string Password { 
            get => password; 
            set => password = value; 
        }

        public int registro(Usuario usuario)
        {
            int resultado = 0;

            try
            {

                string sql = "INSERT INTO usuarios (name, email, password) VALUES (@name, @email, @password)";
                SqlCommand cmd = new SqlCommand(sql);
                cmd.Connection = con.AbrirConexion();
                cmd.Parameters.AddWithValue("@name", usuario.Name);
                cmd.Parameters.AddWithValue("@email", usuario.Email);
                cmd.Parameters.AddWithValue("@password", usuario.Password);

                resultado = cmd.ExecuteNonQuery();
                con.CerrarConexion();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return resultado;
        }
    }
}
