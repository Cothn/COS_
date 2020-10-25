using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace DSP_3
{
    class PolyharmonicSignal:Signal
    {
        double[] A, phi;
        private Complex[] complex_signal, specter;
        public PolyharmonicSignal(double[] amplitudes, double[] phases, int discrPoints, bool fftActive = false)
        {
            fft_flag = fftActive;
            A = amplitudes;
            n = discrPoints;
            phi = phases;
            countFrequency = n/2;
            sineTable = GetSineTable();
            signal = GenerateSignal();
            if (!fft_flag)
            {
                sineSp = GetSineSpectrum();
                cosineSp = GetCosineSpectrum();
                amplSp = GetAmplSpectrum();
                phaseSp = GetPhaseSpectrum();
            }
            else
            {
                complex_signal = new Complex[n];
                for (int i = 0; i <= n - 1; i++)
                {
                    complex_signal[i] = signal[i];
                }
                
                
                //specter = Fft.DecimationInTime(complex_signal, true);
                specter = Fft.fft(complex_signal);

                //normalize specter
                for (var i = 0; i < n; i++)  
                {
                    specter[i] /= (countFrequency);

                }
                
                //get spectr
                amplSp = new double[countFrequency];
                phaseSp = new double[countFrequency];
                sineSp = new double[countFrequency];
                cosineSp = new double[countFrequency];
                for (var j = 0; j < countFrequency; j++)  
                {
                    amplSp[j] = specter[j].Magnitude;
                    phaseSp[j] = -specter[j].Phase;
                    sineSp[j] = -specter[j].Imaginary;
                    cosineSp[j] = specter[j].Real;
                }
                
                //Alternative restore
                restSignal = new double[n];
                specter = Fft.fft(specter);
                //specter = Fft.DecimationInTime(specter, true);
                for (var i = 0; i < n; i++)  
                {
                    restSignal [i] = specter[i].Imaginary/2;
                }

            }
            
            //restSignal = RestoreSignal();
            nfSignal = RestoreNFSignal();
            
        }

        internal override double[] GenerateSignal()
        {
            double[] sign = new double[n];
            Random rnd = new Random();
            for (int i = 0; i <= n - 1; i++)
            {
                double tm = 0;
                for (int j = 1; j <= 30; j++)
                {
                    tm += A[rnd.Next(7)] * Math.Cos(2 * Math.PI * j * i / n + phi[rnd.Next(6)]);
                }
                sign[i] = tm;
            }
            return sign;
        }
        

    }
}
