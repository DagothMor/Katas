using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Katas.ZipUNZip.Services
{
    public static class BinaryListMaker
    {
        public static void Start()
        {
            Console.WriteLine("Enter the length of massive elements");
            int n = Convert.ToInt32(Console.ReadLine());
            List<string> CookedList = ListMaker(n);
            for (int i = 0; i < CookedList.Count; i++)
            {
                Console.WriteLine("-----");
                Console.WriteLine($"{i}={CookedList[i]}");
            }
            Console.ReadLine();
        }

        public static List<string> ListMaker(int N)
        {
            List<string> BinaryCodeList = new List<string>() { "0" };

            for (int i = 0; i < N - 1; i++) { BinaryCodeList.Add(AddBinaryCodeCreator(BinaryCodeList.Last()));}

            return BinaryCodeList;
        }

        public static string AddBinaryCodeCreator(string lastcode)
        {
            char[] lastcharcode = lastcode.ToCharArray();
            for (int i = lastcharcode.Length; i > 0; i--)
            {
                if (lastcharcode[i - 1] == '0')
                {
                    lastcharcode[i - 1] = '1';
                    return CharsToString(lastcharcode);
                    
                }
            }

            string newstring = "";
            for (int i = 0; i < lastcode.Length+1; i++)
            {
                newstring += "0";}
            return newstring;
        }

        public static string CharsToString(char[] chars)
        {
            string stringout = "";
            for (int i = 0; i < chars.Length; i++)
            {
                stringout += chars[i].ToString();
            }

            return stringout;
        }
    }
}
