using System;
using System.Collections.Generic;
using System.Text;


namespace Katas.Katas._3kyu
{
    public static class RailFenceCipher
    {
        public static string Encode(string word, int n)
        {
            List<char>[] lists = new List<char>[n];
            for (int i = 0; i < n; i++)
            {
                lists[i] = new List<char>();
            }
            List<int> IndexesLists = ListGenerator.Generate(n);
            string stringout = "";
            int point = 0;
            for (int i = 0; i < word.Length; i++)
            {
                lists[IndexesLists[point]].Add(word[i]);
                ListGenerator.NextIndex(IndexesLists, ref point);
            }
            for (int i = 0; i < lists.Length; i++)
            {
                stringout += ListGenerator.GetStringFromList(lists[i]);
            }
            return stringout;
        }
        public static string Decode(string word, int n)
        {
            List<char>[] lists = new List<char>[n];
            for (int i = 0; i < n; i++)
            {
                lists[i] = new List<char>();
            }
            List<int> IndexesLists = ListGenerator.Generate(n);
            int point = 0;
            for (int i = 0; i < word.Length; i++)
            {
                lists[IndexesLists[point]].Add(word[i]);
                
                ListGenerator.NextIndex(IndexesLists, ref point);
            }
            int wordindex = 0;
            for (int i = 0; i <lists.Length; i++)
            {
                for (int j = 0; j < lists[i].Count; j++)
                {
                    lists[i][j] = word[wordindex];
                    wordindex++;
                }
            }
            string stringout = "";
            point = 0;
            for (int i = 0; i < word.Length; i++)
            {
                stringout += lists[IndexesLists[point]][0];
                lists[IndexesLists[point]].RemoveAt(0);
                ListGenerator.NextIndex(IndexesLists, ref point);
            }
            return stringout;
        }

    }
    public static class ListGenerator
    {

        public static List<int> Generate(int Number)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < Number; i++)
            {
                list.Add(i);
            }
            for (int i = Number - 2; i > 0; i--)
            {
                list.Add(i);
            }
            return list;
        }
        public static void NextIndex(List<int> listin, ref int point)
        {
            if (point + 1 == listin.Count) point = 0;
            else { point += 1; }
        }

        public static string GetStringFromList(List<char> listin)
        {
            string stringout = "";
            foreach (char letter in listin)
            {
                stringout += letter;
            }
            return stringout;
        }
    }



}
