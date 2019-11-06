using System;
using System.Collections.Generic;
using System.Text;
using Katas.Katas.Remove_All_The_Marked_Elements_of_a_List.Services;

namespace Katas.Katas.ArrayShift
{
    public static class ArrayShift
    {
        public static void Start()
        {
            int b;
            int[] arrayA = AddIntegerArray.Add();
            Console.WriteLine("куда хотим сдвинуть 1-направо;2-влево");
            if (Convert.ToInt32(Console.ReadLine()) == 1)
            {
                Console.WriteLine("на сколько?");

                b = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < b; i++)
                {
                    arrayA = ShiftArray.Right(arrayA);
                }
                for (int i = 0; i < arrayA.Length; i++)
                {
                    Console.Write(arrayA[i]);
                }
            }
            else
            {
                Console.WriteLine("на сколько?");

                b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("сдвигаем влево");
                for (int i = 0; i < b; i++)
                {
                    arrayA = ShiftArray.Left(arrayA);
                }
                for (int i = 0; i < arrayA.Length; i++)
                {
                    Console.Write(arrayA[i]);
                }
            }
        }
    }
}
