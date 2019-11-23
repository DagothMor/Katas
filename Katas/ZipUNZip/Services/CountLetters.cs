using System;
using System.Collections.Generic;
using System.Text;

namespace Katas.ZipUNZip.Services
{
    public static class CountLetters
    {
        public static  Dictionary<char, int> Count(char[] charIn)
        {
            Dictionary<char,int> CountDictionary = new Dictionary<char, int>();

            for (int i = 0; i < charIn.Length; i++)
            {
                if (CountDictionary.ContainsKey(charIn[i]))
                {

                    CountDictionary[charIn[i]]++;
                }
                else
                {
                    CountDictionary.Add(charIn[i], 1);
                }
            }
            return CountDictionary;
        }
    }
}
