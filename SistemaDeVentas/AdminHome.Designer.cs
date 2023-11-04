namespace inventario
{
    partial class AdminHome
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminHome));
            datos = new GroupBox();
            txtcant = new TextBox();
            txtprecio = new TextBox();
            label2 = new Label();
            txtname = new TextBox();
            label4 = new Label();
            label3 = new Label();
            dvgdatos = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            btnnuevo = new Button();
            btneditar = new Button();
            btnguardar = new Button();
            btneliminar = new Button();
            panel1 = new Panel();
            btn_Productos = new Button();
            btn_Acerca_De = new Button();
            btn_Empleados = new Button();
            btn_Ventas = new Button();
            btn_Compras = new Button();
            btn_Salir = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            datos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgdatos).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // datos
            // 
            datos.BackColor = SystemColors.ButtonFace;
            datos.BackgroundImageLayout = ImageLayout.None;
            datos.Controls.Add(txtcant);
            datos.Controls.Add(txtprecio);
            datos.Controls.Add(label2);
            datos.Controls.Add(txtname);
            datos.Controls.Add(label4);
            datos.Controls.Add(label3);
            datos.FlatStyle = FlatStyle.System;
            datos.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            datos.ForeColor = SystemColors.ActiveCaptionText;
            datos.Location = new Point(346, 23);
            datos.Name = "datos";
            datos.Size = new Size(448, 338);
            datos.TabIndex = 2;
            datos.TabStop = false;
            datos.Tag = "";
            datos.Text = "datos";
            datos.Enter += groupBox1_Enter;
            // 
            // txtcant
            // 
            txtcant.Cursor = Cursors.IBeam;
            txtcant.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtcant.Location = new Point(27, 244);
            txtcant.Name = "txtcant";
            txtcant.Size = new Size(140, 21);
            txtcant.TabIndex = 7;
            txtcant.Text = "cantidad";
            txtcant.Enter += txtcant_Enter;
            txtcant.Leave += txtcant_Leave;
            // 
            // txtprecio
            // 
            txtprecio.BackColor = SystemColors.HighlightText;
            txtprecio.Cursor = Cursors.IBeam;
            txtprecio.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtprecio.ForeColor = SystemColors.InfoText;
            txtprecio.Location = new Point(27, 181);
            txtprecio.Name = "txtprecio";
            txtprecio.RightToLeft = RightToLeft.No;
            txtprecio.Size = new Size(140, 21);
            txtprecio.TabIndex = 10;
            txtprecio.Text = "precio";
            txtprecio.Enter += txtprecio_Enter;
            txtprecio.Leave += txtprecio_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(27, 223);
            label2.Name = "label2";
            label2.Size = new Size(64, 17);
            label2.TabIndex = 4;
            label2.Text = "Cantidad";
            label2.UseWaitCursor = true;
            label2.Click += label2_Click;
            // 
            // txtname
            // 
            txtname.Cursor = Cursors.IBeam;
            txtname.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtname.Location = new Point(27, 104);
            txtname.Name = "txtname";
            txtname.Size = new Size(238, 21);
            txtname.TabIndex = 8;
            txtname.Text = "producto";
            txtname.Enter += txtname_Enter;
            txtname.Leave += txtname_Leave;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(27, 144);
            label4.Name = "label4";
            label4.Size = new Size(48, 17);
            label4.TabIndex = 6;
            label4.Text = "Precio";
            label4.UseWaitCursor = true;
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(27, 74);
            label3.Name = "label3";
            label3.Size = new Size(118, 17);
            label3.TabIndex = 5;
            label3.Text = "Nombre producto";
            label3.UseWaitCursor = true;
            // 
            // dvgdatos
            // 
            dvgdatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgdatos.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dvgdatos.Location = new Point(318, 400);
            dvgdatos.Name = "dvgdatos";
            dvgdatos.RowHeadersWidth = 51;
            dvgdatos.RowTemplate.Height = 29;
            dvgdatos.Size = new Size(904, 266);
            dvgdatos.TabIndex = 17;
            dvgdatos.CellContentClick += dataGridView2_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 250;
            // 
            // Column2
            // 
            Column2.HeaderText = "Nombre producto";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 300;
            // 
            // Column3
            // 
            Column3.HeaderText = "Precio";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 250;
            // 
            // Column4
            // 
            Column4.HeaderText = "Cantidad";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 198;
            // 
            // btnnuevo
            // 
            btnnuevo.BackColor = SystemColors.HotTrack;
            btnnuevo.ForeColor = SystemColors.ButtonHighlight;
            btnnuevo.Location = new Point(837, 49);
            btnnuevo.Name = "btnnuevo";
            btnnuevo.Size = new Size(170, 60);
            btnnuevo.TabIndex = 18;
            btnnuevo.Text = "Nuevo";
            btnnuevo.UseVisualStyleBackColor = false;
            btnnuevo.Click += btnnuevo_Click;
            // 
            // btneditar
            // 
            btneditar.BackColor = SystemColors.HotTrack;
            btneditar.ForeColor = SystemColors.ButtonHighlight;
            btneditar.Location = new Point(837, 183);
            btneditar.Name = "btneditar";
            btneditar.Size = new Size(170, 60);
            btneditar.TabIndex = 19;
            btneditar.Text = "Editar";
            btneditar.UseVisualStyleBackColor = false;
            btneditar.Click += btneditar_Click;
            // 
            // btnguardar
            // 
            btnguardar.BackColor = SystemColors.HotTrack;
            btnguardar.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 192, 0);
            btnguardar.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 192);
            btnguardar.ForeColor = SystemColors.ButtonHighlight;
            btnguardar.Location = new Point(837, 115);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(170, 60);
            btnguardar.TabIndex = 20;
            btnguardar.Text = "Guardar";
            btnguardar.UseVisualStyleBackColor = false;
            btnguardar.Click += btnguardar_Click;
            // 
            // btneliminar
            // 
            btneliminar.BackColor = SystemColors.HotTrack;
            btneliminar.ForeColor = SystemColors.ButtonHighlight;
            btneliminar.Location = new Point(837, 249);
            btneliminar.Name = "btneliminar";
            btneliminar.Size = new Size(170, 60);
            btneliminar.TabIndex = 21;
            btneliminar.Text = "Eliminar";
            btneliminar.UseVisualStyleBackColor = false;
            btneliminar.Click += btneliminar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Controls.Add(btn_Productos);
            panel1.Controls.Add(btn_Acerca_De);
            panel1.Controls.Add(btn_Empleados);
            panel1.Controls.Add(btn_Ventas);
            panel1.Controls.Add(btn_Compras);
            panel1.Controls.Add(btn_Salir);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(241, 689);
            panel1.TabIndex = 22;
            // 
            // btn_Productos
            // 
            btn_Productos.FlatStyle = FlatStyle.Flat;
            btn_Productos.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Productos.Location = new Point(39, 434);
            btn_Productos.Name = "btn_Productos";
            btn_Productos.Size = new Size(166, 46);
            btn_Productos.TabIndex = 29;
            btn_Productos.Text = "Productos";
            btn_Productos.UseVisualStyleBackColor = true;
            // 
            // btn_Acerca_De
            // 
            btn_Acerca_De.FlatStyle = FlatStyle.Flat;
            btn_Acerca_De.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Acerca_De.Location = new Point(34, 545);
            btn_Acerca_De.Name = "btn_Acerca_De";
            btn_Acerca_De.Size = new Size(166, 46);
            btn_Acerca_De.TabIndex = 28;
            btn_Acerca_De.Text = "Acerca De";
            btn_Acerca_De.UseVisualStyleBackColor = true;
            // 
            // btn_Empleados
            // 
            btn_Empleados.FlatStyle = FlatStyle.Flat;
            btn_Empleados.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Empleados.Location = new Point(39, 371);
            btn_Empleados.Name = "btn_Empleados";
            btn_Empleados.Size = new Size(166, 46);
            btn_Empleados.TabIndex = 27;
            btn_Empleados.Text = "Empleados";
            btn_Empleados.UseVisualStyleBackColor = true;
            // 
            // btn_Ventas
            // 
            btn_Ventas.FlatStyle = FlatStyle.Flat;
            btn_Ventas.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Ventas.Location = new Point(39, 242);
            btn_Ventas.Name = "btn_Ventas";
            btn_Ventas.Size = new Size(166, 46);
            btn_Ventas.TabIndex = 26;
            btn_Ventas.Text = "Ventas";
            btn_Ventas.UseVisualStyleBackColor = true;
            // 
            // btn_Compras
            // 
            btn_Compras.FlatStyle = FlatStyle.Flat;
            btn_Compras.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Compras.Location = new Point(39, 306);
            btn_Compras.Name = "btn_Compras";
            btn_Compras.Size = new Size(166, 46);
            btn_Compras.TabIndex = 24;
            btn_Compras.Text = "Compras";
            btn_Compras.UseVisualStyleBackColor = true;
            // 
            // btn_Salir
            // 
            btn_Salir.FlatStyle = FlatStyle.Flat;
            btn_Salir.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Salir.Location = new Point(34, 609);
            btn_Salir.Name = "btn_Salir";
            btn_Salir.Size = new Size(166, 46);
            btn_Salir.TabIndex = 23;
            btn_Salir.Text = "Salir";
            btn_Salir.UseVisualStyleBackColor = true;
            btn_Salir.Click += btn_Salir_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = SistemaDeVentas.Properties.Resources.LogoImage;
            pictureBox1.Location = new Point(34, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(171, 160);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(-13, 166);
            label1.Name = "label1";
            label1.Size = new Size(287, 25);
            label1.TabIndex = 23;
            label1.Text = "_________________________";
            // 
            // AdminHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1234, 689);
            Controls.Add(panel1);
            Controls.Add(btneliminar);
            Controls.Add(btnguardar);
            Controls.Add(btneditar);
            Controls.Add(btnnuevo);
            Controls.Add(dvgdatos);
            Controls.Add(datos);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "AdminHome";
            RightToLeft = RightToLeft.No;
            RightToLeftLayout = true;
            Text = "Admin - InventoryForEveryone";
            Load += Form1_Load;
            datos.ResumeLayout(false);
            datos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dvgdatos).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox datos;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtcant;
        private TextBox txtname;
        private TextBox txtprecio;
        private DataGridView dvgdatos;
        private Button btnnuevo;
        private Button btneditar;
        private Button btnguardar;
        private Button btneliminar;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Button btn_Salir;
        private Button btn_Acerca_De;
        private Button btn_Empleados;
        private Button btn_Ventas;
        private Button btn_Compras;
        private Button btn_Productos;
    }
}