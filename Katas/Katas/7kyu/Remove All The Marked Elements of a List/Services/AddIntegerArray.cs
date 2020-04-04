using System;
using System.Collections.Generic;
using System.Text;

namespace Katas.Katas.Remove_All_The_Marked_Elements_of_a_List.Services
{
    class AddIntegerArray
    {
        public static int[] Add()
        {
            int n;

            Console.WriteLine("введи колво элементов");

            n = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[n];

            for (int i = 0; i != n; i++)
            {
                Console.WriteLine($"Введи значение {i}ого элемента");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i != n; i++)
            {
                Console.WriteLine($"значение {i}ого элемента равно {array[i]}");
            }

            return array;
        }
    }
}
