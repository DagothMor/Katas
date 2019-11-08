using System;
using System.Collections.Generic;
using System.Text;

namespace Katas.Katas.The_Supermarket_Queue.Services
{
    public static class CheckCustomers
    {
        public static List<int> Check(List<int> customers)
        {
            Console.WriteLine("Проверяем на наличие неположительных чисел в массиве");
            for (int i = 0; i < customers.Count; i++)
            {
                if (customers[i] <= 0)
                {
                    Console.WriteLine("удаляем"+customers[i]);
                    customers.RemoveAt(i);
                    i--;
                }
            }
            return customers;
        }
    }
}
