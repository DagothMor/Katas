using System;
using System.Collections.Generic;
using System.Text;

namespace Katas.Katas._5kyu
{
    public static class FirstVariationOnCaesarCipher
    {
        public static void Start()
        {
            Console.WriteLine("Press any key to start");
            Console.ReadLine();
            Console.WriteLine("Enter the word");
            string Word = Console.ReadLine();
            Console.WriteLine("Enter the number");
            int Number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The ciphered word is");
            Console.WriteLine(ListToString(movingShift(Word,Number)));
            Console.WriteLine("The deciphered word is");
            Console.WriteLine(demovingShift(movingShift(Word,Number),Number));
            Console.WriteLine("Press any key to end");
            Console.ReadLine();
        }
            public static List<string> movingShift(string s, int shift)
            {
                List<string> listout = new List<string>();
                string DictinaryUpCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                string DictinaryDownCase = "abcdefghijklmnopqrstuvwxyz";
                for (int i = 0; i < s.Length; i++)
                {
                    if (char.IsLetter(s[i]))
                    {
                        if (char.IsUpper(s[i])) { listout.Add(ShiftedLetter(ref DictinaryUpCase, s[i], true, shift+i).ToString()); }
                        else { listout.Add(ShiftedLetter(ref DictinaryDownCase, s[i], true, shift+i).ToString()); }
                    }
                    else { listout.Add(s[i].ToString()); }
                }

                listout = PostManGenerator(ListToString(listout),5);
                return listout;
            }
        public static string demovingShift(List<string> s, int shift)
        {
            string DictinaryUpCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string DictinaryDownCase = "abcdefghijklmnopqrstuvwxyz";
            //cicle demoving
            string stringout = ListToString(s);
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < stringout.Length; i++)
            {
                //stringBuilder.Append(ShiftedLetter())
                if (char.IsLetter(stringout[i]))
                {
                    if (char.IsUpper(stringout[i])) { stringBuilder.Append(ShiftedLetter(ref DictinaryUpCase, stringout[i], false, shift + i).ToString()); }
                    else { stringBuilder.Append(ShiftedLetter(ref DictinaryDownCase, stringout[i], false, shift + i).ToString()); }
                }
                else { stringBuilder.Append(stringout[i]); }
            }
            return stringBuilder.ToString();
        }

        public static char ShiftedLetter(ref string alphabet, char letter, bool vector, int shift)
        {
            int i = GetIndex(ref alphabet, letter);
            if (vector == true)
            {
                i += shift;
                while (i >= alphabet.Length)
                {
                    i -= alphabet.Length;
                }

                return alphabet[i];
            }
            i -= shift;
            while (i < 0)
            {
                i += alphabet.Length;
            }
            return alphabet[i];
        }

        public static int GetIndex(ref string word, char letter)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (letter == word[i])
                {
                    return i;
                }
            }
            return 0;
        }

        public static string ListToString(List<string> list)
        {
            StringBuilder stringbuilder = new StringBuilder();
            for (int i = 0; i < list.Count; i++)
            {
                stringbuilder.Append(list[i]);
            }
            return stringbuilder.ToString();
        }

        public static List<string> PostManGenerator(string word, int CountOfPostMans)
        {
            List<string> list = new List<string>();
            int buffer = (int) Math.Ceiling((decimal) (word.Length / CountOfPostMans))+1;
            int last = word.Length - buffer * (CountOfPostMans - 1);
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < CountOfPostMans - 1; i++)
            {
                for (int j = 0; j < buffer; j++)
                {
                    stringBuilder.Append(word[i * buffer + j]);
                }
                list.Add(stringBuilder.ToString());
                stringBuilder.Clear();
            }

            for (int i = word.Length - last; i < word.Length; i++)
            {
                stringBuilder.Append(word[i]);
            }
            list.Add(stringBuilder.ToString());
            DisplayListOfStrings(list);
        return list;
        }
        public static void DisplayListOfStrings(List<string> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"|{list[i]}|{list[i].Length}");
            }
        }
    }
}
