﻿namespace WindowsFormsApp5
{
    partial class Form6
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
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.year1 = new System.Windows.Forms.TextBox();
            this.economyTrackbar = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.economyTrackbar)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(25, 12);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Economy";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(437, 300);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // year1
            // 
            this.year1.Location = new System.Drawing.Point(468, 22);
            this.year1.Name = "year1";
            this.year1.Size = new System.Drawing.Size(100, 20);
            this.year1.TabIndex = 1;
            this.year1.Text = "2010";
            // 
            // economyTrackbar
            // 
            this.economyTrackbar.Location = new System.Drawing.Point(468, 59);
            this.economyTrackbar.Maximum = 2014;
            this.economyTrackbar.Minimum = 2010;
            this.economyTrackbar.Name = "economyTrackbar";
            this.economyTrackbar.Size = new System.Drawing.Size(202, 45);
            this.economyTrackbar.TabIndex = 2;
            this.economyTrackbar.Value = 2010;
            this.economyTrackbar.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 360);
            this.Controls.Add(this.economyTrackbar);
            this.Controls.Add(this.year1);
            this.Controls.Add(this.chart1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form6";
            this.Text = "Form6";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.economyTrackbar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox year1;
        private System.Windows.Forms.TrackBar economyTrackbar;
    }
}