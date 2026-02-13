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
            numRating = new NumericUpDown();
            txtComment = new TextBox();
            btnSubmit = new Button();
            flpReviewActions = new Panel();
            label1 = new Label();
            panel1 = new Panel();
            btnCancelOrder = new Button();
            label2 = new Label();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrderItems).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numRating).BeginInit();
            flpReviewActions.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvOrders
            // 
            dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrders.Location = new Point(32, 114);
            dgvOrders.Name = "dgvOrders";
            dgvOrders.RowHeadersWidth = 51;
            dgvOrders.Size = new Size(426, 468);
            dgvOrders.TabIndex = 0;
            dgvOrders.SelectionChanged += dgvOrders_SelectionChanged;
            // 
            // dgvOrderItems
            // 
            dgvOrderItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderItems.Location = new Point(528, 114);
            dgvOrderItems.Name = "dgvOrderItems";
            dgvOrderItems.RowHeadersWidth = 51;
            dgvOrderItems.Size = new Size(505, 155);
            dgvOrderItems.TabIndex = 1;
            dgvOrderItems.CellContentClick += dgvOrderItems_CellContentClick;
            dgvOrderItems.CellFormatting += dgvOrderItems_CellFormatting;
            // 
            // lblOrdersTitle
            // 
            lblOrdersTitle.AutoSize = true;
            lblOrdersTitle.Location = new Point(32, 80);
            lblOrdersTitle.Name = "lblOrdersTitle";
            lblOrdersTitle.Size = new Size(77, 20);
            lblOrdersTitle.TabIndex = 2;
            lblOrdersTitle.Text = "My Orders";
            // 
            // lblOrderDetails
            // 
            lblOrderDetails.AutoSize = true;
            lblOrderDetails.Location = new Point(528, 80);
            lblOrderDetails.Name = "lblOrderDetails";
            lblOrderDetails.Size = new Size(97, 20);
            lblOrderDetails.TabIndex = 3;
            lblOrderDetails.Text = "Order Details";
            lblOrderDetails.Click += lblOrderDetails_Click;
            // 
            // numRating
            // 
            numRating.Location = new Point(23, 39);
            numRating.Name = "numRating";
            numRating.Size = new Size(150, 27);
            numRating.TabIndex = 0;
            // 
            // txtComment
            // 
            txtComment.Location = new Point(255, 20);
            txtComment.Multiline = true;
            txtComment.Name = "txtComment";
            txtComment.PlaceholderText = "Optional review...";
            txtComment.Size = new Size(228, 97);
            txtComment.TabIndex = 1;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(23, 86);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(150, 31);
            btnSubmit.TabIndex = 2;
            btnSubmit.Text = "Submit Review";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // flpReviewActions
            // 
            flpReviewActions.Controls.Add(label1);
            flpReviewActions.Controls.Add(numRating);
            flpReviewActions.Controls.Add(txtComment);
            flpReviewActions.Controls.Add(btnSubmit);
            flpReviewActions.Location = new Point(528, 303);
            flpReviewActions.Name = "flpReviewActions";
            flpReviewActions.Size = new Size(505, 153);
            flpReviewActions.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 16);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 3;
            label1.Text = "Rating (1-5)";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnCancelOrder);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(528, 490);
            panel1.Name = "panel1";
            panel1.Size = new Size(505, 92);
            panel1.TabIndex = 4;
            // 
            // btnCancelOrder
            // 
            btnCancelOrder.Location = new Point(23, 45);
            btnCancelOrder.Name = "btnCancelOrder";
            btnCancelOrder.Size = new Size(150, 31);
            btnCancelOrder.TabIndex = 4;
            btnCancelOrder.Text = "Cancel Order";
            btnCancelOrder.UseVisualStyleBackColor = true;
            btnCancelOrder.Click += btnCancelOrder_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 13);
            label2.Name = "label2";
            label2.Size = new Size(133, 20);
            label2.TabIndex = 5;
            label2.Text = "Order Cancellation";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(889, 12);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(145, 29);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "<-- Go Back";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // MyOrdersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1070, 622);
            Controls.Add(btnCancel);
            Controls.Add(panel1);
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
            ((System.ComponentModel.ISupportInitialize)numRating).EndInit();
            flpReviewActions.ResumeLayout(false);
            flpReviewActions.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvOrders;
        private DataGridView dgvOrderItems;
        private Label lblOrdersTitle;
        private Label lblOrderDetails;
        private NumericUpDown numRating;
        private TextBox txtComment;
        private Button btnSubmit;
        private Panel flpReviewActions;
        private Label label1;
        private Panel panel1;
        private Button btnCancelOrder;
        private Label label2;
        private Button btnCancel;
    }
}