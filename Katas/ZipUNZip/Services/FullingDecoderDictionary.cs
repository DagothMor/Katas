using System;
using System.Collections.Generic;
using System.Text;

namespace Katas.ZipUNZip.Services
{
    public static class FullingDecoderDictionary
    {
        public static Dictionary<string, string> Full(List<char> list)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();

            string key;
            string value="";


            for (int i = 0; i < list.Count; i++)
            {
                key = list[i].ToString();
                i++;
                i++;
                while (list[i] != ';')
                {
                    value += list[i];
                    i++;
                }
                dictionary.Add(key,value);
                value = "";
            }


            return dictionary;
        }
    }
}
