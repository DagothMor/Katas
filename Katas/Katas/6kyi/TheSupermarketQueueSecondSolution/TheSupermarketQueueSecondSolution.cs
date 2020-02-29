using System;
using System.Collections.Generic;
using System.Text;
using Katas.Katas._6kyi.TheSupermarketQueueSecondSolution.Services;
using Katas.Katas.Remove_All_The_Marked_Elements_of_a_List.Services;

namespace Katas.Katas._6kyi.TheSupermarketQueueSecondSolution
{
    public static class TheSupermarketQueueSecondSolution
    {
        public static void Start()
        {
            Console.WriteLine("Enter the served queue");

            int[] ArrayOfCustomers = AddIntegerArray.Add();

            Console.WriteLine("Enter the count of self-checkout tills");

            int CountOfTills = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Starting compute the time");

            int time = ComputingTime.StartComputing(ArrayOfCustomers, CountOfTills);

            Console.ReadLine();
        }
    }
}
