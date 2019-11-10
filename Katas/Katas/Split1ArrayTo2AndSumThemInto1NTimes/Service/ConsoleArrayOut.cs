using System;
using System.Collections.Generic;
using System.Text;

namespace Katas.Katas.Split1ArrayTo2AndSumThemInto1NTimes.Service
{
    public static class ConsoleArrayOut
    {
        public static void Start(int[] a)
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("массив равен");
            for(int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i]);
            }
            Console.WriteLine("");
            Console.WriteLine("------------------------");

        }
    }
}
