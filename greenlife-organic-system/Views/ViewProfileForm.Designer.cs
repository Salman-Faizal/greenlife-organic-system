namespace greenlife_organic_system.Views
{
    partial class btnBack
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
            txtFullName = new TextBox();
            txtAddress = new TextBox();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtConfirmPassword = new TextBox();
            label7 = new Label();
            btnUpdate = new Button();
            label8 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(338, 100);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(248, 27);
            txtFullName.TabIndex = 0;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(338, 269);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(248, 27);
            txtAddress.TabIndex = 1;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(338, 213);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(248, 27);
            txtPhone.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(338, 155);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(248, 27);
            txtEmail.TabIndex = 3;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(338, 328);
            txtUsername.Name = "txtUsername";
            txtUsername.ReadOnly = true;
            txtUsername.Size = new Size(248, 27);
            txtUsername.TabIndex = 4;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(338, 385);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(248, 27);
            txtPassword.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(170, 103);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 6;
            label1.Text = "Full Name";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(170, 158);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 7;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(170, 272);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 8;
            label3.Text = "Address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(170, 220);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 9;
            label4.Text = "Phone";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(170, 331);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 10;
            label5.Text = "Username";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(170, 388);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 11;
            label6.Text = "Password";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(338, 440);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.Size = new Size(248, 27);
            txtConfirmPassword.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(170, 443);
            label7.Name = "label7";
            label7.Size = new Size(127, 20);
            label7.TabIndex = 13;
            label7.Text = "Confirm Password";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(393, 507);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(120, 29);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "Update Profile";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(170, 33);
            label8.Name = "label8";
            label8.Size = new Size(52, 20);
            label8.TabIndex = 15;
            label8.Text = "Profile";
            // 
            // button1
            // 
            button1.Location = new Point(668, 12);
            button1.Name = "button1";
            button1.Size = new Size(120, 29);
            button1.TabIndex = 16;
            button1.Text = "<-- Go Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnBack_Click;
            // 
            // btnBack
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 595);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(btnUpdate);
            Controls.Add(label7);
            Controls.Add(txtConfirmPassword);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(txtEmail);
            Controls.Add(txtPhone);
            Controls.Add(txtAddress);
            Controls.Add(txtFullName);
            Name = "btnBack";
            Text = "ViewProfileForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFullName;
        private TextBox txtAddress;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtConfirmPassword;
        private Label label7;
        private Button btnUpdate;
        private Label label8;
        private Button button1;
    }
}