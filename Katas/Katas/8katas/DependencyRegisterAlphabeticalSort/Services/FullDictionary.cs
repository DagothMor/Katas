using System;
using System.Collections.Generic;
using System.Text;

namespace Katas.DependencyRegisterAlphabeticalSort.Services
{
    public static class Fulling
    {
        public static Dictionary<char, int> FullDictionary()
        {
            Dictionary<char, int> SerialAlphaBet = new Dictionary<char, int>();
            string alphabet = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz";

            char[] abc = alphabet.ToCharArray();

            Console.WriteLine("Заполняем Словарь");

            for (int i = 0; i < 52; i++)
            {
                SerialAlphaBet.Add(abc[i], i);
            }

            Console.WriteLine("Выводим словарь");

            for (int i = 0; i < 52; i++)
            {

                Console.WriteLine($"буква-{abc[i]}={SerialAlphaBet[abc[i]]}");

            }
            return SerialAlphaBet;
        }
    }
}
