using System;
using System.Collections.Generic;
using System.Text;

namespace Katas.DependencyRegisterAlphabeticalSort.Services
{
    public static class AddStringArray
    {
        public static string[] Add()
        {
            List<string> listr = new List<string>();


            Console.WriteLine("Введи количество слов");

            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Введи слово номе {i}");
                listr.Add(Convert.ToString(Console.ReadLine()));
            }
            for(int i = 0; i < listr.Count; i++) { Console.WriteLine($"{i}слово={listr[i]}");}

            return listr.ToArray();
        }
    }
}
