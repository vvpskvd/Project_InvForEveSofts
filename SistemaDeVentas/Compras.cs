using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;
using System.Linq.Expressions;

namespace SistemaDeVentas
{
    public partial class Compras : Form
    {

        public Compras()
        {
            InitializeComponent();
        }
        bool edit = false;
        int rows = 0;

        //Referencia al cargar el form.
        private void Compras_Load(object sender, EventArgs e)
        {
            txtCodigo.ForeColor = Color.Gray;
            txtPrecio.ForeColor = Color.Gray;
            txtName.ForeColor = Color.Gray;
            txtProveedor.ForeColor = Color.Gray;

            btnGuardar.Enabled = false;
        }

        //Referencias a textboxs de Codigo.
        private void txtCodigo_Enter(object sender, EventArgs e)
        {
            if (txtCodigo.Text == " ")
            {
                txtCodigo.Text = "";
                txtCodigo.ForeColor = Color.Black;
            }
        }
        private void txtCodigo_Leave(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "")
            {
                txtCodigo.Text = " ";
                txtCodigo.ForeColor = Color.Gray;
            }
        }


        //Referencias a textboxs de Precio.
        private void txtPrecio_Enter(object sender, EventArgs e)
        {
            if (txtPrecio.Text == " ")
            {
                txtPrecio.Text = "";
                txtPrecio.ForeColor = Color.Black;
            }
        }
        private void txtPrecio_Leave(object sender, EventArgs e)
        {
            if (txtPrecio.Text == "")
            {
                txtPrecio.Text = " ";
                txtPrecio.ForeColor = Color.Gray;
            }
        }


        //Referencias a textboxs de Nombre del Producto.
        private void txtName_Enter(object sender, EventArgs e)
        {
            if (txtName.Text == " ")
            {
                txtName.Text = "";
                txtName.ForeColor = Color.Black;
            }
        }
        private void txtName_Leave(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                txtName.Text = " ";
                txtName.ForeColor = Color.Gray;
            }
        }


        //Rerefencias a textboxs de Proveedor.
        private void txtProveedor_Enter(object sender, EventArgs e)
        {
            if (txtProveedor.Text == " ")
            {
                txtProveedor.Text = "";
                txtProveedor.ForeColor = Color.Black;
            }
        }
        private void txtProveedor_Leave(object sender, EventArgs e)
        {
            if (txtProveedor.Text == "")
            {
                txtProveedor.Text = " ";
                txtProveedor.ForeColor = Color.Gray;
            }
        }

        //Referencia Boton Nuevo.
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            edit = false;
            btnGuardar.Enabled = true;
            //Estilo del boton Nuevo
            btnNuevo.Enabled = false;
        }

        //Funcion para limpiar los TextBoxs.
        private void ClearTextBoxs()
        {
            txtCodigo.Text = " ";
            txtPrecio.Text = " ";
            txtName.Text = " ";
            txtProveedor.Text = " ";
        }


        //Referencia al Boton Guardar.
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Validaciones a los datos a guardar.
            if (!edit)
            {
                if (string.IsNullOrWhiteSpace(txtCodigo.Text) || string.IsNullOrWhiteSpace(txtPrecio.Text) || string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtProveedor.Text))
                {
                    MessageBox.Show("Rellene todos los campos correctamente.");
                }
                else
                {
                    int precio;
                    int cant;
                    if (!int.TryParse(txtCodigo.Text, out precio) || !int.TryParse(txtPrecio.Text, out cant))
                    {
                        MessageBox.Show("Ingrese datos validos en los campos a rellenar.");
                    }
                    else
                    {
                        int x = DvgData.Rows.Add();
                        userCompras user = new userCompras();


                        user.Name = txtName.Text;
                        user.Proveedor = txtProveedor.Text;
                        user.Codigo = Convert.ToInt32(txtCodigo.Text);
                        user.Precio = Convert.ToInt32(txtPrecio.Text);

                        DvgData.Rows[x].Cells[0].Value = user.Codigo;
                        DvgData.Rows[x].Cells[1].Value = user.Precio;
                        DvgData.Rows[x].Cells[2].Value = user.Name;
                        DvgData.Rows[x].Cells[3].Value = user.Proveedor;

                        ClearTextBoxs();

                        //Estilo del boton Guardar
                        btnGuardar.Enabled = false;

                        //Estilo del boton Nuevo
                        btnNuevo.Enabled = true;
                    }
                }
            }
            else
            {
                if (DvgData.Rows.Count > 0)
                {
                    userCompras user = new userCompras();


                    user.Name = txtName.Text;
                    user.Proveedor = txtProveedor.Text;
                    user.Codigo = Convert.ToInt32(txtCodigo.Text);
                    user.Precio = Convert.ToInt32(txtPrecio.Text);

                    DvgData.Rows[rows].Cells[0].Value = user.Codigo;
                    DvgData.Rows[rows].Cells[1].Value = user.Precio;
                    DvgData.Rows[rows].Cells[2].Value = user.Name;
                    DvgData.Rows[rows].Cells[3].Value = user.Proveedor;

                    rows = 0;
                    ClearTextBoxs();
                    edit = false;
                    //Estilo del boton Guardar
                    btnGuardar.Enabled = false;

                    //Estilo del boton Nuevo
                    btnNuevo.Enabled = true;
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (DvgData.SelectedRows.Count > 0)
            {
                btnGuardar.Enabled = true;
                btnNuevo.Enabled = true;

                edit = true;
                rows = DvgData.SelectedRows[0].Index;

                txtCodigo.Text = DvgData.CurrentRow.Cells[0].Value.ToString();
                txtPrecio.Text = DvgData.CurrentRow.Cells[1].Value.ToString();
                txtName.Text = DvgData.CurrentRow.Cells[2].Value.ToString();
                txtProveedor.Text = DvgData.CurrentRow.Cells[3].Value.ToString();
            }
        }

        //Referencia al boton Eliminar. 
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (DvgData.SelectedRows.Count > 0)
            {
                int index = DvgData.SelectedRows[0].Index;
                DvgData.Rows.RemoveAt(index);
            }
        }
    }
}
