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
            dgvOrders.TabIndex = 1;
            dgvOrders.SelectionChanged += dgvOrders_SelectionChanged;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(642, 500);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(175, 28);
            cmbStatus.TabIndex = 1;
            // 
            // btnUpdateStatus
            // 
            btnUpdateStatus.BackColor = Color.FromArgb(27, 94, 32);
            btnUpdateStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateStatus.ForeColor = Color.White;
            btnUpdateStatus.Location = new Point(642, 539);
            btnUpdateStatus.Name = "btnUpdateStatus";
            btnUpdateStatus.Size = new Size(121, 36);
            btnUpdateStatus.TabIndex = 2;
            btnUpdateStatus.Text = "Update";
            btnUpdateStatus.UseVisualStyleBackColor = false;
            btnUpdateStatus.Click += btnUpdateStatus_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.CornflowerBlue;
            label1.Location = new Point(642, 477);
            label1.Name = "label1";
            label1.Size = new Size(144, 20);
            label1.TabIndex = 7;
            label1.Text = "Update Order Status";
            // 
            // dgvOrderItems
            // 
            dgvOrderItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderItems.Location = new Point(642, 101);
            dgvOrderItems.Name = "dgvOrderItems";
            dgvOrderItems.RowHeadersWidth = 51;
            dgvOrderItems.Size = new Size(549, 350);
            dgvOrderItems.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Segoe UI Emoji", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(27, 94, 32);
            label2.Location = new Point(12, 59);
            label2.Name = "label2";
            label2.Size = new Size(99, 24);
            label2.TabIndex = 8;
            label2.Text = "All Orders";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(27, 94, 32);
            label3.Location = new Point(642, 66);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 5;
            label3.Text = "Order Items";
            // 
            // cbxActiveOrders
            // 
            cbxActiveOrders.AutoSize = true;
            cbxActiveOrders.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxActiveOrders.ForeColor = Color.CornflowerBlue;
            cbxActiveOrders.Location = new Point(409, 62);
            cbxActiveOrders.Name = "cbxActiveOrders";
            cbxActiveOrders.Size = new Size(154, 24);
            cbxActiveOrders.TabIndex = 0;
            cbxActiveOrders.Text = "Active Orders Only";
            cbxActiveOrders.UseVisualStyleBackColor = true;
            cbxActiveOrders.CheckedChanged += cbxActiveOrders_CheckedChanged;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(27, 94, 32);
            btnCancel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(1060, 12);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(132, 35);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "<-- Go Back";
            btnCancel.UseVisualStyleBackColor = false;
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