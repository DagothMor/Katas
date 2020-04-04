using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Katas.Katas._8katas.ConvertAStringToAnArray
{
    public static class ConvertAStringToAnArray
    {
        public static void Start()
        {
            Console.WriteLine("enter the string");
            string enterwords = Convert.ToString(Console.ReadLine());

            List<string> StringList = new List<string>();
            string word = "";
            List<char> Letters = enterwords.ToCharArray().ToList();
            for (int i = 0; i < Letters.Count; i++)
            {
                if (Letters[i] == ' ')
                {
                    StringList.Add(word);
                    word = "";
                }
                else { word += Letters[i].ToString(); }
            }
            StringList.Add(word);

            Console.ReadLine();



        }
    }
}
