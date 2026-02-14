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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerDashboardForm));
            lblTitle = new Label();
            lblWelcome = new Label();
            btnBrowse = new Button();
            btnOrders = new Button();
            btnProfile = new Button();
            btnLogout = new Button();
            btnViewCart = new Button();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = SystemColors.Control;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(27, 94, 32);
            lblTitle.Location = new Point(12, 19);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(210, 28);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Customer Dashboard";
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.CornflowerBlue;
            lblWelcome.Location = new Point(12, 97);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(88, 20);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "Welcome, ";
            // 
            // btnBrowse
            // 
            btnBrowse.BackColor = Color.CornflowerBlue;
            btnBrowse.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnBrowse.ForeColor = Color.White;
            btnBrowse.Location = new Point(12, 150);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(168, 37);
            btnBrowse.TabIndex = 0;
            btnBrowse.Text = "Browse Products";
            btnBrowse.UseVisualStyleBackColor = false;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // btnOrders
            // 
            btnOrders.BackColor = Color.CornflowerBlue;
            btnOrders.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnOrders.ForeColor = Color.White;
            btnOrders.Location = new Point(12, 236);
            btnOrders.Name = "btnOrders";
            btnOrders.Size = new Size(168, 37);
            btnOrders.TabIndex = 2;
            btnOrders.Text = "My Orders";
            btnOrders.UseVisualStyleBackColor = false;
            btnOrders.Click += btnOrders_Click;
            // 
            // btnProfile
            // 
            btnProfile.BackColor = Color.CornflowerBlue;
            btnProfile.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnProfile.ForeColor = Color.White;
            btnProfile.Location = new Point(12, 279);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(168, 37);
            btnProfile.TabIndex = 3;
            btnProfile.Text = "My Profile";
            btnProfile.UseVisualStyleBackColor = false;
            btnProfile.Click += btnProfile_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(27, 94, 32);
            btnLogout.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(12, 347);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(168, 41);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnViewCart
            // 
            btnViewCart.BackColor = Color.CornflowerBlue;
            btnViewCart.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnViewCart.ForeColor = Color.White;
            btnViewCart.Location = new Point(12, 193);
            btnViewCart.Name = "btnViewCart";
            btnViewCart.Size = new Size(168, 37);
            btnViewCart.TabIndex = 1;
            btnViewCart.Text = "View Cart";
            btnViewCart.UseVisualStyleBackColor = false;
            btnViewCart.Click += btnViewCart_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.Location = new Point(465, -6);
            panel1.Name = "panel1";
            panel1.Size = new Size(247, 455);
            panel1.TabIndex = 7;
            // 
            // CustomerDashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(701, 442);
            Controls.Add(panel1);
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
        private Panel panel1;
    }
}