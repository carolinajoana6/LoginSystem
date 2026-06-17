namespace LoginSystem
{
    partial class LoginForm
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
            lnkRegister = new LinkLabel();
            lblUsuário = new Label();
            this.lblPassword = new Label();
            btnLogin = new Button();
            this.txtUserName = new TextBox();
            txtPassword = new TextBox();
            SuspendLayout();
            // 
            // lnkRegister
            // 
            lnkRegister.AutoSize = true;
            lnkRegister.Location = new Point(34, 200);
            lnkRegister.Name = "lnkRegister";
            lnkRegister.Size = new Size(50, 15);
            lnkRegister.TabIndex = 0;
            lnkRegister.TabStop = true;
            lnkRegister.Text = "Registro";
            // 
            // lblUsuário
            // 
            lblUsuário.AutoSize = true;
            lblUsuário.Location = new Point(34, 57);
            lblUsuário.Name = "lblUsuário";
            lblUsuário.Size = new Size(47, 15);
            lblUsuário.TabIndex = 1;
            lblUsuário.Text = "Usuário";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new Point(34, 136);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new Size(39, 15);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Senha";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(133, 196);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(114, 23);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new Point(120, 54);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new Size(157, 23);
            this.txtUserName.TabIndex = 5;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(120, 128);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(157, 23);
            txtPassword.TabIndex = 6;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 265);
            Controls.Add(txtPassword);
            Controls.Add(this.txtUserName);
            Controls.Add(btnLogin);
            Controls.Add(this.lblPassword);
            Controls.Add(lblUsuário);
            Controls.Add(lnkRegister);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel lnkRegister;
        private Label lblUsuário;

        public Label lblPassword { get; private set; }

        private Label label2;
        private Button btnLogin;
        private TextBox txtUserName;
        private Button button2;
        private TextBox textBox1;
        private TextBox txtPassword;
    }
}