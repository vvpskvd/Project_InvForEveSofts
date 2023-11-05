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
    public partial class ConfigurationHome : Form
    {
        public ConfigurationHome()
        {
            InitializeComponent();
            this.Load += ChangeSystem;
        }

        //Elemento para mostrar en los labelAdminUsername, labelAdminPassword, labelUserUsername y labelUserPassword del ConfigurationHome los datos que estan guardados en el SuperadminConfig.
        private void ChangeSystem(object? sender, EventArgs e)
        {
            labelAdminUsername.Text = Login.Config.SuperadminConfig.UsernameAdmin;
            labelAdminPassword.Text = Login.Config.SuperadminConfig.PasswordAdmin;
            labelUserUsername.Text = Login.Config.UserConfig.UsernameUser;
            labelUserPassword.Text = Login.Config.UserConfig.PasswordUser;
        }
    }
}
