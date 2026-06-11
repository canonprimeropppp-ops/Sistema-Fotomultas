using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Fotomultas.Vistas
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            // 1. Capturamos los datos que el usuario escribió en la pantalla
            string usuarioIngresado = txtUsuario.Text.Trim();
            string pinIngresado = txtContrasena.Text.Trim();

            // 2. Validación básica: Que no deje los campos vacíos
            if (string.IsNullOrEmpty(usuarioIngresado) || string.IsNullOrEmpty(pinIngresado))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Detiene la ejecución
            }

            // 3. Simulación de usuario (Para pruebas rápidas)
            if (usuarioIngresado == "admin" && pinIngresado == "1234")
            {
                MessageBox.Show("¡Inicio de sesión exitoso! Bienvenido al Sistema de Fotomultas.", "Acceso Concedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Usuario o PIN incorrectos. Intente de nuevo.", "Error de Autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContrasena.Clear();
                txtContrasena.Focus();
            }
        }
    }
}
