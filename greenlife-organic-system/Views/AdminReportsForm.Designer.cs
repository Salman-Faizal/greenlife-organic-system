namespace greenlife_organic_system.Views
{
    public partial class AdminReportsForm : Form
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
            ((System.ComponentModel.ISupportInitialize)chartSales).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartStock).BeginInit();
            groupBox1.SuspendLayout();
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
            chartStock.Click += chartStock_Click;
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
            label4.Click += label4_Click;
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
            // AdminReportsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1399, 721);
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
            Text = "Admin Reports";
            Load += AdminReportsForm_Load;
            ((System.ComponentModel.ISupportInitialize)chartSales).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartStock).EndInit();
            groupBox1.ResumeLayout(false);
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
    }
}