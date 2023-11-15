namespace SistemaDeVentas
{
    partial class Compras
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Compras));
            groupBox1 = new GroupBox();
            label4 = new Label();
            txtName = new TextBox();
            txtPrecio = new TextBox();
            txtProveedor = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtCodigo = new TextBox();
            label1 = new Label();
            btnEliminar = new Button();
            btnEditar = new Button();
            btnGuardar = new Button();
            btnNuevo = new Button();
            DvgData = new DataGridView();
            CodigoProducto = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            NombreProducto = new DataGridViewTextBoxColumn();
            Proveedor = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DvgData).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(txtPrecio);
            groupBox1.Controls.Add(txtProveedor);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtCodigo);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(123, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(717, 239);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(373, 128);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 7;
            label4.Text = "Proveedor";
            // 
            // txtName
            // 
            txtName.Cursor = Cursors.IBeam;
            txtName.Location = new Point(38, 146);
            txtName.Name = "txtName";
            txtName.Size = new Size(217, 23);
            txtName.TabIndex = 6;
            txtName.Enter += txtName_Enter;
            txtName.Leave += txtName_Leave;
            // 
            // txtPrecio
            // 
            txtPrecio.Cursor = Cursors.IBeam;
            txtPrecio.Location = new Point(373, 63);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(217, 23);
            txtPrecio.TabIndex = 5;
            txtPrecio.Enter += txtPrecio_Enter;
            txtPrecio.Leave += txtPrecio_Leave;
            // 
            // txtProveedor
            // 
            txtProveedor.Cursor = Cursors.IBeam;
            txtProveedor.Location = new Point(373, 146);
            txtProveedor.Name = "txtProveedor";
            txtProveedor.Size = new Size(217, 23);
            txtProveedor.TabIndex = 4;
            txtProveedor.Enter += txtProveedor_Enter;
            txtProveedor.Leave += txtProveedor_Leave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 128);
            label3.Name = "label3";
            label3.Size = new Size(122, 15);
            label3.TabIndex = 3;
            label3.Text = "Nombre del Producto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(373, 45);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 2;
            label2.Text = "Precio";
            // 
            // txtCodigo
            // 
            txtCodigo.Cursor = Cursors.IBeam;
            txtCodigo.Location = new Point(38, 63);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(217, 23);
            txtCodigo.TabIndex = 1;
            txtCodigo.Enter += txtCodigo_Enter;
            txtCodigo.Leave += txtCodigo_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 45);
            label1.Name = "label1";
            label1.Size = new Size(117, 15);
            label1.TabIndex = 0;
            label1.Text = "Codigo del Producto";
            // 
            // btnEliminar
            // 
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminar.Location = new Point(694, 284);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(146, 53);
            btnEliminar.TabIndex = 1;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Cursor = Cursors.Hand;
            btnEditar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEditar.Location = new Point(496, 284);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(146, 53);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuardar.Location = new Point(316, 284);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(146, 53);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Cursor = Cursors.Hand;
            btnNuevo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnNuevo.Location = new Point(123, 284);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(146, 53);
            btnNuevo.TabIndex = 4;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // DvgData
            // 
            DvgData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DvgData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DvgData.Columns.AddRange(new DataGridViewColumn[] { CodigoProducto, Precio, NombreProducto, Proveedor });
            DvgData.Location = new Point(32, 364);
            DvgData.Name = "DvgData";
            DvgData.RowHeadersWidth = 51;
            DvgData.RowTemplate.Height = 25;
            DvgData.Size = new Size(905, 238);
            DvgData.TabIndex = 5;
            // 
            // CodigoProducto
            // 
            CodigoProducto.HeaderText = "Codigo del Producto";
            CodigoProducto.MinimumWidth = 6;
            CodigoProducto.Name = "CodigoProducto";
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.MinimumWidth = 6;
            Precio.Name = "Precio";
            // 
            // NombreProducto
            // 
            NombreProducto.HeaderText = "Nombre del Producto";
            NombreProducto.MinimumWidth = 6;
            NombreProducto.Name = "NombreProducto";
            // 
            // Proveedor
            // 
            Proveedor.HeaderText = "Proveedor";
            Proveedor.MinimumWidth = 6;
            Proveedor.Name = "Proveedor";
            // 
            // Compras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(983, 643);
            ControlBox = false;
            Controls.Add(DvgData);
            Controls.Add(btnNuevo);
            Controls.Add(btnGuardar);
            Controls.Add(btnEditar);
            Controls.Add(btnEliminar);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Compras";
            Text = "Menu - Compras";
            Load += Compras_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DvgData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label4;
        private TextBox txtName;
        private TextBox txtPrecio;
        private TextBox txtProveedor;
        private Label label3;
        private Label label2;
        private TextBox txtCodigo;
        private Label label1;
        private Button btnEliminar;
        private Button btnEditar;
        private Button btnGuardar;
        private Button btnNuevo;
        private DataGridView DvgData;
        private DataGridViewTextBoxColumn CodigoProducto;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn NombreProducto;
        private DataGridViewTextBoxColumn Proveedor;
    }
}