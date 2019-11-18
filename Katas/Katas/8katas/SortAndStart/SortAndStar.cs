using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Katas.Katas._8katas.SortAndStart
{
    public static class SortAndStar
    {
        public static void Start()
        {
            ///определили полученный массив слов
            string[] str = MakeStringArray.MakeStringArray.Make();
            Console.ReadLine();
            ///тут мы должны отсортировать его в алфавитном порядке
            List<string> listold = str.ToList();
            List<string> list = listold.OrderBy(x=>x[0]).ThenBy(y=>y.Length).ToList();
            for (int i = 0; i < list.Count; i++) { Console.WriteLine(list[i]); }

            string word = list.First();

            List<char> retword = new List<char>();
            for (int i = 0; i < word.Length - 1; i++)
            {
                retword.Add(word[i]);
                retword.Add('*');
                retword.Add('*');
                retword.Add('*');
            }

            retword.Add(word[word.Length - 1]);

            string toadd = "";

            for (int i = 0; i < retword.Count; i++)
            {
                toadd += retword[i]; }

            Console.ReadLine();
        }

        public static string[] sortByAlphabet(string inarray)
        {
            string[] strout = new string[]{};



            return strout;
        }
    }
    
}
