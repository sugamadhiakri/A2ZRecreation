
namespace A2ZRecreation
{
    partial class ReportUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.TicketsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.DailyChartButton = new System.Windows.Forms.Button();
            this.WeeklyChartButton = new System.Windows.Forms.Button();
            this.visitorsLabel = new System.Windows.Forms.Label();
            this.incomeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TicketsChart)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(256, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Report User Control";
            // 
            // TicketsChart
            // 
            chartArea1.Name = "ChartArea1";
            this.TicketsChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.TicketsChart.Legends.Add(legend1);
            this.TicketsChart.Location = new System.Drawing.Point(3, 100);
            this.TicketsChart.Name = "TicketsChart";
            this.TicketsChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.TicketsChart.Series.Add(series1);
            this.TicketsChart.Size = new System.Drawing.Size(589, 298);
            this.TicketsChart.TabIndex = 1;
            this.TicketsChart.Text = "chart1";
            // 
            // DailyChartButton
            // 
            this.DailyChartButton.Location = new System.Drawing.Point(49, 71);
            this.DailyChartButton.Name = "DailyChartButton";
            this.DailyChartButton.Size = new System.Drawing.Size(75, 23);
            this.DailyChartButton.TabIndex = 2;
            this.DailyChartButton.Text = "Daily";
            this.DailyChartButton.UseVisualStyleBackColor = true;
            this.DailyChartButton.Click += new System.EventHandler(this.DailyChartButton_Click);
            // 
            // WeeklyChartButton
            // 
            this.WeeklyChartButton.Location = new System.Drawing.Point(152, 71);
            this.WeeklyChartButton.Name = "WeeklyChartButton";
            this.WeeklyChartButton.Size = new System.Drawing.Size(75, 23);
            this.WeeklyChartButton.TabIndex = 3;
            this.WeeklyChartButton.Text = "Weekly";
            this.WeeklyChartButton.UseVisualStyleBackColor = true;
            this.WeeklyChartButton.Click += new System.EventHandler(this.WeeklyChartButton_Click);
            // 
            // visitorsLabel
            // 
            this.visitorsLabel.AutoSize = true;
            this.visitorsLabel.Location = new System.Drawing.Point(310, 76);
            this.visitorsLabel.Name = "visitorsLabel";
            this.visitorsLabel.Size = new System.Drawing.Size(73, 13);
            this.visitorsLabel.TabIndex = 4;
            this.visitorsLabel.Text = "Total Visitors: ";
            // 
            // incomeLabel
            // 
            this.incomeLabel.AutoSize = true;
            this.incomeLabel.Location = new System.Drawing.Point(447, 76);
            this.incomeLabel.Name = "incomeLabel";
            this.incomeLabel.Size = new System.Drawing.Size(75, 13);
            this.incomeLabel.TabIndex = 5;
            this.incomeLabel.Text = "Total Income: ";
            // 
            // ReportUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.incomeLabel);
            this.Controls.Add(this.visitorsLabel);
            this.Controls.Add(this.WeeklyChartButton);
            this.Controls.Add(this.DailyChartButton);
            this.Controls.Add(this.TicketsChart);
            this.Controls.Add(this.label1);
            this.Name = "ReportUserControl";
            this.Size = new System.Drawing.Size(595, 450);
            this.Load += new System.EventHandler(this.ReportUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TicketsChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart TicketsChart;
        private System.Windows.Forms.Button DailyChartButton;
        private System.Windows.Forms.Button WeeklyChartButton;
        private System.Windows.Forms.Label visitorsLabel;
        private System.Windows.Forms.Label incomeLabel;
    }
}
