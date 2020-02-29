using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Katas.Katas._8katas.GenerateRangeOfIntegers.Services
{
    public static class RangeArrayMaker
    {
        public static int[] Start(int min, int max,int step)
        {
            List<int> listout = new List<int>(){min};

            int addingnumber = min;

            while (listout[listout.Last()] != max)
            {
                if (listout.Last() + step > max)
                {
                    break;
                }
                addingnumber += step;
                listout.Add(addingnumber);
                
            }


            return listout.ToArray();
        }
    }
}
