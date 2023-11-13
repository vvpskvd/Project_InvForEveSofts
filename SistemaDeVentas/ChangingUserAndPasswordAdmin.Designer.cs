namespace SistemaDeVentas
{
    partial class ChangingUserAndPasswordAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangingUserAndPasswordAdmin));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtboxUsuario = new TextBox();
            txtboxPassword = new TextBox();
            btnGuardarDatos = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Gray;
            label1.Dock = DockStyle.Top;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(597, 50);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Gray;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(204, 28);
            label2.TabIndex = 1;
            label2.Text = "InventoryForEveryone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(41, 114);
            label3.Name = "label3";
            label3.Size = new Size(175, 28);
            label3.TabIndex = 2;
            label3.Text = "Nueva Contraseña:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(57, 67);
            label4.Name = "label4";
            label4.Size = new Size(146, 28);
            label4.TabIndex = 3;
            label4.Text = "Nuevo Usuario:";
            // 
            // txtboxUsuario
            // 
            txtboxUsuario.Cursor = Cursors.IBeam;
            txtboxUsuario.Location = new Point(225, 72);
            txtboxUsuario.Name = "txtboxUsuario";
            txtboxUsuario.Size = new Size(150, 23);
            txtboxUsuario.TabIndex = 4;
            // 
            // txtboxPassword
            // 
            txtboxPassword.Cursor = Cursors.IBeam;
            txtboxPassword.Location = new Point(225, 119);
            txtboxPassword.Name = "txtboxPassword";
            txtboxPassword.Size = new Size(150, 23);
            txtboxPassword.TabIndex = 5;
            // 
            // btnGuardarDatos
            // 
            btnGuardarDatos.Cursor = Cursors.Hand;
            btnGuardarDatos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuardarDatos.Location = new Point(423, 92);
            btnGuardarDatos.Name = "btnGuardarDatos";
            btnGuardarDatos.Size = new Size(129, 30);
            btnGuardarDatos.TabIndex = 6;
            btnGuardarDatos.Text = "Guardar Datos";
            btnGuardarDatos.UseVisualStyleBackColor = true;
            btnGuardarDatos.Click += btnGuardarDatos_Click;
            // 
            // ChangingUserAndPasswordAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(597, 173);
            Controls.Add(btnGuardarDatos);
            Controls.Add(txtboxPassword);
            Controls.Add(txtboxUsuario);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "ChangingUserAndPasswordAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cambio de Usuario y/o Contraseña - InventoryForEveryone";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtboxUsuario;
        private TextBox txtboxPassword;
        private Button btnGuardarDatos;
    }
}