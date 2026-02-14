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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboardForm));
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
            panel1 = new Panel();
            panel2 = new Panel();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(27, 94, 32);
            lblTitle.Location = new Point(40, 28);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(192, 23);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "Welcome back, Admin";
            // 
            // lblOrders
            // 
            lblOrders.AutoSize = true;
            lblOrders.ForeColor = Color.FromArgb(27, 94, 32);
            lblOrders.Location = new Point(173, 166);
            lblOrders.Name = "lblOrders";
            lblOrders.Size = new Size(0, 20);
            lblOrders.TabIndex = 11;
            // 
            // lblLowStock
            // 
            lblLowStock.AutoSize = true;
            lblLowStock.BackColor = Color.Coral;
            lblLowStock.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLowStock.ForeColor = Color.White;
            lblLowStock.Location = new Point(133, 8);
            lblLowStock.Name = "lblLowStock";
            lblLowStock.Size = new Size(0, 20);
            lblLowStock.TabIndex = 12;
            // 
            // btnProducts
            // 
            btnProducts.BackColor = Color.CornflowerBlue;
            btnProducts.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnProducts.ForeColor = Color.White;
            btnProducts.Location = new Point(40, 281);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(197, 38);
            btnProducts.TabIndex = 0;
            btnProducts.Text = "Manage Products";
            btnProducts.UseVisualStyleBackColor = false;
            btnProducts.Click += btnManageProducts_Click;
            // 
            // btnOrders
            // 
            btnOrders.BackColor = Color.CornflowerBlue;
            btnOrders.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnOrders.ForeColor = Color.White;
            btnOrders.Location = new Point(40, 325);
            btnOrders.Name = "btnOrders";
            btnOrders.Size = new Size(197, 36);
            btnOrders.TabIndex = 1;
            btnOrders.Text = "Manage Orders";
            btnOrders.UseVisualStyleBackColor = false;
            btnOrders.Click += btnOrders_Click;
            // 
            // btnReports
            // 
            btnReports.BackColor = Color.CornflowerBlue;
            btnReports.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnReports.ForeColor = Color.White;
            btnReports.Location = new Point(40, 407);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(197, 36);
            btnReports.TabIndex = 3;
            btnReports.Text = "Generate Reports";
            btnReports.UseVisualStyleBackColor = false;
            btnReports.Click += btnReports_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(27, 94, 32);
            btnLogout.CausesValidation = false;
            btnLogout.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(40, 480);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(197, 40);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnCustomers
            // 
            btnCustomers.BackColor = Color.CornflowerBlue;
            btnCustomers.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnCustomers.ForeColor = Color.White;
            btnCustomers.Location = new Point(40, 367);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Size = new Size(197, 34);
            btnCustomers.TabIndex = 2;
            btnCustomers.Text = "Manage Customers";
            btnCustomers.UseVisualStyleBackColor = false;
            btnCustomers.Click += btnCustomers_Click;
            // 
            // lblTotSales
            // 
            lblTotSales.AutoSize = true;
            lblTotSales.ForeColor = Color.FromArgb(27, 94, 32);
            lblTotSales.Location = new Point(173, 132);
            lblTotSales.Name = "lblTotSales";
            lblTotSales.Size = new Size(0, 20);
            lblTotSales.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label1.ForeColor = Color.CornflowerBlue;
            label1.Location = new Point(40, 132);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 6;
            label1.Text = "Total Sales: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.ForeColor = Color.CornflowerBlue;
            label2.Location = new Point(40, 166);
            label2.Name = "label2";
            label2.Size = new Size(109, 20);
            label2.TabIndex = 7;
            label2.Text = "Active Orders: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Coral;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(4, 8);
            label3.Name = "label3";
            label3.Size = new Size(125, 20);
            label3.TabIndex = 8;
            label3.Text = "Low Stock Items: ";
            // 
            // lblProducts
            // 
            lblProducts.AutoSize = true;
            lblProducts.ForeColor = Color.FromArgb(27, 94, 32);
            lblProducts.Location = new Point(173, 203);
            lblProducts.Name = "lblProducts";
            lblProducts.Size = new Size(0, 20);
            lblProducts.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label4.ForeColor = Color.CornflowerBlue;
            label4.Location = new Point(40, 203);
            label4.Name = "label4";
            label4.Size = new Size(114, 20);
            label4.TabIndex = 9;
            label4.Text = "Total Products: ";
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.Location = new Point(519, -6);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 592);
            panel1.TabIndex = 14;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Coral;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(lblLowStock);
            panel2.Location = new Point(40, 84);
            panel2.Name = "panel2";
            panel2.Size = new Size(197, 36);
            panel2.TabIndex = 15;
            // 
            // AdminDashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(711, 565);
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblTotSales);
            Controls.Add(btnCustomers);
            Controls.Add(btnLogout);
            Controls.Add(btnReports);
            Controls.Add(btnOrders);
            Controls.Add(btnProducts);
            Controls.Add(lblProducts);
            Controls.Add(lblOrders);
            Controls.Add(lblTitle);
            Controls.Add(panel2);
            Name = "AdminDashboardForm";
            Text = "Dashboard";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
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
        private Panel panel1;
        private Panel panel2;
    }
}