using System;
using System.Collections.Generic;
using System.Text;
using Katas.Katas.The_Supermarket_Queue.Services;
using Katas.ZipUNZip.Services;

namespace Katas.ZipUNZip
{
    public static class ZipUNZip
    {
        public static void Start()
        {
            Console.WriteLine("Enter the string");
            string stringin = Convert.ToString(Console.ReadLine());
            Console.WriteLine($"You entered:{stringin}");
            char[] lettersin = stringin.ToCharArray();
            Dictionary<char, int> CountLetters = Services.CountLetters.Count(lettersin);
            ConsoleOut.Dictionary(CountLetters);
            Console.ReadLine();
            int CountofKeys = CountLetters.Count;
            List<string> BinaryList = BinaryListMaker.ListMaker(CountofKeys);
            ConsoleOut.List(BinaryList);
            List<int> valueslist = FullingList.ValuesList(CountLetters);
            valueslist.Sort();
            valueslist.Reverse();
            ConsoleOut.List(valueslist);
            Console.ReadLine();
            //переделать генератор листкода
        }
    }
}
