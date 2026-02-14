namespace greenlife_organic_system.Views
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
            txtUsername = new TextBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            txtFullName = new TextBox();
            txtPassword = new TextBox();
            txtAddress = new TextBox();
            btnRegister = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            lblMessage = new Label();
            btnBack = new Button();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(273, 183);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(301, 27);
            txtUsername.TabIndex = 0;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(273, 354);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(301, 27);
            txtEmail.TabIndex = 3;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(273, 416);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(301, 27);
            txtPhone.TabIndex = 4;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(273, 292);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(301, 27);
            txtFullName.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(273, 238);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(301, 27);
            txtPassword.TabIndex = 1;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(273, 480);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(301, 27);
            txtAddress.TabIndex = 5;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(27, 94, 32);
            btnRegister.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(318, 560);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(168, 42);
            btnRegister.TabIndex = 6;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(27, 94, 32);
            label1.Location = new Point(181, 70);
            label1.Name = "label1";
            label1.Size = new Size(333, 25);
            label1.TabIndex = 15;
            label1.Text = "Register with GreenLife Organic Store";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.ForeColor = Color.CornflowerBlue;
            label2.Location = new Point(120, 186);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 9;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label3.ForeColor = Color.CornflowerBlue;
            label3.Location = new Point(120, 241);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 10;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label4.ForeColor = Color.CornflowerBlue;
            label4.Location = new Point(120, 299);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 11;
            label4.Text = "Full Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label5.ForeColor = Color.CornflowerBlue;
            label5.Location = new Point(120, 361);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 12;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label6.ForeColor = Color.CornflowerBlue;
            label6.Location = new Point(120, 423);
            label6.Name = "label6";
            label6.Size = new Size(53, 20);
            label6.TabIndex = 13;
            label6.Text = "Phone";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label7.ForeColor = Color.CornflowerBlue;
            label7.Location = new Point(120, 487);
            label7.Name = "label7";
            label7.Size = new Size(63, 20);
            label7.TabIndex = 14;
            label7.Text = "Address";
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMessage.ForeColor = Color.Coral;
            lblMessage.Location = new Point(273, 527);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(0, 20);
            lblMessage.TabIndex = 8;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.CornflowerBlue;
            btnBack.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(318, 608);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(168, 42);
            btnBack.TabIndex = 7;
            btnBack.Text = "Login";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(731, 697);
            Controls.Add(btnBack);
            Controls.Add(lblMessage);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnRegister);
            Controls.Add(txtAddress);
            Controls.Add(txtPassword);
            Controls.Add(txtFullName);
            Controls.Add(txtPhone);
            Controls.Add(txtEmail);
            Controls.Add(txtUsername);
            ForeColor = Color.Coral;
            Name = "RegisterForm";
            Text = "Register New Customer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsername;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private TextBox txtFullName;
        private TextBox txtPassword;
        private TextBox txtAddress;
        private Button btnRegister;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label lblMessage;
        private Button btnBack;
    }
}