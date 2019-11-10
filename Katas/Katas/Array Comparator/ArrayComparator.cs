using Katas.Katas.Remove_All_The_Marked_Elements_of_a_List.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Katas.Katas.Array_Comparator
{
    public static class ArrayComparator
    {
        public static void Start()
        {
            int[] arrayA = AddIntegerArray.Add();

            int[] arrayB = AddIntegerArray.Add();

            int n = 0;

            foreach(int A in arrayA)
            {
                foreach(int B in arrayB)
                {
                    if (A == B)
                    {
                        n++;
                    }

                }
            }

            Console.WriteLine("колво одинаковых элементов равно");
            Console.WriteLine(n);
        }
    }
}
