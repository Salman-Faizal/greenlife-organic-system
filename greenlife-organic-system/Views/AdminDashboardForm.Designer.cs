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
            lblLowStock = new Label();
            btnProducts = new Button();
            btnOrders = new Button();
            btnReports = new Button();
            btnLogout = new Button();
            btnCustomers = new Button();
            lblTotSales = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblProducts = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(23, 28);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(157, 20);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Welcome back, Admin";
            // 
            // lblOrders
            // 
            lblOrders.AutoSize = true;
            lblOrders.Location = new Point(156, 120);
            lblOrders.Name = "lblOrders";
            lblOrders.Size = new Size(0, 20);
            lblOrders.TabIndex = 1;
            // 
            // lblLowStock
            // 
            lblLowStock.AutoSize = true;
            lblLowStock.Location = new Point(156, 156);
            lblLowStock.Name = "lblLowStock";
            lblLowStock.Size = new Size(0, 20);
            lblLowStock.TabIndex = 3;
            // 
            // btnProducts
            // 
            btnProducts.Location = new Point(23, 281);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(197, 29);
            btnProducts.TabIndex = 4;
            btnProducts.Text = "Manage Products";
            btnProducts.UseVisualStyleBackColor = true;
            btnProducts.Click += btnManageProducts_Click;
            // 
            // btnOrders
            // 
            btnOrders.Location = new Point(23, 325);
            btnOrders.Name = "btnOrders";
            btnOrders.Size = new Size(197, 29);
            btnOrders.TabIndex = 5;
            btnOrders.Text = "Manage Orders";
            btnOrders.UseVisualStyleBackColor = true;
            btnOrders.Click += btnOrders_Click;
            // 
            // btnReports
            // 
            btnReports.Location = new Point(23, 414);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(197, 29);
            btnReports.TabIndex = 6;
            btnReports.Text = "Generate Reports";
            btnReports.UseVisualStyleBackColor = true;
            btnReports.Click += btnReports_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(23, 486);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(197, 29);
            btnLogout.TabIndex = 7;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnCustomers
            // 
            btnCustomers.Location = new Point(23, 368);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Size = new Size(197, 29);
            btnCustomers.TabIndex = 8;
            btnCustomers.Text = "Manage Customers";
            btnCustomers.UseVisualStyleBackColor = true;
            btnCustomers.Click += btnCustomers_Click;
            // 
            // lblTotSales
            // 
            lblTotSales.AutoSize = true;
            lblTotSales.Location = new Point(156, 86);
            lblTotSales.Name = "lblTotSales";
            lblTotSales.Size = new Size(0, 20);
            lblTotSales.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 86);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 10;
            label1.Text = "Total Sales: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 120);
            label2.Name = "label2";
            label2.Size = new Size(105, 20);
            label2.TabIndex = 11;
            label2.Text = "Active Orders: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 156);
            label3.Name = "label3";
            label3.Size = new Size(123, 20);
            label3.TabIndex = 12;
            label3.Text = "Low Stock Items: ";
            // 
            // lblProducts
            // 
            lblProducts.AutoSize = true;
            lblProducts.Location = new Point(156, 191);
            lblProducts.Name = "lblProducts";
            lblProducts.Size = new Size(0, 20);
            lblProducts.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 191);
            label4.Name = "label4";
            label4.Size = new Size(110, 20);
            label4.TabIndex = 13;
            label4.Text = "Total Products: ";
            // 
            // AdminDashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(874, 536);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblTotSales);
            Controls.Add(btnCustomers);
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
            Load += AdminDashboardForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblOrders;
        private Label lblLowStock;
        private Button btnProducts;
        private Button btnOrders;
        private Button btnReports;
        private Button btnLogout;
        private Button btnCustomers;
        private Label lblTotSales;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblProducts;
        private Label label4;
    }
}