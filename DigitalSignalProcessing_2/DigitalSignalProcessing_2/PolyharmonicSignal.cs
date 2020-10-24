using System;

namespace DigitalSignalProcessing_2
{
    internal class PolyharmonicSignal
    {
        public int N { get; set;  }
        public double Phi { get; set; }
        public int K { get; set; }
        public int End { get; set; }

        public double[] SKZ_1 { get; set; }
        public double[] SKZ_2 { get; set; }
        public double[] Amplitudes { get; set; }
        public double[] errorsSKZ_1 { get; set; }
        public double[] errorsSKZ_2 { get; set; }
        public double[] errorsAmplitudes { get; set; }

        public PolyharmonicSignal(int n, double phi = 0.0)
        {

            N = n;
            Phi = phi;

            K = (3 * N) / 4;
            End = 2 * N;

            SKZ_1 = new double[End - K + 1];
            SKZ_2 = new double[End - K + 1];
            Amplitudes = new double[End - K + 1];
            errorsSKZ_1 = new double[End - K + 1];
            errorsSKZ_2 = new double[End - K + 1];
            errorsAmplitudes = new double[End - K + 1];
        }

        public void CountAll()
        {
            double skz1;
            double skz2;
            double point;

            for (int m = K; m <= End; m++)
            {
                skz1 = 0;
                skz2 = 0;

                double sineSp = 0;
                double cosineSp = 0;
                for (int j = 0; j <= m; j++)
                {
                    point = CountPolyharmonicSignal(N, j, Phi);
                    skz1 += Math.Pow(point, 2);
                    skz2 += point;
                    
                    cosineSp += point * Math.Cos(2 * Math.PI * j / (N));
                    sineSp += point * Math.Sin(2 * Math.PI * j / (N));
                }
                
                sineSp = 2 * sineSp / (m);
                cosineSp = 2 * cosineSp / (m);
                SKZ_1[m - K] = Math.Sqrt(skz1 / (m + 1));
                SKZ_2[m - K] = Math.Sqrt((skz1 / (m + 1)) - Math.Pow(skz2 / (m + 1), 2));

                
                Amplitudes[m-K] = Math.Sqrt(Math.Pow(sineSp, 2) + Math.Pow(cosineSp, 2));
                errorsAmplitudes[m-K] = 1 - Amplitudes[m-K];

                errorsSKZ_1[m - K] = 0.707 - SKZ_1[m - K];
                errorsSKZ_2[m - K] = 0.707 - SKZ_2[m - K];
            }
        }




        public double CountPolyharmonicSignal(int n, int iteration, double phi)
        {

          return  Math.Sin((2 * Math.PI * iteration ) / n + phi);
        }
    }
}
