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
            btnBack = new Button();
            label3 = new Label();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)dgvCart).BeginInit();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvCart
            // 
            dgvCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCart.Location = new Point(24, 101);
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
            btnIncreaseQty.BackColor = Color.CornflowerBlue;
            btnIncreaseQty.ForeColor = Color.White;
            btnIncreaseQty.Location = new Point(29, 26);
            btnIncreaseQty.Name = "btnIncreaseQty";
            btnIncreaseQty.Size = new Size(180, 29);
            btnIncreaseQty.TabIndex = 0;
            btnIncreaseQty.Text = "Increase (+1)";
            btnIncreaseQty.UseVisualStyleBackColor = false;
            btnIncreaseQty.Click += btnIncreaseQty_Click;
            // 
            // btnDecreaseQty
            // 
            btnDecreaseQty.BackColor = Color.CornflowerBlue;
            btnDecreaseQty.ForeColor = Color.White;
            btnDecreaseQty.Location = new Point(29, 72);
            btnDecreaseQty.Name = "btnDecreaseQty";
            btnDecreaseQty.Size = new Size(180, 29);
            btnDecreaseQty.TabIndex = 1;
            btnDecreaseQty.Text = "Decrease (-1)";
            btnDecreaseQty.UseVisualStyleBackColor = false;
            btnDecreaseQty.Click += btnDecreaseQty_Click;
            // 
            // btnRemoveItem
            // 
            btnRemoveItem.BackColor = Color.CornflowerBlue;
            btnRemoveItem.ForeColor = Color.White;
            btnRemoveItem.Location = new Point(29, 120);
            btnRemoveItem.Name = "btnRemoveItem";
            btnRemoveItem.Size = new Size(180, 29);
            btnRemoveItem.TabIndex = 2;
            btnRemoveItem.Text = "Remove Item";
            btnRemoveItem.UseVisualStyleBackColor = false;
            btnRemoveItem.Click += btnRemoveItem_Click;
            // 
            // btnCheckout
            // 
            btnCheckout.BackColor = Color.FromArgb(27, 94, 32);
            btnCheckout.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCheckout.ForeColor = Color.White;
            btnCheckout.Location = new Point(17, 232);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(209, 35);
            btnCheckout.TabIndex = 1;
            btnCheckout.Text = "Checkout";
            btnCheckout.UseVisualStyleBackColor = false;
            btnCheckout.Click += btnCheckout_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = Color.CornflowerBlue;
            lblTotal.Location = new Point(24, 376);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(50, 20);
            lblTotal.TabIndex = 5;
            lblTotal.Text = "Total: ";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(27, 94, 32);
            btnBack.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(760, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(133, 38);
            btnBack.TabIndex = 0;
            btnBack.Text = "<-- Go Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(250, 250, 250);
            label3.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(27, 94, 32);
            label3.Location = new Point(324, 24);
            label3.Name = "label3";
            label3.Size = new Size(152, 28);
            label3.TabIndex = 15;
            label3.Text = "Shopping Cart";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(200, 230, 201);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(btnCheckout);
            panel1.Location = new Point(617, 101);
            panel1.Name = "panel1";
            panel1.Size = new Size(276, 295);
            panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnIncreaseQty);
            groupBox1.Controls.Add(btnDecreaseQty);
            groupBox1.Controls.Add(btnRemoveItem);
            groupBox1.Location = new Point(17, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 168);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Modify Item";
            // 
            // CartForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 250, 250);
            ClientSize = new Size(919, 450);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(btnBack);
            Controls.Add(lblTotal);
            Controls.Add(dgvCart);
            ForeColor = SystemColors.ControlText;
            Name = "CartForm";
            Text = "Cart";
            ((System.ComponentModel.ISupportInitialize)dgvCart).EndInit();
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
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
        private Button btnBack;
        private Label label3;
        private Panel panel1;
        private GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}