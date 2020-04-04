using Katas.Katas.Remove_All_The_Marked_Elements_of_a_List.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Katas.Katas.The_Supermarket_Queue.Services;

namespace Katas.Katas.The_Supermarket_Queue
{
    public static class TheSupermarketQueue
    {
        public static void Start()
        {
            int time = 0;
            List<int> Customers = AddIntegerArray.Add().ToList();

            Customers = CheckCustomers.Check(Customers);

            Console.WriteLine("обработанный список равен");

            Console.WriteLine("--------");

            for (int i = 0; i < Customers.Count; i++)
            {
                Console.Write(Customers[i]);
            }
            Console.WriteLine("");
            Console.WriteLine("-------");

            int NumberOfTills = Convert.ToInt32(Console.ReadLine());

            int[] Tills = new int[NumberOfTills];

            Console.ReadKey();
            do
            {
                Console.WriteLine("Заполняем/проверяем кассы");
                for (int i=0;i<Tills.Length;i++){
                    if(Tills[i] == 0)
                    {
                        Console.WriteLine(Tills[i]+" касса равна нулю");
                        if (Customers.Count != 0)
                        {
                            Tills[i] = Customers[0];
                            Customers.RemoveAt(0);

                        }
                    }
                }
                for(int i = 0; i < Tills.Length; i++)
                {
                    if (Tills[i] > 0) { Tills[i] -= 1; }
                   
                }
                ConsoleOutList.Out(Customers,Tills);
                time++;
            }
            while (Customers.Count!=0|Tills.Sum()!=0);//пока условие истинно;
            Console.WriteLine("Количество времени равно");
            Console.WriteLine(time);
            Console.ReadKey();
        }
    }
}
