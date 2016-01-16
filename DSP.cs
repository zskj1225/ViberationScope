using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using System.Numerics;

namespace ViberationScope
{
    class DSP
    {
        const double Pi = 3.1415927;
        public static Complex[] FFT(Complex[] inArr)
        {
            Complex[] retVal=new Complex[inArr.Length];
            if (inArr.Length == 1)
            {
                retVal[0] = inArr[0];
            }
            else if (inArr.Length % 2 == 0)
            {
                Complex[] oddHalf = new Complex[inArr.Length / 2];
                Complex[] evenHalf = new Complex[inArr.Length / 2];
                for (int i = 0; i < inArr.Length / 2; i++)
                {
                    oddHalf[i] = inArr[2 * i + 1];
                    evenHalf[i] = inArr[2 * i];
                }
                Complex[] oddFFT = FFT(oddHalf);
                Complex[] evenFFT = FFT(evenHalf);
                for (int i = 0; i < inArr.Length / 2; i++)
                {
                    Complex w=Complex.FromPolarCoordinates(1,-Pi*i/oddFFT.Length);
                    retVal[i] = oddFFT[i]+evenFFT[i]*w;
                    retVal[i + inArr.Length/2] = oddFFT[i]-evenFFT[i]*w;
                }
            }
            else
            {
            }
            return retVal;
        }
        public static Complex[] IFFT(Complex[] inArr)
        {
            Complex[] retVal = new Complex[inArr.Length];
            if (inArr.Length == 1)
            {
                retVal[0] = inArr[0];
            }
            else if (inArr.Length % 2 == 0)
            {
                Complex[] oddHalf = new Complex[inArr.Length / 2];
                Complex[] evenHalf = new Complex[inArr.Length / 2];
                for (int i = 0; i < inArr.Length / 2; i++)
                {
                    oddHalf[i] = inArr[2 * i + 1];
                    evenHalf[i] = inArr[2 * i];
                }
                Complex[] oddIFFT = IFFT(oddHalf);
                Complex[] evenIFFT = IFFT(evenHalf);
                for (int i = 0; i < inArr.Length / 2; i++)
                {
                    Complex w = Complex.FromPolarCoordinates(1, Pi * i / oddIFFT.Length);
                    retVal[i] = (oddIFFT[i] + evenIFFT[i] * w)/2;
                    retVal[i + inArr.Length / 2] = (oddIFFT[i] - evenIFFT[i] * w)/2;
                }
            }
            else
            {
            }
            return retVal;
        }

        public static double oneScan=0.1;
        public static double allScan=0.1;
        public static Complex[] FreqSwipe(Complex[] inArr)
        {
            Complex[] retVal = new Complex[inArr.Length];
            for (int i = 0; i < inArr.Length; i++)
            {
                for (int j = 0; j < inArr.Length; j++)
                {
                    retVal[i] = retVal[i] + inArr[j] * Complex.FromPolarCoordinates(1, allScan*i*j/inArr.Length + j * j *oneScan/inArr.Length);
                }
            }
            return retVal;
        }

    }
}
