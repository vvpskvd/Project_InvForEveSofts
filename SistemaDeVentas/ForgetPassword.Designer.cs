namespace Login
{
    partial class ForgetPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgetPassword));
            labelForgetPassword2 = new Label();
            label1 = new Label();
            labelForgetPassword1 = new Label();
            labelForgetPassword3 = new Label();
            labelForgetPassword4 = new Label();
            labelForgetPassword5 = new Label();
            SuspendLayout();
            // 
            // labelForgetPassword2
            // 
            labelForgetPassword2.AutoSize = true;
            labelForgetPassword2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelForgetPassword2.Location = new Point(8, 69);
            labelForgetPassword2.Name = "labelForgetPassword2";
            labelForgetPassword2.Size = new Size(356, 21);
            labelForgetPassword2.TabIndex = 0;
            labelForgetPassword2.Text = "Contactar al administrador del sitio via WhatsApp:";
            // 
            // label1
            // 
            label1.BackColor = Color.Gray;
            label1.Dock = DockStyle.Top;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(587, 51);
            label1.TabIndex = 2;
            // 
            // labelForgetPassword1
            // 
            labelForgetPassword1.AutoSize = true;
            labelForgetPassword1.BackColor = Color.Gray;
            labelForgetPassword1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            labelForgetPassword1.Location = new Point(12, 9);
            labelForgetPassword1.Name = "labelForgetPassword1";
            labelForgetPassword1.Size = new Size(227, 30);
            labelForgetPassword1.TabIndex = 3;
            labelForgetPassword1.Text = "InventoryForEveryone";
            // 
            // labelForgetPassword3
            // 
            labelForgetPassword3.AutoSize = true;
            labelForgetPassword3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelForgetPassword3.Location = new Point(8, 108);
            labelForgetPassword3.Name = "labelForgetPassword3";
            labelForgetPassword3.Size = new Size(325, 21);
            labelForgetPassword3.TabIndex = 4;
            labelForgetPassword3.Text = "Contactar al administrador del sitio via Gmail:";
            // 
            // labelForgetPassword4
            // 
            labelForgetPassword4.AutoSize = true;
            labelForgetPassword4.Cursor = Cursors.IBeam;
            labelForgetPassword4.Font = new Font("Segoe UI", 12F, FontStyle.Underline, GraphicsUnit.Point);
            labelForgetPassword4.ForeColor = Color.Blue;
            labelForgetPassword4.Location = new Point(370, 69);
            labelForgetPassword4.Name = "labelForgetPassword4";
            labelForgetPassword4.Size = new Size(137, 21);
            labelForgetPassword4.TabIndex = 5;
            labelForgetPassword4.Text = "+57 324 4671947";
            // 
            // labelForgetPassword5
            // 
            labelForgetPassword5.AutoSize = true;
            labelForgetPassword5.Cursor = Cursors.IBeam;
            labelForgetPassword5.Font = new Font("Segoe UI", 12F, FontStyle.Underline, GraphicsUnit.Point);
            labelForgetPassword5.ForeColor = Color.Blue;
            labelForgetPassword5.Location = new Point(339, 108);
            labelForgetPassword5.Name = "labelForgetPassword5";
            labelForgetPassword5.Size = new Size(214, 21);
            labelForgetPassword5.TabIndex = 6;
            labelForgetPassword5.Text = "vvpskvdbussines@gmail.com";
            // 
            // ForgetPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(587, 171);
            Controls.Add(labelForgetPassword5);
            Controls.Add(labelForgetPassword4);
            Controls.Add(labelForgetPassword3);
            Controls.Add(labelForgetPassword1);
            Controls.Add(label1);
            Controls.Add(labelForgetPassword2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "ForgetPassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "¿Olvidaste la Contraseña?";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelForgetPassword2;
        private Label label1;
        private Label labelForgetPassword1;
        private Label labelForgetPassword3;
        private Label labelForgetPassword4;
        private Label labelForgetPassword5;
    }
}