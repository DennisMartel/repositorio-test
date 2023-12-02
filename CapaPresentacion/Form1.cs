using System;
using CapaDatos;
using CapaNegocio;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario usuarioModel = new Usuario();
                usuarioModel.Name = txtNombre.Text;
                usuarioModel.Email = txtCorreo.Text;
                usuarioModel.Password = txtContrasena.Text;

                Usuarios usuario = new Usuarios();

                string respuesta = usuario.CtrlRegistro(usuarioModel);

                if (respuesta.Length > 0)
                {
                    MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                } else
                {
                    MessageBox.Show("Usuario registrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
