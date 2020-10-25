using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DSP_3
{
    class HarmonicSignal:Signal
    {
        double A;
        public HarmonicSignal(double amplitude, int discrPoints)
        {
            A = amplitude;
            n = discrPoints;
            countFrequency = 2;
            sineTable = GetSineTable();
            signal = GenerateSignal();
            sineSp = GetSineSpectrum();
            cosineSp = GetCosineSpectrum();
            amplSp = GetAmplSpectrum();
            phaseSp = GetPhaseSpectrum();
            restSignal = RestoreSignal();
            nfSignal = RestoreNFSignal();
        }

        internal override double[] GenerateSignal()
        {
            double[] sign = new double[n];
            for (int i = 0; i <= n - 1; i++)
            {
                sign[i] = A * Math.Cos(2 * Math.PI * i / n);
            }
            return sign;
        }
        
    }
}
