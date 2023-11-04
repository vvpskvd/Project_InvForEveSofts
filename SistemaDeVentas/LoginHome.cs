using inventario;
using Login.Config;

namespace Login
{
    public partial class LoginHome : Form
    {
        public LoginHome()
        {
            InitializeComponent();
        }

        //Boton para ingresar y validar datos de usuario y contraseña de SuperadminConfig.
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == SuperadminConfig.UsernameAdmin && txtPass.Text == SuperadminConfig.PasswordAdmin)
            {
                this.Hide();
                AdminHome Adminhome = new AdminHome();
                Adminhome.Closed += (s, args) => this.Close();
                Adminhome.Show();
            }
            else if (txtUsuario.Text == UserConfig.UsernameUser && txtPass.Text == UserConfig.PasswordUser)
            {
                this.Hide();
                UserHome Userhome = new UserHome();
                Userhome.Closed += (s, args) => this.Close();
                Userhome.Show();
            }
            else
            {
                MessageBox.Show("Usuario y/ó Contraseña Incorrectos.");
            }
        }

        //Boton de Cancelar accion.
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Botones de mostrar / ocultar contraseña.
        private void btnVerPassword_Click(object sender, EventArgs e)
        {
            btnOcultarPassword.BringToFront();
            txtPass.PasswordChar = '\0';
        }

        private void btnOcultarPassword_Click(object sender, EventArgs e)
        {
            btnVerPassword.BringToFront();
            txtPass.PasswordChar = '*';
        }

        ForgetPassword? forgetPassword = null;
        private void forgetPass_Click(object sender, EventArgs e)
        {
            if (forgetPassword == null || forgetPassword.IsDisposed)
            {
                forgetPassword = new ForgetPassword();
                forgetPassword.Show();
            }
            else
            {
                forgetPassword.BringToFront();
            }
        }
    }
}