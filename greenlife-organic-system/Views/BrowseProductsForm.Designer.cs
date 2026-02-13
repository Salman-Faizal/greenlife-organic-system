namespace greenlife_organic_system.Views
{
    partial class BrowseProductsForm
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
            txtSearch = new TextBox();
            cmbCategory = new ComboBox();
            btnSearch = new Button();
            dgvProducts = new DataGridView();
            numQuantity = new NumericUpDown();
            btnAddToCart = new Button();
            lblCartTotal = new Label();
            pnlDetails = new Panel();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            btnViewCart = new Button();
            lblReviews = new Label();
            flpReviews = new FlowLayoutPanel();
            lblStock = new Label();
            lblDescription = new Label();
            lblRating = new Label();
            lblPrice = new Label();
            lblName = new Label();
            picProduct = new PictureBox();
            label1 = new Label();
            btnCancel = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            pnlDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picProduct).BeginInit();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(12, 96);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(172, 27);
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(509, 98);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(190, 28);
            cmbCategory.TabIndex = 1;
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(180, 96);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(108, 27);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // dgvProducts
            // 
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(12, 145);
            dgvProducts.MultiSelect = false;
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(687, 645);
            dgvProducts.TabIndex = 3;
            dgvProducts.SelectionChanged += dgvProducts_SelectionChanged;
            // 
            // numQuantity
            // 
            numQuantity.Location = new Point(143, 596);
            numQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(74, 27);
            numQuantity.TabIndex = 4;
            numQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAddToCart
            // 
            btnAddToCart.Enabled = false;
            btnAddToCart.Location = new Point(25, 631);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Size = new Size(192, 29);
            btnAddToCart.TabIndex = 5;
            btnAddToCart.Text = "Add to Cart";
            btnAddToCart.UseVisualStyleBackColor = true;
            btnAddToCart.Click += btnAddToCart_Click;
            // 
            // lblCartTotal
            // 
            lblCartTotal.AutoSize = true;
            lblCartTotal.Location = new Point(32, 608);
            lblCartTotal.Name = "lblCartTotal";
            lblCartTotal.Size = new Size(0, 20);
            lblCartTotal.TabIndex = 6;
            // 
            // pnlDetails
            // 
            pnlDetails.Controls.Add(label7);
            pnlDetails.Controls.Add(label6);
            pnlDetails.Controls.Add(label5);
            pnlDetails.Controls.Add(label4);
            pnlDetails.Controls.Add(label2);
            pnlDetails.Controls.Add(btnViewCart);
            pnlDetails.Controls.Add(lblReviews);
            pnlDetails.Controls.Add(flpReviews);
            pnlDetails.Controls.Add(lblCartTotal);
            pnlDetails.Controls.Add(lblStock);
            pnlDetails.Controls.Add(lblDescription);
            pnlDetails.Controls.Add(lblRating);
            pnlDetails.Controls.Add(lblPrice);
            pnlDetails.Controls.Add(lblName);
            pnlDetails.Controls.Add(picProduct);
            pnlDetails.Controls.Add(btnAddToCart);
            pnlDetails.Controls.Add(numQuantity);
            pnlDetails.Location = new Point(778, 72);
            pnlDetails.Name = "pnlDetails";
            pnlDetails.Size = new Size(323, 766);
            pnlDetails.TabIndex = 7;
            pnlDetails.Paint += pnlDetails_Paint;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(25, 327);
            label7.Name = "label7";
            label7.Size = new Size(114, 20);
            label7.TabIndex = 18;
            label7.Text = "Stock Available:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 294);
            label6.Name = "label6";
            label6.Size = new Size(55, 20);
            label6.TabIndex = 17;
            label6.Text = "Rating:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 257);
            label5.Name = "label5";
            label5.Size = new Size(44, 20);
            label5.TabIndex = 16;
            label5.Text = "Price:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 222);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 15;
            label4.Text = "Category:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 598);
            label2.Name = "label2";
            label2.Size = new Size(112, 20);
            label2.TabIndex = 14;
            label2.Text = "Select Quantity:";
            // 
            // btnViewCart
            // 
            btnViewCart.Location = new Point(25, 689);
            btnViewCart.Name = "btnViewCart";
            btnViewCart.Size = new Size(192, 29);
            btnViewCart.TabIndex = 13;
            btnViewCart.Text = "> Proceed To Cart";
            btnViewCart.UseVisualStyleBackColor = true;
            btnViewCart.Click += btnViewCart_Click;
            // 
            // lblReviews
            // 
            lblReviews.AutoSize = true;
            lblReviews.Font = new Font("Segoe UI Variable Display Semib", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReviews.Location = new Point(25, 376);
            lblReviews.Name = "lblReviews";
            lblReviews.Size = new Size(64, 20);
            lblReviews.TabIndex = 0;
            lblReviews.Text = "Reviews";
            // 
            // flpReviews
            // 
            flpReviews.AutoScroll = true;
            flpReviews.FlowDirection = FlowDirection.TopDown;
            flpReviews.Location = new Point(25, 399);
            flpReviews.Name = "flpReviews";
            flpReviews.Size = new Size(230, 121);
            flpReviews.TabIndex = 12;
            flpReviews.WrapContents = false;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(143, 327);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(0, 20);
            lblStock.TabIndex = 11;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(143, 222);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(0, 20);
            lblDescription.TabIndex = 10;
            // 
            // lblRating
            // 
            lblRating.AutoSize = true;
            lblRating.Location = new Point(143, 294);
            lblRating.Name = "lblRating";
            lblRating.Size = new Size(0, 20);
            lblRating.TabIndex = 9;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(143, 257);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(0, 20);
            lblPrice.TabIndex = 8;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(25, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(0, 20);
            lblName.TabIndex = 7;
            // 
            // picProduct
            // 
            picProduct.BackColor = SystemColors.ControlLight;
            picProduct.Location = new Point(25, 44);
            picProduct.Name = "picProduct";
            picProduct.Size = new Size(230, 152);
            picProduct.SizeMode = PictureBoxSizeMode.CenterImage;
            picProduct.TabIndex = 6;
            picProduct.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(423, 99);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 12;
            label1.Text = "Categories";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(961, 12);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(131, 29);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "<-- Go Back";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(290, 34);
            label3.Name = "label3";
            label3.Size = new Size(235, 28);
            label3.TabIndex = 14;
            label3.Text = "Shop Organic Products";
            // 
            // BrowseProductsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1104, 820);
            Controls.Add(label3);
            Controls.Add(btnCancel);
            Controls.Add(label1);
            Controls.Add(dgvProducts);
            Controls.Add(btnSearch);
            Controls.Add(cmbCategory);
            Controls.Add(txtSearch);
            Controls.Add(pnlDetails);
            Name = "BrowseProductsForm";
            Text = "Products";
            Load += BrowseProductsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            pnlDetails.ResumeLayout(false);
            pnlDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSearch;
        private ComboBox cmbCategory;
        private Button btnSearch;
        private DataGridView dgvProducts;
        private NumericUpDown numQuantity;
        private Button btnAddToCart;
        private Label lblCartTotal;
        private Panel pnlDetails;
        private Label lblStock;
        private Label lblDescription;
        private Label lblRating;
        private Label lblPrice;
        private Label lblName;
        private PictureBox picProduct;
        private Label label1;
        private FlowLayoutPanel flpReviews;
        private Label lblReviews;
        private Button btnViewCart;
        private Label label2;
        private Button btnCancel;
        private Label label3;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label7;
    }
}