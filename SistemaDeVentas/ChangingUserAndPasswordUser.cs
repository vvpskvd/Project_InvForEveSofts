using Login.Config;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeVentas
{
    public partial class ChangingUserAndPasswordUser : Form
    {
        public ChangingUserAndPasswordUser()
        {
            InitializeComponent();
        }

        //Boton de cambiar datos para login.
        private void btnGuardarDatos_Click(object sender, EventArgs e)
        {
            // Comprobaciones si estan vacios los espacios, si son numeros en usuario y si contienen caracteres especiales.
            if (string.IsNullOrWhiteSpace(txtboxUsuario.Text) || string.IsNullOrWhiteSpace(txtboxPassword.Text))
            {
                MessageBox.Show("Por favor, asegúrate de que los campos de usuario y contraseña no estén vacíos.");
                return;
            }

            if (txtboxUsuario.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Por favor, asegúrate de que el campo de usuario no contenga números.");
                return;
            }

            // Si las comprobaciones son exitosas, cambia los valores de Usuario y Contraseña
            UserConfig.UsernameUser = txtboxUsuario.Text;
            UserConfig.PasswordUser = txtboxPassword.Text;
            this.Close();
        }
    }
}