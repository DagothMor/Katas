using System;
using System.Collections.Generic;
using System.Text;

namespace Katas.Katas.The_Supermarket_Queue.Services
{
    public static class ConsoleOutList
    {
        public static void Out(List<int> list,int[] tills)
        {
            Console.WriteLine("");
            Console.WriteLine("--------");
            Console.WriteLine("");
            for (int i = 0; i < tills.Length; i++)
            {
                Console.Write("[");
                Console.Write(tills[i]);
                Console.Write("]");
                Console.Write("||");
            }

            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i]);
            }
            Console.WriteLine("");
            Console.WriteLine("--------");
            Console.WriteLine("");
        }
    }
}
