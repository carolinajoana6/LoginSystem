namespace LoginSystem
{
    partial class RegisterForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtUsername = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            txtConfirm = new TextBox();
            cmbRole = new ComboBox();
            btnRegister = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 36);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 0;
            label1.Text = "Usuário:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 79);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 122);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 2;
            label3.Text = "Senha:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 160);
            label4.Name = "label4";
            label4.Size = new Size(79, 15);
            label4.TabIndex = 3;
            label4.Text = "Confirmação:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(114, 33);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(214, 23);
            txtUsername.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(114, 79);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(214, 23);
            txtEmail.TabIndex = 5;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(114, 122);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(214, 23);
            txtPassword.TabIndex = 6;
            // 
            // txtConfirm
            // 
            txtConfirm.Location = new Point(114, 160);
            txtConfirm.Name = "txtConfirm";
            txtConfirm.Size = new Size(214, 23);
            txtConfirm.TabIndex = 7;
            // 
            // cmbRole
            // 
            cmbRole.FormattingEnabled = true;
            cmbRole.Location = new Point(374, 36);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(121, 23);
            cmbRole.TabIndex = 8;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(117, 210);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(98, 23);
            btnRegister.TabIndex = 9;
            btnRegister.Text = "Registrar";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += BtnRegister_Click;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(586, 302);
            Controls.Add(btnRegister);
            Controls.Add(cmbRole);
            Controls.Add(txtConfirm);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtUsername);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RegisterForm";
            Text = "RegisterForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtUsername;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox txtConfirm;
        private ComboBox cmbRole;
        private Button btnRegister;
    }
}