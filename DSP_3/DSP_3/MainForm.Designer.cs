﻿namespace DSP_3
{
    partial class MainForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 =
                new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 =
                new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 =
                new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.textBox_N = new System.Windows.Forms.TextBox();
            this.calculate_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.chart3)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.Anchor = System.Windows.Forms.AnchorStyles.None;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(14, 14);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(421, 134);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            this.chart2.Anchor = System.Windows.Forms.AnchorStyles.None;
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            this.chart2.Location = new System.Drawing.Point(14, 157);
            this.chart2.Name = "chart2";
            this.chart2.Size = new System.Drawing.Size(421, 143);
            this.chart2.TabIndex = 2;
            this.chart2.Text = "chart2";
            // 
            // chart3
            // 
            this.chart3.Anchor = System.Windows.Forms.AnchorStyles.None;
            chartArea3.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea3);
            this.chart3.Location = new System.Drawing.Point(14, 307);
            this.chart3.Name = "chart3";
            this.chart3.Size = new System.Drawing.Size(421, 134);
            this.chart3.TabIndex = 3;
            this.chart3.Text = "chart3";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.calculate_button);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.textBox_N);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(603, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(160, 144);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сигнал";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(7, 48);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(142, 19);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Полигармонический";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_Checked);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 22);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(113, 19);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Гармонический";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_Checked);
            // 
            // textBox_N
            // 
            this.textBox_N.Location = new System.Drawing.Point(8, 73);
            this.textBox_N.Name = "textBox_N";
            this.textBox_N.Size = new System.Drawing.Size(146, 23);
            this.textBox_N.TabIndex = 5;
            this.textBox_N.Text = "128";
            // 
            // calculate_button
            // 
            this.calculate_button.Location = new System.Drawing.Point(7, 101);
            this.calculate_button.Name = "calculate_button";
            this.calculate_button.Size = new System.Drawing.Size(147, 33);
            this.calculate_button.TabIndex = 6;
            this.calculate_button.Text = "Calculate";
            this.calculate_button.UseVisualStyleBackColor = true;
            this.calculate_button.Click += new System.EventHandler(this.calculate_button_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 455);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chart3);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Name = "MainForm";
            this.Text = "Дискретное преобразование Фурье";
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            ((System.ComponentModel.ISupportInitialize) (this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.chart3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox textBox_N;
        private System.Windows.Forms.Button calculate_button;
    }
}
