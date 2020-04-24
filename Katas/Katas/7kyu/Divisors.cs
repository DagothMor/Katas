using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace Katas.Katas._7kyu
{
    public static class Divisors
    {
        static private Stopwatch _stopwatch = new Stopwatch();
        public static int[] divisors(int n)
        {
            _stopwatch.Start();
            List<int> list = new List<int>();
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0) { list.Add(i); }
            }
            _stopwatch.Stop();
            Console.WriteLine(_stopwatch.ElapsedMilliseconds);
            return list.Count == 0 ? null : list.ToArray();
        }
    }

}
