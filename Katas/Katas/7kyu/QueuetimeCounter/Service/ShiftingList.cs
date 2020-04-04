using System;
using System.Collections.Generic;
using System.Text;

namespace Katas.Katas.QueuetimeCounter.Service
{
    public static class ShiftingList
    {
        public static List<int> ShiftList(List<int> l)
        {
            int b = l.Count;

            List<int> listn = new List<int>(b);

            for (int i = 1; i < b; i++)
            {

                listn.Add(l[i]);

            }
            listn.Add(l[0]);
            return listn;
        }
    }
}
