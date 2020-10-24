namespace DigitalSignalProcessing_2
{
    partial class FMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 =
                new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 =
                new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 =
                new System.Windows.Forms.DataVisualization.Charting.Series();
            this.CMain = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.TBn = new System.Windows.Forms.TextBox();
            this.Ln = new System.Windows.Forms.Label();
            this.Lphi = new System.Windows.Forms.Label();
            this.TBphi = new System.Windows.Forms.TextBox();
            this.Bcount = new System.Windows.Forms.Button();
            this.CB1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize) (this.CMain)).BeginInit();
            this.SuspendLayout();
            // 
            // CMain
            // 
            chartArea1.Name = "ChartArea1";
            this.CMain.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.CMain.Legends.Add(legend1);
            this.CMain.Location = new System.Drawing.Point(216, 14);
            this.CMain.Name = "CMain";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.CMain.Series.Add(series1);
            this.CMain.Size = new System.Drawing.Size(1123, 685);
            this.CMain.TabIndex = 0;
            this.CMain.Text = "chart1";
            // 
            // TBn
            // 
            this.TBn.Location = new System.Drawing.Point(54, 14);
            this.TBn.Name = "TBn";
            this.TBn.Size = new System.Drawing.Size(154, 23);
            this.TBn.TabIndex = 1;
            this.TBn.Text = "1024";
            // 
            // Ln
            // 
            this.Ln.AutoSize = true;
            this.Ln.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.Ln.Location = new System.Drawing.Point(28, 14);
            this.Ln.Name = "Ln";
            this.Ln.Size = new System.Drawing.Size(20, 20);
            this.Ln.TabIndex = 2;
            this.Ln.Text = "N";
            // 
            // Lphi
            // 
            this.Lphi.AutoSize = true;
            this.Lphi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.Lphi.Location = new System.Drawing.Point(28, 47);
            this.Lphi.Name = "Lphi";
            this.Lphi.Size = new System.Drawing.Size(18, 20);
            this.Lphi.TabIndex = 4;
            this.Lphi.Text = "φ";
            // 
            // TBphi
            // 
            this.TBphi.Location = new System.Drawing.Point(54, 48);
            this.TBphi.Name = "TBphi";
            this.TBphi.Size = new System.Drawing.Size(154, 23);
            this.TBphi.TabIndex = 3;
            this.TBphi.Text = "0,09817477";
            // 
            // Bcount
            // 
            this.Bcount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.Bcount.Location = new System.Drawing.Point(19, 84);
            this.Bcount.Name = "Bcount";
            this.Bcount.Size = new System.Drawing.Size(190, 51);
            this.Bcount.TabIndex = 5;
            this.Bcount.Text = "Старт!";
            this.Bcount.UseVisualStyleBackColor = true;
            this.Bcount.Click += new System.EventHandler(this.Bcount_Click);
            // 
            // CB1
            // 
            this.CB1.AutoSize = true;
            this.CB1.Checked = true;
            this.CB1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CB1.Location = new System.Drawing.Point(11, 53);
            this.CB1.Margin = new System.Windows.Forms.Padding(2);
            this.CB1.Name = "CB1";
            this.CB1.Size = new System.Drawing.Size(15, 14);
            this.CB1.TabIndex = 6;
            this.CB1.UseVisualStyleBackColor = true;
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 703);
            this.Controls.Add(this.CB1);
            this.Controls.Add(this.Bcount);
            this.Controls.Add(this.Lphi);
            this.Controls.Add(this.TBphi);
            this.Controls.Add(this.Ln);
            this.Controls.Add(this.TBn);
            this.Controls.Add(this.CMain);
            this.Name = "FMain";
            this.Text = "Laba 2";
            ((System.ComponentModel.ISupportInitialize) (this.CMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart CMain;
        private System.Windows.Forms.TextBox TBn;
        private System.Windows.Forms.Label Ln;
        private System.Windows.Forms.Label Lphi;
        private System.Windows.Forms.TextBox TBphi;
        private System.Windows.Forms.Button Bcount;
        private System.Windows.Forms.CheckBox CB1;
    }
}

