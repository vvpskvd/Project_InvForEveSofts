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
            panelMenu = new Panel();
            UserOrAdmin = new Label();
            label5 = new Label();
            btn_Productos = new Button();
            btn_Acerca_De = new Button();
            btn_Empleados = new Button();
            btn_Ventas = new Button();
            btn_Compras = new Button();
            btn_Salir = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panelChildForm = new Panel();
            panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.Gray;
            panelMenu.Controls.Add(UserOrAdmin);
            panelMenu.Controls.Add(label5);
            panelMenu.Controls.Add(btn_Productos);
            panelMenu.Controls.Add(btn_Acerca_De);
            panelMenu.Controls.Add(btn_Empleados);
            panelMenu.Controls.Add(btn_Ventas);
            panelMenu.Controls.Add(btn_Compras);
            panelMenu.Controls.Add(btn_Salir);
            panelMenu.Controls.Add(pictureBox1);
            panelMenu.Controls.Add(label1);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(251, 643);
            panelMenu.TabIndex = 22;
            // 
            // UserOrAdmin
            // 
            UserOrAdmin.AutoSize = true;
            UserOrAdmin.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            UserOrAdmin.Location = new Point(91, 83);
            UserOrAdmin.Name = "UserOrAdmin";
            UserOrAdmin.Size = new Size(147, 26);
            UserOrAdmin.TabIndex = 31;
            UserOrAdmin.Text = "Administrador";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 20);
            label5.Name = "label5";
            label5.Size = new Size(198, 26);
            label5.TabIndex = 30;
            label5.Text = "Inicio sesion como:";
            // 
            // btn_Productos
            // 
            btn_Productos.Cursor = Cursors.Hand;
            btn_Productos.FlatAppearance.BorderSize = 0;
            btn_Productos.FlatStyle = FlatStyle.Flat;
            btn_Productos.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Productos.Location = new Point(3, 373);
            btn_Productos.Name = "btn_Productos";
            btn_Productos.Size = new Size(241, 46);
            btn_Productos.TabIndex = 29;
            btn_Productos.Text = "Productos";
            btn_Productos.TextAlign = ContentAlignment.MiddleLeft;
            btn_Productos.UseVisualStyleBackColor = true;
            btn_Productos.Click += btn_Productos_Click;
            // 
            // btn_Acerca_De
            // 
            btn_Acerca_De.Cursor = Cursors.Hand;
            btn_Acerca_De.FlatAppearance.BorderSize = 0;
            btn_Acerca_De.FlatStyle = FlatStyle.Flat;
            btn_Acerca_De.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Acerca_De.Location = new Point(3, 489);
            btn_Acerca_De.Name = "btn_Acerca_De";
            btn_Acerca_De.Size = new Size(241, 46);
            btn_Acerca_De.TabIndex = 28;
            btn_Acerca_De.Text = "Acerca De";
            btn_Acerca_De.TextAlign = ContentAlignment.MiddleLeft;
            btn_Acerca_De.UseVisualStyleBackColor = true;
            btn_Acerca_De.Click += btn_Acerca_De_Click;
            // 
            // btn_Empleados
            // 
            btn_Empleados.Cursor = Cursors.Hand;
            btn_Empleados.FlatAppearance.BorderSize = 0;
            btn_Empleados.FlatStyle = FlatStyle.Flat;
            btn_Empleados.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Empleados.Location = new Point(3, 306);
            btn_Empleados.Name = "btn_Empleados";
            btn_Empleados.Size = new Size(241, 46);
            btn_Empleados.TabIndex = 27;
            btn_Empleados.Text = "Empleados";
            btn_Empleados.TextAlign = ContentAlignment.MiddleLeft;
            btn_Empleados.UseVisualStyleBackColor = true;
            btn_Empleados.Click += btn_Empleados_Click;
            // 
            // btn_Ventas
            // 
            btn_Ventas.Cursor = Cursors.Hand;
            btn_Ventas.FlatAppearance.BorderSize = 0;
            btn_Ventas.FlatStyle = FlatStyle.Flat;
            btn_Ventas.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Ventas.Location = new Point(3, 183);
            btn_Ventas.Name = "btn_Ventas";
            btn_Ventas.Size = new Size(241, 46);
            btn_Ventas.TabIndex = 26;
            btn_Ventas.Text = "Ventas";
            btn_Ventas.TextAlign = ContentAlignment.MiddleLeft;
            btn_Ventas.UseVisualStyleBackColor = true;
            btn_Ventas.Click += btn_Ventas_Click;
            // 
            // btn_Compras
            // 
            btn_Compras.Cursor = Cursors.Hand;
            btn_Compras.FlatAppearance.BorderSize = 0;
            btn_Compras.FlatStyle = FlatStyle.Flat;
            btn_Compras.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Compras.Location = new Point(3, 242);
            btn_Compras.Name = "btn_Compras";
            btn_Compras.Size = new Size(241, 46);
            btn_Compras.TabIndex = 24;
            btn_Compras.Text = "Compras";
            btn_Compras.TextAlign = ContentAlignment.MiddleLeft;
            btn_Compras.UseVisualStyleBackColor = true;
            btn_Compras.Click += btn_Compras_Click;
            // 
            // btn_Salir
            // 
            btn_Salir.Cursor = Cursors.Hand;
            btn_Salir.FlatAppearance.BorderSize = 0;
            btn_Salir.FlatStyle = FlatStyle.Flat;
            btn_Salir.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Salir.Location = new Point(3, 552);
            btn_Salir.Name = "btn_Salir";
            btn_Salir.Size = new Size(241, 46);
            btn_Salir.TabIndex = 23;
            btn_Salir.Text = "Salir";
            btn_Salir.TextAlign = ContentAlignment.MiddleLeft;
            btn_Salir.UseVisualStyleBackColor = true;
            btn_Salir.Click += btn_Salir_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = SistemaDeVentas.Properties.Resources.LogoImage;
            pictureBox1.Location = new Point(3, 58);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(82, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(-13, 131);
            label1.Name = "label1";
            label1.Size = new Size(287, 25);
            label1.TabIndex = 23;
            label1.Text = "_________________________";
            // 
            // panelChildForm
            // 
            panelChildForm.BackColor = Color.Silver;
            panelChildForm.Dock = DockStyle.Fill;
            panelChildForm.Location = new Point(251, 0);
            panelChildForm.Name = "panelChildForm";
            panelChildForm.Size = new Size(983, 643);
            panelChildForm.TabIndex = 23;
            // 
            // AdminHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1234, 643);
            Controls.Add(panelChildForm);
            Controls.Add(panelMenu);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "AdminHome";
            RightToLeft = RightToLeft.No;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin - InventoryForEveryone";
            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelMenu;
        private PictureBox pictureBox1;
        private Label label1;
        private Button btn_Salir;
        private Button btn_Acerca_De;
        private Button btn_Empleados;
        private Button btn_Ventas;
        private Button btn_Compras;
        private Button btn_Productos;
        private Label label5;
        private Label UserOrAdmin;
        private Panel panelChildForm;
    }
}