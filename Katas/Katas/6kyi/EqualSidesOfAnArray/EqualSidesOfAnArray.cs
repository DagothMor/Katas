using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Katas.Katas.Remove_All_The_Marked_Elements_of_a_List.Services;

namespace Katas.Katas._6kyi.EqualSidesOfAnArray
{
    public static class EqualSidesOfAnArray
    {
        public static void Start()
        {
            Console.WriteLine("Enter to start");
            Console.ReadLine();
            int[] array = AddIntegerArray.Add();
            Console.WriteLine("We entered the array");
            List<int> list = array.ToList();
            for (int i = 0; i < array.Length; i++)
            {
                if (list.GetRange(0,i).Sum() == list.GetRange(i,list.Count-i).Sum())
                {

                }
               


            }

        }
    }
}
