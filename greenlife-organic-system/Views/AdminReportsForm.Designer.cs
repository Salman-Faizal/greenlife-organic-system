namespace greenlife_organic_system.Views
{
    partial class AdminReportsForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            dtpFrom = new DateTimePicker();
            dtpTo = new DateTimePicker();
            btnGenerate = new Button();
            btnExport = new Button();
            chartSales = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chartStock = new System.Windows.Forms.DataVisualization.Charting.Chart();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            groupBox1 = new GroupBox();
            lblCustomerOrders = new Label();
            lblTotalRevenueValue = new Label();
            lblAverageOrderValue = new Label();
            chartTopSelling = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chartOrderStatus = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dgvCustomerOrders = new DataGridView();
            txtUsername = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)chartSales).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartStock).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartTopSelling).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartOrderStatus).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCustomerOrders).BeginInit();
            SuspendLayout();
            // 
            // dtpFrom
            // 
            dtpFrom.Location = new Point(109, 52);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(250, 27);
            dtpFrom.TabIndex = 0;
            // 
            // dtpTo
            // 
            dtpTo.Location = new Point(109, 104);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(250, 27);
            dtpTo.TabIndex = 1;
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(109, 153);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(94, 29);
            btnGenerate.TabIndex = 2;
            btnGenerate.Text = "Generate Report";
            btnGenerate.UseVisualStyleBackColor = true;
            // 
            // btnExport
            // 
            btnExport.Location = new Point(6, 51);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(135, 29);
            btnExport.TabIndex = 3;
            btnExport.Text = "Download CSV";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // chartSales
            // 
            chartArea5.Name = "ChartArea1";
            chartSales.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            chartSales.Legends.Add(legend5);
            chartSales.Location = new Point(46, 298);
            chartSales.Name = "chartSales";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            chartSales.Series.Add(series5);
            chartSales.Size = new Size(613, 375);
            chartSales.TabIndex = 4;
            chartSales.Text = "chart1";
            // 
            // chartStock
            // 
            chartArea6.Name = "ChartArea1";
            chartStock.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            chartStock.Legends.Add(legend6);
            chartStock.Location = new Point(807, 298);
            chartStock.Name = "chartStock";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            chartStock.Series.Add(series6);
            chartStock.Size = new Size(557, 375);
            chartStock.TabIndex = 5;
            chartStock.Text = "chart2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 9);
            label1.Name = "label1";
            label1.Size = new Size(118, 20);
            label1.TabIndex = 6;
            label1.Text = "Generate Report";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 245);
            label3.Name = "label3";
            label3.Size = new Size(174, 20);
            label3.TabIndex = 8;
            label3.Text = "Sales Performance Graph";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(807, 245);
            label4.Name = "label4";
            label4.Size = new Size(140, 20);
            label4.TabIndex = 9;
            label4.Text = "Stock Balance Chart";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(46, 52);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 10;
            label5.Text = "From - ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(46, 109);
            label6.Name = "label6";
            label6.Size = new Size(39, 20);
            label6.TabIndex = 11;
            label6.Text = "To - ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnExport);
            groupBox1.Location = new Point(807, 78);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 104);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Download Order Data";
            // 
            // lblCustomerOrders
            // 
            lblCustomerOrders.AutoSize = true;
            lblCustomerOrders.Location = new Point(46, 731);
            lblCustomerOrders.Name = "lblCustomerOrders";
            lblCustomerOrders.Size = new Size(165, 20);
            lblCustomerOrders.TabIndex = 13;
            lblCustomerOrders.Text = "Customer Order History";
            // 
            // lblTotalRevenueValue
            // 
            lblTotalRevenueValue.AutoSize = true;
            lblTotalRevenueValue.Location = new Point(576, 59);
            lblTotalRevenueValue.Name = "lblTotalRevenueValue";
            lblTotalRevenueValue.Size = new Size(102, 20);
            lblTotalRevenueValue.TabIndex = 14;
            lblTotalRevenueValue.Text = "Total Revenue";
            // 
            // lblAverageOrderValue
            // 
            lblAverageOrderValue.AutoSize = true;
            lblAverageOrderValue.Location = new Point(576, 91);
            lblAverageOrderValue.Name = "lblAverageOrderValue";
            lblAverageOrderValue.Size = new Size(146, 20);
            lblAverageOrderValue.TabIndex = 15;
            lblAverageOrderValue.Text = "Average Order Value";
            // 
            // chartTopSelling
            // 
            chartArea7.Name = "ChartArea1";
            chartTopSelling.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            chartTopSelling.Legends.Add(legend7);
            chartTopSelling.Location = new Point(260, 714);
            chartTopSelling.Name = "chartTopSelling";
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            chartTopSelling.Series.Add(series7);
            chartTopSelling.Size = new Size(375, 375);
            chartTopSelling.TabIndex = 16;
            chartTopSelling.Text = "chart1";
            // 
            // chartOrderStatus
            // 
            chartArea8.Name = "ChartArea1";
            chartOrderStatus.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            chartOrderStatus.Legends.Add(legend8);
            chartOrderStatus.Location = new Point(682, 714);
            chartOrderStatus.Name = "chartOrderStatus";
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.Name = "Series1";
            chartOrderStatus.Series.Add(series8);
            chartOrderStatus.Size = new Size(375, 375);
            chartOrderStatus.TabIndex = 17;
            chartOrderStatus.Text = "chart1";
            // 
            // dgvCustomerOrders
            // 
            dgvCustomerOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomerOrders.Location = new Point(1092, 743);
            dgvCustomerOrders.Name = "dgvCustomerOrders";
            dgvCustomerOrders.RowHeadersWidth = 51;
            dgvCustomerOrders.Size = new Size(300, 188);
            dgvCustomerOrders.TabIndex = 18;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(443, 155);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(216, 27);
            txtUsername.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(443, 120);
            label2.Name = "label2";
            label2.Size = new Size(149, 20);
            label2.TabIndex = 20;
            label2.Text = "Customer User Name";
            // 
            // AdminReportsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1395, 1055);
            Controls.Add(label2);
            Controls.Add(txtUsername);
            Controls.Add(dgvCustomerOrders);
            Controls.Add(chartOrderStatus);
            Controls.Add(chartTopSelling);
            Controls.Add(lblAverageOrderValue);
            Controls.Add(lblTotalRevenueValue);
            Controls.Add(lblCustomerOrders);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(chartStock);
            Controls.Add(chartSales);
            Controls.Add(btnGenerate);
            Controls.Add(dtpTo);
            Controls.Add(dtpFrom);
            Controls.Add(groupBox1);
            Name = "AdminReportsForm";
            Text = "6";
            Load += AdminReportsForm_Load;
            ((System.ComponentModel.ISupportInitialize)chartSales).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartStock).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartTopSelling).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartOrderStatus).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCustomerOrders).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpFrom;
        private DateTimePicker dtpTo;
        private Button btnGenerate;
        private Button btnExport;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSales;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStock;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private GroupBox groupBox1;
        private Label lblCustomerOrders;
        private Label lblTotalRevenueValue;
        private Label lblAverageOrderValue;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTopSelling;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartOrderStatus;
        private DataGridView dgvCustomerOrders;
        private TextBox txtUsername;
        private Label label2;
    }
}