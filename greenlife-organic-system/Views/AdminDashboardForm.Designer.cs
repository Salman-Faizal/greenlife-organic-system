namespace greenlife_organic_system.Views
{
    partial class AdminDashboardForm
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
            lblOrders = new Label();
            lblProducts = new Label();
            lblLowStock = new Label();
            btnProducts = new Button();
            btnOrders = new Button();
            btnReports = new Button();
            btnLogout = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(326, 31);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(122, 20);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Welcome, Admin";
            // 
            // lblOrders
            // 
            lblOrders.AutoSize = true;
            lblOrders.Location = new Point(274, 148);
            lblOrders.Name = "lblOrders";
            lblOrders.Size = new Size(105, 20);
            lblOrders.TabIndex = 1;
            lblOrders.Text = "Active Orders: ";
            // 
            // lblProducts
            // 
            lblProducts.AutoSize = true;
            lblProducts.Location = new Point(274, 100);
            lblProducts.Name = "lblProducts";
            lblProducts.Size = new Size(110, 20);
            lblProducts.TabIndex = 2;
            lblProducts.Text = "Total Products: ";
            lblProducts.Click += lblProducts_Click;
            // 
            // lblLowStock
            // 
            lblLowStock.AutoSize = true;
            lblLowStock.Location = new Point(274, 203);
            lblLowStock.Name = "lblLowStock";
            lblLowStock.Size = new Size(123, 20);
            lblLowStock.TabIndex = 3;
            lblLowStock.Text = "Low Stock Items: ";
            // 
            // btnProducts
            // 
            btnProducts.Location = new Point(131, 288);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(149, 29);
            btnProducts.TabIndex = 4;
            btnProducts.Text = "Manage Products";
            btnProducts.UseVisualStyleBackColor = true;
            btnProducts.Click += btnProducts_Click_1;
            // 
            // btnOrders
            // 
            btnOrders.Location = new Point(316, 288);
            btnOrders.Name = "btnOrders";
            btnOrders.Size = new Size(153, 29);
            btnOrders.TabIndex = 5;
            btnOrders.Text = "Manage Orders";
            btnOrders.UseVisualStyleBackColor = true;
            btnOrders.Click += btnOrders_Click_1;
            // 
            // btnReports
            // 
            btnReports.Location = new Point(508, 288);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(144, 29);
            btnReports.TabIndex = 6;
            btnReports.Text = "Generate Reports";
            btnReports.UseVisualStyleBackColor = true;
            btnReports.Click += btnReports_Click_1;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(340, 363);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(94, 29);
            btnLogout.TabIndex = 7;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click_1;
            // 
            // AdminDashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogout);
            Controls.Add(btnReports);
            Controls.Add(btnOrders);
            Controls.Add(btnProducts);
            Controls.Add(lblLowStock);
            Controls.Add(lblProducts);
            Controls.Add(lblOrders);
            Controls.Add(lblTitle);
            Name = "AdminDashboardForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblOrders;
        private Label lblProducts;
        private Label lblLowStock;
        private Button btnProducts;
        private Button btnOrders;
        private Button btnReports;
        private Button btnLogout;
    }
}