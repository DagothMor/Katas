using System;
using System.Collections.Generic;
using System.Text;

namespace Katas.Katas.ListShift
{
    public static class ShiftList
    {
        public static List<int> Right(List<int> list)
        {
            int b = list.Count;

            List<int> listn = new List<int>(b);

            listn.Add(list[b - 1]);

            for (int i = 0; i < b - 1; i++)
            {
                listn.Add(list[i]);
            }

            return listn;
        }

        public static List<int> Left(List<int> list)
        {
            int b = list.Count;

            List<int> listn = new List<int>(b);

            for (int i = 1; i < b; i++)
            {
               
                listn.Add(list[i]);

            }
            listn.Add(list[0]);
            return listn;
        }

    }
}
