using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace Katas.CreateDictionaryFromTXTFile
{
    public static class createnewdictionaryfromtxtfile
    {
        public static void Start()
        {
            string path = @"C:\kek.txt";
            string stringtext= GetStringFromTXTFile(path);

            
            Console.WriteLine("Done!");
            Console.ReadLine();
        }
        public static int[] Divisors(int n)
        {
            List<int> list = new List<int>();
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0) { list.Add(i); }
            }
            return list.Count == 0 ? null : list.ToArray();
        }
        public static string GetStringFromTXTFile(string path)
        {
            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                string line;
                StringBuilder stringbuilder = new StringBuilder();

                while ((line = sr.ReadLine()) != null)
                {
                    stringbuilder.Append(line);
                    Console.WriteLine(line);
                }

                return stringbuilder.ToString();
            }
            
        }

        public static Dictionary<int, string> GetDictionaryFromString(string stringin)
        {

            return new Dictionary<int, string>();
        }
    }
}
