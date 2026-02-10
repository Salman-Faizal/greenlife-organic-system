namespace greenlife_organic_system.Views
{
    partial class CartForm
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
            dgvCart = new DataGridView();
            btnIncreaseQty = new Button();
            btnDecreaseQty = new Button();
            btnRemoveItem = new Button();
            btnCheckout = new Button();
            lblTotal = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCart).BeginInit();
            SuspendLayout();
            // 
            // dgvCart
            // 
            dgvCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCart.Location = new Point(24, 56);
            dgvCart.MultiSelect = false;
            dgvCart.Name = "dgvCart";
            dgvCart.ReadOnly = true;
            dgvCart.RowHeadersWidth = 51;
            dgvCart.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCart.Size = new Size(547, 258);
            dgvCart.TabIndex = 0;
            // 
            // btnIncreaseQty
            // 
            btnIncreaseQty.Location = new Point(721, 56);
            btnIncreaseQty.Name = "btnIncreaseQty";
            btnIncreaseQty.Size = new Size(180, 29);
            btnIncreaseQty.TabIndex = 1;
            btnIncreaseQty.Text = "Increase (+1)";
            btnIncreaseQty.UseVisualStyleBackColor = true;
            btnIncreaseQty.Click += btnIncreaseQty_Click;
            // 
            // btnDecreaseQty
            // 
            btnDecreaseQty.Location = new Point(721, 127);
            btnDecreaseQty.Name = "btnDecreaseQty";
            btnDecreaseQty.Size = new Size(180, 29);
            btnDecreaseQty.TabIndex = 2;
            btnDecreaseQty.Text = "Decrease (-1)";
            btnDecreaseQty.UseVisualStyleBackColor = true;
            btnDecreaseQty.Click += btnDecreaseQty_Click;
            // 
            // btnRemoveItem
            // 
            btnRemoveItem.Location = new Point(721, 206);
            btnRemoveItem.Name = "btnRemoveItem";
            btnRemoveItem.Size = new Size(180, 29);
            btnRemoveItem.TabIndex = 3;
            btnRemoveItem.Text = "Remove Item";
            btnRemoveItem.UseVisualStyleBackColor = true;
            btnRemoveItem.Click += btnRemoveItem_Click;
            // 
            // btnCheckout
            // 
            btnCheckout.Location = new Point(721, 285);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(180, 29);
            btnCheckout.TabIndex = 4;
            btnCheckout.Text = "Checkout";
            btnCheckout.UseVisualStyleBackColor = true;
            btnCheckout.Click += btnCheckout_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(24, 343);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(49, 20);
            lblTotal.TabIndex = 5;
            lblTotal.Text = "Total: ";
            lblTotal.Click += lblTotal_Click;
            // 
            // CartForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(937, 450);
            Controls.Add(lblTotal);
            Controls.Add(btnCheckout);
            Controls.Add(btnRemoveItem);
            Controls.Add(btnDecreaseQty);
            Controls.Add(btnIncreaseQty);
            Controls.Add(dgvCart);
            Name = "CartForm";
            Text = "Cart";
            ((System.ComponentModel.ISupportInitialize)dgvCart).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCart;
        private Button btnIncreaseQty;
        private Button btnDecreaseQty;
        private Button btnRemoveItem;
        private Button btnCheckout;
        private Label lblTotal;
    }
}