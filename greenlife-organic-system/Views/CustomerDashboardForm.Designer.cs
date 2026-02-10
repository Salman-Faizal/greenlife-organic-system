namespace greenlife_organic_system.Views
{
    partial class CustomerDashboardForm
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
            lblWelcome = new Label();
            btnBrowse = new Button();
            btnOrders = new Button();
            btnProfile = new Button();
            btnLogout = new Button();
            btnViewCart = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(304, 21);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(149, 20);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Customer Dashboard";
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Location = new Point(103, 77);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(78, 20);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "Welcome, ";
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(21, 168);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(145, 29);
            btnBrowse.TabIndex = 2;
            btnBrowse.Text = "Browse Products";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // btnOrders
            // 
            btnOrders.Location = new Point(415, 168);
            btnOrders.Name = "btnOrders";
            btnOrders.Size = new Size(145, 29);
            btnOrders.TabIndex = 3;
            btnOrders.Text = "My Orders";
            btnOrders.UseVisualStyleBackColor = true;
            btnOrders.Click += btnOrders_Click;
            // 
            // btnProfile
            // 
            btnProfile.Location = new Point(615, 168);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(145, 29);
            btnProfile.TabIndex = 4;
            btnProfile.Text = "My Profile";
            btnProfile.UseVisualStyleBackColor = true;
            btnProfile.Click += btnProfile_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(328, 256);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(94, 29);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnViewCart
            // 
            btnViewCart.Location = new Point(224, 168);
            btnViewCart.Name = "btnViewCart";
            btnViewCart.Size = new Size(133, 29);
            btnViewCart.TabIndex = 6;
            btnViewCart.Text = "View Cart";
            btnViewCart.UseVisualStyleBackColor = true;
            btnViewCart.Click += btnViewCart_Click;
            // 
            // CustomerDashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnViewCart);
            Controls.Add(btnLogout);
            Controls.Add(btnProfile);
            Controls.Add(btnOrders);
            Controls.Add(btnBrowse);
            Controls.Add(lblWelcome);
            Controls.Add(lblTitle);
            Name = "CustomerDashboardForm";
            Text = "Dashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblWelcome;
        private Button btnBrowse;
        private Button btnOrders;
        private Button btnProfile;
        private Button btnLogout;
        private Button btnViewCart;
    }
}