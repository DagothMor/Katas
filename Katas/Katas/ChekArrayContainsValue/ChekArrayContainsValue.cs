using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;


namespace Katas.Katas.ChekArrayContainsValue
{
    public static class ChekArrayContainsValue
    {
        public static void start()
        {
            Console.WriteLine("введи искомую переменную");
            var x=Console.ReadLine();
            int n;
            bool Check = false;

            Console.WriteLine("введи колво элементов");

            n = Convert.ToInt32(Console.ReadLine());

            object[] obj = new object[n];

            for (int i = 0; i != n; i++)
            {
                Console.WriteLine($"Введи значение {i}ого элемента");
                obj[i] =Console.ReadLine();
            }
            for (int i = 0; i != n; i++)
            {
                Console.WriteLine($"значение {i}ого элемента равно {obj[i]}");
            }
            foreach (var V in obj)
            {
                if (V.Equals(x))
                {
                    Check = true;
                }
            }
            Console.WriteLine(Check);
        }
    }
}
