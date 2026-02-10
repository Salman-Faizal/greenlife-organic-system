namespace greenlife_organic_system.Views
{
    partial class MyOrdersForm
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
            dgvOrders = new DataGridView();
            dgvOrderItems = new DataGridView();
            lblOrdersTitle = new Label();
            lblOrderDetails = new Label();
            flpReviewActions = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrderItems).BeginInit();
            SuspendLayout();
            // 
            // dgvOrders
            // 
            dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrders.Location = new Point(33, 90);
            dgvOrders.Name = "dgvOrders";
            dgvOrders.RowHeadersWidth = 51;
            dgvOrders.Size = new Size(426, 322);
            dgvOrders.TabIndex = 0;
            dgvOrders.SelectionChanged += dgvOrders_SelectionChanged;
            // 
            // dgvOrderItems
            // 
            dgvOrderItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderItems.Location = new Point(529, 90);
            dgvOrderItems.Name = "dgvOrderItems";
            dgvOrderItems.RowHeadersWidth = 51;
            dgvOrderItems.Size = new Size(505, 153);
            dgvOrderItems.TabIndex = 1;
            dgvOrderItems.CellFormatting += dgvOrderItems_CellFormatting;
            // 
            // lblOrdersTitle
            // 
            lblOrdersTitle.AutoSize = true;
            lblOrdersTitle.Location = new Point(33, 53);
            lblOrdersTitle.Name = "lblOrdersTitle";
            lblOrdersTitle.Size = new Size(77, 20);
            lblOrdersTitle.TabIndex = 2;
            lblOrdersTitle.Text = "My Orders";
            // 
            // lblOrderDetails
            // 
            lblOrderDetails.AutoSize = true;
            lblOrderDetails.Location = new Point(529, 53);
            lblOrderDetails.Name = "lblOrderDetails";
            lblOrderDetails.Size = new Size(97, 20);
            lblOrderDetails.TabIndex = 3;
            lblOrderDetails.Text = "Order Details";
            lblOrderDetails.Click += lblOrderDetails_Click;
            // 
            // flpReviewActions
            // 
            flpReviewActions.AutoScroll = true;
            flpReviewActions.Location = new Point(529, 287);
            flpReviewActions.Name = "flpReviewActions";
            flpReviewActions.Size = new Size(505, 125);
            flpReviewActions.TabIndex = 4;
            // 
            // MyOrdersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1070, 450);
            Controls.Add(flpReviewActions);
            Controls.Add(lblOrderDetails);
            Controls.Add(lblOrdersTitle);
            Controls.Add(dgvOrderItems);
            Controls.Add(dgvOrders);
            Name = "MyOrdersForm";
            Text = "My Orders";
            Load += MyOrdersForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrderItems).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvOrders;
        private DataGridView dgvOrderItems;
        private Label lblOrdersTitle;
        private Label lblOrderDetails;
        private FlowLayoutPanel flpReviewActions;
    }
}