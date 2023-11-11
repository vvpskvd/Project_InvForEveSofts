namespace Login
{
    partial class UserHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserHome));
            panelChildForm = new Panel();
            label10 = new Label();
            label6 = new Label();
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            panelMenu = new Panel();
            btnCompras = new Button();
            btn_Ventas = new Button();
            UserOrAdmin = new Label();
            label5 = new Label();
            btn_Acerca_De = new Button();
            btn_Salir = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panelChildForm.SuspendLayout();
            panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelChildForm
            // 
            panelChildForm.BackColor = Color.Silver;
            panelChildForm.Controls.Add(label10);
            panelChildForm.Controls.Add(label6);
            panelChildForm.Controls.Add(label4);
            panelChildForm.Controls.Add(label2);
            panelChildForm.Controls.Add(label3);
            panelChildForm.Dock = DockStyle.Fill;
            panelChildForm.Location = new Point(246, 0);
            panelChildForm.Margin = new Padding(3, 2, 3, 2);
            panelChildForm.Name = "panelChildForm";
            panelChildForm.Size = new Size(988, 643);
            panelChildForm.TabIndex = 25;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(261, 302);
            label10.Name = "label10";
            label10.Size = new Size(410, 46);
            label10.TabIndex = 40;
            label10.Text = "InventoryForEveryone";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(234, 572);
            label6.Name = "label6";
            label6.Size = new Size(498, 25);
            label6.TabIndex = 36;
            label6.Text = "Seleccione cualquier elemento del menu para comenzar";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(285, 246);
            label4.Name = "label4";
            label4.Size = new Size(354, 46);
            label4.TabIndex = 35;
            label4.Text = "Sismeta de Ventas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(434, 191);
            label2.Name = "label2";
            label2.Size = new Size(56, 46);
            label2.TabIndex = 34;
            label2.Text = "Al";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(234, 130);
            label3.Name = "label3";
            label3.Size = new Size(446, 46);
            label3.TabIndex = 33;
            label3.Text = "Bienvenido / Bienvenida";
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.Gray;
            panelMenu.Controls.Add(btnCompras);
            panelMenu.Controls.Add(btn_Ventas);
            panelMenu.Controls.Add(UserOrAdmin);
            panelMenu.Controls.Add(label5);
            panelMenu.Controls.Add(btn_Acerca_De);
            panelMenu.Controls.Add(btn_Salir);
            panelMenu.Controls.Add(pictureBox1);
            panelMenu.Controls.Add(label1);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Margin = new Padding(3, 2, 3, 2);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(246, 643);
            panelMenu.TabIndex = 24;
            // 
            // btnCompras
            // 
            btnCompras.Cursor = Cursors.Hand;
            btnCompras.FlatAppearance.BorderSize = 0;
            btnCompras.FlatStyle = FlatStyle.Flat;
            btnCompras.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnCompras.Location = new Point(10, 302);
            btnCompras.Margin = new Padding(3, 2, 3, 2);
            btnCompras.Name = "btnCompras";
            btnCompras.Size = new Size(211, 45);
            btnCompras.TabIndex = 33;
            btnCompras.Text = "Compras";
            btnCompras.TextAlign = ContentAlignment.MiddleLeft;
            btnCompras.UseVisualStyleBackColor = true;
            btnCompras.Click += btnCompras_Click;
            // 
            // btn_Ventas
            // 
            btn_Ventas.Cursor = Cursors.Hand;
            btn_Ventas.FlatAppearance.BorderSize = 0;
            btn_Ventas.FlatStyle = FlatStyle.Flat;
            btn_Ventas.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Ventas.Location = new Point(10, 229);
            btn_Ventas.Margin = new Padding(3, 2, 3, 2);
            btn_Ventas.Name = "btn_Ventas";
            btn_Ventas.Size = new Size(211, 45);
            btn_Ventas.TabIndex = 32;
            btn_Ventas.Text = "Ventas";
            btn_Ventas.TextAlign = ContentAlignment.MiddleLeft;
            btn_Ventas.UseVisualStyleBackColor = true;
            btn_Ventas.Click += btn_Ventas_Click;
            // 
            // UserOrAdmin
            // 
            UserOrAdmin.AutoSize = true;
            UserOrAdmin.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            UserOrAdmin.Location = new Point(97, 62);
            UserOrAdmin.Name = "UserOrAdmin";
            UserOrAdmin.Size = new Size(87, 26);
            UserOrAdmin.TabIndex = 31;
            UserOrAdmin.Text = "Usuario";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(10, 15);
            label5.Name = "label5";
            label5.Size = new Size(198, 26);
            label5.TabIndex = 30;
            label5.Text = "Inicio sesion como:";
            // 
            // btn_Acerca_De
            // 
            btn_Acerca_De.Cursor = Cursors.Hand;
            btn_Acerca_De.FlatAppearance.BorderSize = 0;
            btn_Acerca_De.FlatStyle = FlatStyle.Flat;
            btn_Acerca_De.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Acerca_De.Location = new Point(10, 487);
            btn_Acerca_De.Margin = new Padding(3, 2, 3, 2);
            btn_Acerca_De.Name = "btn_Acerca_De";
            btn_Acerca_De.Size = new Size(211, 52);
            btn_Acerca_De.TabIndex = 28;
            btn_Acerca_De.Text = "Acerca De";
            btn_Acerca_De.TextAlign = ContentAlignment.MiddleLeft;
            btn_Acerca_De.UseVisualStyleBackColor = true;
            btn_Acerca_De.Click += btn_Acerca_De_Click;
            // 
            // btn_Salir
            // 
            btn_Salir.Cursor = Cursors.Hand;
            btn_Salir.FlatAppearance.BorderSize = 0;
            btn_Salir.FlatStyle = FlatStyle.Flat;
            btn_Salir.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Salir.Location = new Point(10, 555);
            btn_Salir.Margin = new Padding(3, 2, 3, 2);
            btn_Salir.Name = "btn_Salir";
            btn_Salir.Size = new Size(211, 42);
            btn_Salir.TabIndex = 23;
            btn_Salir.Text = "Salir";
            btn_Salir.TextAlign = ContentAlignment.MiddleLeft;
            btn_Salir.UseVisualStyleBackColor = true;
            btn_Salir.Click += btn_Salir_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = SistemaDeVentas.Properties.Resources.LogoImage;
            pictureBox1.Location = new Point(10, 44);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(81, 60);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(-11, 106);
            label1.Name = "label1";
            label1.Size = new Size(287, 25);
            label1.TabIndex = 23;
            label1.Text = "_________________________";
            // 
            // UserHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1234, 643);
            Controls.Add(panelChildForm);
            Controls.Add(panelMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "UserHome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User - InventoryForEveryone";
            panelChildForm.ResumeLayout(false);
            panelChildForm.PerformLayout();
            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelChildForm;
        private Label label10;
        private Label label6;
        private Label label4;
        private Label label2;
        private Label label3;
        private Panel panelMenu;
        private Label UserOrAdmin;
        private Label label5;
        private Button btn_Acerca_De;
        private Button btn_Salir;
        private PictureBox pictureBox1;
        private Label label1;
        private Button btn_Ventas;
        private Button btnCompras;
    }
}