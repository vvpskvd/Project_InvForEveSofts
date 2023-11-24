using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;

namespace inventario
{
    [DebuggerDisplay($"{{{nameof(Form1Helpers.GetDebuggerDisplay)}(),nq}}")]
    public partial class Ventas : Form
    {
        public Ventas()
        {
            InitializeComponent();
        }
        bool edit = false;
        int id = 1;
        int rows = 0;

        private void Ventas_Load(object sender, EventArgs e)
        {
            txtname.ForeColor = Color.Gray;
            txtprecio.ForeColor = Color.Gray;
            txtcant.ForeColor = Color.Gray;
            btnguardar.Enabled = false;
        }

        private void txtname_Enter(object sender, EventArgs e)
        {
            if (txtname.Text == " ")
            {
                txtname.Text = "";
                txtname.ForeColor = Color.Black;
            }
        }

        private void txtname_Leave(object sender, EventArgs e)
        {
            if (txtname.Text == "")
            {
                txtname.Text = " ";
                txtname.ForeColor = Color.Gray;
            }
        }

        private void txtprecio_Enter(object sender, EventArgs e)
        {
            if (txtprecio.Text == " ")
            {
                txtprecio.Text = "";
                txtprecio.ForeColor = Color.Black;
            }
        }

        private void txtprecio_Leave(object sender, EventArgs e)
        {
            if (txtprecio.Text == "")
            {
                txtprecio.Text = " ";
                txtprecio.ForeColor = Color.Gray;
            }
        }

        private void txtcant_Enter(object sender, EventArgs e)
        {
            if (txtcant.Text == " ")
            {
                txtcant.Text = "";
                txtcant.ForeColor = Color.Black;
            }
        }

        private void txtcant_Leave(object sender, EventArgs e)
        {
            if (txtcant.Text == "")
            {
                txtcant.Text = " ";
                txtcant.ForeColor = Color.Gray;
            }
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            edit = false;
            btnguardar.Enabled = true;
            btnnuevo.Enabled = false;
        }

        private void cleartxt()
        {
            txtname.Text = " ";
            txtprecio.Text = " ";
            txtcant.Text = " ";
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            //Validaciones si los datos son incorrectos.
            if (!edit)
            {
                if (string.IsNullOrWhiteSpace(txtname.Text) || string.IsNullOrWhiteSpace(txtprecio.Text) || string.IsNullOrWhiteSpace(txtcant.Text))
                {
                    MessageBox.Show("Rellene todos los campos correctamente.");
                }
                else
                {
                    int precio;
                    int cant;
                    if (!int.TryParse(txtprecio.Text, out precio) || !int.TryParse(txtcant.Text, out cant))
                    {
                        MessageBox.Show("Ingrese datos validos en los campos a rellenar.");
                    }
                    else
                    {
                        int x = dvgdatos.Rows.Add();
                        user user = new user();
                        user.Id = id;
                        user.Name = txtname.Text;
                        user.Precio = precio;
                        user.Cant = cant;
                        dvgdatos.Rows[x].Cells[0].Value = user.Id;
                        dvgdatos.Rows[x].Cells[1].Value = user.Name;
                        dvgdatos.Rows[x].Cells[2].Value = user.Precio;
                        dvgdatos.Rows[x].Cells[3].Value = user.Cant;
                        cleartxt();
                        id++;
                        btnguardar.Enabled = false;
                        btnnuevo.Enabled = true;
                    }
                }
            }
            else
            {
                if (dvgdatos.Rows.Count > 0)
                {
                    user user = new user();

                    user.Name = txtname.Text;
                    user.Precio = Convert.ToInt32(txtprecio.Text);
                    user.Cant = Convert.ToInt32(txtcant.Text);

                    dvgdatos.Rows[rows].Cells[1].Value = user.Name;
                    dvgdatos.Rows[rows].Cells[2].Value = user.Precio;
                    dvgdatos.Rows[rows].Cells[3].Value = user.Cant;
                    rows = 0;
                    cleartxt();
                    edit = false;
                    btnguardar.Enabled = false;
                    btnnuevo.Enabled = true;
                }
            }
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            if (dvgdatos.SelectedRows.Count > 0)
            {
                btnguardar.Enabled = true;
                btnnuevo.Enabled = false;

                edit = true;
                rows = dvgdatos.SelectedRows[0].Index;
                txtname.Text = dvgdatos.CurrentRow.Cells[1].Value.ToString();
                txtprecio.Text = dvgdatos.CurrentRow.Cells[2].Value.ToString();
                txtcant.Text = dvgdatos.CurrentRow.Cells[3].Value.ToString();
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (dvgdatos.SelectedRows.Count > 0)
            {
                int r = dvgdatos.SelectedRows[0].Index;
                dvgdatos.Rows.RemoveAt(r);
            }
        }
    }
}