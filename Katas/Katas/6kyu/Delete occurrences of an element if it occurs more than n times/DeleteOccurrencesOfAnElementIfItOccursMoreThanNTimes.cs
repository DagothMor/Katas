using System;
using System.Collections.Generic;
using System.Text;
using Katas.Katas._6kyi.Delete_occurrences_of_an_element_if_it_occurs_more_than_n_times.Services;
using Katas.Katas.Remove_All_The_Marked_Elements_of_a_List.Services;
using Katas.Katas.The_Supermarket_Queue.Services;

namespace Katas.Katas._6kyi.Delete_occurrences_of_an_element_if_it_occurs_more_than_n_times
{
    public static class DeleteOccurrencesOfAnElementIfItOccursMoreThanNTimes
    {
        public static void Start()
        {
            Console.WriteLine("Создаем нужный массив");
            int[] Array = AddIntegerArray.Add();

            Console.WriteLine("Создаем список содержащий элементы массива в одинарном количестве");

            List<int> ListVar = ListVarMake.Start(Array);

            for (int i = 0; i < ListVar.Count; i++)
            {
                Console.Write(ListVar[i]);
                Console.Write("");
            }

            Console.WriteLine("Введи количество повторов");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Заполняем пустой лист");

            List<int> ListCheck = new List<int>();

            for (int i = 0; i < ListVar.Count; i++)
            {
                ListCheck.Add(0);
                Console.Write(ListCheck[i]);
                Console.Write("");
            }

            Console.ReadLine();

            List<int> ListNew = ListCheckOut.Start(ListVar, ListCheck, Array, n);

            for (int i = 0; i < ListNew.Count; i++)
            {
                Console.Write(ListNew[i]);
                Console.Write("");
            }
        }

    }
}
