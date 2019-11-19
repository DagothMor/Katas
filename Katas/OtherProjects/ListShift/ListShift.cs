using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Katas.Katas.ArrayShift;
using Katas.Katas.Remove_All_The_Marked_Elements_of_a_List.Services;

namespace Katas.Katas.ListShift
{
    public static class ListShift
    {
        public static void Start()
        {
            int b;
            List<int> list = AddIntegerArray.Add().ToList();
            Console.WriteLine("куда хотим сдвинуть 1-направо;2-влево");
            if (Convert.ToInt32(Console.ReadLine()) == 1)
            {
                Console.WriteLine("на сколько?");

                b = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < b; i++)
                {
                    list = ShiftList.Right(list);
                }
                for (int i = 0; i < list.Count; i++)
                {
                    Console.Write(list[i]);
                }
            }
            else
            {
                Console.WriteLine("на сколько?");

                b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("сдвигаем влево");
                for (int i = 0; i < b; i++)
                {
                    list = ShiftList.Left(list);
                }
                for (int i = 0; i < list.Count; i++)
                {
                    Console.Write(list[i]);
                }
            }
        }
    }
}
