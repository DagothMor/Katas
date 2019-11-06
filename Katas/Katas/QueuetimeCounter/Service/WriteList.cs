using System;
using System.Collections.Generic;
using System.Text;

namespace Katas.Katas.QueuetimeCounter.Service
{
    public static class WriteList
    {
        public static void Write(List<int> A)
        {
            for (int i = 0; i < A.Count; i++)
            {
                Console.Write(A[i]);
            }
            Console.WriteLine("");
        }
    }
}
