
using System;
using System.Collections.Generic;
using System.Text;

namespace Katas.Katas._8kyu.DecibelScale
{
    public static class DecibelScale

    {
        public static double DbScale(double intensity)
        {
            return Math.Log10((intensity/Math.Pow(10, -12))); ;
        }
    }
}
