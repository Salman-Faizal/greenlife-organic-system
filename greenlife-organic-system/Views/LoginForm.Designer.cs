namespace greenlife_organic_system.Views
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
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            btnLogin = new Button();
            btnRegister = new Button();
            lblTitle = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblMessage = new Label();
            btnExit = new Button();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(273, 165);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(216, 27);
            txtPassword.TabIndex = 1;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(273, 116);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(216, 27);
            txtUsername.TabIndex = 0;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(308, 248);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(105, 29);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(328, 383);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(128, 29);
            btnRegister.TabIndex = 3;
            btnRegister.Text = "Register Now";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(263, 40);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(167, 20);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "GreenLife Organic Store";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(173, 123);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 6;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(173, 168);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 7;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(240, 387);
            label4.Name = "label4";
            label4.Size = new Size(82, 20);
            label4.TabIndex = 9;
            label4.Text = "New Here?";
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(273, 208);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(0, 20);
            lblMessage.TabIndex = 8;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(308, 293);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(105, 29);
            btnExit.TabIndex = 4;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(724, 450);
            Controls.Add(btnExit);
            Controls.Add(lblMessage);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblTitle);
            Controls.Add(btnRegister);
            Controls.Add(btnLogin);
            Controls.Add(txtUsername);
            Controls.Add(txtPassword);
            Name = "LoginForm";
            Text = "Login Page";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPassword;
        private TextBox txtUsername;
        private Button btnLogin;
        private Button btnRegister;
        private Label lblTitle;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblMessage;
        private Button btnExit;
    }
}