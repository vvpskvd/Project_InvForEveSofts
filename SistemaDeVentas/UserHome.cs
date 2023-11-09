using SistemaDeVentas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class UserHome : Form
    {
        public UserHome()
        {
            InitializeComponent();
        }
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
        private void btn_Ventas_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_Empleados_Click(object sender, EventArgs e)
        {

        }

        private void btn_Ventas_Click_1(object sender, EventArgs e)
        {

            openChildForm(new Compras());

        }

        private void UserOrAdmin_Click(object sender, EventArgs e)
        {

        }
    }
}
