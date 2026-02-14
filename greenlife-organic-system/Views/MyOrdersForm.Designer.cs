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
            dgvOrders.Location = new Point(32, 69);
            dgvOrders.Name = "dgvOrders";
            dgvOrders.RowHeadersWidth = 51;
            dgvOrders.Size = new Size(426, 513);
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
            dgvOrderItems.CellFormatting += dgvOrderItems_CellFormatting;
            // 
            // lblOrdersTitle
            // 
            lblOrdersTitle.AutoSize = true;
            lblOrdersTitle.Font = new Font("Segoe UI Emoji", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOrdersTitle.ForeColor = Color.FromArgb(27, 94, 32);
            lblOrdersTitle.Location = new Point(32, 34);
            lblOrdersTitle.Name = "lblOrdersTitle";
            lblOrdersTitle.Size = new Size(103, 24);
            lblOrdersTitle.TabIndex = 2;
            lblOrdersTitle.Text = "My Orders";
            // 
            // lblOrderDetails
            // 
            lblOrderDetails.AutoSize = true;
            lblOrderDetails.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOrderDetails.ForeColor = Color.FromArgb(27, 94, 32);
            lblOrderDetails.Location = new Point(528, 80);
            lblOrderDetails.Name = "lblOrderDetails";
            lblOrderDetails.Size = new Size(99, 20);
            lblOrderDetails.TabIndex = 3;
            lblOrderDetails.Text = "Order Details";
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
            txtComment.Size = new Size(228, 104);
            txtComment.TabIndex = 1;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.FromArgb(27, 94, 32);
            btnSubmit.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(23, 86);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(150, 38);
            btnSubmit.TabIndex = 2;
            btnSubmit.Text = "Submit Review";
            btnSubmit.UseVisualStyleBackColor = false;
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
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(27, 94, 32);
            label1.Location = new Point(23, 16);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
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
            btnCancelOrder.BackColor = Color.FromArgb(27, 94, 32);
            btnCancelOrder.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnCancelOrder.ForeColor = Color.White;
            btnCancelOrder.Location = new Point(23, 36);
            btnCancelOrder.Name = "btnCancelOrder";
            btnCancelOrder.Size = new Size(150, 36);
            btnCancelOrder.TabIndex = 4;
            btnCancelOrder.Text = "Cancel Order";
            btnCancelOrder.UseVisualStyleBackColor = false;
            btnCancelOrder.Click += btnCancelOrder_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(27, 94, 32);
            label2.Location = new Point(23, 13);
            label2.Name = "label2";
            label2.Size = new Size(137, 20);
            label2.TabIndex = 5;
            label2.Text = "Order Cancellation";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(27, 94, 32);
            btnCancel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(875, 12);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(159, 36);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "<-- Go Back";
            btnCancel.UseVisualStyleBackColor = false;
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
            Text = "Orders";
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