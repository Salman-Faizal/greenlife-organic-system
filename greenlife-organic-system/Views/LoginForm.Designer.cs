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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            btnLogin = new Button();
            btnRegister = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblMessage = new Label();
            btnExit = new Button();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(272, 218);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(216, 27);
            txtPassword.TabIndex = 1;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(272, 169);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(216, 27);
            txtUsername.TabIndex = 0;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(27, 94, 32);
            btnLogin.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(272, 284);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(136, 35);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(200, 230, 201);
            btnRegister.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = Color.CornflowerBlue;
            btnRegister.Location = new Point(311, 432);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(161, 33);
            btnRegister.TabIndex = 3;
            btnRegister.Text = "Register Now";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label2.ForeColor = Color.CornflowerBlue;
            label2.Location = new Point(159, 173);
            label2.Name = "label2";
            label2.Size = new Size(89, 23);
            label2.TabIndex = 6;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label3.ForeColor = Color.CornflowerBlue;
            label3.Location = new Point(159, 219);
            label3.Name = "label3";
            label3.Size = new Size(85, 23);
            label3.TabIndex = 7;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.CornflowerBlue;
            label4.Location = new Point(214, 438);
            label4.Name = "label4";
            label4.Size = new Size(91, 20);
            label4.TabIndex = 9;
            label4.Text = "New Here?";
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMessage.ForeColor = Color.Coral;
            lblMessage.Location = new Point(272, 261);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(0, 20);
            lblMessage.TabIndex = 8;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(27, 94, 32);
            btnExit.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(272, 325);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(136, 36);
            btnExit.TabIndex = 4;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(272, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(146, 123);
            panel1.TabIndex = 10;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(724, 489);
            Controls.Add(panel1);
            Controls.Add(btnExit);
            Controls.Add(lblMessage);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnRegister);
            Controls.Add(btnLogin);
            Controls.Add(txtUsername);
            Controls.Add(txtPassword);
            Name = "LoginForm";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPassword;
        private TextBox txtUsername;
        private Button btnLogin;
        private Button btnRegister;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblMessage;
        private Button btnExit;
        private Panel panel1;
    }
}