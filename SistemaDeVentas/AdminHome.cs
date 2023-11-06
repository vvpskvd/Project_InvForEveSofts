using Login;
using Login.Config;
using SistemaDeVentas;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;

namespace inventario
{
    [DebuggerDisplay($"{{{nameof(Form1Helpers.GetDebuggerDisplay)}(),nq}}")]
    public partial class AdminHome : Form
    {
        public AdminHome()
        {
            InitializeComponent();
        }

        //Variable para utilizar como puente entre el form de AdminHome y los demas forms del programa.
        private Form? activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        //Boton Ventas en AdminHome.
        private void btn_Ventas_Click(object sender, EventArgs e)
        {
            openChildForm(new Ventas());
        }

        //Boton Compras en AdminHome.
        private void btn_Compras_Click(object sender, EventArgs e)
        {
            openChildForm(new Compras());
        }

        //Boton Sistema en AdminHome.
        private void btn_Empleados_Click(object sender, EventArgs e)
        {
            openChildForm(new ConfigurationHome());
        }

        //Boton Acerca De en AdminHome.
        private void btn_Acerca_De_Click(object sender, EventArgs e)
        {
            openChildForm(new AcercaDe());
        }

        //Boton de Salir para volver al formulario LoginHome y asi volver a ingresar como otro Admin o Usuario.
        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginHome Loginhome = new LoginHome();
            Loginhome.Show();
        }
    }
}