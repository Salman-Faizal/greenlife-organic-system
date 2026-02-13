namespace greenlife_organic_system.Views
{
    partial class AdminManageOrdersForm
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
            cmbStatus = new ComboBox();
            btnUpdateStatus = new Button();
            label1 = new Label();
            dgvOrderItems = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            cbxActiveOrders = new CheckBox();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrderItems).BeginInit();
            SuspendLayout();
            // 
            // dgvOrders
            // 
            dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrders.Location = new Point(12, 101);
            dgvOrders.Name = "dgvOrders";
            dgvOrders.RowHeadersWidth = 51;
            dgvOrders.Size = new Size(551, 474);
            dgvOrders.TabIndex = 0;
            dgvOrders.SelectionChanged += dgvOrders_SelectionChanged;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(642, 507);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(175, 28);
            cmbStatus.TabIndex = 2;
            // 
            // btnUpdateStatus
            // 
            btnUpdateStatus.Location = new Point(642, 546);
            btnUpdateStatus.Name = "btnUpdateStatus";
            btnUpdateStatus.Size = new Size(94, 29);
            btnUpdateStatus.TabIndex = 3;
            btnUpdateStatus.Text = "Update";
            btnUpdateStatus.UseVisualStyleBackColor = true;
            btnUpdateStatus.Click += btnUpdateStatus_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(642, 484);
            label1.Name = "label1";
            label1.Size = new Size(144, 20);
            label1.TabIndex = 4;
            label1.Text = "Update Order Status";
            // 
            // dgvOrderItems
            // 
            dgvOrderItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderItems.Location = new Point(642, 101);
            dgvOrderItems.Name = "dgvOrderItems";
            dgvOrderItems.RowHeadersWidth = 51;
            dgvOrderItems.Size = new Size(549, 350);
            dgvOrderItems.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 62);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 6;
            label2.Text = "All Orders";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(642, 62);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 7;
            label3.Text = "Order Items";
            // 
            // cbxActiveOrders
            // 
            cbxActiveOrders.AutoSize = true;
            cbxActiveOrders.Location = new Point(409, 62);
            cbxActiveOrders.Name = "cbxActiveOrders";
            cbxActiveOrders.Size = new Size(154, 24);
            cbxActiveOrders.TabIndex = 8;
            cbxActiveOrders.Text = "Active Orders Only";
            cbxActiveOrders.UseVisualStyleBackColor = true;
            cbxActiveOrders.CheckedChanged += cbxActiveOrders_CheckedChanged;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(1060, 12);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(132, 29);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "<-- Go Back";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // AdminManageOrdersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1204, 623);
            Controls.Add(btnCancel);
            Controls.Add(cbxActiveOrders);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dgvOrderItems);
            Controls.Add(label1);
            Controls.Add(btnUpdateStatus);
            Controls.Add(cmbStatus);
            Controls.Add(dgvOrders);
            Name = "AdminManageOrdersForm";
            Text = "Manage Orders";
            Load += AdminManageOrdersForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrderItems).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvOrders;
        private ComboBox cmbStatus;
        private Button btnUpdateStatus;
        private Label label1;
        private DataGridView dgvOrderItems;
        private Label label2;
        private Label label3;
        private CheckBox cbxActiveOrders;
        private Button btnCancel;
    }
}