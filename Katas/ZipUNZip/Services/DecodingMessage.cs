using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Katas.ZipUNZip.Services
{
    public static class DecodingMessage
    {
        public static string Decode(Dictionary<string, string> dictionarycode, string BinaryCode)
        {
            Dictionary<string, string> backUpDictionary = dictionarycode;
            List<char> binarycode = BinaryCode.ToCharArray().ToList();
            Dictionary<string,string> workList = dictionarycode;
            string workfield = "";
            string stringout = "";
            while (binarycode.Count>0)
            {
                workfield+=binarycode[0].ToString();
                binarycode.RemoveAt(0);
                foreach (KeyValuePair<string,string> entry in workList)
                {
                    if (entry.Value == workfield)
                    {
                        stringout += entry.Key;
                        workfield="";
                    }
                }
            }
            return stringout;
        }

        /*
        public static List<Dictionary<string, string>> FullingWorkList(Dictionary<string, string> dict)
        {
            List<Dictionary<string, string>> listout = new List<Dictionary<string, string>>();
            foreach (KeyValuePair<string,string> entry in dict)
            {
                listout.Add(dict);
            }

        }*/
    }
}
