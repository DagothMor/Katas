using System;
using System.Collections.Generic;
using System.Text;
using Katas.Katas.Remove_All_The_Marked_Elements_of_a_List.Services;

namespace Katas.Katas.Remove_All_The_Marked_Elements_of_a_List
{
    public static class RemoveAllMarkedElementsOfAList
    {
        public static void start()
        {
            int[] IntegerList = AddIntegerArray.Add();
            int[] ValuesList = AddIntegerArray.Add();

            int[] CheckedList = ChekAndRemoveElements.ChekAndRemove(IntegerList, ValuesList);

            for (int i = 0; i != CheckedList.Length; i++)
            {
                Console.WriteLine($"значение {i}ого элемента равно {CheckedList[i]}");
            }
        }
    }
}
