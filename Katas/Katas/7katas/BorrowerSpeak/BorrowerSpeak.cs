using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Katas.Katas._7katas.BorrowerSpeak
{
    public static class BorrowerSpeak
    {
        public static void Start()
        {
            string _UpCaseLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            char[] UpCaseLetters = _UpCaseLetters.ToCharArray();

            string _AccessLetters = "abcdefghijklmnopqrstuvwxyz";

            char[] AccessLetters = _AccessLetters.ToCharArray();

            // string _Symbols = " 12345567890!@#$%^&*()_+-=";

            //char[] Symbols = _Symbols.ToCharArray();

            Console.WriteLine("Enter the letters");

            char[] letters = Convert.ToString(Console.ReadLine()).ToCharArray();

            List<char> list = new List<char>();

            Dictionary<int,char> DictionaryUpCaseLetters = new Dictionary<int,char>();
            Dictionary<int, char> DictionaryAccessLetters = new Dictionary<int, char>();

            for (int i = 0; i < UpCaseLetters.Length; i++)
            {
                DictionaryUpCaseLetters.Add(i,UpCaseLetters[i]);
            }

            for (int i = 0; i < AccessLetters.Length; i++)
            {
                DictionaryAccessLetters.Add(i, AccessLetters[i]);
            }

            for (int i = 0; i < letters.Length; i++)
            {
                if (AccessLetters.Contains(letters[i]))
                {
                    list.Add(letters[i]);
                }
                else
                {
                    if (UpCaseLetters.Contains(letters[i]))
                    {
                        list.Add(Char.ToLower(letters[i]));
                    }
                }
            }
            string stringout = "";
            for (int i = 0; i < list.Count; i++)
            {
                stringout += list[i].ToString();
            }
            Console.WriteLine(stringout);
            Console.ReadLine();
        }
    }
}


        




