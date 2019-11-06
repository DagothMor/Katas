using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;
using Katas.Katas.Remove_All_The_Marked_Elements_of_a_List.Services;

namespace Katas.Katas.TidyNumber
{
    public static class TidyNumber
    {
        public static bool Start()
        {
            bool ahtung = false;

            Console.WriteLine("введи число");

            int Number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Ты ввел {Number}");

            string digits = Convert.ToString(Number);

            Console.WriteLine($"преобразовали в строку{digits}");

            char[] chars = digits.ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {
                Console.WriteLine($"{i} цифра - {chars[i]}");
            }

            int[] Array = new int[chars.Length];//nenado

            for (int i = 0; i < chars.Length; i++)
            {
                Array[i] = chars[i];
            }

            for (int i = 0; i < Array.Length-1; i++)
            {
                if (Array[i] > Array[i + 1])
                {
                    ahtung = true;
                    break;
                }
            }
            if (Array[Array.Length - 2] > Array[Array.Length - 1])//убрать
            {
                ahtung = true;
            }
            Console.WriteLine(ahtung);
            return ahtung;
        }
    }
}
