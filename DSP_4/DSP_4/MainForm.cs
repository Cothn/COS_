using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DSP_4
{
    public partial class MainForm : Form
    {
        Series DataSer_1, DataSer_2, DataSer_3, DataSer_4, DataSer_5, DataSer_6;
        

        public MainForm()
        {
            InitializeComponent();
            chart1.SetBounds(10, 10, this.Size.Width - 200, (this.Size.Height - 70) / 3);
            chart2.SetBounds(10, (this.Size.Height - 70) / 3 + 20, this.Size.Width - 200, (this.Size.Height - 70) / 3);
            chart3.SetBounds(10, 2 * (this.Size.Height - 70) / 3 + 30, this.Size.Width - 200, (this.Size.Height - 70) / 3);
            Calculate(1,NoisySignal.FilteringType.Parabolic);
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            chart1.SetBounds(10, 10, this.Size.Width - 200, (this.Size.Height - 70) / 3);
            chart2.SetBounds(10,(this.Size.Height - 70) / 3+20,this.Size.Width - 200, (this.Size.Height - 70) / 3);
            chart3.SetBounds(10, 2*(this.Size.Height - 70) / 3 + 30, this.Size.Width - 200, (this.Size.Height - 70) / 3);
        }

        private void Calculate(int freq, NoisySignal.FilteringType ft)
        {
            NoisySignal hs = new NoisySignal(10, freq, 0, 360);
            double[] fs=null;
            switch (ft)
            {
                case NoisySignal.FilteringType.Parabolic:
                    fs = hs.ps;
                    break;
                case NoisySignal.FilteringType.Median:
                    fs = hs.ms;
                    break;
                case NoisySignal.FilteringType.Sliding:
                    fs = hs.ss;
                    break;
                default:
                    break;
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
            DataSer_2 = new Series();
            DataSer_2.ChartType = SeriesChartType.Spline;
            DataSer_2.Color = Color.Blue;
            DataSer_2.Name = "Cглаженный сигнал";
            for (int i = 0; i <= 359; i++)
            {
                DataSer_1.Points.AddXY(2 * Math.PI * i / 360, hs.signVal[i]);
                DataSer_2.Points.AddXY(2 * Math.PI * i / 360, fs[i]);
            }
            chart1.ResetAutoValues();
            chart1.Series.Add(DataSer_1);
            chart1.Series.Add(DataSer_2);
            hs.Operate(ft);
            chart2.Series.Clear();
            chart3.Series.Clear();
            chart2.Legends.Clear();
            chart3.Legends.Clear();
            Legend l2 = new Legend();
            chart2.Legends.Add(l2);
            l2.Title = "Фазовый спектр";
            Legend l3 = new Legend();
            chart3.Legends.Add(l3);
            l3.Title = "Амплитудный спектр";
            DataSer_3 = new Series();
            DataSer_3.ChartType = SeriesChartType.Candlestick;
            DataSer_3.Color = Color.Red;
            DataSer_3.Name = "Исходный сигнал";
            DataSer_4 = new Series();
            DataSer_4.ChartType = SeriesChartType.Candlestick;
            DataSer_4.Color = Color.Green;
            DataSer_4.Name = "Исходный сигнал";
            DataSer_5 = new Series();
            DataSer_5.ChartType = SeriesChartType.Candlestick;
            DataSer_5.Color = Color.Aqua;
            DataSer_5.Name = "Сглаженный сигнал";
            DataSer_6 = new Series();
            DataSer_6.ChartType = SeriesChartType.Candlestick;
            DataSer_6.Color = Color.Cyan;
            DataSer_6.Name = "Сглаженный сигнал";
            for (int i = 0; i <= 49; i++)
            {
                DataSer_3.Points.AddXY(i, hs.phaseSp[i]);
                DataSer_4.Points.AddXY(i, hs.amplSp[i]);
                DataSer_5.Points.AddXY(i, hs.psp[i]);
                DataSer_6.Points.AddXY(i, hs.asp[i]);
            }
            chart2.ResetAutoValues();
            chart2.Series.Add(DataSer_3);
            chart2.Series.Add(DataSer_5);
            chart3.ResetAutoValues();
            chart3.Series.Add(DataSer_4);
            chart3.Series.Add(DataSer_6);
        }

        private void radioButton1_Checked(object sender, EventArgs e)
        {
            Calculate(1, NoisySignal.FilteringType.Parabolic);
        }

        private void radioButton2_Checked(object sender, EventArgs e)
        {
            Calculate(1, NoisySignal.FilteringType.Median);
        }

        private void radioButton3_Checked(object sender, EventArgs e)
        {
            Calculate(1, NoisySignal.FilteringType.Sliding);
        }
    }
}
