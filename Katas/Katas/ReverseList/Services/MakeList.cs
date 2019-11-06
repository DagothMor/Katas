using System;
using System.Collections.Generic;
using System.Text;

namespace Katas.Katas.ReverseList.Services
{
    public static class MakeList
    {
        public static List<int> Make()
        {
            List<int> list = new List<int>();

            int n;
            Console.WriteLine("Создаем список");

            Console.WriteLine("Введите количество элементов");

            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i != n; i++)
            {
                Console.WriteLine($"Введи значение {i} ого элемента");
                list.Add(Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine($"элемент {i}ого элемента равен {list[i]}");
            }

            return list;
        }
    }
}
