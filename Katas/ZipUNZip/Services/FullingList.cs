using System;
using System.Collections.Generic;
using System.Text;

namespace Katas.ZipUNZip.Services
{
    public static class FullingList
    {
        public static void Start() { }

        public static List<int> ValuesList(Dictionary<char,int> dictionary)
        {
            List<int> valuesList = new List<int>();

            foreach (KeyValuePair<char,int> entry in dictionary)
            {
                valuesList.Add(entry.Value);
            }
            return valuesList;


        } 
    }
}
