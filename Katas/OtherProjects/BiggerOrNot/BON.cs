using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Katas.DependencyRegisterAlphabeticalSort.Services;

namespace Katas.BiggerOrNot
{
    public static class BON
    {
        public static void Start()
        {
            Dictionary<char, int> SerialAlphabet = Fulling.FullDictionary();

            Console.WriteLine("Enter the first word");

            string First = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter the second word");

            string Second = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Start Checking...");

            bool check = Checking(First, Second, SerialAlphabet);

            Console.WriteLine($"The result is {check}");

        }

        public static bool Checking(string First, string Second, Dictionary<char, int> ABCDictionary)
        {
            bool IsItNeedToSwap = false;

            char[] FirstChars = First.ToCharArray();
            char[] SecondChars = Second.ToCharArray();

            if (FirstChars.Length > SecondChars.Length)
            {
                for (int i = 0; i < SecondChars.Length; i++)
                {
                    if (ABCDictionary[FirstChars[i]] != ABCDictionary[SecondChars[i]])
                    {
                        if (ABCDictionary[FirstChars[i]] > ABCDictionary[SecondChars[i]])
                        {
                            IsItNeedToSwap = true;
                        }
                        break;
                    }

                }
            }
            else
            {
                for (int i = 0; i < FirstChars.Length; i++)
                {
                    if (ABCDictionary[FirstChars[i]] != ABCDictionary[SecondChars[i]])
                    {
                        if (ABCDictionary[FirstChars[i]] > ABCDictionary[SecondChars[i]])
                        {
                            IsItNeedToSwap = true;
                        }
                        break;
                    }
                }
            }

            return IsItNeedToSwap;
        }

    }
}