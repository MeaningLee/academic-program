﻿namespace CuoiKi
{
    partial class formStatistical
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
            this.btn_dt_nam = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_doanhthu_thang = new System.Windows.Forms.Button();
            this.cbx_nam = new System.Windows.Forms.ComboBox();
            this.cbx_yeucau = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbx_thang = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Bottom;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 111);
            this.chart1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Doanh thu";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(744, 319);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // btn_dt_nam
            // 
            this.btn_dt_nam.Location = new System.Drawing.Point(184, 29);
            this.btn_dt_nam.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_dt_nam.Name = "btn_dt_nam";
            this.btn_dt_nam.Size = new System.Drawing.Size(158, 22);
            this.btn_dt_nam.TabIndex = 1;
            this.btn_dt_nam.Text = "Theo năm";
            this.btn_dt_nam.UseVisualStyleBackColor = true;
            this.btn_dt_nam.Click += new System.EventHandler(this.btn_dt_nam_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(648, 32);
            this.btn_back.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(96, 29);
            this.btn_back.TabIndex = 3;
            this.btn_back.Text = "Trở về";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_doanhthu_thang
            // 
            this.btn_doanhthu_thang.Location = new System.Drawing.Point(376, 29);
            this.btn_doanhthu_thang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_doanhthu_thang.Name = "btn_doanhthu_thang";
            this.btn_doanhthu_thang.Size = new System.Drawing.Size(162, 22);
            this.btn_doanhthu_thang.TabIndex = 4;
            this.btn_doanhthu_thang.Text = "Theo tháng";
            this.btn_doanhthu_thang.UseVisualStyleBackColor = true;
            this.btn_doanhthu_thang.Click += new System.EventHandler(this.btn_doanhthu_thang_Click);
            // 
            // cbx_nam
            // 
            this.cbx_nam.FormattingEnabled = true;
            this.cbx_nam.Location = new System.Drawing.Point(224, 2);
            this.cbx_nam.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbx_nam.Name = "cbx_nam";
            this.cbx_nam.Size = new System.Drawing.Size(120, 21);
            this.cbx_nam.TabIndex = 5;
            this.cbx_nam.SelectedIndexChanged += new System.EventHandler(this.cbx_nam_SelectedIndexChanged);
            // 
            // cbx_yeucau
            // 
            this.cbx_yeucau.FormattingEnabled = true;
            this.cbx_yeucau.Items.AddRange(new object[] {
            "Doanh thu",
            "Hàng hóa"});
            this.cbx_yeucau.Location = new System.Drawing.Point(16, 27);
            this.cbx_yeucau.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbx_yeucau.Name = "cbx_yeucau";
            this.cbx_yeucau.Size = new System.Drawing.Size(126, 21);
            this.cbx_yeucau.TabIndex = 6;
            this.cbx_yeucau.SelectedIndexChanged += new System.EventHandler(this.cbx_yeucau_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(182, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Năm: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Aqua;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(16, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Chọn yêu cầu\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(374, 7);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tháng: ";
            // 
            // cbx_thang
            // 
            this.cbx_thang.Enabled = false;
            this.cbx_thang.FormattingEnabled = true;
            this.cbx_thang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbx_thang.Location = new System.Drawing.Point(433, 5);
            this.cbx_thang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbx_thang.Name = "cbx_thang";
            this.cbx_thang.Size = new System.Drawing.Size(105, 21);
            this.cbx_thang.TabIndex = 10;
            // 
            // formStatistical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(744, 430);
            this.Controls.Add(this.cbx_thang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbx_yeucau);
            this.Controls.Add(this.cbx_nam);
            this.Controls.Add(this.btn_doanhthu_thang);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_dt_nam);
            this.Controls.Add(this.chart1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "formStatistical";
            this.Text = "ThongKe";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ThongKe_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ThongKe_FormClosed);
            this.Load += new System.EventHandler(this.ThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btn_dt_nam;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_doanhthu_thang;
        private System.Windows.Forms.ComboBox cbx_nam;
        private System.Windows.Forms.ComboBox cbx_yeucau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbx_thang;
    }
}