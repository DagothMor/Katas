using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Katas.ZipUNZip.Services;

namespace Katas.Katas._6kyu.IsPangram
{
    public static class IsItPangram
    {
        public static void Start()
        {
            Console.WriteLine("");
            Console.ReadLine();
            bool answer = IsPangram("The quick brown fox jumps over the lazy dog.");
            Console.WriteLine("");
            Console.ReadLine();
        }

        public static bool IsPangram(string str)
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            List<char> alphabetlist = new List<char>();
            for (int i = 0; i < alphabet.Length; i++)
            {

              
                alphabetlist.Add(alphabet[i]);
            }
            List<char> listin = new List<char>();
            string inputword = str.ToLower();
           
            for (int i = 0; i < str.Length; i++)
            {
                if (!ListContainsLetter(listin, inputword[i]))
                {
                    listin.Add(inputword[i]);
                }
            }
            listin.Sort();
            for (int i = 0; i < alphabetlist.Count; i++)
            {
                if (!ListContainsLetter(listin, alphabetlist[i]))
                {
                    return false;
                }
            }
            return true;
        }

        public static bool ListContainsLetter(List<char> list,char letter)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == letter)
                {
                    return true;
                }

            }
            return false;
        }
    }
}
