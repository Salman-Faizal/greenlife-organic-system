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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            label14 = new Label();
            label13 = new Label();
            label8 = new Label();
            label9 = new Label();
            panel1 = new Panel();
            label7 = new Label();
            label10 = new Label();
            label11 = new Label();
            btnExit = new Button();
            label12 = new Label();
            ((System.ComponentModel.ISupportInitialize)chartSales).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartStock).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartTopSelling).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartOrderStatus).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCustomerOrders).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dtpFrom
            // 
            dtpFrom.Location = new Point(71, 35);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(250, 27);
            dtpFrom.TabIndex = 0;
            // 
            // dtpTo
            // 
            dtpTo.Location = new Point(71, 80);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(250, 27);
            dtpTo.TabIndex = 1;
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(96, 310);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(202, 35);
            btnGenerate.TabIndex = 2;
            btnGenerate.Text = "Generate Report";
            btnGenerate.UseVisualStyleBackColor = true;
            // 
            // btnExport
            // 
            btnExport.Location = new Point(21, 46);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(135, 29);
            btnExport.TabIndex = 3;
            btnExport.Text = "Download CSV";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // chartSales
            // 
            chartArea1.Name = "ChartArea1";
            chartSales.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartSales.Legends.Add(legend1);
            chartSales.Location = new Point(1283, 151);
            chartSales.Name = "chartSales";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartSales.Series.Add(series1);
            chartSales.Size = new Size(505, 375);
            chartSales.TabIndex = 4;
            chartSales.Text = "chart1";
            // 
            // chartStock
            // 
            chartArea2.Name = "ChartArea1";
            chartStock.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartStock.Legends.Add(legend2);
            chartStock.Location = new Point(665, 151);
            chartStock.Name = "chartStock";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartStock.Series.Add(series2);
            chartStock.Size = new Size(557, 375);
            chartStock.TabIndex = 5;
            chartStock.Text = "chart2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(842, 35);
            label1.Name = "label1";
            label1.Size = new Size(191, 27);
            label1.TabIndex = 6;
            label1.Text = "Report Generation";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1284, 119);
            label3.Name = "label3";
            label3.Size = new Size(174, 20);
            label3.TabIndex = 8;
            label3.Text = "Sales Performance Graph";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(665, 119);
            label4.Name = "label4";
            label4.Size = new Size(140, 20);
            label4.TabIndex = 9;
            label4.Text = "Stock Balance Chart";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 35);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 10;
            label5.Text = "From - ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 80);
            label6.Name = "label6";
            label6.Size = new Size(39, 20);
            label6.TabIndex = 11;
            label6.Text = "To - ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnExport);
            groupBox1.Location = new Point(41, 753);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(405, 112);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Download Order Data";
            // 
            // lblCustomerOrders
            // 
            lblCustomerOrders.AutoSize = true;
            lblCustomerOrders.Location = new Point(665, 1037);
            lblCustomerOrders.Name = "lblCustomerOrders";
            lblCustomerOrders.Size = new Size(165, 20);
            lblCustomerOrders.TabIndex = 13;
            lblCustomerOrders.Text = "Customer Order History";
            // 
            // lblTotalRevenueValue
            // 
            lblTotalRevenueValue.AutoSize = true;
            lblTotalRevenueValue.Location = new Point(196, 45);
            lblTotalRevenueValue.Name = "lblTotalRevenueValue";
            lblTotalRevenueValue.Size = new Size(102, 20);
            lblTotalRevenueValue.TabIndex = 14;
            lblTotalRevenueValue.Text = "Total Revenue";
            // 
            // lblAverageOrderValue
            // 
            lblAverageOrderValue.AutoSize = true;
            lblAverageOrderValue.Location = new Point(196, 77);
            lblAverageOrderValue.Name = "lblAverageOrderValue";
            lblAverageOrderValue.Size = new Size(72, 20);
            lblAverageOrderValue.TabIndex = 15;
            lblAverageOrderValue.Text = "avg value";
            // 
            // chartTopSelling
            // 
            chartArea3.Name = "ChartArea1";
            chartTopSelling.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            chartTopSelling.Legends.Add(legend3);
            chartTopSelling.Location = new Point(1283, 613);
            chartTopSelling.Name = "chartTopSelling";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            chartTopSelling.Series.Add(series3);
            chartTopSelling.Size = new Size(504, 375);
            chartTopSelling.TabIndex = 16;
            chartTopSelling.Text = "chart1";
            // 
            // chartOrderStatus
            // 
            chartArea4.Name = "ChartArea1";
            chartOrderStatus.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            chartOrderStatus.Legends.Add(legend4);
            chartOrderStatus.Location = new Point(665, 613);
            chartOrderStatus.Name = "chartOrderStatus";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            chartOrderStatus.Series.Add(series4);
            chartOrderStatus.Size = new Size(557, 375);
            chartOrderStatus.TabIndex = 17;
            chartOrderStatus.Text = "chart1";
            // 
            // dgvCustomerOrders
            // 
            dgvCustomerOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomerOrders.Location = new Point(665, 1070);
            dgvCustomerOrders.Name = "dgvCustomerOrders";
            dgvCustomerOrders.RowHeadersWidth = 51;
            dgvCustomerOrders.Size = new Size(547, 356);
            dgvCustomerOrders.TabIndex = 18;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(6, 67);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(315, 27);
            txtUsername.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 44);
            label2.Name = "label2";
            label2.Size = new Size(185, 20);
            label2.TabIndex = 20;
            label2.Text = "Enter customer's username";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.Control;
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(dtpTo);
            groupBox2.Controls.Add(dtpFrom);
            groupBox2.Location = new Point(21, 18);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(351, 133);
            groupBox2.TabIndex = 21;
            groupBox2.TabStop = false;
            groupBox2.Text = "Select Date Range";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.Control;
            groupBox3.Controls.Add(txtUsername);
            groupBox3.Controls.Add(label2);
            groupBox3.Location = new Point(21, 172);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(351, 111);
            groupBox3.TabIndex = 22;
            groupBox3.TabStop = false;
            groupBox3.Text = "Select Customer (Optional)";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label14);
            groupBox4.Controls.Add(label13);
            groupBox4.Controls.Add(label8);
            groupBox4.Controls.Add(label9);
            groupBox4.Controls.Add(lblTotalRevenueValue);
            groupBox4.Controls.Add(lblAverageOrderValue);
            groupBox4.Location = new Point(41, 589);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(405, 125);
            groupBox4.TabIndex = 23;
            groupBox4.TabStop = false;
            groupBox4.Text = "Stats";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(315, 77);
            label14.Name = "label14";
            label14.Size = new Size(34, 20);
            label14.TabIndex = 29;
            label14.Text = "LKR";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(315, 45);
            label13.Name = "label13";
            label13.Size = new Size(34, 20);
            label13.TabIndex = 28;
            label13.Text = "LKR";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(21, 77);
            label8.Name = "label8";
            label8.Size = new Size(149, 20);
            label8.TabIndex = 26;
            label8.Text = "Average Order Value:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(21, 45);
            label9.Name = "label9";
            label9.Size = new Size(105, 20);
            label9.TabIndex = 27;
            label9.Text = "Total Revenue:";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox3);
            panel1.Controls.Add(btnGenerate);
            panel1.Location = new Point(41, 133);
            panel1.Name = "panel1";
            panel1.Size = new Size(405, 364);
            panel1.TabIndex = 24;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(41, 110);
            label7.Name = "label7";
            label7.Size = new Size(64, 20);
            label7.TabIndex = 25;
            label7.Text = "Controls";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(665, 580);
            label10.Name = "label10";
            label10.Size = new Size(130, 20);
            label10.TabIndex = 26;
            label10.Text = "Order Status Chart";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(1283, 580);
            label11.Name = "label11";
            label11.Size = new Size(144, 20);
            label11.TabIndex = 27;
            label11.Text = "Top Selling Products";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(1662, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(135, 29);
            btnExit.TabIndex = 28;
            btnExit.Text = "Exit Report";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(0, 1425);
            label12.Name = "label12";
            label12.Size = new Size(0, 20);
            label12.TabIndex = 29;
            // 
            // AdminReportsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1822, 909);
            Controls.Add(label12);
            Controls.Add(btnExit);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label7);
            Controls.Add(groupBox4);
            Controls.Add(dgvCustomerOrders);
            Controls.Add(chartOrderStatus);
            Controls.Add(chartTopSelling);
            Controls.Add(lblCustomerOrders);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(chartStock);
            Controls.Add(chartSales);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "AdminReportsForm";
            Text = "Reports";
            Load += AdminReportsForm_Load;
            ((System.ComponentModel.ISupportInitialize)chartSales).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartStock).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartTopSelling).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartOrderStatus).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCustomerOrders).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            panel1.ResumeLayout(false);
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
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Panel panel1;
        private Label label8;
        private Label label9;
        private Label label7;
        private Label label10;
        private Label label11;
        private Button btnExit;
        private Label label12;
        private Label label13;
        private Label label14;
    }
}