using Katas.Katas.Remove_All_The_Marked_Elements_of_a_List.Services;
using Katas.Katas.Split1ArrayTo2AndSumThemInto1NTimes.Service;
using System;
using System.Collections.Generic;
using System.Text;


namespace Katas.Katas.Split1ArrayTo2AndSumThemInto1NTimes
{
    public static class SplitAndSum
    {
        public static void Start()
        {
            int[] GettedArray = AddIntegerArray.Add();

            Console.WriteLine("Введи количество шагов");
            int TaskSteps = Convert.ToInt32(Console.ReadLine());

            int TotalSteps = 0;

            while (TotalSteps != TaskSteps && GettedArray.Length != 1)
            {
                double divcount = GettedArray.Length / 2;

                int nFloor = Convert.ToInt32(Math.Floor(divcount));

                Console.WriteLine("1 массив будет иметь вот столько элементов ");
                Console.WriteLine(nFloor);
                Console.ReadLine();

                int[] arrayA = new int[nFloor];

                //Console.WriteLine("А");
                //ConsoleArrayOut.Start(arrayA);

                List<int> listB = new List<int>();

                //int[] arrayB = new int[GettedArray.Length - nFloor];

                //Console.WriteLine("В");
                //ConsoleArrayOut.Start(arrayB);

                for (int i = 0; i < nFloor; i++) { arrayA[i] = GettedArray[i]; }

                Console.WriteLine("А");
                ConsoleArrayOut.Start(arrayA);


                for (int i = nFloor; i < GettedArray.Length; i++) { listB.Add(GettedArray[i]); }

                int[] arrayB = listB.ToArray();
                Console.WriteLine("В");
                ConsoleArrayOut.Start(arrayB);

                for (int i = 0; i < arrayA.Length; i++) { arrayB[arrayB.Length - 1 - i] += arrayA[arrayA.Length - 1 - i]; }

                Console.WriteLine("Сложили оба массива");
                Console.WriteLine("В");
                ConsoleArrayOut.Start(arrayB);

                GettedArray = arrayB;
                TotalSteps++;
            }

            Console.WriteLine("Цикл закончился");
            Console.ReadLine();
        }
    }
}
