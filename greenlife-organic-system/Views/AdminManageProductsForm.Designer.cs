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
            txtPrice = new TextBox();
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
            dgvProducts.Location = new Point(12, 61);
            dgvProducts.MultiSelect = false;
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(521, 687);
            dgvProducts.TabIndex = 0;
            dgvProducts.SelectionChanged += dgvProducts_SelectionChanged;
            // 
            // txtName
            // 
            txtName.Location = new Point(177, 39);
            txtName.Name = "txtName";
            txtName.Size = new Size(237, 27);
            txtName.TabIndex = 1;
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(894, 309);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(237, 27);
            txtCategory.TabIndex = 2;
            // 
            // lblRating
            // 
            lblRating.AutoSize = true;
            lblRating.Location = new Point(19, 479);
            lblRating.Name = "lblRating";
            lblRating.Size = new Size(59, 20);
            lblRating.TabIndex = 7;
            lblRating.Text = "Rating: ";
            // 
            // picProduct
            // 
            picProduct.Location = new Point(894, 111);
            picProduct.Name = "picProduct";
            picProduct.Size = new Size(237, 141);
            picProduct.TabIndex = 8;
            picProduct.TabStop = false;
            // 
            // btnBrowseImage
            // 
            btnBrowseImage.Location = new Point(894, 258);
            btnBrowseImage.Name = "btnBrowseImage";
            btnBrowseImage.Size = new Size(143, 29);
            btnBrowseImage.TabIndex = 9;
            btnBrowseImage.Text = "Browse Image";
            btnBrowseImage.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(736, 646);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(189, 29);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(947, 646);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(184, 29);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(736, 692);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(189, 29);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(947, 692);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(184, 29);
            btnClear.TabIndex = 13;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // numDiscount
            // 
            numDiscount.Location = new Point(894, 407);
            numDiscount.Name = "numDiscount";
            numDiscount.Size = new Size(237, 27);
            numDiscount.TabIndex = 15;
            // 
            // numStock
            // 
            numStock.Location = new Point(894, 455);
            numStock.Name = "numStock";
            numStock.Size = new Size(237, 27);
            numStock.TabIndex = 16;
            // 
            // txtSupplier
            // 
            txtSupplier.Location = new Point(177, 512);
            txtSupplier.Name = "txtSupplier";
            txtSupplier.Size = new Size(237, 27);
            txtSupplier.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 28);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 18;
            label1.Text = "All Products";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 42);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 19;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(736, 146);
            label3.Name = "label3";
            label3.Size = new Size(106, 20);
            label3.TabIndex = 20;
            label3.Text = "Product Image";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(736, 316);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 21;
            label4.Text = "Category";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(736, 365);
            label5.Name = "label5";
            label5.Size = new Size(41, 20);
            label5.TabIndex = 22;
            label5.Text = "Price";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(736, 414);
            label6.Name = "label6";
            label6.Size = new Size(67, 20);
            label6.TabIndex = 23;
            label6.Text = "Discount";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(736, 462);
            label7.Name = "label7";
            label7.Size = new Size(45, 20);
            label7.TabIndex = 24;
            label7.Text = "Stock";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(19, 519);
            label8.Name = "label8";
            label8.Size = new Size(64, 20);
            label8.TabIndex = 25;
            label8.Text = "Supplier";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtPrice);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(lblRating);
            groupBox1.Controls.Add(txtSupplier);
            groupBox1.Location = new Point(717, 28);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(473, 720);
            groupBox1.TabIndex = 26;
            groupBox1.TabStop = false;
            groupBox1.Text = "Product Details";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(177, 334);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(237, 27);
            txtPrice.TabIndex = 27;
            // 
            // AdminManageProductsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1208, 795);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(numStock);
            Controls.Add(numDiscount);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(btnBrowseImage);
            Controls.Add(picProduct);
            Controls.Add(txtCategory);
            Controls.Add(dgvProducts);
            Controls.Add(groupBox1);
            Name = "AdminManageProductsForm";
            Text = "AdminManageProductsForm";
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
    }
}