using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DSP_3
{
    public partial class MainForm : Form
    {
        Series DataSer_1, DataSer_2, DataSer_3, 
            DataSer_4, DataSer_5, DataSer_6, 
            DataSer_7, DataSer_8, DataSer_9, DataSer_10;
        enum SignalType { Harmonic,Polyharmonic}

        public MainForm()
        {
            InitializeComponent();
            chart1.SetBounds(10, 10, this.Size.Width - 300, (this.Size.Height - 70) / 3);
            chart2.SetBounds(10, (this.Size.Height - 70) / 3 + 20, this.Size.Width - 300, (this.Size.Height - 70) / 3);
            chart3.SetBounds(10, 2 * (this.Size.Height - 70) / 3 + 30, this.Size.Width - 300, (this.Size.Height - 70) / 3);
            chart1.ChartAreas[0].AxisX.LabelStyle.Format = "0:0.000";

            Calculate(SignalType.Harmonic, int.Parse(textBox_N.Text), checkBox_FFT.Checked);
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            chart1.SetBounds(10, 10, this.Size.Width - 300, (this.Size.Height - 70) / 3);
            chart2.SetBounds(10,(this.Size.Height - 70) / 3+20,this.Size.Width - 300, (this.Size.Height - 70) / 3);
            chart3.SetBounds(10, 2*(this.Size.Height - 70) / 3 + 30, this.Size.Width - 300, (this.Size.Height - 70) / 3);
            chart1.ChartAreas[0].AxisX.LabelStyle.Format = "0.000";
        }

        private void Calculate(SignalType st, int N, bool fft_flag, int Hf = 0, int Sf = 2049)
        {
            Signal  hs;
            double[] A = new double[7] { 1, 3, 5, 8, 10, 12, 16 };
            double[] ph = new double[6] { Math.PI / 6, Math.PI / 4, Math.PI / 3, Math.PI / 2, Math.PI, 3 * Math.PI / 4 };

            if (st == SignalType.Harmonic)
            {
                hs = new HarmonicSignal(10, N);
            }
            else
            {
                hs = new PolyharmonicSignal(A,ph, N, fft_flag);
                hs.FilterHF(Hf);
                hs.FilterSF(Sf);
                
            }
            chart1.Series.Clear();
            chart1.Legends.Clear();
            DataSer_1 = new Series();
            Legend l1 = new Legend();
            chart1.Legends.Add(l1);
            l1.Title = "Сигналы";
            DataSer_1.ChartType = SeriesChartType.Spline;
            DataSer_1.Color = Color.Red;
            DataSer_1.Name = "Исходный сигнал";
            DataSer_4 = new Series();
            DataSer_4.ChartType = SeriesChartType.Spline;
            DataSer_4.Color = Color.Blue;
            DataSer_4.Name = "Восстановленный\r\n сигнал";
            
            if (st != SignalType.Harmonic)
            {
                DataSer_5 = new Series();
                DataSer_5.ChartType = SeriesChartType.Spline;
                DataSer_5.Color = Color.Green;
                DataSer_5.Name = "Восстановленный \r\nсигнал без \r\nучета фазы";
            }

            for (int i = 1; i <= N-1; i++)
            {
                DataSer_1.Points.AddXY(2 * Math.PI * i / N, hs.signVal[i]);
                DataSer_4.Points.AddXY(2 * Math.PI * i / N, hs.restoredSignal[i]);
                if (st != SignalType.Harmonic)
                {
                    DataSer_5.Points.AddXY(2 * Math.PI * i / N, hs.restorednonphasedSignal[i]);
                }
            }
            
            chart1.ResetAutoValues();
            chart1.Series.Add(DataSer_1); 
            chart1.Series.Add(DataSer_4);
            if (st != SignalType.Harmonic)
            {
                chart1.Series.Add(DataSer_5);
            }

            chart2.Series.Clear();
            chart3.Series.Clear();
            chart2.Legends.Clear();
            chart3.Legends.Clear();
            Legend l2 = new Legend();
            chart2.Legends.Add(l2);
            Legend l3 = new Legend();
            chart3.Legends.Add(l3);
            DataSer_2 = new Series();
            DataSer_2.ChartType = SeriesChartType.Candlestick;
            DataSer_2.Color = Color.Blue;
            DataSer_2.Name = "Фазовый спектр";
            DataSer_3 = new Series();
            DataSer_3.ChartType = SeriesChartType.Candlestick;
            DataSer_3.Color = Color.Blue;
            DataSer_3.Name = "Амплитудный спектр";
            
            DataSer_6 = new Series();
            DataSer_6.ChartType = SeriesChartType.Candlestick;
            DataSer_6.Color = Color.Red;
            DataSer_6.Name = "Амплитуда реальной\r\n(косинусной) составляющей";
            DataSer_7 = new Series();
            DataSer_7.ChartType = SeriesChartType.Candlestick;
            DataSer_7.Color = Color.Green;
            DataSer_7.Name = "Амплитуда мнимой\r\n(синусной) составляющей";
            DataSer_8 = new Series();
            DataSer_8.ChartType = SeriesChartType.Point;
            DataSer_8.Color = Color.Red;
            DataSer_8.IsVisibleInLegend = false;
            DataSer_9 = new Series();
            DataSer_9.ChartType = SeriesChartType.Point;
            DataSer_9.Color = Color.Green;
            DataSer_9.IsVisibleInLegend = false;
            DataSer_10 = new Series();
            DataSer_10.ChartType = SeriesChartType.Point;
            DataSer_10.Color = Color.Blue;
            DataSer_10.IsVisibleInLegend = false;


            for (int j = 1; j <= hs.countFrequency - 1; j++)
            {
                DataSer_2.Points.AddXY(j, hs.phaseSp[j]);
                DataSer_3.Points.AddXY(j, hs.amplSp[j]);
                DataSer_10.Points.AddXY(j, hs.amplSp[j]);

                DataSer_7.Points.AddXY(j, hs.sineSp[j]);
                DataSer_6.Points.AddXY(j, hs.cosineSp[j]);
                DataSer_9.Points.AddXY(j, hs.sineSp[j]);
                DataSer_8.Points.AddXY(j, hs.cosineSp[j]);

            }

            chart2.ResetAutoValues();
            chart2.Series.Add(DataSer_2);
            chart3.ResetAutoValues();

            
            chart3.Series.Add(DataSer_7);
            chart3.Series.Add(DataSer_6);
            
            chart3.Series.Add(DataSer_3);

            
            //точки
            if (checkBox1.Checked)
            {
                chart3.Series.Add(DataSer_8);
                chart3.Series.Add(DataSer_9);
                chart3.Series.Add(DataSer_10);
            }

        }

        private void initializeFilters()
        {
            trackBar_HF.Enabled = true;
            trackBar_SF.Enabled = true;
            textBox_N.Text = Math.Pow(2, trackBar_N.Value).ToString();
            trackBar_HF.Maximum = int.Parse(textBox_N.Text)/2;
            trackBar_SF.Maximum  = int.Parse(textBox_N.Text)/2+1;
            trackBar_HF.Minimum = 0;
            trackBar_SF.Minimum = 1;
            
            trackBar_HF.Value = trackBar_HF.Minimum;
            trackBar_SF.Value = trackBar_SF.Maximum;
            textBox_SF.Text =  trackBar_SF.Value.ToString();
            textBox_HF.Text =  trackBar_HF.Value.ToString();
        }
        private void radioButton1_Checked(object sender, EventArgs e)
        {
            trackBar_HF.Enabled = false;
            trackBar_SF.Enabled = false;
            Calculate(SignalType.Harmonic,int.Parse(textBox_N.Text), checkBox_FFT.Checked);
        }

        private void radioButton2_Checked(object sender, EventArgs e)
        {
            initializeFilters();
            Calculate(SignalType.Polyharmonic,  int.Parse(textBox_N.Text), checkBox_FFT.Checked);
        }
        
        private void trackBar_N_Scroll(object sender, EventArgs e)
        {
            textBox_N.Text = Math.Pow(2, trackBar_N.Value).ToString();
            initializeFilters();
            calculate_button_Click(sender, e);
        }
        
        private void calculate_button_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {

                Calculate(SignalType.Harmonic, int.Parse(textBox_N.Text), checkBox_FFT.Checked);
            }
            else
            {
                Calculate(SignalType.Polyharmonic,  int.Parse(textBox_N.Text), checkBox_FFT.Checked,
                    int.Parse(textBox_HF.Text), int.Parse(textBox_SF.Text));
            }
        }


        private void trackBar_SF_Scroll(object sender, EventArgs e)
        {
            trackBar_HF.Maximum = trackBar_SF.Value-1;
            textBox_SF.Text =  trackBar_SF.Value.ToString();
            calculate_button_Click(sender, e);
        }

        private void trackBar_HF_Scroll(object sender, EventArgs e)
        {
            trackBar_SF.Minimum = trackBar_HF.Value+1;
            textBox_HF.Text = trackBar_HF.Value.ToString();
            calculate_button_Click(sender, e);
        }
        
    }
}
