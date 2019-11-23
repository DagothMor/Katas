using System;
using System.Collections.Generic;
using System.Text;

namespace Katas.ZipUNZip.Services
{
    public static class FullingDictionary
    {
        public static void Start() { }

        public static Dictionary<char, int> StartFull(Dictionary<char, int> dictionary, List<string> listcode,List<int> listvalues)
        {
            Dictionary<char,int> dictionaryout = new Dictionary<char, int>();

            for (int i = 0; i < listcode.Count; i++)
            {
                //dictionaryout.Add(dictionary(listvalues[i],listcode[i]));
            }


            return dictionaryout;

        }
    }
}
