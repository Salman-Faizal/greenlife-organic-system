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
            dtpFrom = new DateTimePicker();
            dtpTo = new DateTimePicker();
            btnGenerate = new Button();
            btnExport = new Button();
            chartSales = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chartStock = new System.Windows.Forms.DataVisualization.Charting.Chart();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)chartSales).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartStock).BeginInit();
            SuspendLayout();
            // 
            // dtpFrom
            // 
            dtpFrom.Location = new Point(-4, 39);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(250, 27);
            dtpFrom.TabIndex = 0;
            // 
            // dtpTo
            // 
            dtpTo.Location = new Point(267, 39);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(250, 27);
            dtpTo.TabIndex = 1;
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(46, 81);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(94, 29);
            btnGenerate.TabIndex = 2;
            btnGenerate.Text = "Generate Report";
            btnGenerate.UseVisualStyleBackColor = true;
            // 
            // btnExport
            // 
            btnExport.Location = new Point(679, 81);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(94, 29);
            btnExport.TabIndex = 3;
            btnExport.Text = "Export CSV";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // chartSales
            // 
            chartArea1.Name = "ChartArea1";
            chartSales.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartSales.Legends.Add(legend1);
            chartSales.Location = new Point(-4, 240);
            chartSales.Name = "chartSales";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartSales.Series.Add(series1);
            chartSales.Size = new Size(375, 375);
            chartSales.TabIndex = 4;
            chartSales.Text = "chart1";
            // 
            // chartStock
            // 
            chartArea2.Name = "ChartArea1";
            chartStock.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartStock.Legends.Add(legend2);
            chartStock.Location = new Point(452, 240);
            chartStock.Name = "chartStock";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartStock.Series.Add(series2);
            chartStock.Size = new Size(375, 375);
            chartStock.TabIndex = 5;
            chartStock.Text = "chart2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(118, 20);
            label1.TabIndex = 6;
            label1.Text = "Generate Report";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(707, 9);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 7;
            label2.Text = "Export CSV";
            // 
            // AdminReportsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1037, 657);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(chartStock);
            Controls.Add(chartSales);
            Controls.Add(btnExport);
            Controls.Add(btnGenerate);
            Controls.Add(dtpTo);
            Controls.Add(dtpFrom);
            Name = "AdminReportsForm";
            Text = "Admin Reports";
            Load += AdminReportsForm_Load;
            ((System.ComponentModel.ISupportInitialize)chartSales).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartStock).EndInit();
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
        private Label label2;
    }
}