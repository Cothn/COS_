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
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.textBox_N = new System.Windows.Forms.TextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.calculate_button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.trackBar_N = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBar_SF = new System.Windows.Forms.TrackBar();
            this.textBox_SF = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.trackBar_HF = new System.Windows.Forms.TrackBar();
            this.textBox_HF = new System.Windows.Forms.TextBox();
            this.checkBox_FFT = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize) (this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.chart3)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.trackBar_N)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.trackBar_SF)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.trackBar_HF)).BeginInit();
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
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(148, 12);
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
            this.textBox_N.Location = new System.Drawing.Point(26, 78);
            this.textBox_N.Name = "textBox_N";
            this.textBox_N.ReadOnly = true;
            this.textBox_N.Size = new System.Drawing.Size(116, 23);
            this.textBox_N.TabIndex = 5;
            this.textBox_N.Text = "128";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(148, 37);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(142, 19);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Полигармонический";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_Checked);
            // 
            // calculate_button
            // 
            this.calculate_button.Location = new System.Drawing.Point(5, 107);
            this.calculate_button.Name = "calculate_button";
            this.calculate_button.Size = new System.Drawing.Size(285, 33);
            this.calculate_button.TabIndex = 6;
            this.calculate_button.Text = "Calculate";
            this.calculate_button.UseVisualStyleBackColor = true;
            this.calculate_button.Click += new System.EventHandler(this.calculate_button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.checkBox_FFT);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.trackBar_N);
            this.groupBox1.Controls.Add(this.calculate_button);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.textBox_N);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(464, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 148);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сигнал";
            // 
            // trackBar_N
            // 
            this.trackBar_N.Location = new System.Drawing.Point(6, 23);
            this.trackBar_N.Minimum = 5;
            this.trackBar_N.Name = "trackBar_N";
            this.trackBar_N.Size = new System.Drawing.Size(136, 45);
            this.trackBar_N.TabIndex = 5;
            this.trackBar_N.Value = 7;
            this.trackBar_N.Scroll += new System.EventHandler(this.trackBar_N_Scroll);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "N:";
            // 
            // checkBox1
            // 
            this.checkBox1.Location = new System.Drawing.Point(148, 62);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(142, 18);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Отоброжать точки";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.trackBar_SF);
            this.groupBox2.Controls.Add(this.textBox_SF);
            this.groupBox2.Location = new System.Drawing.Point(464, 177);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(304, 107);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Фильтр нижних частот";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(21, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "частота фильтрации";
            // 
            // trackBar_SF
            // 
            this.trackBar_SF.Enabled = false;
            this.trackBar_SF.Location = new System.Drawing.Point(6, 23);
            this.trackBar_SF.Maximum = 2;
            this.trackBar_SF.Minimum = 1;
            this.trackBar_SF.Name = "trackBar_SF";
            this.trackBar_SF.Size = new System.Drawing.Size(284, 45);
            this.trackBar_SF.TabIndex = 0;
            this.trackBar_SF.Value = 2;
            this.trackBar_SF.Scroll += new System.EventHandler(this.trackBar_SF_Scroll);
            // 
            // textBox_SF
            // 
            this.textBox_SF.Location = new System.Drawing.Point(148, 71);
            this.textBox_SF.Name = "textBox_SF";
            this.textBox_SF.ReadOnly = true;
            this.textBox_SF.Size = new System.Drawing.Size(124, 23);
            this.textBox_SF.TabIndex = 5;
            this.textBox_SF.Text = "2";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.trackBar_HF);
            this.groupBox3.Controls.Add(this.textBox_HF);
            this.groupBox3.Location = new System.Drawing.Point(464, 290);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(304, 107);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Фильтр верхних частот";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(21, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "частота фильтрации";
            // 
            // trackBar_HF
            // 
            this.trackBar_HF.Enabled = false;
            this.trackBar_HF.Location = new System.Drawing.Point(6, 23);
            this.trackBar_HF.Maximum = 1;
            this.trackBar_HF.Name = "trackBar_HF";
            this.trackBar_HF.Size = new System.Drawing.Size(284, 45);
            this.trackBar_HF.TabIndex = 0;
            this.trackBar_HF.Scroll += new System.EventHandler(this.trackBar_HF_Scroll);
            // 
            // textBox_HF
            // 
            this.textBox_HF.Location = new System.Drawing.Point(148, 71);
            this.textBox_HF.Name = "textBox_HF";
            this.textBox_HF.ReadOnly = true;
            this.textBox_HF.Size = new System.Drawing.Size(124, 23);
            this.textBox_HF.TabIndex = 5;
            this.textBox_HF.Text = "0";
            // 
            // checkBox_FFT
            // 
            this.checkBox_FFT.Location = new System.Drawing.Point(148, 83);
            this.checkBox_FFT.Name = "checkBox_FFT";
            this.checkBox_FFT.Size = new System.Drawing.Size(142, 18);
            this.checkBox_FFT.TabIndex = 9;
            this.checkBox_FFT.Text = "БПФ";
            this.checkBox_FFT.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 455);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
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
            ((System.ComponentModel.ISupportInitialize) (this.trackBar_N)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.trackBar_SF)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.trackBar_HF)).EndInit();
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
        private System.Windows.Forms.TrackBar trackBar_N;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TrackBar trackBar_SF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox_HF;
        private System.Windows.Forms.TrackBar trackBar_HF;
        private System.Windows.Forms.TextBox textBox_SF;
        private System.Windows.Forms.CheckBox checkBox_FFT;
    }
}

