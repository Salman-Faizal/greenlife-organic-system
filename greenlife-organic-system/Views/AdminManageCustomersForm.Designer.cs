namespace greenlife_organic_system.Views
{
    partial class AdminManageCustomersForm
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
            components = new System.ComponentModel.Container();
            dgvCustomers = new DataGridView();
            grpCustomerDetails = new GroupBox();
            btnEditCustomer = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtAddress = new TextBox();
            txtFullName = new TextBox();
            txtEmail = new TextBox();
            txtPhoneNumber = new TextBox();
            txtUsername = new TextBox();
            label6 = new Label();
            btnBack = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            grpCustomerDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // dgvCustomers
            // 
            dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomers.Location = new Point(12, 75);
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.RowHeadersWidth = 51;
            dgvCustomers.Size = new Size(496, 628);
            dgvCustomers.TabIndex = 0;
            dgvCustomers.SelectionChanged += dgvCustomers_SelectionChanged;
            // 
            // grpCustomerDetails
            // 
            grpCustomerDetails.Controls.Add(btnEditCustomer);
            grpCustomerDetails.Controls.Add(label5);
            grpCustomerDetails.Controls.Add(label4);
            grpCustomerDetails.Controls.Add(label3);
            grpCustomerDetails.Controls.Add(label2);
            grpCustomerDetails.Controls.Add(label1);
            grpCustomerDetails.Controls.Add(txtAddress);
            grpCustomerDetails.Controls.Add(txtFullName);
            grpCustomerDetails.Controls.Add(txtEmail);
            grpCustomerDetails.Controls.Add(txtPhoneNumber);
            grpCustomerDetails.Controls.Add(txtUsername);
            grpCustomerDetails.Location = new Point(660, 118);
            grpCustomerDetails.Name = "grpCustomerDetails";
            grpCustomerDetails.Size = new Size(372, 473);
            grpCustomerDetails.TabIndex = 1;
            grpCustomerDetails.TabStop = false;
            grpCustomerDetails.Text = "Customer Details";
            // 
            // btnEditCustomer
            // 
            btnEditCustomer.Location = new Point(87, 413);
            btnEditCustomer.Name = "btnEditCustomer";
            btnEditCustomer.Size = new Size(209, 29);
            btnEditCustomer.TabIndex = 10;
            btnEditCustomer.Text = "Update Customer Details";
            btnEditCustomer.UseVisualStyleBackColor = true;
            btnEditCustomer.Click += btnEditCustomer_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 122);
            label5.Name = "label5";
            label5.Size = new Size(76, 20);
            label5.TabIndex = 9;
            label5.Text = "Full Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 186);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 8;
            label4.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 257);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 7;
            label3.Text = "Phone";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 329);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 6;
            label2.Text = "Address";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 67);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 5;
            label1.Text = "Username";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(145, 326);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(209, 27);
            txtAddress.TabIndex = 4;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(145, 119);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(209, 27);
            txtFullName.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(145, 183);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(209, 27);
            txtEmail.TabIndex = 2;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(145, 254);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(209, 27);
            txtPhoneNumber.TabIndex = 1;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(145, 60);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(209, 27);
            txtUsername.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 39);
            label6.Name = "label6";
            label6.Size = new Size(98, 20);
            label6.TabIndex = 2;
            label6.Text = "Customer List";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(896, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(136, 29);
            btnBack.TabIndex = 3;
            btnBack.Text = "<-- Go Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnCancel_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // AdminManageCustomersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1095, 727);
            Controls.Add(btnBack);
            Controls.Add(label6);
            Controls.Add(dgvCustomers);
            Controls.Add(grpCustomerDetails);
            Name = "AdminManageCustomersForm";
            Text = "Manage Customers";
            Load += AdminManageCustomersForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            grpCustomerDetails.ResumeLayout(false);
            grpCustomerDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCustomers;
        private GroupBox grpCustomerDetails;
        private TextBox txtAddress;
        private TextBox txtFullName;
        private TextBox txtEmail;
        private TextBox txtPhoneNumber;
        private TextBox txtUsername;
        private Button btnEditCustomer;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
        private Button btnBack;
        private ErrorProvider errorProvider1;
    }
}