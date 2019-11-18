using System;
using System.Collections.Generic;
using System.Text;

namespace Katas.MakeStringArray
{
    public static class MakeStringArray
    {
        public static string[] Make()
        {
            Console.WriteLine("Enter the count of array");
            int n = Convert.ToInt32(Console.ReadLine());
            string[] ArrayOfStrings = new string[n];

            for (int i = 0; i < ArrayOfStrings.Length; i++)
            {
                Console.WriteLine($"Enter the word of {i} element");
                ArrayOfStrings[i] = Convert.ToString(Console.ReadLine());
            }
            Console.WriteLine("");
            for (int i =0;i<ArrayOfStrings.Length;i++) {Console.WriteLine($"[{i}]={ArrayOfStrings[i]}"); }
            return ArrayOfStrings;
        }
    }
}
