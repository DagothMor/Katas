using System;
using System.Collections.Generic;
using System.Text;

namespace Katas.Katas._6kyu.ReversingAProcess
{
    public static class reversingaprocess
    {
        public static string Encode(string word,int encoding)
        {

            return " ";
        }
        public static Dictionary<char, int> DictionaryAlphaBetIndexGenerator()
        {
            Dictionary<char,int> dictionary = new Dictionary<char, int>();
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            for (int i = 0; i < alphabet.Length; i++)
            {
                dictionary.Add(alphabet[i],i);
            }
            return dictionary;
        }
    }
    
}
