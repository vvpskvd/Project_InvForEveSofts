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

        //Boton para ingresar y validar datos de usuario.
        //Aca valida si es Usuario o Administrador en las credenciales ya estaticas de SuperadminConfig
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
            Application.Exit();
        }

        //Boton de Mostrar contraseña.
        private void btnVerPassword_Click(object sender, EventArgs e)
        {
            btnOcultarPassword.BringToFront();
            txtPass.PasswordChar = '\0';
        }

        //Boton de Ocultar contraseña
        private void btnOcultarPassword_Click(object sender, EventArgs e)
        {
            btnVerPassword.BringToFront();
            txtPass.PasswordChar = '*';
        }

        //Boton de ¿Olvidaste tu Contraseña?
        //Aqui se inicializa en null, para que al darle click al boton se abra el formulario de ForgetPassword.cs, ademas de validacion que si esta abierto no se abra infinitamente, solo una vez.
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

        //Validacion para que si el usuario presiona "Enter" ingrese y valide datos.
        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnIngresar.PerformClick();
                e.SuppressKeyPress = true;
            }
        }
    }
}