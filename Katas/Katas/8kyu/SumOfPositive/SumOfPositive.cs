using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Katas.Katas._8katas.SumOfPositive
{
    public static class SumOfPositive
    {
        public static void Start()
        {
            int[] arr = new[] { 3, 2, 1, 3 };
            List<int> list = arr.ToList();
            var sum = arr.Where(x=>x>0).Sum();
        }
    }
}
