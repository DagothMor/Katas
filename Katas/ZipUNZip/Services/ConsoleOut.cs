using System;
using System.Collections.Generic;
using System.Text;

namespace Katas.ZipUNZip.Services
{
    public static class ConsoleOut
    {
        public static void Dictionary(Dictionary<char,int> Dictionary)
        {
            foreach (KeyValuePair<char,int> entry in Dictionary)
            {
                Console.Write($"{entry.Value}");
                Console.Write($"=");
                Console.Write($"{entry.Key}");
                Console.WriteLine($"");
                Console.WriteLine("----------------");
            }
        }

        public static void List<T>(List<T> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"{i}={list[i]}");
                Console.WriteLine("--------");
            }
        }
    }
}
