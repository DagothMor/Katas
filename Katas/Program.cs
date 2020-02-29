using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading;
using System.Xml.Schema;
using Katas.Katas._6kyi.ChristmasTree;
using Katas.Katas._6kyi.EqualSidesOfAnArray;
using Katas.Katas.ReversingAndCombiningText;
using Katas.ZipUNZip.Services;


namespace Katas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press any key to start");
            Console.ReadLine();
            //call functions...
            Console.WriteLine("Press any key to end");
            Console.ReadLine();
        }

        public static int[] monkey(int number)
        {
            List<int> list = new List<int>();
            
            for (int i = 0; i <number; i++)
            {
                list.Add(i+1);
            }

            return list.ToArray();
        }
        public static string Interpret(string code)
            {
                string BottlesOfBeer = "";
                for (int i = 99;i> 1; i--)
                {
                    BottlesOfBeer+= $"{i}bottles of beer on the wall, {i} bottles of beer.\nTake one down and pass it around, {i-1} bottles of beer on the wall.";
                }
                BottlesOfBeer += $"1 bottle of beer on the wall, 1 bottle of beer.\nTake one down and pass it around, no more bottles of beer on the wall.\nNo more bottles of beer on the wall, no more bottles of beer.\nGo to the store and buy some more, 99 bottles of beer on the wall.";
                switch (code)
                {
                    case "H": { return "Hello World!"; }
                    case "Q": { return code; }
                    case "9": { return BottlesOfBeer; }
                    default: return null;
                }
            }
        public static string Pattern(int n)
        {
            if (n < 1) { return ""; }
            string stringout = "";
            List<int> list = new List<int>();
            for (int i = n; i > 0; i--)
            {
                list.Add(i);
            }

            while (list.Count != 1)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    stringout += list[i].ToString();
                }
                stringout += "\n";
                list.RemoveAt(list.Count-1);
            }

            stringout += n.ToString();
            return stringout;
        }
        public static double Arithmetic(double a, double b, string op)
        {
            switch (op)
            {
                case "add": return (double)(a + b);
                case "subtract": return (double)(a - b);
                case "multiply": return (double)(a * b);
                default: return (double)(a / b);
            }
        }
        public static bool comp(int[] a, int[] b)
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            for (int i = 0; i < b.Length; i++)
            {
                dictionary.Add(i, 0);
            }
            bool flag = false;
            //int[] check = new int[]{};
            if (a == null || b == null) { return false; }
            //if(a==check||b==check){return false;}
            for (int i = 0; i < a.Length; i++)
            {
                flag = false;
                var asquare = a[i] * a[i];
                for (int j = 0; j < b.Length; j++)
                {
                    if (asquare == b[j])
                    {
                        dictionary[b[i]]++;
                    }
                }
                if (flag == false) { return false; }
            }

            foreach (KeyValuePair<int, int> kvp in dictionary)
            {
                if (kvp.Value == 0)
                {
                    return false;
                }
            }
            return true;
        }
        public static int Potatoes(int p0, int w0, int p1)
        {
            double weightofpotatoes = w0;
            double percentofwaterbefore = p0;
            double percentofwaterafter = p1;
            double weightwaterbefore = (weightofpotatoes * percentofwaterbefore) / 100;
            double weightdrymatter = (weightofpotatoes - weightwaterbefore);
            double weightwaterafter = (((percentofwaterafter * (weightdrymatter)) / (100 - percentofwaterafter)));

            return (int)(weightwaterafter + weightdrymatter);
        }
        public static int HighestRank(int[] arr)
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            List<int> list = new List<int>();
            int key = 0;
            int val = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (dictionary.ContainsKey(arr[i]))
                {
                    dictionary[arr[i]]++;
                }
                else { dictionary.Add(arr[i], 1); }
            }

            foreach (KeyValuePair<int, int> kvp in dictionary)
            {
                if (kvp.Value >= val)
                {
                    val = kvp.Value;

                    list.Add(kvp.Key);
                }
            }

            return list.Max();
        }
        public static long SuperSize(long num)
        {
            List<int> list = num.ToString().ToCharArray().Select(x => int.Parse(x.ToString())).ToList().OrderByDescending(x => x).ToList();
            string stringout = "";
            for (int i = 0; i < list.Count; i++)
            {
                stringout += list[i];
            }
            return Int64.Parse(stringout);
        }
        public static int NoBoringZeros1(int n)
        {
            List<int> list = n.ToString().ToCharArray().ToList().Select(x => int.Parse(x.ToString())).ToList();
            bool flag = false;
            while (flag == false)
            {
                if (list.Last() == 0)
                {
                    list.RemoveAt(list.Last());
                }
                else
                {
                    flag = true;
                }
            }
            string stringin = "";
            for (int i = 0; i < list.Count; i++)
            {
                //stringin += char.Parse(list[i]);

            }
            return Convert.ToInt32(stringin);
        }
        public static int NoBoringZeros2(int n)
        {
            int number = n;
            List<char> listc = new List<char>();
            List<int> list = n.ToString().ToCharArray().Reverse().ToList().Select(x => int.Parse(x.ToString())).ToList();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == 0)
                {
                    list.Remove(i);
                    i--;
                }
                else
                {
                    break;
                }
            }

            List<int> listout = list.ToArray().Reverse().ToList();
            string stringout = "";
            for (int i = 0; i < list.Count; i++)
            {
                stringout += listout[i].ToString();
            }
            return Convert.ToInt32(stringout);
        }
        public static int NoBoringZeros(int n)
        {
            while (n%10==0)
            {
                n /= 10;
            }
            return n;
        }
        public static char AddLetters(char[] letters)
        {
            if (letters.Length<1)
            {
                return 'z';
            }

            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            Dictionary<char, int> dictionary = new Dictionary<char, int>();
            Dictionary<int, char> reverseDictionary = new Dictionary<int, char>();
            int sum = 0;
            for (int i = 0; i < alphabet.Length; i++)
            {
                dictionary.Add(alphabet[i], i + 1);
                reverseDictionary.Add(i + 1, alphabet[i]);
            }
            for (int i = 0; i < letters.Length; i++)
            {
                sum += dictionary[letters[i]];
            }
            while (sum > 26)
            {
                sum -= 26;
            }
            return reverseDictionary[sum];
        }

        public static string ToAlternatingCase(string s)
        {
            string LowerAlphabet = "abcdefghijklmnopqrstuvwxyz";
            string UpAlphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Dictionary<char, char> DictionaryToUp = new Dictionary<char, char>();
            Dictionary<char, char> DictionaryToLower = new Dictionary<char, char>();
            for (int i = 0; i < 26; i++)
            {
                DictionaryToUp.Add(LowerAlphabet[i], UpAlphabet[i]);
                DictionaryToLower.Add(UpAlphabet[i], LowerAlphabet[i]);
            }
            string stringout = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (LowerAlphabet.Contains(s[i]))
                {
                    stringout += DictionaryToUp[s[i]];
                }
                if (UpAlphabet.Contains(s[i]))
                {
                    stringout += DictionaryToLower[s[i]];
                }
                stringout += s[i];
            }

            return stringout;
        }
        public static bool IsLockNessMonster(string sentence)
        {
            List<string> list = new List<string>();
            foreach (string word in list)
            {
                if (sentence.Contains(word))
                {
                    return true;
                }
            }
            return false;
        }
        public static string Shark(
            int pontoonDistance,
            int sharkDistance,
            int yourSpeed,
            int sharkSpeed,
            bool dolphin)
        {
            if (dolphin) { sharkSpeed /= 2; }
            float MyTime = (float)(pontoonDistance / yourSpeed);
            float SharkTime = (float)((sharkDistance + pontoonDistance) / sharkSpeed);
            if (MyTime <= SharkTime) { return "Alive!"; }
            return "Shark Bait!";
        }

        public static List<int> ShiftSerialNumbers(int[] arr)
        {
            List<int> list = arr.ToList();
            List<int> listout = new List<int>();
            int Count = arr.Length;
            if (Count % 2 == 0) {
                for (int i = 0; i <Count-1; i++)
                {
                    listout.Add(list[i+1]);
                    listout.Add(list[i]);
                    i++;
                }
            }
            else {
                for (int i = 0; i < Count-2; i++)
                {
                    listout.Add(list[i + 1]);
                    listout.Add(list[i]);
                    i++;
                }
                listout.Add(list[list.Count]);
            }
            
            
            return list;
        }
    }
}
