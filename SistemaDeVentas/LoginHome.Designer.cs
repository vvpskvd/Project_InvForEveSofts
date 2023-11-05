namespace Login
{
    partial class LoginHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginHome));
            labelUsuario = new Label();
            labelPassword = new Label();
            txtUsuario = new TextBox();
            txtPass = new TextBox();
            label3 = new Label();
            logo = new PictureBox();
            labelTextoLogin1 = new Label();
            labelTextoLogin2 = new Label();
            labelTextoLogin3 = new Label();
            labelTextoLogin4 = new Label();
            btnIngresar = new FontAwesome.Sharp.IconButton();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            btnVerPassword = new PictureBox();
            btnOcultarPassword = new PictureBox();
            forgetPass = new Button();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnVerPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnOcultarPassword).BeginInit();
            SuspendLayout();
            // 
            // labelUsuario
            // 
            labelUsuario.AutoSize = true;
            labelUsuario.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelUsuario.Location = new Point(381, 56);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(83, 28);
            labelUsuario.TabIndex = 0;
            labelUsuario.Text = "Usuario:";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelPassword.Location = new Point(381, 155);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(114, 28);
            labelPassword.TabIndex = 1;
            labelPassword.Text = "Contraseña:";
            // 
            // txtUsuario
            // 
            txtUsuario.Cursor = Cursors.IBeam;
            txtUsuario.Location = new Point(381, 87);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(281, 23);
            txtUsuario.TabIndex = 2;
            // 
            // txtPass
            // 
            txtPass.Cursor = Cursors.IBeam;
            txtPass.Location = new Point(381, 186);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(281, 23);
            txtPass.TabIndex = 3;
            txtPass.KeyDown += txtPass_KeyDown;
            // 
            // label3
            // 
            label3.BackColor = Color.Gray;
            label3.Dock = DockStyle.Left;
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(345, 347);
            label3.TabIndex = 6;
            // 
            // logo
            // 
            logo.BackColor = Color.Gray;
            logo.Image = SistemaDeVentas.Properties.Resources.LogoImage;
            logo.Location = new Point(90, 12);
            logo.Name = "logo";
            logo.Size = new Size(174, 156);
            logo.SizeMode = PictureBoxSizeMode.StretchImage;
            logo.TabIndex = 7;
            logo.TabStop = false;
            // 
            // labelTextoLogin1
            // 
            labelTextoLogin1.AutoSize = true;
            labelTextoLogin1.BackColor = Color.Gray;
            labelTextoLogin1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            labelTextoLogin1.Location = new Point(33, 171);
            labelTextoLogin1.Name = "labelTextoLogin1";
            labelTextoLogin1.Size = new Size(149, 37);
            labelTextoLogin1.TabIndex = 8;
            labelTextoLogin1.Text = "Bienvenido";
            labelTextoLogin1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelTextoLogin2
            // 
            labelTextoLogin2.AutoSize = true;
            labelTextoLogin2.BackColor = Color.Gray;
            labelTextoLogin2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            labelTextoLogin2.Location = new Point(33, 208);
            labelTextoLogin2.Name = "labelTextoLogin2";
            labelTextoLogin2.Size = new Size(41, 37);
            labelTextoLogin2.TabIndex = 9;
            labelTextoLogin2.Text = "Al";
            labelTextoLogin2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelTextoLogin3
            // 
            labelTextoLogin3.AutoSize = true;
            labelTextoLogin3.BackColor = Color.Gray;
            labelTextoLogin3.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            labelTextoLogin3.Location = new Point(33, 247);
            labelTextoLogin3.Name = "labelTextoLogin3";
            labelTextoLogin3.Size = new Size(231, 37);
            labelTextoLogin3.TabIndex = 10;
            labelTextoLogin3.Text = "Sistema de Ventas";
            labelTextoLogin3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelTextoLogin4
            // 
            labelTextoLogin4.BackColor = Color.Gray;
            labelTextoLogin4.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            labelTextoLogin4.Location = new Point(33, 282);
            labelTextoLogin4.Name = "labelTextoLogin4";
            labelTextoLogin4.Size = new Size(286, 46);
            labelTextoLogin4.TabIndex = 11;
            labelTextoLogin4.Text = "InventoryForEveryone";
            labelTextoLogin4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnIngresar
            // 
            btnIngresar.Cursor = Cursors.Hand;
            btnIngresar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnIngresar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnIngresar.IconColor = Color.Black;
            btnIngresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnIngresar.Location = new Point(422, 254);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(90, 33);
            btnIngresar.TabIndex = 12;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnCancelar.IconColor = Color.Black;
            btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelar.Location = new Point(534, 254);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(90, 33);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "Salir";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnVerPassword
            // 
            btnVerPassword.Cursor = Cursors.Hand;
            btnVerPassword.Image = SistemaDeVentas.Properties.Resources.ojocontraseña;
            btnVerPassword.Location = new Point(668, 186);
            btnVerPassword.Name = "btnVerPassword";
            btnVerPassword.Size = new Size(24, 23);
            btnVerPassword.SizeMode = PictureBoxSizeMode.StretchImage;
            btnVerPassword.TabIndex = 14;
            btnVerPassword.TabStop = false;
            btnVerPassword.Click += btnVerPassword_Click;
            // 
            // btnOcultarPassword
            // 
            btnOcultarPassword.Cursor = Cursors.Hand;
            btnOcultarPassword.Image = SistemaDeVentas.Properties.Resources.ojonocontraseña;
            btnOcultarPassword.Location = new Point(668, 186);
            btnOcultarPassword.Name = "btnOcultarPassword";
            btnOcultarPassword.Size = new Size(24, 23);
            btnOcultarPassword.SizeMode = PictureBoxSizeMode.StretchImage;
            btnOcultarPassword.TabIndex = 15;
            btnOcultarPassword.TabStop = false;
            btnOcultarPassword.Click += btnOcultarPassword_Click;
            // 
            // forgetPass
            // 
            forgetPass.Cursor = Cursors.Hand;
            forgetPass.Location = new Point(455, 310);
            forgetPass.Name = "forgetPass";
            forgetPass.Size = new Size(154, 25);
            forgetPass.TabIndex = 16;
            forgetPass.Text = "¿Olvidaste la contraseña?";
            forgetPass.UseVisualStyleBackColor = true;
            forgetPass.Click += forgetPass_Click;
            // 
            // LoginHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(722, 347);
            Controls.Add(forgetPass);
            Controls.Add(btnVerPassword);
            Controls.Add(btnOcultarPassword);
            Controls.Add(btnCancelar);
            Controls.Add(btnIngresar);
            Controls.Add(labelTextoLogin4);
            Controls.Add(labelTextoLogin3);
            Controls.Add(labelTextoLogin2);
            Controls.Add(labelTextoLogin1);
            Controls.Add(logo);
            Controls.Add(label3);
            Controls.Add(txtPass);
            Controls.Add(txtUsuario);
            Controls.Add(labelPassword);
            Controls.Add(labelUsuario);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "LoginHome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login - InventoryForEveryone";
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnVerPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnOcultarPassword).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelUsuario;
        private Label labelPassword;
        private TextBox txtUsuario;
        private TextBox txtPass;
        private Label label3;
        private PictureBox logo;
        private Label labelTextoLogin1;
        private Label labelTextoLogin2;
        private Label labelTextoLogin3;
        private Label labelTextoLogin4;
        private FontAwesome.Sharp.IconButton btnIngresar;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private PictureBox btnVerPassword;
        private PictureBox btnOcultarPassword;
        private Button forgetPass;
    }
}