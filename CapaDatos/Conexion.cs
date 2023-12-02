using System;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Security.Principal;
using System.Windows.Forms;

namespace CapaDatos
{
    public class Conexion
    {
        private SqlConnection con = new SqlConnection("Data Source="+Dns.GetHostName() + WindowsIdentity.GetCurrent().Name + ";Initial Catalog=sistema_usuarios;Integrated Security=True");

        public SqlConnection AbrirConexion()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                return con;
            } 
            catch(Exception ex)
            {
                MessageBox.Show("Error al conectar: " + ex.Message);
                return null;
            }
        }
        public SqlConnection CerrarConexion()
        {
            try
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
                return con;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar: " + ex.Message);
                return null;
            }
        }
    }
}
