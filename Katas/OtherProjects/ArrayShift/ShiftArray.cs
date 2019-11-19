using System;
using System.Collections.Generic;
using System.Text;

namespace Katas.Katas.ArrayShift
{
    public static class ShiftArray
    {
        public static int[] Right(int[] array)
        {

            int b = array.Length;

            int[] newarray = new int[b];
            
            newarray[0] = array[b-1];

            newarray[b - 1] = array[b - 2];

            for (int i = 1; i < b-1; i++)
            {
                newarray[i] = array[i-1];
            }

            return newarray;
        }

        public static int[] Left(int[] array)
        {

            int[] newArray = new int[array.Length];

            newArray[newArray.Length-1] = array[0];

            newArray[0] = array[1];

            for (int i = 1; i < array.Length-1; i++)
            {

                newArray[i] = array[i + 1];

            }

            return newArray;
        }
    }
}
