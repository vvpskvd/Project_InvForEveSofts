using Login;
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
    public partial class AcercaDe : Form
    {
        public AcercaDe()
        {
            InitializeComponent();
        }

        //Boton del form AcercaDe para contactar al administrador, abriendo otra ventana (la misma del ¿Olvidaste la Contraseña?.
        //Aqui se inicializa en null, para que al darle click al boton se abra el formulario de ForgetPassword.cs, ademas de validacion que si esta abierto no se abra infinitamente, solo una vez.
        ForgetPassword? forgetPassword = null;
        private void btnContactAdmin_Click(object sender, EventArgs e)
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
