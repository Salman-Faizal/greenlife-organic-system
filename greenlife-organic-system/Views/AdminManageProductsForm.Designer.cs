namespace greenlife_organic_system.Views
{
    partial class AdminManageProductsForm
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
            dgvProducts = new DataGridView();
            txtName = new TextBox();
            txtCategory = new TextBox();
            lblRating = new Label();
            picProduct = new PictureBox();
            btnBrowseImage = new Button();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            numDiscount = new NumericUpDown();
            numStock = new NumericUpDown();
            txtSupplier = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            groupBox1 = new GroupBox();
            label9 = new Label();
            txtPrice = new TextBox();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDiscount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numStock).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvProducts
            // 
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(31, 61);
            dgvProducts.MultiSelect = false;
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(521, 737);
            dgvProducts.TabIndex = 0;
            dgvProducts.SelectionChanged += dgvProducts_SelectionChanged;
            // 
            // txtName
            // 
            txtName.Location = new Point(177, 39);
            txtName.Name = "txtName";
            txtName.Size = new Size(237, 27);
            txtName.TabIndex = 0;
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(894, 359);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(237, 27);
            txtCategory.TabIndex = 2;
            // 
            // lblRating
            // 
            lblRating.AutoSize = true;
            lblRating.ForeColor = Color.FromArgb(27, 94, 32);
            lblRating.Location = new Point(177, 476);
            lblRating.Name = "lblRating";
            lblRating.Size = new Size(0, 20);
            lblRating.TabIndex = 2;
            // 
            // picProduct
            // 
            picProduct.BackColor = SystemColors.ControlLight;
            picProduct.Location = new Point(894, 161);
            picProduct.Name = "picProduct";
            picProduct.Size = new Size(237, 141);
            picProduct.SizeMode = PictureBoxSizeMode.CenterImage;
            picProduct.TabIndex = 8;
            picProduct.TabStop = false;
            // 
            // btnBrowseImage
            // 
            btnBrowseImage.BackColor = Color.CornflowerBlue;
            btnBrowseImage.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBrowseImage.ForeColor = Color.White;
            btnBrowseImage.Location = new Point(894, 308);
            btnBrowseImage.Name = "btnBrowseImage";
            btnBrowseImage.Size = new Size(143, 35);
            btnBrowseImage.TabIndex = 1;
            btnBrowseImage.Text = "Browse Image";
            btnBrowseImage.UseVisualStyleBackColor = false;
            btnBrowseImage.Enter += btnBrowseImage_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(27, 94, 32);
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(736, 687);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(189, 38);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(27, 94, 32);
            btnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(947, 687);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(184, 38);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(27, 94, 32);
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(19, 653);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(189, 40);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(27, 94, 32);
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(230, 653);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(184, 40);
            btnClear.TabIndex = 4;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // numDiscount
            // 
            numDiscount.Location = new Point(894, 457);
            numDiscount.Name = "numDiscount";
            numDiscount.Size = new Size(237, 27);
            numDiscount.TabIndex = 3;
            // 
            // numStock
            // 
            numStock.Location = new Point(894, 505);
            numStock.Name = "numStock";
            numStock.Size = new Size(237, 27);
            numStock.TabIndex = 4;
            // 
            // txtSupplier
            // 
            txtSupplier.Location = new Point(177, 512);
            txtSupplier.Name = "txtSupplier";
            txtSupplier.Size = new Size(237, 27);
            txtSupplier.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(27, 94, 32);
            label1.Location = new Point(31, 17);
            label1.Name = "label1";
            label1.Size = new Size(117, 24);
            label1.TabIndex = 0;
            label1.Text = "All Products";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(27, 94, 32);
            label2.Location = new Point(19, 42);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 4;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(200, 230, 201);
            label3.ForeColor = Color.FromArgb(27, 94, 32);
            label3.Location = new Point(736, 196);
            label3.Name = "label3";
            label3.Size = new Size(106, 20);
            label3.TabIndex = 11;
            label3.Text = "Product Image";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(200, 230, 201);
            label4.ForeColor = Color.FromArgb(27, 94, 32);
            label4.Location = new Point(736, 366);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 12;
            label4.Text = "Category";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(200, 230, 201);
            label5.ForeColor = Color.FromArgb(27, 94, 32);
            label5.Location = new Point(736, 415);
            label5.Name = "label5";
            label5.Size = new Size(41, 20);
            label5.TabIndex = 13;
            label5.Text = "Price";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(200, 230, 201);
            label6.ForeColor = Color.FromArgb(27, 94, 32);
            label6.Location = new Point(736, 464);
            label6.Name = "label6";
            label6.Size = new Size(67, 20);
            label6.TabIndex = 14;
            label6.Text = "Discount";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(200, 230, 201);
            label7.ForeColor = Color.FromArgb(27, 94, 32);
            label7.Location = new Point(736, 512);
            label7.Name = "label7";
            label7.Size = new Size(45, 20);
            label7.TabIndex = 15;
            label7.Text = "Stock";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.FromArgb(27, 94, 32);
            label8.Location = new Point(19, 519);
            label8.Name = "label8";
            label8.Size = new Size(64, 20);
            label8.TabIndex = 6;
            label8.Text = "Supplier";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(200, 230, 201);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtPrice);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(lblRating);
            groupBox1.Controls.Add(txtSupplier);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnClear);
            groupBox1.Location = new Point(717, 78);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(473, 720);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Product Details";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.FromArgb(27, 94, 32);
            label9.Location = new Point(19, 476);
            label9.Name = "label9";
            label9.Size = new Size(52, 20);
            label9.TabIndex = 5;
            label9.Text = "Rating";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(177, 334);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(237, 27);
            txtPrice.TabIndex = 1;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(27, 94, 32);
            btnCancel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(1052, 11);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(144, 39);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "<-- Go Back";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // AdminManageProductsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1208, 833);
            Controls.Add(btnCancel);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(numStock);
            Controls.Add(numDiscount);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(btnBrowseImage);
            Controls.Add(picProduct);
            Controls.Add(txtCategory);
            Controls.Add(dgvProducts);
            Controls.Add(groupBox1);
            Name = "AdminManageProductsForm";
            Text = "Manage Products";
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)picProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDiscount).EndInit();
            ((System.ComponentModel.ISupportInitialize)numStock).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProducts;
        private TextBox txtName;
        private TextBox txtCategory;
        private Label lblRating;
        private PictureBox picProduct;
        private Button btnBrowseImage;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private NumericUpDown numDiscount;
        private NumericUpDown numStock;
        private TextBox txtSupplier;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private GroupBox groupBox1;
        private TextBox txtPrice;
        private Label label9;
        private Button btnCancel;
    }
}