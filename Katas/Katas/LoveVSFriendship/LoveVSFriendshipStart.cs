using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Katas.Katas.LoveVSFriendship
{
    public static class LoveVSFriendshipStart
    {
        public static Dictionary<char, int> SerialAlphabet = new Dictionary<char, int>();
       
        public static void Start()
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz";

            char[] abc = alphabet.ToCharArray();

            Console.WriteLine("Заполняем Словарь");

            for (int i = 0; i < 26; i++)
            {
                SerialAlphabet.Add(abc[i],i+1);
            }

            Console.WriteLine("Выводим словарь");

            for (int i = 0; i < 26; i++)
            {

                Console.WriteLine($"буква-{abc[i]}={SerialAlphabet[abc[i]]}");

            }


            Console.WriteLine("Введите строку");

            string enterword = Convert.ToString(Console.ReadLine());

            Console.WriteLine("ты ввел");

            Console.WriteLine(enterword);

            Console.WriteLine("Конвертируем в массив букв");

            char[] wordarray = enterword.ToCharArray();

            int sum = 0;

            Console.WriteLine($"сумма равна{sum}");

            for (int i = 0; i < wordarray.Length; i++)
            {
                
                Console.WriteLine($"буква{wordarray[i]}-{SerialAlphabet[wordarray[i]]}=");
                sum += SerialAlphabet[wordarray[i]];
                Console.WriteLine($"сумма равна{sum}");
            }
            Console.ReadKey();
        }
    }
}
