namespace greenlife_organic_system.Views
{
    partial class ViewProfileForm
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
            lblTitle = new Label();
            lblFullName = new Label();
            lblEmail = new Label();
            lblPhone = new Label();
            lblAddress = new Label();
            lblUsername = new Label();
            lblPassword = new Label();
            lblConfirmPassword = new Label();
            txtFullName = new TextBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            txtAddress = new TextBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            btnUpdate = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(160, 59);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(102, 20);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Profile Details";
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Location = new Point(160, 145);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(72, 20);
            lblFullName.TabIndex = 1;
            lblFullName.Text = "FullName";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(160, 190);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(160, 241);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(50, 20);
            lblPhone.TabIndex = 3;
            lblPhone.Text = "Phone";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(160, 292);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(62, 20);
            lblAddress.TabIndex = 4;
            lblAddress.Text = "Address";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(157, 344);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(75, 20);
            lblUsername.TabIndex = 5;
            lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(160, 389);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 20);
            lblPassword.TabIndex = 6;
            lblPassword.Text = "Password";
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Location = new Point(157, 437);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(127, 20);
            lblConfirmPassword.TabIndex = 7;
            lblConfirmPassword.Text = "Confirm Password";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(338, 138);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(252, 27);
            txtFullName.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(338, 187);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(252, 27);
            txtEmail.TabIndex = 9;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(338, 238);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(252, 27);
            txtPhone.TabIndex = 10;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(338, 289);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(252, 27);
            txtAddress.TabIndex = 11;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(338, 341);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(252, 27);
            txtUsername.TabIndex = 12;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(338, 386);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(252, 27);
            txtPassword.TabIndex = 13;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(338, 437);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(252, 27);
            txtConfirmPassword.TabIndex = 14;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(384, 501);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(143, 29);
            btnUpdate.TabIndex = 15;
            btnUpdate.Text = "Update Profile";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(651, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(137, 29);
            btnBack.TabIndex = 16;
            btnBack.Text = "<-- Go Back";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // ViewProfileForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 642);
            Controls.Add(btnBack);
            Controls.Add(btnUpdate);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(txtAddress);
            Controls.Add(txtPhone);
            Controls.Add(txtEmail);
            Controls.Add(txtFullName);
            Controls.Add(lblConfirmPassword);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(lblAddress);
            Controls.Add(lblPhone);
            Controls.Add(lblEmail);
            Controls.Add(lblFullName);
            Controls.Add(lblTitle);
            Name = "ViewProfileForm";
            Text = "Profile";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblFullName;
        private Label lblEmail;
        private Label lblPhone;
        private Label lblAddress;
        private Label lblUsername;
        private Label lblPassword;
        private Label lblConfirmPassword;
        private TextBox txtFullName;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private TextBox txtAddress;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private TextBox txtConfirmPassword;
        private Button btnUpdate;
        private Button btnBack;
    }
}