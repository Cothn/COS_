using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DigitalSignalProcessing_2
{
    public partial class FMain : Form
    {
        private const int _graphAmount = 6;

        private List<CheckBox> _checkBoxesDraw;
        private List<Color> _colors;
        private List<string> _graphLegend;
        public FMain()
        {
            InitializeComponent();
            InitializeVariables();
        }

        private void InitializeVariables()
        {
            

            _colors = new List<Color>()
            {
                Color.Purple,
                Color.Green,
                Color.Red,
                Color.Blue,
                Color.Brown,
                Color.DarkOrange
            };

            _graphLegend = new List<string>
            {
                "СКЗ", "СКО", "Амплитуда", "Погрешность СКЗ", "Погрешность СКО", "Погрешность амплитуды"
            };
        }

        private void Bcount_Click(object sender, EventArgs e)
        {
            CMain.Series.Clear();

            var n = int.Parse(TBn.Text);
            double phi =  0.0;

            if (CB1.Checked)
            {
                phi = double.Parse(TBphi.Text);
            }
            
            PolyharmonicSignal polyharmonicSignal = new PolyharmonicSignal(n, phi);
            polyharmonicSignal.CountAll();

            var serieses = new List<Series>();

            for (int i = 0; i < _graphAmount; i++)
            {
                var series = new Series()
                {
                    Name = _graphLegend[i],
                    Color = _colors[i],
                    IsVisibleInLegend = true,
                    IsXValueIndexed = true,
                    ChartType = SeriesChartType.Line
                };

                serieses.Add(series);
            }

            for (int i = 0; i <= polyharmonicSignal.End - polyharmonicSignal.K; i++)
            {
                serieses[0].Points.AddXY(i + polyharmonicSignal.K, polyharmonicSignal.SKZ_1[i]);
                serieses[1].Points.AddXY(i + polyharmonicSignal.K, polyharmonicSignal.SKZ_2[i]);
                serieses[2].Points.AddXY(i + polyharmonicSignal.K, polyharmonicSignal.Amplitudes[i]);
                serieses[3].Points.AddXY(i + polyharmonicSignal.K, polyharmonicSignal.errorsSKZ_1[i]);
                serieses[4].Points.AddXY(i + polyharmonicSignal.K, polyharmonicSignal.errorsSKZ_2[i]);
                serieses[5].Points.AddXY(i + polyharmonicSignal.K, polyharmonicSignal.errorsAmplitudes[i]);
            }

            CMain.ResetAutoValues();
            
            for (int i = 0; i < _graphAmount; i++)
            {

                    CMain.Series.Add(serieses[i]);
            }

            CMain.Invalidate();
        }

        private void AddPointToSeries(Series series, double x, double y)
        {
            series.Points.AddXY(x, y);
        }
    }
}
